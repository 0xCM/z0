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
        [CmdOp(".dfa-states")]
        public Outcome DfaStates(CmdArgs args)
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
    }
}