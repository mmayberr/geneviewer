using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SeniorProject
{
    public class Sequence
    {
        public struct feature
        {
            public feature(string n, int x, int y)
            {
                this.name = n;
                this.start = x;
                this.end = y;
                this.notes = "";
            }
            public feature(string n, int x, int y, string str)
            {
                this.name = n;
                this.start = x;
                this.end = y;
                this.notes = str;
            }

            public string name;
            public int start;
            public int end;
            public string notes;
        }

        public List<feature> featurelist = new List<feature>();

        public Sequence()
        {
            // input default sequence
            setSEQ("ACGAATCGATGGGGTAACTCTCTCTTTAACGGGGCTAGCGTACGTACAACGTAGCTCGTAGCTCGTAGCATGTACGGCTAGTATTCGGCTAGCCCACGCAACV");
            setAccession("Default");
        }
        public Sequence(XmlTextReader xreader)
        {
            string thisName = "";
            bool addVal = false;
            featurelist.Clear();
            feature newFeat = new feature();
            while (xreader.Read())
            {
                switch (xreader.NodeType)
                {
                    case XmlNodeType.Element:
                        thisName = xreader.Name;
                        break;

                    case XmlNodeType.Text:
                        switch (thisName)
                        {
                            case "GBFeature_key":
                                string featName = xreader.Value.Replace('_', ' ');
                                List<Sequence.feature> results = featurelist.FindAll(x => x.name.Contains(featName));
                                newFeat.notes = "";
                                if (results.Count != 0)
                                {
                                    newFeat.name = featName + "(" + results.Count + ")";
                                    break;
                                }
                                newFeat.name = featName;
                                break;

                            case "GBInterval_from":
                                newFeat.start = Int32.Parse(xreader.Value);
                                break;

                            case "GBInterval_to":
                                newFeat.end = Int32.Parse(xreader.Value);
                                break;

                            case "GBSeq_strandedness":
                                stranded = xreader.Value;
                                break;

                            case "GBSeq_moltype":
                                moltype = xreader.Value;
                                break;

                            case "GBSeq_topology":
                                topology = xreader.Value;
                                break;

                            case "GBSeq_definition":
                                def = xreader.Value;
                                break;

                            case "GBReference_pubmed":
                                if(abrID == null) abrID = xreader.Value;
                                break;

                            case "GBSeq_organism":
                                organism = xreader.Value;
                                break;

                            case "GBSeq_sequence":
                                setSEQ(xreader.Value);
                                break;

                            case "GBSeq_primary-accession":
                                setAccession(xreader.Value);
                                break;

                            case "GBQualifier_name":
                                if (xreader.Value == "gene")
                                {
                                    addVal = true;
                                    newFeat.notes += "-> From gene ";
                                }
                                else if (xreader.Value == "product")
                                {
                                    addVal = true;
                                    newFeat.notes += "-> This codes for ";
                                } else if (xreader.Value == "regulatory_class") {
                                    addVal = true;
                                    newFeat.notes += "-> Type of regulation: ";
                                } else if (xreader.Value == "note") {
                                    addVal = true;
                                    newFeat.notes += "-> ";
                                }
                                break;

                            case "GBQualifier_value":
                                if (addVal)
                                {
                                    newFeat.notes += xreader.Value.Replace('_', ' ') + "\r\n";
                                    addVal = false;
                                }
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine(xreader.Value);
                        break;

                    case XmlNodeType.EndElement:
                        if (xreader.Name == "GBFeature")
                        {
                            if (newFeat.name == "source") { break; }
                            featurelist.Add(newFeat);
                        }
                        break;

                    default:
                        break;
                }
            }
        }
        public void setSEQ(string newSEQ)
        {
            int incorrect = newSEQ.ToUpper().Count(n => ("ACGTURYSWKMBDHVN".Contains('n')) == true);
            if ( incorrect != 0)
            {
                throw new System.ArgumentException("Invalid sequence");
            }
            bool isRNA;
            if (moltype == null) isRNA = false;
            else isRNA = moltype.ToLower().Contains("rna");
            SEQ = ( isRNA ) ? newSEQ.ToUpper().Replace('T','U') : newSEQ.ToUpper();
        }
        public string getSEQ()
        {
            return SEQ;
        }
        public void setAccession(string name)
        {
            accession = name;
        }

        public string getAccession()
        {
            return accession;
        }

        public string getAbstractID()
        {
            return abrID;
        }

        public string getStrandedness()
        {
            return stranded;
        }

        public string getTopology()
        {
            return topology;
        }

        public string getMolType()
        {
            return moltype;
        }

        public string getDefinition()
        {
            return def;
        }

        public string getOrganism()
        {
            return organism;
        }

        public List<feature> getVisibleFeatures(int top, int bot)
        {
            List<feature> retlist = new List<feature>();
            foreach (feature feat in featurelist)
            {
                if (feat.end < top || feat.start > bot)
                {
                    continue;
                }
                retlist.Add(feat);
            }
            return retlist;
        }

        private string SEQ;
        private string accession;
        private string abrID;
        private string stranded;
        private string topology;
        private string moltype;
        private string def;
        private string organism;
    }
}
