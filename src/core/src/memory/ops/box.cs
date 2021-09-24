//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    unsafe partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AddressBox<T> box<T>(T @base, ByteSize size)
            where T : unmanaged, IAddress<T>
                => new AddressBox<T>(@base, size);
    }
}