//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a key-parametric indexed view over <see cref='SegRef'/> values
    /// </summary>
    public readonly struct MemSlotView<E> : IIndexedView<E,SegRef>
        where E : unmanaged, Enum
    {
        readonly SegRef[] Data;

        [MethodImpl(Inline)]
        public MemSlotView(SegRef[] slots)
            => Data = slots;

        [MethodImpl(Inline)]
        public ref readonly SegRef Lookup(E index)
            => ref Data[z.uint8(index)];
        
        public ref readonly SegRef this[E index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public SegRef[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }
        public ref readonly SegRef this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
        
        ref readonly SegRef IIndexedView<SegRef>.Lookup(int index)
            => ref Data[index];

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }        
    }
}