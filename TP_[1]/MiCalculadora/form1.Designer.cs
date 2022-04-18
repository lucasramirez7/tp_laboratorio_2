namespace MiCalculadora
{
    partial class sreen
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
            System.Windows.Forms.Button btnOperar;
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirBin = new System.Windows.Forms.Button();
            this.btnConvertirDec = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.operandoDos = new System.Windows.Forms.TextBox();
            this.operandoUno = new System.Windows.Forms.TextBox();
            this.screen = new System.Windows.Forms.ListBox();
            this.lvResultado = new System.Windows.Forms.Label();
            btnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Location = new System.Drawing.Point(71, 175);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new System.Drawing.Size(139, 39);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(228, 175);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 39);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(376, 175);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(133, 39);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertirBin
            // 
            this.btnConvertirBin.Location = new System.Drawing.Point(71, 244);
            this.btnConvertirBin.Name = "btnConvertirBin";
            this.btnConvertirBin.Size = new System.Drawing.Size(218, 39);
            this.btnConvertirBin.TabIndex = 3;
            this.btnConvertirBin.Text = "Convertir a Binario";
            this.btnConvertirBin.UseVisualStyleBackColor = true;
            this.btnConvertirBin.Click += new System.EventHandler(this.btnConvertirBin_Click);
            // 
            // btnConvertirDec
            // 
            this.btnConvertirDec.Location = new System.Drawing.Point(315, 244);
            this.btnConvertirDec.Name = "btnConvertirDec";
            this.btnConvertirDec.Size = new System.Drawing.Size(194, 39);
            this.btnConvertirDec.TabIndex = 4;
            this.btnConvertirDec.Text = "Convertir a Decimal";
            this.btnConvertirDec.UseVisualStyleBackColor = true;
            this.btnConvertirDec.Click += new System.EventHandler(this.btnConvertirDec_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
            this.comboBox.Location = new System.Drawing.Point(257, 77);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(72, 40);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(0, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 11;
            // 
            // operandoDos
            // 
            this.operandoDos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operandoDos.Location = new System.Drawing.Point(376, 78);
            this.operandoDos.Name = "operandoDos";
            this.operandoDos.Size = new System.Drawing.Size(133, 39);
            this.operandoDos.TabIndex = 7;
            // 
            // operandoUno
            // 
            this.operandoUno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operandoUno.Location = new System.Drawing.Point(71, 79);
            this.operandoUno.Name = "operandoUno";
            this.operandoUno.Size = new System.Drawing.Size(139, 39);
            this.operandoUno.TabIndex = 8;
            this.operandoUno.TextChanged += new System.EventHandler(this.operandoUno_TextChanged);
            // 
            // screen
            // 
            this.screen.FormattingEnabled = true;
            this.screen.ItemHeight = 15;
            this.screen.Location = new System.Drawing.Point(544, 30);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(191, 274);
            this.screen.TabIndex = 10;
            this.screen.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lvResultado
            // 
            this.lvResultado.AutoSize = true;
            this.lvResultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvResultado.Location = new System.Drawing.Point(376, 30);
            this.lvResultado.Name = "lvResultado";
            this.lvResultado.Size = new System.Drawing.Size(22, 25);
            this.lvResultado.TabIndex = 12;
            this.lvResultado.Text = "0";
            // 
            // sreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(758, 328);
            this.Controls.Add(this.lvResultado);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.operandoUno);
            this.Controls.Add(this.operandoDos);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btnConvertirDec);
            this.Controls.Add(this.btnConvertirBin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(btnOperar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Ramirez Lucas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirBin;
        private System.Windows.Forms.Button btnConvertirDec;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox operandoDos;
        private System.Windows.Forms.TextBox operandoUno;
        private System.Windows.Forms.ListBox screen;
        private System.Windows.Forms.Label lvResultado;
    }
}
