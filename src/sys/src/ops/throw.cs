//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct sys
    {        
        [MethodImpl(Options), Op]
        public static void @throw(string msg)
            => xsys.@throw(msg);

        [MethodImpl(Options), Op]
        public static void @throw(Exception e)
            => xsys.@throw(e);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static T @throw<T>(Exception e)
            => xsys.@throw<T>(e);
    }
}