//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".channel", "Defines a directect channel from one workspace to another")]
        Outcome SpecifyChannel(CmdArgs args)
        {
            if(args.Length == 0)
            {
                var channel = State.Channel();
                if(channel.Source.IsEmpty || channel.Target.IsEmpty)
                    return (false, "Channel unspacified");
                Write(channel);
                return true;
            }

            if(args.Length < 2)
                return (false, string.Format("Channel specification requires both a source and target"));

            var src = arg(args,0).Value;
            var dst = arg(args,1).Value;
            Write(State.Channel(src,dst));

            return true;
        }
    }
}