//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public delegate ref BitMatrix<T> BitMatrixUnaryRefOp<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
        where T : unmanaged;

    public delegate ref BitMatrix<T> BitMatrixBinaryRefOp<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
        where T : unmanaged;

}
