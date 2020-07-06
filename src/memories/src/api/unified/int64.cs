//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Memories
    {

        [MethodImpl(Inline), Op, Closures(AllNumeric)]   
        public static long? int64<T>(T? src)
            where T : unmanaged
                => As.int64(src);
    }
}