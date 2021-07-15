//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static XedModels;

    using static Root;
    using static core;

    public class XedFormImportParser : IRecordParser<XedFormImport>
    {
        public static XedFormImportParser create(char delimiter = Chars.Pipe)
            => new XedFormImportParser(delimiter);

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

        public XedFormImportParser(char delimiter)
        {
            Delimiter = delimiter;
        }

        byte FieldCount
            => XedFormImport.FieldCount;

        public char Delimiter {get;}

        public Outcome ParseHeader(TextLine src, out RowHeader dst)
            => Tables.header(src, Delimiter, XedFormImport.FieldCount, out dst);

        public Outcome ParseRow(TextLine src, out XedFormImport dst)
        {
            dst = default;
            var result = Tables.cells(src, Delimiter, FieldCount, out var cells);
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
            dst.Attributes = Seq.delimit(Chars.Colon, 0, attributes(src.Attributes));

            return true;
        }
    }
}