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
        [CmdOp(".sdm-opcode-strings")]
        public Outcome SdmOpCodeStrings(CmdArgs args)
        {
            var result = Outcome.Success;

            result = LoadSdmOpCodeDetails(out var opcodes);
            if(result.Fail)
                return result;

            var count = opcodes.Length;
            var items = alloc<ListItem<string>>(count);
            for(var i=0u; i<count; i++)
                seek(items,i) = (i,skip(opcodes,i).OpCode);

            var spec = StringTables.specify("Z0.Asm", "OpCodeStrings", items);
            var dst = Env.DevRoot + FS.folder("z0/src/asm.data/src/sources/gen");
            result = EmitStringTable(spec, dst);

            return result;
        }
    }
}