//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public abstract class AppCmdService<T> : AppService<T>
        where T : AppCmdService<T>, new()
    {
        CmdDispatcher Dispatcher;

        protected override void OnInit()
        {
            Dispatcher = Cmd.dispatcher(this);
        }

        public Outcome Dispatch(string command, CmdArgs args)
            => Dispatcher.Dispatch(command,args);

        public Outcome Dispatch(string command)
            => Dispatcher.Dispatch(command);

        public Outcome Dispatch(CmdSpec cmd)
            => Dispatcher.Dispatch(cmd.Name, cmd.Args);

        public ReadOnlySpan<string> Supported
        {
            [MethodImpl(Inline)]
            get => Dispatcher.Supported;
        }

        [CmdOp(".cmdlist")]
        Outcome ShowCommands(CmdArgs args)
        {
            iter(Supported, reg => Wf.Row(reg));
            return true;
        }
    }
}