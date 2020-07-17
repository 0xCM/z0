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
    using static math;

    [ApiHost]
    public struct xed_uint8_t
    {
        public byte data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_operand_enum_t(xed_uint8_t src)
            => (xed_operand_enum_t)src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_bits_t(xed_uint8_t src)
            => new xed_bits_t(src.data);

        [MethodImpl(Inline), Op]
        public static implicit operator xed_operand_type_enum_t(xed_uint8_t src)
            => (xed_operand_type_enum_t)src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_chip_enum_t(xed_uint8_t src)
            => (xed_chip_enum_t)src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_uint8_t(xed_chip_enum_t src)
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_operand_visibility_enum_t(xed_uint8_t src)
            => (xed_operand_visibility_enum_t)src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_operand_element_xtype_enum_t(xed_uint8_t src)
            => (xed_operand_element_xtype_enum_t)src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_operand_width_enum_t(xed_uint8_t src)
            => (xed_operand_width_enum_t)src.data;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_nonterminal_enum_t(xed_uint8_t src)
            => (xed_nonterminal_enum_t)src.data;

        [MethodImpl(Inline), Op]
        public static xed_uint8_t operator <<(xed_uint8_t src, int shift)
            => sll(src.data, (byte)shift);
        
        [MethodImpl(Inline), Op]
        public static xed_uint8_t operator >>(xed_uint8_t src, int shift)
            => srl(src.data, (byte)shift);

        [MethodImpl(Inline), Op]
        public static xed_uint8_t operator &(xed_uint8_t x, xed_uint8_t y)
            => and(x.data, y.data);

        [MethodImpl(Inline), Op]
        public static xed_uint8_t operator|(xed_uint8_t x, xed_uint8_t y)
            => or(x.data, y.data);

        [MethodImpl(Inline), Op]
        public static implicit operator byte(xed_uint8_t src)
            => src.data;
                
        [MethodImpl(Inline), Op]
        public static implicit operator bool(xed_uint8_t src)
            => src.data != 0;

        [MethodImpl(Inline), Op]
        public static implicit operator xed_uint32_t(xed_uint8_t src)
            => new xed_uint32_t(src.data);

        [MethodImpl(Inline), Op]
        public static implicit operator xed_uint8_t(byte src)
            => new xed_uint8_t(src);

        [MethodImpl(Inline), Op]
        public static implicit operator xed_uint8_t(bool src)
            => new xed_uint8_t(z.@byte(src));

        [MethodImpl(Inline), Op]
        public static bool operator true(xed_uint8_t src)
            => src != 0;

        [MethodImpl(Inline), Op]
        public static bool operator false(xed_uint8_t src)
            => src == 0;

        [MethodImpl(Inline), Op]
        public xed_uint8_t(byte src)
            => data = src;
    }
}