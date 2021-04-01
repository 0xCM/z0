//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using K = JmpKind;

    public sealed class AsmJmpCollector : WfService<AsmJmpCollector>
    {
        [MethodImpl(Inline), Op]
        static K jmpKind(IceMnemonic src)
            => classify(src, out K _);

        [Op]
        static ref K classify(IceMnemonic src, out K kind)
        {
            kind = K.None;
            switch(src)
            {
                case IceMnemonic.Jmp:
                    kind = K.JMP;
                    break;

                case IceMnemonic.Ja:
                    kind = K.JA;
                    break;
                case IceMnemonic.Jae:
                    kind = K.JAE;
                    break;

                case IceMnemonic.Jb:
                    kind = K.JB;
                    break;
                case IceMnemonic.Jbe:
                    kind = K.JBE;
                    break;

                case IceMnemonic.Jcxz:
                    kind = K.JCXZ;
                    break;

                case IceMnemonic.Je:
                    kind = K.JE;
                    break;
                case IceMnemonic.Jne:
                    kind = K.JNE;
                    break;

                case IceMnemonic.Jg:
                    kind = K.JG;
                    break;
                case IceMnemonic.Jge:
                    kind = K.JGE;
                    break;

                case IceMnemonic.Jl:
                    kind = K.JL;
                    break;
                case IceMnemonic.Jle:
                    kind = K.JLE;
                    break;

                case IceMnemonic.Jo:
                    kind = K.JO;
                    break;
                case IceMnemonic.Jno:
                    kind = K.JNO;
                    break;

                case IceMnemonic.Jp:
                    kind= K.JP;
                    break;
                case IceMnemonic.Jnp:
                    kind = K.JNP;
                    break;

                case IceMnemonic.Js:
                    kind= K.JS;
                    break;
                case IceMnemonic.Jns:
                    kind = K.JNS;

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
                            case IceFlowControl.IndirectBranch:
                            case IceFlowControl.UnconditionalBranch:
                                var kind = jmpKind(fx.Mnemonic);
                                jmprow(fx, kind, out var dst);
                                collection.Add(dst);
                            break;
                        }
                    }
                }
            }

            return collection.ToArray();
        }

        [Op]
        public static ref AsmJmpRow jmprow(in ApiInstruction src, JmpKind jk, out AsmJmpRow dst)
        {
            dst.Kind = jk;
            dst.Base = src.BaseAddress;
            dst.Source = src.IP;
            dst.InstructionSize = src.Encoded.Size;
            dst.CallSite = dst.Source + dst.InstructionSize;
            dst.Target = IceExtractors.branch(dst.Source, src.Instruction, 0).Target.Address;
            dst.Asm = src.FormattedInstruction;
            return ref dst;
        }

    }
}