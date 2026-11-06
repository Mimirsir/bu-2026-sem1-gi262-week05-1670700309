using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{

    public interface IAssignment
    {
        #region Lecture 
        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Selection Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] LCT01_SelectionSortAscending(int[] numbers);

        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Bubble Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] LCT02_BubbleSortAscending(int[] numbers);

        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Insertion Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] LCT03_InsertionSortAscending(int[] numbers);
        #endregion

        #region Assignment
        /// <summary>
        /// เรียงลำดับตัวเลขจากมากไปน้อยโดยใช้ Selection Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] AS01_SelectionSortDescending(int[] numbers);

        /// <summary>
        /// เรียงลำดับตัวเลขจากมากไปน้อยโดยใช้ Bubble Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] AS02_BubbleSortDescending(int[] numbers);

        /// <summary>
        /// เรียงลำดับตัวเลขจากมากไปน้อยโดยใช้ Insertion Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] AS03_InsertionSortDescending(int[] numbers);

        #endregion

        #region Extra

        #endregion
    }
}
