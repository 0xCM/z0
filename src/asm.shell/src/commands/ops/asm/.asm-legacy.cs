//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        AsmToolchainSpec AsmTooling(ToolId assembler, ToolId disassembler, string id)
        {
            var spec = new AsmToolchainSpec();
            spec.Assembler = assembler;
            spec.Disassembler = disassembler;
            spec.AsmPath = AsmWs.AsmPath(id);
            spec.BinPath = AsmWs.BinPath(id);
            spec.HexPath = AsmWs.AsmHexPath(id);
            spec.HexArrayPath = AsmWs.HexArrayPath(id);
            spec.ObjKind = ObjFileKind.win64;
            spec.DisasmPath = AsmWs.DisasmPath(id, disassembler);
            spec.Analysis = AsmWs.Analysis();
            spec.ListPath = AsmWs.ListPath(id);
            spec.AsmBitMode = Bitness.b64;
            spec.EmitDebugInfo = true;
            if(spec.ObjKind > ObjFileKind.bin)
                spec.ObjPath = AsmWs.ObjPath(id);

            return spec;
        }

        [CmdOp(".asm-legacy")]
        Outcome AsmLegacy(CmdArgs args)
        {
            var count = args.Length;
            if(count ==0)
                return Assemble();

            var id = (string)args.First.Value;
            var spec = AsmTooling(Toolspace.nasm, Toolspace.bddiasm, id);
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