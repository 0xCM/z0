//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public delegate ref BitMatrix<T> BitMatrixUnaryRefOp<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
        where T : unmanaged;

    public delegate ref readonly BitMatrix<T> BitMatrixUnaryOp<T>(in BitMatrix<T> a, in BitMatrix<T> dst)
        where T : unmanaged;

    public delegate ref readonly BitMatrix<T> BitMatrixBinaryOp<T>(in BitMatrix<T> a, in BitMatrix<T> b, in BitMatrix<T> dst)
        where T : unmanaged;

    public delegate ref readonly BitMatrix<T> BitMatrixTernaryOp<T>(in BitMatrix<T> a, in BitMatrix<T> b, in BitMatrix<T> c, in BitMatrix<T> dst)
        where T : unmanaged;

}
