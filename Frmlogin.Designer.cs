namespace Login
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnlimpiar = new Button();
            btningresar = new Button();
            txtcontrasena = new TextBox();
            txtusuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(198, 26);
            label1.Name = "label1";
            label1.Size = new Size(324, 40);
            label1.TabIndex = 0;
            label1.Text = "ACCESO RESTRINGIDO";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnlimpiar);
            groupBox1.Controls.Add(btningresar);
            groupBox1.Controls.Add(txtcontrasena);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(73, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 365);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "INGRESE LOS DATOS REQUERIDOS";
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(278, 141);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(171, 36);
            btnlimpiar.TabIndex = 2;
            btnlimpiar.Text = "LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btningresar
            // 
            btningresar.Location = new Point(278, 52);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(171, 36);
            btningresar.TabIndex = 2;
            btningresar.Text = "INGRESAR";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(25, 148);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.Size = new Size(173, 29);
            txtcontrasena.TabIndex = 1;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(25, 59);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(173, 29);
            txtusuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 114);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 0;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 33);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 0;
            label2.Text = "INGRESE USUARIO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 881);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "SEGURIDAD DE SISTEMA";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtcontrasena;
        private TextBox txtusuario;
        private Label label3;
        private Label label2;
        private Button btnlimpiar;
        private Button btningresar;
    }
}