using System;

namespace Pneumatic_Robotic_Manipulator_Module
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8_Horizontal_XZ = new System.Windows.Forms.Label();
            this.label7_Horizontal_XY = new System.Windows.Forms.Label();
            this.label6_Vertical_XY = new System.Windows.Forms.Label();
            this.label5_EE_Rotation = new System.Windows.Forms.Label();
            this.label4_Gripper = new System.Windows.Forms.Label();
            this.label3_Unknown = new System.Windows.Forms.Label();
            this.button2_GotoHome2 = new System.Windows.Forms.Button();
            this.button1_GotoHome1 = new System.Windows.Forms.Button();
            this.checkBox5_Horizontal_XZ_Planar = new System.Windows.Forms.CheckBox();
            this.checkBox4_Horizontal_XY = new System.Windows.Forms.CheckBox();
            this.checkBox3_Vertical_XY = new System.Windows.Forms.CheckBox();
            this.checkBox2_EE_Rotation = new System.Windows.Forms.CheckBox();
            this.checkBox1_Gripper = new System.Windows.Forms.CheckBox();
            this.checkBox1_Unknown = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTrajectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTrajectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1_Title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_addPoint = new System.Windows.Forms.Button();
            this.radioButton1_EE_Rotation = new System.Windows.Forms.RadioButton();
            this.radioButton1_Unknown = new System.Windows.Forms.RadioButton();
            this.label9_trajectoryLog = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.postDelay = new System.Windows.Forms.NumericUpDown();
            this.preDelay = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_startStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1_status = new System.Windows.Forms.ComboBox();
            this.radioButton6_horXZ = new System.Windows.Forms.RadioButton();
            this.radioButton5_horXY = new System.Windows.Forms.RadioButton();
            this.radioButton4_vertXY = new System.Windows.Forms.RadioButton();
            this.radioButton2_gripper = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8_Horizontal_XZ);
            this.groupBox1.Controls.Add(this.label7_Horizontal_XY);
            this.groupBox1.Controls.Add(this.label6_Vertical_XY);
            this.groupBox1.Controls.Add(this.label5_EE_Rotation);
            this.groupBox1.Controls.Add(this.label4_Gripper);
            this.groupBox1.Controls.Add(this.label3_Unknown);
            this.groupBox1.Controls.Add(this.button2_GotoHome2);
            this.groupBox1.Controls.Add(this.button1_GotoHome1);
            this.groupBox1.Controls.Add(this.checkBox5_Horizontal_XZ_Planar);
            this.groupBox1.Controls.Add(this.checkBox4_Horizontal_XY);
            this.groupBox1.Controls.Add(this.checkBox3_Vertical_XY);
            this.groupBox1.Controls.Add(this.checkBox2_EE_Rotation);
            this.groupBox1.Controls.Add(this.checkBox1_Gripper);
            this.groupBox1.Controls.Add(this.checkBox1_Unknown);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Individiual Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Text in initialization.";
            // 
            // label8_Horizontal_XZ
            // 
            this.label8_Horizontal_XZ.AutoSize = true;
            this.label8_Horizontal_XZ.Location = new System.Drawing.Point(102, 164);
            this.label8_Horizontal_XZ.Name = "label8_Horizontal_XZ";
            this.label8_Horizontal_XZ.Size = new System.Drawing.Size(108, 13);
            this.label8_Horizontal_XZ.TabIndex = 12;
            this.label8_Horizontal_XZ.Text = "label8_Horizontal_XZ";
            // 
            // label7_Horizontal_XY
            // 
            this.label7_Horizontal_XY.AutoSize = true;
            this.label7_Horizontal_XY.Location = new System.Drawing.Point(102, 135);
            this.label7_Horizontal_XY.Name = "label7_Horizontal_XY";
            this.label7_Horizontal_XY.Size = new System.Drawing.Size(108, 13);
            this.label7_Horizontal_XY.TabIndex = 11;
            this.label7_Horizontal_XY.Text = "label7_Horizontal_XY";
            // 
            // label6_Vertical_XY
            // 
            this.label6_Vertical_XY.AutoSize = true;
            this.label6_Vertical_XY.Location = new System.Drawing.Point(102, 106);
            this.label6_Vertical_XY.Name = "label6_Vertical_XY";
            this.label6_Vertical_XY.Size = new System.Drawing.Size(96, 13);
            this.label6_Vertical_XY.TabIndex = 10;
            this.label6_Vertical_XY.Text = "label6_Vertical_XY";
            // 
            // label5_EE_Rotation
            // 
            this.label5_EE_Rotation.AutoSize = true;
            this.label5_EE_Rotation.Location = new System.Drawing.Point(102, 77);
            this.label5_EE_Rotation.Name = "label5_EE_Rotation";
            this.label5_EE_Rotation.Size = new System.Drawing.Size(101, 13);
            this.label5_EE_Rotation.TabIndex = 9;
            this.label5_EE_Rotation.Text = "label5_EE_Rotation";
            // 
            // label4_Gripper
            // 
            this.label4_Gripper.AutoSize = true;
            this.label4_Gripper.Location = new System.Drawing.Point(102, 48);
            this.label4_Gripper.Name = "label4_Gripper";
            this.label4_Gripper.Size = new System.Drawing.Size(75, 13);
            this.label4_Gripper.TabIndex = 8;
            this.label4_Gripper.Text = "label4_Gripper";
            // 
            // label3_Unknown
            // 
            this.label3_Unknown.AutoSize = true;
            this.label3_Unknown.Location = new System.Drawing.Point(102, 19);
            this.label3_Unknown.Name = "label3_Unknown";
            this.label3_Unknown.Size = new System.Drawing.Size(87, 13);
            this.label3_Unknown.TabIndex = 4;
            this.label3_Unknown.Text = "label3_Unknown";
            // 
            // button2_GotoHome2
            // 
            this.button2_GotoHome2.Location = new System.Drawing.Point(7, 223);
            this.button2_GotoHome2.Name = "button2_GotoHome2";
            this.button2_GotoHome2.Size = new System.Drawing.Size(86, 23);
            this.button2_GotoHome2.TabIndex = 7;
            this.button2_GotoHome2.Text = "Go to Home 2";
            this.button2_GotoHome2.UseVisualStyleBackColor = true;
            this.button2_GotoHome2.Click += new System.EventHandler(this.button2_GotoHome2_Click);
            // 
            // button1_GotoHome1
            // 
            this.button1_GotoHome1.Location = new System.Drawing.Point(6, 193);
            this.button1_GotoHome1.Name = "button1_GotoHome1";
            this.button1_GotoHome1.Size = new System.Drawing.Size(86, 23);
            this.button1_GotoHome1.TabIndex = 6;
            this.button1_GotoHome1.Text = "Go to Home 1";
            this.button1_GotoHome1.UseVisualStyleBackColor = true;
            this.button1_GotoHome1.Click += new System.EventHandler(this.button1_GotoHome1_Click);
            // 
            // checkBox5_Horizontal_XZ_Planar
            // 
            this.checkBox5_Horizontal_XZ_Planar.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5_Horizontal_XZ_Planar.AutoSize = true;
            this.checkBox5_Horizontal_XZ_Planar.Location = new System.Drawing.Point(6, 164);
            this.checkBox5_Horizontal_XZ_Planar.Name = "checkBox5_Horizontal_XZ_Planar";
            this.checkBox5_Horizontal_XZ_Planar.Size = new System.Drawing.Size(87, 23);
            this.checkBox5_Horizontal_XZ_Planar.TabIndex = 5;
            this.checkBox5_Horizontal_XZ_Planar.Text = "Horizontal XZ  ";
            this.checkBox5_Horizontal_XZ_Planar.UseVisualStyleBackColor = true;
            this.checkBox5_Horizontal_XZ_Planar.CheckedChanged += new System.EventHandler(this.checkBox5_Horizontal_XZ_Planar_CheckedChanged);
            // 
            // checkBox4_Horizontal_XY
            // 
            this.checkBox4_Horizontal_XY.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4_Horizontal_XY.AutoSize = true;
            this.checkBox4_Horizontal_XY.Location = new System.Drawing.Point(6, 135);
            this.checkBox4_Horizontal_XY.Name = "checkBox4_Horizontal_XY";
            this.checkBox4_Horizontal_XY.Size = new System.Drawing.Size(87, 23);
            this.checkBox4_Horizontal_XY.TabIndex = 4;
            this.checkBox4_Horizontal_XY.Text = "Horizontal XY  ";
            this.checkBox4_Horizontal_XY.UseVisualStyleBackColor = true;
            this.checkBox4_Horizontal_XY.CheckedChanged += new System.EventHandler(this.checkBox4_Horizontal_XY_CheckedChanged);
            // 
            // checkBox3_Vertical_XY
            // 
            this.checkBox3_Vertical_XY.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3_Vertical_XY.AutoSize = true;
            this.checkBox3_Vertical_XY.Location = new System.Drawing.Point(6, 106);
            this.checkBox3_Vertical_XY.Name = "checkBox3_Vertical_XY";
            this.checkBox3_Vertical_XY.Size = new System.Drawing.Size(87, 23);
            this.checkBox3_Vertical_XY.TabIndex = 3;
            this.checkBox3_Vertical_XY.Text = "Vertical XY      ";
            this.checkBox3_Vertical_XY.UseVisualStyleBackColor = true;
            this.checkBox3_Vertical_XY.CheckedChanged += new System.EventHandler(this.checkBox3_Vertical_XY_CheckedChanged);
            // 
            // checkBox2_EE_Rotation
            // 
            this.checkBox2_EE_Rotation.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2_EE_Rotation.AutoSize = true;
            this.checkBox2_EE_Rotation.Location = new System.Drawing.Point(6, 77);
            this.checkBox2_EE_Rotation.Name = "checkBox2_EE_Rotation";
            this.checkBox2_EE_Rotation.Size = new System.Drawing.Size(86, 23);
            this.checkBox2_EE_Rotation.TabIndex = 2;
            this.checkBox2_EE_Rotation.Text = "EE Rotation    ";
            this.checkBox2_EE_Rotation.UseVisualStyleBackColor = true;
            this.checkBox2_EE_Rotation.CheckedChanged += new System.EventHandler(this.checkBox2_EE_Rotation_CheckedChanged);
            // 
            // checkBox1_Gripper
            // 
            this.checkBox1_Gripper.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1_Gripper.AutoSize = true;
            this.checkBox1_Gripper.Location = new System.Drawing.Point(6, 48);
            this.checkBox1_Gripper.Name = "checkBox1_Gripper";
            this.checkBox1_Gripper.Size = new System.Drawing.Size(87, 23);
            this.checkBox1_Gripper.TabIndex = 1;
            this.checkBox1_Gripper.Text = "Gripper            ";
            this.checkBox1_Gripper.UseVisualStyleBackColor = true;
            this.checkBox1_Gripper.CheckedChanged += new System.EventHandler(this.checkBox1_Gripper_CheckedChanged);
            // 
            // checkBox1_Unknown
            // 
            this.checkBox1_Unknown.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1_Unknown.AutoSize = true;
            this.checkBox1_Unknown.Location = new System.Drawing.Point(6, 19);
            this.checkBox1_Unknown.Name = "checkBox1_Unknown";
            this.checkBox1_Unknown.Size = new System.Drawing.Size(87, 23);
            this.checkBox1_Unknown.TabIndex = 0;
            this.checkBox1_Unknown.Text = "Unknown        ";
            this.checkBox1_Unknown.UseVisualStyleBackColor = true;
            this.checkBox1_Unknown.CheckedChanged += new System.EventHandler(this.checkBox1_Unknown_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTrajectoryToolStripMenuItem,
            this.loadTrajectoryToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveTrajectoryToolStripMenuItem
            // 
            this.saveTrajectoryToolStripMenuItem.Enabled = false;
            this.saveTrajectoryToolStripMenuItem.Name = "saveTrajectoryToolStripMenuItem";
            this.saveTrajectoryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveTrajectoryToolStripMenuItem.Text = "Save Trajectory";
            // 
            // loadTrajectoryToolStripMenuItem
            // 
            this.loadTrajectoryToolStripMenuItem.Enabled = false;
            this.loadTrajectoryToolStripMenuItem.Name = "loadTrajectoryToolStripMenuItem";
            this.loadTrajectoryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.loadTrajectoryToolStripMenuItem.Text = "Load Trajectory";
            this.loadTrajectoryToolStripMenuItem.Click += new System.EventHandler(this.loadTrajectoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.developersToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutToolStripMenuItem.Text = "About Software";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // developersToolStripMenuItem
            // 
            this.developersToolStripMenuItem.Name = "developersToolStripMenuItem";
            this.developersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.developersToolStripMenuItem.Text = "Developers";
            this.developersToolStripMenuItem.Click += new System.EventHandler(this.developersToolStripMenuItem_Click);
            // 
            // label1_Title
            // 
            this.label1_Title.AutoSize = true;
            this.label1_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Title.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1_Title.Location = new System.Drawing.Point(75, 34);
            this.label1_Title.Name = "label1_Title";
            this.label1_Title.Size = new System.Drawing.Size(485, 31);
            this.label1_Title.TabIndex = 2;
            this.label1_Title.Text = "Pneumatic Robotic Manipulator Control";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "A total of 10 movements can be added";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_addPoint);
            this.groupBox2.Controls.Add(this.radioButton1_EE_Rotation);
            this.groupBox2.Controls.Add(this.radioButton1_Unknown);
            this.groupBox2.Controls.Add(this.label9_trajectoryLog);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.postDelay);
            this.groupBox2.Controls.Add(this.preDelay);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1_startStop);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox1_status);
            this.groupBox2.Controls.Add(this.radioButton6_horXZ);
            this.groupBox2.Controls.Add(this.radioButton5_horXY);
            this.groupBox2.Controls.Add(this.radioButton4_vertXY);
            this.groupBox2.Controls.Add(this.radioButton2_gripper);
            this.groupBox2.Location = new System.Drawing.Point(180, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 255);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Develop Trajectory";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_addPoint
            // 
            this.button_addPoint.Location = new System.Drawing.Point(233, 19);
            this.button_addPoint.Name = "button_addPoint";
            this.button_addPoint.Size = new System.Drawing.Size(86, 23);
            this.button_addPoint.TabIndex = 23;
            this.button_addPoint.Text = "Add Point";
            this.button_addPoint.UseVisualStyleBackColor = true;
            this.button_addPoint.Click += new System.EventHandler(this.button_addPoint_Click);
            // 
            // radioButton1_EE_Rotation
            // 
            this.radioButton1_EE_Rotation.AutoSize = true;
            this.radioButton1_EE_Rotation.Location = new System.Drawing.Point(17, 131);
            this.radioButton1_EE_Rotation.Name = "radioButton1_EE_Rotation";
            this.radioButton1_EE_Rotation.Size = new System.Drawing.Size(82, 17);
            this.radioButton1_EE_Rotation.TabIndex = 22;
            this.radioButton1_EE_Rotation.TabStop = true;
            this.radioButton1_EE_Rotation.Text = "EE Rotation";
            this.radioButton1_EE_Rotation.UseVisualStyleBackColor = true;
            this.radioButton1_EE_Rotation.CheckedChanged += new System.EventHandler(this.radioButton1_EE_Rotation_CheckedChanged);
            // 
            // radioButton1_Unknown
            // 
            this.radioButton1_Unknown.AutoSize = true;
            this.radioButton1_Unknown.Location = new System.Drawing.Point(17, 78);
            this.radioButton1_Unknown.Name = "radioButton1_Unknown";
            this.radioButton1_Unknown.Size = new System.Drawing.Size(71, 17);
            this.radioButton1_Unknown.TabIndex = 21;
            this.radioButton1_Unknown.TabStop = true;
            this.radioButton1_Unknown.Text = "Unknown";
            this.radioButton1_Unknown.UseVisualStyleBackColor = true;
            this.radioButton1_Unknown.CheckedChanged += new System.EventHandler(this.radioButton1_Unknown_CheckedChanged);
            // 
            // label9_trajectoryLog
            // 
            this.label9_trajectoryLog.AutoSize = true;
            this.label9_trajectoryLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9_trajectoryLog.Location = new System.Drawing.Point(231, 77);
            this.label9_trajectoryLog.Name = "label9_trajectoryLog";
            this.label9_trajectoryLog.Size = new System.Drawing.Size(193, 13);
            this.label9_trajectoryLog.TabIndex = 20;
            this.label9_trajectoryLog.Text = "Text description in initialization function.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Post-delay (x 100ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pre-delay (x100ms)";
            // 
            // postDelay
            // 
            this.postDelay.Location = new System.Drawing.Point(117, 217);
            this.postDelay.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.postDelay.Name = "postDelay";
            this.postDelay.Size = new System.Drawing.Size(86, 20);
            this.postDelay.TabIndex = 17;
            this.postDelay.ValueChanged += new System.EventHandler(this.postDelay_ValueChanged);
            // 
            // preDelay
            // 
            this.preDelay.Location = new System.Drawing.Point(117, 174);
            this.preDelay.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.preDelay.Name = "preDelay";
            this.preDelay.Size = new System.Drawing.Size(86, 20);
            this.preDelay.TabIndex = 24;
            this.preDelay.ValueChanged += new System.EventHandler(this.preDelay_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Step III: Setup Delay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "A total of 10 movements can be added.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Trajectory Log";
            // 
            // button1_startStop
            // 
            this.button1_startStop.Location = new System.Drawing.Point(233, 216);
            this.button1_startStop.Name = "button1_startStop";
            this.button1_startStop.Size = new System.Drawing.Size(86, 23);
            this.button1_startStop.TabIndex = 11;
            this.button1_startStop.Text = "Start";
            this.button1_startStop.UseVisualStyleBackColor = true;
            this.button1_startStop.Click += new System.EventHandler(this.button1_startStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Step II: Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Step I: Select Joint";
            // 
            // comboBox1_status
            // 
            this.comboBox1_status.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.comboBox1_status.Location = new System.Drawing.Point(117, 78);
            this.comboBox1_status.Name = "comboBox1_status";
            this.comboBox1_status.Size = new System.Drawing.Size(86, 21);
            this.comboBox1_status.TabIndex = 24;
            this.comboBox1_status.Text = "Select Action";
            this.comboBox1_status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_status_SelectedIndexChanged);
            // 
            // radioButton6_horXZ
            // 
            this.radioButton6_horXZ.AutoSize = true;
            this.radioButton6_horXZ.Location = new System.Drawing.Point(17, 220);
            this.radioButton6_horXZ.Name = "radioButton6_horXZ";
            this.radioButton6_horXZ.Size = new System.Drawing.Size(89, 17);
            this.radioButton6_horXZ.TabIndex = 5;
            this.radioButton6_horXZ.TabStop = true;
            this.radioButton6_horXZ.Text = "Horizontal XZ";
            this.radioButton6_horXZ.UseVisualStyleBackColor = true;
            this.radioButton6_horXZ.CheckedChanged += new System.EventHandler(this.radioButton6_horXZ_CheckedChanged);
            // 
            // radioButton5_horXY
            // 
            this.radioButton5_horXY.AutoSize = true;
            this.radioButton5_horXY.Location = new System.Drawing.Point(17, 191);
            this.radioButton5_horXY.Name = "radioButton5_horXY";
            this.radioButton5_horXY.Size = new System.Drawing.Size(89, 17);
            this.radioButton5_horXY.TabIndex = 4;
            this.radioButton5_horXY.TabStop = true;
            this.radioButton5_horXY.Text = "Horizontal XY";
            this.radioButton5_horXY.UseVisualStyleBackColor = true;
            this.radioButton5_horXY.CheckedChanged += new System.EventHandler(this.radioButton5_horXY_CheckedChanged);
            // 
            // radioButton4_vertXY
            // 
            this.radioButton4_vertXY.AutoSize = true;
            this.radioButton4_vertXY.Location = new System.Drawing.Point(17, 162);
            this.radioButton4_vertXY.Name = "radioButton4_vertXY";
            this.radioButton4_vertXY.Size = new System.Drawing.Size(77, 17);
            this.radioButton4_vertXY.TabIndex = 3;
            this.radioButton4_vertXY.TabStop = true;
            this.radioButton4_vertXY.Text = "Vertical XY";
            this.radioButton4_vertXY.UseVisualStyleBackColor = true;
            this.radioButton4_vertXY.CheckedChanged += new System.EventHandler(this.radioButton4_vertXY_CheckedChanged);
            // 
            // radioButton2_gripper
            // 
            this.radioButton2_gripper.AutoSize = true;
            this.radioButton2_gripper.Location = new System.Drawing.Point(17, 104);
            this.radioButton2_gripper.Name = "radioButton2_gripper";
            this.radioButton2_gripper.Size = new System.Drawing.Size(59, 17);
            this.radioButton2_gripper.TabIndex = 1;
            this.radioButton2_gripper.TabStop = true;
            this.radioButton2_gripper.Text = "Gripper";
            this.radioButton2_gripper.UseVisualStyleBackColor = true;
            this.radioButton2_gripper.CheckedChanged += new System.EventHandler(this.radioButton2_gripper_CheckedChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_comPort);
            this.groupBox3.Controls.Add(this.button_connect);
            this.groupBox3.Location = new System.Drawing.Point(12, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 52);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setup Communication";
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.comboBox_comPort.Location = new System.Drawing.Point(7, 19);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(99, 21);
            this.comboBox_comPort.TabIndex = 2;
            this.comboBox_comPort.Text = "Select Com Port";
            this.comboBox_comPort.SelectedIndexChanged += new System.EventHandler(this.comboBox_comPort_SelectedIndexChanged);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(114, 17);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(557, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "v1.0";
            // 
            // bindingSource2
            // 
            this.bindingSource2.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 411);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1_Title);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainWindow_FormClosing(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer1.Stop();
        }
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1_Unknown;
        private System.Windows.Forms.CheckBox checkBox5_Horizontal_XZ_Planar;
        private System.Windows.Forms.CheckBox checkBox4_Horizontal_XY;
        private System.Windows.Forms.CheckBox checkBox3_Vertical_XY;
        private System.Windows.Forms.CheckBox checkBox2_EE_Rotation;
        private System.Windows.Forms.CheckBox checkBox1_Gripper;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1_Title;
        private System.Windows.Forms.Button button2_GotoHome2;
        private System.Windows.Forms.Button button1_GotoHome1;
        private System.Windows.Forms.Label label8_Horizontal_XZ;
        private System.Windows.Forms.Label label7_Horizontal_XY;
        private System.Windows.Forms.Label label6_Vertical_XY;
        private System.Windows.Forms.Label label5_EE_Rotation;
        private System.Windows.Forms.Label label4_Gripper;
        private System.Windows.Forms.Label label3_Unknown;
        private System.Windows.Forms.Timer timer1;

        //Vars for Discrete Motions
        private bool unknownVar_dis;
        private bool gripperVar_dis;
        private bool EERotationVar_dis;
        private bool verticalXYVar_dis;
        private bool horizontalXYVar_dis;
        private bool horizontalXZVar_dis;
        private bool gotoHome1Var_dis;
        private bool gotoHome2Var_dis;

        //Vars for Continuous Motions
        private bool unknownVar_cont;
        private bool gripperVar_cont;
        private bool EERotationVar_cont;
        private bool verticalXYVar_cont;
        private bool horizontalXYVar_cont;
        private bool horizontalXZVar_cont;
        private bool startStopVar_cont;

        private string logText;
        private int logCnt;
        private bool action;
        private int preDelayVar;
        private int postDelayVar;
        private string portName;
        private int baudRate;
        private byte disMotionByte;
        private bool isContThreadRunning;

        const int MAX_MOVEMENTS = 10;
        private int arrayIndex;
        private int[] preDelayArray = new int[MAX_MOVEMENTS];
        private byte[] currLinkArray = new byte[MAX_MOVEMENTS];
        private byte[] currActionArray = new byte[MAX_MOVEMENTS];
        private int[] postDelayArray = new int[MAX_MOVEMENTS];

        System.Threading.Thread contThread;
        
        private void initializeVars()
        {
            unknownVar_dis = false;
            gripperVar_dis = false;
            EERotationVar_dis = false;
            verticalXYVar_dis = false;
            horizontalXYVar_dis = false; 
            horizontalXZVar_dis = false;
            gotoHome1Var_dis = false;
            gotoHome2Var_dis = false;

            unknownVar_cont = false;
            gripperVar_cont = false;
            EERotationVar_cont = false;
            verticalXYVar_cont = false;
            horizontalXYVar_cont = false;
            horizontalXZVar_cont = false;
            startStopVar_cont = false;

            string text = "This section shows trajectory via points";
            text += "\r\n\t".Replace("\t", "     ");
            text += "You need to develop one way trajectory.";
            text += "\n\r\t".Replace("\t", "     ");
            text += "Software will do the round trip.";
            this.label9_trajectoryLog.Text = text;

            logText = "";
            logCnt = 0;
            action = false;
            preDelayVar = 0;
            postDelayVar = 0;
            portName = "COM1";
            baudRate = 115200;
            disMotionByte = 0x00;
            isContThreadRunning = false;
            arrayIndex = 0;
            for (int i = 0; i < MAX_MOVEMENTS; i++)
            {
                preDelayArray[i] = 0;
                currLinkArray[i] = 0xFF;
                currActionArray[i] = 0xFF;
                postDelayArray[i] = 0;
            }
            this.label11.Text = "For HOME\r\n  Please wait\r\n  for some\r\n  time.";
        }

        void createThread()
        {
            contThread = new System.Threading.Thread(new System.Threading.ThreadStart(runCont));
        }

        void runCont()
        {
            while (isContThreadRunning)
            {
                //Forward Motion
                byte sndCmd = 0xFF;
                for (int i = 0; i < MAX_MOVEMENTS; i++) 
                {
                    if (!isContThreadRunning)
                        break;
                    if (currLinkArray[i] != 0xFF)
                    {
                        System.Threading.Thread.Sleep(preDelayArray[i]);
                        sndCmd = (byte) (currLinkArray[i] | currActionArray[i]);
                        serialPort1.Write(new byte[] { sndCmd }, 0, 1);
                        System.Threading.Thread.Sleep(postDelayArray[i]);
                    }
                }

                //Backward Motion
                sndCmd = 0xFF;
                byte invertCurrAction = 0xFF;
                for (int i = MAX_MOVEMENTS - 1; i >= 0; i--) 
                {
                    if (!isContThreadRunning)
                        break;
                    if (currLinkArray[i] != 0xFF)
                    {
                        System.Threading.Thread.Sleep(postDelayArray[i]);
                        if (currActionArray[i] == 0x01)
                            invertCurrAction = 0x00;
                        else if (currActionArray[i] == 0x00)
                            invertCurrAction = 0x01;
                        sndCmd = (byte)(currLinkArray[i] | invertCurrAction);
                        serialPort1.Write(new byte[] { sndCmd }, 0, 1);
                        System.Threading.Thread.Sleep(preDelayArray[i]);
                    }
                }
            }
        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton6_horXZ;
        private System.Windows.Forms.RadioButton radioButton5_horXY;
        private System.Windows.Forms.RadioButton radioButton4_vertXY;
        private System.Windows.Forms.RadioButton radioButton2_gripper;
        private System.Windows.Forms.ComboBox comboBox1_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_startStop;
        private System.Windows.Forms.ToolStripMenuItem developersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveTrajectoryToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown postDelay;
        private System.Windows.Forms.NumericUpDown preDelay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem loadTrajectoryToolStripMenuItem;
        private System.Windows.Forms.Label label9_trajectoryLog;
        private System.Windows.Forms.RadioButton radioButton1_Unknown;
        private System.Windows.Forms.RadioButton radioButton1_EE_Rotation;
        private System.Windows.Forms.Button button_addPoint;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}

