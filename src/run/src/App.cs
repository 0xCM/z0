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

            var kind = CmdSwitch.kind(args);
            switch(kind)
            {
                case CmdSwitchKind.Control:
                    ControlCommandDispatcher.dispatch(args);
                break;
                case CmdSwitchKind.Workflow:
                    WorkflowCommandDispatcher.dispatch(args);
                break;
                default:
                    DefaultCmdDispatcher.dispatch(args);
                break;
            }
        }
    }
}