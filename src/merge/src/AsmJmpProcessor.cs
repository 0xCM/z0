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
        readonly BitBroker<JccKind,ApiInstruction> broker;

        public IWfShell Wf {get;}

        public readonly ApiPartRoutines Source;

        public readonly FS.FilePath Target;

        readonly List<AsmJmpInfo> Collected;


        public void Dispose()
        {

        }

        [MethodImpl(Inline)]
        public AsmJmpProcessor(IWfShell wf, ApiPartRoutines src)
        {
            Wf = wf;
            broker = AsmBrokers.jmp();
            Source = src;
            Collected = list<AsmJmpInfo>();
            Target = Wf.Db().Table(AsmJmpInfo.TableId, src.Part);
        }

        void Dispatch(in ApiInstruction fx)
        {
            var kind = AsmSemantic.jccKind(fx.Mnemonic);
            init(fx, kind, out var dst);
            Collected.Add(dst);
            broker.Get(kind).Handle(fx);
        }

        public const string RenderPattern = "| {0,-16} | {1,-16} | {2,-16} | {3,-16} | {4,-16} | {5,-16:g} | {6,-32}";

        public static string format(in AsmJmpInfo jmp)
            => string.Format(RenderPattern, jmp.Base, jmp.Source, jmp.InstructionSize, jmp.CallSite, jmp.Target, jmp.Kind, jmp.Asm);

        public static string header()
            => string.Format(RenderPattern,
                nameof(AsmJmpInfo.Base),
                nameof(AsmJmpInfo.Source),
                nameof(AsmJmpInfo.InstructionSize),
                nameof(AsmJmpInfo.CallSite),
                nameof(AsmJmpInfo.Target),
                nameof(AsmJmpInfo.Kind),
                nameof(AsmJmpInfo.Asm)
                );

        public void Process()
        {
            var hosts = Source.View;
            uint kHost = Source.HostCount;
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
                using var writer = Target.Writer();
                writer.WriteLine(header());
                var jumps = @readonly(Collected.ToArray());
                var count = jumps.Length;
                for(var i=0u; i<count; i++)
                {
                    ref readonly var jmp = ref skip(jumps,i);
                    writer.WriteLine(format(jmp));
                }
            }
        }

        static ref AsmJmpInfo init(in ApiInstruction src, JccKind jk, out AsmJmpInfo dst)
        {
            var target = asm.branch(src.Base, src.Instruction, 0);
            dst.Kind = jk;
            dst.Base = src.Base;
            dst.Source = src.IP;
            dst.InstructionSize = src.Encoded.Size;
            dst.CallSite = dst.Source + dst.InstructionSize;
            dst.Target = target.Target.Address;
            dst.Asm = src.FormattedInstruction;
            return ref dst;
        }
    }
}