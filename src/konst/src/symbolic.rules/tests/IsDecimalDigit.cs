//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Konst;

    using DF = DecimalSymFacet;

    partial struct SymbolicTests
    {
        /// <summary>
        /// Tests whether a character is one of (0,..9)
        /// </summary>
        public readonly struct IsDecimalDigit : ISymbolicTest<IsDecimalDigit,char>
        {
            [MethodImpl(Inline)]
            public static bit check(char c)
                => (DF)c >= DF.First && (DF)c <= DF.Last;

            [MethodImpl(Inline)]
            public bit Check(char c)
                => check(c);
        }
    }
}