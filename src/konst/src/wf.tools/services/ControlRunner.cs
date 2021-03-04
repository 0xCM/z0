//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;

    public readonly struct ControlRunner
    {
        public static ControlRunner create(IDbPaths paths)
            => new ControlRunner(paths);

        readonly IDbPaths Db;

        readonly ScriptRunner Runner;

        public ControlRunner(IDbPaths paths)
        {
            Db = paths;
            Runner = ScriptRunner.create();
        }

        public void Run(IToolResultProcessor processor, FS.FilePath script)
        {
            var outcome = Runner.RunControlScript(script.FileName);
            if(outcome)
            {
                term.inform("Response");
                root.iter(outcome.Data, x => processor.Process(x));
            }
        }
    }
}