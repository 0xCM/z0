//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    using static ObjDumpParser.States;

    public class ObjDumpParser : Service<ObjDumpParser>
    {
        const uint BufferSize = 256;

        public static bool DefinesBlockLabel(ReadOnlySpan<AsciCode> src)
        {
            var count = src.Length;
            var result = false;
            var gt = -1;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                if(i <16 && SQ.digit(base16,c))
                {
                    continue;
                }

                if(i == 16 && SQ.whitespace(c))
                    continue;

                if(i == 17 && SQ.lt(c))
                    continue;

                if(i > 17 && SQ.gt(c))
                    gt = i;

                if(gt > 0 && i == gt + 1 && SQ.colon(c))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        internal enum States : byte
        {
            ParsingFile,

            ParsingLine,

            ParsingLabelOffset,

            ParsedLabelOffset,

            ParsingLabelName,

            ParsedLabelName,

            ParsedBlockLabel,

            ParsingCodeOffset,

            ParsedCodeOffset,

            ParsingEncoding,

            ParsedEncoding,

            ParsingInstruction,

            ParsedInstruction,

            ErrorCondition = 0xFF
        }

        States State;

        Index<AsciCode> Codes;

        ObjDumpLine Line;

        uint _Pos;

        List<ObjDumpLine> Lines;

        public ObjDumpParser()
        {
            Codes = alloc<AsciCode>(BufferSize);
            _Pos = 0;
            Lines = new();
        }

        ReadOnlySpan<AsciCode> Complete()
        {
            var data = Codes.View;
            var collected = slice(data,0,_Pos);
            Codes.Clear();
            return collected;
        }

        void Clear()
        {
            Codes.Clear();
            Lines.Clear();
        }

        [MethodImpl(Inline)]

        void Deposit(AsciCode src)
            => Codes[_Pos++] = src;

        public ReadOnlySpan<ObjDumpLine> Parse(FS.FilePath src)
        {
            var result = Outcome.Success;
            Clear();

            State = ParsingFile;
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                result = Parse(line);
                if(result.Fail)
                {
                    Error(result.Message);
                    break;
                }
            }
            return Lines.ViewDeposited();
        }

        Outcome Parse(in AsciLine src)
        {
            State = ParsingLine;
            var result = Outcome.Success;
            var codes = src.Content;
            var count = codes.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(codes,i);
                result = Parse(c);
                if(result.Fail)
                    return result;
            }

            switch(State)
            {
                case ParsingInstruction:
                    State = ParsedInstruction;
                    Line.Instruction = Complete();
                    Lines.Add(Line);
                break;
                case ParsedBlockLabel:
                    Lines.Add(Line);
                break;
            }
            return result;
        }

        Outcome Parse(AsciCode c)
        {
            var result = Outcome.Success;
            switch(State)
            {
                case ParsingLine:
                {
                    if(!SQ.digit(base16,c))
                        break;

                    Deposit(c);
                    State = ParsingLabelOffset;
                }
                break;
                case ParsingLabelOffset:
                    if(SQ.digit(base16, c))
                    {
                        Deposit(c);
                    }
                    else if(SQ.whitespace(c))
                    {
                        var content = Complete();
                        var count = content.Length;
                        if(count == 16)
                        {
                            result = Hex.parse(content, out Line.Offset);
                            State = ParsedLabelOffset;
                        }
                        else
                        {
                            result = (false, "Expected 16 digits");
                        }
                    }
                break;
                case ParsedLabelOffset:
                    if(SQ.lt(c))
                    {
                        State = ParsingLabelName;
                    }
                    else
                    {
                        result = (false, "Expected a '<' token");
                    }
                break;
                case ParsingLabelName:
                    if(SQ.gt(c))
                    {
                        Line.LabelName = Complete();
                        State = ParsedLabelName;
                    }
                    else
                    {
                        Deposit(c);
                    }
                break;

                case ParsedLabelName:
                    if(SQ.colon(c))
                    {
                        State = ParsedBlockLabel;
                        Line.LabelName = Complete();
                    }
                    else
                    {
                        result = (false, "Expected a ':' token");
                    }
                break;

                case ParsingInstruction:
                    Deposit(c);
                break;

                case ParsingEncoding:
                    if(SQ.whitespace(c))
                    {
                        var content = Complete();
                        result = AsmParser.parse(content, out Line.Encoding);
                    }
                break;
            }

            if(result.Fail)
                State = ErrorCondition;

            return result;
        }
    }
}