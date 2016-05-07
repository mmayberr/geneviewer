using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorProject
{
    public class EutilsURLBuilder
    {
        private static string makeQuery(Control[] boxes)
        {
            string query = "";
            for (int it = 0; it < boxes.Length; it++)
            {
                if (boxes[it].Text != "")
                {
                    string type = (string)boxes[it].Tag;
                    string value = (boxes[it].Text).ToLower();

                    string toAppend = "";
                    if (query != "") toAppend = " AND ";
                    if (type == "Biomol")
                    {
                        type = "Properties";
                        value = "biomol " + value;
                    }
                    if (type == "All_fields")
                    {
                        toAppend = toAppend + value;
                    }
                    else
                    {
                        toAppend = toAppend + "\"" + value + "\"[" + type.Replace('_', ' ') + "]";
                    }
                    query += toAppend;
                }
            }
            Console.WriteLine(query);
            return query;
        }
        public static string makeQueryURL(Control[] boxes, string db, int ret)
        {
            return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/esearch.fcgi?db="+ db +"&term=" + makeQuery(boxes) + "&usehistory=y&retmax=" + ret;
        }

        public static string getFile(string in_db, string id, string in_type, string in_mode)
        {
            string db = in_db.ToLower();
            string type = in_type.ToLower();
            string mode = in_mode.ToLower();

            bool isGood = CheckParams(db, id);
            if (!isGood) throw new System.ArgumentException("Invalid database name or ID");
            
            return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=" + db + "&id=" + id + "&rettype=" + type + "&retmode=" + mode;
        }

        private static bool CheckParams(string db, string id)
        {
            if (!isValidID(id)) return false;
            if (!isValidDB(db)) return false;
            return true;
        }

        private static bool CheckParams(string db, List<string> ids)
        {
            foreach (string id in ids)
            {
                if (!isValidID(id)) return false;
            }
            if (!isValidDB(db)) return false;

            return true;
        }

        private static bool isValidDB(string db)
        {
            string validDB = "pubmed protein nuccore nucleotide nucgss nucest structure genome annotinfo assembly bioproject biosample blastdbinfo books cdd clinvar clone gap gapplus grasp dbvar epigenomics gene gds geoprofiles homologene medgen mesh ncbisearch nlmcatalog omim orgtrack pmc popset probe proteinclusters pcassay biosystems pccompound pcsubstance pubmedhealth seqannot snp sra taxonomy unigene gencoll gtr";
            if (validDB.IndexOf(db) == -1) return false;
            return true;
        }
        private static bool isValidID(string id)
        {
            int num;
            bool parsed = Int32.TryParse(id, out num);
            if (!parsed) return false;
            return true;
        }

        public static string getSummary(string in_db, List<string> ids)
        {
            string db = in_db.ToLower();
            if (!CheckParams(db, ids)) throw new System.ArgumentException("Invalid database name or ID");
            string idString = "";
            foreach(string id in ids){
                if (idString != "") idString += ',';
                idString += id;
            }
            return "http://eutils.ncbi.nlm.nih.gov/entrez/eutils/esummary.fcgi?db=" + db + "&id=" + idString;
        }
    }
}
