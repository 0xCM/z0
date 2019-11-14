//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    public static class BitMatrix4x
    {   
        [MethodImpl(Inline)] 
        public static BitMatrix4 Replicate(this BitMatrix4 src, bool structureOnly = false)
            => structureOnly ? ushort.MinValue : (ushort)src;

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this BitMatrix4 A)
            => (ushort)A;

        [MethodImpl(Inline)]
        public static string Format(this BitMatrix4 src)            
            => src.Bytes.FormatMatrixBits(src.RowCount);

    }

}
