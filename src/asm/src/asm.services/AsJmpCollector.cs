//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;
    using static memory;

    public sealed class AsmJmpCollector : WfService<AsmJmpCollector,AsmJmpCollector>
    {
        [MethodImpl(Inline), Op]
        static JccKind jccKind(IceMnemonic src)
            => classify(src, out JccKind _);

        [Op]
        static ref JccKind classify(IceMnemonic src, out JccKind kind)
        {
            kind = JccKind.None;
            switch(src)
            {
                case IceMnemonic.Ja:
                    kind = JccKind.JA;
                    break;
                case IceMnemonic.Jae:
                    kind = JccKind.JAE;
                    break;
                case IceMnemonic.Jb:
                    kind = JccKind.JB;
                    break;
                case IceMnemonic.Jbe:
                    kind = JccKind.JE;
                    break;
                case IceMnemonic.Jcxz:
                    kind = JccKind.JCXZ;
                    break;
                case IceMnemonic.Je:
                    kind = JccKind.JE;
                    break;
                case IceMnemonic.Jg:
                    kind = JccKind.JG;
                    break;
                case IceMnemonic.Jge:
                    kind = JccKind.JGE;
                    break;
                case IceMnemonic.Jl:
                    kind = JccKind.JL;
                    break;
                case IceMnemonic.Jle:
                    kind = JccKind.JLE;
                    break;
                case IceMnemonic.Jmp:
                    kind = JccKind.JMP;
                    break;
                case IceMnemonic.Jne:
                    kind = JccKind.JNE;
                    break;
                case IceMnemonic.Jno:
                    kind = JccKind.JNO;
                    break;
                case IceMnemonic.Jnp:
                    kind = JccKind.JNP;
                    break;
                case IceMnemonic.Jns:
                    kind = JccKind.JNS;
                    break;
                case IceMnemonic.Jo:
                    kind = JccKind.JO;
                    break;
                case IceMnemonic.Jp:
                    kind= JccKind.JP;
                    break;
                default:
                break;
            }
            return ref kind;
        }

        public Index<AsmJmpRow> Collect(ApiPartRoutines src)
        {
            var collection = root.list<AsmJmpRow>();
            var hosts = src.View;
            uint kHost = src.HostCount;
            for(var i=0u; i<kHost; i++)
            {
                ref readonly var host = ref skip(hosts,i);
                var rCount = host.RoutineCount;
                var routines = @readonly(host.Routines);
                for(var j=0u; j<rCount; j++)
                {
                    ref readonly var member = ref skip(routines,j);
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
                                var kind = jccKind(fx.Mnemonic);
                                IceExtractors.jmprow(fx, kind, out var dst);
                                collection.Add(dst);
                            break;
                        }
                    }
                }
            }

            return collection.ToArray();
        }
    }
}