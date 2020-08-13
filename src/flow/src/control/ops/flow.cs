//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Data;

    using static Konst;

    partial struct Flow    
    {
        [MethodImpl(Inline)]
        public static DataFlow<S,T> flow<S,T>(S src, T dst)
            => Table.flow(src,dst);
    }
}