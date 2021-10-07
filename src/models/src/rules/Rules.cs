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

    public readonly partial struct Rules
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ByteSize encode<T>(in CmpPred<T> src, Span<byte> dst)
            where T : unmanaged
        {
            seek(dst,0) = (byte)src.Kind;
            var target = recover<T>(slice(dst,1));
            seek(target,0) = src.A;
            seek(target,1) = src.B;
            return size<T>()*2 + 1;
        }

        [Op]
        public static string symbol(CmpKind kind)
            => kind switch {
                CmpKind.EQ => CmpSymbolExpr.EQ,
                CmpKind.NEQ => CmpSymbolExpr.NEQ,
                CmpKind.GT => CmpSymbolExpr.GT,
                CmpKind.GE => CmpSymbolExpr.GE,
                CmpKind.LT => CmpSymbolExpr.LT,
                CmpKind.LE => CmpSymbolExpr.LE,
                _ => "?",
            };
    }
}