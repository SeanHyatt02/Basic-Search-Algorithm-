/**********************************************************************
 *  Project:        Searching
 *  File:           Form1.cs
 *  Language:       C#
 *  
 *  Description:    This file is the form for searching a list of stars in two files using binary
 *                  and sequential searches.
 *                  
 *  College:        Husson University
 *  Course:         IT 326
 *  
 *  Change Log
 *  Date        Notes
 *  --------    -------------------------------------
 *  1/30/25     Initial Form Design
 *  2/2/25      Finished Sequential and Binary Searches
 *  2/2/25      Final Testing Complete
 *  **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Diagnostics;

namespace HyattSearching {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region data
        String[] starArray;
        #endregion data

        #region File

        /// <summary>
        /// Calls necessary functions when upload button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFileUpload_Click(object sender, EventArgs e) {
            String filename;

            //Get the fileName
            filename = GetFileName();

            //Process the file
            if (filename != null) {
                ReadDataFromTextFile(filename, ref starArray);
            }

            //Display data
            DisplayDataInListBox();
        }


        /// <summary>
        /// Uses Open File Dialoge to alow user to select single file
        /// If no file selected, returns null
        /// </summary>
        /// <returns></returns>
        private String GetFileName() {
            String filename = null;

            //configure the open file dialoge
            OpenFileDialog openDialog = new OpenFileDialog();

            //Set up 
            openDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString(); //Go to PC's my documents
            openDialog.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*"; //Any file that ends in .txt or all files
            openDialog.FilterIndex = 1; //Default file is txt
            openDialog.Multiselect = false; //Only one file
            openDialog.RestoreDirectory = true; //Stay at the directory they chose

            //Show to user:
            //Did the user click the "open" button on dialog
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                filename = openDialog.FileName;
            }
            //Return the file name or Null
            return filename;
        }


        /// <summary>
        /// Function to process the data from the file
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="valueArray"></param>
        private void ReadDataFromTextFile(String filename, ref String[] starArray) {
            String oneLine;             //One line of text from file
            System.IO.StreamReader datafile = null; //Stream for the data file

            try {
                //Open the file
                datafile = new System.IO.StreamReader(filename);

                //Read all lines into a list
                List<String> lines = new List<String>();
                while ((oneLine = datafile.ReadLine()) != null) {
                    lines.Add(oneLine);
                }

                //Convert to array
                starArray = lines.ToArray();    

            } catch (Exception ex) {

                MessageBox.Show("File Content Error - " + ex.Message);

            } finally {
                datafile.Close();
            }
        }

        /// <summary>
        /// Displays the data from file to list box
        /// </summary>
        private void DisplayDataInListBox() {
            //Clear list box
            listBoxDisplay.Items.Clear(); 

            if (starArray != null) {

                //Add each to listbox
                foreach (string s in starArray) {
                    listBoxDisplay.Items.Add(s);   
                }
            }
        }

        #endregion File

        #region events

        /// <summary>
        /// This event calls the sequential search methods to search for a star name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSequential_Click(object sender, EventArgs e) {
            String searchValue = textBoxInput.Text.Trim();
            int result;

            //Check to see if text box is empty
            if (string.IsNullOrEmpty(searchValue)) {
                MessageBox.Show("Please enter a star to search for!");
                return;     
            }

            //Stopwatch:
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //Sequential Search
            result = CS_SequentialSearch.Search(starArray, searchValue);

            //Stop Stopwatch:
            sw.Stop();

            //Result not found
            if (result == CS_SequentialSearch.NOT_FOUND) {
                labelResults.Text = String.Format("Sorry, {0} was not found in the dataset.", searchValue);
                labelTime.Text = "Time Taken: ";
            } else {
                labelResults.Text = String.Format("The star, {0} was found at position {1}.", searchValue, result);
                labelTime.Text = String.Format("Time Taken: {0} ms", sw.ElapsedMilliseconds);
            }
        }

        /// <summary>
        /// Routine to call binary search methods, and record stopwatch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBinary_Click(object sender, EventArgs e) {
            String searchValue = textBoxInput.Text.Trim(); 
            int result;

            //Check if empty:
            if (string.IsNullOrEmpty(searchValue)) {
                MessageBox.Show("Please enter a star to search for!");
                return;
            }

            //Stopwatch:
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //Binary Search
            result = CS_BinarySearch.Search(starArray, searchValue);

            //Stop Stopwatch:
            sw.Stop();

            //Result not found
            if (result == CS_BinarySearch.NOT_FOUND) {
                labelResults.Text = String.Format("Sorry, {0} was not found in the dataset.", searchValue);
                labelTime.Text = "Time Taken: ";
            }
            else {
                labelResults.Text = String.Format("The star, {0} was found at position {1}.", searchValue, result);
                labelTime.Text = String.Format("Time Taken: {0} ms", sw.ElapsedMilliseconds);
            }
        }

        #endregion events

    }
}
