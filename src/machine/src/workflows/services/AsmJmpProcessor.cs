//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;
    using static z;


    public interface IJmpProcessor
    {
        void OnJA(ApiInstruction src)
        {
            term.announce();
        }

        void OnJAE(ApiInstruction src)
        {
            term.announce();
        }

        void OnJB(ApiInstruction src)
        {
            term.announce();
        }

        void OnJBE(ApiInstruction src)
        {
            term.announce();
        }
    }

    public struct AsmJmpProcessor : IJmpProcessor, IDisposable
    {
        readonly BitBroker<JmpKind,ApiInstruction> broker;

        public IWfShell Wf {get;}

        public readonly PartAsmInstructions Source;

        public readonly FilePath Target;

        readonly List<JmpInfo> Collected;

        [MethodImpl(Inline)]
        public void Connect()
        {
            broker[JmpKind.JA] = Flow.handler<ApiInstruction>(OnJA);
            broker[JmpKind.JAE] = Flow.handler<ApiInstruction>(OnJAE);
            broker[JmpKind.JB] = Flow.handler<ApiInstruction>(OnJB);
            broker[JmpKind.JBE] = Flow.handler<ApiInstruction>(OnJBE);
        }

        public void Dispose()
        {

        }

        [MethodImpl(Inline)]
        public AsmJmpProcessor(IWfShell wf, PartAsmInstructions src,  bool connect = true)
        {
            Wf = wf;
            broker = AsmBrokers.jmp();
            Source = src;
            Collected = list<JmpInfo>();
            Target = wf.AsmTables + FolderName.Define("jumps") + FileName.define(src.Part.Format(), FileExtensions.Csv) ;
            if(connect)
                Connect();
        }

        void Dispatch(in ApiInstruction fx)
        {
            var mnemonic = fx.Mnemonic;
            var kind = JmpKind.None;

            switch(fx.Mnemonic)
            {
                case Mnemonic.Ja:
                    kind = JmpKind.JA;
                    break;
                case Mnemonic.Jae:
                    kind = JmpKind.JAE;
                    break;
                case Mnemonic.Jb:
                    kind = JmpKind.JB;
                    break;
                case Mnemonic.Jbe:
                    kind = JmpKind.JE;
                    break;
                case Mnemonic.Jcxz:
                    kind = JmpKind.JCXZ;
                    break;
                case Mnemonic.Je:
                    kind = JmpKind.JE;
                    break;
                case Mnemonic.Jg:
                    kind = JmpKind.JG;
                    break;
                case Mnemonic.Jge:
                    kind = JmpKind.JGE;
                    break;
                case Mnemonic.Jl:
                    kind = JmpKind.JL;
                    break;
                case Mnemonic.Jle:
                    kind = JmpKind.JLE;
                    break;
                case Mnemonic.Jmp:
                    kind = JmpKind.JMP;
                    break;
                case Mnemonic.Jne:
                    kind = JmpKind.JNE;
                    break;
                case Mnemonic.Jno:
                    kind = JmpKind.JNO;
                    break;
                case Mnemonic.Jnp:
                    kind = JmpKind.JNP;
                    break;
                case Mnemonic.Jns:
                    kind = JmpKind.JNS;
                    break;
                case Mnemonic.Jo:
                    kind = JmpKind.JO;
                    break;
                case Mnemonic.Jp:
                    kind = JmpKind.JP;
                    break;
            }

            var dst = default(JmpInfo);
            Fill(fx, kind, ref dst);
            Collected.Add(dst);
            broker.Get(kind).Handle(fx);
        }

        public void Process()
        {
            var hosts = Source.ViewHosts;
            var kHost = Source.Length;
            for(var i=0u; i<kHost; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var kMember = host.RoutineCount;
                var members = @readonly(host.Routines);
                for(var j=0u; j<kMember; j++)
                {
                    ref readonly var member = ref skip(members,j);
                    var instructions = member.Instructions.View;
                    var iCount = instructions.Length;
                    for(var k=0u; k<iCount; k++)
                    {
                        ref readonly var fx = ref skip(instructions, k);
                        var fc = fx.Instruction.FlowControl;
                        switch(fc)
                        {
                            case FlowControl.ConditionalBranch:
                            case FlowControl.UnconditionalBranch:
                            case FlowControl.IndirectBranch:
                            Dispatch(fx);
                                break;
                        }
                    }
                }
            }

            SaveCollected();
        }

        void SaveCollected()
        {
            if(Collected.Count != 0)
            {
                var widths = JmpInfo.RenderWidths;
                var formatter = Table.rowformatter<JmpInfo>(widths);
                using var writer = Target.Writer();
                writer.WriteLine(formatter.FormatHeader());
                var jumps = @readonly(Collected.ToArray());
                var count = jumps.Length;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var jmp = ref skip(jumps,i);
                    var j=0;
                    formatter.Delimit(skip(widths,j++), jmp.Base);
                    formatter.Delimit(skip(widths,j++), jmp.Source);
                    formatter.Delimit(skip(widths,j++), jmp.FxSize);
                    formatter.Delimit(skip(widths,j++), jmp.CallSite);
                    formatter.Delimit(skip(widths,j++), jmp.Target);
                    formatter.Delimit(skip(widths,j++), jmp.Kind.Value());
                    formatter.Delimit(skip(widths,j++), jmp.Asm);
                    writer.WriteLine(formatter.Render(true));
                }
            }
        }

        void Fill(in ApiInstruction src, JmpKind jk, ref JmpInfo dst)
        {
            var target = asm.branch(src.BaseAddress, src.Instruction, 0);
            dst.Kind = jk;
            dst.Base = src.BaseAddress;
            dst.Source = src.IP;
            dst.FxSize = src.Encoded.Size;
            dst.CallSite = dst.Source + dst.FxSize;
            dst.Target = target.Target.TargetAddress;
            dst.Asm = src.FormattedInstruction;
        }

        [MethodImpl(Inline)]
        public void OnJA(ApiInstruction fx)
        {

        }

        [MethodImpl(Inline)]
        public void OnJAE(ApiInstruction fx)
        {

        }

        [MethodImpl(Inline)]
        public void OnJB(ApiInstruction fx)
        {

        }

        [MethodImpl(Inline)]
        public void OnJBE(ApiInstruction fx)
        {

        }
    }
}