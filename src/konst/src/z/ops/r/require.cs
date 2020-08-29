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
        public static void require(bool invariant, string msg, string caller, string file, int? line)
        {
            if(!invariant)
                sys.@throw($"{msg}: Line {line} in {file}");
        }

        [MethodImpl(Inline), Op]
        public static void require(bool invariant, string msg, in AppMsgSource source)
        {
            if(!invariant)
                sys.@throw($"{msg}: {source.Format()}");
        }
    }
}