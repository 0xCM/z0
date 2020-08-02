//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;

    using F = EnumLiteralField;

    public readonly ref struct EmitEnumData
    {
        readonly WfContext Context;

        readonly CorrelationToken Correlation;
        
        [MethodImpl(Inline)]
        public EmitEnumData(WfContext context, CorrelationToken? ct = null)
        {
            Context = context;
            Correlation = ct ?? CorrelationToken.create();
            Context.Running(nameof(EmitEnumData));    
        }
        
        FolderPath DatasetRoot 
            => Context.AppPaths.ResourceRoot + FolderName.Define("enums");


        public void format(in EnumLiteralRecord src, TableFormatter<EnumLiteralField> dst)
        {
            dst.Append(F.PartId, src.PartId);
            dst.Delimit(F.TypeId, src.TypeId);
            dst.Delimit(F.TypeAddress, src.TypeAddress);
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.NameAddress, src.NameAddress);
            dst.Delimit(F.DataType, src.DataType);                
            dst.Delimit(F.ScalarValue, src.ScalarValue);                
            dst.EmitEol();
        }

        public void Run()
        {            

            DatasetRoot.Clear();
                        
            var src = from part in  KnownParts.Service.Known
                       let enums = part.Owner.Enums()
                        orderby part.Id
                        select KeyedValues.@from(part.Id, enums);

            var dst = z.list<EnumLiteralRecord>();
            for(var i=0; i<src.Length; i++)
            {
                var x = src[i];
                for(var j=0u; j<x.Length; j++)
                {
                    var y = x[j];
                    (var part, var type) = y;
                    var records = EnumLiteralRecords.from(part,type);
                    for(var k = 0; k<records.Length; k++)
                        dst.Add(records[k]);
                }                
            }

            var m = dst.ToArray();
            Array.Sort(m);
            
            var path = DatasetRoot + FileName.Define("EnumSummary",FileExtensions.Csv);
            var formatter = TableFormatters.create<EnumLiteralField>();
            formatter.EmitHeader();
            for(var i=0; i<m.Length; i++)
                format(m[i],formatter);

            using var writer = path.Writer();
            writer.Write(formatter.Format());

            Context.Raise(new EmittedEnumSummary(path, (uint)m.Length));
        }    

        public void Dispose()
        {
            Context.Ran(nameof(EmitEnumData), Correlation);    
        }
    }    
}