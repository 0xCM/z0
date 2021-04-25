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

    using PK = ClrPrimalKind;

    [ApiHost(ApiNames.ClrEnums, true)]
    public readonly partial struct ClrEnums
    {
        [MethodImpl(Inline)]
        public static ClrEnum<E> @enum<E>()
            where E : unmanaged, Enum
                => default;

        [Op]
        public static ulong @ulong(ClrPrimalKind kind, object src)
            => kind switch {
                PK.U8 => (ulong)(byte)src,
                PK.I8 => (ulong)(sbyte)src,
                PK.U16 => (ulong)(ushort)src,
                PK.I16 => (ulong)(short)src,
                PK.U32 => (ulong)(uint)src,
                PK.I32 => (ulong)(int)src,
                PK.I64 => (ulong)(long)src,
                PK.U64 => (ulong)src,
                _ => 0ul,
            };
    }
}