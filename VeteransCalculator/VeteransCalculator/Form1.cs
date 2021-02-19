using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeteransCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public int prevPercent = 0;
        public int addPercent = 0;
        public int newPercent = 0;
        public int numRatings = 0;
        public bool bilateral = false;


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLeftArm_Click(object sender, EventArgs e)
        {
            bilateral = true;
            Console.WriteLine(bilateral);
        }

        private void btnLeftLeg_Click(object sender, EventArgs e)
        {
            bilateral = true;
            Console.WriteLine(bilateral);
        }

        private void btnRightLeg_Click(object sender, EventArgs e)
        {
            bilateral = true;
            Console.WriteLine(bilateral);
        }

        private void btnRightArm_Click(object sender, EventArgs e)
        {
            bilateral = true;
            Console.WriteLine(bilateral);
        }

        private void btnTenPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnTwentyPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnThirtyPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnFortyPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnFiftyPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnSixtyPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnSeventyPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnEightyPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnNinetyPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCombinedRating.Text = "0%";
            lblRatingInputHistory.Text = "";
        }

        private void lblRatingInputHistory_Click(object sender, EventArgs e)
        {

        }

        private void lblCombinedRating_Click(object sender, EventArgs e)
        {

        }

        private void btnLeftArm_Enter(object sender, EventArgs e)
        {
            this.btnLeftArm.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnLeftArm_Leave(object sender, EventArgs e)
        {
            this.btnLeftArm.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnLeftLeg_Enter(object sender, EventArgs e)
        {
            this.btnLeftLeg.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnLeftLeg_Leave(object sender, EventArgs e)
        {
            this.btnLeftLeg.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnRightLeg_Enter(object sender, EventArgs e)
        {
            this.btnRightLeg.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnRightLeg_Leave(object sender, EventArgs e)
        {
            this.btnRightLeg.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnRightArm_Enter(object sender, EventArgs e)
        {
            this.btnRightArm.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnRightArm_Leave(object sender, EventArgs e)
        {
            this.btnRightArm.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnTenPercent_Enter(object sender, EventArgs e)
        {
            this.btnTenPercent.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnTenPercent_Leave(object sender, EventArgs e)
        {
            this.btnTenPercent.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnTwentyPercent_Enter(object sender, EventArgs e)
        {
            this.btnTwentyPercent.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnTwentyPercent_Leave(object sender, EventArgs e)
        {
            this.btnTwentyPercent.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnThirtyPercent_Enter(object sender, EventArgs e)
        {
            this.btnThirtyPercent.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnThirtyPercent_Leave(object sender, EventArgs e)
        {
            this.btnThirtyPercent.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnFortyPercent_Enter(object sender, EventArgs e)
        {
            this.btnFortyPercent.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnFortyPercent_Leave(object sender, EventArgs e)
        {
            this.btnFortyPercent.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnFiftyPercent_Enter(object sender, EventArgs e)
        {
            this.btnFiftyPercent.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnFiftyPercent_Leave(object sender, EventArgs e)
        {
            this.btnFiftyPercent.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnSixtyPercent_Enter(object sender, EventArgs e)
        {
            this.btnSixtyPercent.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnSixtyPercent_Leave(object sender, EventArgs e)
        {
            this.btnSixtyPercent.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnSeventyPercent_Enter(object sender, EventArgs e)
        {
            this.btnSeventyPercent.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnSeventyPercent_Leave(object sender, EventArgs e)
        {
            this.btnSeventyPercent.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnEightyPercent_Enter(object sender, EventArgs e)
        {
            this.btnEightyPercent.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnEightyPercent_Leave(object sender, EventArgs e)
        {
            this.btnEightyPercent.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnNinetyPercent_Enter(object sender, EventArgs e)
        {
            this.btnNinetyPercent.BackColor = ColorTranslator.FromHtml("green");
        }

        private void btnNinetyPercent_Leave(object sender, EventArgs e)
        {
            this.btnNinetyPercent.BackColor = ColorTranslator.FromHtml("");
        }

        private void btnClear_Enter(object sender, EventArgs e)
        {
            this.btnClear.ForeColor = ColorTranslator.FromHtml("gold");
        }

        private void btnClear_Leave(object sender, EventArgs e)
        {
            this.btnClear.ForeColor = ColorTranslator.FromHtml("white");
        }
    }
}
