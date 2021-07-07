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

        CmdSpec Next()
            => Cmd.spec(term.prompt("cmd> "));

        public void Run()
        {
            var input = Next();
            while(input.Name != ".exit")
            {
                if(input.IsNonEmpty)
                    Dispatch(input);

                input = Next();
            }
        }

        public Outcome Dispatch(string command, CmdArgs args)
        {
            var outcome = Dispatcher.Dispatch(command,args);
            if(outcome.Fail)
                Wf.Error(outcome.Message);
            return outcome;
        }

        protected Outcome Dispatch(string command, params string[] args)
            => Dispatch(command, Cmd.args(args));

        public Outcome Dispatch(string command)
        {
            var outcome = Dispatcher.Dispatch(command);
            if(outcome.Fail)
                Wf.Error(outcome.Message);
            return outcome;
        }

        public Outcome Dispatch(CmdSpec cmd)
        {
            var outcome = Dispatcher.Dispatch(cmd.Name, cmd.Args);
            if(outcome.Fail)
                Wf.Error(outcome.Message);
            return outcome;
        }

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