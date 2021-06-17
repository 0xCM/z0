//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class IntelSdmProcessor
    {
        public void CreateCombinedToc()
        {
            var specs = LoadSplitSpecs();
            var count = specs.Length;
            var paths = span<FS.FilePath>(count);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref skip(specs,i);
                if(spec.Unit.Contains("TOC"))
                    seek(paths, counter++) = DocExtractPath(spec.Unit, FS.Txt);
            }

            var src = slice(paths,0,counter);
            var dst = CombinedTocPath();
            iter(src, x => Wf.Row(x));
            var flow = Wf.Running(string.Format("Creating combined toc from {0} source files", src.Length));
            DocServices.CombineDocs(src, dst);
            Wf.Ran(flow);
        }
    }
}