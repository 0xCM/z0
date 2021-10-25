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
        public static Xor xor(IExpr a, IExpr b)
            => new Xor(a,b);    
    }
}