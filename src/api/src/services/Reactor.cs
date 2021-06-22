//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    public sealed class Reactor : GlobalService<Reactor,int>
    {
        public static void dispatch(string[] args)
        {
            try
            {
                var parts = ApiRuntimeLoader.parts(array<PartId>());
                term.inform(AppMsg.status(TextProp.define("PartCount", parts.Components.Length)));
                var rng = Rng.@default();
                using var wf = WfAppLoader.load(parts, args).WithSource(rng);
                if(args.Length == 0)
                {
                    wf.Status("usage: run <command> [options]");
                    var settings = wf.Settings;
                    wf.Row(settings.Format());
                }
                else
                {
                    wf.Status("Dispatching");
                    Reactor.create(wf).Dispatch(args);
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
            => Tooling.create(Wf).Run(src);

        public void Dispatch(CmdLine cmd)
        {
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
                case RunScriptCmd.CmdName:
                    Builder.RunScript(FS.path(a0)).RunDirect(Wf);
                    break;
                default:
                    Wf.Error(string.Format("Processor for {0} not found", name));
                    break;
            }
        }
    }
}