//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static XedModels;
    using static XedRuleTable;

    using SQ = SymbolicQuery;
    using SP = SymbolicParse;

    [ApiHost]
    public class XedParsers : AppService<XedParsers>
    {
        bool Verbose {get;} = false;

        Symbols<AttributeKind> Attributes;

        Symbols<Category> Categories;

        public XedParsers()
        {
            Attributes = Symbols.index<AttributeKind>();
            Categories = Symbols.index<Category>();
        }

        [MethodImpl(Inline), Op]
        public static TableRow row(TableRowKind kind, AsciLine src)
            => new TableRow(kind,src);

        static AttributeKind[] attributes(string src)
        {
            var parts = src.SplitClean(Chars.Colon).ToReadOnlySpan();
            var count = parts.Length;
            if(count == 0)
                return default;

            var counter = 0u;
            var dst = span<AttributeKind>(count);
            for(var i=0; i<count; i++)
            {
                var result = DataParser.eparse(skip(parts,i), out seek(dst,i));
                if(result)
                {
                    counter++;
                }
                else
                    return default;
            }
            return slice(dst,0,counter).ToArray();
        }

        [MethodImpl(Inline), Op]
        static TableRowKind classify(in AsciLine src)
        {
            var data = src.Codes;
            if(data.Length < 2)
                return 0;

            ref readonly var c0 = ref skip(data,0);
            ref readonly var c1 = ref skip(data,1);
            if(SQ.hash(c0))
                return TableRowKind.Comment;

            if(SQ.digit(base10,c0))
                return TableRowKind.Instruction;
            else if(SQ.digit(base10,c1))
                return TableRowKind.OpCount;
            else if(SQ.tab(c0))
                return TableRowKind.Operand;
            else
                return 0;
        }

        [MethodImpl(Inline), Op]
        public static Outcome parse(in AsciLine line, out TableRow dst)
        {
            dst = TableRow.Empty;
            var outcome = Outcome.Success;
            if(line.IsNonEmpty)
            {
                var kind = classify(line);
                if(kind == 0)
                    outcome = (false,"Row classification failed");
                else
                    dst = row(kind,line);
            }
            return outcome;
        }

        public Outcome ParseFormImport(TextLine src, out XedFormImport dst)
        {
            const char Delimiter = Chars.Pipe;

            dst = default;
            var result = Tables.cells(src, Delimiter, XedFormImport.FieldCount, out var cells);
            if(result.Fail)
                return result;
            var j=0;

            result = DataParser.parse(skip(cells,j++), out dst.Index);
            if(result.Fail)
                return result;

            result = DataParser.eparse(skip(cells,j++), out IFormType ft);
            if(result.Fail)
                return result;
            else
                dst.Form = ft;

            result = DataParser.eparse(skip(cells,j++), out dst.Class);
            if(result.Fail)
                return result;

            result = DataParser.eparse(skip(cells,j++), out dst.Category);
            if(result.Fail)
                return result;

            result = DataParser.eparse(skip(cells,j++), out dst.IsaKind);
            if(result.Fail)
                return result;

            result = DataParser.eparse(skip(cells,j++), out dst.Extension);
            if(result.Fail)
                return result;

            dst.Attributes = attributes(skip(cells,j++));

            return result;
        }

        public Outcome ParseChipMap(FS.FilePath src, out ChipMap dst)
        {
            dst = default;
            var flow = Wf.Running(string.Format("Parsing {0}", src.ToUri()));
            var chip = ChipCode.None;
            var chips = dict<ChipCode,ChipIsaKinds>();
            using var reader = src.LineReader(TextEncodingKind.Asci);
            while(reader.Next(out var line))
            {
                if(line.StartsWith(Chars.Hash))
                    continue;

                var i = line.Index(Chars.Colon);
                if(i != NotFound)
                {
                    if(Verbose)
                        Wf.Row(line);

                    var name = line.Left(i).Trim();
                    if(blank(name))
                        continue;

                    if(Enums.parse<ChipCode>(name, out chip))
                    {
                        if(!chips.TryAdd(chip, new ChipIsaKinds(chip)))
                            return (false, DuplicateChipCode.Format(chip));
                    }
                    else
                        return (false, ChipCodeNotFound.Format(name));
                }
                else
                {
                    var kinds = line.Content.SplitClean(Chars.Tab).Trim().Select(x => Enums.parse<IsaKind>(x,IsaKind.None)).Where(x => x != 0);
                    chips[chip].Add(kinds);
                    if(chips.TryGetValue(chip, out var entry))
                        entry.Add(kinds);
                }
            }

            var allChips = ChipCodes().ToArray();
            var count = allChips.Length;
            Wf.Ran(flow, string.Format("Parsed {0} chip codes", count));

            var buffer = new Index<ChipCode,IsaKinds>(alloc<IsaKinds>(count));
            for(var i=0; i<count; i++)
            {
                var _code = (ChipCode)i;
                if(chips.TryGetValue(_code, out var entry))
                    buffer[_code] = entry.Kinds;
                else
                    buffer[_code] = IsaKinds.Empty;
            }
            dst = new ChipMap(allChips,buffer);
            return true;
        }

        ReadOnlySpan<ChipCode> ChipCodes()
            => Symbols.index<ChipCode>().Kinds;

        static MsgPattern<ChipCode> DuplicateChipCode => "Duplicate chip code {0}";

        static MsgPattern<string> ChipCodeNotFound => "Code for chip {0} not found";

        public Outcome Parse(in XedFormSource src, ushort seq, out XedFormImport dst)
        {
            var result = Outcome.Success;
            dst.Index = seq;
            result = DataParser.eparse(src.Class, out dst.Class);
            result = DataParser.eparse(src.Extension, out dst.Extension);
            result = DataParser.eparse(src.Category, out dst.Category);
            result = DataParser.eparse(src.Form, out IFormType ft);
            dst.Form = ft;

            result = DataParser.eparse(src.IsaSet, out dst.IsaKind);
            dst.Attributes = Z0.seq.index(Chars.Colon, 0, attributes(src.Attributes));

            return true;
        }

        public ReadOnlySpan<XedRuleTable> ParseRuleTable(FS.FilePath src)
        {
            using var reader = src.AsciLineReader();
            var buffer = alloc<XedRuleTable>(Pow2.T13);
            var dst = span(buffer);
            var outcome = Outcome.Success;
            var tables = 0u;
            while(reader.Next(out var line))
            {
                if(line.IsEmpty)
                    continue;

                ref readonly var c = ref line[0];
                if(SQ.hash(c))
                    continue;

                outcome = parse(line, out var row);
                if(outcome.Fail)
                {
                    Error(outcome.Message);
                    break;
                }

                var i=0u;
                ref var target = ref seek(dst,tables++);
                outcome = SP.digits(base10, line, ref i, out target.Instruction.Sequence);
                if(outcome.Fail)
                {
                    Error(outcome.Message);
                    break;
                }
            }
            return slice(dst, 0, tables);
        }
    }
}