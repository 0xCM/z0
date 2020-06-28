//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    [ApiHost]
    public readonly struct AsmParsers
    {
        [MethodImpl(Inline), Op]
        public static AsmStatementParser statement()
            => new AsmStatementParser(ParseMnemonic);
        
        [MethodImpl(Inline), Op]
        public static AsmFieldParser fields()
            => default;            

        [MethodImpl(Inline), Op]
        public static Mnemonic ParseMnemonic(string src)
            => Enums.Parse(src, Mnemonic.INVALID);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T apply<T>(IParser<string,T> parser, string src) 
            where T : struct
                => parser.Parse(src).ValueOrDefault(default(T));
    }
}