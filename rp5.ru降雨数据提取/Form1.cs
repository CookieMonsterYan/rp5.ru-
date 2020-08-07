using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace rp5.ru降雨数据提取
{
    public partial class Form1 : Form
    {
        private List<string> datetimes = new List<string>();
        private List<float> rains = new List<float>();
        private Regex split = new Regex("\".*?\"");  // *? 表示匹配上一个元素0次或多次，并且次数尽可能少

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_csvFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();

            openFileDlg.Filter = "All files (*.*)|*.*| CSV files(*.csv) | *.csv";
            openFileDlg.FilterIndex = 2;
            openFileDlg.RestoreDirectory = true;
            openFileDlg.Multiselect = true;

            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(string file in openFileDlg.FileNames)
                {
                    dgv_csvFiles.Rows.Add(file);
                }
            }
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "All files (*.*)|*.*| CSV files(*.csv) | *.csv";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtb_result.Text = sfd.FileName;
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            pb.Value = 0;

            string result = txtb_result.Text;
            List<string> files = new List<string>();
            int num = 0;
            foreach(DataGridViewRow row in dgv_csvFiles.Rows)
            {
                string file = (string)row.Cells[0].Value;
                if (File.Exists(file))
                {
                    files.Add(file);
                    num++;
                }
            }

            foreach(string file in files)
            {
                ClipRRR(file);
                pb.Value += 100 / (num + 1);
            }

            SaveRRR(result);
            pb.Value = 100;
        }

        private void ClipRRR(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                string line;
                bool headLine = false;
                while((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    if(line.Length == 0 || line[0].Equals('#'))
                    {
                        continue;
                    }

                    MatchCollection match = split.Matches(line);
                    if(match.Count < 29)
                    {
                        continue;
                    }

                    if(headLine)
                    {
                        string time = match[0].Value.Replace('"', ' ').Trim();
                        if(datetimes.Contains(time))
                        {
                            continue;
                        }
                        datetimes.Add(time);
                        string r = match[23].Value.Replace('"', ' ').Trim();
                        if (r.Length <= 0)
                        {
                            rains.Add(0.0f);
                        }
                        else
                        {
                            float rain = 0.01f;
                            try
                            {
                                rain = float.Parse(r);
                                rains.Add(rain);
                            }
                            catch(Exception ex)
                            {
                                rains.Add(0.01f);
                            }
                            
                        }
                    }
                    else
                    {
                        headLine = true;
                    }
                }
            }
        }

        private void SaveRRR(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("Time,RRR");
                for(int i = 0; i < datetimes.Count; i++)
                {
                    sw.WriteLine(datetimes[i] + "," + rains[i].ToString());
                }
            }
        }
    }
}
