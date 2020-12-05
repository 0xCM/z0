//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static ResIdentity identify(string name, in MemorySegment seg, PrimalKind type)
            => new ResIdentity(name,seg,type);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ResIdentity<T> identify<T>(in asci32 name, ulong location, int length)
            => new ResIdentity<T>(name, memref(location, length));
    }
}