namespace WakfuDammagesCalculator
{
    partial class frmMasteryCaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxElementary = new System.Windows.Forms.TextBox();
            this.tbxMono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxRange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMelee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCritic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxBack = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxBerserk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxHeal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxDmgInflicted = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxHealExecuted = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxArmorGiven = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cete feuille vous permet de saisir vos diverses maîtrises afin de procéder au cal" +
    "cul des dégâts.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maîtrise élémentaire :";
            // 
            // tbxElementary
            // 
            this.tbxElementary.Location = new System.Drawing.Point(129, 53);
            this.tbxElementary.MaxLength = 4;
            this.tbxElementary.Name = "tbxElementary";
            this.tbxElementary.ShortcutsEnabled = false;
            this.tbxElementary.Size = new System.Drawing.Size(46, 20);
            this.tbxElementary.TabIndex = 2;
            this.tbxElementary.Text = "0";
            this.tbxElementary.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxElementary.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxElementary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxElementary.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // tbxMono
            // 
            this.tbxMono.Location = new System.Drawing.Point(129, 79);
            this.tbxMono.MaxLength = 4;
            this.tbxMono.Name = "tbxMono";
            this.tbxMono.ShortcutsEnabled = false;
            this.tbxMono.Size = new System.Drawing.Size(46, 20);
            this.tbxMono.TabIndex = 4;
            this.tbxMono.Text = "0";
            this.tbxMono.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxMono.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxMono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxMono.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maîtrise monocible :";
            // 
            // tbxRange
            // 
            this.tbxRange.Location = new System.Drawing.Point(129, 105);
            this.tbxRange.MaxLength = 4;
            this.tbxRange.Name = "tbxRange";
            this.tbxRange.ShortcutsEnabled = false;
            this.tbxRange.Size = new System.Drawing.Size(46, 20);
            this.tbxRange.TabIndex = 6;
            this.tbxRange.Text = "0";
            this.tbxRange.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxRange.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxRange.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maîtrise distance :";
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(262, 79);
            this.tbxArea.MaxLength = 4;
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.ShortcutsEnabled = false;
            this.tbxArea.Size = new System.Drawing.Size(46, 20);
            this.tbxArea.TabIndex = 8;
            this.tbxArea.Text = "0";
            this.tbxArea.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxArea.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxArea.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Maîtrise zone :";
            // 
            // tbxMelee
            // 
            this.tbxMelee.Location = new System.Drawing.Point(262, 105);
            this.tbxMelee.MaxLength = 4;
            this.tbxMelee.Name = "tbxMelee";
            this.tbxMelee.ShortcutsEnabled = false;
            this.tbxMelee.Size = new System.Drawing.Size(46, 20);
            this.tbxMelee.TabIndex = 10;
            this.tbxMelee.Text = "0";
            this.tbxMelee.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxMelee.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxMelee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxMelee.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Maîtrise mêlée :";
            // 
            // tbxCritic
            // 
            this.tbxCritic.Location = new System.Drawing.Point(129, 131);
            this.tbxCritic.MaxLength = 4;
            this.tbxCritic.Name = "tbxCritic";
            this.tbxCritic.ShortcutsEnabled = false;
            this.tbxCritic.Size = new System.Drawing.Size(46, 20);
            this.tbxCritic.TabIndex = 12;
            this.tbxCritic.Text = "0";
            this.tbxCritic.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxCritic.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxCritic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxCritic.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Maîtrise critique :";
            // 
            // tbxBack
            // 
            this.tbxBack.Location = new System.Drawing.Point(262, 131);
            this.tbxBack.MaxLength = 4;
            this.tbxBack.Name = "tbxBack";
            this.tbxBack.ShortcutsEnabled = false;
            this.tbxBack.Size = new System.Drawing.Size(46, 20);
            this.tbxBack.TabIndex = 14;
            this.tbxBack.Text = "0";
            this.tbxBack.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxBack.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxBack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxBack.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Maîtrise dos :";
            // 
            // tbxBerserk
            // 
            this.tbxBerserk.Location = new System.Drawing.Point(129, 157);
            this.tbxBerserk.MaxLength = 4;
            this.tbxBerserk.Name = "tbxBerserk";
            this.tbxBerserk.ShortcutsEnabled = false;
            this.tbxBerserk.Size = new System.Drawing.Size(46, 20);
            this.tbxBerserk.TabIndex = 16;
            this.tbxBerserk.Text = "0";
            this.tbxBerserk.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxBerserk.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxBerserk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxBerserk.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Maîtrise berserk :";
            // 
            // tbxHeal
            // 
            this.tbxHeal.Location = new System.Drawing.Point(262, 157);
            this.tbxHeal.MaxLength = 4;
            this.tbxHeal.Name = "tbxHeal";
            this.tbxHeal.ShortcutsEnabled = false;
            this.tbxHeal.Size = new System.Drawing.Size(46, 20);
            this.tbxHeal.TabIndex = 18;
            this.tbxHeal.Text = "0";
            this.tbxHeal.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxHeal.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxHeal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxHeal.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Maîtrise soin :";
            // 
            // tbxDmgInflicted
            // 
            this.tbxDmgInflicted.Location = new System.Drawing.Point(129, 183);
            this.tbxDmgInflicted.MaxLength = 3;
            this.tbxDmgInflicted.Name = "tbxDmgInflicted";
            this.tbxDmgInflicted.ShortcutsEnabled = false;
            this.tbxDmgInflicted.Size = new System.Drawing.Size(46, 20);
            this.tbxDmgInflicted.TabIndex = 20;
            this.tbxDmgInflicted.Text = "0";
            this.tbxDmgInflicted.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxDmgInflicted.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxDmgInflicted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxDmgInflicted.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "% Dommages infligés :";
            // 
            // tbxHealExecuted
            // 
            this.tbxHealExecuted.Location = new System.Drawing.Point(262, 183);
            this.tbxHealExecuted.MaxLength = 3;
            this.tbxHealExecuted.Name = "tbxHealExecuted";
            this.tbxHealExecuted.ShortcutsEnabled = false;
            this.tbxHealExecuted.Size = new System.Drawing.Size(46, 20);
            this.tbxHealExecuted.TabIndex = 22;
            this.tbxHealExecuted.Text = "0";
            this.tbxHealExecuted.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxHealExecuted.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxHealExecuted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxHealExecuted.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "% Soin réalisés :";
            // 
            // tbxArmorGiven
            // 
            this.tbxArmorGiven.Location = new System.Drawing.Point(129, 209);
            this.tbxArmorGiven.MaxLength = 3;
            this.tbxArmorGiven.Name = "tbxArmorGiven";
            this.tbxArmorGiven.ShortcutsEnabled = false;
            this.tbxArmorGiven.Size = new System.Drawing.Size(46, 20);
            this.tbxArmorGiven.TabIndex = 24;
            this.tbxArmorGiven.Text = "0";
            this.tbxArmorGiven.Click += new System.EventHandler(this.tbxElementary_Click);
            this.tbxArmorGiven.TextChanged += new System.EventHandler(this.tbxElementary_TextChanged);
            this.tbxArmorGiven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxElementary_KeyPress);
            this.tbxArmorGiven.Leave += new System.EventHandler(this.tbxElementary_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "% Armures donnés :";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(233, 237);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "Enregistrer";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(152, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmMasteryCaster
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxArmorGiven);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxHealExecuted);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxDmgInflicted);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxHeal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxBerserk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxCritic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxMelee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxElementary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMasteryCaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feuille des maîtrises";
            this.Load += new System.EventHandler(this.frmMasteryCaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxElementary;
        private System.Windows.Forms.TextBox tbxMono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMelee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCritic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxBerserk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxHeal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxDmgInflicted;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxHealExecuted;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxArmorGiven;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}