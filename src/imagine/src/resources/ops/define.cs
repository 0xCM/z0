//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Root;
    using static Konst;

    partial struct Resources
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ResMember define<T>(MemberInfo member, ReadOnlySpan<T> src)
            where T : unmanaged
                => new ResMember(member, core.memref(recover<T,byte>(src)));
    }
}