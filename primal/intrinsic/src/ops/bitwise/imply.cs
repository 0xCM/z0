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
    using System.Runtime.Intrinsics;    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
 
    using static zfunc;
    
    public static partial class dinx
    {                

        /// <summary>
        /// Computes the material implication, equivalent to the bitwise expression x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vimply(Vector128<byte> x, Vector128<byte> y)
            => Or(x,vnot(y));

        /// <summary>
        /// Computes the material implication, equivalent to the bitwise expression x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vimply(Vector128<ushort> x, Vector128<ushort> y)
            => Or(x,vnot(y));

        /// <summary>
        /// Computes the material implication, equivalent to the bitwise expression x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vimply(Vector128<uint> x, Vector128<uint> y)
            => Or(x,vnot(y));

        /// <summary>
        /// Computes the material implication, equivalent to the bitwise expression x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vimply(Vector128<ulong> x, Vector128<ulong> y)
            => Or(x,vnot(y));
 
        /// <summary>
        /// Computes the material implication, equivalent to the bitwise expression x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vimply(Vector256<byte> x, Vector256<byte> y)
            => Or(x,vnot(y));

        /// <summary>
        /// Computes the material implication, equivalent to the bitwise expression x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vimply(Vector256<ushort> x, Vector256<ushort> y)
            => Or(x,vnot(y));

        /// <summary>
        /// Computes the material implication, equivalent to the bitwise expression x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vimply(Vector256<uint> x, Vector256<uint> y)
            => Or(x,vnot(y));

        /// <summary>
        /// Computes the material implication, equivalent to the bitwise expression x | ~y for vectors x and y
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vimply(Vector256<ulong> x, Vector256<ulong> y)
            => Or(x,vnot(y));
    }
}