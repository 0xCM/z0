//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RenderProduct<T> : IRenderProduct<T>
    {
        public IRenderPattern Pattern {get;}

        public T Product {get;}

        [MethodImpl(Inline)]
        public RenderProduct(IRenderPattern pattern, T product)
        {
            Pattern = pattern;
            Product = product;
        }

        [MethodImpl(Inline)]
        public static implicit operator T(RenderProduct<T> src)
            => src.Product;
    }
}