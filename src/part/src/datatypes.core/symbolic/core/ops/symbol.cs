//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Symbols
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sym8<T> symbol<T>(W8 w, SymIdentity id, SymKey<byte> index, Identifier name, T value, SymExpr expr)
            where T : unmanaged
                => new Sym8<T>(id, index, name,value,expr);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sym16<T> symbol<T>(W16 w, SymIdentity id, SymKey<ushort> index, Identifier name, T value, SymExpr expr)
            where T : unmanaged
                => new Sym16<T>(id, index, name,value,expr);

        [MethodImpl(Inline)]
        public static Sym8<E> symbol<E>(W8 w, uint index)
            where E : unmanaged, Enum
        {
            ref readonly var entry = ref SymCache<E>.get().Entries[index];
            return symbol(w, entry.Identity, (byte)entry.Index, entry.Name, entry.Value, entry.Expression);
        }

        [MethodImpl(Inline)]
        public static Sym16<E> symbol<E>(W16 w, uint index)
            where E : unmanaged, Enum
        {
            ref readonly var entry = ref SymCache<E>.get().Entries[index];
            return symbol(w, entry.Identity, (byte)entry.Index, entry.Name, entry.Value, entry.Expression);
        }
    }
}