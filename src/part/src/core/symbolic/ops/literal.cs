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
        /// <summary>
        /// Populates a <see cref='SymLiteral<E>'/> from a specified source <see cref='Sym<E>'/>
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="E">The defining type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref SymLiteral<E> literal<E>(in Sym<E> src, out SymLiteral<E> dst)
            where E : unmanaged
        {
            var type = typeof(E);
            dst.Component = typeof(E).Assembly;
            dst.DataType = ClrPrimitives.kind(type);
            dst.Description = src.Description;
            dst.DirectValue = src.Kind;
            dst.ScalarValue = src.Value;
            dst.Identity = src.Identity;
            dst.Name = src.Name;
            dst.Position = (ushort)src.Index.Value;
            dst.Symbol = src.Expr.Format();
            dst.Type = src.Name;
            return ref dst;
        }
    }
}