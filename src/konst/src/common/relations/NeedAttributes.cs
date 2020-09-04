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

    public readonly struct NeedAttributes
    {
        readonly TableSpan<NeedAttribute> Data;

        [MethodImpl(Inline)]
        public static implicit operator NeedAttributes(NeedAttribute[] src)
            => new NeedAttributes(src);

        [MethodImpl(Inline)]
        public static implicit operator NeedAttribute[](NeedAttributes src)
            => src.Data.Storage;

        [MethodImpl(Inline)]
        public NeedAttributes(uint count)
        {
            Data = sys.alloc<NeedAttribute>(count);
        }

        [MethodImpl(Inline)]
        public NeedAttributes(NeedAttribute[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<NeedAttribute> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<NeedAttribute> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref NeedAttribute this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref NeedAttribute this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}