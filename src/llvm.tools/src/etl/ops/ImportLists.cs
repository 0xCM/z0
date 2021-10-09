//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    partial class EtlWorkflow
    {
        public Outcome ImportLists()
        {
            var svc = Wf.Assets();
            var input = LlvmPaths.ListSourceFiles().View;
            var count = input.Length;
            var formatter = Tables.formatter<ListItem>(ListItem.RenderWidths);
            var result = list<ListItem>();
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(input,i);
                var name = src.FileName.WithoutExtension.Format();
                var items = FS.listed(src).View;
                var mCount = items.Length;
                var dst = LlvmPaths.ListImportPath(name);
                svc.EmitTable(name, items, dst);
            }
            return true;
        }
    }
}