//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;
    using static Blit;

    partial class AsmCmdService
    {
        [CmdOp(".dfa-states")]
        Outcome DfaStates(CmdArgs args)
        {
            var width = arg(args,0).To16u();
            var states = Dfa.states(width, w8);
            var count = states.Length;
            Write(string.Format("{0}={1}", "Domain", width));
            Write(string.Format("{0}={1}", "Count", count));
            for(var i=0; i<count; i++)
            {
                ref readonly var state = ref skip(states,i);
                var buffer = ByteBlock16.Empty;
                var v = bitspan.create(width, state.Content, recover<bit>(buffer.Bytes));
                Write(string.Format("State[{0}]={1}", i, state.Content));
                Write(string.Format("BitVector[{0}].Width={1}", i, v.Width));
                Write(string.Format("BitVector[{0}].Bits={1}", i, v.Format()));
            }
            return true;
        }

        [CmdOp(".names")]
        Outcome Names(CmdArgs args)
        {
            var result = Outcome.Success;
            var name0 = Factory.name(n16, "0123456789ABCDEF");
            var name1 = Factory.name(n8, "01234");
            Write(name0);
            Write(name1);

            return result;
        }
    }
}