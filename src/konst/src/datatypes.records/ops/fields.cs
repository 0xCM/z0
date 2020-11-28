//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Records
    {
        [Op, Closures(Closure)]
        public static RecordFields fields<T>()
            where T : struct
                => fields(typeof(T));

        [Op]
        public static RecordFields fields(Type src)
        {
            var fields = src.DeclaredInstanceFields();
            var count = fields.Length;
            var dst = alloc<RecordField>(count);
            map(fields,dst);
            return dst;
        }
    }
}