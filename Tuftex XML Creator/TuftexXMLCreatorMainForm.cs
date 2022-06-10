using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tuftex_XML_Creator
{
    public partial class Form1 : Form
    {
        createXML createXML = new createXML();

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            List<string> bugsList = new List<string>();
            if (sh43Checkbox.Checked)
            {
                bugsList.Add(sh43Checkbox.Text);
            }
            if (sh75CheckBox.Checked)
            {
                bugsList.Add(sh75CheckBox.Text);
            }
            if (sh07Checkbox.Checked)
            {
                bugsList.Add(sh07Checkbox.Text);
            }
            if (sh09Checkbox.Checked)
            {
                bugsList.Add(sh09Checkbox.Text);
            }
            if (sh10Checkbox.Checked)
            {
                bugsList.Add(sh10Checkbox.Text);
            }
            if (sh05Checkbox.Checked)
            {
                bugsList.Add(sh05Checkbox.Text);
            }
            if (sh14Checkbox.Checked)
            {
                bugsList.Add(sh14Checkbox.Text);
            }
            if (sh24Checkbox.Checked)
            {
                bugsList.Add(sh24Checkbox.Text);
            }
            if (sa22Checkbox.Checked)
            {
                bugsList.Add(sa22Checkbox.Text);
            }
            if (sa01Checkbox.Checked)
            {
                bugsList.Add(sa01Checkbox.Text);
            }
            if (sa02Checkbox.Checked)
            {
                bugsList.Add(sa02Checkbox.Text);
            }
            if (sa15Checkbox.Checked)
            {
                bugsList.Add(sa15Checkbox.Text);
            }
            if (sh79CheckBox.Checked)
            {
                bugsList.Add(sh79CheckBox.Text);
            }
            if (sh80CheckBox.Checked)
            {
                bugsList.Add(sh80CheckBox.Text);
            }
            if (sh72CheckBox.Checked)
            {
                bugsList.Add(sh72CheckBox.Text);
            }
            if (sh73CheckBox.Checked)
            {
                bugsList.Add(sh73CheckBox.Text);
            }
            if (sh74CheckBox.Checked)
            {
                bugsList.Add(sh74CheckBox.Text);
            }
            if (sh76CheckBox.Checked)
            {
                bugsList.Add(sh76CheckBox.Text);
            }
            if (sh77CheckBox.Checked)
            {
                bugsList.Add(sh77CheckBox.Text);
            }
            if (sh78CheckBox.Checked)
            {
                bugsList.Add(sh78CheckBox.Text);
            }

            createXML.createXMLRun(altFilePathBox.Text, styleNumberBox.Text, styleNameBox.Text, colorNumberBox.Text, colorNameBox.Text, fiberComboBox.Text, patternBox.Text, parRatingBox.Text, widthBox.Text, baseComboBox.Text, bugsList.ToArray());
        }

        private void altPathCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (altPathCheckBox.Checked)
            {
                altFilePathBox.ReadOnly = false;
            }
            else
            {
                altFilePathBox.ReadOnly = true;
            }
        }

        private void baseComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.baseComboBox.SelectedIndex == -1 && !this.baseComboBox.AutoCompleteCustomSource.Contains(this.baseComboBox.Text))
            {
                MessageBox.Show("Invalid Base");
            }
        }

        private void textBoxSelectAll(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
