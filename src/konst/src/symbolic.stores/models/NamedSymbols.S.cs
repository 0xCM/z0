//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NamedSymbols<S> : IIndex<NamedSymbol<S>>
        where S : unmanaged
    {
        readonly Index<NamedSymbol<S>> Data;

        [MethodImpl(Inline)]
        public NamedSymbols(NamedSymbol<S>[] src)
            => Data = src;

        public ReadOnlySpan<NamedSymbol<S>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<NamedSymbol<S>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref NamedSymbol<S> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref NamedSymbol<S> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public NamedSymbol<S>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator NamedSymbols<S>(NamedSymbol<S>[] src)
            => new NamedSymbols<S>(src);
    }
}