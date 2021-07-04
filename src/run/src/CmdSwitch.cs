//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum CmdSwitchKind
    {
        None = 0,

        [Symbol("control")]
        Control,

        [Symbol("wf")]
        Workflow
    }

    public readonly struct CmdSwitch
    {
       public static bool control(params object[] args)
            => args.Length >=2 && (string)args[0] == "--control";

       public static bool workflow(params object[] args)
            => args.Length >=1 && args[0] != null;

        public static CmdSwitchKind kind(params object[] args)
        {
            if(workflow(args))
            {
                return CmdSwitchKind.Workflow;
            }
            else if(control(args))
            {
                return CmdSwitchKind.Control;
            }
            else
                return 0;
        }
    }
}