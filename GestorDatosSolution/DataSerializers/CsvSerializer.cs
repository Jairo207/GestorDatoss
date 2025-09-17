using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;

namespace DataSerializers
{
    public static class CsvSerializer
    {
        public static List<string[]> LeerCsv(string ruta, string sep = ",")
        {
            var lines = File.ReadAllLines(ruta);
            var result = new List<string[]>();

            foreach (var line in lines)
            {
                result.Add(line.Split(sep[0]));
            }

            return result;
        }

        public static void GuardarCsv(string ruta, List<string[]> filas, string sep = ",")
        {
            using (var sw = new StreamWriter(ruta))
            {
                foreach (var f in filas)
                {
                    sw.WriteLine(string.Join(sep, f));
                }
            }
        }

        public static DataTable ToDataTable(List<string[]> filas)
        {
            var dt = new DataTable();
            if (filas == null || filas.Count == 0) return dt;

            foreach (var h in filas[0])
                dt.Columns.Add(h);

            for (int i = 1; i < filas.Count; i++)
                dt.Rows.Add(filas[i]);

            return dt;
        }

        public static List<string[]> FromDataTable(DataTable dt)
        {
            var list = new List<string[]>();
            if (dt == null || dt.Columns.Count == 0) return list;

            var headers = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray();
            list.Add(headers);

            foreach (DataRow r in dt.Rows)
                list.Add(r.ItemArray.Select(x => x?.ToString() ?? "").ToArray());

            return list;
        }
    }
}
