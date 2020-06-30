//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst; 
    using static Typed;      
    using static V0;  

    partial class BitMatrix
    {
        /// <summary>
        /// Loads the lower half of a 128-bit cpu vector from matrix data
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vload(in BitMatrix8 A) 
            => vscalar(w128, (ulong)A).AsByte();

        /// <summary>
        /// Loads a 256-bit cpu vector from matrix data
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vload(in BitMatrix16 A) 
            => V0.vload(w256, A.Content);

        /// <summary>
        /// Loads a 256-bit cpu vector from matrix data beginning at a specified offset
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="offset">The offset into the source, relative to the primal type, at which to begin reading data</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vload(in BitMatrix32 A, int offset) 
            => V0.vload(w256, A.Content.Slice(offset));

        /// <summary>
        /// Loads a 256-bit cpu vector from matrix data beginning at a specified offset
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="offset">The offset into the source, relative to the primal type, at which to begin reading data</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vload(in BitMatrix64 A, int offset) 
            => V0.vload(w256, A.Content.Slice(offset));
    }
}