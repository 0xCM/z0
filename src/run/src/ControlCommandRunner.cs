//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;


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
                var paths = EnvPaths.create();
                var _args = slice(span(args),1).ToArray();

                for(var i=1; i<count; i++)
                {
                    var name = FS.file(args[i]);
                    term.inform(name);

                    if(!name.HasExtension)
                        name = name.WithExtension(FS.Cmd);

                    var script = paths.ControlScript(name);
                    if(script.Exists)
                    {
                        var runner = ScriptRunner.create(paths);
                        var outcome = runner.RunControlScript(name);
                        if(outcome)
                        {
                            var processor = ToolServices.processor(paths, script);
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