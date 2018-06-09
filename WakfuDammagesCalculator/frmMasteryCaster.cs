/* Project : WakfuDammagesCalculator
 * Description : Application C# qui permet de calculer nos dégâts sur Wakfu
 * Author : Dario GENGA
 * Version : 0.5
 * Date : July 2017
 * Copyright © 2017
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WakfuDammagesCalculator
{
    public partial class frmMasteryCaster : Form
    {
        public frmMasteryCaster()
        {
            InitializeComponent();
        }
        public TextBox lastTbx; // Mémore la dernière textbox cliquée

        // dictionnaire qui stockent les valeurs des maîtrises du lanceur
        private Dictionary<string, double> masteries;

        public Dictionary<string, double> Masteries
        {
            get
            {
                Dictionary<string, double> _masteries = new Dictionary<string, double>();
                _masteries.Add("elementary", Convert.ToInt32(tbxElementary.Text));
                _masteries.Add("mono", Convert.ToInt32(tbxMono.Text));
                _masteries.Add("area", Convert.ToInt32(tbxArea.Text));
                _masteries.Add("range", Convert.ToInt32(tbxRange.Text));
                _masteries.Add("melee", Convert.ToInt32(tbxMelee.Text));
                _masteries.Add("critic", Convert.ToInt32(tbxCritic.Text));
                _masteries.Add("back", Convert.ToInt32(tbxBack.Text));
                _masteries.Add("berserk", Convert.ToInt32(tbxBerserk.Text));
                _masteries.Add("heal", Convert.ToInt32(tbxHeal.Text));
                _masteries.Add("dmgInflicted", Convert.ToInt32(tbxDmgInflicted.Text));
                _masteries.Add("healExecuted", Convert.ToInt32(tbxHealExecuted.Text));
                _masteries.Add("armorGiven", Convert.ToInt32(tbxArmorGiven.Text));

                return _masteries;
            }

            set
            {
                this.masteries = value;
            }
        }

        // Initialisation des textbox des maîtrises
        private void frmMasteryCaster_Load(object sender, EventArgs e)
        {
            tbxElementary.Text = masteries["elementary"].ToString();
            tbxMono.Text = masteries["mono"].ToString();
            tbxArea.Text = masteries["area"].ToString();
            tbxRange.Text = masteries["range"].ToString();
            tbxMelee.Text = masteries["melee"].ToString();
            tbxCritic.Text = masteries["critic"].ToString();
            tbxBack.Text = masteries["back"].ToString();
            tbxBerserk.Text = masteries["berserk"].ToString();
            tbxHeal.Text = masteries["heal"].ToString();
            tbxDmgInflicted.Text = masteries["dmgInflicted"].ToString();
            tbxHealExecuted.Text = masteries["healExecuted"].ToString();
            tbxArmorGiven.Text = masteries["armorGiven"].ToString();
        }
        
        // Filtrage des caractères
        private void tbxElementary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        // Sélectionne tout le texte du textBox lors du clic
        private void tbxElementary_Click(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            if (tbx != lastTbx)
                tbx.SelectAll(); // Sélectionner tout le text de la textbox SI elle n'est pas identique à la précédente cliquée

            lastTbx = tbx; // Mémorie la dernière textbox cliquée
        }

        // Vérifie si le champs a été remplis correctement lorsqu'il perd le focus
        private void tbxElementary_Leave(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;

            int nbCarac = 1;
            foreach (char c in tbx.Text)
            {
                // On supprime les '0' si il s'agit du premier caractère (sauf si c'est le seul)
                if (c == '0' && tbx.Text.Length > 1 && nbCarac == 1)
                    tbx.Text = tbx.Text.Remove(0, 1);
                nbCarac++;
            }

            if (tbx.Text == "")
            {
                tbx.Text = "0";
            }
        }

        // Vérifie si le champs est rempli correctement
        private void tbxElementary_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;

            if (tbx.Text == "")
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
        }
    }
}
