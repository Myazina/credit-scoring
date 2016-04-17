using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadCsvFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        /// <summary>
        /// Load CSV file into DataTable
        /// </summary>
        public DataTable ReadCSV(string filePath)
        {
            File.ReadLines(filePath).Take(1)
          .SelectMany(x => x.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
          .ToList()
          .ForEach(x => dt.Columns.Add(x.Trim(), Type.GetType("System.String")));
            //добавляем новые колонки
            DataColumn c1 = new DataColumn("pmt_string_84m_0", System.Type.GetType("System.Int16"));
            DataColumn c2 = new DataColumn("pmt_string_84m_1", System.Type.GetType("System.Int16"));
            DataColumn c3 = new DataColumn("pmt_string_84m_2", System.Type.GetType("System.Int16"));
            DataColumn c4 = new DataColumn("pmt_string_84m_3", System.Type.GetType("System.Int16"));
            DataColumn c5 = new DataColumn("pmt_string_84m_4", System.Type.GetType("System.Int16"));
            DataColumn c6 = new DataColumn("pmt_string_84m_5", System.Type.GetType("System.Int16"));
            DataColumn c7 = new DataColumn("pmt_string_84m_6", System.Type.GetType("System.Int16"));
            DataColumn c8 = new DataColumn("pmt_string_84m_7", System.Type.GetType("System.Int16"));
            DataColumn c9 = new DataColumn("pmt_string_84m_8", System.Type.GetType("System.Int16"));
            DataColumn c10 = new DataColumn("pmt_string_84m_9", System.Type.GetType("System.Int16"));
            DataColumn c11 = new DataColumn("pmt_string_84m_A", System.Type.GetType("System.Int16"));
            DataColumn c12 = new DataColumn("pmt_string_84m_E", System.Type.GetType("System.Int16"));
            DataColumn c13 = new DataColumn("pmt_string_84m_X", System.Type.GetType("System.Int16"));
            DataColumn c14 = new DataColumn("pmt_freq_0", System.Type.GetType("System.Int16"));
            DataColumn c15 = new DataColumn("pmt_freq_1", System.Type.GetType("System.Int16"));
            DataColumn c16 = new DataColumn("pmt_freq_2", System.Type.GetType("System.Int16"));
            DataColumn c17 = new DataColumn("pmt_freq_3", System.Type.GetType("System.Int16"));
            DataColumn c18 = new DataColumn("pmt_freq_4", System.Type.GetType("System.Int16"));
            DataColumn c19 = new DataColumn("pmt_freq_6", System.Type.GetType("System.Int16"));
            DataColumn c20 = new DataColumn("pmt_freq_7", System.Type.GetType("System.Int16"));
            DataColumn c30 = new DataColumn("type_0", System.Type.GetType("System.Int16"));
            DataColumn c31 = new DataColumn("type_1", System.Type.GetType("System.Int16"));
            DataColumn c32 = new DataColumn("type_2", System.Type.GetType("System.Int16"));
            DataColumn c33 = new DataColumn("type_3", System.Type.GetType("System.Int16"));
            DataColumn c34 = new DataColumn("type_4", System.Type.GetType("System.Int16"));
            DataColumn c36 = new DataColumn("type_6", System.Type.GetType("System.Int16"));
            DataColumn c37 = new DataColumn("type_7", System.Type.GetType("System.Int16"));
            DataColumn c39 = new DataColumn("type_9", System.Type.GetType("System.Int16"));
            DataColumn c40 = new DataColumn("status_0", System.Type.GetType("System.Int16"));
            DataColumn c41 = new DataColumn("status_1", System.Type.GetType("System.Int16"));
            DataColumn c42 = new DataColumn("status_2", System.Type.GetType("System.Int16"));
            DataColumn c43 = new DataColumn("status_3", System.Type.GetType("System.Int16"));
            DataColumn c44 = new DataColumn("status_4", System.Type.GetType("System.Int16"));
            DataColumn c45 = new DataColumn("status_5", System.Type.GetType("System.Int16"));
            DataColumn c46 = new DataColumn("status_6", System.Type.GetType("System.Int16"));
            DataColumn c51 = new DataColumn("relationship_1", System.Type.GetType("System.Int16"));
            DataColumn c52 = new DataColumn("relationship_2", System.Type.GetType("System.Int16"));
            DataColumn c54 = new DataColumn("relationship_4", System.Type.GetType("System.Int16"));
            DataColumn c55 = new DataColumn("relationship_5", System.Type.GetType("System.Int16"));
            DataColumn c59 = new DataColumn("relationship_9", System.Type.GetType("System.Int16"));
            DataColumn c61 = new DataColumn("bureau_cd_1", System.Type.GetType("System.Int16"));
            DataColumn c62 = new DataColumn("bureau_cd_2", System.Type.GetType("System.Int16"));
            DataColumn c63 = new DataColumn("bureau_cd_3", System.Type.GetType("System.Int16"));
            DataColumn c64 = new DataColumn("crs", System.Type.GetType("System.Double"));
            DataColumn c65 = new DataColumn("RUB", System.Type.GetType("System.Double"));
            DataColumn c66 = new DataColumn("USD", System.Type.GetType("System.Double"));
            DataColumn c67 = new DataColumn("EUR", System.Type.GetType("System.Double"));

            dt.Columns.AddRange(new DataColumn[] { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20,
            c30, c31, c32, c33, c34, c36, c37, c39, c40, c41, c42, c43, c44, c45, c46, c51, c52, c54, c55, c59, c61, c62, c63, c64, c65, c66,
            c67});
            //таблица имеет все колонки

            File.ReadLines(filePath).Skip(1)
           .Select(x => x.Split(';'))
           .ToList()
          .ForEach(line =>
          //на проходе формируем значения новых колонок
          {
              DataRow rr = dt.NewRow();
              for (int ii = 0; ii < line.Length; ii++) rr[ii] = line[ii];
              int i = line.Length;
              rr[i] = Numbs('0', line[22]);
              rr[i + 1] = Numbs('1', line[22]);
              rr[i + 2] = Numbs('2', line[22]);
              rr[i + 3] = Numbs('3', line[22]);
              rr[i + 4] = Numbs('4', line[22]);
              rr[i + 5] = Numbs('5', line[22]);
              rr[i + 6] = Numbs('6', line[22]);
              rr[i + 7] = Numbs('7', line[22]);
              rr[i + 8] = Numbs('8', line[22]);
              rr[i + 9] = Numbs('9', line[22]);
              rr[i + 10] = Numbs('A', line[22]);
              rr[i + 11] = Numbs('E', line[22]);
              rr[i + 12] = Numbs('X', line[22]);
              rr[i + 13] = Numbs('0', line[26]);
              rr[i + 14] = Numbs('1', line[26]);
              rr[i + 15] = Numbs('2', line[26]);
              rr[i + 16] = Numbs('3', line[26]);
              rr[i + 17] = Numbs('4', line[26]);
              rr[i + 18] = Numbs('6', line[26]);
              rr[i + 19] = Numbs('7', line[26]);
              rr[i + 20] = Numbs('0', line[4]);
              rr[i + 21] = Numbs('1', line[4]);
              rr[i + 22] = Numbs('2', line[4]);
              rr[i + 23] = Numbs('3', line[4]);
              rr[i + 24] = Numbs('4', line[4]);
              rr[i + 25] = Numbs('6', line[4]);
              rr[i + 26] = Numbs('7', line[4]);
              rr[i + 27] = Numbs('9', line[4]);
              rr[i + 28] = Numbs('0', line[5]);
              rr[i + 29] = Numbs('1', line[5]);
              rr[i + 30] = Numbs('2', line[5]);
              rr[i + 31] = Numbs('3', line[5]);
              rr[i + 32] = Numbs('4', line[5]);
              rr[i + 33] = Numbs('5', line[5]);
              rr[i + 34] = Numbs('6', line[5]);
              rr[i + 35] = Numbs('1', line[27]);
              rr[i + 36] = Numbs('2', line[27]);
              rr[i + 37] = Numbs('4', line[27]);
              rr[i + 38] = Numbs('5', line[27]);
              rr[i + 39] = Numbs('9', line[27]);
              rr[i + 40] = Numbs('1', line[1]);
              rr[i + 41] = Numbs('2', line[1]);
              rr[i + 42] = Numbs('3', line[1]);
              // rr[i + 43] = Numbs('1', line[75]);
              dt.Rows.Add(rr);
          });

            var distinctIds = dt.AsEnumerable()
                .GroupBy(r =>
                    r.Field<string>("tcs_customer_id"))
                /*.Select(s => new
                {
                    id = s.Field<string>("tcs_customer_id")
                })*/
                     .Distinct().Count().ToString();
            textBox3.Text = distinctIds.ToString();


            return dt;

        }
        public DataTable ReadCSV2(string filePath)
        {

            File.ReadLines(filePath).Take(1)
            .SelectMany(x => x.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            .ToList()
            .ForEach(x => dt2.Columns.Add(x.Trim()));

            File.ReadLines(filePath).Skip(1)
           .Select(x => x.Split(';'))
           .ToList()
          .ForEach(line => dt2.Rows.Add(line));

            return dt2;
        }

        public void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        dataGridView1.DataSource = ReadCSV(ofd.FileName);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = "currency like '%" + textBox4.Text + "%'";
                dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.RowCount.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.ColumnCount.ToString();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "currency like '%" + textBox4.Text + "%'";
            dataGridView1.DataSource = bs;

        }
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        dataGridView2.DataSource = ReadCSV2(ofd.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;

            DataRow rr = dt.NewRow();

            var z1 = dt.AsEnumerable()

                  .GroupBy(r => r.Field<string>("tcs_customer_id") +
                  r.Field<string>("open_date") +
                 r.Field<string>("final_pmt_date") +
                 r.Field<string>("credit_limit") +
                 r.Field<string>("currency") +
                 r.Field<string>("inf_confirm_date").First())

                 .Select((t) => new
                 {
                     tcs_customer_id = t.First().Field<string>("tcs_customer_id"),
                     open_date = t.First().Field<string>("open_date"),
                     final_pmt_date = t.First().Field<string>("final_pmt_date"),
                     credit_limit = t.First().Field<string>("credit_limit"),
                     currency = t.First().Field<string>("currency"),
                     inf_confirm_date = t.First().Field<string>("inf_confirm_date"),
                     fact_close_date = t.First().Field<string>("fact_close_date"),

                     pmt_string_84m_0 = t.Sum(x => x.Field<Int16>("pmt_string_84m_0")),
                     pmt_string_84m_1 = t.Sum(x => x.Field<Int16>("pmt_string_84m_1")),
                     pmt_string_84m_2 = t.Sum(x => x.Field<Int16>("pmt_string_84m_2")),
                     pmt_string_84m_3 = t.Sum(x => x.Field<Int16>("pmt_string_84m_3")),
                     pmt_string_84m_4 = t.Sum(x => x.Field<Int16>("pmt_string_84m_4")),
                     pmt_string_84m_5 = t.Sum(x => x.Field<Int16>("pmt_string_84m_5")),
                     pmt_string_84m_6 = t.Sum(x => x.Field<Int16>("pmt_string_84m_6")),
                     pmt_string_84m_7 = t.Sum(x => x.Field<Int16>("pmt_string_84m_7")),
                     pmt_string_84m_8 = t.Sum(x => x.Field<Int16>("pmt_string_84m_8")),
                     pmt_string_84m_9 = t.Sum(x => x.Field<Int16>("pmt_string_84m_9")),
                     pmt_string_84m_A = t.Sum(x => x.Field<Int16>("pmt_string_84m_A")),
                     pmt_string_84m_X = t.Sum(x => x.Field<Int16>("pmt_string_84m_X")),
                     pmt_string_84m_E = t.Sum(x => x.Field<Int16>("pmt_string_84m_E")),
                     pmt_freq_0 = t.Sum(x => x.Field<Int16>("pmt_freq_0")),
                     pmt_freq_1 = t.Sum(x => x.Field<Int16>("pmt_freq_1")),
                     pmt_freq_2 = t.Sum(x => x.Field<Int16>("pmt_freq_2")),
                     pmt_freq_3 = t.Sum(x => x.Field<Int16>("pmt_freq_3")),
                     pmt_freq_4 = t.Sum(x => x.Field<Int16>("pmt_freq_4")),
                     pmt_freq_6 = t.Sum(x => x.Field<Int16>("pmt_freq_6")),
                     pmt_freq_7 = t.Sum(x => x.Field<Int16>("pmt_freq_7")),
                     type_0 = t.Sum(x => x.Field<Int16>("type_0")),
                     type_1 = t.Sum(x => x.Field<Int16>("type_1")),
                     type_2 = t.Sum(x => x.Field<Int16>("type_2")),
                     type_3 = t.Sum(x => x.Field<Int16>("type_3")),
                     type_4 = t.Sum(x => x.Field<Int16>("type_4")),
                     type_6 = t.Sum(x => x.Field<Int16>("type_6")),
                     type_7 = t.Sum(x => x.Field<Int16>("type_7")),
                     type_9 = t.Sum(x => x.Field<Int16>("type_9")),
                     status_0 = t.Sum(x => x.Field<Int16>("status_0")),
                     status_1 = t.Sum(x => x.Field<Int16>("status_1")),
                     status_2 = t.Sum(x => x.Field<Int16>("status_2")),
                     status_3 = t.Sum(x => x.Field<Int16>("status_3")),
                     status_4 = t.Sum(x => x.Field<Int16>("status_4")),
                     status_5 = t.Sum(x => x.Field<Int16>("status_5")),
                     status_6 = t.Sum(x => x.Field<Int16>("status_6")),
                     relationship_1 = t.Sum(x => x.Field<Int16>("relationship_1")),
                     relationship_2 = t.Sum(x => x.Field<Int16>("relationship_2")),
                     relationship_4 = t.Sum(x => x.Field<Int16>("relationship_4")),
                     relationship_5 = t.Sum(x => x.Field<Int16>("relationship_5")),
                     relationship_9 = t.Sum(x => x.Field<Int16>("relationship_9")),
                     bureau_cd_1 = t.Sum(x => x.Field<Int16>("bureau_cd_1")),
                     bureau_cd_2 = t.Sum(x => x.Field<Int16>("bureau_cd_2")),
                     bureau_cd_3 = t.Sum(x => x.Field<Int16>("bureau_cd_3"))

                 });
            string[] name = new string[50] 
                {
                "tcs_customer_id", "open_date" , "final_pmt_date", "credit_limit", "currency", "inf_confirm_date", "fact_close_date",//"count_credit1",
                     "pmt_string_84m_0" , "pmt_string_84m_1", "pmt_string_84m_2" , "pmt_string_84m_3", "pmt_string_84m_4" ,
                     "pmt_string_84m_5" , "pmt_string_84m_6" , "pmt_string_84m_7" , "pmt_string_84m_8" , "pmt_string_84m_9",
                     "pmt_string_84m_A" , "pmt_string_84m_E" , "pmt_string_84m_X",
                     "pmt_freq_0" , "pmt_freq_1" , "pmt_freq_2" , "pmt_freq_3", "pmt_freq_4" , "pmt_freq_6" , "pmt_freq_7",
                      "type_0" , "type_1" , "type_2" , "type_3", "type_4" , "type_6" , "type_7", "type_9",
                      "status_0" , "status_1" , "status_2", "status_3" , "status_4" , "status_5", "status_6",
                      "relationship_1" , "relationship_2" , "relationship_4", "relationship_5" , "relationship_9",
                      "bureau_cd_1", "bureau_cd_2" , "bureau_cd_3",  
                };
            foreach (string s in name) dt1.Columns.Add(s);


            z1.All(w =>
            {
                rr = dt1.NewRow(); rr[0] = w.tcs_customer_id; rr[1] = w.open_date; rr[2] = w.final_pmt_date; rr[3] = w.credit_limit;
                rr[4] = w.currency; rr[5] = w.inf_confirm_date; rr[6] = w.fact_close_date; rr[7] = w.pmt_string_84m_0;
                rr[8] = w.pmt_string_84m_1; rr[9] = w.pmt_string_84m_2; rr[10] = w.pmt_string_84m_3; rr[11] = w.pmt_string_84m_4;
                rr[12] = w.pmt_string_84m_5; rr[13] = w.pmt_string_84m_6; rr[14] = w.pmt_string_84m_7; rr[15] = w.pmt_string_84m_8;
                rr[16] = w.pmt_string_84m_9; rr[17] = w.pmt_string_84m_A; rr[18] = w.pmt_string_84m_E; rr[19] = w.pmt_string_84m_X;
                rr[20] = w.pmt_freq_0; rr[21] = w.pmt_freq_1; rr[22] = w.pmt_freq_2; rr[23] = w.pmt_freq_3; rr[24] = w.pmt_freq_4;
                rr[25] = w.pmt_freq_6; rr[26] = w.pmt_freq_7; rr[27] = w.type_0; rr[28] = w.type_1; rr[29] = w.type_2;
                rr[30] = w.type_3; rr[31] = w.type_4; rr[32] = w.type_6; rr[33] = w.type_7; rr[34] = w.type_9;
                rr[35] = w.status_0; rr[36] = w.status_1; rr[37] = w.status_2; rr[38] = w.status_3; rr[39] = w.status_4;
                rr[40] = w.status_5; rr[41] = w.status_6; rr[42] = w.relationship_1; rr[43] = w.relationship_2; rr[44] = w.relationship_4;
                rr[45] = w.relationship_5; rr[46] = w.relationship_9; rr[47] = w.bureau_cd_1; rr[48] = w.bureau_cd_2;
                rr[49] = w.bureau_cd_3;
                dt1.Rows.Add(rr); return true;
            });

            System.Data.DataColumn count_credit = new System.Data.DataColumn("count_credit", typeof(System.Int16));
            count_credit.DefaultValue = "1";
            System.Data.DataColumn crs = new System.Data.DataColumn("crs", typeof(System.Double));
            System.Data.DataColumn RUB = new System.Data.DataColumn("RUB", typeof(System.Double));
            System.Data.DataColumn USD = new System.Data.DataColumn("USD", typeof(System.Double));
            System.Data.DataColumn EUR = new System.Data.DataColumn("EUR", typeof(System.Double));
            dt1.Columns.Add(count_credit);
            dt1.Columns.Add(crs);
            dt1.Columns.Add(RUB);
            dt1.Columns.Add(USD);
            dt1.Columns.Add(EUR);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (dt1.Rows[i]["currency"].ToString() == "RUB")
                {
                    dt1.Rows[i]["crs"] = "1";
                }
                if (dt1.Rows[i]["currency"].ToString() == "USD")
                {
                    dt1.Rows[i]["crs"] = "67";
                }
                if (dt1.Rows[i]["currency"].ToString() == "EUR")
                {
                    dt1.Rows[i]["crs"] = "76";
                }
                if (dt1.Rows[i]["currency"].ToString() == "RUB")
                {
                    dt1.Rows[i]["RUB"] = Convert.ToDouble(dt1.Rows[i]["crs"]) * Convert.ToDouble(dt1.Rows[i]["credit_limit"]);
                }
                if (dt1.Rows[i]["currency"].ToString() == "USD")
                {
                    dt1.Rows[i]["USD"] = Convert.ToDouble(dt1.Rows[i]["crs"]) * Convert.ToDouble(dt1.Rows[i]["credit_limit"]);
                }
                if (dt1.Rows[i]["currency"].ToString() == "EUR")
                {
                    dt1.Rows[i]["EUR"] = Convert.ToDouble(dt1.Rows[i]["crs"]) * Convert.ToDouble(dt1.Rows[i]["credit_limit"]);
                }
            }            //dt1.Columns.Add(count_credit);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (dt1.Rows[i]["fact_close_date"].ToString() != null && dt1.Rows[i]["final_pmt_date"].ToString() == null)
                {
                    dt1.Rows[i]["final_pmt_date"] = dt1.Rows[i]["fact_close_date"];
                }
                for (int j = 0; j < dt1.Columns.Count; j++)
                {
                    if (string.IsNullOrEmpty(dt1.Rows[i][j].ToString()))
                    {
                        // Write your Custom Code
                        dt1.Rows[i][j] = "0";
                    }

                }
                if (dt1.Rows[i]["fact_close_date"].ToString() != "0")
                {
                    dt1.Rows[i]["fact_close_date"] = "1";
                }
            }
            dt1.Columns.Remove("currency");
            dt1.Columns.Remove("inf_confirm_date");
            dt1.Columns.Remove("open_date");
            dt1.Columns.Remove("final_pmt_date");
            dt.Columns.Remove("pmt_string_84m");
            dt.Columns.Remove("pmt_freq");
            dt.Columns.Remove("type");
            dt.Columns.Remove("status");
            dt.Columns.Remove("relationship");
            dt.Columns.Remove("bureau_cd");
            dt.Columns.Remove("bki_request_date");
            dt.Columns.Remove("pmt_string_start");
            dt.Columns.Remove("interest_rate");

            DataTable dtClone = dt1.Clone();
            dtClone.Columns[0].DataType = typeof(Double); //for string - typeof(Double)
            dtClone.Columns[1].DataType = typeof(Double);
            dtClone.Columns[2].DataType = typeof(Double);
            dtClone.Columns[3].DataType = typeof(Double);
            dtClone.Columns[4].DataType = typeof(Double);
            dtClone.Columns[5].DataType = typeof(Double);
            dtClone.Columns[6].DataType = typeof(Double);
            dtClone.Columns[7].DataType = typeof(Double);
            dtClone.Columns[8].DataType = typeof(Double);
            dtClone.Columns[9].DataType = typeof(Double);
            dtClone.Columns[10].DataType = typeof(Double);
            dtClone.Columns[11].DataType = typeof(Double);
            dtClone.Columns[12].DataType = typeof(Double);
            dtClone.Columns[13].DataType = typeof(Double);
            dtClone.Columns[14].DataType = typeof(Double);
            dtClone.Columns[15].DataType = typeof(Double);
            dtClone.Columns[16].DataType = typeof(Double);
            dtClone.Columns[17].DataType = typeof(Double);
            dtClone.Columns[18].DataType = typeof(Double);
            dtClone.Columns[19].DataType = typeof(Double);
            dtClone.Columns[20].DataType = typeof(Double);
            dtClone.Columns[21].DataType = typeof(Double);
            dtClone.Columns[22].DataType = typeof(Double);
            dtClone.Columns[23].DataType = typeof(Double);
            dtClone.Columns[24].DataType = typeof(Double);
            dtClone.Columns[25].DataType = typeof(Double);
            dtClone.Columns[26].DataType = typeof(Double);
            dtClone.Columns[27].DataType = typeof(Double);
            dtClone.Columns[28].DataType = typeof(Double);
            dtClone.Columns[29].DataType = typeof(Double);
            dtClone.Columns[30].DataType = typeof(Double);
            dtClone.Columns[31].DataType = typeof(Double);
            dtClone.Columns[32].DataType = typeof(Double);
            dtClone.Columns[33].DataType = typeof(Double);
            dtClone.Columns[34].DataType = typeof(Double);
            dtClone.Columns[35].DataType = typeof(Double);
            dtClone.Columns[36].DataType = typeof(Double);
            dtClone.Columns[37].DataType = typeof(Double);
            dtClone.Columns[38].DataType = typeof(Double);
            dtClone.Columns[39].DataType = typeof(Double);
            dtClone.Columns[40].DataType = typeof(Double);
            dtClone.Columns[41].DataType = typeof(Double);
            dtClone.Columns[42].DataType = typeof(Double);
            dtClone.Columns[43].DataType = typeof(Double);
            dtClone.Columns[44].DataType = typeof(Double);
            dtClone.Columns[45].DataType = typeof(Double);
            dtClone.Columns[46].DataType = typeof(Double);
            dtClone.Columns[47].DataType = typeof(Double);
            dtClone.Columns[48].DataType = typeof(Double);
            dtClone.Columns[49].DataType = typeof(Double);
            dtClone.Columns[50].DataType = typeof(Double);

            foreach (DataRow row in dt1.Rows)
            {
                dtClone.ImportRow(row);
            }

            dataGridView2.DataSource = dtClone;

            var _result = (from r1 in dtClone.AsEnumerable()
                           group r1 by new
                           {
                               tcs_customer_id = r1.Field<Double>("tcs_customer_id")
                           } into g
                           select new
                           {
                               tcs_customer_id = g.Key.tcs_customer_id,
                               credit_limit = g.Sum(r => r.Field<Double>("credit_limit")),
                               fact_close_date = g.Sum(r => r.Field<Double>("fact_close_date")),
                               pmt_string_84m_0 = g.Sum(r => r.Field<Double>("pmt_string_84m_0")),
                               pmt_string_84m_1 = g.Sum(r => r.Field<Double>("pmt_string_84m_1")),
                               pmt_string_84m_2 = g.Sum(r => r.Field<Double>("pmt_string_84m_2")),
                               pmt_string_84m_3 = g.Sum(r => r.Field<Double>("pmt_string_84m_3")),
                               pmt_string_84m_4 = g.Sum(r => r.Field<Double>("pmt_string_84m_4")),
                               pmt_string_84m_5 = g.Sum(r => r.Field<Double>("pmt_string_84m_5")),
                               pmt_string_84m_6 = g.Sum(r => r.Field<Double>("pmt_string_84m_6")),
                               pmt_string_84m_7 = g.Sum(r => r.Field<Double>("pmt_string_84m_7")),
                               pmt_string_84m_8 = g.Sum(r => r.Field<Double>("pmt_string_84m_8")),
                               pmt_string_84m_9 = g.Sum(r => r.Field<Double>("pmt_string_84m_9")),
                               pmt_string_84m_A = g.Sum(r => r.Field<Double>("pmt_string_84m_A")),
                               pmt_string_84m_E = g.Sum(r => r.Field<Double>("pmt_string_84m_X")),
                               pmt_string_84m_X = g.Sum(r => r.Field<Double>("pmt_string_84m_E")),
                               pmt_freq_0 = g.Sum(r => r.Field<Double>("pmt_freq_0")),
                               pmt_freq_1 = g.Sum(r => r.Field<Double>("pmt_freq_1")),
                               pmt_freq_2 = g.Sum(r => r.Field<Double>("pmt_freq_2")),
                               pmt_freq_3 = g.Sum(r => r.Field<Double>("pmt_freq_3")),
                               pmt_freq_4 = g.Sum(r => r.Field<Double>("pmt_freq_4")),
                               pmt_freq_6 = g.Sum(r => r.Field<Double>("pmt_freq_6")),
                               pmt_freq_7 = g.Sum(r => r.Field<Double>("pmt_freq_7")),
                               type_0 = g.Sum(r => r.Field<Double>("type_0")),
                               type_1 = g.Sum(r => r.Field<Double>("type_1")),
                               type_2 = g.Sum(r => r.Field<Double>("type_2")),
                               type_3 = g.Sum(r => r.Field<Double>("type_3")),
                               type_4 = g.Sum(r => r.Field<Double>("type_4")),
                               type_6 = g.Sum(r => r.Field<Double>("type_6")),
                               type_7 = g.Sum(r => r.Field<Double>("type_7")),
                               type_9 = g.Sum(r => r.Field<Double>("type_9")),
                               status_0 = g.Sum(r => r.Field<Double>("status_0")),
                               status_1 = g.Sum(r => r.Field<Double>("status_1")),
                               status_2 = g.Sum(r => r.Field<Double>("status_2")),
                               status_3 = g.Sum(r => r.Field<Double>("status_3")),
                               status_4 = g.Sum(r => r.Field<Double>("status_4")),
                               status_5 = g.Sum(r => r.Field<Double>("status_5")),
                               status_6 = g.Sum(r => r.Field<Double>("status_6")),
                               relationship_1 = g.Sum(r => r.Field<Double>("relationship_1")),
                               relationship_2 = g.Sum(r => r.Field<Double>("relationship_2")),
                               relationship_4 = g.Sum(r => r.Field<Double>("relationship_4")),
                               relationship_5 = g.Sum(r => r.Field<Double>("relationship_5")),
                               relationship_9 = g.Sum(r => r.Field<Double>("relationship_9")),
                               bureau_cd_1 = g.Sum(r => r.Field<Double>("bureau_cd_1")),
                               bureau_cd_2 = g.Sum(r => r.Field<Double>("bureau_cd_2")),
                               bureau_cd_3 = g.Sum(r => r.Field<Double>("bureau_cd_3")),
                               crs = g.Sum(r => r.Field<Double>("crs")),
                               RUB = g.Sum(r => r.Field<Double>("RUB")),
                               USD = g.Sum(r => r.Field<Double>("USD")),
                               EUR = g.Sum(r => r.Field<Double>("EUR"))
                           }).ToList();
            // соединяем со второй таблицей
            /*  _result.Columns.Add("bad");
              _result.Columns.Add("sample_type");
              for (int i = 0; i < _result.Rows.Count; i++)
              {
                  _result.Rows[i]["bad"] = dt2.Rows[i]["bad"];
                  _result.Rows[i]["sample_type"] = dt2.Rows[i]["sample_type"];
              }*/

            dataGridView2.DataSource = _result;

        }
        int Numbs(char un, string st)
        {
            char[] w = st.ToCharArray();
            int k = 0;
            w.All(c => { if (c == un) k++; return true; });
            return k;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

    

    

