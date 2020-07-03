//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    public enum AppResourceKind : byte
    {
        None = 0,

        ScalarLiteral,

        CharacterLiteral,

        StringLiteral,

        EnumLiteral,

        ByteSpan,

        EncodedAsci,

        Manifest
    }

}