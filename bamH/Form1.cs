using bamH.Models;
using System.Timers;
using System.Windows.Forms;

namespace bamH
{
    public partial class Form1 : Form
    {
        BamHContext context;
        System.Timers.Timer timer = new System.Timers.Timer();
        int h, m, s;
        bool isLocked = false;
        int x=0;
        public Form1()
        {
            InitializeComponent();
            Nhat();
            
        }
        public void Nhat()
        {
            textBoxTime.Text = string.Format("{0}:{1}:{2}", h.ToString(), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0')) ;
            timer.Interval= 1000; //1s
            timer.Elapsed += OnTimeEvent;
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox1.Image = img;

            dataGridViewThongKeTungNgay.Rows.Clear();
            dataGridViewThongKeTungNgay.Columns.Clear();

             context = new BamHContext();
            DataGridViewTextBoxColumn ngay = new DataGridViewTextBoxColumn()
            {
                Name = "Ngày",
                ReadOnly = true,
                Width = 150,
                SortMode = DataGridViewColumnSortMode.NotSortable,
        };
            dataGridViewThongKeTungNgay.Columns.Add(ngay);
            DataGridViewTextBoxColumn thoiLuong = new DataGridViewTextBoxColumn()
            {
                Name = "Time",
                ReadOnly = true,
                Width = 150,
                SortMode = DataGridViewColumnSortMode.NotSortable,
            };
            dataGridViewThongKeTungNgay.Columns.Add(thoiLuong);

            //dataGridViewThongKeTungNgay.Columns[-1].Visible= false;
            dataGridViewThongKeTungNgay.Width = 350;
            var list = context.ThongKeTungNgays.ToList().OrderByDescending(o => o.Ngay);
            foreach(ThongKeTungNgay t in list)
            {
                dataGridViewThongKeTungNgay.Rows.Add(new Object[2] {t.Ngay.Day+"/"+ t.Ngay.Month , t.ThoiLuong});
            }
            RefreshGridView();
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                if (s == 0 && m == 0 && h == 0)
                {
                    timer.Stop();
                    textBoxTime.Text = string.Format("{0}:{1}:{2}", h.ToString(), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                    textBoxTime.BackColor= Color.DeepPink;
                    if (isLocked == true)
                    {
                        lock_Button.PerformClick();
                    }
                    RefreshGridView();
                    this.Location= new Point(858, 401);
                    this.Focus();
                }
                
                if (s == -1)
                {
                    s = 59;
                    m -= 1;
                }
                if (m == -1 )
                {
                    m = 59;
                    h -= 1;
                }
                textBoxTime.Text = string.Format("{0}:{1}:{2}", h.ToString(), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void fiveMinutes_Click(object sender, EventArgs e)
        {
            m = 5;
            h = 0;
            s = 1;
            textBoxTime.BackColor = Color.LightCyan;
            timer.Start();
            x = m;
        }

        private void fifteenMinutes_Click(object sender, EventArgs e)
        {
            m = 15;
            h = 0;
            s = 0;
            textBoxTime.BackColor = Color.LightCyan;
            timer.Start();
            x = m;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            Application.DoEvents();
        }

        private void lock_Button_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                fiveMinutes.Visible = false;
                fifteenMinutes.Visible = false;
                thirtyMinutes.Visible = false;
                fourtyFiveMinutes.Visible = false;
                default_Button.Visible = false;
                isLocked = true;
                lock_Button.Text = "Open";
                lock_Button.Location = new Point(110, 170);
                this.ControlBox= false;
                int width = 426;
                int height = 328;
                this.Size = new Size(width, height);
                this.Location = new Point(2540-width, 1440- height - 70);
                
            }
            else
            {
                fiveMinutes.Visible = true;
                fifteenMinutes.Visible = true;
                thirtyMinutes.Visible = true;
                fourtyFiveMinutes.Visible = true;
                default_Button.Visible = true;
                isLocked = false;
                lock_Button.Text= "Lock";
                lock_Button.Location = new Point(630, 487);
                this.ControlBox = true;
                int width = 844;
                int height = 638;
                this.Size = new Size(width, height);
                this.Location = new Point(2540 - width, 1440 - height - 70);
            }
        }

        private void default_Button_Click(object sender, EventArgs e)
        {
            fiveMinutes.Enabled = true;
            fifteenMinutes.Enabled = true;
            thirtyMinutes.Enabled = true;
            fourtyFiveMinutes.Enabled = true;
            isLocked = false;
            lock_Button.Text = "Lock";
            timer.Stop();
            textBoxTime.Text = "0:00:00";
            textBoxTime.BackColor = Color.LightCyan;
            this.Location = new Point(1696,732);
        }

        private void thirtyMinutes_Click(object sender, EventArgs e)
        {
            m = 30;
            h = 0;
            s = 0;
            textBoxTime.BackColor = Color.LightCyan;
            timer.Start();
            x = m;
        }

        private void fourtyFiveMinutes_Click(object sender, EventArgs e)
        {
            m = 45;
            h = 0;
            s = 0;
            textBoxTime.BackColor = Color.LightCyan;
            timer.Start();
            x = m;
        }

        public void RefreshGridView()
        {
            ThongKeTungNgay duLieuCuaNgayGanNhat = context.ThongKeTungNgays.OrderByDescending(o => o.Ngay).First();
            DateTime now= DateTime.Now;
            DateTime ngayGanNhat = duLieuCuaNgayGanNhat.Ngay;
            if (ngayGanNhat.Day==now.Day && ngayGanNhat.Month == now.Month && ngayGanNhat.Year == now.Year)
            {
                duLieuCuaNgayGanNhat.ThoiLuong += x;
            }
            else
            {
                context.ThongKeTungNgays.Add(new ThongKeTungNgay() { Ngay = now, ThoiLuong = x });

            }
            context.SaveChanges();
            dataGridViewThongKeTungNgay.Rows.Clear();
            var list = context.ThongKeTungNgays.ToList().OrderByDescending(o => o.Ngay);
            foreach (ThongKeTungNgay t in list)
            {
                dataGridViewThongKeTungNgay.Rows.Add(new Object[2] { t.Ngay.Day + "/" + t.Ngay.Month, t.ThoiLuong });
            }
        }

       

        
    }
}