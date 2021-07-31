//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct asm
    {
        [Op]
        public static Outcome hexbytes(string src, out BinaryCode dst)
            => HexByteParser.hexbytes(src, out dst);
    }
}