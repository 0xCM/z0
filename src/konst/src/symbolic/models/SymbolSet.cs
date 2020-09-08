//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SymbolSet<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        readonly TableSpan<Symbol<S,T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator Symbols<S>(SymbolSet<S,T> src)
            => new Symbols<S>(src.Data.Map(x => x.Simplified));

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<S>(SymbolSet<S,T> src)
            => src.Data.View.Map(x => x.Value);

        [MethodImpl(Inline)]
        public static implicit operator SymbolSet<S,T>(Symbol<S,T>[] src)
            => new SymbolSet<S,T>(src);

        [MethodImpl(Inline)]
        public SymbolSet(Symbol<S,T>[] src)
            => Data = src;

        public ReadOnlySpan<Symbol<S,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Symbol<S,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref readonly Symbol<S,T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref readonly Symbol<S,T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}