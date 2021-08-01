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
        Outcome DfaStates(CmdArgs args)
        {
            var width = arg(args,0).To16u();
            var states = Dfa.states(width, w8);
            var count = states.Length;
            Out(string.Format("{0}={1}", "Domain", width));
            Out(string.Format("{0}={1}", "Count", count));
            for(var i=0; i<count; i++)
            {
                ref readonly var state = ref skip(states,i);
                var buffer = ByteBlock16.Empty;
                var v = Dfa.bitvector(width, state.Content, recover<bit>(buffer.Bytes));
                Out(string.Format("State[{0}]={1}", i, state.Content));
                Out(string.Format("BitVector[{0}].Width={1}", i, v.Width));
                Out(string.Format("BitVector[{0}].Bits={1}", i, v.Format()));
            }
            return true;
        }
    }
}