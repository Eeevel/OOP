
namespace Laba2
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFigure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnFuchsia = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnCyan = new System.Windows.Forms.Button();
            this.btnLime = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(604, 426);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(682, 259);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 25);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать фигуру";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(622, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фигура";
            // 
            // textBoxFigure
            // 
            this.textBoxFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFigure.Location = new System.Drawing.Point(682, 12);
            this.textBoxFigure.Name = "textBoxFigure";
            this.textBoxFigure.Size = new System.Drawing.Size(106, 20);
            this.textBoxFigure.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ширина";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(682, 38);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(106, 20);
            this.textBoxWidth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Высота";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(682, 64);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(106, 20);
            this.textBoxHeight.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цвет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(682, 90);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(106, 20);
            this.textBoxX.TabIndex = 11;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(682, 116);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(106, 20);
            this.textBoxY.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBlack);
            this.panel1.Controls.Add(this.btnFuchsia);
            this.panel1.Controls.Add(this.btnBlue);
            this.panel1.Controls.Add(this.btnCyan);
            this.panel1.Controls.Add(this.btnLime);
            this.panel1.Controls.Add(this.btnYellow);
            this.panel1.Controls.Add(this.btnOrange);
            this.panel1.Controls.Add(this.btnRed);
            this.panel1.Controls.Add(this.btnWhite);
            this.panel1.Location = new System.Drawing.Point(678, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 111);
            this.panel1.TabIndex = 14;
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(76, 76);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(30, 30);
            this.btnBlack.TabIndex = 22;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.MouseCaptureChanged += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnFuchsia
            // 
            this.btnFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.btnFuchsia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuchsia.Location = new System.Drawing.Point(40, 76);
            this.btnFuchsia.Name = "btnFuchsia";
            this.btnFuchsia.Size = new System.Drawing.Size(30, 30);
            this.btnFuchsia.TabIndex = 21;
            this.btnFuchsia.UseVisualStyleBackColor = false;
            this.btnFuchsia.MouseCaptureChanged += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(4, 76);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(30, 30);
            this.btnBlue.TabIndex = 20;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.MouseCaptureChanged += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnCyan
            // 
            this.btnCyan.BackColor = System.Drawing.Color.Cyan;
            this.btnCyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCyan.Location = new System.Drawing.Point(76, 40);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(30, 30);
            this.btnCyan.TabIndex = 19;
            this.btnCyan.UseVisualStyleBackColor = false;
            this.btnCyan.MouseCaptureChanged += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnLime
            // 
            this.btnLime.BackColor = System.Drawing.Color.Lime;
            this.btnLime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLime.Location = new System.Drawing.Point(40, 40);
            this.btnLime.Name = "btnLime";
            this.btnLime.Size = new System.Drawing.Size(30, 30);
            this.btnLime.TabIndex = 18;
            this.btnLime.UseVisualStyleBackColor = false;
            this.btnLime.MouseCaptureChanged += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(4, 40);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(30, 30);
            this.btnYellow.TabIndex = 17;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.MouseCaptureChanged += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.Location = new System.Drawing.Point(76, 4);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(30, 30);
            this.btnOrange.TabIndex = 16;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.MouseCaptureChanged += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(40, 4);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(30, 30);
            this.btnRed.TabIndex = 15;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.MouseCaptureChanged += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhite.Location = new System.Drawing.Point(4, 4);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(30, 30);
            this.btnWhite.TabIndex = 0;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            this.btnWhite.MouseCaptureChanged += new System.EventHandler(this.btnWhite_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(625, 424);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFigure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.picture);
            this.Name = "MainForm";
            this.Text = "Редактор фигур";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFigure;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnFuchsia;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnCyan;
        private System.Windows.Forms.Button btnLime;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Label lbError;
    }
}

