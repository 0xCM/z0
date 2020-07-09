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
    using static core;

    partial struct LiteralFields
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T numeric<T>(FieldInfo f)
            where T : unmanaged
                => sys.constant<T>(f);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] numeric<T>(Type src)
            where T : unmanaged
                => core.map(search<T>(src),numeric<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public FieldValues<T> numeric<T>(Type[] types)
            where T : unmanaged
        {
            var literals = list<FieldValue<T>>();
            for(var i=0u; i<types.Length; i++)
            {
                var values = from<T>(types[i]).ToSpan();
                for(var j=0u; j<values.Length; j++)
                    literals.Add(skip(values,j));
            }
            return sys.array(literals);
        }
    }
}