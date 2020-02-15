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
        public readonly AssemblyId Id;

        public DataResourceRecord[] Records {get;}

        public readonly FilePath ReportPath
            => AsmReports.ResourcePath(Id);
        
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
   }
}