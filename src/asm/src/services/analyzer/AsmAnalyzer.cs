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

        AsmAnalyzerSettings Settings;

        AsmThumbprints Thumbprints;

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
            Thumbprints = Wf.AsmThumbprints();
            AsmAnalyzerSettings.@default(out Settings);
        }

        public void Analyze(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
        {
            var blocks = CollectBlocks(src);

            if(Settings.EmitCalls)
                EmitCalls(src, dst);

            if(Settings.EmitJumps)
                EmitJumps(src, dst);

            if(Settings.EmitHostStatements)
                EmitHostStatements(src, dst);

            if(Settings.EmitStatementIndex)
                EmitStatementIndex(blocks, dst);

            if(Settings.EmitAsmDetails)
                EmitDetails(blocks, dst);
        }

        void EmitDetails(ReadOnlySpan<ApiCodeBlock> src, ApiPackArchive dst)
        {
            var target = dst.AsmDetailDir();
            target.Clear();
            var rows = AsmRows.EmitAsmDetailRows(src, target);
            Emitted(rows, target);
        }

        ReadOnlySpan<AsmIndex> EmitStatementIndex(SortedSpan<ApiCodeBlock> src, ApiPackArchive dst)
        {
            var rows = Statements.BuildStatementIndex(src);
            var formatter = Tables.formatter<AsmIndex>(AsmIndex.RenderWidths);
            Statements.EmitIndex(rows, dst.StatementIndexPath());
            return rows;
        }

        public void Analyze(SortedSpan<AsmIndex> src, ApiPackArchive dst)
        {
            var root = dst.RootDir();
            var blocks = CollectBlocks(root);

            EmitThumbprints(src, root);
        }

        void EmitThumbprints(SortedSpan<AsmIndex> src, FS.FolderPath dst)
        {
            var target = ThumbprintPath(dst);
            var etl = Wf.AsmEtl();
            var distinct = etl.CollectDistinctEncodings(src);
            Thumbprints.Emit(distinct, target);
        }

        void EmitCalls(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
        {
            var target = dst.AsmCallsPath();
            var calls = Calls.EmitRows(src, target);
            Emitted(calls, target);
        }

        void EmitJumps(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
        {
            var target = dst.JmpTarget();
            var rows = Jumps.EmitRows(src, target);
            Emitted(rows, target);
        }

        ReadOnlySpan<ApiPartRoutines> Routines(ReadOnlySpan<ApiCodeBlock> src)
        {
            var routines = Decoder.Decode(src);
            Loaded(routines);
            return routines;

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

        void EmitHostStatements(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
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

            pipe.EmitHostStatements(buffer, dst.RootDir());
        }

        SortedSpan<ApiCodeBlock> CollectBlocks(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            var flow = Wf.Running(CollectingBlocks.Format(count));
            var dst = alloc<ApiCodeBlock>(count);
            var size = AsmEtl.blocks(src, dst);
            Wf.Ran(flow, CollectedBlocks.Format(size));
            return dst.ToSortedSpan();
        }

        SortedSpan<ApiCodeBlock> CollectBlocks(FS.FolderPath root)
        {
            var blocks = ApiHex.ReadBlocks(root);

            return blocks.Storage.ToSortedSpan();
        }

        FS.FilePath StatementIndexPath(FS.FolderPath dir)
            => dir + FS.file("asm.statements", FS.Csv);

        FS.FilePath ThumbprintPath(FS.FolderPath dst)
            => dst + FS.file("asm.thumbprints", FS.Asm);

        FS.FolderPath TableDir(FS.FolderPath root)
            => root + FS.folder("tables");

        FS.FilePath CallTarget(FS.FolderPath root)
            => TableDir(root) + FS.file(AsmCallRow.TableId, FS.Csv);

        FS.FilePath JmpTarget(FS.FolderPath root)
            => TableDir(root) + FS.file(AsmJmpRow.TableId, FS.Csv);

        FS.FolderPath AsmDetailTarget(FS.FolderPath root)
            => TableDir(root) + FS.folder(AsmDetailRow.TableId);

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


        static MsgPattern<Count> CollectingBlocks => "Collecting code blocks from {0} routines";

        static MsgPattern<ByteSize> CollectedBlocks => "Collecting {0} code block bytes";

        public static MsgPattern<Count> CreatingStatements => "Creating {0} statements";

        public static MsgPattern<Count> CreatedStatements => "Created {0} statements";
    }
}