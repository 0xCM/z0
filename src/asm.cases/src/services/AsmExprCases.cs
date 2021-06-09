// //-----------------------------------------------------------------------------
// // Copyright   :  (c) Chris Moore, 2020
// // License     :  MIT
// //-----------------------------------------------------------------------------
// namespace Z0.Asm
// {
//     using System;
//     using System.Runtime.CompilerServices;
//     using System.IO;

//     using static AsmRegCodes;
//     using static Root;
//     using static core;

//     public class AsmExprCases : AppService<AsmExprCases>
//     {
//         readonly AsmX asmx;

//         Index<string> _Buffer;

//         uint Position;

//         public AsmExprCases()
//         {
//             asmx = AsmX.create();
//             _Buffer = alloc<string>(256);
//             Position = 0;
//         }

//         [MethodImpl(Inline)]
//         Index<string> Buffer()
//         {
//             Clear();
//             return _Buffer;
//         }

//         [MethodImpl(Inline)]
//         Index<string> Buffer(bool clear)
//         {
//             if(clear)
//                 Clear();
//             return _Buffer;
//         }

//         void Clear()
//         {
//             _Buffer.Clear();
//             Position = 0;
//         }

//         [MethodImpl(Inline)]
//         Symbols<Gp8> Gp8Regs()
//             => asmx.SymbolSet.Gp8Regs();

//         [MethodImpl(Inline)]
//         Symbols<Gp16> Gp16Regs()
//             => asmx.SymbolSet.Gp16Regs();

//         [MethodImpl(Inline)]
//         Symbols<Gp32> Gp32Regs()
//             => asmx.SymbolSet.Gp32Regs();

//         [MethodImpl(Inline)]
//         Symbols<Gp64> Gp64Regs()
//             => asmx.SymbolSet.Gp64Regs();

//         void case_and_r8_r8(AsmOcPrototype id)
//         {
//             var casename = CaseName(id);
//             var flow = Wf.Running(casename);
//             var regs = Gp8Regs();
//             var grid = Symbols.grid(regs,regs);
//             var rows = grid.RowCount;
//             var cols = grid.ColCount;
//             var count = rows * cols;
//             var buffer = Buffer();
//             var k=0;
//             var defining = Wf.Running(Msg.DefiningExpressions.Format(count,id));
//             for(var i=0u; i<rows; i++)
//             {
//                 for(var j=0u; j<cols; j++)
//                 {
//                     var pair = grid.Pair(i,j);
//                     buffer[k++] = asmx.and(pair.Left, pair.Right);
//                 }
//             }
//             Wf.Ran(defining, Msg.DefinedExpressions.Format(count,id));
//             //Assemble(id, slice(buffer.View,0, count));
//             var dst = text.buffer();
//             for(var i=0; i<count; i++)
//                 dst.AppendLine(src[i]);
//             Assemble(id, asm.source(dst.Emit()));

//             Wf.Ran(flow);
//         }

//         void case_move_r64_imm64(AsmOcPrototype id)
//         {
//             const ulong a1 = 0x7ffa9930f380;
//             var casename = CaseName(id);
//             var flow = Wf.Running(casename);
//             var regs = Gp64Regs();
//             var count = regs.Count;
//             var buffer = Buffer();
//             var defining = Wf.Running(Msg.DefiningExpressions.Format(count,id));
//             for(byte i=0; i<count; i++)
//                 buffer[i] = asmx.mov(regs[i], a1);
//             Wf.Ran(defining, Msg.DefinedExpressions.Format(count,id));
//             //Assemble(id, slice(buffer.View,0, count));
//             var dst = text.buffer();
//             for(var i=0; i<count; i++)
//                 dst.AppendLine(src[i]);
//             Assemble(id, asm.source(dst.Emit()));

//             Wf.Ran(flow);
//         }

//         void case_cmp_r8_imm8(AsmOcPrototype id)
//         {
//             const byte a1 = 0x3C;
//             var regs = Gp8Regs();
//             Generate(id, (byte)regs.Count, i => asmx.cmp(regs[i], a1));
//         }

//         void case_cmp_r16_r16(AsmOcPrototype id)
//         {
//             var left = Gp16Regs();
//             var right = Gp16Regs();
//             var count = (byte)left.Count;
//             for(byte i=0; i<count; i++)
//                 Enqueue(id, count, j => asmx.cmp(left[i], right[j]));
//             Assemble(id);
//         }

//         void case_cmp_r32_r32(AsmOcPrototype id)
//         {
//             var left = Gp32Regs();
//             var right = Gp32Regs();
//             var count = (byte)left.Count;
//             for(byte i=0; i<count; i++)
//                 Enqueue(id, count, j => asmx.cmp(left[i], right[j]));
//             Assemble(id);
//         }

//         void case_move_r64_imm64_example(AsmOcPrototype id)
//         {
//             const ulong Imm64 = 0x7ffa9930f380;

//             var casename = CaseName(id);
//             var regs = Gp64Regs();
//             var count = regs.Count;
//             var buffer = Buffer();
//             for(byte i=0; i<count; i++)
//                 buffer[i]= asmx.mov(regs[i], Imm64);

//             var statement = asm.statement("mov rcx,7ffa9930f380h");
//             AsmExprEncoding expect = (statement.Content,  AsmBytes.parse("48 b9 80 f3 30 99 fa 7f 00 00"));
//             var mov = AsmEncoderPrototype.mov(AsmOp.rcx, Imm64);
//             AsmExprEncoding actual = (statement.Content, mov);
//             Wf.Row(expect.Equals(actual));
//         }

//         string CaseName(AsmOcPrototype id)
//             => id.ToString();

//         void Enqueue(AsmOcPrototype id, byte count, Func<byte,AsmExpr> f)
//         {
//             var buffer = Buffer(false);
//             for(byte i=0; i<count; i++)
//                 buffer[Position++] = f(i);
//         }

//         void Generate(AsmOcPrototype id, byte count, Func<byte,AsmExpr> f)
//         {
//             var casename = CaseName(id);
//             var flow = Wf.Running(casename);
//             var defining = Wf.Running(Msg.DefiningExpressions.Format(count,id));
//             var buffer = Buffer();
//             for(byte i=0; i<count; i++)
//                 buffer[i] = f(i);
//             Wf.Ran(defining, Msg.DefinedExpressions.Format(count,id));
//             var dst = text.buffer();
//             for(var i=0; i<count; i++)
//                 dst.AppendLine(src[i]);
//             Assemble(id, asm.source(dst.Emit()));
//             Wf.Ran(flow);
//         }

//         void Assemble(AsmOcPrototype id)
//         {
//             var buffer = Buffer(false).View;
//             var dst = text.buffer();
//             var count = Position;
//             for(var i=0; i<count; i++)
//                 dst.AppendLine(src[i]);
//             Assemble(id, asm.source(dst.Emit()));
//             Clear();
//         }

//         void Assemble(AsmOcPrototype id, AsmSourceBlock input)
//         {
//             var subject = Tables.identify<AsmAssembly>();
//             var casedir = Db.CaseDir(subject,id).Create();
//             var casename = CaseName(id);
//             var tool = Wf.Nasm();
//             var target = casedir + FS.file(casename, FS.Asm);
//             var emitting = Wf.EmittingFile(target);
//             File.WriteAllText(target.Name, input.Format());

//             Wf.EmittedFile(emitting,1);

//             var script = tool.CreateCaseScript(casename, casedir);
//             var runner = Wf.ScriptRunner();
//             var outcome = runner.RunScript(script.Path);
//             if(outcome)
//                 root.iter(outcome.Data, line => Wf.Row(line));
//             else
//                 Wf.Error(outcome.Message);

//             var assembled = tool.LoadAssembledAsm(casedir, casename);
//             var tablepath = Db.CasePath(subject, id, id, FS.Csv);
//             SaveTable(id, assembled, tablepath);
//         }

//         void SaveTable(AsmOcPrototype id, ReadOnlySpan<AsmAssembly> src, FS.FilePath dst)
//         {
//             var count = src.Length;
//             var formatter = Tables.formatter<AsmAssembly>();
//             var flow = Wf.EmittingTable<AsmAssembly>(dst);
//             using var writer = dst.Writer();
//             writer.WriteLine(formatter.FormatHeader());
//             for(var i=0; i<count; i++)
//                 writer.WriteLine(formatter.Format(skip(src,i)));
//             Wf.EmittedTable(flow, count);
//         }

//         public void Create()
//         {
//             case_and_r8_r8(AsmOcPrototype.and_r8_r8);
//             case_cmp_r8_imm8(AsmOcPrototype.cmp_r8_imm8);
//             case_cmp_r16_r16(AsmOcPrototype.cmp_r16_r16);
//             case_cmp_r32_r32(AsmOcPrototype.cmp_r32_r32);
//         }
//     }
// }