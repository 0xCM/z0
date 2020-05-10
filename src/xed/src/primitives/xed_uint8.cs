//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public struct xed_uint8_t
    {
        public byte data;

        [MethodImpl(Inline)]
        public static implicit operator xed_operand_enum_t(xed_uint8_t src)
            => (xed_operand_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_bits_t(xed_uint8_t src)
            => new xed_bits_t(src.data);

        [MethodImpl(Inline)]
        public static implicit operator xed_operand_type_enum_t(xed_uint8_t src)
            => (xed_operand_type_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_operand_visibility_enum_t(xed_uint8_t src)
            => (xed_operand_visibility_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_operand_element_xtype_enum_t(xed_uint8_t src)
            => (xed_operand_element_xtype_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_operand_width_enum_t(xed_uint8_t src)
            => (xed_operand_width_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator xed_nonterminal_enum_t(xed_uint8_t src)
            => (xed_nonterminal_enum_t)src.data;

        [MethodImpl(Inline)]
        public static implicit operator byte(xed_uint8_t src)
            => src.data;
                
        [MethodImpl(Inline)]
        public static implicit operator bool(xed_uint8_t src)
            => src.data != 0;

        [MethodImpl(Inline)]
        public static implicit operator xed_uint8_t(byte src)
            => new xed_uint8_t(src);

        [MethodImpl(Inline)]
        public static implicit operator xed_uint8_t(bool src)
            => src ? true : false;

        [MethodImpl(Inline)]
        public static bool operator true(xed_uint8_t src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool operator false(xed_uint8_t src)
            => src == 0;

        [MethodImpl(Inline)]
        public xed_uint8_t(byte src)
            => data = src;
    }
}