//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static ResIdentity identify(Name name, MemorySegment seg, ClrPrimalKind type)
            => new ResIdentity(name, seg, type);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ResIdentity<T> identify<T>(Name name, MemoryAddress location, ByteSize length)
            => new ResIdentity<T>(name, segment(location, length));
    }
}