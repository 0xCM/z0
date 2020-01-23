//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static LogixOpNames;

    internal static class OpHelpers
    {
        [MethodImpl(Inline), Op(ubl), PrimalClosures(PrimalKind.Integers)]
        public static string sig(UnaryBitLogicKind kind)
                => $"{kind}:bit";

        [MethodImpl(Inline), Op(bbl), PrimalClosures(PrimalKind.Integers)]
        public static string sig(BinaryBitLogicKind kind)
                => $"{kind}:bit";

        [MethodImpl(Inline), Op(tbl), PrimalClosures(PrimalKind.Integers)]
        public static string sig(TernaryBitLogicKind kind)
                => $"{kind}:bit";

        [MethodImpl(Inline), Op(ubl), PrimalClosures(PrimalKind.Integers)]
        public static string sig<T>(UnaryBitLogicKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).Kind().Keyword()}";

        [MethodImpl(Inline), Op(bbl), PrimalClosures(PrimalKind.Integers)]
        public static string sig<T>(BinaryBitLogicKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).Kind().Keyword()}";    

        [MethodImpl(Inline), Op(tbl), PrimalClosures(PrimalKind.Integers)]
        public static string sig<T>(TernaryBitLogicKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).Kind().Keyword()}";

        [MethodImpl(Inline), Op(shift), PrimalClosures(PrimalKind.Integers)]
        public static string sig<T>(ShiftOpKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).Kind().Keyword()}";

        [MethodImpl(Inline), Op(cmp), PrimalClosures(PrimalKind.Integers)]
        public static string sig<T>(ComparisonKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).Kind().Keyword()}";


        [MethodImpl(Inline), Op(ua), PrimalClosures(PrimalKind.Integers)]
        public static string sig<T>(UnaryArithmeticKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).Kind().Keyword()}";

        [MethodImpl(Inline), Op(ba), PrimalClosures(PrimalKind.Integers)]
        public static string sig<T>(BinaryArithmeticKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).Kind().Keyword()}";


        public static void Set<T>(IVariedExpr<T> expr, params IExpr<T>[] values)
            where T : unmanaged
        {
            var n = Math.Min(expr.Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                expr.Vars[i].Set(values[i]);
        }

    }

}
