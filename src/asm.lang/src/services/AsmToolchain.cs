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
        public Outcome Assemble(in AsmToolchainSpec spec)
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

            var tool = Wf.Nasm();
            var target = tool.OutFile(spec.BinPath, spec.BinKind);
            var cmdline = tool.cmd(spec.AsmPath, target, spec.ListPath);
            var running = Wf.Running(cmdline);
            var process = ScriptProcess.run(cmdline, OnStatus, OnError);
            process.Wait();

            Wf.Ran(running);

            if(errout.Count == 0)
                return true;
            else
                return (false, errout.Delimit(Chars.NL).Format());
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
            var dst = src.Analysis + (outpath.FileName + FS.Hex);
            EmitHexText(data,40,dst);
            return true;
        }

        public Outcome Disassemble(in AsmToolchainSpec spec)
        {
            var tool = Wf.BdDisasm();
            var cmd = tool.Cmd(spec);
            var cmdline = tool.CmdLine(cmd);
            return Run(cmdline, cmd.DisasmPath);
        }

        public Outcome ProcessDisassembly(in AsmToolchainSpec spec)
        {
            var parser = Wf.DbDiasmProcessor();
            parser.ParseDisassembly(spec.DisasmPath, spec.Analysis);
            return true;
        }

        public Outcome Run(in AsmToolchainSpec spec)
        {
            var stdout = list<string>();
            var counter = 0u;
            var outcome = Outcome.Success;

            void OnStatus(in string data)
            {
                if(nonempty(data))
                    stdout.Add(data);
            }

            void OnError(in string data)
            {
                if(nonempty(data))
                    Wf.Error(data);
            }

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

            outcome = ProcessDisassembly(spec);

            return outcome;
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
    }
}