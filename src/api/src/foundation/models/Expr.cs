//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct Expr<T> : IExpr<Expr<T>,T>
        where T : unmanaged
    {
        public string Format()
            => string.Empty;
    }
}