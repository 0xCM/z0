# _Other

## _mm512_swizzle_ps

--------------------------------------------------------------------------------------------------------------
Performs a swizzle transformation of each of the four groups of packed 4xsingle-precision (32-bit)
floating-point elements in "v" using swizzle parameter "s", storing the results in "dst".

[algorithm]

CASE s OF
_MM_SWIZ_REG_NONE:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_DCBA:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_CDAB:
    FOR j := 0 to 7
        i := j*64
        dst[i+31:i]    := v[i+63:i+32]
        dst[i+63:i+32] := v[i+31:i]
    ENDFOR
_MM_SWIZ_REG_BADC:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]     := v[i+95:i+64]
        dst[i+63:i+32]  := v[i+127:i+96]
        dst[i+95:i+64]  := v[i+31:i]
        dst[i+127:i+96] := v[i+63:i+32]
    ENDFOR
_MM_SWIZ_REG_AAAA:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]     := v[i+31:i]
        dst[i+63:i+32]  := v[i+31:i]
        dst[i+95:i+64]  := v[i+31:i]
        dst[i+127:i+96] := v[i+31:i]
    ENDFOR
_MM_SWIZ_REG_BBBB:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]     := v[i+63:i+32]
        dst[i+63:i+32]  := v[i+63:i+32]
        dst[i+95:i+64]  := v[i+63:i+32]
        dst[i+127:i+96] := v[i+63:i+32]
    ENDFOR
_MM_SWIZ_REG_CCCC:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]     := v[i+95:i+64]
        dst[i+63:i+32]  := v[i+95:i+64]
        dst[i+95:i+64]  := v[i+95:i+64]
        dst[i+127:i+96] := v[i+95:i+64]
    ENDFOR
_MM_SWIZ_REG_DDDD:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]     := v[i+127:i+96]
        dst[i+63:i+32]  := v[i+127:i+96]
        dst[i+95:i+64]  := v[i+127:i+96]
        dst[i+127:i+96] := v[i+127:i+96]
    ENDFOR
_MM_SWIZ_REG_DACB:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]     := v[i+63:i+32]
        dst[i+63:i+32]  := v[i+95:i+64]
        dst[i+95:i+64]  := v[i+31:i]
        dst[i+127:i+96] := v[i+127:i+96]
    ENDFOR
ESAC
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_swizzle_pd

--------------------------------------------------------------------------------------------------------------
Performs a swizzle transformation of each of the two groups of packed 4x double-precision (64-bit)
floating-point elements in "v" using swizzle parameter "s", storing the results in "dst".

[algorithm]

CASE s OF
_MM_SWIZ_REG_NONE:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_DCBA:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_CDAB:
    FOR j := 0 to 3
        i := j*64
        dst[i+63:i]     := v[i+127:i+64]
        dst[i+127:i+64] := v[i+63:i]
    ENDFOR
_MM_SWIZ_REG_BADC:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]      := v[i+191:i+128]
        dst[i+127:i+64]  := v[i+255:i+192]
        dst[i+191:i+128] := v[i+63:i]
        dst[i+255:i+192] := v[i+127:i+64]
    ENDFOR
_MM_SWIZ_REG_AAAA:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]      := v[i+63:i]
        dst[i+127:i+64]  := v[i+63:i]
        dst[i+191:i+128] := v[i+63:i]
        dst[i+255:i+192] := v[i+63:i]
    ENDFOR
_MM_SWIZ_REG_BBBB:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]      := v[i+127:i+63]
        dst[i+127:i+64]  := v[i+127:i+63]
        dst[i+191:i+128] := v[i+127:i+63]
        dst[i+255:i+192] := v[i+127:i+63]
    ENDFOR
_MM_SWIZ_REG_CCCC:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]      := v[i+191:i+128]
        dst[i+127:i+64]  := v[i+191:i+128]
        dst[i+191:i+128] := v[i+191:i+128]
        dst[i+255:i+192] := v[i+191:i+128]
    ENDFOR
_MM_SWIZ_REG_DDDD:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]         := v[i+255:i+192]
        dst[i+127:i+64]  := v[i+255:i+192]
        dst[i+191:i+128] := v[i+255:i+192]
        dst[i+255:i+192] := v[i+255:i+192]
    ENDFOR
_MM_SWIZ_REG_DACB:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]         := v[i+127:i+64]
        dst[i+127:i+64]  := v[i+191:i+128]
        dst[i+191:i+128] := v[i+63:i]
        dst[i+255:i+192] := v[i+255:i+192]
    ENDFOR
ESAC
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_swizzle_epi32

--------------------------------------------------------------------------------------------------------------
Performs a swizzle transformation of each of the four groups of packed 4x 32-bit integer elements in "v" using
swizzle parameter "s", storing the results in "dst".

[algorithm]

CASE s OF
_MM_SWIZ_REG_NONE:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_DCBA:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_CDAB:
    FOR j := 0 to 7
        i := j*64
        dst[i+31:i]    := v[i+63:i+32]
        dst[i+63:i+32] := v[i+31:i]
    ENDFOR
_MM_SWIZ_REG_BADC:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]        := v[i+95:i+64]
        dst[i+63:i+32]  := v[i+127:i+96]
        dst[i+95:i+64]  := v[i+31:i]
        dst[i+127:i+96] := v[i+63:i+32]
    ENDFOR
_MM_SWIZ_REG_AAAA:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]        := v[i+31:i]
        dst[i+63:i+32]  := v[i+31:i]
        dst[i+95:i+64]  := v[i+31:i]
        dst[i+127:i+96] := v[i+31:i]
    ENDFOR
_MM_SWIZ_REG_BBBB:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]        := v[i+63:i+32]
        dst[i+63:i+32]  := v[i+63:i+32]
        dst[i+95:i+64]  := v[i+63:i+32]
        dst[i+127:i+96] := v[i+63:i+32]
    ENDFOR
_MM_SWIZ_REG_CCCC:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]        := v[i+95:i+64]
        dst[i+63:i+32]  := v[i+95:i+64]
        dst[i+95:i+64]  := v[i+95:i+64]
        dst[i+127:i+96] := v[i+95:i+64]
    ENDFOR
_MM_SWIZ_REG_DDDD:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]        := v[i+127:i+96]
        dst[i+63:i+32]  := v[i+127:i+96]
        dst[i+95:i+64]  := v[i+127:i+96]
        dst[i+127:i+96] := v[i+127:i+96]
    ENDFOR
_MM_SWIZ_REG_DACB:
    FOR j := 0 to 3
        i := j*128
        dst[i+31:i]        := v[i+63:i+32]
        dst[i+63:i+32]  := v[i+95:i+64]
        dst[i+95:i+64]  := v[i+31:i]
        dst[i+127:i+96] := v[i+127:i+96]
    ENDFOR
ESAC
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_swizzle_epi64

--------------------------------------------------------------------------------------------------------------
Performs a swizzle transformation of each of the two groups of packed 4x64-bit integer elements in "v" using
swizzle parameter "s", storing the results in "dst".

[algorithm]

CASE s OF
_MM_SWIZ_REG_NONE:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_DCBA:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_CDAB:
    FOR j := 0 to 3
        i := j*64
        dst[i+63:i]        := v[i+127:i+64]
        dst[i+127:i+64] := v[i+63:i]
    ENDFOR
_MM_SWIZ_REG_BADC:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]         := v[i+191:i+128]
        dst[i+127:i+64]  := v[i+255:i+192]
        dst[i+191:i+128] := v[i+63:i]
        dst[i+255:i+192] := v[i+127:i+64]
    ENDFOR
_MM_SWIZ_REG_AAAA:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]         := v[i+63:i]
        dst[i+127:i+64]  := v[i+63:i]
        dst[i+191:i+128] := v[i+63:i]
        dst[i+255:i+192] := v[i+63:i]
    ENDFOR
_MM_SWIZ_REG_BBBB:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]         := v[i+127:i+63]
        dst[i+127:i+64]  := v[i+127:i+63]
        dst[i+191:i+128] := v[i+127:i+63]
        dst[i+255:i+192] := v[i+127:i+63]
    ENDFOR
_MM_SWIZ_REG_CCCC:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]         := v[i+191:i+128]
        dst[i+127:i+64]  := v[i+191:i+128]
        dst[i+191:i+128] := v[i+191:i+128]
        dst[i+255:i+192] := v[i+191:i+128]
    ENDFOR
_MM_SWIZ_REG_DDDD:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]         := v[i+255:i+192]
        dst[i+127:i+64]  := v[i+255:i+192]
        dst[i+191:i+128] := v[i+255:i+192]
        dst[i+255:i+192] := v[i+255:i+192]
    ENDFOR
_MM_SWIZ_REG_DACB:
    FOR j := 0 to 1
        i := j*256
        dst[i+63:i]         := v[i+127:i+64]
        dst[i+127:i+64]  := v[i+191:i+128]
        dst[i+191:i+128] := v[i+63:i]
        dst[i+255:i+192] := v[i+255:i+192]
    ENDFOR
ESAC
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_swizzle_ps

--------------------------------------------------------------------------------------------------------------
Performs a swizzle transformation of each of the four groups of packed 4x single-precision (32-bit)
floating-point elements in "v" using swizzle parameter "s", storing the results in "dst" using writemask "k"
(elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

CASE s OF
_MM_SWIZ_REG_NONE:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_DCBA:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_CDAB:
    FOR j := 0 to 7
        i := j*64
        IF k[j*2]
            dst[i+31:i]    := v[i+63:i+32]
        ELSE
            dst[i+31:i]    := src[i+31:i]
        FI
        IF k[j*2+1]
            dst[i+63:i+32] := v[i+31:i]
        ELSE
            dst[i+63:i+32] := src[i+63:i+32]
        FI
    ENDFOR
_MM_SWIZ_REG_BADC:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+95:i+64]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+127:i+96]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+31:i]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+63:i+32]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_AAAA:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+31:i]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+31:i]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+31:i]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+31:i]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_BBBB:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+63:i+32]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+63:i+32]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+63:i+32]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+63:i+32]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_CCCC:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+95:i+64]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+95:i+64]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+95:i+64]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+95:i+64]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_DDDD:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+127:i+96]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+127:i+96]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+127:i+96]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+127:i+96]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_DACB:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+63:i+32]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+95:i+64]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+31:i]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+127:i+96]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
ESAC
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_swizzle_pd

--------------------------------------------------------------------------------------------------------------
Performs a swizzle transformation of each of the two groups of packed 4x double-precision (64-bit)
floating-point elements in "v" using swizzle parameter "s", storing the results in "dst" using writemask "k"
(elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

CASE s OF
_MM_SWIZ_REG_NONE:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_DCBA:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_CDAB:
    FOR j := 0 to 3
        i := j*64
        IF k[j*2]
            dst[i+63:i]     := v[i+127:i+64]
        ELSE
            dst[i+63:i]     := src[i+63:i]
        FI
        IF k[j*2+1]
            dst[i+127:i+64] := v[i+63:i]
        ELSE
            dst[i+127:i+64] := src[i+127:i+64]
        FI
    ENDFOR
_MM_SWIZ_REG_BADC:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+191:i+128]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+255:i+192]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+63:i]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+127:i+64]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_AAAA:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+63:i]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+63:i]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+63:i]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+63:i]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_BBBB:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+127:i+63]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+127:i+63]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+127:i+63]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+127:i+63]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_CCCC:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+191:i+128]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+191:i+128]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+191:i+128]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+191:i+128]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_DDDD:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+255:i+192]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+255:i+192]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+255:i+192]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+255:i+192]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_DACB:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+127:i+64]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+191:i+128]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+63:i]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+255:i+192]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
ESAC
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_swizzle_epi32

--------------------------------------------------------------------------------------------------------------
Performs a swizzle transformation of each of the four groups of packed 4x32-bit integer elements in "v" using
swizzle parameter "s", storing the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

CASE s OF
_MM_SWIZ_REG_NONE:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_DCBA:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_CDAB:
    FOR j := 0 to 7
        i := j*64
        IF k[j*2]
            dst[i+31:i]    := v[i+63:i+32]
        ELSE
            dst[i+31:i]    := src[i+31:i]
        FI
        IF k[j*2+1]
            dst[i+63:i+32] := v[i+31:i]
        ELSE
            dst[i+63:i+32] := src[i+63:i+32]
        FI
    ENDFOR
_MM_SWIZ_REG_BADC:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+95:i+64]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+127:i+96]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+31:i]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+63:i+32]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_AAAA:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+31:i]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+31:i]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+31:i]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+31:i]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_BBBB:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+63:i+32]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+63:i+32]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+63:i+32]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+63:i+32]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_CCCC:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+95:i+64]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+95:i+64]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+95:i+64]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+95:i+64]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_DDDD:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+127:i+96]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+127:i+96]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+127:i+96]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+127:i+96]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
_MM_SWIZ_REG_DACB:
    FOR j := 0 to 3
        i := j*128
        IF k[j*4]
            dst[i+31:i]     := v[i+63:i+32]
        ELSE
            dst[i+31:i]     := src[i+31:i]
        FI
        IF k[j*4+1]
            dst[i+63:i+32]  := v[i+95:i+64]
        ELSE
            dst[i+63:i+32]  := src[i+63:i+32]
        FI
        IF k[j*4+2]
            dst[i+95:i+64]  := v[i+31:i]
        ELSE
            dst[i+95:i+64]  := src[i+95:i+64]
        FI
        IF k[j*4+3]
            dst[i+127:i+96] := v[i+127:i+96]
        ELSE
            dst[i+127:i+96] := src[i+127:i+96]
        FI
    ENDFOR
ESAC
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_swizzle_epi64

--------------------------------------------------------------------------------------------------------------
Performs a swizzle transformation of each of the four groups of packed 4x64-bit integer elements in "v" using
swizzle parameter "s", storing the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

CASE s OF
_MM_SWIZ_REG_NONE:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_DCBA:
    dst[511:0] := v[511:0]
_MM_SWIZ_REG_CDAB:
    FOR j := 0 to 3
        i := j*64
        IF k[j*2]
            dst[i+63:i]     := v[i+127:i+64]
        ELSE
            dst[i+63:i]     := src[i+63:i]
        FI
        IF k[j*2+1]
            dst[i+127:i+64] := v[i+63:i]
        ELSE
            dst[i+127:i+64] := src[i+127:i+64]
        FI
    ENDFOR
_MM_SWIZ_REG_BADC:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+191:i+128]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+255:i+192]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+63:i]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+127:i+64]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_AAAA:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+63:i]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+63:i]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+63:i]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+63:i]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_BBBB:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+127:i+63]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+127:i+63]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+127:i+63]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+127:i+63]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_CCCC:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+191:i+128]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+191:i+128]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+191:i+128]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+191:i+128]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_DDDD:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+255:i+192]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+255:i+192]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+255:i+192]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+255:i+192]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
_MM_SWIZ_REG_DACB:
    FOR j := 0 to 1
        i := j*256
        IF k[j*4]
            dst[i+63:i]      := v[i+127:i+64]
        ELSE
            dst[i+63:i]      := src[i+63:i]
        FI
        IF k[j*4+1]
            dst[i+127:i+64]  := v[i+191:i+128]
        ELSE
            dst[i+127:i+64]  := src[i+127:i+64]
        FI
        IF k[j*4+2]
            dst[i+191:i+128] := v[i+63:i]
        ELSE
            dst[i+191:i+128] := src[i+191:i+128]
        FI
        IF k[j*4+3]
            dst[i+255:i+192] := v[i+255:i+192]
        ELSE
            dst[i+255:i+192] := src[i+255:i+192]
        FI
    ENDFOR
ESAC
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_gmin_ps

--------------------------------------------------------------------------------------------------------------
Determines the minimum element of the packed single-precision (32-bit) floating-point elements stored in "a"
and stores the result in "dst".

[algorithm]

min := a[31:0]
FOR j := 1 to 15
    i := j*32
    dst := FpMin(min, a[i+31:i])
ENDFOR
dst := min

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_gmin_ps

--------------------------------------------------------------------------------------------------------------
Determines the minimum element of the packed single-precision (32-bit) floating-point elements stored in "a"
and stores the result in "dst" using writemask "k" (elements are ignored when the corresponding mask bit is not
set).

[algorithm]

min := a[31:0]
FOR j := 1 to 15
    i := j*32
    IF k[j]
        CONTINUE
    ELSE
        dst := FpMin(min, a[i+31:i])
    FI
ENDFOR
dst := min

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_gmin_pd

--------------------------------------------------------------------------------------------------------------
Determines the minimum element of the packed double-precision (64-bit) floating-point elements stored in "a"
and stores the result in "dst".

[algorithm]

min := a[63:0]
FOR j := 1 to 7
    i := j*64
    dst := FpMin(min, a[i+63:i])
ENDFOR
dst := min

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_gmin_pd

--------------------------------------------------------------------------------------------------------------
Determines the minimum element of the packed double-precision (64-bit) floating-point elements stored in "a"
and stores the result in "dst". Bitmask "k" is used to exclude certain elements (elements are ignored when the
corresponding mask bit is not set).

[algorithm]

min := a[63:0]
FOR j := 1 to 7
    i := j*64
    IF k[j]
        CONTINUE
    ELSE
        dst := FpMin(min, a[i+63:i])
    FI
ENDFOR
dst := min

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_gmax_ps

--------------------------------------------------------------------------------------------------------------
Determines the maximum element of the packed single-precision (32-bit) floating-point elements stored in "a"
and stores the result in "dst".

[algorithm]

max := a[31:0]
FOR j := 1 to 15
    i := j*32
    dst := FpMax(max, a[i+31:i])
ENDFOR
dst := max

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_gmax_ps

--------------------------------------------------------------------------------------------------------------
Determines the maximum element of the packed single-precision (32-bit) floating-point elements stored in "a"
and stores the result in "dst". Bitmask "k" is used to exclude certain elements (elements are ignored when the
corresponding mask bit is not set).

[algorithm]

max := a[31:0]
FOR j := 1 to 15
    i := j*32
    IF k[j]
        CONTINUE
    ELSE
        dst := FpMax(max, a[i+31:i])
    FI
ENDFOR
dst := max

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_gmax_pd

--------------------------------------------------------------------------------------------------------------
Determines the maximum element of the packed double-precision (64-bit) floating-point elements stored in "a"
and stores the result in "dst".

[algorithm]

max := a[63:0]
FOR j := 1 to 7
    i := j*64
    dst := FpMax(max, a[i+63:i])
ENDFOR
dst := max

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_gmax_pd

--------------------------------------------------------------------------------------------------------------
Determines the maximum element of the packed double-precision (64-bit) floating-point elements stored in "a"
and stores the result in "dst". Bitmask "k" is used to exclude certain elements (elements are ignored when the
corresponding mask bit is not set).

[algorithm]

max := a[63:0]
FOR j := 1 to 7
    i := j*64
    IF k[j]
        CONTINUE
    ELSE
        dst := FpMax(max, a[i+63:i])
    FI
ENDFOR
dst := max

--------------------------------------------------------------------------------------------------------------

## _mm512_i64extgather_epi32lo

--------------------------------------------------------------------------------------------------------------
Up-converts 8 single-precision (32-bit) memory locations starting at location "base_addr" at packed 64-bit
integer indices stored in "vindex" scaled by "scale" using "conv" to 32-bit integer elements and stores them in
"dst". "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:   dst[i+31:i] := MEM[addr+31:addr]
    _MM_UPCONV_EPI32_UINT8:  dst[i+31:i] := ZeroExtend32(MEM[addr+7:addr])
    _MM_UPCONV_EPI32_SINT8:  dst[i+31:i] := SignExtend32(MEM[addr+7:addr])
    _MM_UPCONV_EPI32_UINT16: dst[i+31:i] := ZeroExtend32(MEM[addr+15:addr])
    _MM_UPCONV_EPI32_SINT16: dst[i+31:i] := SignExtend32(MEM[addr+15:addr])
    ESAC
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64extgather_epi32lo

--------------------------------------------------------------------------------------------------------------
Up-converts 8 single-precision (32-bit) memory locations starting at location "base_addr" at packed 64-bit
integer indices stored in "vindex" scaled by "scale" using "conv" to 32-bit integer elements and stores them in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). "hint"
indicates to the processor whether the data is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_UPCONV_EPI32_NONE:   dst[i+31:i] := MEM[addr+31:addr]
        _MM_UPCONV_EPI32_UINT8:  dst[i+31:i] := ZeroExtend32(MEM[addr+7:addr])
        _MM_UPCONV_EPI32_SINT8:  dst[i+31:i] := SignExtend32(MEM[addr+7:addr])
        _MM_UPCONV_EPI32_UINT16: dst[i+31:i] := ZeroExtend32(MEM[addr+15:addr])
        _MM_UPCONV_EPI32_SINT16: dst[i+31:i] := SignExtend32(MEM[addr+15:addr])
        ESAC
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_i64extgather_epi64

--------------------------------------------------------------------------------------------------------------
Up-converts 8 double-precision (64-bit) memory locations starting at location "base_addr" at packed 64-bit
integer indices stored in "vindex" scaled by "scale" using "conv" to 64-bit integer elements and stores them in
"dst". "hint" indicates to the processor whether the load is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_UPCONV_EPI64_NONE: dst[i+63:i] := MEM[addr+63:addr]
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64extgather_epi64

--------------------------------------------------------------------------------------------------------------
Up-converts 8 double-precision (64-bit) memory locations starting at location "base_addr" at packed 64-bit
integer indices stored in "vindex" scaled by "scale" using "conv" to 64-bit integer elements and stores them in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). "hint"
indicates to the processor whether the load is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_UPCONV_EPI64_NONE: dst[i+63:i] := MEM[addr+63:addr]
        ESAC
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_i64extgather_pslo

--------------------------------------------------------------------------------------------------------------
Up-converts 8 memory locations starting at location "base_addr" at packed 64-bit integer indices stored in
"vindex" scaled by "scale" using "conv" to single-precision (32-bit) floating-point elements and stores them in
the lower half of "dst". "hint" indicates to the processor whether the load is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_UPCONV_PS_NONE:    dst[i+31:i] := MEM[addr+31:addr]
    _MM_UPCONV_PS_FLOAT16: dst[i+31:i] := Convert_FP16_To_FP32(MEM[addr+15:addr])
    _MM_UPCONV_PS_UINT8:   dst[i+31:i] := Convert_UInt8_To_FP32(MEM[addr+7:addr])
    _MM_UPCONV_PS_SINT8:   dst[i+31:i] := Convert_Int8_To_FP32(MEM[addr+7:addr])
    _MM_UPCONV_PS_UINT16:  dst[i+31:i] := Convert_UInt16_To_FP32(MEM[addr+15:addr])
    _MM_UPCONV_PS_SINT16:  dst[i+31:i] := Convert_Int16_To_FP32(MEM[addr+15:addr])
    ESAC
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64extgather_pslo

--------------------------------------------------------------------------------------------------------------
Up-converts 8 memory locations starting at location "base_addr" at packed 64-bit integer indices stored in
"vindex" scaled by "scale" using "conv" to single-precision (32-bit) floating-point elements and stores them in
the lower half of "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is
not set). "hint" indicates to the processor whether the load is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_UPCONV_PS_NONE:    dst[i+31:i] := MEM[addr+31:addr]
        _MM_UPCONV_PS_FLOAT16: dst[i+31:i] := Convert_FP16_To_FP32(MEM[addr+15:addr])
        _MM_UPCONV_PS_UINT8:   dst[i+31:i] := Convert_UInt8_To_FP32(MEM[addr+7:addr])
        _MM_UPCONV_PS_SINT8:   dst[i+31:i] := Convert_Int8_To_FP32(MEM[addr+7:addr])
        _MM_UPCONV_PS_UINT16:  dst[i+31:i] := Convert_UInt16_To_FP32(MEM[addr+15:addr])
        _MM_UPCONV_PS_SINT16:  dst[i+31:i] := Convert_Int16_To_FP32(MEM[addr+15:addr])
        ESAC
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_i64extgather_pd

--------------------------------------------------------------------------------------------------------------
Up-converts 8 double-precision (64-bit) floating-point elements stored in memory starting at location
"base_addr" at packed 64-bit integer indices stored in "vindex" scaled by "scale" using "conv" to 64-bit
floating-point elements and stores them in "dst". "hint" indicates to the processor whether the data is
non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_UPCONV_PD_NONE: dst[i+63:i] := MEM[addr+63:addr]
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64extgather_pd

--------------------------------------------------------------------------------------------------------------
Up-converts 8 double-precision (64-bit) floating-point elements stored in memory starting at location
"base_addr" at packed 64-bit integer indices stored in "vindex" scaled by "scale" using "conv" to 64-bit
floating-point elements and stores them in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set). "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_UPCONV_PD_NONE: dst[i+63:i] := MEM[addr+63:addr]
        ESAC
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_i64extscatter_pslo

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed single-precision (32-bit) floating-point elements in "a" using "conv" and stores them
in memory locations starting at location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled
by "scale". "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_DOWNCONV_PS_NONE:    MEM[addr+31:addr] := a[i+31:i]
    _MM_DOWNCONV_PS_FLOAT16: MEM[addr+15:addr] := Convert_FP32_To_FP16(a[i+31:i])
    _MM_DOWNCONV_PS_UINT8:   MEM[addr+ 7:addr] := Convert_FP32_To_UInt8(a[i+31:i])
    _MM_DOWNCONV_PS_SINT8:   MEM[addr+ 7:addr] := Convert_FP32_To_Int8(a[i+31:i])
    _MM_DOWNCONV_PS_UINT16:  MEM[addr+15:addr] := Convert_FP32_To_UInt16(a[i+31:i])
    _MM_DOWNCONV_PS_SINT16:  MEM[addr+15:addr] := Convert_FP32_To_Int16(a[i+31:i])
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64extscatter_pslo

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed single-precision (32-bit) floating-point elements in "a" using "conv" and stores them
in memory locations starting at location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled
by "scale". Elements are only written when the corresponding mask bit is set in "k"; otherwise, elements are
unchanged in memory. "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_PS_NONE:    MEM[addr+31:addr] := a[i+31:i]
        _MM_DOWNCONV_PS_FLOAT16: MEM[addr+15:addr] := Convert_FP32_To_FP16(a[i+31:i])
        _MM_DOWNCONV_PS_UINT8:   MEM[addr+ 7:addr] := Convert_FP32_To_UInt8(a[i+31:i])
        _MM_DOWNCONV_PS_SINT8:   MEM[addr+ 7:addr] := Convert_FP32_To_Int8(a[i+31:i])
        _MM_DOWNCONV_PS_UINT16:  MEM[addr+15:addr] := Convert_FP32_To_UInt16(a[i+31:i])
        _MM_DOWNCONV_PS_SINT16:  MEM[addr+15:addr] := Convert_FP32_To_Int16(a[i+31:i])
        ESAC
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_i64extscatter_pd

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed double-precision (64-bit) floating-point elements in "a" using "conv" and stores them
in memory locations starting at location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled
by "scale". "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_DOWNCONV_EPI64_NONE: MEM[addr+63:addr] := a[i+63:i]
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64extscatter_pd

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed double-precision (64-bit) floating-point elements in "a" using "conv" and stores them
in memory locations starting at location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled
by "scale". Elements are written to memory using writemask "k" (elements are not stored to memory when the
corresponding mask bit is not set; the memory location is left unchagned). "hint" indicates to the processor
whether the data is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_EPI64_NONE: MEM[addr+63:addr] := a[i+63:i]
        ESAC
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_i64extscatter_epi32lo

--------------------------------------------------------------------------------------------------------------
Down-converts the low 8 packed 32-bit integer elements in "a" using "conv" and stores them in memory locations
starting at location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled by "scale". "hint"
indicates to the processor whether the data is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_DOWNCONV_EPI32_NONE:   MEM[addr+31:addr] := a[i+31:i]
    _MM_DOWNCONV_EPI32_UINT8:  MEM[addr+ 7:addr] := Truncate8(a[i+31:i])
    _MM_DOWNCONV_EPI32_SINT8:  MEM[addr+ 7:addr] := Saturate8(a[i+31:i])
    _MM_DOWNCONV_EPI32_UINT16: MEM[addr+15:addr] := Truncate16(a[i+31:i])
    _MM_DOWNCONV_EPI32_SINT16: MEM[addr+15:addr] := Saturate16(a[i+31:i])
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64extscatter_epi32lo

--------------------------------------------------------------------------------------------------------------
Down-converts the low 8 packed 32-bit integer elements in "a" using "conv" and stores them in memory locations
starting at location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled by "scale".
Elements are written to memory using writemask "k" (elements are only written when the corresponding mask bit
is set; otherwise, the memory location is left unchanged). "hint" indicates to the processor whether the data
is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_EPI32_NONE:   MEM[addr+31:addr] := a[i+31:i]
        _MM_DOWNCONV_EPI32_UINT8:  MEM[addr+ 7:addr] := Truncate8(a[i+31:i])
        _MM_DOWNCONV_EPI32_SINT8:  MEM[addr+ 7:addr] := Saturate8(a[i+31:i])
        _MM_DOWNCONV_EPI32_UINT16: MEM[addr+15:addr] := Truncate16(a[i+31:i])
        _MM_DOWNCONV_EPI32_SINT16: MEM[addr+15:addr] := Saturate16(a[i+31:i])
        ESAC
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_i64extscatter_epi64

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed 64-bit integer elements in "a" using "conv" and stores them in memory locations
starting at location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled by "scale". "hint"
indicates to the processor whether the load is non-temporal.

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_DOWNCONV_EPI64_NONE: MEM[addr+63:addr] := a[i+63:i]
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64extscatter_epi64

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed 64-bit integer elements in "a" using "conv" and stores them in memory locations
starting at location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled by "scale". Only
those elements whose corresponding mask bit is set in writemask "k" are written to memory.

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_EPI64_NONE: MEM[addr+63:addr] := a[i+63:i]
        ESAC
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_i64gather_epi32lo

--------------------------------------------------------------------------------------------------------------
Loads 8 32-bit integer memory locations starting at location "base_addr" at packed 64-bit integer indices
stored in "vindex" scaled by "scale" to "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64gather_epi32lo

--------------------------------------------------------------------------------------------------------------
Loads 8 32-bit integer memory locations starting at location "base_addr" at packed 64-bit integer indices
stored in "vindex" scaled by "scale" to "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    IF k[j]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_i64gather_pslo

--------------------------------------------------------------------------------------------------------------
Loads 8 single-precision (32-bit) floating-point memory locations starting at location "base_addr" at packed
64-bit integer indices stored in "vindex" scaled by "scale" to "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64gather_pslo

--------------------------------------------------------------------------------------------------------------
Loads 8 single-precision (32-bit) floating-point memory locations starting at location "base_addr" at packed
64-bit integer indices stored in "vindex" scaled by "scale" to "dst" using writemask "k" (elements are copied
from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    IF k[j]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_i64scatter_pslo

--------------------------------------------------------------------------------------------------------------
Stores 8 packed single-precision (32-bit) floating-point elements in "a" in memory locations starting at
location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled by "scale".

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    MEM[addr+31:addr] := a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64scatter_pslo

--------------------------------------------------------------------------------------------------------------
Stores 8 packed single-precision (32-bit) floating-point elements in "a" in memory locations starting at
location "base_addr" at packed 64-bit integer indices stored in "vindex" scaled by "scale" using writemask "k"
(elements are only written to memory when the corresponding mask bit is set).

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    IF k[j]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        MEM[addr+31:addr] := a[i+31:i]
    FI    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_i64scatter_epi32lo

--------------------------------------------------------------------------------------------------------------
Stores 8 packed 32-bit integer elements in "a" in memory locations starting at location "base_addr" at packed
64-bit integer indices stored in "vindex" scaled by "scale".

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    MEM[addr+31:addr] := a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_i64scatter_epi32lo

--------------------------------------------------------------------------------------------------------------
Stores 8 packed 32-bit integer elements in "a" in memory locations starting at location "base_addr" at packed
64-bit integer indices stored in "vindex" scaled by "scale" using writemask "k" (elements are only written to
memory when the corresponding mask bit is set).

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*64
    IF k[j]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        MEM[addr+31:addr] := a[i+31:i]
    FI    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set_pi32

--------------------------------------------------------------------------------------------------------------
Set packed 32-bit integers in "dst" with the supplied values.

[algorithm]

dst[31:0] := e0
dst[63:32] := e1

--------------------------------------------------------------------------------------------------------------

## _mm_set_pi16

--------------------------------------------------------------------------------------------------------------
Set packed 16-bit integers in "dst" with the supplied values.

[algorithm]

dst[15:0] := e0
dst[31:16] := e1
dst[47:32] := e2
dst[63:48] := e3

--------------------------------------------------------------------------------------------------------------

## _mm_set_pi8

--------------------------------------------------------------------------------------------------------------
Set packed 8-bit integers in "dst" with the supplied values.

[algorithm]

dst[7:0] := e0
dst[15:8] := e1
dst[23:16] := e2
dst[31:24] := e3
dst[39:32] := e4
dst[47:40] := e5
dst[55:48] := e6
dst[63:56] := e7

--------------------------------------------------------------------------------------------------------------

## _mm_set1_pi32

--------------------------------------------------------------------------------------------------------------
Broadcast 32-bit integer "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set1_pi16

--------------------------------------------------------------------------------------------------------------
Broadcast 16-bit integer "a" to all all elements of "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := a[15:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set1_pi8

--------------------------------------------------------------------------------------------------------------
Broadcast 8-bit integer "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := a[7:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_setr_pi32

--------------------------------------------------------------------------------------------------------------
Set packed 32-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[31:0] := e1
dst[63:32] := e0

--------------------------------------------------------------------------------------------------------------

## _mm_setr_pi16

--------------------------------------------------------------------------------------------------------------
Set packed 16-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[15:0] := e3
dst[31:16] := e2
dst[47:32] := e1
dst[63:48] := e0

--------------------------------------------------------------------------------------------------------------

## _mm_setr_pi8

--------------------------------------------------------------------------------------------------------------
Set packed 8-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[7:0] := e7
dst[15:8] := e6
dst[23:16] := e5
dst[31:24] := e4
dst[39:32] := e3
dst[47:40] := e2
dst[55:48] := e1
dst[63:56] := e0

--------------------------------------------------------------------------------------------------------------

## _bnd_narrow_ptr_bounds

--------------------------------------------------------------------------------------------------------------
Narrow the bounds for pointer "q" to the intersection of the bounds of "r" and the bounds ["q", "q" + "size" -
1], and store the result in "dst".

[algorithm]

dst := q
IF r.LB &gt; (q + size - 1) OR r.UB &lt; q
    dst.LB := 1
    dst.UB := 0
ELSE
    dst.LB := MAX(r.LB, q)
    dst.UB := MIN(r.UB, (q + size - 1))
FI

--------------------------------------------------------------------------------------------------------------

## _bnd_copy_ptr_bounds

--------------------------------------------------------------------------------------------------------------
Make a pointer with the value of "q" and bounds set to the bounds of "r" (e.g. copy the bounds of "r" to
pointer "q"), and store the result in "dst".

[algorithm]

dst := q
dst.LB := r.LB
dst.UB := r.UB

--------------------------------------------------------------------------------------------------------------

## _bnd_init_ptr_bounds

--------------------------------------------------------------------------------------------------------------
Make a pointer with the value of "q" and open bounds, which allow the pointer to access the entire virtual
address space, and store the result in "dst".

[algorithm]

dst := q
dst.LB := 0
dst.UB := 0

--------------------------------------------------------------------------------------------------------------

## _bnd_get_ptr_lbound

--------------------------------------------------------------------------------------------------------------
Return the lower bound of "q".

[algorithm]

dst := q.LB

--------------------------------------------------------------------------------------------------------------

## _bnd_get_ptr_ubound

--------------------------------------------------------------------------------------------------------------
Return the upper bound of "q".

[algorithm]

dst := q.UB

--------------------------------------------------------------------------------------------------------------

## _castf32_u32

--------------------------------------------------------------------------------------------------------------
Cast from type float to type unsigned __int32 without conversion.
	This intrinsic is only used for compilation
and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _castf64_u64

--------------------------------------------------------------------------------------------------------------
Cast from type double to type unsigned __int64 without conversion.
	This intrinsic is only used for
compilation and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _castu32_f32

--------------------------------------------------------------------------------------------------------------
Cast from type unsigned __int32 to type float without conversion.
	This intrinsic is only used for compilation
and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _castu64_f64

--------------------------------------------------------------------------------------------------------------
Cast from type unsigned __int64 to type double without conversion.
	This intrinsic is only used for
compilation and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _allow_cpu_features

--------------------------------------------------------------------------------------------------------------
Treat the processor-specific feature(s) specified in "a" as available. Multiple features may be OR'd together.
See the valid feature flags below:

[algorithm]

_FEATURE_GENERIC_IA32
_FEATURE_FPU
_FEATURE_CMOV
_FEATURE_MMX
_FEATURE_FXSAVE
_FEATURE_SSE
_FEATURE_SSE2
_FEATURE_SSE3
_FEATURE_SSSE3
_FEATURE_SSE4_1
_FEATURE_SSE4_2
_FEATURE_MOVBE
_FEATURE_POPCNT
_FEATURE_PCLMULQDQ
_FEATURE_AES
_FEATURE_F16C
_FEATURE_AVX
_FEATURE_RDRND
_FEATURE_FMA
_FEATURE_BMI
_FEATURE_LZCNT
_FEATURE_HLE
_FEATURE_RTM
_FEATURE_AVX2
_FEATURE_KNCNI
_FEATURE_AVX512F
_FEATURE_ADX
_FEATURE_RDSEED
_FEATURE_AVX512ER
_FEATURE_AVX512PF
_FEATURE_AVX512CD
_FEATURE_SHA
_FEATURE_MPX
_FEATURE_AVX512BW
_FEATURE_AVX512VL
_FEATURE_AVX512VBMI
_FEATURE_AVX512_4FMAPS
_FEATURE_AVX512_4VNNIW
_FEATURE_AVX512_VPOPCNTDQ
_FEATURE_AVX512_BITALG
_FEATURE_AVX512_VBMI2
_FEATURE_GFNI
_FEATURE_VAES
_FEATURE_VPCLMULQDQ
_FEATURE_AVX512_VNNI
_FEATURE_CLWB
_FEATURE_RDPID
_FEATURE_IBT
_FEATURE_SHSTK
_FEATURE_SGX
_FEATURE_WBNOINVD
_FEATURE_PCONFIG
_FEATURE_AXV512_4VNNIB
_FEATURE_AXV512_4FMAPH
_FEATURE_AXV512_BITALG2
_FEATURE_AXV512_VP2INTERSECT

--------------------------------------------------------------------------------------------------------------

## _may_i_use_cpu_feature

--------------------------------------------------------------------------------------------------------------
Dynamically query the processor to determine if the processor-specific feature(s) specified in "a" are
available, and return true or false (1 or 0) if the set of features is available. Multiple features may be OR'd
together. This intrinsic does not check the processor vendor. See the valid feature flags below:

[algorithm]

_FEATURE_GENERIC_IA32
_FEATURE_FPU
_FEATURE_CMOV
_FEATURE_MMX
_FEATURE_FXSAVE
_FEATURE_SSE
_FEATURE_SSE2
_FEATURE_SSE3
_FEATURE_SSSE3
_FEATURE_SSE4_1
_FEATURE_SSE4_2
_FEATURE_MOVBE
_FEATURE_POPCNT
_FEATURE_PCLMULQDQ
_FEATURE_AES
_FEATURE_F16C
_FEATURE_AVX
_FEATURE_RDRND
_FEATURE_FMA
_FEATURE_BMI
_FEATURE_LZCNT
_FEATURE_HLE
_FEATURE_RTM
_FEATURE_AVX2
_FEATURE_KNCNI
_FEATURE_AVX512F
_FEATURE_ADX
_FEATURE_RDSEED
_FEATURE_AVX512ER
_FEATURE_AVX512PF
_FEATURE_AVX512CD
_FEATURE_SHA
_FEATURE_MPX
_FEATURE_AVX512BW
_FEATURE_AVX512VL
_FEATURE_AVX512VBMI
_FEATURE_AVX512_4FMAPS
_FEATURE_AVX512_4VNNIW
_FEATURE_AVX512_VPOPCNTDQ
_FEATURE_AVX512_BITALG
_FEATURE_AVX512_VBMI2
_FEATURE_GFNI
_FEATURE_VAES
_FEATURE_VPCLMULQDQ
_FEATURE_AVX512_VNNI
_FEATURE_CLWB
_FEATURE_RDPID
_FEATURE_IBT
_FEATURE_SHSTK
_FEATURE_SGX
_FEATURE_WBNOINVD
_FEATURE_PCONFIG
_FEATURE_AXV512_4VNNIB
_FEATURE_AXV512_4FMAPH
_FEATURE_AXV512_BITALG2
_FEATURE_AXV512_VP2INTERSECT

--------------------------------------------------------------------------------------------------------------

## _cvtsh_ss

--------------------------------------------------------------------------------------------------------------
Convert the half-precision (16-bit) floating-point value "a" to a single-precision (32-bit) floating-point
value, and store the result in "dst".

[algorithm]

dst[31:0] := Convert_FP16_To_FP32(a[15:0])

--------------------------------------------------------------------------------------------------------------

## _cvtss_sh

--------------------------------------------------------------------------------------------------------------
Convert the single-precision (32-bit) floating-point value "a" to a half-precision (16-bit) floating-point
value, and store the result in "dst".
	[round_note]

[algorithm]

dst[15:0] := Convert_FP32_To_FP16(a[31:0])

--------------------------------------------------------------------------------------------------------------

## _MM_TRANSPOSE4_PS

--------------------------------------------------------------------------------------------------------------
Macro: Transpose the 4x4 matrix formed by the 4 rows of single-precision (32-bit) floating-point elements in
"row0", "row1", "row2", and "row3", and store the transposed matrix in these vectors ("row0" now contains
column 0, etc.).

[algorithm]

__m128 tmp3, tmp2, tmp1, tmp0;
tmp0 := _mm_unpacklo_ps(row0, row1);
tmp2 := _mm_unpacklo_ps(row2, row3);
tmp1 := _mm_unpackhi_ps(row0, row1);
tmp3 := _mm_unpackhi_ps(row2, row3);
row0 := _mm_movelh_ps(tmp0, tmp2);
row1 := _mm_movehl_ps(tmp2, tmp0);
row2 := _mm_movelh_ps(tmp1, tmp3);
row3 := _mm_movehl_ps(tmp3, tmp1);

--------------------------------------------------------------------------------------------------------------

## _MM_GET_EXCEPTION_STATE

--------------------------------------------------------------------------------------------------------------
Macro: Get the exception state bits from the MXCSR control and status register. The exception state may
contain any of the following flags: _MM_EXCEPT_INVALID, _MM_EXCEPT_DIV_ZERO, _MM_EXCEPT_DENORM,
_MM_EXCEPT_OVERFLOW, _MM_EXCEPT_UNDERFLOW, _MM_EXCEPT_INEXACT

[algorithm]

dst[31:0] := MXCSR &amp; _MM_EXCEPT_MASK

--------------------------------------------------------------------------------------------------------------

## _MM_SET_EXCEPTION_STATE

--------------------------------------------------------------------------------------------------------------
Macro: Set the exception state bits of the MXCSR control and status register to the value in unsigned 32-bit
integer "a". The exception state may contain any of the following flags: _MM_EXCEPT_INVALID,
_MM_EXCEPT_DIV_ZERO, _MM_EXCEPT_DENORM, _MM_EXCEPT_OVERFLOW, _MM_EXCEPT_UNDERFLOW, _MM_EXCEPT_INEXACT

[algorithm]

MXCSR := a[31:0] AND ~_MM_EXCEPT_MASK

--------------------------------------------------------------------------------------------------------------

## _MM_GET_EXCEPTION_MASK

--------------------------------------------------------------------------------------------------------------
Macro: Get the exception mask bits from the MXCSR control and status register. The exception mask may contain
any of the following flags: _MM_MASK_INVALID, _MM_MASK_DIV_ZERO, _MM_MASK_DENORM, _MM_MASK_OVERFLOW,
_MM_MASK_UNDERFLOW, _MM_MASK_INEXACT

[algorithm]

dst[31:0] := MXCSR &amp; _MM_MASK_MASK

--------------------------------------------------------------------------------------------------------------

## _MM_SET_EXCEPTION_MASK

--------------------------------------------------------------------------------------------------------------
Macro: Set the exception mask bits of the MXCSR control and status register to the value in unsigned 32-bit
integer "a". The exception mask may contain any of the following flags: _MM_MASK_INVALID, _MM_MASK_DIV_ZERO,
_MM_MASK_DENORM, _MM_MASK_OVERFLOW, _MM_MASK_UNDERFLOW, _MM_MASK_INEXACT

[algorithm]

MXCSR := a[31:0] AND ~_MM_MASK_MASK

--------------------------------------------------------------------------------------------------------------

## _MM_GET_ROUNDING_MODE

--------------------------------------------------------------------------------------------------------------
Macro: Get the rounding mode bits from the MXCSR control and status register. The rounding mode may contain
any of the following flags: _MM_ROUND_NEAREST, _MM_ROUND_DOWN, _MM_ROUND_UP, _MM_ROUND_TOWARD_ZERO

[algorithm]

dst[31:0] := MXCSR &amp; _MM_ROUND_MASK

--------------------------------------------------------------------------------------------------------------

## _MM_SET_ROUNDING_MODE

--------------------------------------------------------------------------------------------------------------
Macro: Set the rounding mode bits of the MXCSR control and status register to the value in unsigned 32-bit
integer "a". The rounding mode may contain any of the following flags: _MM_ROUND_NEAREST, _MM_ROUND_DOWN,
_MM_ROUND_UP, _MM_ROUND_TOWARD_ZERO

[algorithm]

MXCSR := a[31:0] AND ~_MM_ROUND_MASK

--------------------------------------------------------------------------------------------------------------

## _MM_GET_FLUSH_ZERO_MODE

--------------------------------------------------------------------------------------------------------------
Macro: Get the flush zero bits from the MXCSR control and status register. The flush zero may contain any of
the following flags: _MM_FLUSH_ZERO_ON or _MM_FLUSH_ZERO_OFF

[algorithm]

dst[31:0] := MXCSR &amp; _MM_FLUSH_MASK

--------------------------------------------------------------------------------------------------------------

## _MM_SET_FLUSH_ZERO_MODE

--------------------------------------------------------------------------------------------------------------
Macro: Set the flush zero bits of the MXCSR control and status register to the value in unsigned 32-bit
integer "a". The flush zero may contain any of the following flags: _MM_FLUSH_ZERO_ON or _MM_FLUSH_ZERO_OFF

[algorithm]

MXCSR := a[31:0] AND ~_MM_FLUSH_MASK

--------------------------------------------------------------------------------------------------------------

## _mm_cvtpi16_ps

--------------------------------------------------------------------------------------------------------------
Convert packed 16-bit integers in "a" to packed single-precision (32-bit) floating-point elements, and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    m := j*32
    dst[m+31:m] := Convert_Int16_To_FP32(a[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_cvtpu16_ps

--------------------------------------------------------------------------------------------------------------
Convert packed unsigned 16-bit integers in "a" to packed single-precision (32-bit) floating-point elements,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    m := j*32
    dst[m+31:m] := Convert_Int16_To_FP32(a[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_cvtpi8_ps

--------------------------------------------------------------------------------------------------------------
Convert the lower packed 8-bit integers in "a" to packed single-precision (32-bit) floating-point elements,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*8
    m := j*32
    dst[m+31:m] := Convert_Int8_To_FP32(a[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_cvtpu8_ps

--------------------------------------------------------------------------------------------------------------
Convert the lower packed unsigned 8-bit integers in "a" to packed single-precision (32-bit) floating-point
elements, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*8
    m := j*32
    dst[m+31:m] := Convert_Int8_To_FP32(a[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_cvtpi32x2_ps

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers in "a" to packed single-precision (32-bit) floating-point elements,
store the results in the lower 2 elements of "dst", then covert the packed signed 32-bit integers in "b" to
single-precision (32-bit) floating-point element, and store the results in the upper 2 elements of "dst".

[algorithm]

dst[31:0] := Convert_Int32_To_FP32(a[31:0])
dst[63:32] := Convert_Int32_To_FP32(a[63:32])
dst[95:64] := Convert_Int32_To_FP32(b[31:0])
dst[127:96] := Convert_Int32_To_FP32(b[63:32])

--------------------------------------------------------------------------------------------------------------

## _mm_cvtps_pi16

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 16-bit integers, and store
the results in "dst". Note: this intrinsic will generate 0x7FFF, rather than 0x8000, for input values between
0x7FFF and 0x7FFFFFFF.

[algorithm]

FOR j := 0 to 3
    i := 16*j
    k := 32*j
    IF a[k+31:k] &gt;= FP32(0x7FFF) &amp;&amp; a[k+31:k] &lt;= FP32(0x7FFFFFFF)
        dst[i+15:i] := 0x7FFF
    ELSE
        dst[i+15:i] := Convert_FP32_To_Int16(a[k+31:k])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_cvtps_pi8

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 8-bit integers, and store
the results in lower 4 elements of "dst". Note: this intrinsic will generate 0x7F, rather than 0x80, for input
values between 0x7F and 0x7FFFFFFF.

[algorithm]

FOR j := 0 to 3
    i := 8*j
    k := 32*j
    IF a[k+31:k] &gt;= FP32(0x7F) &amp;&amp; a[k+31:k] &lt;= FP32(0x7FFFFFFF)
        dst[i+7:i] := 0x7F
    ELSE
        dst[i+7:i] := Convert_FP32_To_Int8(a[k+31:k])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set_ss

--------------------------------------------------------------------------------------------------------------
Copy single-precision (32-bit) floating-point element "a" to the lower element of "dst", and zero the upper 3
elements.

[algorithm]

dst[31:0] := a[31:0]
dst[127:32] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_set1_ps

--------------------------------------------------------------------------------------------------------------
Broadcast single-precision (32-bit) floating-point value "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set_ps1

--------------------------------------------------------------------------------------------------------------
Broadcast single-precision (32-bit) floating-point value "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set_ps

--------------------------------------------------------------------------------------------------------------
Set packed single-precision (32-bit) floating-point elements in "dst" with the supplied values.

[algorithm]

dst[31:0] := e0
dst[63:32] := e1
dst[95:64] := e2
dst[127:96] := e3

--------------------------------------------------------------------------------------------------------------

## _mm_setr_ps

--------------------------------------------------------------------------------------------------------------
Set packed single-precision (32-bit) floating-point elements in "dst" with the supplied values in reverse
order.

[algorithm]

dst[31:0] := e3
dst[63:32] := e2
dst[95:64] := e1
dst[127:96] := e0

--------------------------------------------------------------------------------------------------------------

## _mm_load1_ps

--------------------------------------------------------------------------------------------------------------
Load a single-precision (32-bit) floating-point element from memory into all elements of "dst".

[algorithm]

dst[31:0] := MEM[mem_addr+31:mem_addr]
dst[63:32] := MEM[mem_addr+31:mem_addr]
dst[95:64] := MEM[mem_addr+31:mem_addr]
dst[127:96] := MEM[mem_addr+31:mem_addr]

--------------------------------------------------------------------------------------------------------------

## _mm_load_ps1

--------------------------------------------------------------------------------------------------------------
Load a single-precision (32-bit) floating-point element from memory into all elements of "dst".

[algorithm]

dst[31:0] := MEM[mem_addr+31:mem_addr]
dst[63:32] := MEM[mem_addr+31:mem_addr]
dst[95:64] := MEM[mem_addr+31:mem_addr]
dst[127:96] := MEM[mem_addr+31:mem_addr]

--------------------------------------------------------------------------------------------------------------

## _mm_loadr_ps

--------------------------------------------------------------------------------------------------------------
Load 4 single-precision (32-bit) floating-point elements from memory into "dst" in reverse order. mem_addr
must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[31:0] := MEM[mem_addr+127:mem_addr+96]
dst[63:32] := MEM[mem_addr+95:mem_addr+64]
dst[95:64] := MEM[mem_addr+63:mem_addr+32]
dst[127:96] := MEM[mem_addr+31:mem_addr]

--------------------------------------------------------------------------------------------------------------

## _mm_store1_ps

--------------------------------------------------------------------------------------------------------------
Store the lower single-precision (32-bit) floating-point element from "a" into 4 contiguous elements in
memory. "mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+31:mem_addr] := a[31:0]
MEM[mem_addr+63:mem_addr+32] := a[31:0]
MEM[mem_addr+95:mem_addr+64] := a[31:0]
MEM[mem_addr+127:mem_addr+96] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## _mm_store_ps1

--------------------------------------------------------------------------------------------------------------
Store the lower single-precision (32-bit) floating-point element from "a" into 4 contiguous elements in
memory. "mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+31:mem_addr] := a[31:0]
MEM[mem_addr+63:mem_addr+32] := a[31:0]
MEM[mem_addr+95:mem_addr+64] := a[31:0]
MEM[mem_addr+127:mem_addr+96] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## _mm_malloc

--------------------------------------------------------------------------------------------------------------
Allocate "size" bytes of memory, aligned to the alignment specified in "align", and return a pointer to the
allocated memory. "_mm_free" should be used to free memory that is allocated with "_mm_malloc".

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_free

--------------------------------------------------------------------------------------------------------------
Free aligned memory that was allocated with "_mm_malloc".

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_undefined_ps

--------------------------------------------------------------------------------------------------------------
Return vector of type __m128 with undefined elements.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_storeu_si16

--------------------------------------------------------------------------------------------------------------
Store 16-bit integer from the first element of "a" into memory. "mem_addr" does not need to be aligned on any
particular boundary.

[algorithm]

MEM[mem_addr+15:mem_addr] := a[15:0]

--------------------------------------------------------------------------------------------------------------

## _mm_loadu_si16

--------------------------------------------------------------------------------------------------------------
Load unaligned 16-bit integer from memory into the first element of "dst".

[algorithm]

dst[15:0] := MEM[mem_addr+15:mem_addr]
dst[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_undefined_pd

--------------------------------------------------------------------------------------------------------------
Return vector of type __m128d with undefined elements.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_undefined_si128

--------------------------------------------------------------------------------------------------------------
Return vector of type __m128i with undefined elements.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_set_epi64

--------------------------------------------------------------------------------------------------------------
Set packed 64-bit integers in "dst" with the supplied values.

[algorithm]

dst[63:0] := e0
dst[127:64] := e1

--------------------------------------------------------------------------------------------------------------

## _mm_set_epi64x

--------------------------------------------------------------------------------------------------------------
Set packed 64-bit integers in "dst" with the supplied values.

[algorithm]

dst[63:0] := e0
dst[127:64] := e1

--------------------------------------------------------------------------------------------------------------

## _mm_set_epi32

--------------------------------------------------------------------------------------------------------------
Set packed 32-bit integers in "dst" with the supplied values.

[algorithm]

dst[31:0] := e0
dst[63:32] := e1
dst[95:64] := e2
dst[127:96] := e3

--------------------------------------------------------------------------------------------------------------

## _mm_set_epi16

--------------------------------------------------------------------------------------------------------------
Set packed 16-bit integers in "dst" with the supplied values.

[algorithm]

dst[15:0] := e0
dst[31:16] := e1
dst[47:32] := e2
dst[63:48] := e3
dst[79:64] := e4
dst[95:80] := e5
dst[111:96] := e6
dst[127:112] := e7

--------------------------------------------------------------------------------------------------------------

## _mm_set_epi8

--------------------------------------------------------------------------------------------------------------
Set packed 8-bit integers in "dst" with the supplied values.

[algorithm]

dst[7:0] := e0
dst[15:8] := e1
dst[23:16] := e2
dst[31:24] := e3
dst[39:32] := e4
dst[47:40] := e5
dst[55:48] := e6
dst[63:56] := e7
dst[71:64] := e8
dst[79:72] := e9
dst[87:80] := e10
dst[95:88] := e11
dst[103:96] := e12
dst[111:104] := e13
dst[119:112] := e14
dst[127:120] := e15

--------------------------------------------------------------------------------------------------------------

## _mm_set1_epi64

--------------------------------------------------------------------------------------------------------------
Broadcast 64-bit integer "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set1_epi64x

--------------------------------------------------------------------------------------------------------------
Broadcast 64-bit integer "a" to all elements of "dst". This intrinsic may generate the "vpbroadcastq".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set1_epi32

--------------------------------------------------------------------------------------------------------------
Broadcast 32-bit integer "a" to all elements of "dst". This intrinsic may generate "vpbroadcastd".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set1_epi16

--------------------------------------------------------------------------------------------------------------
Broadcast 16-bit integer "a" to all all elements of "dst". This intrinsic may generate "vpbroadcastw".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := a[15:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set1_epi8

--------------------------------------------------------------------------------------------------------------
Broadcast 8-bit integer "a" to all elements of "dst". This intrinsic may generate "vpbroadcastb".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := a[7:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_setr_epi64

--------------------------------------------------------------------------------------------------------------
Set packed 64-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[63:0] := e1
dst[127:64] := e0

--------------------------------------------------------------------------------------------------------------

## _mm_setr_epi32

--------------------------------------------------------------------------------------------------------------
Set packed 32-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[31:0] := e3
dst[63:32] := e2
dst[95:64] := e1
dst[127:96] := e0

--------------------------------------------------------------------------------------------------------------

## _mm_setr_epi16

--------------------------------------------------------------------------------------------------------------
Set packed 16-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[15:0] := e7
dst[31:16] := e6
dst[47:32] := e5
dst[63:48] := e4
dst[79:64] := e3
dst[95:80] := e2
dst[111:96] := e1
dst[127:112] := e0

--------------------------------------------------------------------------------------------------------------

## _mm_setr_epi8

--------------------------------------------------------------------------------------------------------------
Set packed 8-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[7:0] := e15
dst[15:8] := e14
dst[23:16] := e13
dst[31:24] := e12
dst[39:32] := e11
dst[47:40] := e10
dst[55:48] := e9
dst[63:56] := e8
dst[71:64] := e7
dst[79:72] := e6
dst[87:80] := e5
dst[95:88] := e4
dst[103:96] := e3
dst[111:104] := e2
dst[119:112] := e1
dst[127:120] := e0

--------------------------------------------------------------------------------------------------------------

## _mm_set_sd

--------------------------------------------------------------------------------------------------------------
Copy double-precision (64-bit) floating-point element "a" to the lower element of "dst", and zero the upper
element.

[algorithm]

dst[63:0] := a[63:0]
dst[127:64] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_set1_pd

--------------------------------------------------------------------------------------------------------------
Broadcast double-precision (64-bit) floating-point value "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set_pd1

--------------------------------------------------------------------------------------------------------------
Broadcast double-precision (64-bit) floating-point value "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm_set_pd

--------------------------------------------------------------------------------------------------------------
Set packed double-precision (64-bit) floating-point elements in "dst" with the supplied values.

[algorithm]

dst[63:0] := e0
dst[127:64] := e1

--------------------------------------------------------------------------------------------------------------

## _mm_setr_pd

--------------------------------------------------------------------------------------------------------------
Set packed double-precision (64-bit) floating-point elements in "dst" with the supplied values in reverse
order.

[algorithm]

dst[63:0] := e1
dst[127:64] := e0

--------------------------------------------------------------------------------------------------------------

## _mm_store1_pd

--------------------------------------------------------------------------------------------------------------
Store the lower double-precision (64-bit) floating-point element from "a" into 2 contiguous elements in
memory. "mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[63:0]
MEM[mem_addr+127:mem_addr+64] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## _mm_store_pd1

--------------------------------------------------------------------------------------------------------------
Store the lower double-precision (64-bit) floating-point element from "a" into 2 contiguous elements in
memory. "mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[63:0]
MEM[mem_addr+127:mem_addr+64] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## _mm_storer_pd

--------------------------------------------------------------------------------------------------------------
Store 2 double-precision (64-bit) floating-point elements from "a" into memory in reverse order.
	"mem_addr"
must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[127:64]
MEM[mem_addr+127:mem_addr+64] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## _mm_castpd_ps

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128d to type __m128. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_castpd_si128

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128d to type __m128i. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_castps_pd

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128 to type __m128d. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_castps_si128

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128 to type __m128i. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_castsi128_pd

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128i to type __m128d. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm_castsi128_ps

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128i to type __m128. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------
