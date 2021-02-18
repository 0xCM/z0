//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmOpCodes;

    using M = AsmSyntaxMeaning;
    using K = OpCodeTokenKind;

    public struct AsmOpCodeTokens
    {
        public readonly struct Rd0
        {
            public string Symbol => "/0";

            public OpCodeTokenKind Kind => K.Rd0;

            public string Description => M.Rd0;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(Rd0 src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct Rd1
        {
            public string Symbol => "/1";

            public OpCodeTokenKind Kind => K.Rd1;

            public string Description => M.Rd1;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(Rd1 src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct Rd2
        {
            public string Symbol => "/2";

            public OpCodeTokenKind Kind => K.Rd2;

            public string Description => M.Rd2;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(Rd2 src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct Rd3
        {
            public string Symbol => "/3";

            public OpCodeTokenKind Kind => K.Rd3;

            public string Description => M.Rd3;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(Rd3 src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct Vex
        {
            public string Symbol => "VEX";

            public OpCodeTokenKind Kind => K.Vex;

            public string Description => EmptyString;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(Vex src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct x128
        {
            public string Symbol => "128";

            public OpCodeTokenKind Kind => K.x128;

            public string Description => EmptyString;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(x128 src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct x256
        {
            public string Symbol => "256";


            public OpCodeTokenKind Kind => K.x256;

            public string Description => EmptyString;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(x256 src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct Nds
        {
            public string Symbol => "NDS";

            public OpCodeTokenKind Kind => K.Nds;

            public string Description => EmptyString;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(Nds src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct Lig
        {
            public string Symbol => "LIG";

            public OpCodeTokenKind Kind => K.Lig;

            public string Description => EmptyString;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(Lig src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct Rex
        {
            public string Symbol => "REX";

            public OpCodeTokenKind Kind => K.Rex;

            public string Description => EmptyString;

            [MethodImpl(Inline)]
            public static implicit operator AsmOpCodeToken(Rex src)
                => (src.Symbol, src.Kind, src.Description);
        }

        public readonly struct HexLiteral
        {
            public Hex8 Value {get;}

            [MethodImpl(Inline)]
            public HexLiteral(Hex8 seq)
                => Value = seq;

            [MethodImpl(Inline)]
            public static implicit operator HexLiteral(byte src)
                => new HexLiteral(src);

            [MethodImpl(Inline)]
            public static implicit operator HexLiteral(Hex8Seq src)
                => new HexLiteral(src);
        }
    }
}