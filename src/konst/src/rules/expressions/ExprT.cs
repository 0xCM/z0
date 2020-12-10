//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct Expr<T> : IExpr<Expr<T>,T>
        where T : unmanaged
    {
        /// <summary>
        /// The identified expression
        /// </summary>
        public IExpr<T> Encoding {get;}
        public string Format()
            => string.Empty;
    }
}