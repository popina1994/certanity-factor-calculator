﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using etf.cfactor.zd130033d.Klase;

namespace etf.cfactor.zd130033d
{
    public partial class formMain : Form
    {
        
        
       
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRules.SelectedItem != null)
            {
                String changedS = listBoxRules.SelectedItem.ToString();

                tbRule.Text = changedS + "\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String[] arrS = tbRule.Text.Split('\n');
            if (arrS.Length != 2) {
                MessageBox.Show("Погрешно унети аргументи");
                return;
             }

            int index = listBoxRules.Items.IndexOf(arrS[0]);
            if (index == -1)
                MessageBox.Show("Не постоји дато правило");
            else
            { 
                String rule = arrS[1];
                String[] paramsVal;
                ArrayList postfix;
                try
                {
                    Parser.Check(rule, out paramsVal, out postfix);
                }
                catch (Error er)
                {
                    MessageBox.Show(er.ToString());
                    return;
                }

                int indexSearch = listBoxRules.Items.IndexOf(arrS[1]);
                if (indexSearch != -1)
                    MessageBox.Show("Већ постоји правило");

                // Sprecava dodavanje dva puta istog pravila.
                //
                listBoxRules.Items.RemoveAt(index);
                listBoxRules.Items.Insert(index, rule);
                Pravilo.rules.Remove(arrS[0]);
                Pravilo.rules[rule] = new Pravilo(rule, postfix, paramsVal);
            }
  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btAddRule_Click(object sender, EventArgs e)
        {
            // Get rule from textbox.
            //
            String rule = tbRule.Text;
            String[] paramsVal;
            ArrayList postfix;
            try {
                Parser.Check(rule, out paramsVal, out postfix);
            }
            catch (Error er)
            {
                MessageBox.Show(er.ToString());
                return;
            }

            // Sprecava dodavanje dva puta istog pravila.
            //
            int index = listBoxRules.Items.IndexOf(rule);
            if (index == -1)
            {
                listBoxRules.Items.Add(rule);
                index = listBoxRules.Items.IndexOf(rule);
                Pravilo.rules[rule] = new Pravilo(rule, postfix, paramsVal);
            }

             
        }

        private void listBoxObserve_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxObserve.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double mb, md;

            if (!Double.TryParse(tbMB.Text, out mb))
            {
                MessageBox.Show("Није добар measure of belief");
                return;
            }

            if (!Double.TryParse(tbMD.Text, out md))
            {
                MessageBox.Show("Није добар measure of disbelief");
                return;
            }


            if (mb < 0 || mb > 1)
            {
                
                MessageBox.Show("Није добар measure of belief");
                return;
            }
            if (md < 0 || md > 1)
            {

                MessageBox.Show("Није добар measure of disbelief");
                return;
            }
            String observe = tbObserve.Text;

            if (!Parser.IsWord(observe))
            {
                MessageBox.Show("Није добро име опажања (могу само слова и бројеви)");
                return;
            }
            int index = listBoxObserve.Items.IndexOf(observe);
            if (index == -1)
            {
                listBoxObserve.Items.Add(observe);
                index = listBoxObserve.Items.IndexOf(observe);
                Opazanje.observe[observe] = new Opazanje(observe, mb, md);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String rule = tbRule.Text;
            int index = listBoxRules.Items.IndexOf(rule);

            if (index == -1)
            {
                MessageBox.Show("Правило не постоји");
                return;
            }
            else
            {
                listBoxRules.Items.RemoveAt(index);
                Pravilo.rules.Remove(rule);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String observation = tbObserve.Text;
            int index = listBoxObserve.Items.IndexOf(observation);

            if (index == -1)
                MessageBox.Show("Опажање не постоји");
            else
            {
                listBoxObserve.Items.RemoveAt(index);
                Opazanje.observe.Remove(observation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            String conclusion = tbConclusion.Text;

            if (!Parser.IsWord(conclusion))
            {
                MessageBox.Show("Није добро име закључка (могу само слова и бројеви)");
                return;
            }
            int index = listBoxConclusion.Items.IndexOf(conclusion);
            if (index == -1)
            {
                listBoxConclusion.Items.Add(conclusion);
                index = listBoxConclusion.Items.IndexOf(conclusion);
                Zakljucak.conclusion[conclusion] = new Zakljucak(conclusion);
            }
        }

        private void listBoxObserve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxObserve.SelectedItem != null)
            {
                
                String changedS = listBoxObserve.SelectedItem.ToString();
                tbObserve.Text = changedS;

                Opazanje o = Opazanje.observe[changedS];
                tbMB.Text = o.mBelief.ToString();
                tbMD.Text = o.mDisbelief.ToString();
            }
            
        }

        private void listBoxConclusion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxConclusion.SelectedItem != null)
            {
                String changedS = listBoxConclusion.SelectedItem.ToString();

                tbConclusion.Text = changedS + "\n";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String observe = tbObserve.Text;

            int index = listBoxObserve.Items.IndexOf(observe);
            if (index == -1) 
                MessageBox.Show("Не постоји дато опажање");
            else
            {
                
                

                double mb, md;

                if (!Double.TryParse(tbMB.Text, out mb))
                {
                    MessageBox.Show("Није добар measure of belief");
                    return;
                }

                if (!Double.TryParse(tbMD.Text, out md))
                {
                    MessageBox.Show("Није добар measure of disbelief");
                    return;
                }
                if (mb < 0 || mb > 1)
                {
                    MessageBox.Show("Није добар measure of belief");
                    return;
                }
                if (md < 0 || md > 1)
                {
                    MessageBox.Show("Није добар measure of disbelief");
                    return;
                }

                listBoxObserve.Items.RemoveAt(index);
                listBoxObserve.Items.Insert(index, observe);
                Opazanje.observe[observe] = new Opazanje(observe, mb, md);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String conclusion = tbConclusion.Text;
            int index = listBoxConclusion.Items.IndexOf(conclusion);

            if (index == -1)
                MessageBox.Show("Закључак не постоји");
            else
            {
                listBoxConclusion.Items.RemoveAt(index);
                Zakljucak.conclusion.Remove(conclusion);
            }
        }
    }
}
