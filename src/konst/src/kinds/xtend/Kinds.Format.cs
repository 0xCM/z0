//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    partial class XTend
    {
        [MethodImpl(Inline)]
        public static string Format<K>(this K kind)
            where K : IOpKind
                => kind.Format();

        /// <summary>
        /// Determines whether the kind has a nonzero value
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this CellWidth src)
            => src != 0;

        [MethodImpl(Inline)]
        public static string Format(this ComparisonApiKey kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this ComparisonApiKey kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        public static string Format(this ApiKeyId id)
            => id.ToString().ToLower();

        public static string Format(this ApiKeyId id, bool vectorized)
            => vectorized ? $"v{id.Format()}" : id.Format();

        public static string Format(this ApiKeyId? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

        [MethodImpl(Inline)]
        public static string Format(this ArithmeticApiKey kind)
            => kind switch {
                ArithmeticApiKey.Inc => "++",
                ArithmeticApiKey.Dec => "--",
                ArithmeticApiKey.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string Format<T>(this ArithmeticApiKey kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        public static string Format(this BitShiftApiKey kind)
            => kind switch {
                BitShiftApiKey.Sll => "<<",
                BitShiftApiKey.Srl => ">>",
                BitShiftApiKey.Rotl => "<<>",
                BitShiftApiKey.Rotr => ">><",
                _ => kind.ToString()
            };

        public static string Format<S,T>(this BitShiftApiKey kind, S arg1, T arg2)
            => $"{arg1} {kind.Format()} {arg2}";


        [MethodImpl(Inline)]
        public static string Format(this BitLogicApiKey kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BitLogicApiKey kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}