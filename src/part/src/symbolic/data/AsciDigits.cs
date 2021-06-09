//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static AsciCode;
    using static core;

    using Facets = AsciCodeFacets;

    partial struct AsciCharData
    {
        public static ReadOnlySpan<AsciCode> DigitCodes => new AsciCode[Facets.DigitCount]{
            d0,d1,d2,d3,d4,d5,d6,d7,d8,d9
            };

        public static ReadOnlySpan<char> DigitChars
            => span("0123456789");

    }
}