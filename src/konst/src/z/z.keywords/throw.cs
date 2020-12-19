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
        [Op]
        public static void @throw(Exception e)
            => throw e;

        [Op]
        public static T @throw<T>(Exception e)
            => throw e;

        [MethodImpl(Inline), Op]
        public static void @throw(string msg)
            => sys.@throw(msg);

        [MethodImpl(Inline), Op]
        public static T @throw<T>(object msg)
            => sys.@throw<T>(msg);
    }
}