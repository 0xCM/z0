//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static AsmOpCodeTokens;
    using static Root;
    using static core;

    partial struct AsmOpCodes
    {
        [Op]
        public static bit parse(ReadOnlySpan<char> src, out RexBToken dst)
        {
            var matched = bit.Off;
            var length = src.Length;
            dst = default;
            if(length < 3)
                return matched;

            ref readonly var c0 = ref skip(src,0);
            ref readonly var c1 = ref skip(src,1);
            ref readonly var c2 = ref skip(src,2);

            switch(length)
            {
                case 3:
                    switch(c0)
                    {
                        case '+':
                            switch(c1)
                            {
                                case 'r':
                                    switch(c2)
                                    {
                                        case 'b':
                                            dst = RexBToken.rb;
                                            matched = true;
                                        break;
                                        case 'w':
                                            dst = RexBToken.rw;
                                            matched = true;
                                        break;
                                        case 'd':
                                            dst = RexBToken.rd;
                                            matched = true;
                                        break;
                                        case 'o':
                                            dst = RexBToken.ro;
                                            matched = true;
                                        break;
                                    }
                                break;
                            }
                        break;
                    }

                break;
                case 4:
                    ref readonly var c3 = ref skip(src,3);
                    switch(c0)
                    {
                        case 'N':
                        switch(c1)
                        {
                            case '.':
                            switch(c2)
                            {
                                case 'A':
                                    dst = RexBToken.NA;
                                    matched = true;
                                break;
                                case 'E':
                                    dst = RexBToken.NE;
                                    matched = true;
                                break;
                            }
                            break;
                        }
                        break;
                    }

                break;
            }

            return matched;
        }
    }
}