//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static z;

    public readonly struct EnumDefinitionEmitter
    {
        public void Generate()
        {
            var archive = ReferenceArchive.Service;
            var ds = archive.Dataset("EnumTypes");
            ds.OnSuccess(GenerateEnums);
        }

        public void GenerateEnum(TextDoc spec)
        {
            var records = ParseEnumLiterals(spec).ToReadOnlySpan();
            var formatter = Tabular.Formatter<EnumLiteralRecordField>();
            for(var i=0u; i<records.Length; i++)
            {
                ref readonly var record = ref skip(records, i);
                var literal = CreateLiteralEntity("", record);
            }
        }
        
        public void GenerateEnums(TextDoc src)
        {
            var archive = ReferenceArchive.Service;
            foreach(var row in src.RowData)
            {
                var filename = FileName.Define(row[0]);
                var  doc = archive.Dataset(filename);
                doc.OnSuccess(GenerateEnum);
            }
        }

        EnumLiteralRecord[] ParseEnumLiterals(TextDoc src)
        {
            var dst = Root.alloc<EnumLiteralRecord>(src.RowCount);
            for(var i=0; i<src.RowCount; i++)
            {
                ref readonly var row = ref src[i];
                if(row.CellCount >= 3)
                {
                    var value = BitSpans.parse(row[2]).Convert<byte>();
                    dst[i] = new EnumLiteralRecord(i, row[0], row[1], EnumScalarKind.None, value);
                }
                else
                    dst[i] = EnumLiteralRecord.Empty;
            }
            return dst;
        }

        public EnumDataSource[] ParseDataSources(TextDoc src)
        {
            var dst = sys.alloc<EnumDataSource>(src.RowCount);
            for(var i=0; i<src.RowCount; i++)
            {
                ref readonly var row = ref src[i];
                if(row.CellCount >= 4)
                {
                    
                }

            }

            return dst;
        }

        EnumLiteralField CreateLiteralEntity(string declarer, in EnumLiteralRecord src)
            => Artifacts.EnumLiteral(declarer, src.Identifier, src.Sequence, src.Description, src.DataType, src.Value);
    }
}