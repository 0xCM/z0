//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    partial class Xed
    {
        public static xed_uint32_t xed_modrm_mod(xed_uint8_t m) { return m >> 6; }

        public static xed_uint32_t xed_modrm_reg(xed_uint8_t m) { return (m >> 3)&7; }

        public static xed_uint32_t xed_modrm_rm(xed_uint8_t m) { return m & 7; }

        public static xed_uint32_t xed_sib_scale(xed_uint8_t m) { return m >> 6; }

        public static xed_uint32_t xed_sib_index(xed_uint8_t m) { return (m >> 3) & 7; }

        public static xed_uint32_t xed_sib_base(xed_uint8_t m) { return m&7; }

        public static xed_uint32_t bits2bytes(xed_uint32_t bits) { return bits>>3; }

        public static xed_uint32_t bytes2bits(xed_uint32_t bytes) { return bytes<<3; }
    }
}