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

    partial struct Resources
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ReadOnlySpan<T> extract<T>(in ResMember member, int i0, int i1)
            where T : unmanaged
                => segment(member.Address.Pointer<T>(), i0, i1);
    }
}