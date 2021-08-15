//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-legacy")]
        Outcome AsmLegacy(CmdArgs args)
        {
            var count = args.Length;
            if(count ==0)
                return Assemble();

            var id = (string)args.First.Value;
            var spec = AsmWs.ToolchainSpec(Toolspace.nasm, Toolspace.bddiasm, id);
            if(count > 1)
                Enums.parse(args[1].Value, out spec.AsmBitMode);

            var result = AsmToolchain.Run(spec);
            if(result)
            {
                var binfile = AsmWs.BinPath(id);
                var objfile = AsmWs.ObjPath(id);
                var asmfile = AsmWs.AsmPath(id);
                var hexfile = AsmWs.HexArrayPath(id);
                var dumps = AsmWs.DumpOut().Create();
                _Assembled = binfile.ReadBytes();
                RoutineName = id;
                Files(new FS.FilePath[]{binfile, objfile, asmfile, hexfile}, false);
                result = LlvmObjDump(objfile, dumps);
                if(!result)
                    return result;
                result = LlvmMcDisasm(hexfile, dumps);
            }
            return result;
        }
    }
}