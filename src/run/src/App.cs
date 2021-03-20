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

            var kind = CommandSwitch.kind(args);
            switch(kind)
            {
                case CommandSwitchKind.Control:
                    ControlCommandDispatcher.dispatch(args);
                break;
                case CommandSwitchKind.Workflow:
                    WorkflowCommandDispatcher.dispatch(args);
                break;
                default:
                    DefaultCommandDispatcher.dispatch(args);
                break;
            }
        }
    }
}