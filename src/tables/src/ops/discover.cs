//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;

    partial struct Tables
    {
        public static ReadOnlySpan<ReflectedTable> discover(Assembly src)
        {
            var types = @readonly(src.Types().Tagged<RecordAttribute>());
            var count = types.Length;
            var dst = root.datalist<ReflectedTable>();
            discover(src,dst);
            return dst.View();
        }

        public static ReadOnlySpan<ReflectedTable> discover(ReadOnlySpan<Assembly> src)
        {
            var count = src.Length;
            var dst = root.datalist<ReflectedTable>();
            for(var i=0; i<count; i++)
            {
                discover(skip(src,i), dst);
            }
            return dst.View();
        }

        static uint discover(Assembly src, DataList<ReflectedTable> dst)
        {
            var types = @readonly(src.Types().Tagged<RecordAttribute>());
            var count = types.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var type = ref skip(types,i);
                var tag = type.Tag<RecordAttribute>().Require();
                dst.Add(new ReflectedTable(identify(type), fields(type)));
                counter++;
            }

            return counter;
        }
    }
}