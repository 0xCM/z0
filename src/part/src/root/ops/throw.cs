//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct root
    {
        [Op]
        public static void @throw(Exception e)
            => sys.@throw(e);

        [Op]
        public static T @throw<T>(Exception e)
            => throw e;

        [Op]
        public static T @throw<T>([Caller] string caller = null, [Line] int? line = null, [File] string? path = null)
            => throw new Exception();

        [MethodImpl(Inline), Op]
        public static void @throw(string msg)
            => sys.@throw(msg);

        [MethodImpl(Inline), Op]
        public static void @throw(Func<string> f)
            => sys.@throw(f);

        [MethodImpl(Inline), Op]
        public static T @throw<T>(object msg)
            => sys.@throw<T>(msg);
    }
}