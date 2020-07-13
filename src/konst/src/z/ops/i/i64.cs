//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                
        [MethodImpl(Inline), Op]
        public static unsafe long i64(bool on)
            => *((sbyte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe int i32(bool on)
            => *((sbyte*)(&on));
    }
}