//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;

    internal static class OpHelpers
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig(UnaryBitLogicOpKind kind)
                => $"{kind}:bit";

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig(BinaryBitLogicOpKind kind)
                => $"{kind}:bit";

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig(TernaryBitLogicOpKind kind)
                => $"{kind}:bit";

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig<T>(UnaryBitLogicOpKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig<T>(BinaryBitLogicOpKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";    

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig<T>(TernaryBitLogicOpKind kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig<T>(ShiftOpKindId kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig<T>(ComparisonOpKindId kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig<T>(UnaryArithmeticKindId kind)
            where T : unmanaged
                => $"{kind}:{typeof(T).NumericKind().Keyword()}";

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static string sig<T>(BinaryArithmeticKindId kind)
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
