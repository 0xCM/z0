//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        public static Outcome hexbytes(string src, out BinaryCode dst)
        {
            var result = HexByteParser.ParseData(src, out var _dst);
            if(result)
                dst = _dst.Storage;
            else
                dst = BinaryCode.Empty;
            return result;
        }
    }
}