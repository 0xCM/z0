//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class RootLegacy
    {
        [MethodImpl(Inline), Op]
        public static void @throw(string msg)
            => sys.@throw(msg);

        [MethodImpl(Inline), Op]
        public static void @throw(Exception e)
            => sys.@throw(e);

    }
}