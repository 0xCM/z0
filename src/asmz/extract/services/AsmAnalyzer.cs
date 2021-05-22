//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static core;

    using Asm;

    public sealed class AsmAnalyzer : AppService<AsmAnalyzer>
    {
        ApiHex ApiHex;

        AsmDecoder Decoder;

        AsmRowBuilder AsmRows;

        AsmStatementPipe Statements;

        AsmCallPipe Calls;

        AsmJmpPipe Jumps;

        AsmBitstringEmitter Bitstrings;

        public AsmAnalyzer()
        {
        }

        protected override void OnInit()
        {
            ApiHex = Wf.ApiHex();
            Decoder = Wf.AsmDecoder();
            AsmRows = Wf.AsmRowBuilder();
            Statements = Wf.AsmStatementPipe();
            Calls = Wf.AsmCallPipe();
            Jumps = Wf.AsmJmpPipe();
            Bitstrings = Wf.AsmBitstringEmitter();
        }

        public void Analyze(ReadOnlySpan<AsmRoutine> routines, FS.FolderPath dst)
        {
            var count = routines.Length;
            var buffer = alloc<ApiCodeBlock>(count);
            ref readonly var target = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var routine = ref skip(routines,i);
                seek(target,i) = routine.Code;
            }

            var blocks = @readonly(buffer);
            EmitCalls(routines,dst);
            var statements  = EmitStatements(blocks, dst);
            EmitBitstrings(statements, dst);
            EmitDetails(blocks, dst);
        }

        public void AnalyzeCaptured(FS.FolderPath root, FS.FolderPath dst)
        {
            var blocks = LoadBlocks(root);
            var routines = LoadRoutines(blocks);

            EmitCalls(routines, dst);
            EmitJumps(routines, dst);

            var statements  = EmitStatements(blocks, dst);
            EmitBitstrings(statements, dst);

            EmitDetails(blocks, dst);
        }

        void EmitDetails(ReadOnlySpan<ApiCodeBlock> src, FS.FolderPath dst)
        {
            var target = AsmDetailTarget(dst);
            target.Clear();
            var rows = AsmRows.EmitAsmDetailRows(src, target);
            Emitted(rows, dst);
        }

        ReadOnlySpan<AsmApiStatement> EmitStatements(ReadOnlySpan<ApiCodeBlock> src, FS.FolderPath dst)
        {
            var target = StatementTarget(dst);
            var rows = Statements.BuildStatements(src);
            TableEmit(rows, AsmApiStatement.RenderWidths, target);
            Emitted(rows, target);
            return rows;
        }

        void EmitBitstrings(ReadOnlySpan<AsmApiStatement> src, FS.FolderPath dst)
        {
            var target = BsTarget(dst);
            var bitstrings = Bitstrings.EmitBitstrings(src, target);
            Emitted(bitstrings, target);
        }

        void EmitCalls(ReadOnlySpan<ApiPartRoutines> src, FS.FolderPath dst)
        {
            var target = CallTarget(dst);
            target.Clear();
            var calls = Calls.EmitRows(src, target);
            Emitted(calls, target);
        }

        void EmitCalls(ReadOnlySpan<AsmRoutine> src, FS.FolderPath dst)
        {
            var target = CallTarget(dst);
            target.Clear();
            var calls = Calls.EmitRows(src, target);
            Emitted(calls, target);
        }

        void EmitJumps(ReadOnlySpan<ApiPartRoutines> src, FS.FolderPath dst)
        {
            var target = JmpTarget(dst);
            target.Clear();
            var jumps = Jumps.EmitRows(src, target);
            Emitted(jumps, target);

        }

        void Emitted(ReadOnlySpan<AsmDetailRow> rows, FS.FolderPath dst)
        {

        }

        void Emitted(ReadOnlySpan<AsmApiStatement> rows, FS.FilePath dst)
        {

        }

        void Emitted(ReadOnlySpan<AsmEncodingInfo> rows, FS.FilePath dst)
        {

        }

        void Emitted(ReadOnlySpan<AsmCallRow> rows, FS.FolderPath dst)
        {

        }

        void Emitted(ReadOnlySpan<AsmJmpRow> rows, FS.FolderPath dst)
        {

        }

        void Loaded(ReadOnlySpan<ApiPartRoutines> src)
        {

        }

        void Loaded(ReadOnlySpan<ApiCodeBlock> src)
        {

        }

        ReadOnlySpan<ApiPartRoutines> LoadRoutines(ReadOnlySpan<ApiCodeBlock> src)
        {
            var routines = Decoder.Decode(src);
            Loaded(routines);
            return routines;

        }

        ReadOnlySpan<ApiCodeBlock> LoadBlocks(FS.FolderPath root)
        {
            var blocks = ApiHex.ReadBlocks(root).View;
            Loaded(blocks);
            return blocks;
        }


        FS.FilePath BsTarget(FS.FolderPath dst)
            => dst + FS.file("asm.bitstrings", FS.Asm);

        FS.FolderPath CallTarget(FS.FolderPath dst)
            => dst + FS.folder(AsmCallRow.TableId);

        FS.FolderPath JmpTarget(FS.FolderPath dst)
            => dst + FS.folder(AsmJmpRow.TableId);

        FS.FolderPath AsmDetailTarget(FS.FolderPath dst)
            => dst + FS.folder(AsmDetailRow.TableId);

        FS.FilePath StatementTarget(FS.FolderPath dst)
            => dst + FS.file(AsmApiStatement.TableId, FS.Csv);
    }
}