//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {                
        [MethodImpl(Inline), Op]
        public static unsafe double @double(bool on)
            => *((byte*)(&on));

        [MethodImpl(Inline), Op, Closures(Numeric64k)]
        public static unsafe double @double<T>(T src)
            where T : unmanaged             
                => *((double*)(&src));            
    }
}