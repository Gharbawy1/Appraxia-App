using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace DisabilityApp
{
    public partial class StartForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x upper left
                int nTopRect, //  y  uper left
                int nRightRect,  // x lower right
                int nBottomRect, // y  lower Right
                int nWidthEllipse,
                int nHightEllipse

            );



        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }



        // FOLDER 1 
        private void F1_Click(object sender, EventArgs e)
        {
            F1Arrow.Visible = true;
            Folder1Container.Visible = true;
            F2VideoBtn.Visible = false;
            F3VideoBtn.Visible = false;
            F5VideoBtn.Visible = false;
            F6BaseBtn.Visible = false; F7VidoeBtn.Visible = false;
            F9VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;

            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }
            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }

            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
        }
        // FOLDER 2
        private void F2_Click(object sender, EventArgs e)
        {
            F2Arrow.Visible = true;
            F2Container.Visible = true;
            F2VideoBtn.Visible = true;

            F5VideoBtn.Visible = false;
            F6BaseBtn.Visible = false; F7VidoeBtn.Visible = false;
            F9VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;
            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }
            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }

            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }
        }
        // FOLDER 3
        private void F3_Click(object sender, EventArgs e)
        {
            F3Arrow.Visible = true;
            Folder3Container.Visible = true;
            F3VideoBtn.Visible = true;
            F2VideoBtn.Visible = false;
            F6BaseBtn.Visible = false;
            F5VideoBtn.Visible = false;
            F7VidoeBtn.Visible = false;
            F9VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;
            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }
            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }

            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }
        }
        // FOLDER 4
        private void F4_Click(object sender, EventArgs e)
        {
            F4Arrow.Visible = true;
            Folder4Container.Visible = true;
            F6BaseBtn.Visible = false;
            F2VideoBtn.Visible = false;
            F5VideoBtn.Visible = false;
            F7VidoeBtn.Visible = false;
            F9VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;
            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }
            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }

            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }
        }
        // FOLDER 5
        private void F5_Click(object sender, EventArgs e)
        {
            F5Arrow.Visible = true;
            F5Container.Visible = true;
            F5VideoBtn.Visible = true;
            F2VideoBtn.Visible = false;
            F7VidoeBtn.Visible = false;
            F9VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;
            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }
            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }

            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }

        }
        // FOLDER 6
        // FOLDER 7
        private void F7_Click(object sender, EventArgs e)
        {
            F7Arrow.Visible = true;
            F7Container.Visible = true;
            F7VidoeBtn.Visible = true;
            F6BaseBtn.Visible = true;

            F2VideoBtn.Visible = false;
            F5VideoBtn.Visible = false;
            // F8VideoBtn.Visible = false;
            F9VideoBtn.Visible = false;
            //F11VideoBtn.Visible = false;
            //F12VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;
            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }
            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }

            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }
        }
        // FOLDER 8
        private void F8_Click(object sender, EventArgs e)
        {

            F8Arrow.Visible = true;
            F8Container.Visible = true;
            F8Container.BringToFront();
            //  F8VideoBtn.Visible = true;

            F2VideoBtn.Visible = false;
            F5VideoBtn.Visible = false;
            F6BaseBtn.Visible = false; F7VidoeBtn.Visible = false;
            F9VideoBtn.Visible = false;
            //F11VideoBtn.Visible = false;
            //F12VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;

            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }
            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }

            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }
        }
        // FOLDER  9
        private void F9_Click(object sender, EventArgs e)
        {
            F9Arrow.Visible = true;
            F9Container.Visible = true;
            F9VideoBtn.Visible = true;
            F2VideoBtn.Visible = false;
            F5VideoBtn.Visible = false;
            F6BaseBtn.Visible = false; F7VidoeBtn.Visible = false;
            //            F8VideoBtn.Visible = false;
            //          F11VideoBtn.Visible = false;
            //        F12VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;

        }

        private void F10_Click(object sender, EventArgs e)
        {
            F10Arrow.Visible = true;
            F10Container.Visible = true;
            F10VideoBtn.Visible = true;
            F2VideoBtn.Visible = false;
            F5VideoBtn.Visible = false;
            F6BaseBtn.Visible = false; F7VidoeBtn.Visible = false;
            //      F8VideoBtn.Visible = false;
            F9VideoBtn.Visible = false;
            //    F11VideoBtn.Visible = false;
            //  F12VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;
            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }
            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }
            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }
            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }
        }

        private void F11_Click(object sender, EventArgs e)
        {
            F11Arrow.Visible = true;
            F11Container.Visible = true;
            //F11VideoBtn.Visible = true;
            F2VideoBtn.Visible = false;
            F5VideoBtn.Visible = false;
            F6BaseBtn.Visible = false; F7VidoeBtn.Visible = false;
            //F8VideoBtn.Visible = false;
            F9VideoBtn.Visible = false;
            //F12VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;
            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }
            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }
            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }
            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }
        }



        /// <summary>
        /// //////////////
        /// </summary>

        // for subfolder6
        private void button10_Click(object sender, EventArgs e)
        {

            F6ShowContent.Visible = true;
            F6Title1.Visible = false;
            F62Arrow.Visible = false;
            comp21.Visible = false;
            comp21Content.Visible = false;
            comp22Content.Visible = false;
            comp23Content.Visible = false;
            comp22.Visible = false;
            comp24Content.Visible = false;
            // display the content
            F6hArrow.Visible = true;
            F6Title1.Visible = true;

            comp11.Visible = true;
            comp11content.Visible = true;
            comp12.Visible = true;
            comp12content.Visible = true;

            // then next btn
        }

        private void F10Container_Click(object sender, EventArgs e)
        {
            F10SubContainer.Visible = true;
        }

        private void WhatIsAppraxButton_Click(object sender, EventArgs e)
        {

            F11ShowContent.Visible = true;
            F11Content.BringToFront();
            FoldersPanel.Visible = false;
            FoldersPanel.SendToBack();
            F1Arrow.Visible = false;
            Folder1Container.Visible = false;
            //
            F8.Visible = false;
            F13.Visible = false;
            label13.Visible = false;
            F12.Visible = false;
            pictureBox14.Visible = false;
            label10.Visible = false;
            label12.Visible = false;
            label11.Visible = false;

        }

        private void MoreDeffBtn_Click(object sender, EventArgs e)
        {
            F12ShowContent.Visible = true;
            F12ShowContent.BringToFront();
        }

        private void F2Container_Click(object sender, EventArgs e)
        {
            F2ShowContent.Visible = true;
            F2ShowContent.BringToFront();
        }

        // for F32ShowContent
        private void button3_Click(object sender, EventArgs e)
        {
            Sub32ShowContent.Visible = true;
            Sub32ShowContent.BringToFront();
        }

        private void F31ShowContent_Click(object sender, EventArgs e)
        {
            Sub31ShowContent.Visible = true;
            Sub31ShowContent.BringToFront();
        }

        private void F33ShowContent_Click(object sender, EventArgs e)
        {
            Sub33ShowContent.Visible = true;
            Sub33ShowContent.BringToFront();
        }

        private void F41ShowContent_Click(object sender, EventArgs e)
        {
            F4ShowContent.Visible = true;
            F41ShowContent.BringToFront();
        }


        private void F5Container_Click(object sender, EventArgs e)
        {
            F5ShowContent.Visible = true;
            F5ShowContent.BringToFront();
        }

        private void F61SubShowContent_Click(object sender, EventArgs e)
        {


        }
        // copy it to next btn
        private void F62SubShowContent_Click(object sender, EventArgs e)
        {

        }

        private void F7Container_Click(object sender, EventArgs e)
        {
            F7ShowContent.Visible = true;
            F7ShowContent.BringToFront();
        }

        private void F8Container_Click(object sender, EventArgs e)
        {
            F8ShowContent.Visible = true;
            F8ShowContent.BringToFront();
        }

        private void F9Container_Click(object sender, EventArgs e)
        {
            F91ShowContent.Visible = true;
            F91ShowContent.BringToFront();
        }

        private void Home12_Click(object sender, EventArgs e)
        {
            F12ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void Home11_Click(object sender, EventArgs e)
        {

            F11ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
            F8.Visible = true;
            F13.Visible = true;
            label13.Visible = true;
            F12.Visible = true;
            pictureBox14.Visible = true;
            label10.Visible = true;
            label12.Visible = true;
            label11.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Sub1ContentF21.Visible = false;
            Sub3ContentF21.Visible = false;
            Sub2ContentF21.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Sub2ContentF21.Visible = false;
            Sub1ContentF21.Visible = true;
            Sub3ContentF21.Visible = true;
            Sub1ContentF21.BringToFront();
            Sub3ContentF21.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // home F2
        private void button2_Click(object sender, EventArgs e)
        {
            F2ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }



        private void button12_Click(object sender, EventArgs e)
        {
            // first item of options of foldr 10
            F101ShowContent.Visible = true;
            F101ShowContent.BringToFront();
        }

        private void Sub102ContentF10_Click(object sender, EventArgs e)
        {
            F102ShowContent.Visible = true;
            F102ShowContent.BringToFront();
        }
        /*
        private void F8Container_Click(object sender, EventArgs e)
        {
            F8ShowContent.Visible = true;
            F8ShowContent.BringToFront();

        }*/

        private void F11Container_Click(object sender, EventArgs e)
        {
            // the f11 button that display content of folder11
            Folder11ShowContent.Visible = true;
            Folder11ShowContent.BringToFront();
        }

        private void Home8_Click(object sender, EventArgs e)
        {
            F8ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }



        private void Home7_Click_1(object sender, EventArgs e)
        {
            F7ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }


        private void Home5_Click_1(object sender, EventArgs e)
        {
            F5ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }



        private void Home32_Click(object sender, EventArgs e)
        {
            Sub32ShowContent.Visible = false;

            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void Home31_Click_1(object sender, EventArgs e)
        {
            Sub31ShowContent.Visible = false;

            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void Home33_Click(object sender, EventArgs e)
        {
            Sub33ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void Home9_Click(object sender, EventArgs e)
        {
            F91ShowContent.Visible = false;

            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }



        private void button35_Click(object sender, EventArgs e)
        {
            // next btn for folder 9
            // first infisable the old 2 picture
            SideF9Panel11.Visible = false;
            SideF9Panel12.Visible = false;
            // second display the new
            SideF9Panel21.Visible = true;
            SideF9Panel22.Visible = true;
            SideF9Panel23.Visible = true;
            SideF9Panel23.BringToFront();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            // privious btn in folder 9
            SideF9Panel21.Visible = false;
            SideF9Panel22.Visible = false;
            SideF9Panel23.Visible = false;

            // show the old
            SideF9Panel11.Visible = true;
            SideF9Panel12.Visible = true;
        }

        private void Home101_Click(object sender, EventArgs e)
        {
            F101ShowContent.Visible = false;

            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void Home102_Click_1(object sender, EventArgs e)
        {
            F102ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();

        }

        private void Sub31ShowContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F13_Click(object sender, EventArgs e)
        {
            F13Arrow.Visible = true;
            F13Container.Visible = true;
            F13VideoBtn.Visible = true;
            F2VideoBtn.Visible = false;
            F5VideoBtn.Visible = false;
            //F6VideoBtn.Visible = false;
            F7VidoeBtn.Visible = false;
            // F8VideoBtn.Visible = false;
            F9VideoBtn.Visible = false;
            //F11VideoBtn.Visible = false;
            //F12VideoBtn.Visible = false;
            if (F12Container.Visible)
            {
                F12Arrow.Visible = false;
                F12Container.Visible = false;
            }

            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }
            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }
            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }

        }

        private void F13Container_Click(object sender, EventArgs e)
        {
            // dislpaly the content f13
            F13ShowContent.Visible = true;
            F13ShowContent.BringToFront();
        }


        // not display the f12 btn
        private void F12_Click_1(object sender, EventArgs e)
        {
            F12Arrow.Visible = true;
            F12Container.Visible = true;
            //F12VideoBtn.Visible = true;
            F2VideoBtn.Visible = false;
            F5VideoBtn.Visible = false;
            F6BaseBtn.Visible = false;
            F7VidoeBtn.Visible = false;
            //F8VideoBtn.Visible = false;
            F9VideoBtn.Visible = false;
            //F11VideoBtn.Visible = false;
            F13VideoBtn.Visible = false;

            if (F13Container.Visible)
            {
                F13Arrow.Visible = false;
                F13Container.Visible = false;
            }
            if (F2Container.Visible)
            {
                F2Arrow.Visible = false;
                F2Container.Visible = false;
            }
            if (F10Container.Visible)
            {
                F10Arrow.Visible = false;
                F10Container.Visible = false;
                if (F10SubContainer.Visible == true)
                {
                    F10SubContainer.Visible = false;
                }
            }
            if (F11Container.Visible)
            {
                F11Arrow.Visible = false;
                F11Container.Visible = false;
            }
            if (Folder3Container.Visible)
            {
                F3Arrow.Visible = false;
                Folder3Container.Visible = false;
            }
            if (Folder4Container.Visible)
            {
                F4Arrow.Visible = false;
                Folder4Container.Visible = false;
            }
            if (F5Container.Visible)
            {
                F5Arrow.Visible = false;
                F5Container.Visible = false;
            }
            if (Folder1Container.Visible)
            {
                F1Arrow.Visible = false;
                Folder1Container.Visible = false;
            }
            if (F7Container.Visible)
            {
                F7Arrow.Visible = false;
                F7Container.Visible = false;
            }
            if (F8Container.Visible)
            {
                F8Arrow.Visible = false;
                F8Container.Visible = false;
            }
            if (F9Container.Visible)
            {
                F9Arrow.Visible = false;
                F9Container.Visible = false;
            }
        }



        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // info btn
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void F12Container_Click_1(object sender, EventArgs e)
        {
            // to display the content
            F12ShowContent1.Visible = true;
            F12ShowContent1.BringToFront();
        }

        private void GoToVideosForm_Click(object sender, EventArgs e)
        {
            VideoShowForm NewForm = new VideoShowForm();
            NewForm.ShowDialog();
        }

        private void HomeF11_Click(object sender, EventArgs e)
        {
            Folder11ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

        }


        int i = 1;
        private void button121_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                // viwe page2
                F11PicRight.Visible = false;
                F11PicLeft.Visible = false;
                pictureBox38.Visible = false;
                SideFolder11right.Visible = true;
                SideFolder11left.Visible = true;
                i++;
            }
            else if (i == 2)
            {
                SideFolder11right.Visible = false;
                SideFolder11left.Visible = false;
                pic1right.Visible = true;
                pic1left.Visible = true;

            }

        }
        private void button120_Click(object sender, EventArgs e)
        {
            if (i == 2)
            {
                pic1right.Visible = false;
                pic1left.Visible = false;
                SideFolder11right.Visible = true;
                SideFolder11left.Visible = true;
                i--;
            }
            else if (i == 1)
            {
                SideFolder11right.Visible = false;
                SideFolder11left.Visible = false;
                F11PicRight.Visible = true;
                F11PicLeft.Visible = true;
                pictureBox38.Visible = true;
            }

        }

        private void Home4_Click(object sender, EventArgs e)
        {
            F4ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            pic4right.Visible = false;
            pic4left.Visible = false;
            label37.Visible = false;
            label32.Visible = true;
            label4Head.Visible = true;
            label4title1.Visible = true;
            content41.Visible = true;
            label4title2.Visible = true;
            content42.Visible = true;
            TheLast1.Visible = true;
            TheLast2.Visible = true;
            f4arrowright.Visible = true;
            f4arrowright1.Visible = true;

        }

        private void button39_Click(object sender, EventArgs e)
        {
            pic4right.Visible = true;
            pic4left.Visible = true;
            label37.Visible = true;
            TheLast2.Visible = false;
            TheLast1.Visible = false;
            label32.Visible = false;
            label4Head.Visible = false;
            label4title1.Visible = false;
            content41.Visible = false;
            label4title2.Visible = false;
            content42.Visible = false;
            f4arrowright.Visible = false;
            f4arrowright1.Visible = false;
        }

        private void Home6_Click(object sender, EventArgs e)
        {
            F6ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Home121_Click(object sender, EventArgs e)
        {
            F12ShowContent1.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void Home13_Click(object sender, EventArgs e)
        {
            F13ShowContent.Visible = false;
            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }


        private void F6VideoBtn_Click(object sender, EventArgs e)
        {

        }

        private void F1VideoBtn_Click(object sender, EventArgs e)
        {
            string projectPath = @"C:\Users\HP\Desktop\DisabilityAPP\DisabilityAPP\bin\Debug\DisabilityAPP.exe";
            Process.Start(projectPath);
        }

        private void F2VideoBtn_Click(object sender, EventArgs e)
        {

        }

        private void F3VideoBtn_Click(object sender, EventArgs e)
        {
            string projectPath = @"C:\Users\HP\Desktop\F2VID\F2VID\bin\Debug\F2VID.exe";
            Process.Start(projectPath);
        }

        private void F4VideoBtn_Click(object sender, EventArgs e)
        {
            //
            string projectPath = @"C:\Users\HP\Desktop\F3Vid\F3Vid\bin\Debug\F3Vid.exe";
            Process.Start(projectPath);
        }

        private void F5VideoBtn_Click(object sender, EventArgs e)
        {
            string projectPath = @"C:\Users\HP\Desktop\F4VId\F4VId\bin\Debug\F4VId.exe";
            Process.Start(projectPath);
        }

        private void F7VidoeBtn_Click(object sender, EventArgs e)
        {
            //
            string projectPath = @"C:\Users\HP\Desktop\F5Vid\F5Vid\bin\Debug\F5Vid.exe";
            Process.Start(projectPath);
        }

        private void F8VideoBtn_Click(object sender, EventArgs e)
        {

        }

        private void F9VideoBtn_Click(object sender, EventArgs e)
        {
            // 
            string projectPath = @"C:\Users\HP\Desktop\F6Vid\F6Vid\bin\Debug\F6Vid.exe";
            Process.Start(projectPath);
        }

        private void F10VideoBtn_Click(object sender, EventArgs e)
        {

        }

        private void F11VideoBtn_Click(object sender, EventArgs e)
        {

        }

        private void F12VideoBtn_Click(object sender, EventArgs e)
        {

        }

        private void F13VideoBtn_Click(object sender, EventArgs e)
        {
            //
            string projectPath = @"C:\Users\HP\Desktop\F7Vid\F7Vid\bin\Debug\F7Vid.exe";
            Process.Start(projectPath);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {

            FoldersPanel.Visible = true;
            FoldersPanel.BringToFront();
        }

        private void button43_Click(object sender, EventArgs e)
        {

            F6ShowContent.Visible = true;
            F6hArrow.Visible = false;
            F6Title1.Visible = false;

            comp11.Visible = false;
            comp11content.Visible = false;
            comp12.Visible = false;
            comp12content.Visible = false;
            // display the content
            F6title2.Visible = true;
            F62Arrow.Visible = true;
            comp21.Visible = true;
            comp21Content.Visible = true;
            comp22Content.Visible = true;
            comp23Content.Visible = true;
            comp22.Visible = true;
            comp24Content.Visible = true;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            F6ShowContent.Visible = true;
            F6Title1.Visible = false;
            F62Arrow.Visible = false;
            comp21.Visible = false;
            comp21Content.Visible = false;
            comp22Content.Visible = false;
            comp23Content.Visible = false;
            comp22.Visible = false;
            comp24Content.Visible = false;
            // display the content
            F6hArrow.Visible = true;
            F6Title1.Visible = true;

            comp11.Visible = true;
            comp11content.Visible = true;
            comp12.Visible = true;
            comp12content.Visible = true;
        }

        private void F8Container_Click_1(object sender, EventArgs e)
        {
            F8ShowContent.Visible = true;
            F8ShowContent.BringToFront();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void F2ShowContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            label40.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, label40.Width, label40.Height, 30, 30));

            F1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F9.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F10.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F11.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));
            F13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, F1.Width, F1.Height, 30, 30));

        }
    }

}