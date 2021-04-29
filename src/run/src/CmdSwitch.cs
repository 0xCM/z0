//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum CmdSwitchKind
    {
        None = 0,

        [Alias("control")]
        Control,

        [Alias("wf")]
        Workflow
    }

    public readonly struct CmdSwitch
    {
       public static bool control(params string[] args)
            => args.Length >=2 && args[0] == "--control";

       public static bool workflow(params string[] args)
            => args.Length >=2 && args[0] == "--wf";

        public static CmdSwitchKind kind(params string[] args)
        {
            if(control(args))
                return CmdSwitchKind.Control;
            else if(workflow(args))
                return CmdSwitchKind.Workflow;
            else
                return 0;
        }
    }
}