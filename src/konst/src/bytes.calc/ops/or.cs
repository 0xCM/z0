//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    partial struct Bytes
    {
        /// <summary>
        /// Joins three operands via <see cref='BitLogicKinds.Or'/>
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b, byte c)
            => (byte)(a | b | c);

        /// <summary>
        /// Joins four operands via the <see cref='BitLogicKinds.Or'/> operator
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        /// <param name="d">The fourth operand</param>
        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b, byte c, byte d)
            => (byte)(a | b | c | d);

        [MethodImpl(Inline), Or]
        public static byte or(byte a, byte b, byte c, byte d, byte e)

            => (byte)(a | b | c | d | e);

        [MethodImpl(Inline), Or]
        public static void or(in byte A, in byte B, ref byte Z)
            => store8(or(read8(A), read8(B)), ref Z);

    }
}