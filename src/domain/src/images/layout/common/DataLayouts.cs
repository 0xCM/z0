//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct DataLayouts
    {
        [MethodImpl(Inline), Op]
        public static string format(in LayoutSectionInfo src)
            => Render.format(src.SectionName, src.Id, src.Content);

        [MethodImpl(Inline), Op]
        public static SegmentSpec segment(uint index, ulong kind, params SegmentPartition[] parts)
            => new SegmentSpec(identify(index, kind), parts);

        [MethodImpl(Inline), Op]
        public static LayoutSectionInfo describe(in LayoutIdentity id, string name, string content)
            => new LayoutSectionInfo(id,name,content);

        [MethodImpl(Inline), Op]
        public static LayoutIdentity identify(uint index, ulong kind)
            => new LayoutIdentity(index,kind);

        [MethodImpl(Inline), Op]
        public static ulong width(ReadOnlySpan<SegmentSpec> src)
        {
            var total = 0ul;
            var count = src.Length;
            ref readonly var item = ref first(src);
            for(var i=0; i<count; i++)
                total += width(skip(item,i).Sections);
            return total;
        }

        [MethodImpl(Inline), Op]
        public static ulong width(ReadOnlySpan<SegmentPartition> src)
        {
            var total = 0ul;
            var count = src.Length;
            ref readonly var item = ref first(src);
            for(var i=0; i<count; i++)
                total += skip(item,i).Width;
            return total;
        }

        [Op]
        public static string format(in SegmentSpec src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }

        public const string PartitionFormat = "[{0}..{1}]({2})";

        [MethodImpl(Inline), Op]
        public static string format(in SegmentPartition src)
            => string.Format(PartitionFormat, src.Left/8, src.Right/8, src.Width/8);

        [MethodImpl(Inline), Op]
        public static void render(in SegmentPartition src, ITextBuffer dst)
            => dst.Append(format(src));

        [Op]
        public static void render(in SegmentSpec src, ITextBuffer dst)
        {
            var count = src.SectionCount;
            if(count != 0)
            {
                ref readonly var section = ref src.FirstSection;

                for(var i=0; i<count; i++)
                {
                    if(i != 0)
                        dst.Append("| ");

                    render(skip(section,i), dst);
                }
            }
        }

        public static string format(in DataLayout src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }
        [Op]
        public static void render(in DataLayout src, ITextBuffer dst)
        {
            var count = src.SectionCount;
            if(count != 0)
            {
                ref readonly var section = ref src.FirstSection;
                dst.AppendLine(string.Format("{0} ", src.Index));
                dst.AppendLine(RP.PageBreak40);

                for(var i=0; i<count; i++)
                {
                    ref readonly var current = ref skip(section,i);
                    render(skip(section,i), dst);
                }

                dst.AppendLine(RP.PageBreak40);
            }
        }
    }
}