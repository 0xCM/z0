//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        AsmToolchainSpec AsmTooling(ToolId assembler, ToolId disassembler, FS.FilePath src)
        {
            var spec = new AsmToolchainSpec();
            var id = src.FileName.WithoutExtension.Format();
            spec.Assembler = assembler;
            spec.Disassembler = disassembler;
            spec.AsmPath = src;
            spec.BinPath = AsmWs.BinPath(id);
            spec.HexPath = AsmWs.AsmHexPath(id);
            spec.HexArrayPath = AsmWs.HexArrayPath(id);
            spec.ObjKind = ObjFileKind.win64;
            spec.DisasmPath = AsmWs.DisasmPath(id, disassembler);
            spec.Analysis = AsmWs.Analysis();
            spec.ListPath = AsmWs.ListPath(id);
            spec.AsmBitMode = Bitness.b64;
            spec.EmitDebugInfo = true;
            spec.ObjPath = AsmWs.ObjPath(id);
            return spec;
        }

        Outcome Assemble()
        {
            var src = State.Files(FS.Asm).View;
            var result = Outcome.Success;
            var count = src.Length;
            var output = list<FS.FilePath>();
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var spec = AsmTooling(Toolspace.nasm, Toolspace.bddiasm, path);
                result = AsmToolchain.Run(spec);
                if(result.Fail)
                    return result;

                output.Add(path);
                output.Add(spec.BinPath);
                output.Add(spec.ObjPath);
            }

            Files(output.ToArray(), false);

            return DumpObjects();
        }
    }
}