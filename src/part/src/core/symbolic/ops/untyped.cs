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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymLiteral untyped<E>(in SymLiteral<E> src)
            where E : unmanaged
        {
            var dst = new SymLiteral();
            dst.Component = src.Component.SimpleName;
            dst.Type = src.Type;
            dst.Position = src.Position;
            dst.Name = src.Name;
            dst.DataType = src.DataType;
            dst.ScalarValue = src.ScalarValue;
            dst.Symbol = src.Symbol;
            dst.Description = src.Description;
            dst.Identity = src.Identity;
            dst.Hidden = src.Hidden;
            return dst;
        }
    }
}