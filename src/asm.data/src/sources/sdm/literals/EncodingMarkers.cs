//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using M = SdmModels.EncodingMarkers;
    partial struct SdmModels
    {
        public enum EncodingClass : byte
        {
            None = 0,

            ExplicitRegs,

            Imm,

            ModRm,

            Vex,

            Evex,

            Vsib,

            Arithmetic
        }

        [SymSource]
        public enum ModRmKind : byte
        {
            [Symbol(M.RmR)]
            RmR,

            [Symbol(M.RmW)]
            RmW,

            [Symbol(M.RmRW)]
            RmRW,

            [Symbol(M.RegR)]
            RegR,

            [Symbol(M.RegW)]
            RegW,

            [Symbol(M.RegRW)]
            RegRW,

            [Symbol(M.RmRMust11)]
            RmRMust11,

            [Symbol(M.RmWNot11)]
            RmWNot11
        }

        public readonly struct EncodingMarkers
        {
            const string _ = "_";

            const string W = "W";

            const string R = "R";

            const string X = "X";

            const string B = "B";

            const string C = "C";

            const string V = "V";

            const string tick = "'";

            const string dot = ".";

            const string or = "/";

            /// <summary>
            /// (r)
            /// </summary>
            [TextMarker]
            public const string r = "(r)";

            /// <summary>
            /// (w)
            /// </summary>
            [TextMarker]
            public const string w = "(w)";

            /// <summary>
            /// ModRM:
            /// </summary>
            [TextMarker]
            public const string ModRM = "ModRM:";

            /// <summary>
            /// REX
            /// </summary>
            [TextMarker]
            public const string REX = "REX";

            /// <summary>
            /// REX.W
            /// </summary>
            [TextMarker]
            public const string RexW = REX + dot + W;

            /// <summary>
            /// REX.B
            /// </summary>
            [TextMarker]
            public const string RexB = REX + dot + B;

            [TextMarker]
            public const string VEX = "VEX" + dot;

            [TextMarker]
            public const string EVEX = "EVEX" + dot;

            [TextMarker]
            public const string rw = "(r,w)";

            [TextMarker]
            public const string rm = "r/m";

            [TextMarker]
            public const string reg = "reg";

            /// <summary>
            /// r/m (r)
            /// </summary>
            [TextMarker]
            public const string RmR = rm + _ + r;

            /// <summary>
            /// r/m (w)
            /// </summary>
            [TextMarker]
            public const string RmW = rm + _ + w;

            /// <summary>
            /// r/m (r,w)
            /// </summary>
            [TextMarker]
            public const string RmRW = rm + _ + rw;

            /// <summary>
            /// reg (r)
            /// </summary>
            [TextMarker]
            public const string RegR = reg + _ + r;

            /// <summary>
            /// reg (w)
            /// </summary>
            [TextMarker]
            public const string RegW = reg + _ + w;

            /// <summary>
            /// reg (r,w)
            /// </summary>
            [TextMarker]
            public const string RegRW = reg  + _ + rw;

            /// <summary>
            /// r/m (r, ModRM:[7:6] must be 11b)
            /// </summary>
            [TextMarker]
            public const string RmRMust11 = rm + _ + "(r, ModRM:[7:6] must be 11b)";

            /// <summary>
            /// r/m (w, ModRM:[7:6] must not be 11b)
            /// </summary>
            [TextMarker]
            public const string RmWNot11 = rm + _ + "(w, ModRM:[7:6] must not be 11b)";

            [TextMarker]
            public const string vvvv = "vvvv";

            /// <summary>
            /// R'
            /// </summary>
            [TextMarker]
            public const string RTick = R + tick;

            /// <summary>
            /// V'
            /// </summary>
            [TextMarker]
            public const string VTick = V + tick;

            /// <summary>
            /// RC
            /// </summary>
            [TextMarker]
            public const string RC = R + C;

            /// <summary>
            /// RX
            /// </summary>
            [TextMarker]
            public const string RX = R + X;

            /// <summary>
            /// RXB
            /// </summary>
            [TextMarker]
            public const string RXB = R + X + B;

            /// <summary>
            /// WRXB
            /// </summary>
            [TextMarker]
            public const string WRXB = W + R + X + B;
        }
    }
}