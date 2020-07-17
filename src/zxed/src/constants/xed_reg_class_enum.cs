//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    public enum xed_reg_class_enum_t : byte
    {
        XED_REG_CLASS_INVALID,

        XED_REG_CLASS_BNDCFG,

        XED_REG_CLASS_BNDSTAT,

        XED_REG_CLASS_BOUND,

        XED_REG_CLASS_CR,

        XED_REG_CLASS_DR,

        XED_REG_CLASS_FLAGS,

        XED_REG_CLASS_GPR,

        XED_REG_CLASS_GPR16,

        XED_REG_CLASS_GPR32,

        XED_REG_CLASS_GPR64,

        XED_REG_CLASS_GPR8,

        XED_REG_CLASS_IP,

        XED_REG_CLASS_MASK,

        XED_REG_CLASS_MMX,

        XED_REG_CLASS_MSR,

        XED_REG_CLASS_MXCSR,

        XED_REG_CLASS_PSEUDO,

        XED_REG_CLASS_PSEUDOX87,

        XED_REG_CLASS_SR,

        XED_REG_CLASS_TMP,

        XED_REG_CLASS_X87,

        XED_REG_CLASS_XCR,

        XED_REG_CLASS_XMM,

        XED_REG_CLASS_YMM,

        XED_REG_CLASS_ZMM,

        XED_REG_CLASS_LAST        
    }
}