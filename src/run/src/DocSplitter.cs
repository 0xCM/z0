//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static core;
    using static Root;

    public class DocSplitter : Service<DocSplitter>
    {

        AsmWorkspace Workspace;

        RecordSet<SplitSpec> Specs;

        protected override void Initialized()
        {
            Workspace = Context.AsmWorkspace();
            var pipe = SplitSpecPipe.Service;
            var outcome = pipe.Load(SpecPath, out Specs);
            if(outcome.Fail)
            {

            }

        }


        FS.FilePath SpecPath
            => Workspace.DocRoot() + FS.file("splits", FS.Csv);

    }
}