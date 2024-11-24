namespace Notifyicon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TreeNode treeNode1 = new TreeNode("nadir");
            TreeNode treeNode2 = new TreeNode("mahmude");
            TreeNode treeNode3 = new TreeNode("Boys", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Nur", 1, -2);
            TreeNode treeNode5 = new TreeNode("Reem", 1, -2);
            TreeNode treeNode6 = new TreeNode("Girls", 1, -2, new TreeNode[] { treeNode4, treeNode5 });
            button1 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            imageList1 = new ImageList(components);
            treeView1 = new TreeView();
            progressBar1 = new ProgressBar();
            StartPrograss = new Button();
            resetProgressBar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 30);
            button1.Name = "button1";
            button1.Size = new Size(190, 49);
            button1.TabIndex = 0;
            button1.Text = "Show Icon";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipClicked += NtifyIcon1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "boy.png");
            imageList1.Images.SetKeyName(1, "girl.png");
            // 
            // treeView1
            // 
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(329, 30);
            treeView1.Name = "treeView1";
            treeNode1.Name = "nadir";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "nadir";
            treeNode2.Name = "mahmude";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Text = "mahmude";
            treeNode3.Name = "Boys";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "Boys";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Nur";
            treeNode4.SelectedImageIndex = -2;
            treeNode4.Text = "Nur";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Reem";
            treeNode5.SelectedImageIndex = -2;
            treeNode5.Text = "Reem";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Girls";
            treeNode6.SelectedImageIndex = -2;
            treeNode6.Text = "Girls";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode6 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(415, 320);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(116, 375);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(641, 26);
            progressBar1.TabIndex = 2;
            // 
            // StartPrograss
            // 
            StartPrograss.Location = new Point(241, 431);
            StartPrograss.Name = "StartPrograss";
            StartPrograss.Size = new Size(75, 23);
            StartPrograss.TabIndex = 3;
            StartPrograss.Text = "Start Progress";
            StartPrograss.UseVisualStyleBackColor = true;
            StartPrograss.Click += StartPrograss_Click;
            // 
            // resetProgressBar
            // 
            resetProgressBar.Location = new Point(463, 431);
            resetProgressBar.Name = "resetProgressBar";
            resetProgressBar.Size = new Size(75, 23);
            resetProgressBar.TabIndex = 3;
            resetProgressBar.Text = "Reset  Progress Bar";
            resetProgressBar.UseVisualStyleBackColor = true;
            resetProgressBar.Click += resetProgressBar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 331);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 4;
            label1.Text = "0%";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "moon", "sun ", "Earth", "marsa" });
            checkedListBox1.Location = new Point(98, 173);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 488);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(resetProgressBar);
            Controls.Add(StartPrograss);
            Controls.Add(progressBar1);
            Controls.Add(treeView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NotifyIcon notifyIcon1;
        private ImageList imageList1;
        private TreeView treeView1;
        private ProgressBar progressBar1;
        private Button StartPrograss;
        private Button resetProgressBar;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private CheckedListBox checkedListBox1;
    }
}
