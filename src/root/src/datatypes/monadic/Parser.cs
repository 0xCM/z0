//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    public readonly struct Parser
    {
        /// <summary>
        /// Transforms a readonly T-cell into an editable T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        static ref T edit<T>(in T src)
            => ref AsRef(src);

        /// <summary>
        /// Presents an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        static ref T @as<S,T>(in S src)
            => ref As<S,T>(ref edit(src));

        [MethodImpl(Inline)]
        public static ParseResult<T> lower<S,T>(ParseResult<S,T> src)
            => src
            ? ParseResult<T>.Fail(src.Source.ToString(), src.Reason.ValueOrDefault(string.Empty))
            : ParseResult<T>.Success(src.Source.ToString(), src.Value);

        [MethodImpl(Inline)]
        public static ParseResult<S,T> lift<S,T>(ParseResult<T> src)
            => src ? ParseResult<S,T>.Success(@as<string,S>(src.Source), src.Value) : ParseResult<S,T>.Fail(@as<string,S>(src.Source), src.Message);

        [MethodImpl(Inline)]
        public static T apply<P,S,T>(P parser, S src)
            where T : struct
            where P : IParser2<S,T>
                => parser.Parse(src).ValueOrDefault(default(T));
    }
}