namespace WakfuDammagesCalculator
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlTarget = new System.Windows.Forms.Panel();
            this.rdbRange = new System.Windows.Forms.RadioButton();
            this.rdbMelee = new System.Windows.Forms.RadioButton();
            this.pnlAoE = new System.Windows.Forms.Panel();
            this.rdbMono = new System.Windows.Forms.RadioButton();
            this.rdbArea = new System.Windows.Forms.RadioButton();
            this.pnlOrientation = new System.Windows.Forms.Panel();
            this.rdbFront = new System.Windows.Forms.RadioButton();
            this.rdbSide = new System.Windows.Forms.RadioButton();
            this.rdbBack = new System.Windows.Forms.RadioButton();
            this.pnlTypeSpell = new System.Windows.Forms.Panel();
            this.rdbDammage = new System.Windows.Forms.RadioButton();
            this.rdbHeal = new System.Windows.Forms.RadioButton();
            this.rdbArmor = new System.Windows.Forms.RadioButton();
            this.btnResistTarget = new System.Windows.Forms.Button();
            this.btnMasteryCaster = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxParade = new System.Windows.Forms.CheckBox();
            this.cbxBerserk = new System.Windows.Forms.CheckBox();
            this.cbxCritic = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxValueAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBaseValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblBaseValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlTarget.SuspendLayout();
            this.pnlAoE.SuspendLayout();
            this.pnlOrientation.SuspendLayout();
            this.pnlTypeSpell.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlTarget);
            this.groupBox1.Controls.Add(this.pnlAoE);
            this.groupBox1.Controls.Add(this.pnlOrientation);
            this.groupBox1.Controls.Add(this.pnlTypeSpell);
            this.groupBox1.Controls.Add(this.btnResistTarget);
            this.groupBox1.Controls.Add(this.btnMasteryCaster);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxParade);
            this.groupBox1.Controls.Add(this.cbxBerserk);
            this.groupBox1.Controls.Add(this.cbxCritic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxValueAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxBaseValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propriétés du sort ";
            // 
            // pnlTarget
            // 
            this.pnlTarget.Controls.Add(this.rdbRange);
            this.pnlTarget.Controls.Add(this.rdbMelee);
            this.pnlTarget.Location = new System.Drawing.Point(130, 164);
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Size = new System.Drawing.Size(180, 22);
            this.pnlTarget.TabIndex = 29;
            // 
            // rdbRange
            // 
            this.rdbRange.AutoSize = true;
            this.rdbRange.Checked = true;
            this.rdbRange.Location = new System.Drawing.Point(3, -2);
            this.rdbRange.Name = "rdbRange";
            this.rdbRange.Size = new System.Drawing.Size(67, 17);
            this.rdbRange.TabIndex = 15;
            this.rdbRange.TabStop = true;
            this.rdbRange.Text = "Distance";
            this.rdbRange.UseVisualStyleBackColor = true;
            // 
            // rdbMelee
            // 
            this.rdbMelee.AutoSize = true;
            this.rdbMelee.Location = new System.Drawing.Point(118, -2);
            this.rdbMelee.Name = "rdbMelee";
            this.rdbMelee.Size = new System.Drawing.Size(54, 17);
            this.rdbMelee.TabIndex = 16;
            this.rdbMelee.TabStop = true;
            this.rdbMelee.Text = "Mêlée";
            this.rdbMelee.UseVisualStyleBackColor = true;
            // 
            // pnlAoE
            // 
            this.pnlAoE.Controls.Add(this.rdbMono);
            this.pnlAoE.Controls.Add(this.rdbArea);
            this.pnlAoE.Location = new System.Drawing.Point(130, 137);
            this.pnlAoE.Name = "pnlAoE";
            this.pnlAoE.Size = new System.Drawing.Size(180, 26);
            this.pnlAoE.TabIndex = 28;
            // 
            // rdbMono
            // 
            this.rdbMono.AutoSize = true;
            this.rdbMono.Checked = true;
            this.rdbMono.Location = new System.Drawing.Point(3, 2);
            this.rdbMono.Name = "rdbMono";
            this.rdbMono.Size = new System.Drawing.Size(74, 17);
            this.rdbMono.TabIndex = 13;
            this.rdbMono.TabStop = true;
            this.rdbMono.Text = "Monocible";
            this.rdbMono.UseVisualStyleBackColor = true;
            // 
            // rdbArea
            // 
            this.rdbArea.AutoSize = true;
            this.rdbArea.Location = new System.Drawing.Point(117, 2);
            this.rdbArea.Name = "rdbArea";
            this.rdbArea.Size = new System.Drawing.Size(50, 17);
            this.rdbArea.TabIndex = 14;
            this.rdbArea.TabStop = true;
            this.rdbArea.Text = "Zone";
            this.rdbArea.UseVisualStyleBackColor = true;
            // 
            // pnlOrientation
            // 
            this.pnlOrientation.Controls.Add(this.rdbFront);
            this.pnlOrientation.Controls.Add(this.rdbSide);
            this.pnlOrientation.Controls.Add(this.rdbBack);
            this.pnlOrientation.Location = new System.Drawing.Point(130, 109);
            this.pnlOrientation.Name = "pnlOrientation";
            this.pnlOrientation.Size = new System.Drawing.Size(180, 26);
            this.pnlOrientation.TabIndex = 27;
            // 
            // rdbFront
            // 
            this.rdbFront.AutoSize = true;
            this.rdbFront.Checked = true;
            this.rdbFront.Location = new System.Drawing.Point(3, 5);
            this.rdbFront.Name = "rdbFront";
            this.rdbFront.Size = new System.Drawing.Size(49, 17);
            this.rdbFront.TabIndex = 9;
            this.rdbFront.TabStop = true;
            this.rdbFront.Text = "Face";
            this.rdbFront.UseVisualStyleBackColor = true;
            // 
            // rdbSide
            // 
            this.rdbSide.AutoSize = true;
            this.rdbSide.Location = new System.Drawing.Point(65, 5);
            this.rdbSide.Name = "rdbSide";
            this.rdbSide.Size = new System.Drawing.Size(47, 17);
            this.rdbSide.TabIndex = 10;
            this.rdbSide.TabStop = true;
            this.rdbSide.Text = "Côté";
            this.rdbSide.UseVisualStyleBackColor = true;
            // 
            // rdbBack
            // 
            this.rdbBack.AutoSize = true;
            this.rdbBack.Location = new System.Drawing.Point(117, 5);
            this.rdbBack.Name = "rdbBack";
            this.rdbBack.Size = new System.Drawing.Size(44, 17);
            this.rdbBack.TabIndex = 11;
            this.rdbBack.TabStop = true;
            this.rdbBack.Text = "Dos";
            this.rdbBack.UseVisualStyleBackColor = true;
            // 
            // pnlTypeSpell
            // 
            this.pnlTypeSpell.Controls.Add(this.rdbDammage);
            this.pnlTypeSpell.Controls.Add(this.rdbHeal);
            this.pnlTypeSpell.Controls.Add(this.rdbArmor);
            this.pnlTypeSpell.Location = new System.Drawing.Point(130, 78);
            this.pnlTypeSpell.Name = "pnlTypeSpell";
            this.pnlTypeSpell.Size = new System.Drawing.Size(180, 30);
            this.pnlTypeSpell.TabIndex = 26;
            // 
            // rdbDammage
            // 
            this.rdbDammage.AutoSize = true;
            this.rdbDammage.Checked = true;
            this.rdbDammage.Location = new System.Drawing.Point(3, 6);
            this.rdbDammage.Name = "rdbDammage";
            this.rdbDammage.Size = new System.Drawing.Size(59, 17);
            this.rdbDammage.TabIndex = 5;
            this.rdbDammage.TabStop = true;
            this.rdbDammage.Text = "Dégâts";
            this.rdbDammage.UseVisualStyleBackColor = true;
            this.rdbDammage.CheckedChanged += new System.EventHandler(this.rdbDammage_CheckedChanged);
            // 
            // rdbHeal
            // 
            this.rdbHeal.AutoSize = true;
            this.rdbHeal.Location = new System.Drawing.Point(65, 6);
            this.rdbHeal.Name = "rdbHeal";
            this.rdbHeal.Size = new System.Drawing.Size(46, 17);
            this.rdbHeal.TabIndex = 6;
            this.rdbHeal.TabStop = true;
            this.rdbHeal.Text = "Soin";
            this.rdbHeal.UseVisualStyleBackColor = true;
            this.rdbHeal.CheckedChanged += new System.EventHandler(this.rdbDammage_CheckedChanged);
            // 
            // rdbArmor
            // 
            this.rdbArmor.AutoSize = true;
            this.rdbArmor.Location = new System.Drawing.Point(117, 6);
            this.rdbArmor.Name = "rdbArmor";
            this.rdbArmor.Size = new System.Drawing.Size(58, 17);
            this.rdbArmor.TabIndex = 7;
            this.rdbArmor.TabStop = true;
            this.rdbArmor.Text = "Armure";
            this.rdbArmor.UseVisualStyleBackColor = true;
            this.rdbArmor.CheckedChanged += new System.EventHandler(this.rdbDammage_CheckedChanged);
            // 
            // btnResistTarget
            // 
            this.btnResistTarget.Location = new System.Drawing.Point(197, 245);
            this.btnResistTarget.Name = "btnResistTarget";
            this.btnResistTarget.Size = new System.Drawing.Size(182, 23);
            this.btnResistTarget.TabIndex = 25;
            this.btnResistTarget.Text = "Accéder aux résistances de la cible";
            this.btnResistTarget.UseVisualStyleBackColor = true;
            this.btnResistTarget.Click += new System.EventHandler(this.btnResistTarget_Click);
            // 
            // btnMasteryCaster
            // 
            this.btnMasteryCaster.Location = new System.Drawing.Point(9, 245);
            this.btnMasteryCaster.Name = "btnMasteryCaster";
            this.btnMasteryCaster.Size = new System.Drawing.Size(182, 23);
            this.btnMasteryCaster.TabIndex = 24;
            this.btnMasteryCaster.Text = "Accéder aux maîtrises du lanceur";
            this.btnMasteryCaster.UseVisualStyleBackColor = true;
            this.btnMasteryCaster.Click += new System.EventHandler(this.btnMasteryCaster_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sort encaissé en :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sort lancé en :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cible à :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Zone d\'effet :";
            // 
            // cbxParade
            // 
            this.cbxParade.AutoSize = true;
            this.cbxParade.Location = new System.Drawing.Point(130, 215);
            this.cbxParade.Name = "cbxParade";
            this.cbxParade.Size = new System.Drawing.Size(60, 17);
            this.cbxParade.TabIndex = 19;
            this.cbxParade.Text = "Parade";
            this.cbxParade.UseVisualStyleBackColor = true;
            // 
            // cbxBerserk
            // 
            this.cbxBerserk.AutoSize = true;
            this.cbxBerserk.Location = new System.Drawing.Point(248, 192);
            this.cbxBerserk.Name = "cbxBerserk";
            this.cbxBerserk.Size = new System.Drawing.Size(62, 17);
            this.cbxBerserk.TabIndex = 18;
            this.cbxBerserk.Text = "Berserk";
            this.cbxBerserk.UseVisualStyleBackColor = true;
            // 
            // cbxCritic
            // 
            this.cbxCritic.AutoSize = true;
            this.cbxCritic.Location = new System.Drawing.Point(131, 192);
            this.cbxCritic.Name = "cbxCritic";
            this.cbxCritic.Size = new System.Drawing.Size(88, 17);
            this.cbxCritic.TabIndex = 17;
            this.cbxCritic.Text = "Coup critique";
            this.cbxCritic.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dégâts occasionnés de :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type de sort :";
            // 
            // tbxValueAdd
            // 
            this.tbxValueAdd.Location = new System.Drawing.Point(130, 52);
            this.tbxValueAdd.MaxLength = 4;
            this.tbxValueAdd.Name = "tbxValueAdd";
            this.tbxValueAdd.ShortcutsEnabled = false;
            this.tbxValueAdd.Size = new System.Drawing.Size(100, 20);
            this.tbxValueAdd.TabIndex = 3;
            this.tbxValueAdd.Text = "0";
            this.tbxValueAdd.Click += new System.EventHandler(this.tbxBaseValue_Click);
            this.tbxValueAdd.TextChanged += new System.EventHandler(this.tbxBaseValue_TextChanged);
            this.tbxValueAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxValueAdd_KeyPress);
            this.tbxValueAdd.Leave += new System.EventHandler(this.tbxBaseValue_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valeur supplémentaires :";
            // 
            // tbxBaseValue
            // 
            this.tbxBaseValue.Location = new System.Drawing.Point(130, 26);
            this.tbxBaseValue.MaxLength = 4;
            this.tbxBaseValue.Name = "tbxBaseValue";
            this.tbxBaseValue.ShortcutsEnabled = false;
            this.tbxBaseValue.Size = new System.Drawing.Size(100, 20);
            this.tbxBaseValue.TabIndex = 1;
            this.tbxBaseValue.Text = "0";
            this.tbxBaseValue.Click += new System.EventHandler(this.tbxBaseValue_Click);
            this.tbxBaseValue.TextChanged += new System.EventHandler(this.tbxBaseValue_TextChanged);
            this.tbxBaseValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBaseValue_KeyPress);
            this.tbxBaseValue.Leave += new System.EventHandler(this.tbxBaseValue_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valeur de base du sort :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(316, 293);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculer !";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPreview);
            this.groupBox2.Controls.Add(this.lblBaseValue);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultat ";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(256, 28);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(50, 13);
            this.lblPreview.TabIndex = 1;
            this.lblPreview.Text = "Aperçu : ";
            // 
            // lblBaseValue
            // 
            this.lblBaseValue.AutoSize = true;
            this.lblBaseValue.Location = new System.Drawing.Point(6, 28);
            this.lblBaseValue.Name = "lblBaseValue";
            this.lblBaseValue.Size = new System.Drawing.Size(96, 13);
            this.lblBaseValue.TabIndex = 0;
            this.lblBaseValue.Text = "Montant de base : ";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wakfu Calculateur de dégâts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTarget.ResumeLayout(false);
            this.pnlTarget.PerformLayout();
            this.pnlAoE.ResumeLayout(false);
            this.pnlAoE.PerformLayout();
            this.pnlOrientation.ResumeLayout(false);
            this.pnlOrientation.PerformLayout();
            this.pnlTypeSpell.ResumeLayout(false);
            this.pnlTypeSpell.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBack;
        private System.Windows.Forms.RadioButton rdbSide;
        private System.Windows.Forms.RadioButton rdbFront;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbArmor;
        private System.Windows.Forms.RadioButton rdbHeal;
        private System.Windows.Forms.RadioButton rdbDammage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxValueAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBaseValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxParade;
        private System.Windows.Forms.CheckBox cbxBerserk;
        private System.Windows.Forms.CheckBox cbxCritic;
        private System.Windows.Forms.RadioButton rdbMelee;
        private System.Windows.Forms.RadioButton rdbRange;
        private System.Windows.Forms.RadioButton rdbArea;
        private System.Windows.Forms.RadioButton rdbMono;
        private System.Windows.Forms.Button btnResistTarget;
        private System.Windows.Forms.Button btnMasteryCaster;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblBaseValue;
        private System.Windows.Forms.Panel pnlTypeSpell;
        private System.Windows.Forms.Panel pnlOrientation;
        private System.Windows.Forms.Panel pnlTarget;
        private System.Windows.Forms.Panel pnlAoE;
    }
}

