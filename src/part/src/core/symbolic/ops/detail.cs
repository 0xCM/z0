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
        [Op, Closures(Closure)]
        public static ref SymbolDetial detail<T>(in Sym<T> src, ushort count, out SymbolDetial dst)
            where T : unmanaged
        {
            dst.TypeName = src.Type.Name;
            dst.SymCount = count;
            dst.Index = src.Index;
            dst.Name = src.Name;
            dst.Expr = src.Expr;
            dst.NameData = text.utf16(src.Name).ToArray();
            dst.NameSize = (ushort)dst.NameData.Count;
            dst.ExprData = text.utf16(src.Expr.Format()).ToArray();
            dst.ExprSize = (ushort)dst.ExprData.Count;
            return ref dst;
        }
    }
}