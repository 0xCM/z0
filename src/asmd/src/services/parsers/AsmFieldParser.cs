//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmFieldParser
    {
        public static AsmFieldParser Service => default;

        [MethodImpl(Inline)]
        public AsciCode16 Parse(string src, out AsciCode16 result)     
            => result = src;

        [MethodImpl(Inline)]
        public AsciCode32 Parse(string src, out AsciCode32 result)     
            => result = src;

        [MethodImpl(Inline)]
        public AsciCode64 Parse(string src, out AsciCode64 result)     
            => result = src;

        [MethodImpl(Inline)]
        public YeaOrNea Parse(string src, out YeaOrNea result)     
            => result = @enum(src, out var _, YeaOrNea.N);

        [MethodImpl(Inline)]
        public OpCodeId Parse(string src, out OpCodeId result)     
            => result = @enum(src, out var _, OpCodeId.INVALID);

        [MethodImpl(Inline)]
        public T Parse<T>(string src, out T result, T @default = default)     
            where T : unmanaged
                => result = numeric<T>(src, out var _,  @default);

        [MethodImpl(Inline)]
        public string Parse(string src, out string result)
        {
            result = src?.Trim() ?? string.Empty;
            return result;
        }

        [MethodImpl(Inline)]
        E @enum<E>(string src, out ParseResult<E> result, E @default = default)
            where E : unmanaged, Enum
        {
            result = parse(src, x => Enums.Parse(src, @default));
            return result.ValueOrDefault(@default);
        }

        [MethodImpl(Inline)]
        T numeric<T>(string src, out ParseResult<T> result, T @default = default)     
            where T : unmanaged
        {      
            var parser = NumericParser.create<T>();
            result = parser.Parse(src);
            return result.ValueOrDefault(default(T));
        }

        static ParseResult<T> parse<T>(string src, Func<string,T> parser)
        {
            try
            {
                return success(src,parser(src));
            }
            catch(Exception e)
            {
                return fail<T>(src,e);
            }
        }

        [MethodImpl(Inline)]
        static ParseResult<T> success<T>(string src, T value)
            => ParseResult<T>.Success(src, value);

        [MethodImpl(Inline)]
        static ParseResult<T> fail<T>(string src, Exception e, T rep = default)
            => ParseResult<T>.Fail(src, e);            
    }
}