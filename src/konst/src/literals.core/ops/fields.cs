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

    partial struct Literals
    {
        [MethodImpl(Inline), Op]
        public static LiteralFields fields(Type src)
            => new LiteralFields(src.LiteralFields());

        [MethodImpl(Inline)]
        public static LiteralFields<F> fields<F>()
            where F : unmanaged, Enum
        {
            var specs = typeof(F).LiteralFields();
            var values = specs.Map(f => (F)f.GetRawConstantValue());
            return new LiteralFields<F>(specs, values);
        }

        /// <summary>
        /// Collects unmanaged fields defined by a type
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FieldValues<T> fields<T>(Type src)
            where T : unmanaged
                => search<T>(src).Select(f => (f, sys.constant<T>(f)));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public FieldValues<T> fields<T>(Type[] types)
            where T : unmanaged
        {
            var literals = list<FieldValue<T>>();
            for(var i=0u; i<types.Length; i++)
            {
                var values = fields<T>(types[i]).ToSpan();
                for(var j=0u; j<values.Length; j++)
                    literals.Add(skip(values,j));
            }
            return sys.array(literals);
        }
    }
}