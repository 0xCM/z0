//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SymbolicTests
    {
        /// <summary>
        /// Tests whether a character is one of (0,..9)
        /// </summary>
        public readonly struct IsDecimalDigit : ISymbolicTest<IsDecimalDigit,char>
        {
            [MethodImpl(Inline)]
            public bit Check(char c)
                => @decimal(c);
        }
    }
}