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

    public struct AsmJmpProcessor : IDisposable
    {
        readonly BitBroker<JmpKind,ApiInstruction> broker;

        public IWfShell Wf {get;}

        public readonly ApiPartRoutines Source;

        public readonly FS.FilePath Target;

        readonly List<AsmJmpRecord> Collected;


        public void Dispose()
        {

        }

        [MethodImpl(Inline)]
        public AsmJmpProcessor(IWfShell wf, ApiPartRoutines src,  bool connect = true)
        {
            Wf = wf;
            broker = AsmBrokers.jmp();
            Source = src;
            Collected = list<AsmJmpRecord>();
            //Target = wf.AsmTables + FS.folder("jumps") + FS.file(src.Part.Format(), FileExtensions.Csv) ;
            Target = Wf.Db().Table(AsmJmpRecord.TableId, src.Part);
        }

        void Dispatch(in ApiInstruction fx)
        {
            var mnemonic = fx.Mnemonic;
            var kind = AsmJmpClassifier.classify(fx.Mnemonic);

            var dst = default(AsmJmpRecord);
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
                var formatter = TableRows.formatter<AsmJmpRecord>(AsmJmpRecord.RenderWidths);
                using var writer = Target.Writer();
                writer.WriteLine(formatter.FormatHeader());
                var jumps = @readonly(Collected.ToArray());
                var count = jumps.Length;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var jmp = ref skip(jumps,i);
                    var rendered = string.Format(AsmJmpRecord.RenderPattern, jmp.Base, jmp.Source, jmp.InstructionSize, jmp.CallSite, jmp.Target, jmp.Kind, jmp.Asm);
                    writer.WriteLine(rendered);
                }
            }
        }

        void Fill(in ApiInstruction src, JmpKind jk, ref AsmJmpRecord dst)
        {
            var target = asm.branch(src.Base, src.Instruction, 0);
            dst.Kind = jk;
            dst.Base = src.Base;
            dst.Source = src.IP;
            dst.InstructionSize = src.Encoded.Size;
            dst.CallSite = dst.Source + dst.InstructionSize;
            dst.Target = target.Target.Target;
            dst.Asm = src.FormattedInstruction;
        }
    }
}