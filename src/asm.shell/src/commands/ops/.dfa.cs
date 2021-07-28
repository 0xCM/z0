//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".emit-pe-headers")]
        Outcome EmitSectionHeaders(CmdArgs args)
        {
            var service = Wf.CliEmitter();
            service.EmitSectionHeaders();
            return true;
        }

        [CmdOp(".dfa-states")]
        Outcome DfaStates(CmdArgs args)
        {
            var width = arg(args,0).To8u();
            var domain = dfa.domain(width);
            var states = dfa.states(domain, w8);
            var count = states.Length;
            Out(string.Format("{0}={1}", "Domain", domain));
            Out(string.Format("{0}={1}", "Count", count));
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(states,i);
                var buffer = ByteBlock8.Empty;
                var v = dfa.bitvector(domain, s, recover<bit>(buffer.Bytes));
                Out(string.Format("State[{0}]={1}", i, s.Content));
                Out(string.Format("BitVector[{0}].Width={1}", i, v.Width));
                Out(string.Format("BitVector[{0}].Bits={1}", i, dfa.format(v)));
            }
            return true;
        }

        [CmdOp(".dfa-symbols")]
        Outcome DfaSymbols(CmdArgs args)
        {
            var store = dfa.symstore<string>(24);
            store.Deposit("abc", out var s1);
            Write(s1);
            store.Deposit("def", out var s2);
            Write(s2);
            store.Deposit("hij", out var s3);
            Write(s3);
            store.Deposit("klm", out var s4);
            Write(s4);
            store.Deposit("nop", out var s5);
            Write(s5);

            var e1 = store.Extract(s1);
            var e2 = store.Extract(s2);
            var e3 = store.Extract(s3);
            var e4 = store.Extract(s4);
            var e5 = store.Extract(s5);
            Write(e1 + e2 + e3 + e4 + e5);
            return true;
        }
    }
}