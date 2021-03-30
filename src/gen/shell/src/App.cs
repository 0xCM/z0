//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    sealed class Generator : WfService<Generator>
    {
        public void Generate(string[] args)
        {
            var flow = Wf.Running("Generating");
            z.iter(args, arg => Wf.Row(arg));
            Wf.Ran(flow);
        }
    }

    class App
    {

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(WfShell.parts(Index<PartId>.Empty), args);
                Generator.create(wf).Generate(args);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }
}