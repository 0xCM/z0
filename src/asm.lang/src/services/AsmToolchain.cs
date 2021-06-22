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
            var process = ToolCmd.run(cmdline, OnStatus, OnError);
            process.Wait();

            Wf.Ran(running);

            if(errout.Count == 0)
                return true;
            else
                return (false, errout.Delimit(Chars.NL).Format());
        }

        public Outcome Disassemble(in AsmToolchainSpec spec)
        {
            var stdout = list<string>();
            var errout = list<string>();
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
                    errout.Add(data);
            }

            var tool = Wf.BdDisasm();
            var cmd = tool.Cmd(spec);
            var cmdline = tool.CmdLine(cmd);
            var running = Wf.Running(cmdline);

            using var writer = cmd.OutputFile.Writer();
            var process = ToolCmd.run(cmdline, writer, OnStatus, OnError);

            process.Wait();
            stdout.Sort();

            var collected = stdout.ViewDeposited();
            var count = collected.Length;
            var buffer = alloc<TextLine>(count);
            Lines.lines(collected, buffer);

            Wf.Ran(running);
            return errout.Count == 0;

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

            outcome = Disassemble(spec);

            if(outcome.Fail)
            {
                Wf.Error(outcome.Message);
                return outcome;
            }

            return ProcessDisassembly(spec);
        }
    }
}