using System.Data;
using System.Linq;

namespace ReadCsvFile
{
    public class Helper
    {
        private DataTable _dt = new DataTable();

        public Helper()
        {
        }

        public static int Numbs(char un, string st)
        {
            char[] w = st.ToCharArray();
            int k = 0;
            w.All(c => { if (c == un) k++; return true; });
            return k;
        }
    }
}