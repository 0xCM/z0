//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct JmpStubSynthetic<T>
        where T : unmanaged
    {
        public MemoryRange Location {get; private set;}

        [MethodImpl(NotInline)]
        ulong Jump(T a0)
            => root.timestamp();

        public MemoryRange Init()
        {
            Jump(default);
            var @base = ApiJit.jit(GetType().Method(nameof(Jump)));
            var size = 16ul;
            var liberated = memory.liberate(@base,size);
            if(liberated.IsNonZero)
                Location = (@base, @base + size);
            return Location;
        }
    }
}