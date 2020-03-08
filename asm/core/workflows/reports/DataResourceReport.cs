//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    using F = AsmWorkflowReports.DataResourceField;
    using R = AsmWorkflowReports.DataResourceRecord;

    partial class AsmWorkflowReports
    {
        public enum DataResourceField : ulong
        {
            Offset = 0 | (8 << 32),

            Location = 1 | (16 << 32),

            Length = 2 | (10 << 32),

            Id = 3 | (1 << 32)
        }

        /// <summary>
        /// Describes an assembly code emission
        /// </summary>
        public class DataResourceRecord : IRecord<F,R>
        {    
            public static DataResourceRecord Create(ushort offset, ulong location, int length, string id)
                => new DataResourceRecord(offset, location, length, id);

            DataResourceRecord(ushort Offset, ulong location, int length, string id)
            {
                this.Offset =Offset;
                this.Location = location;
                this.Length = length;
                this.Id = id;
            }

            [ReportField(F.Offset)]
            public ushort Offset {get; set;}

            [ReportField(F.Location)]
            public ulong Location {get; set;}

            [ReportField(F.Length)]
            public int Length {get; set;}

            [ReportField(F.Id)]
            public string Id {get; set;}

            public string DelimitedText(char delimiter)
            {
                var dst = text.factory.Builder();
                dst.AppendField(Offset.FormatAsmHex(), 8);
                dst.DelimitField(Location.FormatAsmHex(),16, delimiter); 
                dst.DelimitField(Length.FormatAsmHex(4),10,delimiter); 
                dst.DelimitField(Id,delimiter);                        
                return dst.ToString();
            }
        }

        public readonly struct DataResourceReport : IReport<DataResourceRecord>
        {        
            public readonly AssemblyId Id;

            public DataResourceRecord[] Records {get;}

            public readonly FilePath ReportPath
                => AsmEmissionPaths.The.ResourcePath(Id);
            
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
}