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

    public readonly struct TableStore
    {
        [MethodImpl(Inline)]
        public static FieldIndex<F> fields<F>()
            where F : unmanaged, Enum
                => new FieldIndex<F>(0);
    }
}