//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;

    public readonly ref struct EmitEnumData
    {
        readonly IAppContext Context;
        
        [MethodImpl(Inline)]
        public EmitEnumData(IAppContext context)
        {
            Context = context;
            Context.Running(nameof(EmitEnumData));    
        }
        
        FolderPath DatasetRoot 
            => Context.AppPaths.AppDataRoot;
                        
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
            using var writer = path.Writer();
            for(var i=0; i<m.Length; i++)
            {
                var row = m[i].Format();
                writer.WriteLine(row);
            }

            Context.Deposit(new EmittedEnumSummary(path, (uint)m.Length));
        }    

        public void Dispose()
        {
            Context.Ran(nameof(EmitEnumData));    
        }

    }    
}