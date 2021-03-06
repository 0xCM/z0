//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public abstract class AppCmdService<T> : AppService<T>
        where T : AppCmdService<T>, new()
    {
        CmdDispatcher Dispatcher;

        IWorkerLog Witness;

        protected AppCmdService()
        {

        }

        protected override void OnInit()
        {
            Dispatcher = Cmd.dispatcher(this);
            Witness = Loggers.worker(controller().Id(), Db.ControlRoot());
        }

        protected override void Disposing()
        {
            base.Disposing();
            Witness?.Dispose();
        }


        CmdSpec Next()
            => Cmd.cmdspec(term.prompt("cmd> "));

        public void Run()
        {
            var input = Next();
            while(input.Name != ".exit")
            {
                if(input.IsNonEmpty)
                {
                    Witness.LogStatus(input.Format());
                    Dispatch(input);
                }

                input = Next();
            }
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

        protected static Outcome argerror(string value)
            => (false, $"The argument value '{value}' is invalid");

        protected static CmdArg arg(in CmdArgs src, int index)
        {
            if(src.IsEmpty)
                sys.@throw(EmptyArgList.Format());

            var count = src.Length;
            if(count < index - 1)
                sys.@throw(ArgSpecError.Format());
            return src[(ushort)index];
        }

        protected bool Arg(in CmdArgs src, int index, out CmdArg value)
        {
            value = default;
            if(src.IsEmpty)
            {
                Error(EmptyArgList.Format());
                return false;
            }

            var count = src.Length;
            if(count < index - 1)
            {
                Error(ArgSpecError.Format());
                return false;
            }

            value = src[(ushort)index];
            return true;
        }

        static MsgPattern EmptyArgList => "No arguments specified";

        static MsgPattern ArgSpecError => "Argument specification error";
    }
}