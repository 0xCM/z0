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

    partial struct Symbols
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sym untyped<T>(Sym<T> src)
            where T : unmanaged
                => new Sym(src.Identity, src.Index, src.Type, bw64(src.Kind), src.Name, src.Expr, src.Description, src.Hidden);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymLiteral untype<E>(in SymLiteral<E> src)
            where E : unmanaged
        {
            var dst = new SymLiteral();
            dst.Component = src.Component.SimpleName;
            dst.Type = src.Type;
            dst.Position = src.Position;
            dst.Name = src.Name;
            dst.Symbol = src.Symbol;
            dst.DataType = src.DataType;
            dst.ScalarValue = src.ScalarValue;
            dst.Description = src.Description;
            dst.Hidden = src.Hidden;
            dst.Identity = src.Identity;
            return dst;
        }
    }
}