﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTrello.View
{
    public partial class FrmTestMoveCarte : Form
    {
        public FrmTestMoveCarte()
        {
            InitializeComponent();
        }

        private void btnUp1_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel1);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex - 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel1, alphaIndex - 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void btnDown2_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel1);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex + 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel1, alphaIndex + 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel2);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex - 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel2, alphaIndex - 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel2);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex + 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel2, alphaIndex + 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel3);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex - 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel3, alphaIndex - 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var alphaIndex = flowLayoutPanel2.Controls.IndexOf(panel3);
            Control control = null;
            foreach (Control c in flowLayoutPanel2.Controls)
            {
                if (flowLayoutPanel2.Controls.IndexOf(c) == alphaIndex + 1)
                { control = c; break; }
            }
            if (control == null)
            { }
            else
            {
                flowLayoutPanel2.Controls.SetChildIndex(panel3, alphaIndex + 1);
                flowLayoutPanel2.Controls.SetChildIndex(control, alphaIndex);
            }
        }

        private void lblRight_Click(object sender, EventArgs e)
        {
            //var alphaIndex = flnCarte.Controls.IndexOf(lblRight);
            //Control control = null;
            //foreach (Control c in flnCarte.Controls)
            //{
            //    if (flnCarte.Controls.IndexOf(c) == alphaIndex + 1)
            //    { control = c; break; }
            //}
            //if (control == null)
            //{ }
            //else
            //{
            //    flnCarte.Controls.SetChildIndex(lblRight, alphaIndex + 1);
            //    flnCarte.Controls.SetChildIndex(control, alphaIndex);
            //}
        }

        private void lblLeft_Click(object sender, EventArgs e)
        {
            //var alphaIndex = flnCarte.Controls.IndexOf(lblLeft);
            //Control control = null;
            //foreach (Control c in flnCarte.Controls)
            //{
            //    if (flnCarte.Controls.IndexOf(c) == alphaIndex - 1)
            //    { control = c; break; }
            //}
            //if (control == null)
            //{ }
            //else
            //{
            //    flnCarte.Controls.SetChildIndex(lblLeft, alphaIndex - 1);
            //    flnCarte.Controls.SetChildIndex(control, alphaIndex);
            //}
        }

        private void lblUp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmTestMoveCarte_Load(object sender, EventArgs e)
        {

        }

        //private void ajout_Click(object sender, EventArgs e)
        //{
        //    CtlListe c = new CtlListe();
        //    c.txtTitreListe.Text = txtAjout.Text;
        //    flnListe.Controls.Add(c);
        //    c.lblLeft.Click += delegate (object s, EventArgs ev) { lblLeft_Click(sender, e, c); };
        //    c.lblRight.Click += delegate (object s, EventArgs ev) { lblRight_Click(sender, e, c); };
        //}
        //private void annuler_Click(object sender, EventArgs e)
        //{

        //    pnlAjout.Controls.Remove(txtAjout);

        //}

        //private void lblLeft_Click(object sender, EventArgs e, CtlListe c)
        //{
        //    var alphaIndex = flnListe.Controls.IndexOf(c);
        //    Control control = null;
        //    foreach (Control ctrl in flnListe.Controls)
        //    {
        //        if (flnListe.Controls.IndexOf(ctrl) == alphaIndex - 1)
        //        { control = ctrl; break; }
        //    }
        //    if (control == null)
        //    { }
        //    else
        //    {
        //        flnListe.Controls.SetChildIndex(c, alphaIndex - 1);
        //        flnListe.Controls.SetChildIndex(control, alphaIndex);
        //    }
        //}

        //private void lblRight_Click(object sender, EventArgs e, CtlListe c)
        //{
        //    var alphaIndex = flnListe.Controls.IndexOf(c);
        //    Control control = null;
        //    foreach (Control ctrl in flnListe.Controls)
        //    {
        //        if (flnListe.Controls.IndexOf(ctrl) == alphaIndex + 1)
        //        { control = ctrl; break; }
        //    }
        //    if (control == null)
        //    { }
        //    else
        //    {
        //        flnListe.Controls.SetChildIndex(c, alphaIndex + 1);
        //        flnListe.Controls.SetChildIndex(control, alphaIndex);
        //    }
        //}
    }
}
