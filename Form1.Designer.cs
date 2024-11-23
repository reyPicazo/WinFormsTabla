namespace WinFormsTabla
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
            panelPrincipal = new Panel();
            richTextBoxPrueba = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelAux = new Label();
            nameTabla = new Label();
            name = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Teal;
            panelPrincipal.Controls.Add(richTextBoxPrueba);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(labelAux);
            panelPrincipal.Controls.Add(nameTabla);
            panelPrincipal.Controls.Add(name);
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(788, 438);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxPrueba
            // 
            richTextBoxPrueba.Location = new Point(237, 66);
            richTextBoxPrueba.Name = "richTextBoxPrueba";
            richTextBoxPrueba.Size = new Size(198, 212);
            richTextBoxPrueba.TabIndex = 5;
            richTextBoxPrueba.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.Location = new Point(40, 242);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(157, 36);
            buttonVer.TabIndex = 4;
            buttonVer.Text = "Ver Tabla";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += button1_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(40, 174);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(157, 31);
            textBoxNum.TabIndex = 3;
            textBoxNum.TextChanged += textBoxNum_TextChanged;
            // 
            // labelAux
            // 
            labelAux.AutoSize = true;
            labelAux.ForeColor = SystemColors.ButtonFace;
            labelAux.Location = new Point(37, 122);
            labelAux.Name = "labelAux";
            labelAux.Size = new Size(168, 25);
            labelAux.TabIndex = 2;
            labelAux.Text = "¿Cual tabla quieres?";
            // 
            // nameTabla
            // 
            nameTabla.AutoSize = true;
            nameTabla.ForeColor = SystemColors.ButtonFace;
            nameTabla.Location = new Point(37, 69);
            nameTabla.Name = "nameTabla";
            nameTabla.Size = new Size(164, 25);
            nameTabla.TabIndex = 1;
            nameTabla.Text = "Tabla de Multiplicar";
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Teal;
            name.ForeColor = SystemColors.Control;
            name.Location = new Point(37, 31);
            name.Name = "name";
            name.Size = new Size(315, 25);
            name.TabIndex = 0;
            name.Text = "Rey Emmanuel Picazo Perez Id 300388";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label name;
        private RichTextBox richTextBoxPrueba;
        private Button button1;
        private TextBox textBoxNum;
        private Label labelAux;
        private Label nameTabla;
        private Button buttonVer;
    }
}
