//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymSource<K>
        where K : unmanaged
    {
        readonly Symbols<K> Data;

        [MethodImpl(Inline)]
        public SymSource(Symbols<K> src)
        {
            Data = src;
        }

        public uint SymbolCount
        {
            [MethodImpl(Inline), Op]
            get => Data.Count;
        }

        [MethodImpl(Inline), Op]
        public ref readonly Sym<K> Symbol(K key)
            => ref Data[key];

        public ref readonly Sym<K> this[K key]
        {
            [MethodImpl(Inline)]
            get => ref Symbol(key);
        }

        public ReadOnlySpan<Sym<K>> Symbols
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [MethodImpl(Inline)]
        public static implicit operator SymSource<K>(Symbols<K> src)
            => new SymSource<K>(src);
    }
}