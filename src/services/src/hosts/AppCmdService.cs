//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public abstract class AppCmdService<T,S> : AppCmdService<T>
        where T : AppCmdService<T,S>, new()
        where S : CmdShellState, new()
    {
        protected S State {get;}

        protected AppCmdService()
        {
            State = new S();
        }

        protected FS.Files Files(FS.Files src, bool write = true)
        {
            State.Files(src);
            if(write)
                iter(src.View, f => Write(f.ToUri()));
            return src;
        }

        [CmdOp(".project")]
        protected Outcome Project(CmdArgs args)
        {
            var outcome = Outcome.Success;
            if(args.Length == 0)
                return LoadProjectSources(State.Project());
            else
                return LoadProjectSources(State.Project(arg(args,0).Value));
        }

        [CmdOp(".files")]
        protected Outcome ShowFiles(CmdArgs args)
        {
            var result = Outcome.Success;
            var files = State.Files();
            iter(files, file => Write(file.ToUri()));
            return result;
        }

        protected Outcome LoadProjectSources(IProjectWs ws)
        {
            var outcome = Outcome.Success;
            var dir = ws.Home();
            outcome = dir.Exists;
            if(outcome)
                Files(ws.SrcFiles());
            else
                outcome = (false, UndefinedProject.Format(ws.Project));
            return outcome;
        }

        protected Outcome LoadProjectSources(IProjectWs ws, Subject? scope)
        {
            Files(ProjectFiles(ws,scope));
            return true;
        }

        protected Outcome RunProjectScript(CmdArgs args, ScriptId script, Subject? scope = null)
            => RunProjectScript(State.Project(), args, script, scope);

        static MsgPattern<ProjectId> UndefinedProject
            => "Undefined project:{0}";
    }


    public abstract class AppCmdService<T> : AppService<T>, IAppCmdService
        where T : AppCmdService<T>, new()
    {
        CmdDispatcher Dispatcher;

        IWorkerLog Witness;

        Option<IToolCmdShell> Shell;

        protected OmniScript OmniScript;

        protected IProjectSet ProjectWs;

        protected ProjectScripts ProjectScripts;

        protected AppCmdService()
        {
            PromptTitle = "cmd";
        }

        protected override void OnInit()
        {
            Dispatcher = Cmd.dispatcher(this, Dispatch);
            Witness = Loggers.worker(controller().Id(), Db.ControlRoot());
            OmniScript = Wf.OmniScript();
            ProjectWs = Ws.Projects();
            ProjectScripts = Wf.ProjectScripts();
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

        protected Outcome RunExe(ReadOnlySpan<ToolFlow> flows)
        {
            if(ToolFlows.target(flows,FS.Exe, out var flow))
            {
                ref readonly var target = ref flow.Target;
                Write(string.Format("Executing {0}", flow.Target.ToUri()));
                var result = OmniScript.Run(target, CmdVars.Empty, true, out var response);
                if(result.Fail)
                    return result;

                for(var j=0; j<response.Length; j++)
                    Write(skip(response, j).Content);
                return true;
            }
            else
                return false;
        }

        protected Outcome ShowSyms<K>(Symbols<K> src)
            where K : unmanaged
        {
            const string Pattern1 = "{0,-4} {1}";
            const string Pattern2 = "{0,-4} {1}('{2}')";
            var count = src.Length;
            var view = src.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var symbol = ref skip(view,i);
                var key = symbol.Key;
                var name = symbol.Name.Format();
                var expr = symbol.Expr.Format();
                if(name.Equals(expr))
                    Write(string.Format(Pattern1, key, expr));
                else
                    Write(string.Format(Pattern2, key, name, expr));
            }
            return true;
        }

        protected ByteSize EmitHexArray(byte[] src, FS.FilePath dst)
        {
            var array = Hex.hexarray(src);
            var size = src.Length;
            var flow = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            writer.WriteLine(array.Format(false));
            EmittedFile(flow, size);
            return size;
        }

        protected Outcome EmitHexArrays(ReadOnlySpan<FS.FilePath> src, FS.FolderPath dir)
        {
            var result = Outcome.Success;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var dst = dir + FS.file(path.FileName.Format(), FS.XArray);
                var data = HexArray.cover(path.ReadBytes());
                var size = data.Length;
                using var writer = dst.AsciWriter();
                writer.WriteLine(data.Format(true));
                Write(string.Format("({0} bytes)[{1} -> {2}]", size, path.ToUri(), dst.ToUri()));
            }

            return result;
        }

        protected Index<SymKindRow> EmitSymKinds<K>(in Symbols<K> src, FS.FilePath dst)
            where K : unmanaged
        {
            var result = Outcome.Success;
            var kinds = src.Kinds;
            var count = kinds.Length;
            var buffer = alloc<SymKindRow>(count);
            Symbols.kinds(src,buffer);
            TableEmit(@readonly(buffer), SymKindRow.RenderWidths, dst);
            return buffer;
        }

        protected void Write<R>(ReadOnlySpan<R> src, ReadOnlySpan<byte> widths)
            where R : struct
        {
            var formatter = Tables.formatter<R>(widths);
            var count = src.Length;
            for(var i=0; i<count; i++)
                Write(formatter.Format(skip(src,i)));
        }

        protected ReadOnlySpan<CmdResponse> ParseCmdResponse(ReadOnlySpan<TextLine> src)
        {
            var count = src.Length;
            if(count == 0)
                Warn("No response to parse");

            var parsed = list<CmdResponse>();
            for(var i=0; i<count; i++)
            {
                if(CmdResponse.parse(skip(src,i).Content, out var response))
                    parsed.Add(response);
            }
            return parsed.ViewDeposited();
        }

        protected FS.Files ProjectFiles(IProjectWs ws, Subject? scope)
        {
            if(scope != null)
                return ws.SrcFiles(scope.Value.Format());
            else
                return ws.SrcFiles();
        }

        protected Outcome RunProjectScript(IProjectWs ws, CmdArgs args, ScriptId script, Subject? scope = null)
        {
            var result = Outcome.Success;
            if(args.Count != 0)
            {
                result = OmniScript.RunProjectScript(ws.Project, arg(args,0).Value, script, false, out _);
                return result;
            }

            var src = ProjectFiles(ws, scope).View;
            if(result.Fail)
                return result;

            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                RunProjectScript(ws,path,script);
            }

            return result;
        }

        protected Outcome RunProjectScript(IProjectWs ws, FS.FilePath path, ScriptId script)
        {
            var srcid = path.FileName.WithoutExtension.Format();
            OmniScript.RunProjectScript(ws.Project, srcid, script, true, out var flows);
            for(var j=0; j<flows.Length; j++)
            {
                ref readonly var flow = ref skip(flows, j);
                Write(flow.Format());
            }
            return true;
        }

        protected Outcome RunProjectScript(IProjectWs ws, ScriptId script)
        {
            OmniScript.RunProjectScript(ws.Project, script, true, out var flows);
            for(var j=0; j<flows.Length; j++)
            {
                ref readonly var flow = ref skip(flows, j);
                Write(flow.Format());
            }
            return true;
        }

        static MsgPattern EmptyArgList => "No arguments specified";

        static MsgPattern ArgSpecError => "Argument specification error";
    }
}