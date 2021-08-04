//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static AsmOpCodeTokens;

    partial struct AsmOpCodes
    {
        const string DispTokens =
            "cb\0" +
            "cw\0" +
            "cd\0" +
            "cp\0" +
            "c0\0" +
            "ct\0";

        [Op]
        public static bit parse(ReadOnlySpan<char> src, out DispToken dst)
        {
            dst = default;
            var matched = bit.Off;
            if(src.Length < 2)
                return matched;

            ref readonly var c0 = ref skip(src,0);
            ref readonly var c1 = ref skip(src,1);
            switch(c0)
            {
                case 'c':
                switch(c1)
                {
                    case 'b':
                        dst = DispToken.cb;
                        matched = true;
                    break;

                    case 'w':
                        dst = DispToken.cw;
                        matched = true;
                    break;

                    case 'd':
                        dst = DispToken.cd;
                        matched = true;
                    break;

                    case 'p':
                        dst = DispToken.cp;
                        matched = true;
                    break;

                    case 'o':
                        dst = DispToken.co;
                        matched = true;
                    break;

                    case 't':
                        dst = DispToken.cb;
                        matched = true;
                    break;
                }
                break;
            }

            return matched;
        }
    }
}