//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Text;

    using static Root;
    using static core;

    public sealed class AsmIndexPipe : AppService<AsmIndexPipe>
    {
        AsmDecoder Decoder;

        protected override void OnInit()
        {
            Decoder = Wf.AsmDecoder();
        }

        public SortedReadOnlySpan<AsmIndex> BuildIndex(SortedSpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            if(count == 0)
                return default;

            var dst = list<AsmIndex>();
            var counter = 0u;
            var @base = src[0].BaseAddress;

            for(var i=0u; i<count; i++)
            {
                ref readonly var code = ref src[i];
                var decoded = Decode(code);
                var instructions = decoded.Instructions;
                var icount = instructions.Length;
                if(icount == 0)
                    continue;

                var bytes = code.View;
                var i0 = first(instructions);
                var blockBase = (MemoryAddress)i0.IP;
                var blockOffset = z16;
                for(var j=0; j<icount; j++)
                {
                    var instruction = skip(instructions,j);
                    var opcode = asm.opcode(instruction.OpCode.ToString());
                    if(!opcode.IsValid)
                        break;

                    var statement = new AsmIndex();
                    var size = (ushort)instruction.ByteLength;
                    var specifier = instruction.Specifier;
                    var ip = (MemoryAddress)instruction.IP;
                    statement.Sequence = counter++;
                    statement.GlobalOffset = (Address32)(ip - @base);
                    statement.BlockAddress = blockBase;
                    statement.BlockOffset = blockOffset;
                    statement.IP = ip;
                    statement.OpUri = code.OpUri;
                    statement.Statement = instruction.FormattedInstruction;
                    AsmParser.sig(instruction.OpCode.InstructionString, out statement.Sig);
                    statement.Encoded = AsmHexCode.load(slice(bytes, blockOffset, size));
                    statement.OpCode = opcode;
                    statement.Bitstring = statement.Encoded;
                    dst.Add(statement);

                    blockOffset += size;
                }
            }

            return Spans.sorted(dst.ViewDeposited());
        }

        public uint EmitIndex(SortedReadOnlySpan<AsmIndex> src, FS.FilePath dst)
            => Emit(src.View, AsmIndex.RenderWidths, AsmIndex.RowPad, Encoding.ASCII, dst);

        public ReadOnlySpan<AsmIndex> LoadIndex(FS.FilePath src)
        {
            var dst = list<AsmIndex>();
            var counter = 1u;

            using var reader = src.Reader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = AsmParser.parse(counter++, line, out var row);
                if(result.Ok)
                    dst.Add(row);

                line = reader.ReadLine();
            }

            return dst.ViewDeposited();
        }

        public void TraverseIndex(FS.FilePath src, Receiver<AsmIndex> dst)
        {
            var counter = 1u;
            using var reader = src.Reader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = AsmParser.parse(counter++, line, out var row);
                if(result.Ok)
                    dst(row);
                line = reader.ReadLine();
            }
        }

        AsmInstructionBlock Decode(in ApiCodeBlock src)
        {
            var outcome = Decoder.Decode(src, out var decoded);
            if(outcome)
                return decoded;
            else
            {
                Wf.Error(outcome.Message);
                return AsmInstructionBlock.Empty;
            }
        }
    }
}