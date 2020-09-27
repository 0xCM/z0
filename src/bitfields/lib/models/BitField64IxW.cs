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

    using api = BitFields;

    public struct BitField64<I,W>
        where I : unmanaged
        where W : unmanaged
    {
        internal ulong Data;

        internal readonly BitFieldSpec<I,W> Spec;

        [MethodImpl(Inline)]
        public BitField64(BitFieldSpec<I,W> spec, ulong data)
        {
            Spec = spec;
            Data = data;
        }

        [MethodImpl(Inline)]
        public BitFieldSegment segment(I index)
            => skip(Spec.Segments, uint8(index));

        public ulong this[I index]
        {
            [MethodImpl(Inline)]
            get => api.extract(segment(index), Data);

            [MethodImpl(Inline)]
            set => api.deposit(segment(index), value, ref Data);
        }
    }
}