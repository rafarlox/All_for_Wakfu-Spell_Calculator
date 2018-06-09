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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public TextBox lastTbx; // Mémore la dernière textbox cliquée

        // dictionnaire qui stockent les valeurs des maîtrises du lanceur
        private Dictionary<string, double> masteries = new Dictionary<string, double>
        {
            {"elementary", 0},
            {"mono", 0},
            {"area", 0},
            {"range", 0},
            {"melee", 0},
            {"critic", 0},
            {"back", 0},
            {"berserk", 0},
            {"heal", 0},
            {"dmgInflicted", 0},
            {"healExecuted", 0},
            {"armorGiven", 0}
        };

        // dictionnaire qui stockent les valeurs des résistances de la cible
        private Dictionary<string, double> resistances = new Dictionary<string, double>
        {
            {"elementary", 0},
            {"critic", 0},
            {"back", 0},
            {"heal", 0},
            {"parade", 20},
            {"dmgReceived", 0},
            {"healReceived", 0},
            {"barrier", 0},
        };

        // Ouvre la feuille des maîtrises lorsqu'on clic sur le bouton correspondant
        private void btnMasteryCaster_Click(object sender, EventArgs e)
        {
            frmMasteryCaster frmMasteryCaster = new frmMasteryCaster();
            frmMasteryCaster.Masteries = masteries; // Envoie les maîtrises actuelles à la feuille des maîtrises
            var dr = frmMasteryCaster.ShowDialog();
            if (dr == DialogResult.OK)
                masteries = frmMasteryCaster.Masteries; // Récupère les nouvelles maîtrises
        }

        // Ouvre la feuille des résistances lorsqu'on clic sur le bouton correspondant
        private void btnResistTarget_Click(object sender, EventArgs e)
        {
            // On retire les valeurs décimals stockés
            double resistElem = resistances["elementary"];
            if (resistElem.ToString().Contains('.'))
                resistances["elementary"] = Convert.ToInt32(resistElem * 100); // On converti en int32 afin de retirer .00

            frmResistTarget frmResistTarget = new frmResistTarget();
            frmResistTarget.Resistances = resistances; // Envoie les résistances actuelles à la feuille des résistances
            var dr = frmResistTarget.ShowDialog();
            if (dr == DialogResult.OK)
                resistances = frmResistTarget.Resistances; // Récupère les nouvelles résistances
        }

        // Calcul le montant du sort selon les maîtrises, résistances et propriété
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Montant de dégats finaux selon l'orientation et les coups critiques
            const double CRIT = 1.25; // 125% en critique
            const double SIDE = 0.1;  // 10% de côté
            const double BACK = 0.25; // 25% de dos
            
            // Initialisation des montants des maîtrises et résistances :
            int baseValue = Convert.ToInt32(tbxBaseValue.Text);
            double baseValueCrit = Math.Floor(baseValue * CRIT);
            double valueAdd;
            double valueTotal;
            
            if (tbxValueAdd.Text[tbxValueAdd.Text.Length - 1] == '%')
            {
                valueAdd = Convert.ToDouble(tbxValueAdd.Text.Remove(tbxValueAdd.Text.Length - 1)) / 100;

                valueTotal = baseValue + (baseValue * valueAdd);
            }
            else
            {
                valueAdd = Convert.ToInt32(tbxValueAdd.Text);
                valueTotal = baseValue + valueAdd;
            }

            // MAITRISES
            double masteryElem = masteries["elementary"]; // Maîtrise élémentaire
            double masteryMono = masteries["mono"]; // Maîtrise monocible
            double masteryArea = masteries["area"]; // Maîtrise zone
            double masteryRange = masteries["range"]; // Maîtrise distance
            double masteryMelee = masteries["melee"]; // Maîtrise mêlée
            double masteryCritic = masteries["critic"]; // Maîtrise critique
            double masteryBack = masteries["back"]; // Maîtrise dos
            double masteryBerserk = masteries["berserk"]; // Maîtrise berserk
            double masteryHeal = masteries["heal"]; // Maîtrise soin
            double dmgInflicted = masteries["dmgInflicted"]; // % Dommages infligés
            double healExecuted = masteries["healExecuted"]; // % Soins réalisés
            double armorGiven = masteries["armorGiven"]; // % Armures donnés

            // RESISTANCES
            double resistElem = resistances["elementary"]; // Résistances élémentaires
            double resistCritic = resistances["critic"]; // Résistance critique
            double resistBack = resistances["back"]; // Résistance dos
            double resistHeal = resistances["heal"]; // % Résistance aux soins
            double paradeReduc = resistances["parade"]; // % réduction de la parade (20%, 30%, 35%)
            double dmgReceived = resistances["dmgReceived"]; // % Dommages reçus
            double healReceived = resistances["healReceived"]; // % Soins reçus
            double barrier = resistances["barrier"]; // Montant de barrière

            // PROPRIETE DU SORT
            var radioTypeSpell = pnlTypeSpell.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var radioOrientation = pnlOrientation.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var radioAoE = pnlAoE.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var radioTarget = pnlTarget.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            bool critic;
            if (cbxCritic.Checked && cbxCritic.Enabled == true)
                critic = true;
            else
                critic = false;

            bool berserk;
            if (cbxBerserk.Checked && cbxBerserk.Enabled == true)
                berserk = true;
            else
                berserk = false;

            bool parade;
            if (cbxParade.Checked && cbxParade.Enabled == true)
                parade = true;
            else
                parade = false;

            // CALCULS

            double totalElem = masteryElem; // total des maîtrises élémentaires et secondaires
            double finalDmg = dmgInflicted / 100; // total de % finaux
            double resultBeforeReduction; // Résultat de nos dégâts/soins/armures avant réduction

            double totalRes = resistElem; // Total des résistances élémentaires et secondaire (dos/crit)
            double reductionFromRes; // Le % de réduction obtenus via nos resistances
            double resultAfterReduction; // Résultat final de nos dégâts/soins/amures après réduction

            switch (radioTypeSpell.Name)
            {
                // Sort de dégâts
                case "rdbDammage":
                    // Zone d'effet (monocible ou zone)
                    switch (radioAoE.Name)
                    {
                        case "rdbMono":
                            totalElem = totalElem + masteryMono;
                            break;
                        case "rdbArea":
                            totalElem = totalElem + masteryArea;
                            break;
                        default:
                            break;
                    }
                    // Cible à portée (distance ou mêlée)
                    switch (radioTarget.Name)
                    {
                        case "rdbRange":
                            totalElem = totalElem + masteryRange;
                            break;
                        case "rdbMelee":
                            totalElem = totalElem + masteryMelee;
                            break;
                        default:
                            break;
                    }
                    if (berserk)
                        totalElem = totalElem + masteryBerserk;

                    if (radioOrientation.Name == "rdbBack")
                    {
                        totalElem = totalElem + masteryBack;
                        finalDmg = finalDmg + BACK;
                        totalRes = totalRes + resistBack; 
                    }
                    else if (radioOrientation.Name == "rdbSide")
                    {
                        finalDmg = finalDmg + SIDE;
                    }
                    
                    // Calcul des dégâts avant réduction

                    if (critic)
                    {
                        totalElem = totalElem + masteryCritic;
                        totalRes = totalRes + resistCritic;

                        resultBeforeReduction = valueTotal * (1 + totalElem / 100) * (1 + finalDmg) * CRIT;
                    }
                    else
                    {
                        resultBeforeReduction = valueTotal * (1 + totalElem / 100) * (1 + finalDmg);
                    }

                    // Calcul du % de reduction des résistances et du % dégâts subit
                    // Formule : Arrondi inférieur( 1 - 0.8 ^ (Résistance/100) ) * 100
                    reductionFromRes = totalRes / 100;
                    reductionFromRes = 1 - Math.Pow(0.8, reductionFromRes);
                    reductionFromRes = Math.Floor(reductionFromRes * 100);

                    dmgReceived = dmgReceived / 100;

                    if (parade)
                        dmgReceived = dmgReceived - paradeReduc;

                    // Calcul dégats avec réduction
                    resultAfterReduction = resultBeforeReduction * (1 - reductionFromRes / 100) * (1 + dmgReceived / 100);

                    // Affichage du résultat
                    lblBaseValue.Text = "Valeur de base : " + baseValue.ToString() + Environment.NewLine + "Valeur de base en critique : " + baseValueCrit;
                    lblPreview.Text = "Aperçu : " + Math.Floor(resultAfterReduction).ToString();

                    break;

                // CALCUL SOIN
                case "rdbHeal":
                    // Zone d'effet (monocible ou zone)
                    switch (radioAoE.Name)
                    {
                        case "rdbMono":
                            totalElem = totalElem + masteryMono;
                            break;
                        case "rdbArea":
                            totalElem = totalElem + masteryArea;
                            break;
                        default:
                            break;
                    }
                    // Cible à portée (distance ou mêlée)
                    switch (radioTarget.Name)
                    {
                        case "rdbRange":
                            totalElem = totalElem + masteryRange;
                            break;
                        case "rdbMelee":
                            totalElem = totalElem + masteryMelee;
                            break;
                        default:
                            break;
                    }
                    if (berserk)
                        totalElem = totalElem + masteryBerserk;

                    // On ajoute la maîtrise soin à notre maîtrise élémentaire
                    totalElem = totalElem + masteryHeal;
                    // Soins reçus
                    healReceived = healReceived / 100;

                    // Calcul des soins avant réduction
                    if (critic)
                    {
                        totalElem = totalElem + masteryCritic;

                        resultBeforeReduction = valueTotal * (1 + totalElem / 100) * (1 + healExecuted / 100) * CRIT;
                    }
                    else
                    {
                        resultBeforeReduction = valueTotal * (1 + totalElem / 100) * (1 + healExecuted / 100);
                    }
                    
                    // Calcul des soins avec réduction
                    resultAfterReduction = resultBeforeReduction * (1 - resistHeal / 100) * (1 + healReceived);

                    // Affichage du résultat
                    lblBaseValue.Text = "Valeur de base : " + baseValue.ToString() + Environment.NewLine + "Valeur de base en critique : " + baseValueCrit;
                    lblPreview.Text = "Aperçu : " + Math.Floor(resultAfterReduction).ToString();

                    break;

                // CALCUL ARMURE
                case "rdbArmor":
                    totalElem = totalElem + masteryMono;
                    totalElem = totalElem + masteryMelee;

                    // Calcul des armures (il s'agit là du résultat final car il n'y a pas de réduction pour les armures)
                    resultAfterReduction = valueTotal * (1 + totalElem / 100) * (1 + armorGiven / 100);

                    // Affichage du résultat
                    lblBaseValue.Text = "Valeur de base : " + baseValue.ToString() + Environment.NewLine + "Valeur de base en critique : " + baseValueCrit;
                    lblPreview.Text = "Aperçu : " + Math.Floor(resultAfterReduction).ToString();
                    break;
                default:
                    break;
            }

            

            
        }

        // Filtrage des caractères
        private void tbxBaseValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        // Filtrages des caractères
        private void tbxValueAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pourcent = (char)37;
            // On autorise le %
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != pourcent)
                e.Handled = true;
        }

        // Sélectionne tout le texte du textBox lors du clic
        private void tbxBaseValue_Click(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;

            if (tbx != lastTbx)
                tbx.SelectAll(); // Sélectionner tout le text de la textbox SI elle n'est pas identique à la précédente cliquée

            lastTbx = tbx; // Mémorie la dernière textbox cliquée
        }

        // On supprime les '0' inutile lorsque le textbox perd le focus
        private void tbxBaseValue_Leave(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;

            int nbCarac = 1; // nbCarac
            foreach (char c in tbx.Text)
            {

                // On supprime les '0' si il s'agit du premier caractère (sauf si c'est le seul)
                if (c == '0' && tbx.Text.Length > 1 && nbCarac == 1)
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
        private void tbxBaseValue_TextChanged(object sender, EventArgs e)
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
                btnCalculate.Enabled = false;
            }
            else
            {
                tbx.BackColor = SystemColors.Window;
                btnCalculate.Enabled = true;
            }

            if (tbx.Text == "")
                btnCalculate.Enabled = false;
            else if (flag)
                btnCalculate.Enabled = true;
        }

        // Désactiver les priopriétés de sort selon le type de sort
        private void rdbDammage_CheckedChanged(object sender, EventArgs e)
        {
            // Sort de dégâts -> on active tout
            if (rdbDammage.Checked)
            {
                rdbFront.Enabled = true;
                rdbSide.Enabled = true;
                rdbBack.Enabled = true;
                cbxParade.Enabled = true;
            }
            // Sinon on désactivé l'orientation et la parade
            else
            {
                rdbFront.Enabled = false;
                rdbSide.Enabled = false;
                rdbBack.Enabled = false;
                cbxParade.Enabled = false;
            }

            // Sort d'armure -> on désactive la zone d'effet et la portée en plus !
            if (rdbArmor.Checked)
            {
                rdbMono.Enabled = false;
                rdbArea.Enabled = false;
                rdbRange.Enabled = false;
                rdbMelee.Enabled = false;
                cbxCritic.Enabled = false;
                cbxBerserk.Enabled = false;
            }
            else
            {
                rdbMono.Enabled = true;
                rdbArea.Enabled = true;
                rdbRange.Enabled = true;
                rdbMelee.Enabled = true;
                cbxCritic.Enabled = true;
                cbxBerserk.Enabled = true;
            }
        }
    }
}
