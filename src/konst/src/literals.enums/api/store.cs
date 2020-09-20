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

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static ref T store<E,T>(in E e, out T dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            dst = z.@as<E,T>(e);
            return ref dst;
        }

        /// <summary>
        /// Stores an enum value of any primal kind to a u64 target
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref ulong store<E>(in E src, out ulong dst)
            where E : unmanaged
        {
            dst = 0ul;
            var eSize = z.size<E>();
            if(eSize == 1)
                store(w8, src, ref dst);
            else if(eSize == 2)
                store(w16, src, ref dst);
            else if(eSize == 4)
                store(w32, src, ref dst);
            else
                store(w64, src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref byte store<E>(W8 w, in E src, ref ulong dst)
            where E : unmanaged
        {
            ref var u8 = ref z.@as<E,byte>(src);
            dst = u8;
            return ref u8;
        }

        [MethodImpl(Inline)]
        public static ref ushort store<E>(W16 w, in E src, ref ulong dst)
            where E : unmanaged
        {
            ref var tVal = ref z.@as<E,ushort>(src);
            dst = tVal;
            return ref tVal;
        }

        [MethodImpl(Inline)]
        public static ref uint store<E>(W32 w, in E src, ref ulong dst)
            where E : unmanaged
        {
            ref var tVal = ref z.@as<E,uint>(src);
            dst = tVal;
            return ref tVal;
        }

        [MethodImpl(Inline)]
        public static ref ulong store<E>(W64 w, in E src, ref ulong dst)
            where E : unmanaged
        {
            ref var tVal = ref z.@as<E,ulong>(src);
            dst = tVal;
            return ref tVal;
        }

        [Op]
        public static void store(PartId part, Type src, Span<EnumLiteralRow> dst)
        {
            var fields = span(src.LiteralFields());
            var tc = PrimalKinds.ecode(src);
            store(part, src, tc, fields, dst);
        }

        [Op]
        public static void store(PartId part, Type type, EnumTypeCode tc, ReadOnlySpan<FieldInfo> fields, Span<EnumLiteralRow> dst)
        {
            var count = fields.Length;
            var address = type.TypeHandle.Value;
            for(var i=0u; i<count; i++)
            {
                ref readonly var f = ref z.skip(fields,i);
                var nameAddress = z.address(f.Name);
                seek(dst,i) = new EnumLiteralRow(part, type, address, (ushort)i, f.Name, nameAddress, (EnumScalarKind)tc, Enums.unbox(tc, f.GetRawConstantValue()));
            }
        }
    }
}