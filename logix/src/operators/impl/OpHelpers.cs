//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Seed;    
    using static Memories;

    internal static class OpHelpers
    {
        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig(UnaryLogicKind kind)
                => $"{kind}:bit";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig(BinaryLogicKind kind)
                => $"{kind}:bit";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig(TernaryLogicKind kind)
                => $"{kind}:bit";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(UnaryLogicKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BinaryLogicKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";    

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(TernaryLogicKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BitShiftKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BinaryComparisonKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(UnaryArithmeticKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(Integers)]
        public static string sig<T>(BinaryArithmeticKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        public static void Set<T>(IVariedExpr<T> expr, params IExpr<T>[] values)
            where T : unmanaged
        {
            var n = Math.Min(expr.Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                expr.Vars[i].Set(values[i]);
        }
    }
}
