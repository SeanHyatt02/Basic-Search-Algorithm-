/**********************************************************************
 *  Project:        Searching
 *  File:           CS_SequentialSearch.cs
 *  Language:       C#
 *  
 *  Description:    This file is the Sequential Search Class
 *                  
 *  College:        Husson University
 *  Course:         IT 326
 *  
 *  Change Log
 *  Date        Notes
 *  --------    -------------------------------------
 *  1/30/25     Initial Sequential Search
 *  2/2/25      Change to accept strings
 *  2/2/25      Final Testing Complete
 *  **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyattSearching {
    internal class CS_SequentialSearch {

        #region data
        public const int NOT_FOUND = -1;
        #endregion data

        #region methods

        //Search entire array
        public static int Search(string[] data, string target) {
            return Search(data, target, data.GetLowerBound(0), data.GetUpperBound(0));
        }

        //Search starting at this position
        public static int Search(string[] data, string target, int start) {
            return Search(data, target, start, data.GetUpperBound(0));
        }

        //Search within a start and end 
        public static int Search(string[] data, string target, int start, int end) {
            int index = -1;

            //Make sure the start position is within the array bounds
            if ((start < data.GetLowerBound(0)) || (start > data.GetUpperBound(0))) {
                throw new ArgumentException("Start index out of bounds");
            }

            //Make sure end position within array bounds:
            if ((end < data.GetLowerBound(0)) || (end > data.GetUpperBound(0)) || (start > end)) {
                throw new ArgumentException("end index out of bounds");
            }

            //Start searching at start index
            index = start;
            while ((index <= end) && (data[index] != target)) {
                index++;
            }

            //Determine which stopped loop
            if (index <= end) {
                return index; //Found it
            }
            else {
                //Item not found index > end
                return NOT_FOUND;
            }
        }

        #endregion methods
    }
}
