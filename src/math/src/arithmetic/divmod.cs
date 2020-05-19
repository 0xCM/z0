//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    partial class math
    {
        /// <summary>
        /// Computes dst = (div(a,b), mod(a,b))
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), DivMod]
        public static ConstPair<sbyte> divmod(sbyte a, sbyte b)
            => (div(a,b), mod(a,b));

        /// <summary>
        /// Computes dst = (div(a,b), mod(a,b))
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), DivMod]
        public static ConstPair<byte> divmod(byte a, byte b)
            => (div(a,b), mod(a,b));

        /// <summary>
        /// Computes dst = (div(a,b), mod(a,b))
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), DivMod]
        public static ConstPair<short> divmod(short a, short b)
            => (div(a,b), mod(a,b));

        /// <summary>
        /// Computes dst = (div(a,b), mod(a,b))
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), DivMod]
        public static ConstPair<ushort> divmod(ushort a, ushort b)
            => (div(a,b), mod(a,b));

        /// <summary>
        /// Computes dst = (div(a,b), mod(a,b))
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), DivMod]
        public static ConstPair<int> divmod(int a, int b)
            => (div(a,b), mod(a,b));

        /// <summary>
        /// Computes dst = (div(a,b), mod(a,b))
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), DivMod]
        public static ConstPair<uint> divmod(uint a, uint b)
            => (div(a,b), mod(a,b));

        /// <summary>
        /// Computes dst = (div(a,b), mod(a,b))
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), DivMod]
        public static ConstPair<long> divmod(long a, long b)
            => (div(a,b), mod(a,b));

        /// <summary>
        /// Computes dst = (div(a,b), mod(a,b))
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The divisor</param>
        [MethodImpl(Inline), DivMod]
        public static ConstPair<ulong> divmod(ulong a, ulong b)
            => (div(a,b), mod(a,b));
    }
}