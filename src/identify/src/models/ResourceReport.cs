//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using F = ResourceField;
    using R = ResourceRecord;

    public enum ResourceField : ulong
    {
        Offset = 0 | (8 << 32),

        Location = 1 | (16 << 32),

        Length = 2 | (10 << 32),

        Id = 3 | (1 << 32)
    }

    /// <summary>
    /// Describes an assembly code emission
    /// </summary>
    public class ResourceRecord : IRecord<F,R>
    {    
        public static ResourceRecord Create(ushort offset, ulong location, int length, string id)
            => new ResourceRecord(offset, location, length, id);

        ResourceRecord(ushort Offset, ulong location, int length, string id)
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
            dst.AppendDelimited(Location.FormatAsmHex(),16, delimiter); 
            dst.AppendDelimited(Length.FormatAsmHex(4),10,delimiter); 
            dst.AppendDelimited(Id,delimiter);                        
            return dst.ToString();
        }
    }

    public readonly struct ResourceReport : IReport<ResourceRecord>
    {        
        public readonly PartId Id;

        public ResourceRecord[] Records {get;}
        
        readonly BinaryResources Index;        

        public static ResourceReport Create(PartId id, BinaryResources resources)
            => new ResourceReport(id, resources);

        ResourceReport(PartId id, BinaryResources index)
        {
            Id = id;
            Index = index;
            Records = CreateRecords(id,index);
        }

        static ResourceRecord[] CreateRecords(PartId id, BinaryResources index)
        {
            var records = new List<ResourceRecord>();
            var start = 0ul;

            foreach(var r in index.Indexed.OrderBy(x => x.Location))
            {
                if(start == 0)
                    start = r.Location;
                var offset = r.Location - start;

                records.Add(ResourceRecord.Create((ushort)offset, r.Location, r.Length, r.Id));
            }
            return records.ToArray();
        }
    }    
}