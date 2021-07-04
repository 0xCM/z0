//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Symbols
    {
        [MethodImpl(Inline), Op]
        public static Sym symbol(SymIdentity id, SymKey index, Identifier type, ulong value, Identifier name, SymExpr expr, TextBlock? description = null, bool hidden = false)
            => new Sym(id, index, type, value, name, expr, description, hidden);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sym<T> symbol<T>(SymIdentity id, SymKey<T> index, Identifier name, T value, SymExpr expr, TextBlock description, bool hidden = false)
            where T : unmanaged
                => new Sym<T>(id, index, name, value, expr, description, hidden);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sym8<T> symbol<T>(W8 w, SymIdentity id, SymKey<byte> index, Identifier name, T value, SymExpr expr, TextBlock description, bool hidden = false)
            where T : unmanaged
                => new Sym8<T>(id, index, name, value, expr, description, hidden);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sym16<T> symbol<T>(W16 w, SymIdentity id, SymKey<ushort> index, Identifier name, T value, SymExpr expr, TextBlock description, bool hidden = false)
            where T : unmanaged
                => new Sym16<T>(id, index, name, value, expr, description, hidden);

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k)]
        public static Sym16<T> symbol<T>(W16 w, Sym<T> entry)
            where T : unmanaged
                => symbol(w, entry.Identity, (ushort)entry.Key, entry.Name, entry.Kind, entry.Expr, entry.Description, entry.Hidden);

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static Sym8<T> symbol<T>(W8 w, Sym<T> entry)
            where T : unmanaged
                => symbol(w, entry.Identity, (byte)entry.Key, entry.Name, entry.Kind, entry.Expr, entry.Description, entry.Hidden);
    }
}