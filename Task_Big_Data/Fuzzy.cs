using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Big_Data
{
    class  Fuzzy
    {
        #region Private filts
        /// <summary>
        /// Center: Function Item
        /// </summary>
        private double c;
        /// <summary>
        /// Left: Function Item
        /// </summary>
        private double l;
        /// <summary>
        /// Right: Function Item
        /// </summary>
        private double r;

        private static Fuzzy result;
        #endregion

        #region Constructor
        public Fuzzy(double _c=0, double _l=0,double _r=0)
        {
            this.c = _c;
            this.l = _l;
            this.r = _r;
        }
        #endregion

        #region Public Method

        /// This function  performs the addition operatio. return  object
        public static Fuzzy operator +(Fuzzy object1, Fuzzy object2)
        {
            result = new Fuzzy();
            result.c = object1.c + object2.c;
            result.l = object1.l + object2.l;
            result.r = object1.r + object2.r;
            return result;

        }
        // This function  perform a separation operation. return object
        public static Fuzzy operator -(Fuzzy object1, Fuzzy object2)
        {
            result = new Fuzzy();
            result.c = object1.c + object2.c;
            result.l = object1.l + object2.r;
            result.r = object1.r + object2.l;
            return result;
        }
        // This function  performs the multiplication operation. return object
        public static Fuzzy operator *(Fuzzy object1, Fuzzy object2)
        {
            result = new Fuzzy();
            result.c = object1.c * object2.c;
            if (object1.c > 0 && object2.c > 0)
            {
                result.l = object1.c * object2.l + object2.c * object1.l - object1.l * object2.c;
                result.r = object1.c * object2.r + object2.c * object1.r + object1.r * object2.r;
            }
            else if (object1.c > 0 && object2.c < 0)
            {
                result.l = object1.c * object2.r + object2.l * object1.l - object1.l * object2.c;
                result.r = object1.c * object2.l + object1.r * object1.c + object1.r * object2.l;
            }
            else if (object1.c < 0 && object2.c < 0)
            {

                result.l = object2.r * object1.r - (object1.c * object2.r + object2.c * object1.r);
                result.r = object1.l * object2.l + (object1.c * object2.l - object2.c * object1.l);
            }
            else
            {
                result = new Fuzzy();
            }
            return result;
        }
        // This function performs the division operation. return object
        public static Fuzzy operator /(Fuzzy object1, Fuzzy object2)
        {
            result = new Fuzzy();
            if (object1.c != 0 && object2.c != 0)
            {
                result.c = object1.c / object2.c;
                result.l = (object1.c * object2.r - object1.c * object2.l) / (object2.c * (object2.c + object2.r));
                result.r = (object1.c * object2.l + object2.c * object1.r) / (object2.c * (object2.c - object2.l));
            }
            return result;
            return result;
        }
        #endregion

        public  string fResult()
        {
            return ("C: "+result.c + " L: " + result.l + " R:" + result.r).ToString();
        }

    }
}
