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
        [MethodImpl(Inline), Op]
        public static ClrMemberIdentity identity(FieldInfo src)
            => ClrMemberIdentity.from(src);

        [MethodImpl(Inline), Op]
        public readonly void enums(in ReadOnlySpan<Type> src, Span<ClrEnum> dst)
        {
            var count = src.Length;
            for(uint i=0, j=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(src,i);
                if(candidate.IsEnum)
                    seek(dst, j++) = candidate;
            }
        }

        [MethodImpl(Inline), Op]
        public static Indexed<Type> interfaces(Type src)
            => src.GetInterfaces();

        [MethodImpl(Inline), Op]
        public static ClrInterfaceMap imap(Type host, Type contract)
            => @as<InterfaceMapping,ClrInterfaceMap>(host.GetInterfaceMap(contract));

        [MethodImpl(Inline), Op]
        public static ClrTypes index(Type[] src)
            => ClrTypes.create(src);

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

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ClrStruct @struct<T>()
            where T : struct
                => new ClrStruct<T>(typeof(T));

        [MethodImpl(Inline), Op]
        public static Z0.EnumLiteralNames[] names(ReadOnlySpan<ClrEnum> src)
        {
            var count = src.Length;
            var buffer = z.alloc<Z0.EnumLiteralNames>(count);
            var dst  = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var et = ref skip(src,i);
                seek(dst,i) = new Z0.EnumLiteralNames(et, System.Enum.GetNames(et));
            }

            return buffer;
        }
    }
}