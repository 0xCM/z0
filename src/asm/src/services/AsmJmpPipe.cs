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
    using static AsmRecords;

    using K = JmpKind;

    public sealed class AsmJmpPipe : AppService<AsmJmpPipe>
    {
        public Index<AsmJmpRow> EmitRows(ReadOnlySpan<ApiPartRoutines> routines)
        {
            var dst = root.list<AsmJmpRow>();
            var count = routines.Length;
            for(var i=0; i<count; i++)
                dst.AddRange(EmitJmpRows(routines[i]));
            var rows = dst.ToArray();
            return rows;
        }

        public Index<AsmJmpRow> EmitJmpRows(ApiPartRoutines src)
        {
            var collector = Wf.AsmJmpPipe();
            var rows = collector.Collect(src);
            Store(rows, Db.Table(AsmJmpRow.TableId, src.Part));
            return rows;
        }

        void Store(ReadOnlySpan<AsmJmpRow> src, FS.FilePath dst)
        {
            if(src.Length != 0)
            {
                var flow = Wf.EmittingTable<AsmJmpRow>(dst);
                var formatter = Tables.formatter<AsmJmpRow>();
                using var writer = dst.Writer();
                writer.WriteLine(formatter.FormatHeader());
                var count = src.Length;
                for(var i=0u; i<count; i++)
                    writer.WriteLine(formatter.Format(skip(src,i)));
                Wf.EmittedTable<AsmJmpRow>(flow, count, dst);
            }
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
                var routines = host.Members.View;
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
                                classify(fx.Mnemonic, out var kind);
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
            dst.Asm = src.Statment;
            return ref dst;
        }

        [Op]
        static ref JmpKind classify(IceMnemonic src, out JmpKind kind)
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
    }
}