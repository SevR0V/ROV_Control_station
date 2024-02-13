namespace SevROVClient
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectButton = new System.Windows.Forms.Button();
            this.hostInput = new System.Windows.Forms.TextBox();
            this.portInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.connectionStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depth_stabilization_check = new System.Windows.Forms.CheckBox();
            this.yaw_stabilization_check = new System.Windows.Forms.CheckBox();
            this.pitch_stabilization_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rollSetPoint = new System.Windows.Forms.Label();
            this.pitchSetPoint = new System.Windows.Forms.Label();
            this.powerLimitValue1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.roll_stabilization_check = new System.Windows.Forms.CheckBox();
            this.depthBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yawBox = new System.Windows.Forms.Label();
            this.pitchBox = new System.Windows.Forms.Label();
            this.rollBox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rollKp = new System.Windows.Forms.NumericUpDown();
            this.pitchKp = new System.Windows.Forms.NumericUpDown();
            this.depthKp = new System.Windows.Forms.NumericUpDown();
            this.rollKi = new System.Windows.Forms.NumericUpDown();
            this.pitchKi = new System.Windows.Forms.NumericUpDown();
            this.depthKi = new System.Windows.Forms.NumericUpDown();
            this.depthKd = new System.Windows.Forms.NumericUpDown();
            this.pitchKd = new System.Windows.Forms.NumericUpDown();
            this.rollKd = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CameraBtn = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label16 = new System.Windows.Forms.Label();
            this.yawKd = new System.Windows.Forms.NumericUpDown();
            this.yawKi = new System.Windows.Forms.NumericUpDown();
            this.yawKp = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.portInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerLimitValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawKp)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(17, 91);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(324, 35);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // hostInput
            // 
            this.hostInput.Location = new System.Drawing.Point(64, 40);
            this.hostInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hostInput.Name = "hostInput";
            this.hostInput.Size = new System.Drawing.Size(148, 26);
            this.hostInput.TabIndex = 0;
            this.hostInput.Text = "192.169.10.100";
            this.hostInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(271, 41);
            this.portInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portInput.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(69, 26);
            this.portInput.TabIndex = 1;
            this.portInput.Value = new decimal(new int[] {
            1337,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Host:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.Location = new System.Drawing.Point(87, 139);
            this.connectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(107, 20);
            this.connectionStatus.TabIndex = 11;
            this.connectionStatus.Text = "Disconnected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectionStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hostInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.portInput);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(397, 195);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.depth_stabilization_check);
            this.groupBox2.Controls.Add(this.yaw_stabilization_check);
            this.groupBox2.Controls.Add(this.pitch_stabilization_check);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rollSetPoint);
            this.groupBox2.Controls.Add(this.pitchSetPoint);
            this.groupBox2.Controls.Add(this.powerLimitValue1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.roll_stabilization_check);
            this.groupBox2.Controls.Add(this.depthBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.yawBox);
            this.groupBox2.Controls.Add(this.pitchBox);
            this.groupBox2.Controls.Add(this.rollBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(18, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(397, 182);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telemetry";
            // 
            // depth_stabilization_check
            // 
            this.depth_stabilization_check.AutoSize = true;
            this.depth_stabilization_check.Location = new System.Drawing.Point(296, 115);
            this.depth_stabilization_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depth_stabilization_check.Name = "depth_stabilization_check";
            this.depth_stabilization_check.Size = new System.Drawing.Size(113, 24);
            this.depth_stabilization_check.TabIndex = 23;
            this.depth_stabilization_check.Text = "DepthStab";
            this.depth_stabilization_check.UseVisualStyleBackColor = true;
            // 
            // yaw_stabilization_check
            // 
            this.yaw_stabilization_check.AutoSize = true;
            this.yaw_stabilization_check.Location = new System.Drawing.Point(205, 115);
            this.yaw_stabilization_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yaw_stabilization_check.Name = "yaw_stabilization_check";
            this.yaw_stabilization_check.Size = new System.Drawing.Size(100, 24);
            this.yaw_stabilization_check.TabIndex = 22;
            this.yaw_stabilization_check.Text = "YawStab";
            this.yaw_stabilization_check.UseVisualStyleBackColor = true;
            // 
            // pitch_stabilization_check
            // 
            this.pitch_stabilization_check.AutoSize = true;
            this.pitch_stabilization_check.Location = new System.Drawing.Point(109, 115);
            this.pitch_stabilization_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pitch_stabilization_check.Name = "pitch_stabilization_check";
            this.pitch_stabilization_check.Size = new System.Drawing.Size(104, 24);
            this.pitch_stabilization_check.TabIndex = 21;
            this.pitch_stabilization_check.Text = "PitchStab";
            this.pitch_stabilization_check.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Set points:";
            // 
            // rollSetPoint
            // 
            this.rollSetPoint.AutoSize = true;
            this.rollSetPoint.Location = new System.Drawing.Point(267, 31);
            this.rollSetPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rollSetPoint.Name = "rollSetPoint";
            this.rollSetPoint.Size = new System.Drawing.Size(14, 20);
            this.rollSetPoint.TabIndex = 19;
            this.rollSetPoint.Text = "-";
            // 
            // pitchSetPoint
            // 
            this.pitchSetPoint.AutoSize = true;
            this.pitchSetPoint.Location = new System.Drawing.Point(267, 51);
            this.pitchSetPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pitchSetPoint.Name = "pitchSetPoint";
            this.pitchSetPoint.Size = new System.Drawing.Size(14, 20);
            this.pitchSetPoint.TabIndex = 17;
            this.pitchSetPoint.Text = "-";
            // 
            // powerLimitValue1
            // 
            this.powerLimitValue1.DecimalPlaces = 1;
            this.powerLimitValue1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.powerLimitValue1.Location = new System.Drawing.Point(118, 142);
            this.powerLimitValue1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powerLimitValue1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.powerLimitValue1.Name = "powerLimitValue1";
            this.powerLimitValue1.Size = new System.Drawing.Size(53, 26);
            this.powerLimitValue1.TabIndex = 16;
            this.powerLimitValue1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Power Limit";
            // 
            // roll_stabilization_check
            // 
            this.roll_stabilization_check.AutoSize = true;
            this.roll_stabilization_check.Location = new System.Drawing.Point(21, 115);
            this.roll_stabilization_check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roll_stabilization_check.Name = "roll_stabilization_check";
            this.roll_stabilization_check.Size = new System.Drawing.Size(96, 24);
            this.roll_stabilization_check.TabIndex = 14;
            this.roll_stabilization_check.Text = "RollStab";
            this.roll_stabilization_check.UseVisualStyleBackColor = true;
            this.roll_stabilization_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // depthBox
            // 
            this.depthBox.AutoSize = true;
            this.depthBox.Location = new System.Drawing.Point(87, 91);
            this.depthBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(14, 20);
            this.depthBox.TabIndex = 13;
            this.depthBox.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Depth";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yawBox
            // 
            this.yawBox.AutoSize = true;
            this.yawBox.Location = new System.Drawing.Point(87, 71);
            this.yawBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yawBox.Name = "yawBox";
            this.yawBox.Size = new System.Drawing.Size(14, 20);
            this.yawBox.TabIndex = 8;
            this.yawBox.Text = "-";
            // 
            // pitchBox
            // 
            this.pitchBox.AutoSize = true;
            this.pitchBox.Location = new System.Drawing.Point(87, 51);
            this.pitchBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pitchBox.Name = "pitchBox";
            this.pitchBox.Size = new System.Drawing.Size(14, 20);
            this.pitchBox.TabIndex = 6;
            this.pitchBox.Text = "-";
            // 
            // rollBox
            // 
            this.rollBox.AutoSize = true;
            this.rollBox.Location = new System.Drawing.Point(87, 31);
            this.rollBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rollBox.Name = "rollBox";
            this.rollBox.Size = new System.Drawing.Size(14, 20);
            this.rollBox.TabIndex = 4;
            this.rollBox.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Yaw";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pitch";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Roll";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rollKp
            // 
            this.rollKp.DecimalPlaces = 1;
            this.rollKp.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.rollKp.Location = new System.Drawing.Point(98, 466);
            this.rollKp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rollKp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.rollKp.Name = "rollKp";
            this.rollKp.Size = new System.Drawing.Size(91, 26);
            this.rollKp.TabIndex = 21;
            this.rollKp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // pitchKp
            // 
            this.pitchKp.DecimalPlaces = 1;
            this.pitchKp.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.pitchKp.Location = new System.Drawing.Point(98, 506);
            this.pitchKp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pitchKp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.pitchKp.Name = "pitchKp";
            this.pitchKp.Size = new System.Drawing.Size(91, 26);
            this.pitchKp.TabIndex = 22;
            this.pitchKp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // depthKp
            // 
            this.depthKp.DecimalPlaces = 1;
            this.depthKp.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.depthKp.Location = new System.Drawing.Point(97, 588);
            this.depthKp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depthKp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.depthKp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.depthKp.Name = "depthKp";
            this.depthKp.Size = new System.Drawing.Size(92, 26);
            this.depthKp.TabIndex = 23;
            this.depthKp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rollKi
            // 
            this.rollKi.DecimalPlaces = 1;
            this.rollKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rollKi.Location = new System.Drawing.Point(198, 466);
            this.rollKi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rollKi.Name = "rollKi";
            this.rollKi.Size = new System.Drawing.Size(80, 26);
            this.rollKi.TabIndex = 24;
            // 
            // pitchKi
            // 
            this.pitchKi.DecimalPlaces = 1;
            this.pitchKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.pitchKi.Location = new System.Drawing.Point(198, 506);
            this.pitchKi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pitchKi.Name = "pitchKi";
            this.pitchKi.Size = new System.Drawing.Size(80, 26);
            this.pitchKi.TabIndex = 25;
            // 
            // depthKi
            // 
            this.depthKi.DecimalPlaces = 1;
            this.depthKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.depthKi.Location = new System.Drawing.Point(198, 588);
            this.depthKi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depthKi.Name = "depthKi";
            this.depthKi.Size = new System.Drawing.Size(80, 26);
            this.depthKi.TabIndex = 26;
            // 
            // depthKd
            // 
            this.depthKd.DecimalPlaces = 2;
            this.depthKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.depthKd.Location = new System.Drawing.Point(287, 588);
            this.depthKd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depthKd.Name = "depthKd";
            this.depthKd.Size = new System.Drawing.Size(80, 26);
            this.depthKd.TabIndex = 29;
            // 
            // pitchKd
            // 
            this.pitchKd.DecimalPlaces = 2;
            this.pitchKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pitchKd.Location = new System.Drawing.Point(287, 508);
            this.pitchKd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pitchKd.Name = "pitchKd";
            this.pitchKd.Size = new System.Drawing.Size(80, 26);
            this.pitchKd.TabIndex = 28;
            // 
            // rollKd
            // 
            this.rollKd.DecimalPlaces = 2;
            this.rollKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.rollKd.Location = new System.Drawing.Point(287, 466);
            this.rollKd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rollKd.Name = "rollKd";
            this.rollKd.Size = new System.Drawing.Size(80, 26);
            this.rollKd.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 441);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Kp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 441);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Ki";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 441);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Kd";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 590);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Depth";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 511);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Pitch";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 469);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Roll";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(44, 626);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(324, 35);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 671);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 35);
            this.button1.TabIndex = 32;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CameraBtn
            // 
            this.CameraBtn.Location = new System.Drawing.Point(44, 715);
            this.CameraBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CameraBtn.Name = "CameraBtn";
            this.CameraBtn.Size = new System.Drawing.Size(324, 35);
            this.CameraBtn.TabIndex = 33;
            this.CameraBtn.Text = "Камера";
            this.CameraBtn.UseVisualStyleBackColor = true;
            this.CameraBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(454, 16);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1108, 901);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 548);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Yaw";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // yawKd
            // 
            this.yawKd.DecimalPlaces = 2;
            this.yawKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.yawKd.Location = new System.Drawing.Point(287, 545);
            this.yawKd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yawKd.Name = "yawKd";
            this.yawKd.Size = new System.Drawing.Size(80, 26);
            this.yawKd.TabIndex = 37;
            this.yawKd.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // yawKi
            // 
            this.yawKi.DecimalPlaces = 1;
            this.yawKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yawKi.Location = new System.Drawing.Point(198, 545);
            this.yawKi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yawKi.Name = "yawKi";
            this.yawKi.Size = new System.Drawing.Size(80, 26);
            this.yawKi.TabIndex = 36;
            this.yawKi.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // yawKp
            // 
            this.yawKp.DecimalPlaces = 1;
            this.yawKp.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.yawKp.Location = new System.Drawing.Point(97, 545);
            this.yawKp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yawKp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yawKp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yawKp.Name = "yawKp";
            this.yawKp.Size = new System.Drawing.Size(92, 26);
            this.yawKp.TabIndex = 35;
            this.yawKp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yawKp.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 760);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 35);
            this.button2.TabIndex = 40;
            this.button2.Text = "Камера Стоп";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 939);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.yawKd);
            this.Controls.Add(this.yawKi);
            this.Controls.Add(this.yawKp);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.CameraBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.depthKd);
            this.Controls.Add(this.pitchKd);
            this.Controls.Add(this.rollKd);
            this.Controls.Add(this.depthKi);
            this.Controls.Add(this.pitchKi);
            this.Controls.Add(this.rollKi);
            this.Controls.Add(this.depthKp);
            this.Controls.Add(this.pitchKp);
            this.Controls.Add(this.rollKp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "SEVROV v2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerLimitValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawKp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown portInput;
        private System.Windows.Forms.TextBox hostInput;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label yawBox;
        private System.Windows.Forms.Label pitchBox;
        private System.Windows.Forms.Label rollBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label depthBox;
        private System.Windows.Forms.CheckBox roll_stabilization_check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown powerLimitValue1;
        private System.Windows.Forms.Label rollSetPoint;
        private System.Windows.Forms.Label pitchSetPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rollKp;
        private System.Windows.Forms.NumericUpDown pitchKp;
        private System.Windows.Forms.NumericUpDown depthKp;
        private System.Windows.Forms.NumericUpDown rollKi;
        private System.Windows.Forms.NumericUpDown pitchKi;
        private System.Windows.Forms.NumericUpDown depthKi;
        private System.Windows.Forms.NumericUpDown depthKd;
        private System.Windows.Forms.NumericUpDown pitchKd;
        private System.Windows.Forms.NumericUpDown rollKd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CameraBtn;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.CheckBox depth_stabilization_check;
        private System.Windows.Forms.CheckBox yaw_stabilization_check;
        private System.Windows.Forms.CheckBox pitch_stabilization_check;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown yawKd;
        private System.Windows.Forms.NumericUpDown yawKi;
        private System.Windows.Forms.NumericUpDown yawKp;
        private System.Windows.Forms.Button button2;
    }
}

