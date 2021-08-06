//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;
    using static SdmModels.ModRMPatterns;

    using K = SdmModels.ModRMPatternKind;

    partial struct SdmModels
    {
        internal readonly struct ModRMPatterns
        {
           const byte ModRMCount = 8;

            public static readonly string[] Literals =
                new string[ModRMCount]{RmR, RmW, RmRW, RegR, RegW, RegRW, RmRMust11, RmWNot11};

            public const string Marker = "ModRM:";

            public const string RmR = "r/m (r)";

            public const string RmW = "r/m (w)";

            public const string RmRW = "r/m (r,w)";

            public const string RegR = "reg (r)";

            public const string RegW = "reg (w)";

            public const string RegRW = "reg (r,w)";

            public const string RmRMust11 = "r/m (r, ModRM:[7:6] must be 11b)";

            public const string RmWNot11 = "r/m (w, ModRM:[7:6] must not be 11b)";

        }

        partial struct Patterns
        {
            [Op]
            public static ReadOnlySpan<string> modrm()
                => ModRMPatterns.Literals;

            [Op]
            public static string pattern(ModRMPatternKind kind)
                => skip(ModRMPatterns.Literals, (byte)kind + 1);

            [Op]
            public static bit parse(string src, out ModRMPatternKind dst)
            {
                dst = 0;
                var i = text.index(src,ModRMPatterns.Marker);
                if(i < 0)
                    return false;

                var content = text.right(src,Chars.Colon);
                switch(src)
                {
                    case RmR:
                        dst = K.RmR;
                    break;

                    case RmW:
                        dst = K.RmW;
                    break;

                    case RmRW:
                        dst = K.RmRW;
                    break;

                    case RegR:
                        dst = K.RegR;
                    break;

                    case RegW:
                        dst = K.RegW;
                    break;

                    case RegRW:
                        dst = K.RegRW;
                    break;

                    case RmRMust11:
                        dst = K.RmRMust11;
                    break;

                    case RmWNot11:
                        dst = K.RmWNot11;
                    break;
                }
                return dst != 0;
            }
        }
    }
}