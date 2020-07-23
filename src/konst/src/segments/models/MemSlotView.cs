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

    /// <summary>
    /// Defines an indexed view over <see cref='SegRef'/> values
    /// </summary>
    public readonly struct MemSlotView : IIndexedView<SegRef>
    {
        readonly SegRef[] Data;

        [MethodImpl(Inline)]
        public static implicit operator MemSlotView(SegRef[] src)
            => new MemSlotView(src);

        [MethodImpl(Inline)]
        public static implicit operator SegRef[](MemSlotView src)
            => src.Data;

        [MethodImpl(Inline)]
        public MemSlotView(SegRef[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public ref readonly SegRef Lookup(int index)
            => ref Data[index];

        public ref readonly SegRef this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup((int)index);
        }
        
        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }
}