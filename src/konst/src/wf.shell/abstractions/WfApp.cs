//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    public abstract class WfApp<A> : WfService<A>
        where A : WfApp<A>, new()
    {
        public static void run(string[] args, params PartId[] parts)
        {
            using var wf = WfShell.create(WfShell.parts(parts), args);
            using var app = new A();
            app.Init(wf);
            var name = typeof(A).Name;
            var flow = wf.Running(text.msg("Running application {0}", name));
            app.Run();
            wf.Ran(flow, text.msg("Ran application {0}", name));

        }

        protected abstract void Run();
    }

}