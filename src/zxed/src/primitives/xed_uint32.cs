//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
                
    [ApiHost]
    public struct xed_uint32_t
    {
        public uint data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_reg_enum_t(xed_uint32_t src)
            => (xed_reg_enum_t)src;

        [MethodImpl(Inline), Op]
        public static implicit operator uint(xed_uint32_t src)
            => src.data;

        [MethodImpl(Inline), Op]
        public static explicit operator byte(xed_uint32_t src)
            => (byte)src.data;

        [MethodImpl(Inline), Op]
        public static explicit operator ushort(xed_uint32_t src)
            => (byte)src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_uint32_t(uint src)
            => new xed_uint32_t(src);

        [MethodImpl(Inline), Op]
        public static implicit operator xed_uint32_t(bool src)
            => src ? true : false;

        [MethodImpl(Inline), Op]
        public static implicit operator bool(xed_uint32_t src)
            => src.data != 0;

        [MethodImpl(Inline), Op]
        public static bool operator true(xed_uint32_t src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bool operator false(xed_uint32_t src)
            => src == 0;

        [MethodImpl(Inline), Op]
        public xed_uint32_t(uint src)
            => data = src;
    }
}