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

    public class xed_operand_accessors
    {
        [MethodImpl(Inline)]
        public static xed_bits_t xed3_operand_get_reg(in xed_decoded_inst_t d)
            => d._operands.reg;

        [MethodImpl(Inline)]
        public static xed_bits_t xed3_operand_get_mod(in xed_decoded_inst_t d)
            => d._operands.mod;

        [MethodImpl(Inline)]
        public static void xed3_operand_set_outreg(ref xed_decoded_inst_t d, xed_reg_enum_t opval)    
            => d._operands.outreg = opval;
    }
}