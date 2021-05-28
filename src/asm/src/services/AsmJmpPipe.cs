//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    using K = JmpKind;

    public sealed class AsmJmpPipe : AppService<AsmJmpPipe>
    {
        // public ReadOnlySpan<AsmJmpRow> EmitRows(ReadOnlySpan<ApiPartRoutines> src)
        // {
        //     var dst = Db.TableDir<AsmJmpRow>();
        //     return EmitRows(src,dst);
        // }

        // public ReadOnlySpan<AsmJmpRow> EmitRows(ReadOnlySpan<ApiPartRoutines> src, FS.FolderPath dst)
        // {
        //     var rows = list<AsmJmpRow>();
        //     var count = src.Length;
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var routines = ref skip(src,i);
        //         var path = Db.Table(dst, AsmJmpRow.TableId, routines.Part);
        //         rows.AddRange(EmitJmpRows(routines, path));
        //     }

        //     return rows.ViewDeposited();
        // }

        public ReadOnlySpan<AsmJmpRow> EmitRows(ReadOnlySpan<AsmRoutine> src, FS.FilePath dst)
        {
            var rows = Collect(src);
            Store(rows, dst);
            return rows;
        }

        // Index<AsmJmpRow> EmitJmpRows(ApiPartRoutines src, FS.FilePath dst)
        // {
        //     var rows = Collect(src);
        //     Store(rows, dst);
        //     return rows;
        // }

        void Store(ReadOnlySpan<AsmJmpRow> src, FS.FilePath dst)
        {
            if(src.Length != 0)
            {
                var flow = Wf.EmittingTable<AsmJmpRow>(dst);
                var formatter = Tables.formatter<AsmJmpRow>(AsmJmpRow.RenderWidths);
                using var writer = dst.Writer();
                writer.WriteLine(formatter.FormatHeader());
                var count = src.Length;
                for(var i=0u; i<count; i++)
                    writer.WriteLine(formatter.Format(skip(src,i)));
                Wf.EmittedTable<AsmJmpRow>(flow, count, dst);
            }
        }

        // Index<AsmJmpRow> Collect(ApiPartRoutines src)
        // {
        //     var collection = root.list<AsmJmpRow>();
        //     var hosts = src.View;
        //     uint kHost = src.HostCount;
        //     for(var i=0u; i<kHost; i++)
        //     {
        //         ref readonly var host = ref skip(hosts,i);
        //         var rCount = host.RoutineCount;
        //         var routines = host.Members.View;
        //         for(var j=0u; j<rCount; j++)
        //         {
        //             ref readonly var member = ref skip(routines,j);
        //             var instructions = member.Instructions.View;
        //             var iCount = instructions.Length;
        //             for(var k=0u; k<iCount; k++)
        //             {
        //                 ref readonly var fx = ref skip(instructions, k);
        //                 var fc = fx.Instruction.FlowControl;
        //                 switch(fc)
        //                 {
        //                     case IceFlowControl.ConditionalBranch:
        //                     case IceFlowControl.IndirectBranch:
        //                     case IceFlowControl.UnconditionalBranch:
        //                         classify(fx.Mnemonic, out var kind);
        //                         jmprow(fx, kind, out var dst);
        //                         collection.Add(dst);
        //                     break;
        //                 }
        //             }
        //         }
        //     }

        //     return collection.ToArray();
        // }

        ReadOnlySpan<AsmJmpRow> Collect(ReadOnlySpan<AsmRoutine> src)
        {
            var dst = list<AsmJmpRow>();
            for(var i=0u; i<src.Length; i++)
            {
                var routine = root.require(skip(src, i));
                var count = routine.InstructionCount;
                var instructions = routine.Instructions.View;
                for(var j=0; j<count; j++)
                {
                    ref readonly var instruction = ref skip(instructions, j);
                    switch(instruction.Instruction.FlowControl)
                    {
                        case IceFlowControl.ConditionalBranch:
                        case IceFlowControl.IndirectBranch:
                        case IceFlowControl.UnconditionalBranch:
                            classify(instruction.Mnemonic, out var kind);
                            jmprow(instruction, kind, out var row);
                            dst.Add(row);
                        break;
                    }
                }
            }

            return dst.ViewDeposited();
        }

        [Op]
        static ref AsmJmpRow jmprow(in ApiInstruction src, JmpKind jk, out AsmJmpRow dst)
        {
            dst.SourcePart = src.Part;
            dst.Block = src.BaseAddress;
            dst.Kind = jk;
            dst.Source = src.IP;
            dst.InstructionSize = src.Encoded.Size;
            dst.CallSite = dst.Source + dst.InstructionSize;
            dst.Target = IceExtractors.branch(dst.Source, src.Instruction, 0).Target.Address;
            dst.Instruction = src.Statment;
            dst.Encoded = src.Encoded;
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