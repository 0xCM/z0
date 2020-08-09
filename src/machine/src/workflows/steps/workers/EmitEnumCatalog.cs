//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;
    using static Flow;
    using static EmitEnumCatalogStep;

    using F = EnumLiteralField;

    [Step(WfStepKind.EmitEnumCatalog)]
    public readonly ref struct EmitEnumCatalog
    {
        readonly IWfContext Wf;
        
        readonly CorrelationToken Ct;

        readonly FilePath TargetPath;
        
        [MethodImpl(Inline)]
        public EmitEnumCatalog(IWfContext context, CorrelationToken? ct = null)
        {
            Wf = context;
            Ct = correlate(ct);
            TargetPath = Wf.IndexRoot + FileName.Define("enums",FileExtensions.Csv);
            Wf.Created(WorkerName, Ct);    
        }
        
        public void format(in EnumLiteralRecord src, TableFormatter<EnumLiteralField> dst)
        {
            dst.Append(F.PartId, src.PartId);
            dst.Delimit(F.TypeId, src.TypeId);
            dst.Delimit(F.TypeAddress, src.TypeAddress);
            dst.Delimit(F.NameAddress, src.NameAddress);
            dst.Delimit(F.TypeName, src.TypeName);
            dst.Delimit(F.DataType, src.DataType);                
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.ScalarValue, src.ScalarValue);                
            dst.Delimit(F.Name, src.Name);
            dst.EmitEol();
        }

        public void Run()
        {                                    
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
            
            var formatter = Tables.formatter<EnumLiteralField>();
            formatter.EmitHeader();
            for(var i=0; i<m.Length; i++)
                format(m[i],formatter);

            using var writer = TargetPath.Writer();
            writer.Write(formatter.Format());

            Wf.Raise(new EmittedEnumCatalog(TargetPath, (uint)m.Length, Ct));
        }    

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);    
        }
    }    
}