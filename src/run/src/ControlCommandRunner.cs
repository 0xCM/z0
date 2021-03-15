//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    readonly struct ControlCommandRunner
    {
        public static void dispatch(params string[] args)
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

        public static bool specifies(params string[] args)
            => args.Length >=2 && args[0] == "--control";
    }
}