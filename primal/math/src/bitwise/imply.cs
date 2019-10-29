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
    
    partial class math
    {                
        /// <summary>
        /// Computes a | ~b, the material implication
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static byte imply(byte a, byte b)
            => (byte)(a | ~b);

        /// <summary>
        /// Computes a | ~b, the material implication
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort imply(ushort a, ushort b)
            => (ushort)(a | ~b);

        /// <summary>
        /// Computes a | ~b, the material implication
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static uint imply(uint a, uint b)
            => a | ~b;

        /// <summary>
        /// Computes a | ~b, the material implication
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong imply(ulong a, ulong b)
            => a | ~b;
    }

}