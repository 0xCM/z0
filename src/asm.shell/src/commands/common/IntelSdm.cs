//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static core;

    partial class AsmCmdService
    {
        // Outcome DeriveSdmOpCodeStrings()
        // {
        //     var result = Outcome.Success;
        //     var opcodes = SdmOpCodes();
        //     var count = opcodes.Length;
        //     var items = alloc<ListItem<string>>(count);
        //     for(var i=0u; i<count; i++)
        //         seek(items,i) = (i,skip(opcodes,i).OpCode);

        //     var dst = Wf.EnvPaths.Codebase(PartId.AsmData) + FS.folder("src/sources/gen");
        //     var spec = StringTables.specify("Z0.Asm", "OpCodeStrings", items);
        //     return Wf.Generators().Generate(spec,dst);
        // }

    }
}