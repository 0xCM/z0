//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial class IntelSdm
    {
        public Outcome EmitOpCodeStrings(ReadOnlySpan<SdmOpCodeDetail> src)
        {
            var result = Outcome.Success;
            var count = src.Length;
            var items = alloc<ListItem<string>>(count);
            for(var i=0u; i<count; i++)
                seek(items,i) = (i,skip(src,i).OpCode);

            var svc = Wf.StringTables();
            var dst = Wf.EnvPaths.Codebase(PartId.AsmData) + FS.folder("src/sources/gen");
            var spec = StringTables.specify("Z0.Asm", "OpCodeStrings", items);
            result = svc.Emit(spec, dst);
            return result;
        }
    }
}