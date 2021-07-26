//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    public enum XedCmdInputKind : byte
    {
        None = 0,

        [Symbol("-i", "pecoff-format")]
        PeCoff,


        [Symbol("-ir", "raw unformatted binary file")]
        RawBin,


        [Symbol("-ih", "raw unformatted ASCII hex file")]
        HexText,
    }
}