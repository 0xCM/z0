//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public sealed class Reactor : AppSingleton<Reactor,int>, IReactor
    {
        public static void dispatch(string[] args)
        {
            try
            {
                var parts = ApiQuery.parts(Index<PartId>.Empty);
                term.inform(AppMsg.status(text.prop("PartCount", parts.Components.Length)));
                var rng = Rng.@default();
                using var wf = WfRuntime.create(parts, args).WithSource(rng);
                if(args.Length == 0)
                {
                    wf.Status("usage: run <command> [options]");
                    var settings = wf.Settings;
                    wf.Row(settings.Format());
                }
                else
                {
                    wf.Status("Dispatching");
                    Reactor.init(wf).Dispatch(args);
                }

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        WfCmdBuilder Builder;

        IWfDb Db;

        protected override Reactor Init(out int state)
        {
            state = 32;
            Builder = Wf.CmdBuilder();
            Db = Wf.Db();
            return this;
        }

        public void Run(CmdLine src)
            => ToolServices.create(Wf).Run(src);

        public void Dispatch(CmdLine cmd)
        {
            ShowSupported();
            var args = cmd.Parts;
            if(args.IsEmpty)
                return;

            var name =  first(args).Content;
            var a0 = args.Length >= 2 ? args[1].Content : EmptyString;
            var a1 = args.Length >= 3 ? args[2].Content : EmptyString;
            var a2 = args.Length >= 4 ? args[3].Content : EmptyString;
            var a3 = args.Length >= 5 ? args[4].Content : EmptyString;

            switch(name)
            {
                case EmitResDataCmd.CmdName:
                    Builder.EmitResData().RunTask(Wf);
                    break;
                case RunScriptCmd.CmdName:
                    Builder.RunScript(FS.path(a0)).RunDirect(Wf);
                    break;
                case EmitAssemblyRefsCmd.CmdName:
                    Builder.EmitAssemblyRefs().RunTask(Wf);
                break;
                default:
                    Wf.Error(string.Format("Processor for {0} not found", name));
                    break;
            }
        }

        public ReadOnlySpan<CmdId> SupportedCommands()
            => Wf.Router.SupportedCommands;

        public void ShowSupported()
            => root.iter(Wf.Router.SupportedCommands, c => Wf.Status(c));
    }
}