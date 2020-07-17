//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    public enum xed_cpuid_bit_enum_t : byte
    {
        XED_CPUID_BIT_INVALID,

        XED_CPUID_BIT_ADOXADCX,

        XED_CPUID_BIT_AES,

        XED_CPUID_BIT_AVX,

        XED_CPUID_BIT_AVX2,

        XED_CPUID_BIT_AVX512BW,

        XED_CPUID_BIT_AVX512CD,

        XED_CPUID_BIT_AVX512DQ,

        XED_CPUID_BIT_AVX512ER,

        XED_CPUID_BIT_AVX512F,

        XED_CPUID_BIT_AVX512IFMA,

        XED_CPUID_BIT_AVX512PF,

        XED_CPUID_BIT_AVX512VBMI,

        XED_CPUID_BIT_AVX512VL,

        XED_CPUID_BIT_AVX512_4FMAPS,

        XED_CPUID_BIT_AVX512_4VNNIW,

        XED_CPUID_BIT_AVX512_BITALG,

        XED_CPUID_BIT_AVX512_VBMI2,

        XED_CPUID_BIT_AVX512_VNNI,

        XED_CPUID_BIT_AVX512_VPOPCNTDQ,

        XED_CPUID_BIT_BMI1,

        XED_CPUID_BIT_BMI2,

        XED_CPUID_BIT_CET,

        XED_CPUID_BIT_CLDEMOTE,

        XED_CPUID_BIT_CLFLUSH,

        XED_CPUID_BIT_CLFLUSHOPT,

        XED_CPUID_BIT_CLWB,

        XED_CPUID_BIT_CMPXCHG16B,

        XED_CPUID_BIT_F16C,

        XED_CPUID_BIT_FMA,

        XED_CPUID_BIT_FXSAVE,

        XED_CPUID_BIT_GFNI,

        XED_CPUID_BIT_INTEL64,

        XED_CPUID_BIT_INTELPT,

        XED_CPUID_BIT_INVPCID,

        XED_CPUID_BIT_LAHF,
        XED_CPUID_BIT_LZCNT,
        XED_CPUID_BIT_MONITOR,
        XED_CPUID_BIT_MONITORX,
        XED_CPUID_BIT_MOVDIR64B,
        XED_CPUID_BIT_MOVDIRI,
        XED_CPUID_BIT_MOVEBE,
        XED_CPUID_BIT_MPX,
        XED_CPUID_BIT_OSPKU,
        XED_CPUID_BIT_OSXSAVE,
        XED_CPUID_BIT_PCLMULQDQ,
        XED_CPUID_BIT_PCONFIG,
        XED_CPUID_BIT_PKU,
        XED_CPUID_BIT_POPCNT,
        XED_CPUID_BIT_PREFETCHW,
        XED_CPUID_BIT_PREFETCHWT1,
        XED_CPUID_BIT_PTWRITE,
        XED_CPUID_BIT_RDP,
        XED_CPUID_BIT_RDRAND,
        XED_CPUID_BIT_RDSEED,
        XED_CPUID_BIT_RDTSCP,
        XED_CPUID_BIT_RDWRFSGS,
        XED_CPUID_BIT_RTM,
        XED_CPUID_BIT_SGX,
        XED_CPUID_BIT_SHA,
        XED_CPUID_BIT_SMAP,
        XED_CPUID_BIT_SMX,
        XED_CPUID_BIT_SSE,
        XED_CPUID_BIT_SSE2,
        XED_CPUID_BIT_SSE3,
        XED_CPUID_BIT_SSE4,
        XED_CPUID_BIT_SSE42,
        
        XED_CPUID_BIT_SSSE3,
        
        XED_CPUID_BIT_VAES,
        
        XED_CPUID_BIT_VIA_PADLOCK_AES,
        
        XED_CPUID_BIT_VIA_PADLOCK_AES_EN,
        
        XED_CPUID_BIT_VIA_PADLOCK_PMM,
        
        XED_CPUID_BIT_VIA_PADLOCK_PMM_EN,
        
        XED_CPUID_BIT_VIA_PADLOCK_RNG,
        
        XED_CPUID_BIT_VIA_PADLOCK_RNG_EN,
        
        XED_CPUID_BIT_VIA_PADLOCK_SHA,
        
        XED_CPUID_BIT_VIA_PADLOCK_SHA_EN,
        
        XED_CPUID_BIT_VMX,
        
        XED_CPUID_BIT_VPCLMULQDQ,
        
        XED_CPUID_BIT_WAITPKG,
        
        XED_CPUID_BIT_WBNOINVD,
        
        XED_CPUID_BIT_XSAVE,
        
        XED_CPUID_BIT_XSAVEC,
        
        XED_CPUID_BIT_XSAVEOPT,
 
        XED_CPUID_BIT_XSAVES,
 
        XED_CPUID_BIT_LAST

    }

}