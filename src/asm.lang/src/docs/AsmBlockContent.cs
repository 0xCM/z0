//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct AsmBlockContent
    {
        public AsmBlockHeader Header;

        public Index<AsmHexCode> Encoded;

        public TextBlock SourceText;
    }
}