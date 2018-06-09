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
    public partial class frmResistTarget : Form
    {
        public frmResistTarget()
        {
            InitializeComponent();
        }
        public TextBox lastTbx; // Mémore la dernière textbox cliquée

        // dictionnaire qui stockent les valeurs des maîtrises du lanceur
        private Dictionary<string, double> resistances;

        public Dictionary<string, double> Resistances
        {
            get
            {
                // On récupère le radiobutton qui est cocher
                var checkedRadioButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked); 
                string parade = checkedRadioButton.Text.Remove(checkedRadioButton.Text.Length - 1); // On retire le caractère %

                Dictionary<string, double> _resistances = new Dictionary<string, double>();
                _resistances.Add("elementary", Convert.ToInt32(tbxElementary.Text));
                _resistances.Add("critic", Convert.ToInt32(tbxCritic.Text));
                _resistances.Add("back", Convert.ToInt32(tbxBack.Text));
                _resistances.Add("heal", Convert.ToInt32(tbxHeal.Text));
                _resistances.Add("parade", Convert.ToInt32(parade));
                _resistances.Add("dmgReceived", Convert.ToInt32(tbxDmgReceived.Text));
                _resistances.Add("healReceived", Convert.ToInt32(tbxHealReceived.Text));
                _resistances.Add("barrier", Convert.ToInt32(tbxBarrier.Text));

                return _resistances;
            }
            set
            {
                this.resistances = value;
            }
        }

        // Initialisation des textbox et radiobuttons des résistances
        private void frmResistTarget_Load(object sender, EventArgs e)
        {
            tbxElementary.Text = resistances["elementary"].ToString();
            tbxCritic.Text = resistances["critic"].ToString();
            tbxBack.Text = resistances["back"].ToString();
            tbxHeal.Text = resistances["heal"].ToString();
            tbxDmgReceived.Text = resistances["dmgReceived"].ToString();
            tbxHealReceived.Text = resistances["healReceived"].ToString();
            tbxBarrier.Text = resistances["barrier"].ToString();

            switch(resistances["parade"])
            {
                case 20:
                    rdbParade20.Checked = true;
                    break;
                case 30:
                    rdbParade30.Checked = true;
                    break;
                case 35:
                    rdbParade35.Checked = true;
                    break;
                default:
                    break;
            }
        }
        // Filtrages des caractères
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

        // On supprime les '0' inutile lorsque le textbox perd le focus
        private void tbxElementary_Leave(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;

            int nbCarac = 1; // nbCarac
            foreach (char c in tbx.Text)
            {

                // On supprime les '0' si il s'agit du premier caractère (sauf si c'est le seul)
                if (c == '0' && tbx.Text.Length > 1 && nbCarac == 1 && tbx.Text[tbx.Text.Length - 1] != '%')
                {
                    tbx.Text = tbx.Text.Remove(0, 1);
                    nbCarac--;
                }
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
            bool flag = true; // Si passe à false on refuse le calcul (erreurs dans les champs)

            TextBox tbx = (TextBox)sender;

            int nbCarac = 1; // nbCarac
            foreach (char c in tbx.Text)
            {
                
                // champs incorrect si '%' n'est pas à la fin de la chaîne ou si il n'y a que le '%' comme caractère
                if (c == '%' && nbCarac != tbx.Text.Length || c == '%' && nbCarac == 1)
                {
                    flag = false;
                }
                nbCarac++;
            }

            if (!flag)
            {
                tbx.BackColor = Color.Red;
                btnOk.Enabled = false;
            }
            else
            {
                tbx.BackColor = SystemColors.Window;
                btnOk.Enabled = true;
            }

            if (tbx.Text == "")
                btnOk.Enabled = false;
            else if (flag)
                btnOk.Enabled = true;

            // Preview du % de réduction selon les résistances élémentaires
            if (tbx.Name == "tbxElementary" && tbx.Text != "")
            {   
                if (Convert.ToInt32(tbx.Text) >= 2065)
                {
                    lblPreview.Text = "100% de réduction";
                }
                else
                {
                    // Calcul des résistances (% de réduction)
                    // Formule : Arrondi inférieur( 1 - 0.8 ^ (Résistance/100) ) * 100
                    double elementary = Convert.ToDouble(tbx.Text) / 100;
                    elementary = 1 - Math.Pow(0.8, elementary);
                    elementary = Math.Floor(elementary * 100);

                    lblPreview.Text = elementary + "% de réduction";
                }
            }
        }
    }
}
