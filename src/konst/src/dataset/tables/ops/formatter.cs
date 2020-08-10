//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static TableFormatter<F> formatter<F>(LiteralFields<F> fields, StringBuilder dst = null)
            where F : unmanaged, Enum
                => new TableFormatter<F>(fields, dst);
    }
}