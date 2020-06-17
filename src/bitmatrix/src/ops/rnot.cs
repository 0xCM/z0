//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 

    partial class BitMatrix
    {        
                
        [MethodImpl(Inline), RNot, NumericClosures(UnsignedInts)]
        public static ref readonly BitMatrix<T> rnot<T>(in BitMatrix<T> A, in BitMatrix<T> b, in BitMatrix<T> dst)
            where T : unmanaged
                => ref not(b, dst);
    }
}