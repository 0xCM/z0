//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct LlvmModels
    {
        public enum SimpleValueType : byte
        {
            // Simple value types that aren't explicitly part of this enumeration
            // are considered extended value types.
            INVALID_SIMPLE_VALUE_TYPE = 0,

            // If you change this numbering, you must change the values in
            // ValueTypes.td as well!
            Other          =   1,   // This is a non-standard value

            i1             =   2,   // This is a 1 bit integer value

            i8             =   3,   // This is an 8 bit integer value

            i16            =   4,   // This is a 16 bit integer value

            i32            =   5,   // This is a 32 bit integer value

            i64            =   6,   // This is a 64 bit integer value

            i128           =   7,   // This is a 128 bit integer value

            FIRST_INTEGER_VALUETYPE = i1,
            LAST_INTEGER_VALUETYPE  = i128,

            bf16           =   8,   // This is a 16 bit brain floating point value
            f16            =   9,   // This is a 16 bit floating point value
            f32            =  10,   // This is a 32 bit floating point value
            f64            =  11,   // This is a 64 bit floating point value
            f80            =  12,   // This is a 80 bit floating point value
            f128           =  13,   // This is a 128 bit floating point value
            ppcf128        =  14,   // This is a PPC 128-bit floating point value

            FIRST_FP_VALUETYPE = bf16,
            LAST_FP_VALUETYPE  = ppcf128,

            v1i1           =  15,   //    1 x i1
            v2i1           =  16,   //    2 x i1
            v4i1           =  17,   //    4 x i1
            v8i1           =  18,   //    8 x i1
            v16i1          =  19,   //   16 x i1
            v32i1          =  20,   //   32 x i1
            v64i1          =  21,   //   64 x i1
            v128i1         =  22,   //  128 x i1
            v256i1         =  23,   //  256 x i1
            v512i1         =  24,   //  512 x i1
            v1024i1        =  25,   // 1024 x i1

            v1i8           =  26,   //    1 x i8
            v2i8           =  27,   //    2 x i8
            v4i8           =  28,   //    4 x i8
            v8i8           =  29,   //    8 x i8
            v16i8          =  30,   //   16 x i8
            v32i8          =  31,   //   32 x i8
            v64i8          =  32,   //   64 x i8
            v128i8         =  33,   //  128 x i8
            v256i8         =  34,   //  256 x i8
            v512i8         =  35,   //  512 x i8
            v1024i8        =  36,   // 1024 x i8

            v1i16          =  37,   //   1 x i16
            v2i16          =  38,   //   2 x i16
            v3i16          =  39,   //   3 x i16
            v4i16          =  40,   //   4 x i16
            v8i16          =  41,   //   8 x i16
            v16i16         =  42,   //  16 x i16
            v32i16         =  43,   //  32 x i16
            v64i16         =  44,   //  64 x i16
            v128i16        =  45,   // 128 x i16
            v256i16        =  46,   // 256 x i16
            v512i16        =  47,   // 512 x i16

            v1i32          =  48,   //    1 x i32
            v2i32          =  49,   //    2 x i32
            v3i32          =  50,   //    3 x i32
            v4i32          =  51,   //    4 x i32
            v5i32          =  52,   //    5 x i32
            v6i32          =  53,   //    6 x i32
            v7i32          =  54,   //    7 x i32
            v8i32          =  55,   //    8 x i32
            v16i32         =  56,   //   16 x i32
            v32i32         =  57,   //   32 x i32
            v64i32         =  58,   //   64 x i32
            v128i32        =  59,   //  128 x i32
            v256i32        =  60,   //  256 x i32
            v512i32        =  61,   //  512 x i32
            v1024i32       =  62,   // 1024 x i32
            v2048i32       =  63,   // 2048 x i32

            v1i64          =  64,   //   1 x i64
            v2i64          =  65,   //   2 x i64
            v3i64          =  66,   //   3 x i64
            v4i64          =  67,   //   4 x i64
            v8i64          =  68,   //   8 x i64
            v16i64         =  69,   //  16 x i64
            v32i64         =  70,   //  32 x i64
            v64i64         =  71,   //  64 x i64
            v128i64        =  72,   // 128 x i64
            v256i64        =  73,   // 256 x i64

            v1i128         =  74,   //  1 x i128

            FIRST_INTEGER_FIXEDLEN_VECTOR_VALUETYPE = v1i1,
            LAST_INTEGER_FIXEDLEN_VECTOR_VALUETYPE = v1i128,

            v1f16          =  75,   //    1 x f16
            v2f16          =  76,   //    2 x f16
            v3f16          =  77,   //    3 x f16
            v4f16          =  78,   //    4 x f16
            v8f16          =  79,   //    8 x f16
            v16f16         =  80,   //   16 x f16
            v32f16         =  81,   //   32 x f16
            v64f16         =  82,   //   64 x f16
            v128f16        =  83,   //  128 x f16
            v256f16        =  84,   //  256 x f16
            v512f16        =  85,   //  256 x f16

            v2bf16         =  86,   //    2 x bf16
            v3bf16         =  87,   //    3 x bf16
            v4bf16         =  88,   //    4 x bf16
            v8bf16         =  89,   //    8 x bf16
            v16bf16        =  90,   //   16 x bf16
            v32bf16        =  91,   //   32 x bf16
            v64bf16        =  92,   //   64 x bf16
            v128bf16       =  93,   //  128 x bf16

            v1f32          =  94,   //    1 x f32
            v2f32          =  95,   //    2 x f32
            v3f32          =  96,   //    3 x f32
            v4f32          =  97,   //    4 x f32
            v5f32          =  98,   //    5 x f32
            v6f32          =  99,   //    6 x f32
            v7f32          = 100,   //    7 x f32
            v8f32          = 101,   //    8 x f32
            v16f32         = 102,   //   16 x f32
            v32f32         = 103,   //   32 x f32
            v64f32         = 104,   //   64 x f32
            v128f32        = 105,   //  128 x f32
            v256f32        = 106,   //  256 x f32
            v512f32        = 107,   //  512 x f32
            v1024f32       = 108,   // 1024 x f32
            v2048f32       = 109,   // 2048 x f32

            v1f64          = 110,   //    1 x f64
            v2f64          = 111,   //    2 x f64
            v3f64          = 112,   //    3 x f64
            v4f64          = 113,   //    4 x f64
            v8f64          = 114,   //    8 x f64
            v16f64         = 115,   //   16 x f64
            v32f64         = 116,   //   32 x f64
            v64f64         = 117,   //   64 x f64
            v128f64        = 118,   //  128 x f64
            v256f64        = 119,   //  256 x f64

            FIRST_FP_FIXEDLEN_VECTOR_VALUETYPE = v1f16,
            LAST_FP_FIXEDLEN_VECTOR_VALUETYPE = v256f64,

            FIRST_FIXEDLEN_VECTOR_VALUETYPE = v1i1,
            LAST_FIXEDLEN_VECTOR_VALUETYPE = v256f64,

            nxv1i1         = 120,   // n x  1 x i1
            nxv2i1         = 121,   // n x  2 x i1
            nxv4i1         = 122,   // n x  4 x i1
            nxv8i1         = 123,   // n x  8 x i1
            nxv16i1        = 124,   // n x 16 x i1
            nxv32i1        = 125,   // n x 32 x i1
            nxv64i1        = 126,   // n x 64 x i1

            nxv1i8         = 127,   // n x  1 x i8
            nxv2i8         = 128,   // n x  2 x i8
            nxv4i8         = 129,   // n x  4 x i8
            nxv8i8         = 130,   // n x  8 x i8
            nxv16i8        = 131,   // n x 16 x i8
            nxv32i8        = 132,   // n x 32 x i8
            nxv64i8        = 133,   // n x 64 x i8

            nxv1i16        = 134,  // n x  1 x i16
            nxv2i16        = 135,  // n x  2 x i16
            nxv4i16        = 136,  // n x  4 x i16
            nxv8i16        = 137,  // n x  8 x i16
            nxv16i16       = 138,  // n x 16 x i16
            nxv32i16       = 139,  // n x 32 x i16

            nxv1i32        = 140,  // n x  1 x i32
            nxv2i32        = 141,  // n x  2 x i32
            nxv4i32        = 142,  // n x  4 x i32
            nxv8i32        = 143,  // n x  8 x i32
            nxv16i32       = 144,  // n x 16 x i32
            nxv32i32       = 145,  // n x 32 x i32

            nxv1i64        = 146,  // n x  1 x i64
            nxv2i64        = 147,  // n x  2 x i64
            nxv4i64        = 148,  // n x  4 x i64
            nxv8i64        = 149,  // n x  8 x i64
            nxv16i64       = 150,  // n x 16 x i64
            nxv32i64       = 151,  // n x 32 x i64

            FIRST_INTEGER_SCALABLE_VECTOR_VALUETYPE = nxv1i1,
            LAST_INTEGER_SCALABLE_VECTOR_VALUETYPE = nxv32i64,

            nxv1f16        = 152,  // n x  1 x f16
            nxv2f16        = 153,  // n x  2 x f16
            nxv4f16        = 154,  // n x  4 x f16
            nxv8f16        = 155,  // n x  8 x f16
            nxv16f16       = 156,  // n x 16 x f16
            nxv32f16       = 157,  // n x 32 x f16

            nxv1bf16       = 158,  // n x  1 x bf16
            nxv2bf16       = 159,  // n x  2 x bf16
            nxv4bf16       = 160,  // n x  4 x bf16
            nxv8bf16       = 161,  // n x  8 x bf16

            nxv1f32        = 162,  // n x  1 x f32
            nxv2f32        = 163,  // n x  2 x f32
            nxv4f32        = 164,  // n x  4 x f32
            nxv8f32        = 165,  // n x  8 x f32
            nxv16f32       = 166,  // n x 16 x f32

            nxv1f64        = 167,  // n x  1 x f64
            nxv2f64        = 168,  // n x  2 x f64
            nxv4f64        = 169,  // n x  4 x f64
            nxv8f64        = 170,  // n x  8 x f64

            FIRST_FP_SCALABLE_VECTOR_VALUETYPE = nxv1f16,
            LAST_FP_SCALABLE_VECTOR_VALUETYPE = nxv8f64,

            FIRST_SCALABLE_VECTOR_VALUETYPE = nxv1i1,
            LAST_SCALABLE_VECTOR_VALUETYPE = nxv8f64,

            FIRST_VECTOR_VALUETYPE = v1i1,
            LAST_VECTOR_VALUETYPE  = nxv8f64,

            x86mmx         = 171,    // This is an X86 MMX value

            Glue           = 172,    // This glues nodes together during pre-RA sched

            isVoid         = 173,    // This has no value

            Untyped        = 174,    // This value takes a register, but has
                                    // unspecified type.  The register class
                                    // will be determined by the opcode.

            funcref        = 175,    // WebAssembly's funcref type
            externref      = 176,    // WebAssembly's externref type
            x86amx         = 177,    // This is an X86 AMX value

            FIRST_VALUETYPE =  1,    // This is always the beginning of the list.
            LAST_VALUETYPE = x86amx, // This always remains at the end of the list.
            VALUETYPE_SIZE = LAST_VALUETYPE + 1,

            // This is the current maximum for LAST_VALUETYPE.
            // MVT::MAX_ALLOWED_VALUETYPE is used for asserts and to size bit vectors
            // This value must be a multiple of 32.
            MAX_ALLOWED_VALUETYPE = 192,

            // A value of type llvm::TokenTy
            token          = 248,

            // This is MDNode or MDString.
            Metadata       = 249,

            // An int value the size of the pointer of the current
            // target to any address space. This must only be used internal to
            // tblgen. Other than for overloading, we treat iPTRAny the same as iPTR.
            iPTRAny        = 250,

            // A vector with any length and element size. This is used
            // for intrinsics that have overloadings based on vector types.
            // This is only for tblgen's consumption!
            vAny           = 251,

            // Any floating-point or vector floating-point value. This is used
            // for intrinsics that have overloadings based on floating-point types.
            // This is only for tblgen's consumption!
            fAny           = 252,

            // An integer or vector integer value of any bit width. This is
            // used for intrinsics that have overloadings based on integer bit widths.
            // This is only for tblgen's consumption!
            iAny           = 253,

            // An int value the size of the pointer of the current
            // target.  This should only be used internal to tblgen!
            iPTR           = 254,

            // Any type. This is used for intrinsics that have overloadings.
            // This is only for tblgen's consumption!
            Any            = 255
        }
    }
}