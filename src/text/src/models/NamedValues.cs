//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct NamedValues
    {
        public static NamedValues<T> empty<T>()
            => new NamedValues<T>(NamedValue.empty<T>());
    }

    public readonly struct NamedValues<T>
    {
        public NamedValue<T>[] Data {get;}

        [MethodImpl(Inline)]
        public NamedValues(params NamedValue<T>[] src)
            => Data = src;

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data?.Length ?? 0;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data?.Length ?? 0;
        }

        public NamedValue<T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }
        public ReadOnlySpan<NamedValue<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<NamedValue<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref NamedValue<T> this[string name]
        {
            [MethodImpl(Inline)]
            get => ref Data[Index(name)];
        }

        public ref NamedValue<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Count == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Count != 0;
        }

        [MethodImpl(Inline)]
        uint Index(string name)
        {
            var view = View;
            for(var i=0u; i<Count; i++)
            {
                ref readonly var x = ref skip(view,i);
                if(x.Name == name)
                    return i;
            }
            return 0;
        }

        [MethodImpl(Inline)]
        public static implicit operator NamedValues<T>(NamedValue<T>[] src)
            => new NamedValues<T>(src);
    }
}