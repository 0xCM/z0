//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HexIndex<K>
        where K : unmanaged, IHexNumber
    {
        public readonly K[] Data;

        [MethodImpl(Inline)]
        public HexIndex(K[] data)
            => Data = data;

        public ref K this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public Ref<K> Ref
        {
            [MethodImpl(Inline)]
            get => MemRefs.from(in Data[0], Data.Length);
        }

        public Span<K> Span
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get =>  Data.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get =>  Data == null || Data.Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data != null && Data.Length != 0;
        }
    }
}