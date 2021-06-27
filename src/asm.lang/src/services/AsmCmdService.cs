//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    using static Root;
    using static core;

    public sealed class AsmCmdService : AppCmdService<AsmCmdService>
    {
        NativeBuffer CodeBuffer;

        NativeBuffer ContextBuffer;

        AsmCmdArbiter Arbiter;

        public AsmCmdService()
        {
            CodeBuffer = Buffers.native(Pow2.T10);
            ContextBuffer = Buffers.native(size<Amd64Context>());
            Arbiter = AsmCmdArbiter.start(ContextBuffer);
        }

        protected override void Disposing()
        {
            Arbiter.Dispose();
            CodeBuffer.Dispose();
            ContextBuffer.Dispose();
        }

        [CmdOp(".env")]
        Outcome ShowEnv(CmdArgs args)
        {
            var vars = SystemEnv.vars();
            iter(vars, v => Wf.Row(v));
            return true;
        }

        [CmdOp(".thread")]
        Outcome ShowThread(CmdArgs args)
        {
            var id = Kernel32.GetCurrentThreadId();
            Wf.Row(string.Format("ThreadId:{0}", id));
            return true;
        }

        void OnJobComplete()
        {
            ref readonly var context = ref first(recover<Amd64Context>(ContextBuffer.Allocated));
            Wf.Row(EmptyString);
            Wf.Row(string.Format("RIP:{0:x}", context.Rip));
            Wf.Row(string.Format("LastBranchFromRip:{0:x}", context.LastBranchFromRip));
            Wf.Row(string.Format("RAX:{0:x}", context.Rax));
            Wf.Row(string.Format("RCX:{0:x}", context.Rcx));
            Wf.Row(string.Format("RDX:{0:x}", context.Rdx));
            Wf.Row(string.Format("RBX:{0:x}", context.Rbx));
            Wf.Row(string.Format("EFlags:{0:x}", context.EFlags.FormatBits()));
        }

        void SubmitJob(Action job)
        {
            Arbiter.Enque(job, OnJobComplete);
        }

        static uint CountA;

        static uint CountB;

        [CmdOp(".regs")]
        unsafe Outcome ShowRegVals(CmdArgs args)
        {
            static void calc()
            {
                var ts = (ulong)Timestamp.now();
                if(ts % 2 == 0)
                    CountB++;
                else
                    CountA++;
            }

            SubmitJob(calc);
            return true;
        }

        [CmdOp(".regnames")]
        Outcome ShowRegs(CmdArgs args)
        {
            var regs = AsmRegs.list(AsmCodes.GP);
            iter(regs, reg => Wf.Row(reg));
            return true;
        }

        [CmdOp(".gen-regname-provider")]
        Outcome GenRegNameProvider(CmdArgs args)
        {
            Wf.AsmModelGen().EmitRegNameProvider();
            return true;
        }

        [CmdOp(".regnames-save")]
        Outcome EmitRegNames(CmdArgs args)
        {
            var dst = Db.AppLog("regnames", FS.Cs);
            using var writer = dst.AsciWriter();
            var regs = AsmRegs.list(AsmCodes.GP);
            var bytespan = SpanRes.specify("GpRegNames", recover<RegOp,byte>(regs).ToArray());
            writer.WriteLine(bytespan.Format());
            return true;
        }

        [CmdOp(".rexbits")]
        Outcome ShowRexTable(CmdArgs args)
        {
            var bits = RexPrefix.Range();
            using var log = OpenShowLog("rexbits");
            var buffer = TextTools.buffer();
            AsmRender.RexTable(buffer);
            Show(buffer.Emit(), log);
            return true;
        }

        [CmdOp(".sdm")]
        Outcome ProcessSdm(CmdArgs args)
        {
            Wf.IntelSdmProcessor().Run();
            return true;
        }

        [CmdOp(".asm")]
        Outcome ToolChain(CmdArgs args)
        {
            if(args.Length ==0)
            {
                return (false, "No arguments were supplied");
            }
            var name = (string)args.First.Value;
            var workspace = Wf.AsmWorkspace();
            var toolchain = Wf.AsmToolchain();
            var spec = workspace.ToolchainSpec(Toolsets.nasm, Toolsets.bddiasm, name);
            return toolchain.Run(spec);
        }

        uint LoadCode(uint offset, ReadOnlySpan<byte> src)
        {
            var i0 = offset;
            var dst = CodeBuffer.Allocated;
            var j=offset;
            for(var i=0; i<src.Length; i++)
                seek(dst, offset++) = skip(src,i);
            return offset - i0;
        }

        static ReadOnlySpan<byte> min64u_64u_64u
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x72,0x04,0x48,0x8b,0xc2,0xc3,0x48,0x8b,0xc1,0xc3};

        [CmdOp(".exec")]
        unsafe void Exec(CmdArgs args)
        {
            LoadCode(0,min64u_64u_64u);
            var pCode = CodeBuffer.Address.Pointer<byte>();
            var name = "min64u";
            var f = BinaryOpDynamics.binop<ulong>(name, pCode);
            var a = 4ul;
            var b = 12ul;
            var c = f(a,b);
            var description = string.Format("{0}({1},{2})={3}", name, a, b, c);
            Wf.Row(description);
        }

        [CmdOp(".modrm")]
        Outcome ShowModRmTable(CmdArgs args)
        {
            var dst = span<char>(256*128);
            var count = AsmRender.ModRmBits(dst);
            var result = slice(dst,0,count);
            Wf.Row(result);
            return true;
        }

        [CmdOp(".core")]
        Outcome Cpu(CmdArgs args)
        {
            Wf.Row(string.Format("Cpu:{0}",Kernel32.GetCurrentProcessorNumber()));
            return true;
        }

        [CmdOp(".emit-cli-headers")]
        Outcome EmitCliHeaders()
        {
            var svc = Wf.CliEmitter();
            svc.EmitSectionHeaders(Wf.RuntimeArchive());
            return true;
        }

        [CmdOp(".emit-xed-cat")]
        Outcome EmitXedCatalog()
        {
            Wf.IntelXed().EmitCatalog();
            return true;
        }

        [CmdOp(".emit-xed-forms")]
        Outcome EmitXedForms()
        {
            var parser = XedSummaryParser.create(Wf.EventSink);
            var parsed = parser.ParseSummaries();
            Wf.Status($"Parsed {parsed.Length} summaries");
            Wf.IntelXed().EmitFormSummaries(parsed);
            return true;
        }
    }
}