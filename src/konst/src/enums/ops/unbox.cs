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

    using NK = NumericKind;
    using EC = ClrEnumCode;

    partial class Enums
    {
        [Op]
        public static ulong unbox(NK nk, object src)
            => nk switch {
                NK.U8 => (ulong)(byte)src,
                NK.I8 => (ulong)(sbyte)src,
                NK.U16 => (ulong)(ushort)src,
                NK.I16 => (ulong)(short)src,
                NK.U32 => (ulong)(uint)src,
                NK.I32 => (ulong)(int)src,
                NK.I64 => (ulong)(long)src,
                NK.U64 => (ulong)src,
                _ => 0ul,
            };

        [Op]
        public static ulong unbox(EC ec, object src)
            => ec switch {
                EC.U8 => (ulong)(byte)src,
                EC.I8 => (ulong)(sbyte)src,
                EC.U16 => (ulong)(ushort)src,
                EC.I16 => (ulong)(short)src,
                EC.U32 => (ulong)(uint)src,
                EC.I32 => (ulong)(int)src,
                EC.I64 => (ulong)(long)src,
                EC.U64 => (ulong)src,
                _ => 0ul,
            };
    }
}