//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Memories;

    partial class math
    {    
        /// <summary>
        /// Defines the operator eqz(a,b) := a == b ? Min : Zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eqz]
        public static sbyte eqz(sbyte a, sbyte b)
            => a == b ? Min8i : Zero8i;

        /// <summary>
        /// Defines the operator eqz(a,b) := a == b ? Min : Zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eqz]
        public static byte eqz(byte a, byte b)
            => a == b ? Max8u : Zero8u;

        /// <summary>
        /// Defines the operator eqz(a,b) := a == b ? Min : Zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eqz]
        public static short eqz(short a, short b)
            => a == b ? Min16i : Zero16i;

        /// <summary>
        /// Defines the operator eqz(a,b) := a == b ? Min : Zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eqz]
        public static ushort eqz(ushort a, ushort b)
            => a == b ? Max16u : Zero16u;

        /// <summary>
        /// Defines the operator eqz(a,b) := a == b ? Min : Zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eqz]
        public static int eqz(int a, int b)
            => a == b ? Min32i : Zero32i;

        /// <summary>
        /// Defines the operator eqz(a,b) := a == b ? Min : Zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eqz]
        public static uint eqz(uint a, uint b)
            => a == b ? Max32u : Zero32u;

        /// <summary>
        /// Defines the operator eqz(a,b) := a == b ? Min : Zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eqz]
        public static long eqz(long a, long b)
            => a == b ? Min64i : Zero64i;

        /// <summary>
        /// Defines the operator eqz(a,b) := a == b ? Min : Zero
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Eqz]
        public static ulong eqz(ulong a, ulong b)
            => a == b ? Max64u : Zero64u;


        /*
            eqz_ᐤ64iㆍ64iᐤ: 0f 1f 44 00 00 48 3b ca 74 03 33 c0 c3 48 b8 00 00 00 00 00 00 00 80 c3 19 00 00 00 40 00 00 00 00 00 00 00 00 00 00

            eqz_ᐤ64uㆍ64uᐤ: 0f 1f 44 00 00 48 3b ca 74 03 33 c0 c3 48 b8 ff ff ff ff ff ff ff ff c3
        */            
    }
}