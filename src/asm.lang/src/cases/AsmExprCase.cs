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

    public class AsmExprCases : WfService<AsmExprCases>
    {
        readonly AsmX asmx;

        public AsmExprCases()
        {
            asmx = AsmX.create();
        }

        void case_and_r8_r8(AsmSigKind id)
        {
            var symbols = asmx.SymbolSet;
            var casename = id.ToString();
            var flow = Wf.Running(casename);
            var regs = symbols.Gp8Regs();
            var grid = Symbols.grid(regs,regs);
            var rows = grid.RowCount;
            var cols = grid.ColCount;
            var count = rows * cols;
            var buffer = alloc<AsmExpr>(count);
            var k=0;
            var defining = Wf.Running(DefiningExpressions.Format(count,id));
            for(var i=0u; i<rows; i++)
            {
                for(var j=0u; j<cols; j++)
                {
                    var pair = grid.Pair(i,j);
                    seek(buffer,k++) = asmx.and(pair.Left, pair.Right);
                }
            }
            Wf.Ran(defining, DefinedExpressions.Format(count,id));
            Assemble(id, buffer);
            Wf.Ran(flow);
        }

        string CaseName(AsmSigKind id)
            => id.ToString();

        void Assemble(AsmSigKind id, Index<AsmExpr> input)
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

            var assembled = tool.LoadAssembledAsm(casename);
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

        void case_and_r8_imm8(AsmSigKind id)
        {

        }

        void case_move_r64_imm64(AsmSigKind id)
        {
            var encoder = AsmEncoder.create();
            var expr = asm.expression("mov rcx,7ffa9930f380h");
            var expect = asm.encoding(expr,  AsmBytes.hexcode("48 b9 80 f3 30 99 fa 7f 00 00"));
            var mov = encoder.mov(AsmRegOps.rcx, 0x7ffa9930f380);
            var actual = asm.encoding(expr, mov);
            Wf.Row(expect.Equals(actual));
        }

        public void Run(AsmSigKind id)
        {
            switch(id)
            {
                case AsmSigKind.and_r8_r8:
                    case_and_r8_r8(id);
                break;
                case AsmSigKind.mov_r64_imm64:
                    case_move_r64_imm64(id);
                    break;
                case AsmSigKind.and_r8_imm8:
                    case_and_r8_imm8(id);
                    break;
                default:
                break;
            }
        }

        static MsgPattern<Count,AsmSigKind> DefiningExpressions => "Defining {0} expressions of kind {1}";

        static MsgPattern<Count,AsmSigKind> DefinedExpressions => "Defining {0} expressions of kind {1}";
    }
}