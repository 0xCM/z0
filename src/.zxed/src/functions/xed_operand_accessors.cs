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
    using static xed_machine_mode_enum_t;

    [ApiHost]
    public readonly struct xed_operand_accessors
    {
        [MethodImpl(Inline), Op]
        public static xed_bits_t xed3_operand_get_reg(in xed_decoded_inst_t d)
            => d._operands.reg;

        [MethodImpl(Inline), Op]
        public static xed_bits_t xed3_operand_get_mod(in xed_decoded_inst_t d)
            => d._operands.mod;

        [MethodImpl(Inline), Op]
        public static void xed3_operand_set_outreg(ref xed_decoded_inst_t d, xed_reg_enum_t opval)    
            => d._operands.outreg = opval;

        [Op]
        public static void xed3_operand_set_mode(ref xed_decoded_inst_t d, xed_machine_mode_enum_t mm)            
        {
            switch(mm)
            {
                case XED_MACHINE_MODE_LONG_64:
                    d._operands.mode = xed_operand_mode.mode64;
                    return;
                    
                case XED_MACHINE_MODE_LEGACY_32:
                case XED_MACHINE_MODE_LONG_COMPAT_32:
                    d._operands.mode = xed_operand_mode.mode32;
                    break;

                case XED_MACHINE_MODE_REAL_16:
                    d._operands.mode = xed_operand_mode.mode16;
                    break;
                    
                case XED_MACHINE_MODE_REAL_32:
                    d._operands.mode = xed_operand_mode.mode32;
                    break;

                case XED_MACHINE_MODE_LEGACY_16:
                case XED_MACHINE_MODE_LONG_COMPAT_16:
                    d._operands.mode = xed_operand_mode.mode16;
                    break;
                default:
                    term.error("Bad machine mode in xed_operand_values_set_mode() call");
                    break;
            }
        }
    }
}