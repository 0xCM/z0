//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct rules
    {
        [MethodImpl(Inline), Op]
        public Product<IExpr> product(params IExpr[] src)        
            => new Product<IExpr>(src);
    }
}