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
        /// Computes a & (~b)
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong andnot(ulong a, ulong b)
            => AndNot(b,a);

        /// <summary>
        /// Computes a & (~b)
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static uint andnot(uint a, uint b)
            => AndNot(b,a);

        /// <summary>
        /// Computes a & (~b)
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static byte andnot(byte a, byte b)
            => (byte)AndNot((uint)b,(uint)a);

        /// <summary>
        /// Computes a & (~b)
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort andnot(ushort a, ushort b)
            => (ushort)AndNot((uint)b,(uint)a);

    }

}