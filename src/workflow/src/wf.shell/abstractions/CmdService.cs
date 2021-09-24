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

    public interface IAppCmdService : IAppService
    {
        Outcome Dispatch(CmdSpec cmd);

        void Run();
    }

    public abstract class AppCmdService<T> : AppService<T>, IAppCmdService
        where T : AppCmdService<T>, new()
    {
        CmdDispatcher Dispatcher;

        IWorkerLog Witness;

        protected AppCmdService()
        {
            PromptTitle = "cmd";
        }

        protected override void OnInit()
        {
            Dispatcher = Cmd.dispatcher(this, Dispatch);
            Witness = Loggers.worker(controller().Id(), Db.ControlRoot());
        }

        protected override void Disposing()
        {
            base.Disposing();
            Witness?.Dispose();
        }

        protected virtual string PromptTitle {get;}

        protected virtual Outcome Dispatch(string command, CmdArgs args)
            => (false, string.Format("Handler for '{0}' not found", command));

        string Prompt()
            => string.Format("{0}> ", PromptTitle);

        CmdSpec Next()
        {
            var input = term.prompt(Prompt());

            return Cmd.cmdspec(input);
        }

        public void Run()
        {
            var input = Next();
            while(input.Name != ".exit")
            {
                if(input.IsNonEmpty)
                {
                    Witness.LogStatus(string.Format("{0} {1}", Prompt(), input.Format()));
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

        protected static CmdArg arg(in CmdArgs src, int index)
        {
            if(src.IsEmpty)
                sys.@throw(EmptyArgList.Format());

            var count = src.Length;
            if(count < index - 1)
                sys.@throw(ArgSpecError.Format());
            return src[(ushort)index];
        }

        static MsgPattern EmptyArgList => "No arguments specified";

        static MsgPattern ArgSpecError => "Argument specification error";
    }
}