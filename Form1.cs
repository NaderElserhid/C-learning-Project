namespace Notifyicon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipTitle = "My Title";
            notifyIcon1.BalloonTipText = "My Text";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(100);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You double-clicked me!");
        }

        private void NtifyIcon1(object sender, EventArgs e)
        {
            MessageBox.Show("You licked me!");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void StartPrograss_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += 10;
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = counter;
                label1.Text = counter.ToString() + "%";
            }

        }

        private void resetProgressBar_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            counter = 0;
            label1.Text = "0%";
        }
    }
}
