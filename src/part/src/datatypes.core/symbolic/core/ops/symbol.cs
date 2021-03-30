//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Symbols
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sym8<T> symbol<T>(W8 w, SymKey<byte> key, Identifier name, T value, SymExpr expr)
            where T : unmanaged
                => new Sym8<T>(key, name,value,expr);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sym16<T> symbol<T>(W16 w, SymKey<ushort> key, Identifier name, T value, SymExpr expr)
            where T : unmanaged
                => new Sym16<T>(key, name,value,expr);

        [MethodImpl(Inline)]
        public static Sym8<E> symbol<E>(W8 w, uint index)
            where E : unmanaged, Enum
        {
            ref readonly var entry = ref SymCache<E>.get().Entries[index];
            return symbol(w, (byte)entry.Key, entry.Name, entry.Value, entry.Expression);
        }

        [MethodImpl(Inline)]
        public static Sym16<E> symbol<E>(W16 w, uint index)
            where E : unmanaged, Enum
        {
            ref readonly var entry = ref SymCache<E>.get().Entries[index];
            return symbol(w, (byte)entry.Key, entry.Name, entry.Value, entry.Expression);
        }
    }
}