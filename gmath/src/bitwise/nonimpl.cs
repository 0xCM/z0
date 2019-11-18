//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
    
    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
 
    using static zfunc;
    
    public static partial class math
    {                
        /// <summary>
        /// Computes the material nomimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static byte nonimpl(byte a, byte b)
            => (byte)AndNot((uint)a,(uint)b);

        /// <summary>
        /// Computes the material nomimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort nonimpl(ushort a, ushort b)
            => (ushort)AndNot((uint)a,(uint)b);

        /// <summary>
        /// Computes the material nomimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong nonimpl(ulong a, ulong b)
            => AndNot(a,b);

        /// <summary>
        /// Computes the material nomimplication z := ~a & b for operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static uint nonimpl(uint a, uint b)
            => AndNot(a,b);
    }
}