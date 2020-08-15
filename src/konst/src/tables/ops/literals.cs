//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static LiteralFields<F> literals<F>()
            where F : unmanaged, Enum
                => new LiteralFields<F>(typeof(F).LiteralFields());        
    }
}