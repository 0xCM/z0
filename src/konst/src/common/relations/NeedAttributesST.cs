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

    public readonly struct NeedAttributes<S,T>
    {
        readonly TableSpan<NeedAttribute<S,T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator NeedAttributes<S,T>(NeedAttribute<S,T>[] src)
            => new NeedAttributes<S,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator NeedAttribute<S,T>[](NeedAttributes<S,T> src)
            => src.Data.Storage;

        [MethodImpl(Inline)]
        public NeedAttributes(uint count)
        {
            Data = sys.alloc<NeedAttribute<S,T>>(count);
        }

        [MethodImpl(Inline)]
        public NeedAttributes(NeedAttribute<S,T>[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<NeedAttribute<S,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<NeedAttribute<S,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref NeedAttribute<S,T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref NeedAttribute<S,T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}