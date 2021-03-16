//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct BitFields
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitSegment<T> segment<T>(BitFieldPart part, T state = default)
            where T : unmanaged
                => new BitSegment<T>(part, state);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitSegment<T> segment<T>(Identifier name, byte i0, byte i1, T state = default)
            where T : unmanaged
                => new BitSegment<T>(BitFieldSpecs.part(name, i0, i1), state);
    }
}