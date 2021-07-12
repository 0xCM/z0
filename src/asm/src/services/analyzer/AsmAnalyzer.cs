//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Asm;

    public sealed class AsmAnalyzer : AppService<AsmAnalyzer>
    {
        ApiHex ApiHex;

        AsmRowBuilder AsmRows;

        AsmCallPipe Calls;

        AsmJmpPipe Jumps;

        AsmAnalyzerSettings Settings;

        public AsmAnalyzer()
        {
        }

        protected override void OnInit()
        {
            ApiHex = Wf.ApiHex();
            AsmRows = Wf.AsmRowBuilder();
            Calls = Wf.AsmCallPipe();
            Jumps = Wf.AsmJmpPipe();
            AsmAnalyzerSettings.@default(out Settings);
        }

        public void Analyze(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
        {
            var blocks = CollectBlocks(src);
            var statements = Wf.AsmStatementPipe();
            if(Settings.EmitCalls)
                EmitCalls(src, dst);

            if(Settings.EmitJumps)
                EmitJumps(src, dst);

            if(Settings.EmitHostStatements)
                statements.EmitHostStatements(src, dst);

            if(Settings.EmitStatementIndex)
                statements.EmitIndex(src, dst.StatementIndexPath());

            if(Settings.EmitAsmDetails)
                EmitDetails(blocks, dst);
        }

        void EmitDetails(ReadOnlySpan<ApiCodeBlock> src, ApiPackArchive dst)
        {
            var target = dst.AsmDetailDir();
            target.Clear();
            var rows = AsmRows.Emit(src, target);
        }

        public SortedSpan<ApiCodeBlock> CollectBlocks(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            var flow = Wf.Running(Msg.CollectingBlocks.Format(count));
            var blocks = AsmRoutines.blocks(src);
            Wf.Ran(flow, Msg.CollectedBlocks.Format(count));
            return blocks;
        }

        void EmitCalls(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
            => Calls.EmitRows(src, dst.AsmCallsPath());

        void EmitJumps(ReadOnlySpan<AsmRoutine> src, ApiPackArchive dst)
            => Jumps.EmitRows(src, dst.JmpTarget());
    }
}