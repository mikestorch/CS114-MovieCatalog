using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MichaelStorchProjectTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Close Program
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Hide First Page of Posters
            posterMissing.Visible = false;
            posterPotw.Visible = false;
            posterPhobia.Visible = false;

            //Show Second Page of Posters
            posterTheStray.Visible = true;
            posterDisco.Visible = true;
            posterSchism.Visible = true;
            
            //Hide Next Button and make Back Button Visible
            btnNext.Visible = false;
            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Show First Page of Posters
            posterMissing.Visible = true;
            posterPotw.Visible = true;
            posterPhobia.Visible = true;

            //Hide Second Page of Posters
            posterTheStray.Visible = false;
            posterDisco.Visible = false;
            posterSchism.Visible = false;

            //Hide Next Button and make Back Button Visible
            btnNext.Visible = true;
            btnBack.Visible = false;
        }

        private void posterMissing_Click(object sender, EventArgs e)
        {
            //Change lblSelection to MISSING
            lblSelection.Text = "MISSING - Short Film";
            //Change lblCredits to Directed by Michael Storch
            lblCredits.Text = "Directed by Michael Storch";

            //Add 3D Border to MISSING Poster
            posterMissing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //Remove 3D Border from previously selected Poster
            posterPotw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            posterPhobia.BorderStyle = System.Windows.Forms.BorderStyle.None;

            //Play MISSING Preview GIF
            previewMissing.Visible = true;
            //Hide Other Prewiew GIFs
            previewOSE.Visible = false;
            previewPotw.Visible = false;
            previewPhobia.Visible = false;
            previewTheStray.Visible = false;
            previewDisco.Visible = false;
            previewSchism.Visible = false;
        }

        private void posterPotw_Click(object sender, EventArgs e)
        {
            //Change Label to Phantom of the Woods
            lblSelection.Text = "PHANTOM OF THE WOODS - Feature Film";
            //Change lblCredits to Directed by Michael Storch
            lblCredits.Text = "Directed by Michael Storch";

            //Add 3D Border to MISSING Poster
            posterPotw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //Remove 3D Border from previously selected Poster
            posterMissing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            posterPhobia.BorderStyle = System.Windows.Forms.BorderStyle.None;

            //Play Phantom Preview GIF
            previewPotw.Visible = true;
            //Hide Other Prewiew GIFs
            previewOSE.Visible = false;
            previewMissing.Visible = false;
            previewPhobia.Visible = false;
            previewTheStray.Visible = false;
            previewDisco.Visible = false;
            previewSchism.Visible = false;

        }

        private void posterPhobia_Click(object sender, EventArgs e)
        {
            //Change Label to PHOBIA
            lblSelection.Text = "PHOBIA - Horror Anthology";
            //Change lblCredits to Produced by J.R.S. Storch and Michael Storch
            lblCredits.Text = "Produced by J.R.S. Storch and Michael Storch";

            //Add 3D Border to MISSING Poster
            posterPhobia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //Remove 3D Border from previously selected Poster
            posterMissing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            posterPotw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            
            //Play Phobia Preview GIF
            previewPhobia.Visible = true;
            //Hide Other Prewiew GIFs
            previewOSE.Visible = false;
            previewMissing.Visible = false;
            previewPotw.Visible = false;
            previewDisco.Visible = false;
            previewTheStray.Visible = false;
            previewSchism.Visible = false;
        }


        private void posterTheStray_Click(object sender, EventArgs e)
        {
            //Change Label to Phantom of the Woods
            lblSelection.Text = "THE STRAY - Feature Film";
            //Change lblCredits to Directed by Cam Clark
            lblCredits.Text = "Directed by Cam Clark";

            //Add 3D Border to The Stray Poster
            posterTheStray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //Remove 3D Border from previously selected Poster
            posterDisco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            posterSchism.BorderStyle = System.Windows.Forms.BorderStyle.None;
            
            //Play The Stray Preview GIF
            previewTheStray.Visible = true;
            //Hide Other Preview GIFs
            previewOSE.Visible = false;
            previewMissing.Visible = false;
            previewPotw.Visible = false;
            previewPhobia.Visible = false;
            previewDisco.Visible = false;
            previewSchism.Visible = false;

        }

        private void posterDisco_Click(object sender, EventArgs e)
        {
            //Change Label to Phantom of the Woods
            lblSelection.Text = "DISCONNECTED - TV Series";
            //Change lblCredits to Produced by J.R.S. Storch
            lblCredits.Text = "Directed by J.R.S. Storch";

            //Add 3D Border to The Stray Poster
            posterDisco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //Remove 3D Border from previously selected Poster
            posterTheStray.BorderStyle = System.Windows.Forms.BorderStyle.None;
            posterSchism.BorderStyle = System.Windows.Forms.BorderStyle.None;
            
            //Play The Stray Preview GIF
            previewDisco.Visible = true;
            //Hide Other Preview GIFs
            previewOSE.Visible = false;
            previewMissing.Visible = false;
            previewPotw.Visible = false;
            previewPhobia.Visible = false;
            previewTheStray.Visible = false;
            previewSchism.Visible = false;
        }

        private void posterSchism_Click(object sender, EventArgs e)
        {
            //Change Label to Phantom of the Woods
            lblSelection.Text = "SCHISM - Feature Film";
            //Change lblCredits to Directed by Michael Storch
            lblCredits.Text = "Directed by Michael Storch";

            //Add 3D Border to The Stray Poster
            posterSchism.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //Remove 3D Border from previously selected Poster
            posterTheStray.BorderStyle = System.Windows.Forms.BorderStyle.None;
            posterDisco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            
            //Play Phantom Preview GIF
            previewSchism.Visible = true;
            //Hide Other Preview GIFs
            previewOSE.Visible = false;
            previewMissing.Visible = false;
            previewPotw.Visible = false;
            previewPhobia.Visible = false;
            previewTheStray.Visible = false;
            previewDisco.Visible = false;
        }

    }
}
