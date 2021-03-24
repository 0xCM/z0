//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    public readonly struct ControlRunner
    {
        public static ControlRunner create(IEnvPaths paths)
            => new ControlRunner(paths);

        readonly IEnvPaths Paths;

        readonly ScriptRunner Runner;

        public ControlRunner(IEnvPaths paths)
        {
            Paths = paths;
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