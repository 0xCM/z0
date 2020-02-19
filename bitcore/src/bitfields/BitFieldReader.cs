//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly ref struct BitFieldReader<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        readonly BitFieldSpec<E> spec;

        readonly ReadOnlySpan<BitFieldSegment> Segments;

        [MethodImpl(Inline)]
        internal BitFieldReader(BitFieldSpec<E> spec)
        {
            this.spec = spec;
            this.Segments = spec.Segments;            
        }

        [MethodImpl(Inline)]
        public T Read(in BitFieldSegment segment, T src)
            => BitField.read(segment, src);

        [MethodImpl(Inline)]
        public void Read(T src, Span<T> dst)
            => BitField.read(spec, src, dst);

        [MethodImpl(Inline)]
        public T Read(in BitFieldSegment segment, T src, bool offset)
            => BitField.read(segment, src, offset);
    }
}
