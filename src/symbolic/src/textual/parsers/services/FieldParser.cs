//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FieldParser : IFieldParser
    {
        public static FieldParser Service => default(FieldParser);

        [MethodImpl(Inline)]
        public YeaOrNea Parse(string src, out YeaOrNea result)     
            => result = Literal(src, out var _, YeaOrNea.N);

        [MethodImpl(Inline)]
        public T Numeric<T>(string src, out T result, T @default = default)     
            where T : unmanaged
        {
            var parser = NumericParser.create<T>();
            result = parser.Parse(src).ValueOrDefault(@default);
            return result;
        }

        [MethodImpl(Inline)]
        public string Parse(string src, out string result)
        {
            result = src?.Trim() ?? string.Empty;
            return result;
        }

        [MethodImpl(Inline)]
        public E Literal<E>(string src, out ParseResult<E> result, E @default = default)
            where E : unmanaged, Enum
        {
            result = success(src, Enums.Parse(src, @default));
            return result.Value;
        }

        [MethodImpl(Inline)]
        static ParseResult<T> success<T>(string src, T value)
            => ParseResult<T>.Success(src, value);

        [MethodImpl(Inline)]        
        static ParseResult<T> fail<T>(string src, Exception e, T rep = default)
            => ParseResult<T>.Fail(src, e);            
    }
}