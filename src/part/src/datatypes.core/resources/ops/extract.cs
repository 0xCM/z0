//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Resources
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ReadOnlySpan<T> extract<T>(in ResMember member, uint i0, uint i1)
            where T : unmanaged
                => memory.section(member.Address.Pointer<T>(), i0, i1);
    }
}