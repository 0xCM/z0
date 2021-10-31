//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static core;

    public abstract class AppCmdService<T> : AppService<T>, IAppCmdService
        where T : AppCmdService<T>, new()
    {
        CmdDispatcher Dispatcher;

        IWorkerLog Witness;

        Option<IToolCmdShell> Shell;

        protected OmniScript OmniScript;

        protected AppCmdService()
        {
            PromptTitle = "cmd";
        }

        protected override void OnInit()
        {
            Dispatcher = Cmd.dispatcher(this, Dispatch);
            Witness = Loggers.worker(controller().Id(), Db.ControlRoot());
            OmniScript = Wf.OmniScript();
        }

        public T With(IToolCmdShell shell)
        {
            Shell = Option.some(shell);
            return (T)this;
        }

        protected void Emitted(FS.FilePath dst)
            => Write(string.Format("Emitted {0}", dst.ToUri()));

        Outcome SelectTool(ToolId tool)
        {
            var result = Outcome.Success;
            if(Shell.IsNone())
            {
                result = (false, "Target shell unspecified");
                return result;
            }

            return Shell.Value.SelectTool(tool);
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


        protected Outcome ToolEnv(out Settings dst)
        {
            var path = Ws.Tools().Toolbase + FS.file("show-env-config", FS.Cmd);
            dst = Settings.Empty;
            if(!path.Exists)
                return (false, FS.missing(path));
            var cmd = Cmd.cmdline(path.Format(PathSeparator.BS));
            var response = OmniScript.RunCmd(cmd);
            dst = Settings.parse(response);
            return true;
        }

        [CmdOp(".tool-env")]
        protected Outcome ShowToolEnv(CmdArgs args)
        {
            var result = ToolEnv(out var settings);
            if(result.Fail)
                return result;

            iter(settings, s => Write(s));

            return true;
            // var path = Ws.Tools().Toolbase + FS.file("show-env-config", FS.Cmd);
            // if(!path.Exists)
            //     return (false, FS.missing(path));
            // var cmd = Cmd.cmdline(path.Format(PathSeparator.BS));
            // var response = OmniScript.RunCmd(cmd);
            // var settings = Settings.parse(response);
            // iter(settings, s => Write(s));
            // return true;
        }

        public void Run()
        {
            var input = Next();
            while(input.Name != ".exit")
            {
                if(input.IsNonEmpty)
                {
                    if(input.Name == ".tool")
                    {
                        var result = SelectTool(arg(input.Args,0).Value);
                        if(result.Fail)
                        {
                            Error(result.Message);
                        }
                    }
                    else
                    {
                        Witness.LogStatus(string.Format("{0} {1}", Prompt(), input.Format()));
                        Dispatch(input);
                    }
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