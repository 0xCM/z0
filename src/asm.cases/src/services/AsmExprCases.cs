//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static AsmX;
    using static Part;
    using static memory;

    public class AsmExprCases : WfService<AsmExprCases>
    {
        readonly AsmX asmx;

        Index<AsmExpr> _Buffer;

        public AsmExprCases()
        {
            asmx = AsmX.create();
            _Buffer = alloc<AsmExpr>(256);
        }

        [MethodImpl(Inline)]
        Index<AsmExpr> Buffer()
        {
            _Buffer.Clear();
            return _Buffer;
        }

        [MethodImpl(Inline)]
        Symbols<Gp8> Gp8Regs()
            => asmx.SymbolSet.Gp8Regs();

        [MethodImpl(Inline)]
        Symbols<Gp16> Gp16Regs()
            => asmx.SymbolSet.Gp16Regs();

        [MethodImpl(Inline)]
        Symbols<Gp64> Gp64Regs()
            => asmx.SymbolSet.Gp64Regs();

        void case_and_r8_r8(AsmSigKind id)
        {
            var casename = CaseName(id);
            var flow = Wf.Running(casename);
            var regs = Gp8Regs();
            var grid = Symbols.grid(regs,regs);
            var rows = grid.RowCount;
            var cols = grid.ColCount;
            var count = rows * cols;
            var buffer = Buffer();
            var k=0;
            var defining = Wf.Running(Msg.DefiningExpressions.Format(count,id));
            for(var i=0u; i<rows; i++)
            {
                for(var j=0u; j<cols; j++)
                {
                    var pair = grid.Pair(i,j);
                    buffer[k++] = asmx.and(pair.Left, pair.Right);
                }
            }
            Wf.Ran(defining, Msg.DefinedExpressions.Format(count,id));
            Assemble(id, slice(buffer.View,0, count));
            Wf.Ran(flow);
        }

        void case_move_r64_imm64(AsmSigKind id)
        {
            const ulong Imm64 = 0x7ffa9930f380;
            var casename = CaseName(id);
            var flow = Wf.Running(casename);
            var regs = Gp64Regs();
            var count = regs.Count;
            var buffer = Buffer();
            var defining = Wf.Running(Msg.DefiningExpressions.Format(count,id));
            for(byte i=0; i<count; i++)
                buffer[i] = asmx.mov(regs[i], Imm64);
            Wf.Ran(defining, Msg.DefinedExpressions.Format(count,id));
            Assemble(id, slice(buffer.View,0, count));
            Wf.Ran(flow);
        }

        void case_move_r64_imm64_example(AsmSigKind id)
        {
            const ulong Imm64 = 0x7ffa9930f380;

            var casename = CaseName(id);
            var regs = Gp64Regs();
            var count = regs.Count;
            var buffer = Buffer();
            for(byte i=0; i<count; i++)
                buffer[i]= asmx.mov(regs[i], Imm64);

            var expr = asm.expression("mov rcx,7ffa9930f380h");
            var expect = asm.encoding(expr,  AsmBytes.hexcode("48 b9 80 f3 30 99 fa 7f 00 00"));
            var mov = AsmEncoder.mov(AsmRegOps.rcx, Imm64);
            var actual = asm.encoding(expr, mov);
            Wf.Row(expect.Equals(actual));
        }

        string CaseName(AsmSigKind id)
            => id.ToString();

        void Assemble(AsmSigKind id, ReadOnlySpan<AsmExpr> input)
        {
            var subject = Tables.tableid<AssembledAsm>();
            var casedir = Db.CaseDir(subject,id).Create();
            var casename = CaseName(id);
            var tool = Wf.nasm();
            var source = tool.Source(input);
            var target = tool.Input(casedir, FS.file(casename, FS.Asm));
            var emitting = Wf.EmittingFile(target);
            source.Save(target);
            Wf.EmittedFile(emitting,1);

            var script = tool.CreateCaseScript(casename, casedir);
            var runner = Wf.ScriptRunner();
            var outcome = runner.RunScript(script.Path);
            if(outcome)
                root.iter(outcome.Data, line => Wf.Row(line));
            else
                Wf.Error(outcome.Message);

            var assembled = tool.LoadAssembledAsm(casedir, casename);
            var tablepath = Db.CasePath(subject, id, id, FS.Csv);
            SaveTable(id, assembled, tablepath);
        }

        void SaveTable(AsmSigKind id, ReadOnlySpan<AssembledAsm> src, FS.FilePath dst)
        {
            var count = src.Length;
            var formatter = Tables.formatter<AssembledAsm>();
            var flow = Wf.EmittingTable<AssembledAsm>(dst);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(src,i)));
            Wf.EmittedTable(flow, count);
        }

        public void Create(AsmSigKind id)
        {
            switch(id)
            {
                case AsmSigKind.and_r8_r8:
                    case_and_r8_r8(id);
                break;
                case AsmSigKind.mov_r64_imm64:
                    case_move_r64_imm64(id);
                    break;
                default:
                break;
            }
        }

        public void Create()
        {
            Create(AsmSigKind.and_r8_r8);
            //Create(AsmSigKind.mov_r64_imm64);
        }
    }
}