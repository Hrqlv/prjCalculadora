namespace prjCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lbVisor = new System.Windows.Forms.Label();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btInverterSinal = new System.Windows.Forms.Button();
            this.btPontoDecimal = new System.Windows.Forms.Button();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btSomar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btRaiz = new System.Windows.Forms.Button();
            this.btQuadrado = new System.Windows.Forms.Button();
            this.btFraçao = new System.Windows.Forms.Button();
            this.btBackSpace = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btPorcentagem = new System.Windows.Forms.Button();
            this.btSeno = new System.Windows.Forms.Button();
            this.btLog = new System.Windows.Forms.Button();
            this.btPi = new System.Windows.Forms.Button();
            this.btTangente = new System.Windows.Forms.Button();
            this.btCosseno = new System.Windows.Forms.Button();
            this.btE = new System.Windows.Forms.Button();
            this.lbCalculo = new System.Windows.Forms.Label();
            this.pnSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.SkyBlue;
            this.pnSuperior.Controls.Add(this.lbVisor);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(477, 172);
            this.pnSuperior.TabIndex = 0;
            // 
            // lbVisor
            // 
            this.lbVisor.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbVisor.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisor.ForeColor = System.Drawing.Color.White;
            this.lbVisor.Location = new System.Drawing.Point(135, 55);
            this.lbVisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVisor.Name = "lbVisor";
            this.lbVisor.Size = new System.Drawing.Size(318, 63);
            this.lbVisor.TabIndex = 0;
            this.lbVisor.Text = "0";
            this.lbVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt0
            // 
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt0.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(93, 564);
            this.bt0.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(80, 72);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt3
            // 
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(178, 486);
            this.bt3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(80, 72);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(93, 486);
            this.bt2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(80, 72);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(0, 486);
            this.bt1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(89, 72);
            this.bt1.TabIndex = 4;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt4
            // 
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(0, 410);
            this.bt4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(89, 72);
            this.bt4.TabIndex = 5;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt6
            // 
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(178, 410);
            this.bt6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(80, 72);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(94, 410);
            this.bt5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(80, 72);
            this.bt5.TabIndex = 7;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt7
            // 
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt7.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(0, 334);
            this.bt7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(89, 72);
            this.bt7.TabIndex = 8;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt8.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(94, 332);
            this.bt8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(80, 72);
            this.bt8.TabIndex = 9;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt9.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(178, 332);
            this.bt9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(80, 72);
            this.bt9.TabIndex = 10;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btInverterSinal
            // 
            this.btInverterSinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInverterSinal.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInverterSinal.Location = new System.Drawing.Point(2, 564);
            this.btInverterSinal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btInverterSinal.Name = "btInverterSinal";
            this.btInverterSinal.Size = new System.Drawing.Size(87, 72);
            this.btInverterSinal.TabIndex = 11;
            this.btInverterSinal.Text = "+-";
            this.btInverterSinal.UseVisualStyleBackColor = true;
            this.btInverterSinal.Click += new System.EventHandler(this.btInverterSinal_Click);
            // 
            // btPontoDecimal
            // 
            this.btPontoDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPontoDecimal.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPontoDecimal.Location = new System.Drawing.Point(178, 564);
            this.btPontoDecimal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPontoDecimal.Name = "btPontoDecimal";
            this.btPontoDecimal.Size = new System.Drawing.Size(80, 72);
            this.btPontoDecimal.TabIndex = 12;
            this.btPontoDecimal.Text = ",";
            this.btPontoDecimal.UseVisualStyleBackColor = true;
            this.btPontoDecimal.Click += new System.EventHandler(this.btPontoDecimal_Click);
            // 
            // btSubtrair
            // 
            this.btSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubtrair.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubtrair.Location = new System.Drawing.Point(262, 410);
            this.btSubtrair.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(92, 72);
            this.btSubtrair.TabIndex = 13;
            this.btSubtrair.Text = "-";
            this.btSubtrair.UseVisualStyleBackColor = true;
            this.btSubtrair.Click += new System.EventHandler(this.btSubtrair_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMultiplicar.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicar.Location = new System.Drawing.Point(262, 332);
            this.btMultiplicar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(92, 72);
            this.btMultiplicar.TabIndex = 14;
            this.btMultiplicar.Text = "X";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btDividir
            // 
            this.btDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDividir.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDividir.Location = new System.Drawing.Point(270, 256);
            this.btDividir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(96, 72);
            this.btDividir.TabIndex = 15;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btSomar
            // 
            this.btSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSomar.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSomar.Location = new System.Drawing.Point(262, 488);
            this.btSomar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(94, 72);
            this.btSomar.TabIndex = 16;
            this.btSomar.Text = "+";
            this.btSomar.UseVisualStyleBackColor = true;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalcular.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(262, 564);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(92, 72);
            this.btCalcular.TabIndex = 17;
            this.btCalcular.Text = "=";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btRaiz
            // 
            this.btRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRaiz.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRaiz.Location = new System.Drawing.Point(164, 256);
            this.btRaiz.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btRaiz.Name = "btRaiz";
            this.btRaiz.Size = new System.Drawing.Size(102, 72);
            this.btRaiz.TabIndex = 18;
            this.btRaiz.Text = "RAIZ";
            this.btRaiz.UseVisualStyleBackColor = true;
            this.btRaiz.Click += new System.EventHandler(this.btRaiz_Click);
            // 
            // btQuadrado
            // 
            this.btQuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuadrado.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuadrado.Location = new System.Drawing.Point(84, 256);
            this.btQuadrado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btQuadrado.Name = "btQuadrado";
            this.btQuadrado.Size = new System.Drawing.Size(80, 72);
            this.btQuadrado.TabIndex = 19;
            this.btQuadrado.Text = "QUA";
            this.btQuadrado.UseVisualStyleBackColor = true;
            this.btQuadrado.Click += new System.EventHandler(this.btQuadrado_Click);
            // 
            // btFraçao
            // 
            this.btFraçao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFraçao.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFraçao.Location = new System.Drawing.Point(0, 256);
            this.btFraçao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btFraçao.Name = "btFraçao";
            this.btFraçao.Size = new System.Drawing.Size(82, 72);
            this.btFraçao.TabIndex = 20;
            this.btFraçao.Text = "1/X";
            this.btFraçao.UseVisualStyleBackColor = true;
            this.btFraçao.Click += new System.EventHandler(this.btFraçao_Click);
            // 
            // btBackSpace
            // 
            this.btBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackSpace.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackSpace.Location = new System.Drawing.Point(252, 178);
            this.btBackSpace.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btBackSpace.Name = "btBackSpace";
            this.btBackSpace.Size = new System.Drawing.Size(106, 72);
            this.btBackSpace.TabIndex = 21;
            this.btBackSpace.Text = "BACK";
            this.btBackSpace.UseVisualStyleBackColor = true;
            this.btBackSpace.Click += new System.EventHandler(this.btBackSpace_Click);
            // 
            // btC
            // 
            this.btC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btC.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.ForeColor = System.Drawing.Color.White;
            this.btC.Location = new System.Drawing.Point(168, 178);
            this.btC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(80, 72);
            this.btC.TabIndex = 22;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btCE
            // 
            this.btCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCE.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.Location = new System.Drawing.Point(84, 178);
            this.btCE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(80, 72);
            this.btCE.TabIndex = 23;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btPorcentagem
            // 
            this.btPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPorcentagem.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPorcentagem.ForeColor = System.Drawing.Color.White;
            this.btPorcentagem.Location = new System.Drawing.Point(0, 178);
            this.btPorcentagem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPorcentagem.Name = "btPorcentagem";
            this.btPorcentagem.Size = new System.Drawing.Size(82, 72);
            this.btPorcentagem.TabIndex = 24;
            this.btPorcentagem.Text = "%";
            this.btPorcentagem.UseVisualStyleBackColor = true;
            this.btPorcentagem.Click += new System.EventHandler(this.btPorcentagem_Click);
            // 
            // btSeno
            // 
            this.btSeno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSeno.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeno.Location = new System.Drawing.Point(370, 256);
            this.btSeno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSeno.Name = "btSeno";
            this.btSeno.Size = new System.Drawing.Size(107, 72);
            this.btSeno.TabIndex = 25;
            this.btSeno.Text = "SIN";
            this.btSeno.UseVisualStyleBackColor = true;
            this.btSeno.Click += new System.EventHandler(this.btSeno_Click);
            // 
            // btLog
            // 
            this.btLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLog.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLog.Location = new System.Drawing.Point(359, 178);
            this.btLog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(118, 72);
            this.btLog.TabIndex = 26;
            this.btLog.Text = "LOG";
            this.btLog.UseVisualStyleBackColor = true;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // btPi
            // 
            this.btPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPi.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPi.Location = new System.Drawing.Point(360, 486);
            this.btPi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPi.Name = "btPi";
            this.btPi.Size = new System.Drawing.Size(117, 72);
            this.btPi.TabIndex = 27;
            this.btPi.Text = "PI";
            this.btPi.UseVisualStyleBackColor = true;
            this.btPi.Click += new System.EventHandler(this.btPi_Click);
            // 
            // btTangente
            // 
            this.btTangente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTangente.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTangente.Location = new System.Drawing.Point(358, 410);
            this.btTangente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btTangente.Name = "btTangente";
            this.btTangente.Size = new System.Drawing.Size(119, 72);
            this.btTangente.TabIndex = 28;
            this.btTangente.Text = "TAN";
            this.btTangente.UseVisualStyleBackColor = true;
            this.btTangente.Click += new System.EventHandler(this.btTangente_Click);
            // 
            // btCosseno
            // 
            this.btCosseno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCosseno.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCosseno.Location = new System.Drawing.Point(360, 332);
            this.btCosseno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btCosseno.Name = "btCosseno";
            this.btCosseno.Size = new System.Drawing.Size(117, 72);
            this.btCosseno.TabIndex = 29;
            this.btCosseno.Text = "COS";
            this.btCosseno.UseVisualStyleBackColor = true;
            this.btCosseno.Click += new System.EventHandler(this.btCosseno_Click);
            // 
            // btE
            // 
            this.btE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btE.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btE.Location = new System.Drawing.Point(360, 564);
            this.btE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btE.Name = "btE";
            this.btE.Size = new System.Drawing.Size(117, 72);
            this.btE.TabIndex = 30;
            this.btE.Text = "e";
            this.btE.UseVisualStyleBackColor = true;
            this.btE.Click += new System.EventHandler(this.btE_Click);
            // 
            // lbCalculo
            // 
            this.lbCalculo.BackColor = System.Drawing.Color.SkyBlue;
            this.lbCalculo.Font = new System.Drawing.Font("Quartz", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculo.ForeColor = System.Drawing.Color.White;
            this.lbCalculo.Location = new System.Drawing.Point(135, 667);
            this.lbCalculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCalculo.Name = "lbCalculo";
            this.lbCalculo.Size = new System.Drawing.Size(318, 63);
            this.lbCalculo.TabIndex = 31;
            this.lbCalculo.Text = "Calculo";
            this.lbCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(477, 759);
            this.Controls.Add(this.lbCalculo);
            this.Controls.Add(this.btE);
            this.Controls.Add(this.btCosseno);
            this.Controls.Add(this.btTangente);
            this.Controls.Add(this.btPi);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.btSeno);
            this.Controls.Add(this.btPorcentagem);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btBackSpace);
            this.Controls.Add(this.btFraçao);
            this.Controls.Add(this.btQuadrado);
            this.Controls.Add(this.btRaiz);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btSomar);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btSubtrair);
            this.Controls.Add(this.btPontoDecimal);
            this.Controls.Add(this.btInverterSinal);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.pnSuperior);
            this.Font = new System.Drawing.Font("Quartz", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lbVisor;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btInverterSinal;
        private System.Windows.Forms.Button btPontoDecimal;
        private System.Windows.Forms.Button btSubtrair;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btRaiz;
        private System.Windows.Forms.Button btQuadrado;
        private System.Windows.Forms.Button btFraçao;
        private System.Windows.Forms.Button btBackSpace;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btPorcentagem;
        private System.Windows.Forms.Button btSeno;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Button btPi;
        private System.Windows.Forms.Button btTangente;
        private System.Windows.Forms.Button btCosseno;
        private System.Windows.Forms.Button btE;
        private System.Windows.Forms.Label lbCalculo;
    }
}

