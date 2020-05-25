//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static HexCodes;
    using static Seed;
    using static Memories;


    struct OpCodeParser
    {
        public static OpCodeParser Service => default(OpCodeParser);

        ParseResult<HexDigit> ParseDigit(char c)
        {
            var code = (HexDigitCodeUp)c;
            return default;
        }
        void Parse(char c)
        {
            

        }

        public OpCodeSpec Parse(OpCodeExpression src)            
        {
            for(var i=0; i<src.Data.Length; i++)
                Parse(skip(src.Data, i));

            return new OpCodeSpec(src);
        }
    }
}