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
    using static z;

    using F = ResourceField;

    public enum ResourceField : uint
    {
        Offset = 0 | (8 << WidthOffset),

        Address = 1 | (16 << WidthOffset),

        Size = 2 | (10 << WidthOffset),

        Uri = 3 | (40 << WidthOffset),

        Data = 4 | 1 << WidthOffset,
    }

    public struct ResourceRow
    {
        public Address16 Offset;

        public MemoryAddress Address;

        public ByteSize Size;

        public string Uri;

        public BinaryCode Data;
    }

    [ApiHost]
    public readonly struct ResourceTable
    {
        [Op]
        public void render(in ResourceRow src, StringBuilder dst)
        {
            delimit(dst, F.Offset, src.Offset.Format());
            delimit(dst, F.Address, src.Address);
            delimit(dst, F.Size, src.Size.Format());
            delimit(dst, F.Uri, src.Uri);
            delimit(dst, F.Data, src.Data.Format());
        }

        [Op]
        public static TableSpan<ResourceRow> create(BinaryResources src)
        {
            var view = src.View;
            var count = view.Length;
            if(count == 0)
                return default;

            var records = new List<ResourceRow>();
            var buffer = alloc<ResourceRow>(count);

            ref readonly var target = ref first(span(buffer));
            ref readonly var source = ref first(view);
            var start = target.Address;

            for(var i=0u; i<count; i++)
            {
                ref var x = ref seek(target,i);
                ref readonly var y = ref skip(source,i);
                var offset = x.Address - start;
                x.Offset = (ushort)offset;
                x.Address = y.Address;
                x.Size = y.Size;
                x.Uri = y.Uri;
                x.Data = y.Data.ToArray();
            }
            return buffer;
        }

        static void delimit<F>(StringBuilder sb, F field, object content, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
        {

            sb.Append(text.rspace(delimiter));
            sb.Append($"{content}".PadRight(text.width(field)));
        }
    }
}