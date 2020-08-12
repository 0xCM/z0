//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static TableContent<F,T> content<F,T>(T[] src, F f = default)
            where F : unmanaged, Enum
            where T : struct, ITable<F,T>
                => new TableContent<F,T>(src);

        [MethodImpl(Inline)]
        public static TableContent<F,T,D> content<F,T,D>(T[] src, F f = default, D d = default)
            where F : unmanaged, Enum
            where D :  unmanaged, Enum
            where T : struct, ITable<F,T,D>
                => new TableContent<F,T,D>(src);
    }
}