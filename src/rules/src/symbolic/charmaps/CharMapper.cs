//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = CharMaps;

    public readonly ref struct CharMapper<T>
        where T : unmanaged
    {
        readonly CharMap<T> Data;

        [MethodImpl(Inline)]
        public CharMapper(CharMap<T> spec)
        {
            Data = spec;
        }

        [MethodImpl(Inline)]
        public uint Map(ReadOnlySpan<char> src, Span<T> dst)
            => api.apply(Data, src, dst);

        [MethodImpl(Inline)]
        public ref T Map(char src, ref T dst)
        {
            dst = Data[src];
            return ref dst;
        }
    }
}