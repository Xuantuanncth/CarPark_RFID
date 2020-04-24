using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using AForge.Video;
using Excel = Microsoft.Office.Interop.Excel;
using AForge.Video.DirectShow;

namespace BaiDoXe
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection camera;
        private VideoCaptureDevice cam1;
        private VideoCaptureDevice cam2;
        private string data_recv;
        string[] cardName = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        CardName card_Num = new CardName {
            card_num = " ",
            checkin = 0,
            checkout = 0
        };

        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            Console.WriteLine("[TuanDX] ============> Camera Count: "+camera.Count);
            if(camera.Count == 0)
            {
                bt_opencam1.Enabled = false;
                bt_opencam2.Enabled = false;
            } else if(camera.Count == 1)
            {
                FilterInfo info = camera[0];
                cb_cam1.Items.Add(info.Name);
                cb_cam1.SelectedIndex = 0;
                bt_opencam1.Enabled = true;
                bt_opencam2.Enabled = false;
            } else if(camera.Count == 2)
            {
                Console.WriteLine("[TuanDX] Camera count: " + camera.Count);
                foreach(FilterInfo info in camera)
                {
                    cb_cam1.Items.Add(info.Name);
                    cb_cam2.Items.Add(info.Name);
                }
                bt_opencam1.Enabled = true;
                bt_opencam2.Enabled = true;
                cb_cam1.SelectedIndex = 0;
                cb_cam2.SelectedIndex = 1;
            }
            string[] COM = SerialPort.GetPortNames();
            cb_COM.Items.AddRange(COM);
            timer1.Start();     
        }

        private void bt_opencam1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("TDX =============> opencamera 1");
            if(cam1 != null && cam1.IsRunning)
            {
                cam1.Stop();
            }
            cam1 = new VideoCaptureDevice(camera[cb_cam1.SelectedIndex].MonikerString);
            cam1.NewFrame += Cam_NewFarme1;
            cam1.Start();
        }
        private void Cam_NewFarme1(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pb_Camera1.Image = bitmap;
        }

        private void bt_opencam2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("TDX =============> opencamera 2");
            if (cam2 != null && cam2.IsRunning)
            {
                cam2.Stop();
            }
            cam2 = new VideoCaptureDevice(camera[cb_cam2.SelectedIndex].MonikerString);
            cam2.NewFrame += Cam_NewFarme2;
            cam2.Start();
        }
        private void Cam_NewFarme2(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pb_Camera2.Image = bitmap;
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                lb_status_device.Text = "Disconnect";
                bt_Connect.Text = "Connection";
            } else
            {
                serialPort1.PortName = cb_COM.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                lb_status_device.Text = "Connection";
                bt_Connect.Text = "Disconnect";
            }
        }
        private void DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            data_recv = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }
        private void ShowData(object sender, EventArgs e) {
            Console.WriteLine("Data: "+data_recv);
            string[] sperator = { "_" };
            Int32 count = 2;
            string[] data = data_recv.Split(sperator, count, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Data0: "+data[0]+"; Data1: "+data[1]);
            if (data[0] == "in") 
            {
                savePicture(data_recv, 1);
                saveDataGridView(Convert.ToInt32(data[1]),1);

            } 
            else if(data[0] == "out")
            {
                savePicture(data_recv, 1);
                loadPicture(data[1]);
            } 
            else if(data[0] == "ok")
            {
                saveDataGridView(Convert.ToInt32(data[1]), 2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lb_time.Text = now.ToString("dd MMMM yyyy HH_mm");
        }
        
        private void savePicture(string name, Int32 device)
        {
            string path = "E://Picture//" + name + ".jpg";
            Console.WriteLine("Path: " + path);
            if (device == 1) {
                try
                {
                    pb_Camera1.Image.Save(path);
                }
                catch(Exception exe)
                {
                    MessageBox.Show("!!!Camera not working 1 , Error: "+ exe.Message,"Waring",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            else
            {
                try
                {
                    pb_Camera2.Image.Save(path);
                }
                catch (Exception exe)
                {
                    MessageBox.Show("!!!Camera not working 2 , Error: " + exe.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void loadPicture(string name)
        {
            string path_in = "E://Picture//in_"+name+".jpg";
            string path_out = "E://Picture//out_" + name + ".jpg";
            try
            {
                pb_Display1.Image = Image.FromFile(path_in);
                pb_Display2.Image = Image.FromFile(path_out);
            }
            catch (Exception exe)
            {
                MessageBox.Show("!!!Picture don't exsit , Error: "+exe.Message,"Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                      
        }
        private void saveDataGridView(Int32 number, Int16 check_in)
        {
            int index = 0;
            if (check_in == 1)
            {

                card_Num.card_num = cardName[number];
                card_Num.checkin = 1;
                int check = search_card(cardName[number], 1);
                if (check == -1)
                {
                    index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells["CARD"].Value = card_Num.card_num;
                    dataGridView1.Rows[index].Cells["TIME_IN"].Value = lb_time.Text;
                }
                else
                {
                    MessageBox.Show("Card is exsit data ", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else if(check_in == 2)
            {
                index = search_card(cardName[number],0);
                if(index >= 0)
                {
                    dataGridView1.Rows[index].Cells["TIME_OUT"].Value = lb_time.Text;
                }
            }
        }
        private int search_card(string card, Int16 mode)
        {
            int index = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Cells["CARD"].Value != null)
                    {
                        if (row.Cells["CARD"].Value.ToString().Equals(card))
                        {
                            if (row.Cells["TIME_OUT"].Value == null)
                            {
                                index = row.Index;
                                Console.WriteLine("Index: " + index);
                                break;
                            }
                            Console.WriteLine("Index: "+ row.Index);
                        }
                    }
                }
            }
            catch(Exception exe)
            {
                //MessageBox.Show("!!! Error: "+exe.Message,"Waring", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            return index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveDataGridView(2, 1);
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void bt_export_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
