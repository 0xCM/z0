//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static Outcome parse(string src, out BinaryCode dst)
        {
            var result = HexByteParser.ParseData(src, out var data);
            if(result)
            {
                dst = data.Storage;
                return result;
            }
            else
            {
                dst = BinaryCode.Empty;
                return result;
            }
        }
    }
}