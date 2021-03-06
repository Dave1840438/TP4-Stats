﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_Loi_Normale
{
    public partial class Form1 : Form
    {
        List<List<double>> tableLoiNormale;
        public Form1()
        {
            InitializeComponent();

            String valeursDeLaTable = ".50000 .50399 .50798 .51197 .51595 .51994 .52392 .52790 .53188 .53586" +
"/.53983 .54380 .54776 .55172 .55567 .55962 .56356 .56749 .57142 .57535" +
"/.57926 .58317 .58706 .59095 .59483 .59871 .60257 .60642 .61026 .61409" +
"/.61791 .62172 .62552 .62930 .63307 .63683 .64058 .64431 .64803 .65173" +
"/.65542 .65910 .66276 .66640 .67003 .67364 .67724 .68082 .68439 .68793" +
"/.69146 .69497 .69847 .70194 .70540 .70884 .71226 .71566 .71904 .72240" +
"/.72575 .72907 .73237 .73565 .73891 .74215 .74537 .74857 .75175 .75490" +
"/.75804 .76115 .76424 .76730 .77035 .77337 .77637 .77935 .78230 .78524" +
"/.78814 .79103 .79389 .79673 .79955 .80234 .80511 .80785 .81057 .81327" +
"/.81594 .81859 .82121 .82381 .82639 .82894 .83147 .83398 .83646 .83891" +
"/.84134 .84375 .84614 .84849 .85083 .85314 .85543 .85769 .85993 .86214" +
"/.86433 .86650 .86864 .87076 .87286 .87493 .87698 .87900 .88100 .88298" +
"/.88493 .88686 .88877 .89065 .89251 .89435 .89617 .89796 .89973 .90147" +
"/.90320 .90490 .90658 .90824 .90988 .91149 .91309 .91466 .91621 .91774" +
"/.91924 .92073 .92220 .92364 .92507 .92647 .92785 .92922 .93056 .93189" +
"/.93319 .93448 .93574 .93699 .93822 .93943 .94062 .94179 .94295 .94408" +
"/.94520 .94630 .94738 .94845 .94950 .95053 .95154 .95254 .95352 .95449" +
"/.95543 .95637 .95728 .95818 .95907 .95994 .96080 .96164 .96246 .96327" +
"/.96407 .96485 .96562 .96638 .96712 .96784 .96856 .96926 .96995 .97062" +
"/.97128 .97193 .97257 .97320 .97381 .97441 .97500 .97558 .97615 .97670" +
"/.97725 .97778 .97831 .97882 .97932 .97982 .98030 .98077 .98124 .98169" +
"/.98214 .98257 .98300 .98341 .98382 .98422 .98461 .98500 .98537 .98574" +
"/.98610 .98645 .98679 .98713 .98745 .98778 .98809 .98840 .98870 .98899" +
"/.98928 .98956 .98983 .99010 .99036 .99061 .99086 .99111 .99134 .99158" +
"/.99180 .99202 .99224 .99245 .99266 .99286 .99305 .99324 .99343 .99361" +
"/.99379 .99396 .99413 .99430 .99446 .99461 .99477 .99492 .99506 .99520" +
"/.99534 .99547 .99560 .99573 .99585 .99598 .99609 .99621 .99632 .99643" +
"/.99653 .99664 .99674 .99683 .99693 .99702 .99711 .99720 .99728 .99736" +
"/.99744 .99752 .99760 .99767 .99774 .99781 .99788 .99795 .99801 .99807" +
"/.99813 .99819 .99825 .99831 .99836 .99841 .99846 .99851 .99856 .99861" +
"/.99865 .99869 .99874 .99878 .99882 .99886 .99889 .99893 .99896 .99900" +
"/.99903 .99906 .99910 .99913 .99916 .99918 .99921 .99924 .99926 .99929" +
"/.99931 .99934 .99936 .99938 .99940 .99942 .99944 .99946 .99948 .99950" +
"/.99952 .99953 .99955 .99957 .99958 .99960 .99961 .99962 .99964 .99965" +
"/.99966 .99968 .99969 .99970 .99971 .99972 .99973 .99974 .99975 .99976" +
"/.99977 .99978 .99978 .99979 .99980 .99981 .99981 .99982 .99983 .99983" +
"/.99984 .99985 .99985 .99986 .99986 .99987 .99987 .99988 .99988 .99989" +
"/.99989 .99990 .99990 .99990 .99991 .99991 .99992 .99992 .99992 .99992" +
"/.99993 .99993 .99993 .99994 .99994 .99994 .99994 .99995 .99995 .99995" +
"/.99995 .99995 .99996 .99996 .99996 .99996 .99996 .99996 .99997 .99997" +
"/.99997 .99997 .99997 .99997 .99997 .99998 .99998 .99998 .99998 .99998";

            //Sépare les rangés
            String[] listeRangees = valeursDeLaTable.Split('/');
            tableLoiNormale = new List<List<double>>();

            //Sépare les colonnes
            foreach (String range in valeursDeLaTable.Split('/'))
            {
                //Ajoute une valeur
                List<double> rangeNombre = new List<double>();
                foreach (String nombre in range.Split(' '))
                {
                    rangeNombre.Add(double.Parse("0" + nombre, CultureInfo.InvariantCulture));
                }
                //Ajoute une rangé
                tableLoiNormale.Add(rangeNombre);
            }
        }

        protected void CalculerProabilite(object sender, EventArgs e)
        {
            //Remplace toutes les virgules par des points
            foreach (Control c in this.Controls)
            {
                TextBox tbx = c as TextBox;
                if (c != null)
                    c.Text = c.Text.Replace(',', '.');
            }

            try
            {
                //Déclaration des variables
                double moyenne = double.Parse(TBX_Moyenne.Text, CultureInfo.InvariantCulture);
                double ecartType = double.Parse(TBX_EcartType.Text, CultureInfo.InvariantCulture);
                double a = double.Parse(TBX_A.Text, CultureInfo.InvariantCulture);
                double coteZa = (a - moyenne) / ecartType;
                double resultat = 0;

                //P(x < a)
                if (RBTN_LessThanA.Checked)
                {
                    resultat = AireSousLaCourbe(coteZa);
                    LBL_Result.Text = "La probabilité que X soit plus petit que a est de ";
                }

                //P(X > a)
                if (RBTN_BiggerThanA.Checked)
                {
                    resultat = 1 - AireSousLaCourbe(coteZa);
                    LBL_Result.Text = "La probabilité que X soit plus grand que a est de ";
                }

                //P(a < X < b)
                if (RBTN_BetweenTwo.Checked)
                {
                    double b = double.Parse(TBX_B.Text, CultureInfo.InvariantCulture);
                    double coteZb = (b - moyenne) / ecartType;
                    if (coteZa > coteZb)
                        MessageBox.Show("Incohérence des valeurs : a est plus grand que b");
                    else
                        resultat = 1 - (AireSousLaCourbe(coteZa) + (1 - AireSousLaCourbe(coteZb)));
                    LBL_Result.Text = "La probabilité que X soit entre a et b est de ";
                }

                //Met le résultat en pourcentage
                resultat = Math.Round(resultat * 100, 2, MidpointRounding.AwayFromZero);
                LBL_Result.Text += resultat.ToString() + "%";
            }
            catch
            {
                MessageBox.Show("Un ou plusieurs paramètre(s) a/ont été entré(s) incorrectement");
            }
        }

        //Renovoie l'aire sous la courbe
        protected double AireSousLaCourbe(double coteZ)
        {
            if (coteZ > 4.1)
                return 1;
            else if (coteZ < -4.1)
                    return 0;
            else if (coteZ >= 0)
                return tableLoiNormale[(int)(coteZ * 10)][((int)(coteZ * 100)) % 10];
            else
                return 1 - tableLoiNormale[(int)(Math.Abs(coteZ) * 10)][((int)(Math.Abs(coteZ) * 100)) % 10];
        }

        //Rend visible le champs b si P(a < X < b) est coché
        private void RBTN_BetweenTwo_CheckedChanged(object sender, EventArgs e)
        {
            LBL_b.Visible = TBX_B.Visible = RBTN_BetweenTwo.Checked;
        }

        //Empêche l'utilisateur d'entrer des lettres et autre symboles non nécéssaires
        private void Alpha_Filter(object sender, KeyPressEventArgs e)
        {
            String allowedCharacters = "1234567890-.,";

            if (!allowedCharacters.Contains(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

    }
}
