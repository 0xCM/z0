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

    [ApiHost(ApiNames.ClrQuery, true)]
    public readonly partial struct ClrQuery
    {
        const NumericKind Closure = UnsignedInts;

        const BindingFlags BF = ReflectionFlags.BF_All;

        [MethodImpl(Inline), Op]
        public static Index<Type> interfaces(Type src)
            => src.GetInterfaces();

        [MethodImpl(Inline), Op]
        public static ClrInterfaceMap imap(Type host, Type contract)
            => @as<InterfaceMapping,ClrInterfaceMap>(host.GetInterfaceMap(contract));

        [MethodImpl(Inline), Op]
        public static ClrTypes index(Type[] src)
            => new ClrTypes(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ClrType<T> type<T>()
            => default;

        [MethodImpl(Inline), Op]
        public static bool type(in ClrTypes src, string name, out Type dst)
        {
            dst = default;
            for(var i=0u; i<src.Count; i++)
            {
                ref readonly var x = ref skip(src.Pairs,i);
                if(x.Value.Name == name)
                {
                    dst = x.Value;
                    return true;
                }
            }
            return false;
        }

        [MethodImpl(Inline), Op]
        public static ClrStruct @struct(Type src)
            => new ClrStruct(src);

    }
}