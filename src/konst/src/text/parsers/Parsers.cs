//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    using static Konst;

    [ApiHost]
    public readonly struct Parsers
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T apply<T>(IParser<string,T> parser, string src) 
            where T : struct
                => parser.Parse(src).ValueOrDefault(default(T));

        /// <summary>
        /// Defines a parser predicated on a parse function
        /// </summary>
        /// <param name="f">The parse function</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static IParser<S,T> from<S,T>(Parse<S,T> f)
            => new Parser<S,T>(f);    

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static NumericParser<T> numeric<T>()
            where T : unmanaged
                => default(NumericParser<T>);

        [MethodImpl(Inline), Op]
        public static ScalarParser scalar()
            => ScalarParser.Service;

        [MethodImpl(Inline)]
        public static NumericParserNoFail<T> numeric<T>(bool succeed)
            where T : unmanaged
                => NumericParser.infallible<T>();

        [MethodImpl(Inline)]
        public static ITextParser<MemoryRange> address(bool range)
            => MemoryRangeParser.Service;

        [MethodImpl(Inline)]
        public static HexScalarParser hex()
            => HexScalarParser.Service;

        [MethodImpl(Inline)]
        public static IHexParser<byte> hex(bool bytes)
            => HexByteParser.Service;
    }
}