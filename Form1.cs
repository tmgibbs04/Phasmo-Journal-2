using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Phasmo_Journal_2
{
    public partial class Form1 : Form
    {


        public List<Ghost> Ghosts = new List<Ghost>();
        public List<string> GhostNames = new List<string>();
        public List<string> Evidence = new List<string>();
        public List<string> BlockedEvidence = new List<string>();
        public List<Ghost> DetectedGhosts = new List<Ghost>();


        //Evidence: DOTS,Writing,EMF,Orbs,Prints,Temps,SpiritBox
        //ghosts: Banshee,Demon,Deogen,Goryo,Hantu,Jinn,Mare,Moroi,Myling,Obake,Oni,Onryo,Phantom,Poltergeist,Raiju,Revenant,Shade,Spirit,Thaye,The Mimic,The Twins,Wraith,Yokai,Yurei


        public Form1()
        {
            InitializeComponent();
            BuildLists();
            BuildGhosts();
            BuildOutputListView();

        }

        private void BuildLists()
        {

            GhostNames.Add("Banshee");
            GhostNames.Add("Demon");
            GhostNames.Add("Deogen");
            GhostNames.Add("Goryo");
            GhostNames.Add("Hantu");
            GhostNames.Add("Jinn");
            GhostNames.Add("Mare");
            GhostNames.Add("Moroi");
            GhostNames.Add("Myling");
            GhostNames.Add("Obake");
            GhostNames.Add("Oni");
            GhostNames.Add("Onryo");
            GhostNames.Add("Phantom");
            GhostNames.Add("Poltergeist");
            GhostNames.Add("Raiju");
            GhostNames.Add("Revenant");
            GhostNames.Add("Shade");
            GhostNames.Add("Spirit");
            GhostNames.Add("Thaye");
            GhostNames.Add("The Mimic");
            GhostNames.Add("The Twins");
            GhostNames.Add("Wraith");
            GhostNames.Add("Yokai");
            GhostNames.Add("Yurei");



        }

        private void BuildOutputListView()
        {
            foreach (Ghost ghost in Ghosts)
            {

                ListViewItem item = new ListViewItem(ghost.GhostName);
                foreach (string evidence in ghost.PotentialEvidence)
                {
                    item.SubItems.Add(evidence);
                    item.UseItemStyleForSubItems = false;
                }
                outputListView.Items.Add(item);
            }

            foreach (ListViewItem item in outputListView.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text == "Banshee" || subItem.Text == "Demon" || subItem.Text == "Deogen" || subItem.Text == "Goryo" || subItem.Text == "Hantu" || subItem.Text == "Jinn" || subItem.Text == "Mare" || subItem.Text == "Moroi" || subItem.Text == "Myling" || subItem.Text == "Obake" || subItem.Text == "Oni" || subItem.Text == "Onryo" || subItem.Text == "Phantom" || subItem.Text == "Poltergeist" || subItem.Text == "Raiju" || subItem.Text == "Revenant" || subItem.Text == "Shade" || subItem.Text == "Spirit" || subItem.Text == "Thaye" || subItem.Text == "The Mimic" || subItem.Text == "The Twins" || subItem.Text == "Wraith" || subItem.Text == "Yokai" || subItem.Text == "Yurei")
                    {
                        subItem.ForeColor = Color.White;
                    }
                    else
                    {
                        subItem.ForeColor = Color.LightGray;
                    }

                }
            }
        }

        private void BuildGhosts()
        {

            Ghost banshee = new Ghost("Banshee", new List<string> { "D.O.T.S", "Ghost Orbs", "Fingerprints" });
            Ghost demon = new Ghost("Demon", new List<string> { "Ghost Writing", "Fingerprints", "Freezing Temps" });
            Ghost deogen = new Ghost("Deogen", new List<string> { "D.O.T.S", "Ghost Writing", "Spirit Box" });
            Ghost goryo = new Ghost("Goryo", new List<string> { "D.O.T.S", "EMF 5", "Fingerprints" });
            Ghost hantu = new Ghost("Hantu", new List<string> { "Ghost Orbs", "Fingerprints", "Freezing Temps" });
            Ghost jinn = new Ghost("Jinn", new List<string> { "EMF 5", "Fingerprints", "Freezing Temps" });
            Ghost mare = new Ghost("Mare", new List<string> { "Ghost Writing", "Ghost Orbs", "Spirit Box" });
            Ghost moroi = new Ghost("Moroi", new List<string> { "Ghost Writing", "Freezing Temps", "Spirit Box" });
            Ghost myling = new Ghost("Myling", new List<string> { "Ghost Writing", "EMF 5", "Fingerprints" });
            Ghost obake = new Ghost("Obake", new List<string> { "EMF 5", "Ghost Orbs", "Fingerprints" });
            Ghost oni = new Ghost("Oni", new List<string> { "D.O.T.S", "EMF 5", "Freezing Temps" });
            Ghost Onryo = new Ghost("Onryo", new List<string> { "Ghost Orbs", "Freezing Temps", "Spirit Box" });
            Ghost phantom = new Ghost("Phantom", new List<string> { "D.O.T.S", "Fingerprints", "Spirit Box" });
            Ghost poltergeist = new Ghost("Poltergeist", new List<string> { "Ghost Writing", "Fingerprints", "Spirit Box" });
            Ghost raiju = new Ghost("Raiju", new List<string> { "D.O.T.S", "EMF 5", "Ghost Orbs" });
            Ghost revenant = new Ghost("Revenant", new List<string> { "Ghost Writing", "Ghost Orbs", "Freezing Temps" });
            Ghost shade = new Ghost("Shade", new List<string> { "Ghost Writing", "EMF 5", "Freezing Temps" });
            Ghost spirit = new Ghost("Spirit", new List<string> { "Ghost Writing", "EMF 5", "Spirit Box" });
            Ghost thaye = new Ghost("Thaye", new List<string> { "D.O.T.S", "Ghost Writing", "Ghost Orbs" });
            Ghost theMimic = new Ghost("The Mimic", new List<string> { "Fingerprints", "Freezing Temps", "Spirit Box", "Ghost Orbs" });
            Ghost theTwins = new Ghost("The Twins", new List<string> { "EMF 5", "Freezing Temps", "Spirit Box" });
            Ghost wraith = new Ghost("Wraith", new List<string> { "D.O.T.S", "EMF 5", "Spirit Box" });
            Ghost yokai = new Ghost("Yokai", new List<string> { "D.O.T.S", "Ghost Orbs", "Spirit Box" });
            Ghost yurei = new Ghost("Yurei", new List<string> { "D.O.T.S", "Ghost Orbs", "Freezing Temps" });

            Ghosts.Add(banshee);
            Ghosts.Add(demon);
            Ghosts.Add(deogen);
            Ghosts.Add(goryo);
            Ghosts.Add(hantu);
            Ghosts.Add(jinn);
            Ghosts.Add(mare);
            Ghosts.Add(moroi);
            Ghosts.Add(myling);
            Ghosts.Add(obake);
            Ghosts.Add(oni);
            Ghosts.Add(Onryo);
            Ghosts.Add(phantom);
            Ghosts.Add(poltergeist);
            Ghosts.Add(raiju);
            Ghosts.Add(revenant);
            Ghosts.Add(shade);
            Ghosts.Add(spirit);
            Ghosts.Add(thaye);
            Ghosts.Add(theMimic);
            Ghosts.Add(theTwins);
            Ghosts.Add(wraith);
            Ghosts.Add(yokai);
            Ghosts.Add(yurei);

        }


        private void BuildDetectedGhostsList()
        {
            DetectedGhosts.Clear();


            foreach (Ghost ghost in Ghosts)
            {


                string potentialGhostName;
                List<string> potentialGhostEvidence = new List<string>();
                var potentialGhostFound = false;

                foreach (string evidence in Evidence)
                {
                    if (ghost.PotentialEvidence.Contains(evidence))
                    {
                        potentialGhostFound = true;
                    }
                    else
                    {
                        potentialGhostFound = false;
                        break;
                    }
                }
                foreach (string evidence in BlockedEvidence)
                {
                    if (ghost.PotentialEvidence.Contains(evidence))
                    {
                        potentialGhostFound = false;
                        break;
                    }
                }

                if (potentialGhostFound)
                {
                    potentialGhostName = ghost.GhostName;
                    foreach (string evidence in ghost.PotentialEvidence)
                    {
                        if (!Evidence.Contains(evidence))
                        {
                            potentialGhostEvidence.Add(evidence);
                        }
                    }

                    Ghost potentialGhost = new Ghost(potentialGhostName, potentialGhostEvidence);
                    DetectedGhosts.Add(potentialGhost);
                }

            }
        }

        private void DisplayResults()
        {
            outputListView.Items.Clear();


            foreach (Ghost ghost in DetectedGhosts)
            {

                ListViewItem item = new ListViewItem(ghost.GhostName);
                foreach (string evidence in ghost.PotentialEvidence)
                {
                    item.SubItems.Add(evidence);
                    item.UseItemStyleForSubItems = false;
                }
                outputListView.Items.Add(item);
            }

            foreach (ListViewItem item in outputListView.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text == "Banshee" || subItem.Text == "Demon" || subItem.Text == "Deogen" || subItem.Text == "Goryo" || subItem.Text == "Hantu" || subItem.Text == "Jinn" || subItem.Text == "Mare" || subItem.Text == "Moroi" || subItem.Text == "Myling" || subItem.Text == "Obake" || subItem.Text == "Oni" || subItem.Text == "Onryo" || subItem.Text == "Phantom" || subItem.Text == "Poltergeist" || subItem.Text == "Raiju" || subItem.Text == "Revenant" || subItem.Text == "Shade" || subItem.Text == "Spirit" || subItem.Text == "Thaye" || subItem.Text == "The Mimic" || subItem.Text == "The Twins" || subItem.Text == "Wraith" || subItem.Text == "Yokai" || subItem.Text == "Yurei")
                    {
                        subItem.ForeColor = Color.White;
                    }
                    else
                    {
                        subItem.ForeColor = Color.LightGray;
                    }

                }
            }
        }

        //Evidence Buttons

        private void BDots_CheckedChanged(object sender, EventArgs e)
        {
            if (bDots.Checked)
            {
                Evidence.Add("D.O.T.S");
                xDots.Checked = false;
            }
            else
                Evidence.Remove("D.O.T.S");

            BuildDetectedGhostsList();
            DisplayResults();

        }

        private void BWriting_CheckedChanged(object sender, EventArgs e)
        {
            if (bWriting.Checked)
            {
                Evidence.Add("Ghost Writing");
                xWriting.Checked = false;
            }
            else
                Evidence.Remove("Ghost Writing");

            BuildDetectedGhostsList();
            DisplayResults();

        }

        private void BEMF_CheckedChanged(object sender, EventArgs e)
        {
            if (bEMF.Checked)
            {
                Evidence.Add("EMF 5");
                xEMF.Checked = false;
            }
            else
                Evidence.Remove("EMF 5");

            BuildDetectedGhostsList();
            DisplayResults();

        }

        private void BOrbs_CheckedChanged(object sender, EventArgs e)
        {
            if (bOrbs.Checked)
            {
                Evidence.Add("Ghost Orbs");
                xOrbs.Checked = false;
            }
            else
                Evidence.Remove("Ghost Orbs");

            BuildDetectedGhostsList();
            DisplayResults();


        }

        private void BPrints_CheckedChanged(object sender, EventArgs e)
        {
            if (bPrints.Checked)
            {
                Evidence.Add("Fingerprints");
                xPrints.Checked = false;
            }
            else
                Evidence.Remove("Fingerprints");

            BuildDetectedGhostsList();
            DisplayResults();
        }

        private void BTemps_CheckedChanged(object sender, EventArgs e)
        {
            if (bTemps.Checked)
            {
                Evidence.Add("Freezing Temps");
                xTemps.Checked = false;
            }
            else
                Evidence.Remove("Freezing Temps");

            BuildDetectedGhostsList();
            DisplayResults();
        }

        private void BSpiritBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bSpiritBox.Checked)
            {
                Evidence.Add("Spirit Box");
                xSpiritBox.Checked = false;
            }
            else
                Evidence.Remove("Spirit Box");

            BuildDetectedGhostsList();
            DisplayResults();
        }

        //NotEvidence Buttons

        private void XDots_CheckedChanged(object sender, EventArgs e)
        {
            if (xDots.Checked)
            {
                bDots.Checked = false;
                bDots.BackColor = Color.DarkRed;
                BlockedEvidence.Add("D.O.T.S");
            }
            else
            {
                bDots.BackColor = Color.DimGray;
                BlockedEvidence.Remove("D.O.T.S");

            }

            BuildDetectedGhostsList();
            DisplayResults();

        }

        private void XWriting_CheckedChanged(object sender, EventArgs e)
        {
            if (xWriting.Checked)
            {
                bWriting.Checked = false;
                bWriting.BackColor = Color.DarkRed;
                BlockedEvidence.Add("Ghost Writing");

            }
            else
            {
                bWriting.BackColor = Color.DimGray;
                BlockedEvidence.Remove("Ghost Writing");

            }

            BuildDetectedGhostsList();
            DisplayResults();
        }

        private void XEMF_CheckedChanged(object sender, EventArgs e)
        {
            if (xEMF.Checked)
            {
                bEMF.Checked = false;
                bEMF.BackColor = Color.DarkRed;
                BlockedEvidence.Add("EMF 5");

            }
            else
            {
                bEMF.BackColor = Color.DimGray;
                BlockedEvidence.Remove("EMF 5");
            }
            BuildDetectedGhostsList();
            DisplayResults();

        }

        private void XOrbs_CheckedChanged(object sender, EventArgs e)
        {
            if (xOrbs.Checked)
            {
                bOrbs.Checked = false;
                bOrbs.BackColor = Color.DarkRed;
                BlockedEvidence.Add("Ghost Orbs");

            }
            else
            {
                bOrbs.BackColor = Color.DimGray;
                BlockedEvidence.Remove("Ghost Orbs");
            }
            BuildDetectedGhostsList();
            DisplayResults();

        }

        private void XPrints_CheckedChanged(object sender, EventArgs e)
        {
            if (xPrints.Checked)
            {
                bPrints.Checked = false;
                bPrints.BackColor = Color.DarkRed;
                BlockedEvidence.Add("Fingerprints");
            }
            else
            {
                bPrints.BackColor = Color.DimGray;
                BlockedEvidence.Remove("Fingerprints");
            }
            BuildDetectedGhostsList();
            DisplayResults();

        }

        private void XTemps_CheckedChanged(object sender, EventArgs e)
        {
            if (xTemps.Checked)
            {
                bTemps.Checked = false;
                bTemps.BackColor = Color.DarkRed;
                BlockedEvidence.Add("Freezing Temps");
            }
            else
            {
                bTemps.BackColor = Color.DimGray;
                BlockedEvidence.Remove("Freezing Temps");
            }
            BuildDetectedGhostsList();
            DisplayResults();

        }

        private void XSpiritBox_CheckedChanged(object sender, EventArgs e)
        {
            if (xSpiritBox.Checked)
            {
                bSpiritBox.Checked = false;
                bSpiritBox.BackColor = Color.DarkRed;
                BlockedEvidence.Add("Spirit Box");
            }
            else
            {
                bSpiritBox.BackColor = Color.DimGray;
                BlockedEvidence.Remove("Spirit Box");
            }
            BuildDetectedGhostsList();
            DisplayResults();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();

        }

        public void Reset()
        {
            bDots.Checked = false;
            bEMF.Checked = false;
            bOrbs.Checked = false;
            bPrints.Checked = false;
            bSpiritBox.Checked = false;
            bTemps.Checked = false;
            bWriting.Checked = false;

            xDots.Checked = false;
            xEMF.Checked = false;
            xOrbs.Checked = false;
            xPrints.Checked = false;
            xSpiritBox.Checked = false;
            xTemps.Checked = false;
            xWriting.Checked = false;

            Evidence.Clear();
            DetectedGhosts.Clear();
            BlockedEvidence.Clear();

            BuildOutputListView();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by: \n\n" +
                "Taylor G. AKA: Bruce Nightly\n\n" +
                "This is a replacement journal for Phasmophobia " +
                "updated for all 23 ghosts in version: v0.6.2.0.\n\n");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
