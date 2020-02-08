//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
 
    public readonly struct DataResourceReport : IAsmReport<DataResourceRecord>
    {
        public const AsmReportKind Kind = AsmReportKind.DataResource;
        
        public readonly AssemblyId Id;

        public DataResourceRecord[] Records {get;}

        public readonly FilePath ReportPath
            => AsmReports.ResourcePath(Id);
        
        public AsmReportKind ReportKind
            => Kind;

        readonly DataResourceIndex Index;        

        public static DataResourceReport Create(AssemblyId id, DataResourceIndex resources)
            => new DataResourceReport(id, resources);

        DataResourceReport(AssemblyId id, DataResourceIndex index)
        {
            Id = id;
            Index = index;
            Records = CreateRecords(id,index);
        }

        public Option<FilePath> Save()
            => Records.Save(ReportPath); 

        static DataResourceRecord[] CreateRecords(AssemblyId id, DataResourceIndex index)
        {
            var records = new List<DataResourceRecord>();
            var start = 0ul;

            foreach(var r in index.Indexed.OrderBy(x => x.Location))
            {
                if(start == 0)
                    start = r.Location;
                var offset = r.Location - start;

                records.Add(DataResourceRecord.Create((ushort)offset, r.Location, r.Length, r.Id));
            }
            return records.ToArray();
        }

        // public Option<FilePath> Save()
        // {            
        //     var dst = AsmReports.ResourcePath(Id).CreateParentIfMissing();
        //     var delimter = spaced(pipe());
        //     var header = concat(
        //         "Offset".PadRight(8), delimter,
        //         "Location".PadRight(16), delimter,  
        //         "Length".PadRight(10), delimter, 
        //         "Id") ;

        //     var start = 0ul;
        //     using var writer = new StreamWriter(dst.Name, false);  
        //     writer.WriteLine(header);         
        //     foreach(var r in Index.Indexed.OrderBy(x => x.Location))
        //     {
        //         if(start == 0)
        //             start = r.Location;
                    
        //         var offset = r.Location - start;
                
        //         var description = concat(
        //                 offset.FormatAsmHex(4).PadRight(8), delimter,
        //                 r.Location.FormatAsmHex().PadRight(16), delimter, 
        //                 r.Length.FormatAsmHex(4).PadRight(10), delimter, 
        //                 r.Id);
        //         writer.WriteLine(description);
        //     }
        //     return dst;
        // }
    }
}