/**********************************************************************
 *  Project:        Searching
 *  File:           CS_BinarySearch.cs
 *  Language:       C#
 *  
 *  Description:    This file is the Binary Search Class.
 *                  
 *  College:        Husson University
 *  Course:         IT 326
 *  
 *  Change Log
 *  Date        Notes
 *  --------    -------------------------------------
 *  1/30/25     Initial Binary Search
 *  2/2/25      Change to accept Strings
 *  2/2/25      Final Testing Complete
 *  **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyattSearching {
    internal class CS_BinarySearch {

        #region data
        public const int NOT_FOUND = -1;
        #endregion data

        #region methods

        public static int Search(string[] data, string target) {
            return Search(data, target, data.GetLowerBound(0), data.GetUpperBound(0));
        }

        /// <summary>
        /// This routine uses binary search to find the desired item in the data array 
        /// starting at the low index
        /// ending at high index
        /// </summary>
        /// <param name="data"></param>
        /// <param name="item"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns>Returns index if value is found, and NOT_FOUND if not found</returns>
        public static int Search(string[] data, string target, int low, int high) {
            bool found = false;
            int middle = 0;

            //Make sure low and high are valid - within array bounds
            if (low < data.GetLowerBound(0) || (high > data.GetUpperBound(0)) || (low > high)) {
                throw new ArgumentException("Invlaid low or high value provided");
            }

            while ((low <= high) && (!found)) {

                //Middle Calculation:
                middle = low + (high - low) / 2;

                //String Comparison:
                int comparison = string.Compare(data[middle], target, StringComparison.OrdinalIgnoreCase);

                //Check:
                if (comparison == 0) {
                    found = true;           //Target Found 
                }
                else if (comparison > 0) {
                    high = middle - 1;      //Target smaller - keep left side
                }
                else if (comparison < 0) {
                    low = middle + 1;      //Target larger - keep right side
                }
            }

            //Check if found:
            if (found) {
                return middle;
            }
            else {
                return NOT_FOUND;
            }
        }
        
        #endregion methods

    }
}

