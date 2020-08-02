//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    public enum xed_isa_set_enum_t : byte
    {
        XED_ISA_SET_INVALID,
     
        XED_ISA_SET_3DNOW,
     
        XED_ISA_SET_ADOX_ADCX,
     
        XED_ISA_SET_AES,
     
        XED_ISA_SET_AMD,
     
        XED_ISA_SET_AVX,
     
        XED_ISA_SET_AVX2,
     
        XED_ISA_SET_AVX2GATHER,
     
        XED_ISA_SET_AVX512BW_128,
     
        XED_ISA_SET_AVX512BW_128N,
     
        XED_ISA_SET_AVX512BW_256,
     
        XED_ISA_SET_AVX512BW_512,
     
        XED_ISA_SET_AVX512BW_KOP,
     
        XED_ISA_SET_AVX512CD_128,
     
        XED_ISA_SET_AVX512CD_256,
     
        XED_ISA_SET_AVX512CD_512,
     
        XED_ISA_SET_AVX512DQ_128,
     
        XED_ISA_SET_AVX512DQ_128N,
     
        XED_ISA_SET_AVX512DQ_256,
     
        XED_ISA_SET_AVX512DQ_512,
     
        XED_ISA_SET_AVX512DQ_KOP,
     
        XED_ISA_SET_AVX512DQ_SCALAR,
        
        XED_ISA_SET_AVX512ER_512,
        
        XED_ISA_SET_AVX512ER_SCALAR,
        
        XED_ISA_SET_AVX512F_128,
        
        XED_ISA_SET_AVX512F_128N,
        
        XED_ISA_SET_AVX512F_256,
        
        XED_ISA_SET_AVX512F_512,
        
        XED_ISA_SET_AVX512F_KOP,
        
        XED_ISA_SET_AVX512F_SCALAR,
        
        XED_ISA_SET_AVX512PF_512,
        
        XED_ISA_SET_AVX512_4FMAPS_512,
        
        XED_ISA_SET_AVX512_4FMAPS_SCALAR,
        
        XED_ISA_SET_AVX512_4VNNIW_512,
        
        XED_ISA_SET_AVX512_BITALG_128,
        
        XED_ISA_SET_AVX512_BITALG_256,
        
        XED_ISA_SET_AVX512_BITALG_512,
        
        XED_ISA_SET_AVX512_GFNI_128,
        
        XED_ISA_SET_AVX512_GFNI_256,
        
        XED_ISA_SET_AVX512_GFNI_512,
        
        XED_ISA_SET_AVX512_IFMA_128,
        
        XED_ISA_SET_AVX512_IFMA_256,
        
        XED_ISA_SET_AVX512_IFMA_512,
        
        XED_ISA_SET_AVX512_VAES_128,
        
        XED_ISA_SET_AVX512_VAES_256,
        
        XED_ISA_SET_AVX512_VAES_512,
        
        XED_ISA_SET_AVX512_VBMI2_128,
        
        XED_ISA_SET_AVX512_VBMI2_256,
        
        XED_ISA_SET_AVX512_VBMI2_512,
        
        XED_ISA_SET_AVX512_VBMI_128,
        
        XED_ISA_SET_AVX512_VBMI_256,
        
        XED_ISA_SET_AVX512_VBMI_512,
        
        XED_ISA_SET_AVX512_VNNI_128,
        
        XED_ISA_SET_AVX512_VNNI_256,
        
        XED_ISA_SET_AVX512_VNNI_512,
        
        XED_ISA_SET_AVX512_VPCLMULQDQ_128,
        
        XED_ISA_SET_AVX512_VPCLMULQDQ_256,
        XED_ISA_SET_AVX512_VPCLMULQDQ_512,
        XED_ISA_SET_AVX512_VPOPCNTDQ_128,
        XED_ISA_SET_AVX512_VPOPCNTDQ_256,
        XED_ISA_SET_AVX512_VPOPCNTDQ_512,
        XED_ISA_SET_AVXAES,
        XED_ISA_SET_AVX_GFNI,
        XED_ISA_SET_BMI1,
        XED_ISA_SET_BMI2,
        XED_ISA_SET_CET,
        XED_ISA_SET_CLDEMOTE,
        XED_ISA_SET_CLFLUSHOPT,
        XED_ISA_SET_CLFSH,
        XED_ISA_SET_CLWB,
        XED_ISA_SET_CLZERO,
        XED_ISA_SET_CMOV,
        XED_ISA_SET_CMPXCHG16B,
        XED_ISA_SET_F16C,
        XED_ISA_SET_FAT_NOP,
        XED_ISA_SET_FCMOV,
        XED_ISA_SET_FMA,
        XED_ISA_SET_FMA4,
        XED_ISA_SET_FXSAVE,
        XED_ISA_SET_FXSAVE64,
        XED_ISA_SET_GFNI,
        XED_ISA_SET_I186,
        XED_ISA_SET_I286PROTECTED,
        XED_ISA_SET_I286REAL,
        XED_ISA_SET_I386,
        XED_ISA_SET_I486,
        XED_ISA_SET_I486REAL,
        XED_ISA_SET_I86,
        XED_ISA_SET_INVPCID,
        XED_ISA_SET_LAHF,
        XED_ISA_SET_LONGMODE,
        XED_ISA_SET_LZCNT,
        XED_ISA_SET_MONITOR,
        XED_ISA_SET_MONITORX,
        XED_ISA_SET_MOVBE,
        XED_ISA_SET_MOVDIR,
        XED_ISA_SET_MPX,
        XED_ISA_SET_PAUSE,
        XED_ISA_SET_PCLMULQDQ,
        XED_ISA_SET_PCONFIG,
        XED_ISA_SET_PENTIUMMMX,
        XED_ISA_SET_PENTIUMREAL,
        XED_ISA_SET_PKU,
        XED_ISA_SET_POPCNT,
        XED_ISA_SET_PPRO,
        XED_ISA_SET_PREFETCHW,
        XED_ISA_SET_PREFETCHWT1,
        XED_ISA_SET_PREFETCH_NOP,
        XED_ISA_SET_PT,
        XED_ISA_SET_RDPID,
        XED_ISA_SET_RDPMC,
        XED_ISA_SET_RDRAND,
        XED_ISA_SET_RDSEED,
        XED_ISA_SET_RDTSCP,
        XED_ISA_SET_RDWRFSGS,
        XED_ISA_SET_RTM,
        XED_ISA_SET_SGX,
        XED_ISA_SET_SGX_ENCLV,
        XED_ISA_SET_SHA,
        XED_ISA_SET_SMAP,
        XED_ISA_SET_SMX,
        XED_ISA_SET_SSE,
        XED_ISA_SET_SSE2,
        XED_ISA_SET_SSE2MMX,
        XED_ISA_SET_SSE3,
        XED_ISA_SET_SSE3X87,
        XED_ISA_SET_SSE4,
        XED_ISA_SET_SSE42,
        XED_ISA_SET_SSE4A,
        XED_ISA_SET_SSEMXCSR,
        XED_ISA_SET_SSE_PREFETCH,
        XED_ISA_SET_SSSE3,
        XED_ISA_SET_SSSE3MMX,
        XED_ISA_SET_SVM,
        XED_ISA_SET_TBM,
        XED_ISA_SET_VAES,
        XED_ISA_SET_VIA_PADLOCK_AES,
        XED_ISA_SET_VIA_PADLOCK_MONTMUL,
        XED_ISA_SET_VIA_PADLOCK_RNG,
        XED_ISA_SET_VIA_PADLOCK_SHA,
        XED_ISA_SET_VMFUNC,
        XED_ISA_SET_VPCLMULQDQ,
        XED_ISA_SET_VTX,
        XED_ISA_SET_WAITPKG,
        XED_ISA_SET_WBNOINVD,
        XED_ISA_SET_X87,
        XED_ISA_SET_XOP,
        XED_ISA_SET_XSAVE,
        XED_ISA_SET_XSAVEC,
        XED_ISA_SET_XSAVEOPT,
        XED_ISA_SET_XSAVES,
        XED_ISA_SET_LAST
    }

}