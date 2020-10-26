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

    partial struct DataLayouts
    {
        public const string PartitionFormat = "[{0}..{1}]({2})";

        [Op, MethodImpl(Inline)]
        public static string format(in LayoutPartition src)
            => string.Format(PartitionFormat, src.Left/8, src.Right/8, src.Width/8);

        [Op, MethodImpl(Inline)]
        public static string format<T>(in LayoutPartition<T> src)
            where T : unmanaged
                => string.Format(PartitionFormat, src.Left/8, src.Right/8, src.Width/8);

        [Op, Closures(Closure)]
        public static string format<T>(in LayoutIdentity<T> src)
            where T : unmanaged
                => string.Format("{0}:{1}", src.Index, src.Kind);

        [Op, Closures(Closure)]
        public static string format(in LayoutIdentity src)
            => string.Format("{0}:{1}", src.Index, src.Kind);

        [Op]
        public static string format(in DataLayout src)
        {
            var dst = Buffers.text();
            render(src,dst);
            return dst.Emit();
        }

        [Op, Closures(Closure)]
        public static string format<T>(in DataLayout<T> src)
            where T : unmanaged
                => Render.format(src.Id, src.Storage);

        [MethodImpl(Inline), Op]
        public static void render(in LayoutPartition src, ITextBuffer dst)
            => dst.Append(DataLayouts.format(src));

        [Op]
        public static void render(in DataLayout src, ITextBuffer dst)
        {
            var count = src.PartitionCount;
            if(count != 0)
            {
                ref readonly var section = ref src.FirstPartition;
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