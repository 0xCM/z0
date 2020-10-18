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

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static A encode<A>(string src)
            where A : unmanaged, IBytes
        {

            return default;
        }
    }
}