//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

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

        AsmAnalyzerSettings Settings;

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
            AsmAnalyzerSettings.@default(out Settings);
        }

        uint CountStatements(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            var total = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var routine = ref skip(src,i);
                total += (uint)routine.InstructionCount;
            }
            return total;

        }

        void EmitHostStatements(ReadOnlySpan<AsmRoutine> src, FS.FolderPath dst)
        {
            var pipe = Wf.AsmStatementPipe();
            var total = CountStatements(src);
            var running = Wf.Running(CreatingStatements.Format(total));
            var buffer = span<AsmApiStatement>(total);
            var count = src.Length;
            var offset = 0u;
            for(var i=0; i<count; i++)
                offset += pipe.CreateStatementData(skip(src,i), slice(buffer, offset));
            Wf.Ran(running, CreatedStatements.Format(total));

            pipe.EmitHostStatements(buffer, dst);
        }

        Index<ApiCodeBlock> ColectBlocks(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            var flow = Wf.Running(CollectingBlocks.Format(count));
            var dst = alloc<ApiCodeBlock>(count);
            var size = AsmEtl.blocks(src, dst);
            Wf.Ran(flow, CollectedBlocks.Format(size));
            return dst;
        }

        public void Analyze(ReadOnlySpan<AsmRoutine> src, FS.FolderPath dst)
        {
            var blocks = ColectBlocks(src);

            if(Settings.EmitCalls)
                EmitCalls(src, dst);

            if(Settings.EmitJumps)
                EmitJumps(src, dst);

            if(Settings.EmitHostStatements)
                EmitHostStatements(src, dst);

            if(Settings.EmitStatementIndex)
            {
                var statements = EmitStatementIndex(blocks.ToSortedSpan(), dst);
                if(Settings.EmitBitstringIndex)
                    EmitBitstrings(statements, dst);
            }

            if(Settings.EmitAsmDetails)
                EmitDetails(blocks, dst);
        }

        void EmitDetails(ReadOnlySpan<ApiCodeBlock> src, FS.FolderPath dst)
        {
            var target = AsmDetailTarget(dst);
            target.Clear();
            var rows = AsmRows.EmitAsmDetailRows(src, target);
            Emitted(rows, dst);
        }

        ReadOnlySpan<AsmIndex> EmitStatementIndex(SortedSpan<ApiCodeBlock> src, FS.FolderPath dst)
        {
            var target = StatementTarget(dst);
            var rows = Statements.BuildStatementIndex(src);
            TableEmit(rows, AsmIndex.RenderWidths, target);
            return rows;
        }

        void EmitBitstrings(ReadOnlySpan<AsmIndex> src, FS.FolderPath dst)
        {
            var target = BsTarget(dst);
            var distinct = Bitstrings.CollectDistinct(src);
             Bitstrings.EmitBitstrings(distinct, target);
        }

        void EmitCalls(ReadOnlySpan<AsmRoutine> src, FS.FolderPath dst)
        {
            var target = CallTarget(dst);
            var calls = Calls.EmitRows(src, target);
            Emitted(calls, target);
        }

        void EmitJumps(ReadOnlySpan<AsmRoutine> src, FS.FolderPath dst)
        {
            var target = JmpTarget(dst);
            var rows = Jumps.EmitRows(src, target);
            Emitted(rows, target);
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

        void Emitted(ReadOnlySpan<AsmCallRow> rows, FS.FilePath dst)
        {

        }

        void Emitted(ReadOnlySpan<AsmJmpRow> rows, FS.FilePath dst)
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


        FS.FolderPath TableDir(FS.FolderPath root)
            => root + FS.folder("tables");

        FS.FilePath BsTarget(FS.FolderPath dst)
            => dst + FS.file("asm.bitstrings", FS.Asm);

        FS.FilePath CallTarget(FS.FolderPath root)
            => TableDir(root) + FS.file(AsmCallRow.TableId, FS.Csv);

        FS.FilePath JmpTarget(FS.FolderPath root)
            => TableDir(root) + FS.file(AsmJmpRow.TableId, FS.Csv);

        FS.FolderPath AsmDetailTarget(FS.FolderPath root)
            => TableDir(root) + FS.folder(AsmDetailRow.TableId);

        FS.FilePath StatementTarget(FS.FolderPath root)
            => TableDir(root)+ FS.file(AsmApiStatement.TableId, FS.Csv);


        static MsgPattern<Count> CollectingBlocks => "Collecting code blocks from {0} routines";

        static MsgPattern<ByteSize> CollectedBlocks => "Collecting {0} code block bytes";

        public static MsgPattern<Count> CreatingStatements => "Creating {0} statements";

        public static MsgPattern<Count> CreatedStatements => "Created {0} statements";
    }
}