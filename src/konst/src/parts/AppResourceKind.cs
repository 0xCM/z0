//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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