//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class App
    {
        public static void Main(params string[] args)
        {
            var count = args.Length;
            if(count != 0)
                term.inform(string.Format("Command-line: {0}", args.Delimit()));

            ControlDispatch.dispatch(args);

            // var kind = CmdSwitch.kind(args);
            // switch(kind)
            // {
            //     case CmdSwitchKind.Control:
            //     break;
            //     case CmdSwitchKind.Workflow:
            //     break;
            //     default:
            //         Reactor.dispatch(args);
            //     break;
            // }
        }
    }
}