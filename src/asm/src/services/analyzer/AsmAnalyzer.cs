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

        AsmRowBuilder AsmRows;

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
            AsmRows = Wf.AsmRowBuilder();
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
                Wf.AsmStatementPipe().EmitHostStatements(src, dst);

            if(Settings.EmitStatementIndex)
                EmitStatementIndex(blocks, dst);

            if(Settings.EmitAsmDetails)
                EmitDetails(blocks, dst);
        }

        public void Analyze(SortedSpan<AsmIndex> src, ApiPackArchive dst)
        {
            var root = dst.RootDir();
            var blocks = CollectBlocks(root);
            EmitThumbprints(src, root);
        }

        void EmitDetails(ReadOnlySpan<ApiCodeBlock> src, ApiPackArchive dst)
        {
            var target = dst.AsmDetailDir();
            target.Clear();
            var rows = AsmRows.Emit(src, target);
        }

        ReadOnlySpan<AsmIndex> EmitStatementIndex(SortedSpan<ApiCodeBlock> src, ApiPackArchive dst)
        {
            var pipe = Wf.AsmIndexPipe();
            var rows = pipe.BuildIndex(src);
            pipe.EmitIndex(rows, dst.StatementIndexPath());
            return rows;
        }

        SortedSpan<AsmEncodingInfo> CollectDistinctEncodings(ReadOnlySpan<AsmIndex> src)
        {
            var collecting = Wf.Running(Msg.CollectingBitstrings.Format(src.Length));
            var collected = AsmEtl.encodings(src);
            Wf.Ran(collecting, Msg.CollectedBitstrings.Format(collected.Count));
            return collected;
        }

        void EmitThumbprints(SortedSpan<AsmIndex> src, FS.FolderPath dst)
        {
            var target = ThumbprintPath(dst);
            var distinct = CollectDistinctEncodings(src);
            Thumbprints.Emit(distinct, target);
        }

        void EmitCalls(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
            => Calls.EmitRows(src, dst.AsmCallsPath());

        void EmitJumps(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
            => Jumps.EmitRows(src, dst.JmpTarget());

        SortedSpan<ApiCodeBlock> CollectBlocks(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            var flow = Wf.Running(Msg.CollectingBlocks.Format(count));
            var blocks = AsmRoutines.blocks(src);
            Wf.Ran(flow, Msg.CollectedBlocks.Format(count));
            return blocks;
        }

        SortedSpan<ApiCodeBlock> CollectBlocks(FS.FolderPath root)
            => ApiHex.ReadBlocks(root).Storage.ToSortedSpan();

        FS.FilePath ThumbprintPath(FS.FolderPath dst)
            => dst + FS.file("asm.thumbprints", FS.Asm);
    }
}