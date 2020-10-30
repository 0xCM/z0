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

    partial struct Cmd
    {
        [MethodImpl(Inline)]
        public static string name<K,T>(in CmdOption<K,T> src)
            where K : unmanaged
                => src.Kind.ToString();
    }
}