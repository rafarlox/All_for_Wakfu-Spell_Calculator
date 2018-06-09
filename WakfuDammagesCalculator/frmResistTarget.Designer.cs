namespace WakfuDammagesCalculator
{
    partial class frmResistTarget
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
            this.btnOk = new System.Windows.Forms.Button();
            this.tbxDmgReceived = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxHeal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxBack = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxCritic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxElementary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbParade20 = new System.Windows.Forms.RadioButton();
            this.rdbParade30 = new System.Windows.Forms.RadioButton();
            this.rdbParade35 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxBarrier = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxHealReceived = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(265, 220);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 37;
            this.btnOk.Text = "Enregistrer";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tbxDmgReceived
            // 
            this.tbxDmgReceived.Location = new System.Drawing.Point(146, 158);
            this.tbxDmgReceived.MaxLength = 3;
            this.tbxDmgReceived.Name = "tbxDmgReceived";
            this.tbxDmgReceived.ShortcutsEnabled = false;
            this.tbxDmgReceived.Size = new System.Drawing.Size(46, 20);
            this.tbxDmgReceived.TabIndex = 36;
            this.tbxDmgReceived.Text = "0";
            this.tbxDmgReceived.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxDmgReceived.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxDmgReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxDmgReceived.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "% Dommages reçus :";
            // 
            // tbxHeal
            // 
            this.tbxHeal.Location = new System.Drawing.Point(146, 105);
            this.tbxHeal.MaxLength = 3;
            this.tbxHeal.Name = "tbxHeal";
            this.tbxHeal.ShortcutsEnabled = false;
            this.tbxHeal.Size = new System.Drawing.Size(46, 20);
            this.tbxHeal.TabIndex = 34;
            this.tbxHeal.Text = "0";
            this.tbxHeal.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxHeal.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxHeal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxHeal.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Résistance aux soins (%) :";
            // 
            // tbxBack
            // 
            this.tbxBack.Location = new System.Drawing.Point(290, 79);
            this.tbxBack.MaxLength = 4;
            this.tbxBack.Name = "tbxBack";
            this.tbxBack.ShortcutsEnabled = false;
            this.tbxBack.Size = new System.Drawing.Size(46, 20);
            this.tbxBack.TabIndex = 32;
            this.tbxBack.Text = "0";
            this.tbxBack.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxBack.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxBack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxBack.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Résistance dos :";
            // 
            // tbxCritic
            // 
            this.tbxCritic.Location = new System.Drawing.Point(146, 79);
            this.tbxCritic.MaxLength = 4;
            this.tbxCritic.Name = "tbxCritic";
            this.tbxCritic.ShortcutsEnabled = false;
            this.tbxCritic.Size = new System.Drawing.Size(46, 20);
            this.tbxCritic.TabIndex = 30;
            this.tbxCritic.Text = "0";
            this.tbxCritic.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxCritic.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxCritic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxCritic.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Résistance critique :";
            // 
            // tbxElementary
            // 
            this.tbxElementary.Location = new System.Drawing.Point(146, 53);
            this.tbxElementary.MaxLength = 4;
            this.tbxElementary.Name = "tbxElementary";
            this.tbxElementary.ShortcutsEnabled = false;
            this.tbxElementary.Size = new System.Drawing.Size(46, 20);
            this.tbxElementary.TabIndex = 28;
            this.tbxElementary.Text = "0";
            this.tbxElementary.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxElementary.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxElementary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxElementary.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Résistance élémentaire :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cete feuille vous permet de saisir les diverses résistances de la cible afin de p" +
    "rocéder au calcul des dégâts.";
            // 
            // rdbParade20
            // 
            this.rdbParade20.AutoSize = true;
            this.rdbParade20.Checked = true;
            this.rdbParade20.Location = new System.Drawing.Point(146, 135);
            this.rdbParade20.Name = "rdbParade20";
            this.rdbParade20.Size = new System.Drawing.Size(45, 17);
            this.rdbParade20.TabIndex = 38;
            this.rdbParade20.TabStop = true;
            this.rdbParade20.Text = "20%";
            this.rdbParade20.UseVisualStyleBackColor = true;
            // 
            // rdbParade30
            // 
            this.rdbParade30.AutoSize = true;
            this.rdbParade30.Location = new System.Drawing.Point(197, 135);
            this.rdbParade30.Name = "rdbParade30";
            this.rdbParade30.Size = new System.Drawing.Size(45, 17);
            this.rdbParade30.TabIndex = 39;
            this.rdbParade30.Text = "30%";
            this.rdbParade30.UseVisualStyleBackColor = true;
            // 
            // rdbParade35
            // 
            this.rdbParade35.AutoSize = true;
            this.rdbParade35.Location = new System.Drawing.Point(248, 135);
            this.rdbParade35.Name = "rdbParade35";
            this.rdbParade35.Size = new System.Drawing.Size(45, 17);
            this.rdbParade35.TabIndex = 40;
            this.rdbParade35.Text = "35%";
            this.rdbParade35.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Parade à :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Barrière :";
            // 
            // tbxBarrier
            // 
            this.tbxBarrier.Location = new System.Drawing.Point(146, 184);
            this.tbxBarrier.MaxLength = 3;
            this.tbxBarrier.Name = "tbxBarrier";
            this.tbxBarrier.ShortcutsEnabled = false;
            this.tbxBarrier.Size = new System.Drawing.Size(46, 20);
            this.tbxBarrier.TabIndex = 43;
            this.tbxBarrier.Text = "0";
            this.tbxBarrier.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxBarrier.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxBarrier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxBarrier.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(184, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxHealReceived
            // 
            this.tbxHealReceived.Location = new System.Drawing.Point(290, 158);
            this.tbxHealReceived.MaxLength = 3;
            this.tbxHealReceived.Name = "tbxHealReceived";
            this.tbxHealReceived.ShortcutsEnabled = false;
            this.tbxHealReceived.Size = new System.Drawing.Size(46, 20);
            this.tbxHealReceived.TabIndex = 46;
            this.tbxHealReceived.Text = "0";
            this.tbxHealReceived.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxHealReceived.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxHealReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxHealReceived.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "% Soins reçu :";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(198, 56);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(83, 13);
            this.lblPreview.TabIndex = 47;
            this.lblPreview.Text = "0% de réduction";
            // 
            // frmResistTarget
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 255);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.tbxHealReceived);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxBarrier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbParade35);
            this.Controls.Add(this.rdbParade30);
            this.Controls.Add(this.rdbParade20);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxDmgReceived);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxHeal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxCritic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxElementary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmResistTarget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feuille des résistances";
            this.Load += new System.EventHandler(this.frmResistTarget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbxDmgReceived;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxHeal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxCritic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxElementary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbParade20;
        private System.Windows.Forms.RadioButton rdbParade30;
        private System.Windows.Forms.RadioButton rdbParade35;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxBarrier;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxHealReceived;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPreview;
    }
}