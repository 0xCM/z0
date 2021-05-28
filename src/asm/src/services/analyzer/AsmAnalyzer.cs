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

        ReadOnlySpan<AsmApiStatement> BuildStatements(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var dst = core.list<AsmApiStatement>();
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                var outcome = Decoder.Decode(block.Code, out var instructions);
                if(outcome.Fail)
                {
                    Wf.Error(outcome.Message);
                    continue;
                }

                counter += BuildStatements(block.OpUri, instructions, dst);
            }
            return dst.ViewDeposited();
        }

        uint BuildStatements(in OpUri uri, IceInstructions src, List<AsmApiStatement> dst)
        {
            var count = (uint)src.Count;
            if(count == 0)
                return  count;

            var offseq = AsmOffsetSeq.Zero;
            var view = src.View;
            var code = src.Encoded.View;
            ref readonly var i0 = ref first(view);
            var @base = i0.MemoryAddress64;
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(view,i);
                var statement = new AsmApiStatement();
                var size = (uint)instruction.ByteLength;
                var recoded = new ApiCodeBlock(instruction.IP, uri, slice(code, offseq.Offset, size).ToArray());
                var apifx = new ApiInstruction(@base, instruction, recoded);
                offseq = offseq.AccrueOffset(size);

                statement.BlockAddress = @base;
                statement.OpUri = uri;
                statement.IP = instruction.IP;
                dst.Add(statement);
            }
            return (uint)count;
        }

        ReadOnlySpan<ApiCodeBlock> ColectBlocks(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            var flow = Wf.Running(CollectingBlocks.Format(count));
            var dst = span<ApiCodeBlock>(count);
            var size = AsmEtl.blocks(src,dst);
            Wf.Ran(flow, CollectedBlocks.Format(size));
            return dst;
        }

        public void Analyze(ReadOnlySpan<AsmRoutine> routines, FS.FolderPath dst)
        {
            var blocks = ColectBlocks(routines);

            if(Settings.EmitCalls)
                EmitCalls(routines, dst);

            if(Settings.EmitJumps)
                EmitJumps(routines, dst);

            if(Settings.EmitStatements)
            {
                var statements = EmitStatements(blocks, dst);
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


        FS.FilePath BsTarget(FS.FolderPath dst)
            => dst + FS.file("asm.bitstrings", FS.Asm);

        FS.FilePath CallTarget(FS.FolderPath dst)
            => dst + FS.file(AsmCallRow.TableId, FS.Csv);

        FS.FilePath JmpTarget(FS.FolderPath dst)
            => dst + FS.file(AsmJmpRow.TableId, FS.Csv);

        FS.FolderPath AsmDetailTarget(FS.FolderPath dst)
            => dst + FS.folder(AsmDetailRow.TableId);

        FS.FilePath StatementTarget(FS.FolderPath dst)
            => dst + FS.file(AsmApiStatement.TableId, FS.Csv);


        static MsgPattern<Count> CollectingBlocks => "Collecting code blocks from {0} routines";

        static MsgPattern<ByteSize> CollectedBlocks => "Collecting {0} code block bytes";
    }
}