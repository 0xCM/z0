//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    public ref struct BitField64<I,W>
        where I : unmanaged, Enum
        where W : unmanaged, Enum
    {
        ulong data;

        readonly BitFieldSpec<I,W> spec;

        readonly ReadOnlySpan<FieldSegment> segments;
        
        [MethodImpl(Inline)]
        BitField64(in BitFieldSpec<I,W> spec, ulong data)
        {
            this.spec = spec;
            this.segments = spec.Segments;
            this.data = data;
        }

        [MethodImpl(Inline)]
        FieldSegment segment(I index)
            => skip(segments, Enums.numeric<I,byte>(index));

        BitFieldOps<ulong> Ops
        {
            [MethodImpl(Inline)]
            get => default(BitFieldOps<ulong>);
        }

        public ulong this[I index]
        {
            [MethodImpl(Inline)]
            get => Ops.Extract(segment(index), data);
            
            [MethodImpl(Inline)]
            set => Ops.Deposit(segment(index), value, ref data);
        }

        /// <summary>
        /// Extracts all segments from the source value and deposits the result in a caller-suppled span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public void Read(Span<ulong> dst)
            => Ops.Deposit(spec, data, dst);
    }
}