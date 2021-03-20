//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public enum CommandSwitchKind
    {
        None = 0,

        [Alias("control")]
        Control,

        [Alias("wf")]
        Workflow
    }

    public readonly struct CommandSwitch
    {
       public static bool control(params string[] args)
            => args.Length >=2 && args[0] == "--control";

       public static bool workflow(params string[] args)
            => args.Length >=2 && args[0] == "--wf";

        public static CommandSwitchKind kind(params string[] args)
        {
            if(control(args))
                return CommandSwitchKind.Control;
            else if(workflow(args))
                return CommandSwitchKind.Workflow;
            else
                return 0;
        }
    }

    readonly struct DefaultCommandDispatcher
    {
        public static void dispatch(string[] args)
        {
            try
            {
                var parts = WfShell.parts(Index<PartId>.Empty);
                term.inform(AppMsg.status(text.prop("PartCount", parts.Components.Length)));
                var rng = Rng.@default();
                using var wf = WfShell.create(parts, args).WithRandom(rng);
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

    }

    readonly struct WorkflowCommandDispatcher
    {
        public static void dispatch(string[] args)
        {


        }
    }

    readonly struct ControlCommandDispatcher
    {
        public static void dispatch(params string[] args)
        {
            try
            {
                var count = args.Length;
                var paths = DbPaths.create();
                var _args = slice(span(args),1).ToArray();

                for(var i=1; i<count; i++)
                {
                    var name = FS.file(args[i]);
                    term.inform(name);

                    if(!name.HasExtension)
                        name = name.WithExtension(FS.Extensions.Cmd);

                    var script = paths.ControlScript(name);
                    if(script.Exists)
                    {
                        var runner = ScriptRunner.create();
                        var outcome = runner.RunControlScript(name);
                        if(outcome)
                        {
                            var processor = Tools.processor(paths, script);
                            term.inform("Response");
                            root.iter(outcome.Data, x => processor.Process(x));
                        }
                    }
                    else
                    {
                        term.error($"The script {script.ToUri()} does not exist");
                    }
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }
}