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

    public enum ResourceField : int
    {
        Offset = 0 | (8 << 16),

        Address = 1 | (16 << 16),

        Size = 2 | (10 << 16),

        Uri = 3 | (40 << 16),

        Data = 4 | 1 << 16,
    }

    /// <summary>
    /// Describes an assembly code emission
    /// </summary>
    public class ResourceRecord : ITabular<F,R>
    {    
        public static ResourceRecord Create(ushort offset, MemoryAddress location, int size, string uri, byte[] data)
            => new ResourceRecord(offset, location, size, uri, data);

        ResourceRecord(ushort Offset, MemoryAddress @base, int length, string uri, byte[] data)
        {
            this.Offset =Offset;
            this.Address = @base;
            this.Size = length;
            this.Uri = uri;
            this.Data = data;
        }

        [TabularField(F.Offset)]
        public ushort Offset {get; set;}

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
            var dst = text.build();
            dst.AppendField(F.Offset, Offset.FormatSmallHex());
            dst.AppendDelimitedHere(Address, F.Address, delimiter); 
            dst.AppendDelimited(Size.FormatAsmHex(4), FieldFormat.width(F.Size), delimiter); 
            dst.AppendDelimited(Uri, FieldFormat.width(F.Uri), delimiter);                        
            dst.AppendDelimited(Data.FormatHexBytes(), delimiter);                        
            return dst.ToString();
        }
    }

    partial class XTend
    {
        internal static void AppendDelimitedHere<C,F>(this StringBuilder sb, C content, F field, char delimiter)
            where C : ITextual
            where F : unmanaged, Enum
        {
            var pad = FieldFormat.width(field);
            sb.Append($"{delimiter} ");            
            sb.Append($"{content?.Format()}".PadRight(pad));
        }

    }

    public class ResourceReport : Report<ResourceReport,F,R>
    {        
        public static ResourceReport Create(ResourceIndex resources)
            => new ResourceReport(resources);

        public static ResourceReport Create(IEnumerable<BinaryResource> resources)
            => new ResourceReport(resources.ToArray());

        public ResourceReport()
        {

        }

        ResourceReport(ResourceIndex index)
            : base(CreateRecords(index))
        {

        }

        static ResourceRecord[] CreateRecords(ResourceIndex index)
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