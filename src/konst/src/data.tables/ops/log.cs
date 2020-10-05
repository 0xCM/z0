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
        public static TableLog<F,T> log<F,T>(ITableFormatter<F,T> formatter, FilePath dst)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
                => new TableLog<F,T>(formatter, dst);
    }
}