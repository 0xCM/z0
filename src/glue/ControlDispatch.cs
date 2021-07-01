//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static core;

    public readonly struct ControlDispatch
    {
        public static void dispatch(ReadOnlySpan<string> args)
        {
            try
            {
                var count = args.Length;
                var paths = EnvPaths.create();
                var handlers = paths.ResultHandlers();

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
                        var output = runner.RunControlScript(name);
                        var processor = Tooling.processor(paths, script, handlers);
                        term.inform("Response");
                        iter(output, x => processor.Process(x));
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