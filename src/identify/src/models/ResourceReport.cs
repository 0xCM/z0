//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using F = ResourceField;
    using R = ResourceRecord;

    public enum ResourceField : ulong
    {
        Offset = 0 | (8ul << 32),

        Address = 1 | (16ul << 32),

        Size = 2 | (10ul << 32),

        Uri = 3 | (40ul << 32),

        Data = 4 | 1ul << 32,
    }

    /// <summary>
    /// Describes an assembly code emission
    /// </summary>
    public class ResourceRecord : ITabular<F,R>
    {    
        public static ResourceRecord Create(MemoryOffset offset, MemoryAddress location, int size, string uri, byte[] data)
            => new ResourceRecord(offset, location, size, uri, data);

        ResourceRecord(MemoryOffset Offset, MemoryAddress @base, int length, string uri, byte[] data)
        {
            this.Offset =Offset;
            this.Address = @base;
            this.Size = length;
            this.Uri = uri;
            this.Data = data;
        }

        [TabularField(F.Offset)]
        public MemoryOffset Offset {get; set;}

        [TabularField(F.Address)]
        public MemoryAddress Address {get; set;}

        [TabularField(F.Size)]
        public int Size {get; set;}

        [TabularField(F.Uri)]
        public string Uri {get; set;}

        [TabularField(F.Data)]
        public byte[] Data {get;set;}

        public string DelimitedText(char delimiter)
        {
            var dst = text.factory.Builder();
            dst.AppendField(Offset, F.Offset);
            dst.AppendDelimited(Address, F.Address, delimiter); 
            dst.AppendDelimited(Size.FormatAsmHex(4), FieldFormat.width(F.Size), delimiter); 
            dst.AppendDelimited(Uri, FieldFormat.width(F.Uri), delimiter);                        
            dst.AppendDelimited(Data.FormatHexBytes(), delimiter);                        
            return dst.ToString();
        }
    }

    public class ResourceReport : Report<ResourceReport,F,R>
    {        
        public static ResourceReport Create(BinaryResources resources)
            => new ResourceReport(resources);

        public static ResourceReport Create(IEnumerable<BinaryResource> resources)
            => new ResourceReport(resources.ToArray());

        public ResourceReport()
        {

        }

        ResourceReport(BinaryResources index)
            : base(CreateRecords(index))
        {

        }

        static ResourceRecord[] CreateRecords(BinaryResources index)
        {
            var records = new List<ResourceRecord>();
            var start = 0ul;

            foreach(var r in index.Indexed.OrderBy(x => x.Address))
            {
                if(start == 0)
                    start = r.Address;
                var offset = r.Address - start;

                records.Add(ResourceRecord.Create((ushort)offset, r.Address, r.Length, r.Uri, r.Data.ToArray()));
            }
            return records.ToArray();
        }
    }    
}