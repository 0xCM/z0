//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {
        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte abs(sbyte a)
            => (sbyte)(a + (a >> 7)^(a >> 7));         

        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static short abs(short a)
            => (short)(a + (a >> 15)^(a >> 15));         

        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static int abs(int a)
            => (a + (a >> 31)^(a >> 31));         

        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static long abs(long a)
            => (a + (a >> 63)^(a >> 63));         

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static float abs(float a)
            => MathF.Abs(a);

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static double abs(double a)
            => Math.Abs(a);
 
        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static ref sbyte abs(ref sbyte a)
        {
            a = abs(a);
            return ref a;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static ref short abs(ref short a)
        {
            a = abs(a);
            return ref a;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static ref int abs(ref int a)
        {
            a = abs(a);
            return ref a;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="a">The source value</param>
        [MethodImpl(Inline)]
        public static ref long abs(ref long a)
        {
            a = abs(a);
            return ref a;
        }
    }
}