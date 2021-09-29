using System;

namespace GDLibrary.Utility
{
    /// <summary>
    /// Provide math functions for use within our game 
    /// </summary>
    /// <see cref="GBLibrary.Program"/>
    /// <seealso cref="GDLibrary.Program"/>
    /// <exaple>
    /// int rand = MathUtility.RandInRange(1,100>;
    /// </exaple>
    class MathUtility
    {
        /// <summary>
        /// Returns a int in the range lo-hi 
        /// </summary>
        /// <param name="lo"> Integer value <=hi</param>
        /// <param name="hi">Integer value >= lo</param>
        /// <returns>Random integer</returns>
        public static int RandInRange(int lo, int hi)
        {
            if (hi < lo)
                throw new Exception("hi must be >= to lo");




            //System.Random rand = new System.Random();
            Random rand = new Random();
            //int x=(hi - lo) * rand.Next() + lo;

            return rand.Next(lo, hi);
        }

        //RandInRangeExcl (int lo, int hi, int exclusion
        //excluse a number 
        public static int RandInRangeExclude(int lo, int hi, int exclusion)
        {
            if (hi < lo)
                throw new Exception("hi must be >= to lo");
        }
    }
}
