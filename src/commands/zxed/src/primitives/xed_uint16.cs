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
        
    public struct xed_uint16_t
    {
        public ushort data;

        [MethodImpl(Inline)]
        public static implicit operator xed_iform_enum_t(xed_uint16_t src)
            => (xed_iform_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_iclass_enum_t(xed_uint16_t src)
            => (xed_iclass_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_category_enum_t(xed_uint16_t src)
            => (xed_category_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_extension_enum_t(xed_uint16_t src)
            => (xed_extension_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_reg_enum_t(xed_uint16_t src)
            => (xed_reg_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_uint16_t(xed_reg_enum_t src)
            => new xed_uint16_t((ushort)src);

        [MethodImpl(Inline)]
        public static implicit operator xed_isa_set_enum_t(xed_uint16_t src)
            => (xed_isa_set_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator ushort(xed_uint16_t src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_uint16_t(ushort src)
            => new xed_uint16_t(src);

        [MethodImpl(Inline)]
        public static bool operator true(xed_uint16_t src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool operator false(xed_uint16_t src)
            => src == 0;

        [MethodImpl(Inline)]
        public static implicit operator xed_uint16_t(bool src)
            => src ? true : false;

        [MethodImpl(Inline)]
        public static implicit operator bool(xed_uint16_t src)
            => src.data != 0;

        [MethodImpl(Inline)]
        public xed_uint16_t(ushort src)
            => data = src;
    }
}