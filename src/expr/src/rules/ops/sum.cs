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
        public Sum<IExpr> sum(params IExpr[] src)        
            => new Sum<IExpr>(src);
    }
}