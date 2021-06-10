//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsciCode;
    using static core;


    [ApiHost]
    public readonly struct SymTableModel
    {
        public static ReadOnlySpan<AsciCode> DigitCodes => new AsciCode[10]{d0,d1,d2,d3,d4,d5,d6,d7,d8,d9};

        public static ReadOnlySpan<char> DigitChars => span("0123456789");

        [MethodImpl(Inline), Op]
        public static char render(byte digit)
            => skip(DigitChars, digit);

        [MethodImpl(Inline), Op]
        public static AsciCode code(byte digit)
            => skip(DigitCodes,digit);

    }

}