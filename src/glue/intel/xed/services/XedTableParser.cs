//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;

    enum TableParserState : byte
    {
        None,

        ParsingInstruction,

        ParsingOpCount,

        ParsingOperand,
    }

    public class XedTableParser : AppService<XedTableParser>
    {
        const char CommentMarker = Chars.Hash;

        public bool ParseTables(FS.FilePath src)
        {
            using var reader = src.AsciLineReader();
            var line = TextLine.Empty;
            var seq = 0u;
            var opcount = z8;
            var succeeded = true;
            var opseq = z8;
            var state = TableParserState.ParsingInstruction;
            var outcome = Outcome.Empty;
            while(reader.Next(out line))
            {
                if(line.IsEmpty || line.StartsWith(CommentMarker))
                    continue;

                if(state == TableParserState.ParsingOpCount)
                {
                    if(!byte.TryParse(line.Content.Trim(), out opcount))
                    {
                        Wf.Error(string.Format("Parsing operand count from {0} failed", line));
                        succeeded = false;
                        break;
                    }

                    if(opcount != 0)
                    {
                        state = TableParserState.ParsingOperand;
                    }
                }
                else if(state == TableParserState.ParsingOperand)
                {
                    var _opseq = line.Content.Trim().LeftOfFirst(Chars.Space);
                    if(!byte.TryParse(_opseq, out opseq))
                    {
                        Wf.Error(string.Format("Parsing operand sequence from {0} failed", line));
                        succeeded = false;
                        break;
                    }

                    outcome = default;
                    if(!outcome)
                    {
                        Wf.Error(outcome.Message);
                        succeeded = false;
                        break;
                    }

                    if(opseq == opcount - 1)
                    {
                        state = TableParserState.ParsingInstruction;
                    }
                }
                else if(state == TableParserState.ParsingInstruction)
                {
                    if(!line.StartsWith(seq.ToString()))
                    {
                        Wf.Error(string.Format("Parsing instruction sequence from {0} failed", line));
                        succeeded = false;
                        break;
                    }

                    outcome = default;
                    if(!outcome)
                    {
                        Wf.Error(outcome.Message);
                        succeeded = false;
                        break;
                    }

                    state = TableParserState.ParsingOpCount;
                    seq++;
                }
                else
                {
                    Wf.Error(string.Format("Invalid state {0}", state));
                    succeeded = false;
                    break;
                }
            }

            return succeeded;
        }
    }
        /*
            0 INVALID INVALID INVALID INVALID INVALID ATTRIBUTES:
            0
            1 FADD FADD_ST0_MEMmem32real X87_ALU X87 X87 ATTRIBUTES: NOTSX
            3
                0 REG0 IMPLICIT RW REG F80 ST(0)
                1 MEM0 EXPLICIT R IMM_CONST F32
                2 REG1 SUPPRESSED W REG INVALID X87STATUS
            2 FADD FADD_ST0_X87 X87_ALU X87 X87 ATTRIBUTES: NOTSX
            3
                0 REG0 IMPLICIT RW REG F80 ST(0)
                1 REG1 EXPLICIT R NT_LOOKUP_FN F80 X87
                2 REG2 SUPPRESSED W REG INVALID X87STATUS
            267 AND_LOCK AND_LOCK_MEMb_IMMb_82r4 LOGICAL BASE I86 ATTRIBUTES: BYTEOP HLE_ACQ_ABLE HLE_REL_ABLE LOCKED
            3
                0 MEM0 EXPLICIT RW IMM_CONST U8
                1 IMM0 EXPLICIT R IMM_CONST U8
                2 REG0 SUPPRESSED W NT_LOOKUP_FN INVALID RFLAGS
            268 AND_LOCK AND_LOCK_MEMv_IMMb LOGICAL BASE I86 ATTRIBUTES: HLE_ACQ_ABLE HLE_REL_ABLE LOCKED SCALABLE
            3
                0 MEM0 EXPLICIT RW IMM_CONST INT
                1 IMM0 EXPLICIT R IMM_CONST I8
                2 REG0 SUPPRESSED W NT_LOOKUP_FN INVALID RFLAGS
        */
}