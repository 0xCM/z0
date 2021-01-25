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

    using static Part;
    using static z;

    public struct AsmJmpRowEmitter
    {
        readonly BitBroker<JccKind,ApiInstruction> Broker;

        public IWfShell Wf {get;}

        public readonly ApiPartRoutines Source;

        public readonly FS.FilePath Target;

        readonly List<AsmJmpRow> Collected;

        [MethodImpl(Inline)]
        public AsmJmpRowEmitter(IWfShell wf, ApiPartRoutines src)
        {
            Wf = wf;
            Broker = AsmBrokers.jmp();
            Source = src;
            Collected = list<AsmJmpRow>();
            Target = Wf.Db().Table(AsmJmpRow.TableId, src.Part);
        }

        void Dispatch(in ApiInstruction fx)
        {
            var kind = AsmBuilder.jccKind(fx.Mnemonic);
            IceExtractors.jmprow(fx, kind, out var dst);
            Collected.Add(dst);
            Broker.Get(kind).Handle(fx);
        }

        const string RenderPattern = "| {0,-16} | {1,-16} | {2,-16} | {3,-16} | {4,-16} | {5,-16:g} | {6,-32}";

        static string format(in AsmJmpRow jmp)
            => string.Format(RenderPattern, jmp.Base, jmp.Source, jmp.InstructionSize, jmp.CallSite, jmp.Target, jmp.Kind, jmp.Asm);

        static string header()
            => string.Format(RenderPattern,
                nameof(AsmJmpRow.Base),
                nameof(AsmJmpRow.Source),
                nameof(AsmJmpRow.InstructionSize),
                nameof(AsmJmpRow.CallSite),
                nameof(AsmJmpRow.Target),
                nameof(AsmJmpRow.Kind),
                nameof(AsmJmpRow.Asm)
                );

        public void Emit()
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
                            case IceFlowControl.ConditionalBranch:
                            case IceFlowControl.UnconditionalBranch:
                            case IceFlowControl.IndirectBranch:
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
    }
}