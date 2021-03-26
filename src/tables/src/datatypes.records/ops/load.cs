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

    partial struct RecUtil
    {
        [Op, Closures(Closure)]
        public static void load<T>(in RecordFields fields, ReadOnlySpan<T> src, in DynamicRows<T> dst)
            where T : struct
        {
            var count = (uint)src.Length;
            var target = dst.Edit;
            for(var i=0u; i<count; i++)
                load(fields, i, skip(src, i), ref seek(target,i));
        }

        [Op, Closures(Closure)]
        public static void load<T>(in RecordFields fields, uint index, in T src, ref DynamicRow<T> dst)
            where T : struct
        {
            dst = dst.UpdateSource(index, src);
            var tr = __makeref(edit(src));
            var count = fields.Length;
            var fv = fields.View;
            var target = dst.Edit;
            for(var i=0u; i<count; i++)
                seek(target, i) = skip(fv, i).Definition.GetValueDirect(tr);
        }
    }
}