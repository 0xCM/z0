//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Resources
    {
        public static Index<BinaryResRow> rows(BinaryResLookup src)
        {
            var view = src.View;
            var count = view.Length;
            if(count == 0)
                return default;
            var buffer = alloc<BinaryResRow>(count);
            rows(src,buffer);

            return buffer;
        }

        [Op]
        public static void rows(BinaryResLookup src, Span<BinaryResRow> dst)
        {
            var view = src.View;
            var count = view.Length;
            if(count == 0 || dst.Length < count)
                return;

            ref readonly var target = ref first(dst);
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
        }

        [MethodImpl(Inline), Op]
        public static Index<StringResRow> rows(Index<StringRes> src)
            => src.Select(r => row(r));
    }
}