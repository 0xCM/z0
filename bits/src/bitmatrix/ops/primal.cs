//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitMatrix
    {        
        /// <summary>
        /// Defines a primal bitmatrix of order 4
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix4 primal(N4 n, ushort src)
            => BitMatrix4.From(src);

        /// <summary>
        /// Defines a primal bitmatrix of order 4
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix4 primal(N4 n, BitVector4[] src)
            => BitMatrix4.From(src);

        /// <summary>
        /// Defines a primal bitmatrix of order 8
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 primal(N8 n, Span<byte> src)
            => BitMatrix8.From(src);

        /// <summary>
        /// Defines a primal bitmatrix of order 8
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 primal(N8 n, ReadOnlySpan<byte> src)
            => BitMatrix8.From(src.Replicate());

        /// <summary>
        /// Defines a primal bitmatrix of order 16
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 primal(N16 n, Span<ushort> src)
            => BitMatrix16.From(src);

        /// <summary>
        /// Defines a primal bitmatrix of order 16
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 primal(N16 n, ReadOnlySpan<byte> src)
            => BitMatrix16.From(src.Replicate());

        /// <summary>
        /// Defines a primal bitmatrix of order 32
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 primal(N32 n, Span<uint> src)
            => BitMatrix32.From(src);

        /// <summary>
        /// Defines a primal bitmatrix of order 32
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 primal(N32 n, ReadOnlySpan<byte> src)
            => BitMatrix32.From(src.Replicate());

        /// <summary>
        /// Defines a primal bitmatrix of order 64
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 primal(N64 n, Span<ulong> src)
            => BitMatrix64.From(src);

        /// <summary>
        /// Defines a primal bitmatrix of order 64
        /// </summary>
        /// <param name="n">The order selector</param>
        /// <param name="src">The data used to populate the matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 primal(N64 n, ReadOnlySpan<byte> src)
            => BitMatrix64.From(src.Replicate());
 
        [MethodImpl(Inline)]
        public static BitMatrix8 primal(N8 n8, byte row0 = 0, byte row1 = 0, byte row2 = 0, byte row3 = 0, 
            byte row4 = 0, byte row5 = 0, byte row6 = 0, byte row7 = 0)
                => BitMatrix8.From(row0, row1, row2, row3, row4, row5, row6, row7);
 
    }
}