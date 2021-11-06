using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_caro
{
    public partial class Client : Form
    {
        SimpleTcpClient client;
        List<Button> buttonList;
        List<Point1> PointList;
        int x_return = 0;
        int y_return = 0;
        public Client()
        {
            InitializeComponent();
            ConectToServr();
            LoadButton();
            EnabaleButton(1);
            panel7.BackgroundImage = Image.FromFile("D:\\sql\\Caro_usingSocket\\8c573b098f861b67208cd37995714542.png");
        }

        private void ConectToServr()
        {
            client = new SimpleTcpClient($"{textIP.Text}");
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Event_DisConnected;
            client.Events.DataReceived += Event_DataReceived;
        }
        private void Resetgame()
        {
            foreach (Point1 item in PointList)
                item.Check = 0;
            foreach (Button item in buttonList)
                item.BackgroundImage = base.BackgroundImage;
        }
        private void ServerUndo(int x, int y, int type)
        {
            foreach (Point1 item in PointList)
            {
                if (item.X == x && item.Y == y)
                    item.Check = 0;
            }
            foreach (Button item in buttonList)
            {
                if ((item.Tag as Point1).X == x && (item.Tag as Point1).Y == y)
                    item.BackgroundImage = base.BackgroundImage;
                item.Enabled = (type == 1) ? true : false;
            }
        }
        private void checkString(string s)
        {
            if (s.Contains("start"))
            {
                EnabaleButton(0);
            }
            else if (s.Contains("YOUR TURN"))
            {
                string x = "";
                string y = "";
                int i = 9;
                while (i < s.Length)
                {
                    if (s[i] == ':')
                    {
                        i++;
                        break;
                    }
                    else
                        x += s[i];
                    i++;
                }
                for (; i < s.Length; i++)
                    y += s[i];
                addIconForButon(Int32.Parse(x), Int32.Parse(y));
                textTurn.Text = string.Empty;
                textTurn.Text += "Client turn";
                panel7.BackgroundImage = Image.FromFile("D:\\sql\\Caro_usingSocket\\8c573b098f861b67208cd37995714542.png");
            }
            else if (s.Contains("New game"))
            {
                Resetgame();
                textTurn.Text = string.Empty;
                textTurn.Text = "Client turn";
            }
            else if (s.Contains("Undo"))
            {
                string x = "";
                string y = "";
                int i = 4;
                while (i < s.Length)
                {
                    if (s[i] == ':')
                    {
                        i++;
                        break;
                    }
                    else
                        x += s[i];
                    i++;
                }
                for (; i < s.Length; i++)
                    y += s[i];
                ServerUndo(Int32.Parse(x), Int32.Parse(y), 0);
            }
            else if (s.Contains("win")){
                MessageBox.Show("SERVER WIN", "MESSAGE", MessageBoxButtons.OK);
                Resetgame();
            }
        }
        private void addIconForButon(int x, int y)
        {
            foreach (Button item in buttonList)
            {
                if ((item.Tag as Point1).X == x && (item.Tag as Point1).Y == y)
                {
                    item.BackgroundImage = Image.FromFile("D:\\sql\\Caro_usingSocket\\d9s61d2-f9889c71-c985-4d62-a74f-ce39a2277708.png");
                }
                item.Enabled = true;
            }
        }
        private void Event_DataReceived(object sender, DataReceivedEventArgs e)
        {
            textInfo.Text += $"Server:{Encoding.UTF8.GetString(e.Data)}.{Environment.NewLine}";
            string s = Encoding.UTF8.GetString(e.Data);
            checkString(s);

        }
        private void Event_DisConnected(object sender, ClientDisconnectedEventArgs e)
        {
            // throw new NotImplementedException();
            textInfo.Text += $"server is Disconnected.{Environment.NewLine}";
            BtnConnect.Enabled = true;
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            //throw new NotImplementedException();
            textInfo.Text += $"server is Connected.{Environment.NewLine}";
        }
        private void LoadButton()
        {
            panel1.Controls.Clear();
            PointList = new List<Point1>();
            PointList = ListPoint.Instance.LoadPointList();
            int x = 0;
            int y = 0;
            buttonList = new List<Button>();
            foreach (Point1 item in PointList)
            {
                Button btn = new Button() { Width = 28, Height = 28, BackgroundImageLayout = ImageLayout.Stretch };
                btn.Tag = item;
                btn.Click += Btn_Click;
                btn.Location = new Point(x + item.X * 29, y + item.Y * 29);
                btn.BackColor = Color.Cyan;
                btn.ImageAlign = ContentAlignment.MiddleRight;
                btn.Enabled = false;
                buttonList.Add(btn);
            }
            foreach (Button item in buttonList)
            {
                panel1.Controls.Add(item);
            }
        }
        private void EnabaleButton(int check)
        {
            foreach (Button item in buttonList)
            {
                item.Enabled = (check == 1) ? false : true;
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Image.FromFile("D:\\sql\\Caro_usingSocket\\8c573b098f861b67208cd37995714542.png");
            int x = ((sender as Button).Tag as Point1).X;
            int y = ((sender as Button).Tag as Point1).Y;
            client.Send($"YOUR TURN{x.ToString()}:{y.ToString()}");
            EnabaleButton(1);
            textTurn.Text = string.Empty;
            textTurn.Text += "Server turn";
            panel7.BackgroundImage = Image.FromFile("D:\\sql\\Caro_usingSocket\\d9s61d2-f9889c71-c985-4d62-a74f-ce39a2277708.png");
            x_return = x; y_return = y;
            guna2Button2.Enabled = true;
            foreach (Point1 item in PointList)
            {
                if (item.X == x && item.Y == y)
                    item.Check = -1;
            }
            if (checkWin(x, y) == -1) {
                client.Send("win");
                MessageBox.Show("CLIENT WIN", "MESSAGE", MessageBoxButtons.OK);
                Resetgame();
            }
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                BtnConnect.Enabled = false;
                //EnabaleButton(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Resetgame();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            client.Send("New game");
            Resetgame();
            textTurn.Text = string.Empty;
            textTurn.Text = "Client turn";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            client.Send($"Undo{x_return.ToString()}:{y_return.ToString()}");
            ServerUndo(x_return, y_return, 1);
            guna2Button2.Enabled = false;
        }
        int checkWin1(int x,int y)
        {
            List<Point1> check1 = new List<Point1>();
            List<Point1> check2 = new List<Point1>();
            foreach(Point1 item in PointList)
            {
                if (item.X == x)
                    check1.Add(item);
                if (item.Y == y)
                    check2.Add(item);
            }
            int count = 0;string s = "";
            foreach(Point1 item in check1)
            {
                if (item.Check == -1){
                    count++;
                    if (count == 5) return -1;
                }
                else
                    count = 0;
            }
            count = 0;
            foreach (Point1 item in check2)
            {
                s += $"{item.X},";
                if (item.Check ==-1) { 
                    count++;
                    if (count == 5) return -1;
                }
                else
                    count = 0;
            }
            return 0;
        }
        int checkWin2(int x, int y)
        {
            List<Point1> check1 = new List<Point1>();
            List<Point1> check2 = new List<Point1>();
            foreach (Point1 item in PointList)
            {
                if (x != item.X || y != item.Y)
                {
                    if ((x - item.X) == (y - item.Y))
                        check1.Add(item);
                    if ((x - item.X) == -(y - item.Y))
                        check2.Add(item);
                }
                else if(x==item.X && y == item.Y){
                    check1.Add(item);check2.Add(item);
                }
            }
            int count = 0;
            foreach(Point1 item in check1){
                if(item.Check == -1){
                    count++;
                    if (count == 5) return -1;
                }
                else 
                    count = 0;
            }
            foreach (Point1 item in check2)
            {
                if (item.Check == -1) { 
                    count++;
                    if (count == 5) return -1;
                }
                else
                    count = 0;
            }
            return 0;
        }
        int checkWin(int x,int y)
        {
            if (checkWin1(x, y) == -1) return -1;
            else if (checkWin2(x, y) == -1) return -1;
            return 0;
        }
    }
}
