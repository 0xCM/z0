//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct Relations
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

        [MethodImpl(Inline)]
        public static CmpEval<T> eval<T>(CmpPred<T> pred, bit eval)
            => new CmpEval<T>(pred, eval);

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

        [Op, Closures(Closure)]
        public static string format<T>(in CmpPred<T> src)
            => string.Format("{0}{1}{2}", src.A, symbol(src.Kind), src.B);

        [Op, Closures(Closure)]
        public static string format<T>(in CmpEval<T> src)
            => string.Format("{0}:{1}", format(src.Source), src.Result ? "true" : "false");
    }
}