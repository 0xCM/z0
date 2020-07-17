//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    public enum xed_attribute_enum_t : byte
    {
        XED_ATTRIBUTE_INVALID,
        
        XED_ATTRIBUTE_AMDONLY,
        
        XED_ATTRIBUTE_ATT_OPERAND_ORDER_EXCEPTION,
        
        XED_ATTRIBUTE_BROADCAST_ENABLED,
        
        XED_ATTRIBUTE_BYTEOP,
        
        XED_ATTRIBUTE_DISP8_EIGHTHMEM,
        
        XED_ATTRIBUTE_DISP8_FULL,
        
        XED_ATTRIBUTE_DISP8_FULLMEM,
        
        XED_ATTRIBUTE_DISP8_GPR_READER,
        
        XED_ATTRIBUTE_DISP8_GPR_READER_BYTE,
        
        XED_ATTRIBUTE_DISP8_GPR_READER_WORD,
        
        XED_ATTRIBUTE_DISP8_GPR_WRITER_LDOP_D,
        
        XED_ATTRIBUTE_DISP8_GPR_WRITER_LDOP_Q,
        
        XED_ATTRIBUTE_DISP8_GPR_WRITER_STORE,
        
        XED_ATTRIBUTE_DISP8_GPR_WRITER_STORE_BYTE,
        
        XED_ATTRIBUTE_DISP8_GPR_WRITER_STORE_WORD,
        
        XED_ATTRIBUTE_DISP8_GSCAT,
        
        XED_ATTRIBUTE_DISP8_HALF,
        
        XED_ATTRIBUTE_DISP8_HALFMEM,
        
        XED_ATTRIBUTE_DISP8_MEM128,
        
        XED_ATTRIBUTE_DISP8_MOVDDUP,
        
        XED_ATTRIBUTE_DISP8_QUARTERMEM,
        
        XED_ATTRIBUTE_DISP8_SCALAR,
        
        XED_ATTRIBUTE_DISP8_TUPLE1,
        
        XED_ATTRIBUTE_DISP8_TUPLE1_4X,
        
        XED_ATTRIBUTE_DISP8_TUPLE1_BYTE,
        
        XED_ATTRIBUTE_DISP8_TUPLE1_WORD,
        
        XED_ATTRIBUTE_DISP8_TUPLE2,
        
        XED_ATTRIBUTE_DISP8_TUPLE4,
        XED_ATTRIBUTE_DISP8_TUPLE8,
        XED_ATTRIBUTE_DOUBLE_WIDE_MEMOP,
        XED_ATTRIBUTE_DOUBLE_WIDE_OUTPUT,
        XED_ATTRIBUTE_DWORD_INDICES,
        XED_ATTRIBUTE_ELEMENT_SIZE_D,
        XED_ATTRIBUTE_ELEMENT_SIZE_Q,
        XED_ATTRIBUTE_EXCEPTION_BR,
        XED_ATTRIBUTE_FAR_XFER,
        XED_ATTRIBUTE_FIXED_BASE0,
        XED_ATTRIBUTE_FIXED_BASE1,
        XED_ATTRIBUTE_GATHER,
        XED_ATTRIBUTE_HALF_WIDE_OUTPUT,
        XED_ATTRIBUTE_HLE_ACQ_ABLE,
        XED_ATTRIBUTE_HLE_REL_ABLE,
        XED_ATTRIBUTE_IGNORES_OSFXSR,
        XED_ATTRIBUTE_IMPLICIT_ONE,
        XED_ATTRIBUTE_INDEX_REG_IS_POINTER,
        XED_ATTRIBUTE_INDIRECT_BRANCH,
        XED_ATTRIBUTE_KMASK,
        XED_ATTRIBUTE_LOCKABLE,
        XED_ATTRIBUTE_LOCKED,
        XED_ATTRIBUTE_MASKOP,
        XED_ATTRIBUTE_MASKOP_EVEX,
        XED_ATTRIBUTE_MASK_AS_CONTROL,
        XED_ATTRIBUTE_MASK_VARIABLE_MEMOP,
        XED_ATTRIBUTE_MEMORY_FAULT_SUPPRESSION,
        XED_ATTRIBUTE_MMX_EXCEPT,
        XED_ATTRIBUTE_MPX_PREFIX_ABLE,
        XED_ATTRIBUTE_MULTISOURCE4,
        XED_ATTRIBUTE_MXCSR,
        XED_ATTRIBUTE_MXCSR_RD,
        XED_ATTRIBUTE_NONTEMPORAL,
        XED_ATTRIBUTE_NOP,
        XED_ATTRIBUTE_NOTSX,
        XED_ATTRIBUTE_NOTSX_COND,
        XED_ATTRIBUTE_NO_RIP_REL,
        XED_ATTRIBUTE_PREFETCH,
        XED_ATTRIBUTE_PROTECTED_MODE,
        XED_ATTRIBUTE_QWORD_INDICES,
        XED_ATTRIBUTE_REP,
        XED_ATTRIBUTE_REQUIRES_ALIGNMENT,
        XED_ATTRIBUTE_RING0,
        XED_ATTRIBUTE_SCALABLE,
        XED_ATTRIBUTE_SCATTER,
        XED_ATTRIBUTE_SIMD_SCALAR,
        XED_ATTRIBUTE_SKIPLOW32,
        XED_ATTRIBUTE_SKIPLOW64,
        XED_ATTRIBUTE_SPECIAL_AGEN_REQUIRED,
        XED_ATTRIBUTE_STACKPOP0,
        XED_ATTRIBUTE_STACKPOP1,
        XED_ATTRIBUTE_STACKPUSH0,
        XED_ATTRIBUTE_STACKPUSH1,
        XED_ATTRIBUTE_X87_CONTROL,
        XED_ATTRIBUTE_X87_MMX_STATE_CW,
        XED_ATTRIBUTE_X87_MMX_STATE_R,
        XED_ATTRIBUTE_X87_MMX_STATE_W,
        XED_ATTRIBUTE_X87_NOWAIT,
        XED_ATTRIBUTE_XMM_STATE_CW,
        XED_ATTRIBUTE_XMM_STATE_R,
        XED_ATTRIBUTE_XMM_STATE_W,
        XED_ATTRIBUTE_LAST        
    }
}