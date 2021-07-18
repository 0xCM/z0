//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public sealed class AsmToolchain : AppService<AsmToolchain>
    {
        Outcome Exec(in CmdLine cmd)
        {
            var stdout = list<string>();
            var errout = list<string>();

            void OnStatus(in string data)
            {
                if(nonempty(data))
                    stdout.Add(data);
            }

            void OnError(in string data)
            {
                if(nonempty(data))
                    errout.Add(data);
            }

            var cmdrun = Wf.Running(cmd);
            var cmdproc = ScriptProcess.run(cmd, OnStatus, OnError);
            cmdproc.Wait();
            Wf.Ran(cmdrun);

            if(errout.Count == 0)
                return true;
            else
                return (false, errout.Delimit(Chars.NL).Format());
        }

        public Outcome Assemble(in AsmToolchainSpec spec)
        {
            var tool = Wf.Nasm();
            var result = Exec(tool.Command(spec.AsmPath, tool.OutFile(spec.BinPath, ObjFileKind.bin), spec.ListPath));
            if(result.Ok && CanEmitObj(spec))
            {
                var debug = CalcDebugOptions(spec);
                result = Exec(tool.Command(spec.AsmPath, tool.OutFile(spec.ObjPath, spec.ObjKind), debug));
            }
            return result;
        }

        public ByteSize EmitHexText(ReadOnlySpan<byte> src, ushort rowsize, FS.FilePath dst)
        {
            const char Delimiter = Chars.Pipe;
            var @base = MemoryAddress.Zero;
            var size = src.Length;
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.AsciWriter();
            var formatter = HexDataFormatter.create(@base, rowsize, false);
            var buffer = alloc<byte>(rowsize);
            var parts = size/rowsize;
            var offset = @base;
            var data = default(ReadOnlySpan<byte>);
            for(var i=0; i<parts; i++)
            {
                data = slice(src,offset,rowsize);
                writer.WriteLine(formatter.FormatLine(data, offset, Delimiter));
                offset += rowsize;
            }

            var remainder = size % rowsize;
            if(remainder != 0)
            {
                data = slice(src, offset, remainder);
                writer.WriteLine(formatter.FormatLine(data, offset, Delimiter));
            }
            Wf.EmittedFile(flow,size);
            return size;
        }

        public Outcome ProcessAssembly(in AsmToolchainSpec src)
        {
            var outpath = src.BinPath;
            var data = outpath.ReadBytes();
            EmitHexText(data,40,src.HexPath);
            return true;
        }

        public Outcome Disassemble(in AsmToolchainSpec spec)
        {
            var tool = Wf.BdDisasm();
            var cmd = tool.Cmd(spec);
            var cmdline = tool.CmdLine(cmd);
            return Run(cmdline, cmd.OutputPath);
        }

        public Outcome ProcessDisassembly(in AsmToolchainSpec spec)
        {
            var parser = Wf.DbDiasmProcessor();
            parser.ParseDisassembly(spec.DisasmPath, spec.Analysis);
            return true;
        }

        public Outcome Run(in AsmToolchainSpec spec)
        {
            var outcome = Outcome.Success;
            outcome = Assemble(spec);
            if(outcome.Fail)
            {
                Wf.Error(outcome.Message);
                return outcome;
            }

            outcome = ProcessAssembly(spec);
            if(outcome.Fail)
            {
                Wf.Error(outcome.Message);
                return outcome;
            }

            outcome = Disassemble(spec);
            if(outcome.Fail)
            {
                Wf.Error(outcome.Message);
                return outcome;
            }

            return ProcessDisassembly(spec);
        }

        Outcome Run(CmdLine cmdline, FS.FilePath dst)
        {
            var stdout = list<string>();
            var errout = list<string>();
            var running = Wf.Running(cmdline);

            void OnStatus(in string data)
            {
                if(nonempty(data))
                    stdout.Add(data);
            }

            void OnError(in string data)
            {
                if(nonempty(data))
                    errout.Add(data);
            }

            using var writer = dst.AsciWriter();
            var process = ScriptProcess.run(cmdline, writer, OnStatus, OnError);
            process.Wait();
            stdout.Sort();
            Wf.Ran(running);

             if(errout.Count == 0)
                return true;
            else
                return (false, errout.Delimit(Chars.NL).Format());
       }

        NasmDebugOptions CalcDebugOptions(in AsmToolchainSpec spec)
        {
            if(!spec.EmitDebugInfo)
                return 0;

            var options = NasmDebugOptions.g;

            if(spec.ObjKind == ObjFileKind.bin)
                return options;

            if(spec.ObjKind == ObjFileKind.obj)
            {
                if((byte)spec.AsmBitMode <= 32)
                    return options | NasmDebugOptions.Win32DbgFormat;
                else
                    return options | NasmDebugOptions.Win64DbgFormat;
            }

            return options;
        }

        bool CanEmitObj(in AsmToolchainSpec spec)
            => spec.ObjKind != 0 && spec.ObjKind != ObjFileKind.bin && spec.ObjPath.IsNonEmpty;
    }
}