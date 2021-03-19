//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Classifies defined asm syntax nodes
    /// </summary>
    public enum AsmNodeKind : byte
    {
        None = 0,

        Comment,

        LineLabel,

        Address,

        LabelDef,

        LabelRef,

        Alias,

        EncodedBytes,

        Statement,

        Keyword,
    }
}