//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    using static core;

    partial class LlvmEtlServices
    {
        public ReadOnlySpan<ItemList<string>> EmitListTables()
        {
            var svc = Wf.Assets();
            var input = LlvmPaths.ListSourceFiles().View;
            var count = input.Length;
            var formatter = Tables.formatter<ListItem>(ListItem.RenderWidths);
            var lists = list<ItemList<string>>();
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(input,i);
                var name = src.FileName.WithoutExtension.Format();
                var items = FS.listed(src);
                lists.Add(items);
                var dst = LlvmPaths.ListImportPath(name);
                svc.EmitTable(name, items.View, dst);
            }

            return lists.ViewDeposited();
        }
    }
}