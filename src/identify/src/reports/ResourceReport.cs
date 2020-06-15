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

    using static Konst;

    using F = ResourceField;
    using R = ResourceRecord;

    public enum ResourceField : uint
    {
        Offset = 0 | (8 << WidthOffset),

        Address = 1 | (16 << WidthOffset),

        Size = 2 | (10 << WidthOffset),

        Uri = 3 | (40 << WidthOffset),

        Data = 4 | 1 << WidthOffset,
    }

    /// <summary>
    /// Describes an assembly code emission
    /// </summary>
    public struct ResourceRecord : ITabular<F,R>
    {    
        public ushort Offset;

        public MemoryAddress Address;

        public int Size;

        public string Uri;

        public byte[] Data;

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

        public string DelimitedText(char delimiter)
        {
            var dst = text.build();
            dst.Delimit(F.Offset, Offset.FormatSmallHex());
            dst.Delimit(F.Address, Address, delimiter); 
            dst.Delimit(F.Size, Size.FormatAsmHex(4), delimiter); 
            dst.Delimit(F.Uri, Uri, delimiter);                        
            dst.Delimit(F.Data, Data.FormatHexBytes(), delimiter);                        
            return dst.ToString();
        }
    }

    partial class XTend
    {
        internal static void AppendDelimitedHere<C,F>(this StringBuilder sb, C content, F field, char delimiter)
            where C : ITextual
            where F : unmanaged, Enum
        {
            var pad = Tabular.width(field);
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