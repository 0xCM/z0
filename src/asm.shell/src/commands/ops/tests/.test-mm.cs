//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static Root;
    using static core;

    using static MatchMachine3x8;

    partial class AsmCmdService
    {
        [CmdOp(".test-mm")]
        public Outcome TestMatchMachine(CmdArgs args)
            => TestMatchMachine();

        Outcome TestMatchMachine()
        {
            var result = Outcome.Success;
            result &= Match(2, first32u(MatchTarget0), MatchInput);
            result &= Match(2, first32u(MatchTarget1), MatchInput);
            result &= Match(3, first32u(MatchTarget2), MatchInput);
            result &= Match(1, first32u(MatchTarget3), MatchInput);
            result &= Match(3, first32u(MatchTarget4), MatchInput);
            return result ? (true, "Pass") : (false, "Fail");
        }

        Outcome Match(byte n, uint src, ReadOnlySpan<byte> input)
        {
            var result = Outcome.Success;

            var spec = specify(n,src);
            var machine = MatchMachine3x8.create(spec);

            Write(spec.Format());

            var i = machine.Run(input);
            var matched = i>=0;
            var msg = matched ? string.Format("Matched: i={0}",i) : "Unmatched";
            result = (matched, msg);
            Write(result.Message);
            return result;
        }

        static ReadOnlySpan<byte> MatchTarget0 => new byte[4]{0x24,0x12,0x00,0x00};

        static ReadOnlySpan<byte> MatchTarget1 => new byte[4]{0xCC,0x00,0x00,0x00};

        static ReadOnlySpan<byte> MatchTarget2 => new byte[4]{0x48,0x16,0x19,0x00};

        static ReadOnlySpan<byte> MatchTarget3 => new byte[4]{0x19,0x00,0x00,0x00};

        static ReadOnlySpan<byte> MatchTarget4 => new byte[4]{0xCC,0x00,0x19,0x00};


        static ReadOnlySpan<byte> MatchInput => new byte[]{
            0x52,0x21,0x18,0x00,
            0x23,0x48,0x16,0x19,
            0x22,0x24,0x12,0xCC,
            0xCC,0x00,0x19,0x00
            };
    }
}