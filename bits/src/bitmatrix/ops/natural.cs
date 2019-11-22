//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitMatrix
    {        
        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N8,byte> natural(in BitMatrix8 A)
            => BitMatrix<N8,byte>.Load(A.data);

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N16,byte> natural(in BitMatrix16 A)
            => BitMatrix<N16,byte>.Load(A.Bytes);

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N32,byte> natural(in BitMatrix32 A)
            => BitMatrix<N32,byte>.Load(A.Bytes);

        /// <summary>
        /// Projects, without allocation, a primal bitmatrix onto a generic bitmatrix of natural order
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]    
        public static BitMatrix<N64,byte> natural(in BitMatrix64 A)
            => BitMatrix<N64,byte>.Load(A.Bytes);
    }
}