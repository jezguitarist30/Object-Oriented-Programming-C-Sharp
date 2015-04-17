using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPversion1
{
    public partial class SampleClassA
    {
        /// <summary>
        /// By Default fields are Private in C#
        /// </summary>
        int defaultA;

        /// <summary>
        /// Can only be accessible from same project or assembly
        /// </summary>
        internal int InternalX;

        /// <summary>
        /// Can only be accessible if derived
        /// </summary>
        protected int protectedY;

        /// <summary>
        /// Means protected or Internal
        /// </summary>
        protected internal int protectedInternalZ;

        /// <summary>
        /// No restrictions at all
        /// </summary>
        public int testPublicInt;

        /// <summary>
        /// Can only be accessible within the class
        /// </summary>
        private int testPrivateInt;

        /// <summary>
        /// Can be accessible from abstract representation of the class.
        /// Or can be accessibile without creating the class
        /// </summary>
        public static int publicStaticInt;
    }
}
