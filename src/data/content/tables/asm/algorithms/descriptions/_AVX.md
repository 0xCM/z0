# _AVX

## VADDPD - _mm256_add_pd

| VADDPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[i+63:i] + b[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VADDPS - _mm256_add_ps

| VADDPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[i+31:i] + b[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VADDSUBPD - _mm256_addsub_pd

| VADDSUBPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Alternatively add and subtract packed double-precision (64-bit) floating-point elements in "a" to/from packed
elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF ((j &amp; 1) == 0)
        dst[i+63:i] := a[i+63:i] - b[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i] + b[i+63:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VADDSUBPS - _mm256_addsub_ps

| VADDSUBPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Alternatively add and subtract packed single-precision (32-bit) floating-point elements in "a" to/from packed
elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF ((j &amp; 1) == 0)
        dst[i+31:i] := a[i+31:i] - b[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i] + b[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VANDPD - _mm256_and_pd

| VANDPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of packed double-precision (64-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := (a[i+63:i] AND b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VANDPS - _mm256_and_ps

| VANDPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of packed single-precision (32-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := (a[i+31:i] AND b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VANDNPD - _mm256_andnot_pd

| VANDNPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of packed double-precision (64-bit) floating-point elements in "a" and then AND with
"b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ((NOT a[i+63:i]) AND b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VANDNPS - _mm256_andnot_ps

| VANDNPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of packed single-precision (32-bit) floating-point elements in "a" and then AND with
"b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ((NOT a[i+31:i]) AND b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBLENDPD - _mm256_blend_pd

| VBLENDPD_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Blend packed double-precision (64-bit) floating-point elements from "a" and "b" using control mask "imm8", and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF imm8[j]
        dst[i+63:i] := b[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBLENDPS - _mm256_blend_ps

| VBLENDPS_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Blend packed single-precision (32-bit) floating-point elements from "a" and "b" using control mask "imm8", and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF imm8[j]
        dst[i+31:i] := b[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBLENDVPD - _mm256_blendv_pd

| VBLENDVPD_YMMqq_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Blend packed double-precision (64-bit) floating-point elements from "a" and "b" using "mask", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF mask[i+63]
        dst[i+63:i] := b[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBLENDVPS - _mm256_blendv_ps

| VBLENDVPS_YMMqq_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Blend packed single-precision (32-bit) floating-point elements from "a" and "b" using "mask", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF mask[i+31]
        dst[i+31:i] := b[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VDIVPD - _mm256_div_pd

| VDIVPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Divide packed double-precision (64-bit) floating-point elements in "a" by packed elements in "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 64*j
    dst[i+63:i] := a[i+63:i] / b[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VDIVPS - _mm256_div_ps

| VDIVPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Divide packed single-precision (32-bit) floating-point elements in "a" by packed elements in "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := a[i+31:i] / b[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VDPPS - _mm256_dp_ps

| VDPPS_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Conditionally multiply the packed single-precision (32-bit) floating-point elements in "a" and "b" using the
high 4 bits in "imm8", sum the four products, and conditionally store the sum in "dst" using the low 4 bits of
"imm8".

[algorithm]

DEFINE DP(a[127:0], b[127:0], imm8[7:0]) {
    FOR j := 0 to 3
        i := j*32
        IF imm8[(4+j)%8]
            temp[i+31:i] := a[i+31:i] * b[i+31:i]
        ELSE
            temp[i+31:i] := FP32(0.0)
        FI
    ENDFOR
    
    sum[31:0] := (temp[127:96] + temp[95:64]) + (temp[63:32] + temp[31:0])
    
    FOR j := 0 to 3
        i := j*32
        IF imm8[j%8]
            tmpdst[i+31:i] := sum[31:0]
        ELSE
            tmpdst[i+31:i] := FP32(0.0)
        FI
    ENDFOR
    RETURN tmpdst[127:0]
}
dst[127:0] := DP(a[127:0], b[127:0], imm8[7:0])
dst[255:128] := DP(a[255:128], b[255:128], imm8[7:0])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VHADDPD - _mm256_hadd_pd

| VHADDPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of double-precision (64-bit) floating-point elements in "a" and "b", and pack
the results in "dst".

[algorithm]

dst[63:0] := a[127:64] + a[63:0]
dst[127:64] := b[127:64] + b[63:0]
dst[191:128] := a[255:192] + a[191:128]
dst[255:192] := b[255:192] + b[191:128]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VHADDPS - _mm256_hadd_ps

| VHADDPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of single-precision (32-bit) floating-point elements in "a" and "b", and pack
the results in "dst".

[algorithm]

dst[31:0] := a[63:32] + a[31:0]
dst[63:32] := a[127:96] + a[95:64]
dst[95:64] := b[63:32] + b[31:0]
dst[127:96] := b[127:96] + b[95:64]
dst[159:128] := a[191:160] + a[159:128]
dst[191:160] := a[255:224] + a[223:192]
dst[223:192] := b[191:160] + b[159:128]
dst[255:224] := b[255:224] + b[223:192]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VHSUBPD - _mm256_hsub_pd

| VHSUBPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of double-precision (64-bit) floating-point elements in "a" and "b", and
pack the results in "dst".

[algorithm]

dst[63:0] := a[63:0] - a[127:64]
dst[127:64] := b[63:0] - b[127:64]
dst[191:128] := a[191:128] - a[255:192]
dst[255:192] := b[191:128] - b[255:192]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VHSUBPS - _mm256_hsub_ps

| VHSUBPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of single-precision (32-bit) floating-point elements in "a" and "b", and pack
the results in "dst".

[algorithm]

dst[31:0] := a[31:0] - a[63:32]
dst[63:32] := a[95:64] - a[127:96]
dst[95:64] := b[31:0] - b[63:32]
dst[127:96] := b[95:64] - b[127:96]
dst[159:128] := a[159:128] - a[191:160]
dst[191:160] := a[223:192] - a[255:224]
dst[223:192] := b[159:128] - b[191:160]
dst[255:224] := b[223:192] - b[255:224]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMAXPD - _mm256_max_pd

| VMAXPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b", and store packed maximum
values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := MAX(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMAXPS - _mm256_max_ps

| VMAXPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b", and store packed maximum
values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMINPD - _mm256_min_pd

| VMINPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b", and store packed minimum
values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := MIN(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMINPS - _mm256_min_ps

| VMINPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b", and store packed minimum
values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMULPD - _mm256_mul_pd

| VMULPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[i+63:i] * b[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMULPS - _mm256_mul_ps

| VMULPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[i+31:i] * b[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VORPD - _mm256_or_pd

| VORPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of packed double-precision (64-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[i+63:i] OR b[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VORPS - _mm256_or_ps

| VORPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of packed single-precision (32-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[i+31:i] OR b[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VSHUFPD - _mm256_shuffle_pd

| VSHUFPD_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle double-precision (64-bit) floating-point elements within 128-bit lanes using the control in "imm8",
and store the results in "dst".

[algorithm]

dst[63:0] := (imm8[0] == 0) ? a[63:0] : a[127:64]
dst[127:64] := (imm8[1] == 0) ? b[63:0] : b[127:64]
dst[191:128] := (imm8[2] == 0) ? a[191:128] : a[255:192]
dst[255:192] := (imm8[3] == 0) ? b[191:128] : b[255:192]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VSHUFPS - _mm256_shuffle_ps

| VSHUFPS_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle single-precision (32-bit) floating-point elements in "a" within 128-bit lanes using the control in
"imm8", and store the results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[31:0] := src[31:0]
    1:    tmp[31:0] := src[63:32]
    2:    tmp[31:0] := src[95:64]
    3:    tmp[31:0] := src[127:96]
    ESAC
    RETURN tmp[31:0]
}
dst[31:0] := SELECT4(a[127:0], imm8[1:0])
dst[63:32] := SELECT4(a[127:0], imm8[3:2])
dst[95:64] := SELECT4(b[127:0], imm8[5:4])
dst[127:96] := SELECT4(b[127:0], imm8[7:6])
dst[159:128] := SELECT4(a[255:128], imm8[1:0])
dst[191:160] := SELECT4(a[255:128], imm8[3:2])
dst[223:192] := SELECT4(b[255:128], imm8[5:4])
dst[255:224] := SELECT4(b[255:128], imm8[7:6])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBPD - _mm256_sub_pd

| VSUBPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed double-precision (64-bit) floating-point elements in "b" from packed double-precision (64-bit)
floating-point elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[i+63:i] - b[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBPS - _mm256_sub_ps

| VSUBPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed single-precision (32-bit) floating-point elements in "b" from packed single-precision (32-bit)
floating-point elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[i+31:i] - b[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VXORPD - _mm256_xor_pd

| VXORPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of packed double-precision (64-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[i+63:i] XOR b[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VXORPS - _mm256_xor_ps

| VXORPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of packed single-precision (32-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[i+31:i] XOR b[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm_cmp_pd

| VCMPPD_XMMdq_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in "dst".

[algorithm]

CASE (imm8[4:0]) OF
0: OP := _CMP_EQ_OQ
1: OP := _CMP_LT_OS
2: OP := _CMP_LE_OS
3: OP := _CMP_UNORD_Q 
4: OP := _CMP_NEQ_UQ
5: OP := _CMP_NLT_US
6: OP := _CMP_NLE_US
7: OP := _CMP_ORD_Q
8: OP := _CMP_EQ_UQ
9: OP := _CMP_NGE_US
10: OP := _CMP_NGT_US
11: OP := _CMP_FALSE_OQ
12: OP := _CMP_NEQ_OQ
13: OP := _CMP_GE_OS
14: OP := _CMP_GT_OS
15: OP := _CMP_TRUE_UQ
16: OP := _CMP_EQ_OS
17: OP := _CMP_LT_OQ
18: OP := _CMP_LE_OQ
19: OP := _CMP_UNORD_S
20: OP := _CMP_NEQ_US
21: OP := _CMP_NLT_UQ
22: OP := _CMP_NLE_UQ
23: OP := _CMP_ORD_S
24: OP := _CMP_EQ_US
25: OP := _CMP_NGE_UQ 
26: OP := _CMP_NGT_UQ 
27: OP := _CMP_FALSE_OS 
28: OP := _CMP_NEQ_OS 
29: OP := _CMP_GE_OQ
30: OP := _CMP_GT_OQ
31: OP := _CMP_TRUE_US
ESAC
FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ( a[i+63:i] OP b[i+63:i] ) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm256_cmp_pd

| VCMPPD_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in "dst".

[algorithm]

CASE (imm8[4:0]) OF
0: OP := _CMP_EQ_OQ
1: OP := _CMP_LT_OS
2: OP := _CMP_LE_OS
3: OP := _CMP_UNORD_Q 
4: OP := _CMP_NEQ_UQ
5: OP := _CMP_NLT_US
6: OP := _CMP_NLE_US
7: OP := _CMP_ORD_Q
8: OP := _CMP_EQ_UQ
9: OP := _CMP_NGE_US
10: OP := _CMP_NGT_US
11: OP := _CMP_FALSE_OQ
12: OP := _CMP_NEQ_OQ
13: OP := _CMP_GE_OS
14: OP := _CMP_GT_OS
15: OP := _CMP_TRUE_UQ
16: OP := _CMP_EQ_OS
17: OP := _CMP_LT_OQ
18: OP := _CMP_LE_OQ
19: OP := _CMP_UNORD_S
20: OP := _CMP_NEQ_US
21: OP := _CMP_NLT_UQ
22: OP := _CMP_NLE_UQ
23: OP := _CMP_ORD_S
24: OP := _CMP_EQ_US
25: OP := _CMP_NGE_UQ 
26: OP := _CMP_NGT_UQ 
27: OP := _CMP_FALSE_OS 
28: OP := _CMP_NEQ_OS 
29: OP := _CMP_GE_OQ
30: OP := _CMP_GT_OQ
31: OP := _CMP_TRUE_US
ESAC
FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ( a[i+63:i] OP b[i+63:i] ) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm_cmp_ps

| VCMPPS_XMMdq_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in "dst".

[algorithm]

CASE (imm8[4:0]) OF
0: OP := _CMP_EQ_OQ
1: OP := _CMP_LT_OS
2: OP := _CMP_LE_OS
3: OP := _CMP_UNORD_Q 
4: OP := _CMP_NEQ_UQ
5: OP := _CMP_NLT_US
6: OP := _CMP_NLE_US
7: OP := _CMP_ORD_Q
8: OP := _CMP_EQ_UQ
9: OP := _CMP_NGE_US
10: OP := _CMP_NGT_US
11: OP := _CMP_FALSE_OQ
12: OP := _CMP_NEQ_OQ
13: OP := _CMP_GE_OS
14: OP := _CMP_GT_OS
15: OP := _CMP_TRUE_UQ
16: OP := _CMP_EQ_OS
17: OP := _CMP_LT_OQ
18: OP := _CMP_LE_OQ
19: OP := _CMP_UNORD_S
20: OP := _CMP_NEQ_US
21: OP := _CMP_NLT_UQ
22: OP := _CMP_NLE_UQ
23: OP := _CMP_ORD_S
24: OP := _CMP_EQ_US
25: OP := _CMP_NGE_UQ 
26: OP := _CMP_NGT_UQ 
27: OP := _CMP_FALSE_OS 
28: OP := _CMP_NEQ_OS 
29: OP := _CMP_GE_OQ
30: OP := _CMP_GT_OQ
31: OP := _CMP_TRUE_US
ESAC
FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] OP b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm256_cmp_ps

| VCMPPS_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in "dst".

[algorithm]

CASE (imm8[4:0]) OF
0: OP := _CMP_EQ_OQ
1: OP := _CMP_LT_OS
2: OP := _CMP_LE_OS
3: OP := _CMP_UNORD_Q 
4: OP := _CMP_NEQ_UQ
5: OP := _CMP_NLT_US
6: OP := _CMP_NLE_US
7: OP := _CMP_ORD_Q
8: OP := _CMP_EQ_UQ
9: OP := _CMP_NGE_US
10: OP := _CMP_NGT_US
11: OP := _CMP_FALSE_OQ
12: OP := _CMP_NEQ_OQ
13: OP := _CMP_GE_OS
14: OP := _CMP_GT_OS
15: OP := _CMP_TRUE_UQ
16: OP := _CMP_EQ_OS
17: OP := _CMP_LT_OQ
18: OP := _CMP_LE_OQ
19: OP := _CMP_UNORD_S
20: OP := _CMP_NEQ_US
21: OP := _CMP_NLT_UQ
22: OP := _CMP_NLE_UQ
23: OP := _CMP_ORD_S
24: OP := _CMP_EQ_US
25: OP := _CMP_NGE_UQ 
26: OP := _CMP_NGT_UQ 
27: OP := _CMP_FALSE_OS 
28: OP := _CMP_NEQ_OS 
29: OP := _CMP_GE_OQ
30: OP := _CMP_GT_OQ
31: OP := _CMP_TRUE_US
ESAC
FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ( a[i+31:i] OP b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPSD - _mm_cmp_sd

| VCMPSD_XMMdq_XMMdq_XMMq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" based on the comparison
operand specified by "imm8", store the result in the lower element of "dst", and copy the upper element from
"a" to the upper element of "dst".

[algorithm]

CASE (imm8[4:0]) OF
0: OP := _CMP_EQ_OQ
1: OP := _CMP_LT_OS
2: OP := _CMP_LE_OS
3: OP := _CMP_UNORD_Q 
4: OP := _CMP_NEQ_UQ
5: OP := _CMP_NLT_US
6: OP := _CMP_NLE_US
7: OP := _CMP_ORD_Q
8: OP := _CMP_EQ_UQ
9: OP := _CMP_NGE_US
10: OP := _CMP_NGT_US
11: OP := _CMP_FALSE_OQ
12: OP := _CMP_NEQ_OQ
13: OP := _CMP_GE_OS
14: OP := _CMP_GT_OS
15: OP := _CMP_TRUE_UQ
16: OP := _CMP_EQ_OS
17: OP := _CMP_LT_OQ
18: OP := _CMP_LE_OQ
19: OP := _CMP_UNORD_S
20: OP := _CMP_NEQ_US
21: OP := _CMP_NLT_UQ
22: OP := _CMP_NLE_UQ
23: OP := _CMP_ORD_S
24: OP := _CMP_EQ_US
25: OP := _CMP_NGE_UQ 
26: OP := _CMP_NGT_UQ 
27: OP := _CMP_FALSE_OS 
28: OP := _CMP_NEQ_OS 
29: OP := _CMP_GE_OQ
30: OP := _CMP_GT_OQ
31: OP := _CMP_TRUE_US
ESAC
dst[63:0] := ( a[63:0] OP b[63:0] ) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPSS - _mm_cmp_ss

| VCMPSS_XMMdq_XMMdq_XMMd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" based on the comparison
operand specified by "imm8", store the result in the lower element of "dst", and copy the upper 3 packed
elements from "a" to the upper elements of "dst".

[algorithm]

CASE (imm8[4:0]) OF
0: OP := _CMP_EQ_OQ
1: OP := _CMP_LT_OS
2: OP := _CMP_LE_OS
3: OP := _CMP_UNORD_Q 
4: OP := _CMP_NEQ_UQ
5: OP := _CMP_NLT_US
6: OP := _CMP_NLE_US
7: OP := _CMP_ORD_Q
8: OP := _CMP_EQ_UQ
9: OP := _CMP_NGE_US
10: OP := _CMP_NGT_US
11: OP := _CMP_FALSE_OQ
12: OP := _CMP_NEQ_OQ
13: OP := _CMP_GE_OS
14: OP := _CMP_GT_OS
15: OP := _CMP_TRUE_UQ
16: OP := _CMP_EQ_OS
17: OP := _CMP_LT_OQ
18: OP := _CMP_LE_OQ
19: OP := _CMP_UNORD_S
20: OP := _CMP_NEQ_US
21: OP := _CMP_NLT_UQ
22: OP := _CMP_NLE_UQ
23: OP := _CMP_ORD_S
24: OP := _CMP_EQ_US
25: OP := _CMP_NGE_UQ 
26: OP := _CMP_NGT_UQ 
27: OP := _CMP_FALSE_OS 
28: OP := _CMP_NEQ_OS 
29: OP := _CMP_GE_OQ
30: OP := _CMP_GT_OQ
31: OP := _CMP_TRUE_US
ESAC
dst[31:0] := ( a[31:0] OP b[31:0] ) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTDQ2PD - _mm256_cvtepi32_pd

| VCVTDQ2PD_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers in "a" to packed double-precision (64-bit) floating-point elements, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*64
    dst[m+63:m] := Convert_Int32_To_FP64(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTDQ2PS - _mm256_cvtepi32_ps

| VCVTDQ2PS_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers in "a" to packed single-precision (32-bit) floating-point elements, and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := Convert_Int32_To_FP32(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPD2PS - _mm256_cvtpd_ps

| VCVTPD2PS_XMMdq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed double-precision (64-bit) floating-point elements in "a" to packed single-precision (32-bit)
floating-point elements, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    k := 64*j
    dst[i+31:i] := Convert_FP64_To_FP32(a[k+63:k])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPS2DQ - _mm256_cvtps_epi32

| VCVTPS2DQ_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers, and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := Convert_FP32_To_Int32(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPS2PD - _mm256_cvtps_pd

| VCVTPS2PD_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed double-precision (64-bit)
floating-point elements, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 64*j
    k := 32*j
    dst[i+63:i] := Convert_FP32_To_FP64(a[k+31:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTTPD2DQ - _mm256_cvttpd_epi32

| VCVTTPD2DQ_XMMdq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers with
truncation, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    k := 64*j
    dst[i+31:i] := Convert_FP64_To_Int32_Truncate(a[k+63:k])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPD2DQ - _mm256_cvtpd_epi32

| VCVTPD2DQ_XMMdq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers, and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    k := 64*j
    dst[i+31:i] := Convert_FP64_To_Int32(a[k+63:k])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTTPS2DQ - _mm256_cvttps_epi32

| VCVTTPS2DQ_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers with
truncation, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := Convert_FP32_To_Int32_Truncate(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VEXTRACTF128 - _mm256_extractf128_ps

| VEXTRACTF128_XMMdq_YMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract 128 bits (composed of 4 packed single-precision (32-bit) floating-point elements) from "a", selected
with "imm8", and store the result in "dst".

[algorithm]

CASE imm8[0] OF
0: dst[127:0] := a[127:0]
1: dst[127:0] := a[255:128]
ESAC
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VEXTRACTF128 - _mm256_extractf128_pd

| VEXTRACTF128_XMMdq_YMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract 128 bits (composed of 2 packed double-precision (64-bit) floating-point elements) from "a", selected
with "imm8", and store the result in "dst".

[algorithm]

CASE imm8[0] OF
0: dst[127:0] := a[127:0]
1: dst[127:0] := a[255:128]
ESAC
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VEXTRACTF128 - _mm256_extractf128_si256

| VEXTRACTF128_XMMdq_YMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract 128 bits (composed of integer data) from "a", selected with "imm8", and store the result in "dst".

[algorithm]

CASE imm8[0] OF
0: dst[127:0] := a[127:0]
1: dst[127:0] := a[255:128]
ESAC
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_extract_epi32

--------------------------------------------------------------------------------------------------------------
Extract a 32-bit integer from "a", selected with "index", and store the result in "dst".

[algorithm]

dst[31:0] := (a[255:0] &gt;&gt; (index[2:0] * 32))[31:0]

--------------------------------------------------------------------------------------------------------------

## _mm256_extract_epi64

--------------------------------------------------------------------------------------------------------------
Extract a 64-bit integer from "a", selected with "index", and store the result in "dst".

[algorithm]

dst[63:0] := (a[255:0] &gt;&gt; (index[1:0] * 64))[63:0]

--------------------------------------------------------------------------------------------------------------

## VZEROALL - _mm256_zeroall

| VZEROALL

--------------------------------------------------------------------------------------------------------------
Zero the contents of all XMM or YMM registers.

[algorithm]

YMM0[MAX:0] := 0
YMM1[MAX:0] := 0
YMM2[MAX:0] := 0
YMM3[MAX:0] := 0
YMM4[MAX:0] := 0
YMM5[MAX:0] := 0
YMM6[MAX:0] := 0
YMM7[MAX:0] := 0
IF _64_BIT_MODE
    YMM8[MAX:0] := 0
    YMM9[MAX:0] := 0
    YMM10[MAX:0] := 0
    YMM11[MAX:0] := 0
    YMM12[MAX:0] := 0
    YMM13[MAX:0] := 0
    YMM14[MAX:0] := 0
    YMM15[MAX:0] := 0
FI

--------------------------------------------------------------------------------------------------------------

## VZEROUPPER - _mm256_zeroupper

| VZEROUPPER

--------------------------------------------------------------------------------------------------------------
Zero the upper 128 bits of all YMM registers; the lower 128-bits of the registers are unmodified.

[algorithm]

YMM0[MAX:128] := 0
YMM1[MAX:128] := 0
YMM2[MAX:128] := 0
YMM3[MAX:128] := 0
YMM4[MAX:128] := 0
YMM5[MAX:128] := 0
YMM6[MAX:128] := 0
YMM7[MAX:128] := 0
IF _64_BIT_MODE
    YMM8[MAX:128] := 0
    YMM9[MAX:128] := 0
    YMM10[MAX:128] := 0
    YMM11[MAX:128] := 0
    YMM12[MAX:128] := 0
    YMM13[MAX:128] := 0
    YMM14[MAX:128] := 0
    YMM15[MAX:128] := 0
FI

--------------------------------------------------------------------------------------------------------------

## VPERMILPS - _mm256_permutevar_ps

| VPERMILPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shuffle single-precision (32-bit) floating-point elements in "a" within 128-bit lanes using the control in
"b", and store the results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[31:0] := src[31:0]
    1:    tmp[31:0] := src[63:32]
    2:    tmp[31:0] := src[95:64]
    3:    tmp[31:0] := src[127:96]
    ESAC
    RETURN tmp[31:0]
}
dst[31:0] := SELECT4(a[127:0], b[1:0])
dst[63:32] := SELECT4(a[127:0], b[33:32])
dst[95:64] := SELECT4(a[127:0], b[65:64])
dst[127:96] := SELECT4(a[127:0], b[97:96])
dst[159:128] := SELECT4(a[255:128], b[129:128])
dst[191:160] := SELECT4(a[255:128], b[161:160])
dst[223:192] := SELECT4(a[255:128], b[193:192])
dst[255:224] := SELECT4(a[255:128], b[225:224])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMILPS - _mm_permutevar_ps

| VPERMILPS_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shuffle single-precision (32-bit) floating-point elements in "a" using the control in "b", and store the
results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[31:0] := src[31:0]
    1:    tmp[31:0] := src[63:32]
    2:    tmp[31:0] := src[95:64]
    3:    tmp[31:0] := src[127:96]
    ESAC
    RETURN tmp[31:0]
}
dst[31:0] := SELECT4(a[127:0], b[1:0])
dst[63:32] := SELECT4(a[127:0], b[33:32])
dst[95:64] := SELECT4(a[127:0], b[65:64])
dst[127:96] := SELECT4(a[127:0], b[97:96])
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMILPS - _mm256_permute_ps

| VPERMILPS_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle single-precision (32-bit) floating-point elements in "a" within 128-bit lanes using the control in
"imm8", and store the results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[31:0] := src[31:0]
    1:    tmp[31:0] := src[63:32]
    2:    tmp[31:0] := src[95:64]
    3:    tmp[31:0] := src[127:96]
    ESAC
    RETURN tmp[31:0]
}
dst[31:0] := SELECT4(a[127:0], imm8[1:0])
dst[63:32] := SELECT4(a[127:0], imm8[3:2])
dst[95:64] := SELECT4(a[127:0], imm8[5:4])
dst[127:96] := SELECT4(a[127:0], imm8[7:6])
dst[159:128] := SELECT4(a[255:128], imm8[1:0])
dst[191:160] := SELECT4(a[255:128], imm8[3:2])
dst[223:192] := SELECT4(a[255:128], imm8[5:4])
dst[255:224] := SELECT4(a[255:128], imm8[7:6])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMILPS - _mm_permute_ps

| VPERMILPS_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle single-precision (32-bit) floating-point elements in "a" using the control in "imm8", and store the
results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[31:0] := src[31:0]
    1:    tmp[31:0] := src[63:32]
    2:    tmp[31:0] := src[95:64]
    3:    tmp[31:0] := src[127:96]
    ESAC
    RETURN tmp[31:0]
}
dst[31:0] := SELECT4(a[127:0], imm8[1:0])
dst[63:32] := SELECT4(a[127:0], imm8[3:2])
dst[95:64] := SELECT4(a[127:0], imm8[5:4])
dst[127:96] := SELECT4(a[127:0], imm8[7:6])
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMILPD - _mm256_permutevar_pd

| VPERMILPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shuffle double-precision (64-bit) floating-point elements in "a" within 128-bit lanes using the control in
"b", and store the results in "dst".

[algorithm]

IF (b[1] == 0) dst[63:0] := a[63:0]; FI
IF (b[1] == 1) dst[63:0] := a[127:64]; FI
IF (b[65] == 0) dst[127:64] := a[63:0]; FI
IF (b[65] == 1) dst[127:64] := a[127:64]; FI
IF (b[129] == 0) dst[191:128] := a[191:128]; FI
IF (b[129] == 1) dst[191:128] := a[255:192]; FI
IF (b[193] == 0) dst[255:192] := a[191:128]; FI
IF (b[193] == 1) dst[255:192] := a[255:192]; FI
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMILPD - _mm_permutevar_pd

| VPERMILPD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shuffle double-precision (64-bit) floating-point elements in "a" using the control in "b", and store the
results in "dst".

[algorithm]

IF (b[1] == 0) dst[63:0] := a[63:0]; FI
IF (b[1] == 1) dst[63:0] := a[127:64]; FI
IF (b[65] == 0) dst[127:64] := a[63:0]; FI
IF (b[65] == 1) dst[127:64] := a[127:64]; FI
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMILPD - _mm256_permute_pd

| VPERMILPD_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle double-precision (64-bit) floating-point elements in "a" within 128-bit lanes using the control in
"imm8", and store the results in "dst".

[algorithm]

IF (imm8[0] == 0) dst[63:0] := a[63:0]; FI
IF (imm8[0] == 1) dst[63:0] := a[127:64]; FI
IF (imm8[1] == 0) dst[127:64] := a[63:0]; FI
IF (imm8[1] == 1) dst[127:64] := a[127:64]; FI
IF (imm8[2] == 0) dst[191:128] := a[191:128]; FI
IF (imm8[2] == 1) dst[191:128] := a[255:192]; FI
IF (imm8[3] == 0) dst[255:192] := a[191:128]; FI
IF (imm8[3] == 1) dst[255:192] := a[255:192]; FI
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMILPD - _mm_permute_pd

| VPERMILPD_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle double-precision (64-bit) floating-point elements in "a" using the control in "imm8", and store the
results in "dst".

[algorithm]

IF (imm8[0] == 0) dst[63:0] := a[63:0]; FI
IF (imm8[0] == 1) dst[63:0] := a[127:64]; FI
IF (imm8[1] == 0) dst[127:64] := a[63:0]; FI
IF (imm8[1] == 1) dst[127:64] := a[127:64]; FI
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPERM2F128 - _mm256_permute2f128_ps

| VPERM2F128_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) selected by "imm8"
from "a" and "b", and store the results in "dst".

[algorithm]

DEFINE SELECT4(src1, src2, control) {
    CASE(control[1:0]) OF
    0:    tmp[127:0] := src1[127:0]
    1:    tmp[127:0] := src1[255:128]
    2:    tmp[127:0] := src2[127:0]
    3:    tmp[127:0] := src2[255:128]
    ESAC
    IF control[3]
        tmp[127:0] := 0
    FI
    RETURN tmp[127:0]
}
dst[127:0] := SELECT4(a[255:0], b[255:0], imm8[3:0])
dst[255:128] := SELECT4(a[255:0], b[255:0], imm8[7:4])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERM2F128 - _mm256_permute2f128_pd

| VPERM2F128_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) selected by "imm8"
from "a" and "b", and store the results in "dst".

[algorithm]

DEFINE SELECT4(src1, src2, control) {
    CASE(control[1:0]) OF
    0:    tmp[127:0] := src1[127:0]
    1:    tmp[127:0] := src1[255:128]
    2:    tmp[127:0] := src2[127:0]
    3:    tmp[127:0] := src2[255:128]
    ESAC
    IF control[3]
        tmp[127:0] := 0
    FI
    RETURN tmp[127:0]
}
dst[127:0] := SELECT4(a[255:0], b[255:0], imm8[3:0])
dst[255:128] := SELECT4(a[255:0], b[255:0], imm8[7:4])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERM2F128 - _mm256_permute2f128_si256

| VPERM2F128_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 128-bits (composed of integer data) selected by "imm8" from "a" and "b", and store the results in
"dst".

[algorithm]

DEFINE SELECT4(src1, src2, control) {
    CASE(control[1:0]) OF
    0:    tmp[127:0] := src1[127:0]
    1:    tmp[127:0] := src1[255:128]
    2:    tmp[127:0] := src2[127:0]
    3:    tmp[127:0] := src2[255:128]
    ESAC
    IF control[3]
        tmp[127:0] := 0
    FI
    RETURN tmp[127:0]
}
dst[127:0] := SELECT4(a[255:0], b[255:0], imm8[3:0])
dst[255:128] := SELECT4(a[255:0], b[255:0], imm8[7:4])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTSS - _mm256_broadcast_ss

| VBROADCASTSS_YMMqq_MEMd

--------------------------------------------------------------------------------------------------------------
Broadcast a single-precision (32-bit) floating-point element from memory to all elements of "dst".

[algorithm]

tmp[31:0] := MEM[mem_addr+31:mem_addr]
FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := tmp[31:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTSS - _mm_broadcast_ss

| VBROADCASTSS_XMMdq_MEMd

--------------------------------------------------------------------------------------------------------------
Broadcast a single-precision (32-bit) floating-point element from memory to all elements of "dst".

[algorithm]

tmp[31:0] := MEM[mem_addr+31:mem_addr]
FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := tmp[31:0]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTSD - _mm256_broadcast_sd

| VBROADCASTSD_YMMqq_MEMq

--------------------------------------------------------------------------------------------------------------
Broadcast a double-precision (64-bit) floating-point element from memory to all elements of "dst".

[algorithm]

tmp[63:0] := MEM[mem_addr+63:mem_addr]
FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := tmp[63:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTF128 - _mm256_broadcast_ps

| VBROADCASTF128_YMMqq_MEMdq

--------------------------------------------------------------------------------------------------------------
Broadcast 128 bits from memory (composed of 4 packed single-precision (32-bit) floating-point elements) to all
elements of "dst".

[algorithm]

tmp[127:0] := MEM[mem_addr+127:mem_addr]
dst[127:0] := tmp[127:0]
dst[255:128] := tmp[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTF128 - _mm256_broadcast_pd

| VBROADCASTF128_YMMqq_MEMdq

--------------------------------------------------------------------------------------------------------------
Broadcast 128 bits from memory (composed of 2 packed double-precision (64-bit) floating-point elements) to all
elements of "dst".

[algorithm]

tmp[127:0] := MEM[mem_addr+127:mem_addr]
dst[127:0] := tmp[127:0]
dst[255:128] := tmp[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VINSERTF128 - _mm256_insertf128_ps

| VINSERTF128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", then insert 128 bits (composed of 4 packed single-precision (32-bit) floating-point
elements) from "b" into "dst" at the location specified by "imm8".

[algorithm]

dst[255:0] := a[255:0]
CASE (imm8[0]) OF
0: dst[127:0] := b[127:0]
1: dst[255:128] := b[127:0]
ESAC
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VINSERTF128 - _mm256_insertf128_pd

| VINSERTF128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", then insert 128 bits (composed of 2 packed double-precision (64-bit) floating-point
elements) from "b" into "dst" at the location specified by "imm8".

[algorithm]

dst[255:0] := a[255:0]
CASE imm8[0] OF
0: dst[127:0] := b[127:0]
1: dst[255:128] := b[127:0]
ESAC
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VINSERTF128 - _mm256_insertf128_si256

| VINSERTF128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", then insert 128 bits from "b" into "dst" at the location specified by "imm8".

[algorithm]

dst[255:0] := a[255:0]
CASE (imm8[0]) OF
0: dst[127:0] := b[127:0]
1: dst[255:128] := b[127:0]
ESAC
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_insert_epi8

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the 8-bit integer "i" into "dst" at the location specified by "index".

[algorithm]

dst[255:0] := a[255:0]
sel := index[4:0]*8
dst[sel+7:sel] := i[7:0]

--------------------------------------------------------------------------------------------------------------

## _mm256_insert_epi16

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the 16-bit integer "i" into "dst" at the location specified by "index".

[algorithm]

dst[255:0] := a[255:0]
sel := index[3:0]*16
dst[sel+15:sel] := i[15:0]

--------------------------------------------------------------------------------------------------------------

## _mm256_insert_epi32

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the 32-bit integer "i" into "dst" at the location specified by "index".

[algorithm]

dst[255:0] := a[255:0]
sel := index[2:0]*32
dst[sel+31:sel] := i[31:0]

--------------------------------------------------------------------------------------------------------------

## _mm256_insert_epi64

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the 64-bit integer "i" into "dst" at the location specified by "index".

[algorithm]

dst[255:0] := a[255:0]
sel := index[1:0]*64
dst[sel+63:sel] := i[63:0]

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm256_load_pd

| VMOVAPD_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from memory into
"dst".
	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[255:0] := MEM[mem_addr+255:mem_addr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm256_store_pd

| VMOVAPD_MEMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from "a" into
memory.
	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+255:mem_addr] := a[255:0]

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm256_load_ps

| VMOVAPS_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from memory into
"dst".
	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[255:0] := MEM[mem_addr+255:mem_addr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm256_store_ps

| VMOVAPS_MEMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from "a" into
memory.
	"mem_addr" must be aligned on a 32-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+255:mem_addr] := a[255:0]

--------------------------------------------------------------------------------------------------------------

## VMOVUPD - _mm256_loadu_pd

| VMOVUPD_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from memory into
"dst".
	"mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[255:0] := MEM[mem_addr+255:mem_addr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVUPD - _mm256_storeu_pd

| VMOVUPD_MEMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from "a" into
memory.
	"mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

MEM[mem_addr+255:mem_addr] := a[255:0]

--------------------------------------------------------------------------------------------------------------

## VMOVUPS - _mm256_loadu_ps

| VMOVUPS_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from memory into
"dst".
	"mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[255:0] := MEM[mem_addr+255:mem_addr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVUPS - _mm256_storeu_ps

| VMOVUPS_MEMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from "a" into
memory.
	"mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

MEM[mem_addr+255:mem_addr] := a[255:0]

--------------------------------------------------------------------------------------------------------------

## VMOVDQA - _mm256_load_si256

| VMOVDQA_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load 256-bits of integer data from memory into "dst".
	"mem_addr" must be aligned on a 32-byte boundary or a
general-protection exception may be generated.

[algorithm]

dst[255:0] := MEM[mem_addr+255:mem_addr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA - _mm256_store_si256

| VMOVDQA_MEMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store 256-bits of integer data from "a" into memory.
	"mem_addr" must be aligned on a 32-byte boundary or a
general-protection exception may be generated.

[algorithm]

MEM[mem_addr+255:mem_addr] := a[255:0]

--------------------------------------------------------------------------------------------------------------

## VMOVDQU - _mm256_loadu_si256

| VMOVDQU_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load 256-bits of integer data from memory into "dst".
	"mem_addr" does not need to be aligned on any
particular boundary.

[algorithm]

dst[255:0] := MEM[mem_addr+255:mem_addr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQU - _mm256_storeu_si256

| VMOVDQU_MEMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store 256-bits of integer data from "a" into memory.
	"mem_addr" does not need to be aligned on any particular
boundary.

[algorithm]

MEM[mem_addr+255:mem_addr] := a[255:0]

--------------------------------------------------------------------------------------------------------------

## VMASKMOVPD - _mm256_maskload_pd

| VMASKMOVPD_YMMqq_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load packed double-precision (64-bit) floating-point elements from memory into "dst" using "mask" (elements
are zeroed out when the high bit of the corresponding element is not set).

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF mask[i+63]
        dst[i+63:i] := MEM[mem_addr+i+63:mem_addr+i]
    ELSE
        dst[i+63:i] := 0
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMASKMOVPD - _mm256_maskstore_pd

| VMASKMOVPD_MEMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store packed double-precision (64-bit) floating-point elements from "a" into memory using "mask".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF mask[i+63]
        MEM[mem_addr+i+63:mem_addr+i] := a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMASKMOVPD - _mm_maskload_pd

| VMASKMOVPD_XMMdq_XMMdq_MEMdq

--------------------------------------------------------------------------------------------------------------
Load packed double-precision (64-bit) floating-point elements from memory into "dst" using "mask" (elements
are zeroed out when the high bit of the corresponding element is not set).

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF mask[i+63]
        dst[i+63:i] := MEM[mem_addr+i+63:mem_addr+i]
    ELSE
        dst[i+63:i] := 0
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VMASKMOVPD - _mm_maskstore_pd

| VMASKMOVPD_MEMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Store packed double-precision (64-bit) floating-point elements from "a" into memory using "mask".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF mask[i+63]
        MEM[mem_addr+i+63:mem_addr+i] := a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMASKMOVPS - _mm256_maskload_ps

| VMASKMOVPS_YMMqq_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load packed single-precision (32-bit) floating-point elements from memory into "dst" using "mask" (elements
are zeroed out when the high bit of the corresponding element is not set).

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF mask[i+31]
        dst[i+31:i] := MEM[mem_addr+i+31:mem_addr+i]
    ELSE
        dst[i+31:i] := 0
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMASKMOVPS - _mm256_maskstore_ps

| VMASKMOVPS_MEMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store packed single-precision (32-bit) floating-point elements from "a" into memory using "mask".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF mask[i+31]
        MEM[mem_addr+i+31:mem_addr+i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMASKMOVPS - _mm_maskload_ps

| VMASKMOVPS_XMMdq_XMMdq_MEMdq

--------------------------------------------------------------------------------------------------------------
Load packed single-precision (32-bit) floating-point elements from memory into "dst" using "mask" (elements
are zeroed out when the high bit of the corresponding element is not set).

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF mask[i+31]
        dst[i+31:i] := MEM[mem_addr+i+31:mem_addr+i]
    ELSE
        dst[i+31:i] := 0
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VMASKMOVPS - _mm_maskstore_ps

| VMASKMOVPS_MEMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Store packed single-precision (32-bit) floating-point elements from "a" into memory using "mask".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF mask[i+31]
        MEM[mem_addr+i+31:mem_addr+i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVSHDUP - _mm256_movehdup_ps

| VMOVSHDUP_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Duplicate odd-indexed single-precision (32-bit) floating-point elements from "a", and store the results in
"dst".

[algorithm]

dst[31:0] := a[63:32] 
dst[63:32] := a[63:32] 
dst[95:64] := a[127:96] 
dst[127:96] := a[127:96]
dst[159:128] := a[191:160] 
dst[191:160] := a[191:160] 
dst[223:192] := a[255:224] 
dst[255:224] := a[255:224]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVSLDUP - _mm256_moveldup_ps

| VMOVSLDUP_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Duplicate even-indexed single-precision (32-bit) floating-point elements from "a", and store the results in
"dst".

[algorithm]

dst[31:0] := a[31:0] 
dst[63:32] := a[31:0] 
dst[95:64] := a[95:64] 
dst[127:96] := a[95:64]
dst[159:128] := a[159:128] 
dst[191:160] := a[159:128] 
dst[223:192] := a[223:192] 
dst[255:224] := a[223:192]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDDUP - _mm256_movedup_pd

| VMOVDDUP_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Duplicate even-indexed double-precision (64-bit) floating-point elements from "a", and store the results in
"dst".

[algorithm]

dst[63:0] := a[63:0]
dst[127:64] := a[63:0]
dst[191:128] := a[191:128]
dst[255:192] := a[191:128]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VLDDQU - _mm256_lddqu_si256

| VLDDQU_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load 256-bits of integer data from unaligned memory into "dst". This intrinsic may perform better than
"_mm256_loadu_si256" when the data crosses a cache line boundary.

[algorithm]

dst[255:0] := MEM[mem_addr+255:mem_addr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVNTDQ - _mm256_stream_si256

| VMOVNTDQ_MEMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store 256-bits of integer data from "a" into memory using a non-temporal memory hint.
	"mem_addr" must be
aligned on a 32-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+255:mem_addr] := a[255:0]

--------------------------------------------------------------------------------------------------------------

## VMOVNTPD - _mm256_stream_pd

| VMOVNTPD_MEMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store 256-bits (composed of 4 packed double-precision (64-bit) floating-point elements) from "a" into memory
using a non-temporal memory hint.
	"mem_addr" must be aligned on a 32-byte boundary or a general-protection
exception may be generated.

[algorithm]

MEM[mem_addr+255:mem_addr] := a[255:0]

--------------------------------------------------------------------------------------------------------------

## VMOVNTPS - _mm256_stream_ps

| VMOVNTPS_MEMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store 256-bits (composed of 8 packed single-precision (32-bit) floating-point elements) from "a" into memory
using a non-temporal memory hint.
	"mem_addr" must be aligned on a 32-byte boundary or a general-protection
exception may be generated.

[algorithm]

MEM[mem_addr+255:mem_addr] := a[255:0]

--------------------------------------------------------------------------------------------------------------

## VRCPPS - _mm256_rcp_ps

| VRCPPS_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the approximate reciprocal of packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst". The maximum relative error for this approximation is less than 1.5*2^-12.

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := 1.0 / a[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VRSQRTPS - _mm256_rsqrt_ps

| VRSQRTPS_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the approximate reciprocal square root of packed single-precision (32-bit) floating-point elements in
"a", and store the results in "dst". The maximum relative error for this approximation is less than 1.5*2^-12.

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := (1.0 / SQRT(a[i+31:i]))
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VSQRTPD - _mm256_sqrt_pd

| VSQRTPD_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := SQRT(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VSQRTPS - _mm256_sqrt_ps

| VSQRTPS_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := SQRT(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VROUNDPD - _mm256_round_pd

| VROUNDPD_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" using the "rounding" parameter, and
store the results as packed double-precision floating-point elements in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ROUND(a[i+63:i], rounding)
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VROUNDPS - _mm256_round_ps

| VROUNDPS_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" using the "rounding" parameter, and
store the results as packed single-precision floating-point elements in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ROUND(a[i+31:i], rounding)
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VUNPCKHPD - _mm256_unpackhi_pd

| VUNPCKHPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave double-precision (64-bit) floating-point elements from the high half of each 128-bit
lane in "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_QWORDS(src1[127:0], src2[127:0]) {
    dst[63:0] := src1[127:64] 
    dst[127:64] := src2[127:64] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_HIGH_QWORDS(a[127:0], b[127:0])
dst[255:128] := INTERLEAVE_HIGH_QWORDS(a[255:128], b[255:128])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VUNPCKHPS - _mm256_unpackhi_ps

| VUNPCKHPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave single-precision (32-bit) floating-point elements from the high half of each 128-bit
lane in "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_DWORDS(src1[127:0], src2[127:0]) {
    dst[31:0] := src1[95:64] 
    dst[63:32] := src2[95:64] 
    dst[95:64] := src1[127:96] 
    dst[127:96] := src2[127:96] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_HIGH_DWORDS(a[127:0], b[127:0])
dst[255:128] := INTERLEAVE_HIGH_DWORDS(a[255:128], b[255:128])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VUNPCKLPD - _mm256_unpacklo_pd

| VUNPCKLPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave double-precision (64-bit) floating-point elements from the low half of each 128-bit lane
in "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_QWORDS(src1[127:0], src2[127:0]) {
    dst[63:0] := src1[63:0] 
    dst[127:64] := src2[63:0] 
    RETURN dst[127:0]
}
dst[127:0] := INTERLEAVE_QWORDS(a[127:0], b[127:0])
dst[255:128] := INTERLEAVE_QWORDS(a[255:128], b[255:128])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VUNPCKLPS - _mm256_unpacklo_ps

| VUNPCKLPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave single-precision (32-bit) floating-point elements from the low half of each 128-bit lane
in "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_DWORDS(src1[127:0], src2[127:0]) {
    dst[31:0] := src1[31:0] 
    dst[63:32] := src2[31:0] 
    dst[95:64] := src1[63:32] 
    dst[127:96] := src2[63:32] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_DWORDS(a[127:0], b[127:0])
dst[255:128] := INTERLEAVE_DWORDS(a[255:128], b[255:128])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPTEST - _mm256_testz_si256

| VPTEST_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the
result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to
1 if the result is zero, otherwise set "CF" to 0. Return the "ZF" value.

[algorithm]

IF ((a[255:0] AND b[255:0]) == 0)
    ZF := 1
ELSE
    ZF := 0
FI
IF (((NOT a[255:0]) AND b[255:0]) == 0)
    CF := 1
ELSE
    CF := 0
FI
RETURN ZF

--------------------------------------------------------------------------------------------------------------

## VPTEST - _mm256_testc_si256

| VPTEST_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the
result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to
1 if the result is zero, otherwise set "CF" to 0. Return the "CF" value.

[algorithm]

IF ((a[255:0] AND b[255:0]) == 0)
    ZF := 1
ELSE
    ZF := 0
FI
IF (((NOT a[255:0]) AND b[255:0]) == 0)
    CF := 1
ELSE
    CF := 0
FI
RETURN CF

--------------------------------------------------------------------------------------------------------------

## VPTEST - _mm256_testnzc_si256

| VPTEST_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the
result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to
1 if the result is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise
return 0.

[algorithm]

IF ((a[255:0] AND b[255:0]) == 0)
    ZF := 1
ELSE
    ZF := 0
FI
IF (((NOT a[255:0]) AND b[255:0]) == 0)
    CF := 1
ELSE
    CF := 0
FI
IF (ZF == 0 &amp;&amp; CF == 0)
    dst := 1
ELSE
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## VTESTPD - _mm256_testz_pd

| VTESTPD_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing double-precision (64-bit) floating-point elements) in "a"
and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return the "ZF" value.

[algorithm]

tmp[255:0] := a[255:0] AND b[255:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[255] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[255:0] := (NOT a[255:0]) AND b[255:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[255] == 0)
    CF := 1
ELSE
    CF := 0
FI
dst := ZF

--------------------------------------------------------------------------------------------------------------

## VTESTPD - _mm256_testc_pd

| VTESTPD_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing double-precision (64-bit) floating-point elements) in "a"
and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return the "CF" value.

[algorithm]

tmp[255:0] := a[255:0] AND b[255:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[255] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[255:0] := (NOT a[255:0]) AND b[255:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[255] == 0)
    CF := 1
ELSE
    CF := 0
FI
dst := CF

--------------------------------------------------------------------------------------------------------------

## VTESTPD - _mm256_testnzc_pd

| VTESTPD_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing double-precision (64-bit) floating-point elements) in "a"
and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.

[algorithm]

tmp[255:0] := a[255:0] AND b[255:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[255] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[255:0] := (NOT a[255:0]) AND b[255:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[255] == 0)
    CF := 1
ELSE
    CF := 0
FI
IF (ZF == 0 &amp;&amp; CF == 0)
    dst := 1
ELSE
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## VTESTPD - _mm_testz_pd

| VTESTPD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing double-precision (64-bit) floating-point elements) in "a"
and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return the "ZF" value.

[algorithm]

tmp[127:0] := a[127:0] AND b[127:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[127:0] := (NOT a[127:0]) AND b[127:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0)
    CF := 1
ELSE
    CF := 0
FI
dst := ZF

--------------------------------------------------------------------------------------------------------------

## VTESTPD - _mm_testc_pd

| VTESTPD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing double-precision (64-bit) floating-point elements) in "a"
and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return the "CF" value.

[algorithm]

tmp[127:0] := a[127:0] AND b[127:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[127:0] := (NOT a[127:0]) AND b[127:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0)
    CF := 1
ELSE
    CF := 0
FI
dst := CF

--------------------------------------------------------------------------------------------------------------

## VTESTPD - _mm_testnzc_pd

| VTESTPD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing double-precision (64-bit) floating-point elements) in "a"
and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 64-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 64-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.

[algorithm]

tmp[127:0] := a[127:0] AND b[127:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[127:0] := (NOT a[127:0]) AND b[127:0]
IF (tmp[63] == 0 &amp;&amp; tmp[127] == 0)
    CF := 1
ELSE
    CF := 0
FI
IF (ZF == 0 &amp;&amp; CF == 0)
    dst := 1
ELSE
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## VTESTPS - _mm256_testz_ps

| VTESTPS_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing single-precision (32-bit) floating-point elements) in "a"
and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return the "ZF" value.

[algorithm]

tmp[255:0] := a[255:0] AND b[255:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; \
    tmp[159] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[223] == 0 &amp;&amp; tmp[255] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[255:0] := (NOT a[255:0]) AND b[255:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; \
    tmp[159] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[223] == 0 &amp;&amp; tmp[255] == 0)
    CF := 1
ELSE
    CF := 0
FI
dst := ZF

--------------------------------------------------------------------------------------------------------------

## VTESTPS - _mm256_testc_ps

| VTESTPS_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing single-precision (32-bit) floating-point elements) in "a"
and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return the "CF" value.

[algorithm]

tmp[255:0] := a[255:0] AND b[255:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; \
    tmp[159] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[223] == 0 &amp;&amp; tmp[255] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[255:0] := (NOT a[255:0]) AND b[255:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; \
    tmp[159] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[223] == 0 &amp;&amp; tmp[255] == 0)
    CF := 1
ELSE
    CF := 0
FI
dst := CF

--------------------------------------------------------------------------------------------------------------

## VTESTPS - _mm256_testnzc_ps

| VTESTPS_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing single-precision (32-bit) floating-point elements) in "a"
and "b", producing an intermediate 256-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.

[algorithm]

tmp[255:0] := a[255:0] AND b[255:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; \
    tmp[159] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[223] == 0 &amp;&amp; tmp[255] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[255:0] := (NOT a[255:0]) AND b[255:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0 &amp;&amp; \
    tmp[159] == 0 &amp;&amp; tmp[191] == 0 &amp;&amp; tmp[223] == 0 &amp;&amp; tmp[255] == 0)
    CF := 1
ELSE
    CF := 0
FI
IF (ZF == 0 &amp;&amp; CF == 0)
    dst := 1
ELSE
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## VTESTPS - _mm_testz_ps

| VTESTPS_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing single-precision (32-bit) floating-point elements) in "a"
and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return the "ZF" value.

[algorithm]

tmp[127:0] := a[127:0] AND b[127:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[127:0] := (NOT a[127:0]) AND b[127:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0)
    CF := 1
ELSE
    CF := 0
FI
dst := ZF

--------------------------------------------------------------------------------------------------------------

## VTESTPS - _mm_testc_ps

| VTESTPS_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing single-precision (32-bit) floating-point elements) in "a"
and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return the "CF" value.

[algorithm]

tmp[127:0] := a[127:0] AND b[127:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[127:0] := (NOT a[127:0]) AND b[127:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0)
    CF := 1
ELSE
    CF := 0
FI
dst := CF

--------------------------------------------------------------------------------------------------------------

## VTESTPS - _mm_testnzc_ps

| VTESTPS_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing single-precision (32-bit) floating-point elements) in "a"
and "b", producing an intermediate 128-bit value, and set "ZF" to 1 if the sign bit of each 32-bit element in
the intermediate value is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b",
producing an intermediate value, and set "CF" to 1 if the sign bit of each 32-bit element in the intermediate
value is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise return 0.

[algorithm]

tmp[127:0] := a[127:0] AND b[127:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0)
    ZF := 1
ELSE
    ZF := 0
FI
tmp[127:0] := (NOT a[127:0]) AND b[127:0]
IF (tmp[31] == 0 &amp;&amp; tmp[63] == 0 &amp;&amp; tmp[95] == 0 &amp;&amp; tmp[127] == 0)
    CF := 1
ELSE
    CF := 0
FI
IF (ZF == 0 &amp;&amp; CF == 0)
    dst := 1
ELSE
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## VMOVMSKPD - _mm256_movemask_pd

| VMOVMSKPD_GPR32d_YMMqq

--------------------------------------------------------------------------------------------------------------
Set each bit of mask "dst" based on the most significant bit of the corresponding packed double-precision
(64-bit) floating-point element in "a".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF a[i+63]
        dst[j] := 1
    ELSE
        dst[j] := 0
    FI
ENDFOR
dst[MAX:4] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVMSKPS - _mm256_movemask_ps

| VMOVMSKPS_GPR32d_YMMqq

--------------------------------------------------------------------------------------------------------------
Set each bit of mask "dst" based on the most significant bit of the corresponding packed single-precision
(32-bit) floating-point element in "a".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF a[i+31]
        dst[j] := 1
    ELSE
        dst[j] := 0
    FI
ENDFOR
dst[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VXORPD - _mm256_setzero_pd

| VXORPD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Return vector of type __m256d with all elements set to zero.

[algorithm]

dst[MAX:0] := 0

--------------------------------------------------------------------------------------------------------------

## VXORPS - _mm256_setzero_ps

| VXORPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Return vector of type __m256 with all elements set to zero.

[algorithm]

dst[MAX:0] := 0

--------------------------------------------------------------------------------------------------------------

## VPXOR - _mm256_setzero_si256

| VPXOR_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Return vector of type __m256i with all elements set to zero.

[algorithm]

dst[MAX:0] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set_pd

--------------------------------------------------------------------------------------------------------------
Set packed double-precision (64-bit) floating-point elements in "dst" with the supplied values.

[algorithm]

dst[63:0] := e0
dst[127:64] := e1
dst[191:128] := e2
dst[255:192] := e3
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set_ps

--------------------------------------------------------------------------------------------------------------
Set packed single-precision (32-bit) floating-point elements in "dst" with the supplied values.

[algorithm]

dst[31:0] := e0
dst[63:32] := e1
dst[95:64] := e2
dst[127:96] := e3
dst[159:128] := e4
dst[191:160] := e5
dst[223:192] := e6
dst[255:224] := e7
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set_epi8

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
dst[135:128] := e16
dst[143:136] := e17
dst[151:144] := e18
dst[159:152] := e19
dst[167:160] := e20
dst[175:168] := e21
dst[183:176] := e22
dst[191:184] := e23
dst[199:192] := e24
dst[207:200] := e25
dst[215:208] := e26
dst[223:216] := e27
dst[231:224] := e28
dst[239:232] := e29
dst[247:240] := e30
dst[255:248] := e31
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set_epi16

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
dst[143:128] := e8
dst[159:144] := e9
dst[175:160] := e10
dst[191:176] := e11
dst[207:192] := e12
dst[223:208] := e13
dst[239:224] := e14
dst[255:240] := e15
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set_epi32

--------------------------------------------------------------------------------------------------------------
Set packed 32-bit integers in "dst" with the supplied values.

[algorithm]

dst[31:0] := e0
dst[63:32] := e1
dst[95:64] := e2
dst[127:96] := e3
dst[159:128] := e4
dst[191:160] := e5
dst[223:192] := e6
dst[255:224] := e7
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set_epi64x

--------------------------------------------------------------------------------------------------------------
Set packed 64-bit integers in "dst" with the supplied values.

[algorithm]

dst[63:0] := e0
dst[127:64] := e1
dst[191:128] := e2
dst[255:192] := e3
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_setr_pd

--------------------------------------------------------------------------------------------------------------
Set packed double-precision (64-bit) floating-point elements in "dst" with the supplied values in reverse
order.

[algorithm]

dst[63:0] := e3
dst[127:64] := e2
dst[191:128] := e1
dst[255:192] := e0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_setr_ps

--------------------------------------------------------------------------------------------------------------
Set packed single-precision (32-bit) floating-point elements in "dst" with the supplied values in reverse
order.

[algorithm]

dst[31:0] := e7
dst[63:32] := e6
dst[95:64] := e5
dst[127:96] := e4
dst[159:128] := e3
dst[191:160] := e2
dst[223:192] := e1
dst[255:224] := e0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_setr_epi8

--------------------------------------------------------------------------------------------------------------
Set packed 8-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[7:0] := e31
dst[15:8] := e30
dst[23:16] := e29
dst[31:24] := e28
dst[39:32] := e27
dst[47:40] := e26
dst[55:48] := e25
dst[63:56] := e24
dst[71:64] := e23
dst[79:72] := e22
dst[87:80] := e21
dst[95:88] := e20
dst[103:96] := e19
dst[111:104] := e18
dst[119:112] := e17
dst[127:120] := e16
dst[135:128] := e15
dst[143:136] := e14
dst[151:144] := e13
dst[159:152] := e12
dst[167:160] := e11
dst[175:168] := e10
dst[183:176] := e9
dst[191:184] := e8
dst[199:192] := e7
dst[207:200] := e6
dst[215:208] := e5
dst[223:216] := e4
dst[231:224] := e3
dst[239:232] := e2
dst[247:240] := e1
dst[255:248] := e0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_setr_epi16

--------------------------------------------------------------------------------------------------------------
Set packed 16-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[15:0] := e15
dst[31:16] := e14
dst[47:32] := e13
dst[63:48] := e12
dst[79:64] := e11
dst[95:80] := e10
dst[111:96] := e9
dst[127:112] := e8
dst[143:128] := e7
dst[159:144] := e6
dst[175:160] := e5
dst[191:176] := e4
dst[207:192] := e3
dst[223:208] := e2
dst[239:224] := e1
dst[255:240] := e0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_setr_epi32

--------------------------------------------------------------------------------------------------------------
Set packed 32-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[31:0] := e7
dst[63:32] := e6
dst[95:64] := e5
dst[127:96] := e4
dst[159:128] := e3
dst[191:160] := e2
dst[223:192] := e1
dst[255:224] := e0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_setr_epi64x

--------------------------------------------------------------------------------------------------------------
Set packed 64-bit integers in "dst" with the supplied values in reverse order.

[algorithm]

dst[63:0] := e3
dst[127:64] := e2
dst[191:128] := e1
dst[255:192] := e0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set1_pd

--------------------------------------------------------------------------------------------------------------
Broadcast double-precision (64-bit) floating-point value "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set1_ps

--------------------------------------------------------------------------------------------------------------
Broadcast single-precision (32-bit) floating-point value "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set1_epi8

--------------------------------------------------------------------------------------------------------------
Broadcast 8-bit integer "a" to all elements of "dst". This intrinsic may generate the "vpbroadcastb".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := a[7:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set1_epi16

--------------------------------------------------------------------------------------------------------------
Broadcast 16-bit integer "a" to all all elements of "dst". This intrinsic may generate the "vpbroadcastw".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := a[15:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set1_epi32

--------------------------------------------------------------------------------------------------------------
Broadcast 32-bit integer "a" to all elements of "dst". This intrinsic may generate the "vpbroadcastd".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_set1_epi64x

--------------------------------------------------------------------------------------------------------------
Broadcast 64-bit integer "a" to all elements of "dst". This intrinsic may generate the "vpbroadcastq".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_castpd_ps

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m256d to type __m256.
	This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castps_pd

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m256 to type __m256d.
	This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castps_si256

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m256 to type __m256i. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castpd_si256

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m256d to type __m256i. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castsi256_ps

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m256i to type __m256. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castsi256_pd

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m256i to type __m256d. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castps256_ps128

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m256 to type __m128. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castpd256_pd128

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m256d to type __m128d. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castsi256_si128

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m256i to type __m128i. This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castps128_ps256

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128 to type __m256; the upper 128 bits of the result are undefined. This intrinsic is
only used for compilation and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castpd128_pd256

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128d to type __m256d; the upper 128 bits of the result are undefined. This intrinsic is
only used for compilation and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_castsi128_si256

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128i to type __m256i; the upper 128 bits of the result are undefined. This intrinsic is
only used for compilation and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_zextps128_ps256

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128 to type __m256; the upper 128 bits of the result are zeroed. This intrinsic is only
used for compilation and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_zextpd128_pd256

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128d to type __m256d; the upper 128 bits of the result are zeroed. This intrinsic is
only used for compilation and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_zextsi128_si256

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m128i to type __m256i; the upper 128 bits of the result are zeroed. This intrinsic is
only used for compilation and does not generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## VROUNDPS - _mm256_floor_ps

| VROUNDPS_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" down to an integer value, and store
the results as packed single-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := FLOOR(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VROUNDPS - _mm256_ceil_ps

| VROUNDPS_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" up to an integer value, and store
the results as packed single-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := CEIL(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VROUNDPD - _mm256_floor_pd

| VROUNDPD_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" down to an integer value, and store
the results as packed double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := FLOOR(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VROUNDPD - _mm256_ceil_pd

| VROUNDPD_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" up to an integer value, and store
the results as packed double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := CEIL(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_undefined_ps

--------------------------------------------------------------------------------------------------------------
Return vector of type __m256 with undefined elements.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_undefined_pd

--------------------------------------------------------------------------------------------------------------
Return vector of type __m256d with undefined elements.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm256_undefined_si256

--------------------------------------------------------------------------------------------------------------
Return vector of type __m256i with undefined elements.

[missing]

--------------------------------------------------------------------------------------------------------------

## VINSERTF128 - _mm256_set_m128

| VINSERTF128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Set packed __m256 vector "dst" with the supplied values.

[algorithm]

dst[127:0] := lo[127:0]
dst[255:128] := hi[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VINSERTF128 - _mm256_set_m128d

| VINSERTF128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Set packed __m256d vector "dst" with the supplied values.

[algorithm]

dst[127:0] := lo[127:0]
dst[255:128] := hi[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VINSERTF128 - _mm256_set_m128i

| VINSERTF128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Set packed __m256i vector "dst" with the supplied values.

[algorithm]

dst[127:0] := lo[127:0]
dst[255:128] := hi[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VINSERTF128 - _mm256_setr_m128

| VINSERTF128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Set packed __m256 vector "dst" with the supplied values.

[algorithm]

dst[127:0] := lo[127:0]
dst[255:128] := hi[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VINSERTF128 - _mm256_setr_m128d

| VINSERTF128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Set packed __m256d vector "dst" with the supplied values.

[algorithm]

dst[127:0] := lo[127:0]
dst[255:128] := hi[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VINSERTF128 - _mm256_setr_m128i

| VINSERTF128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Set packed __m256i vector "dst" with the supplied values.

[algorithm]

dst[127:0] := lo[127:0]
dst[255:128] := hi[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_loadu2_m128

--------------------------------------------------------------------------------------------------------------
Load two 128-bit values (composed of 4 packed single-precision (32-bit) floating-point elements) from memory,
and combine them into a 256-bit value in "dst".
	"hiaddr" and "loaddr" do not need to be aligned on any
particular boundary.

[algorithm]

dst[127:0] := MEM[loaddr+127:loaddr]
dst[255:128] := MEM[hiaddr+127:hiaddr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_loadu2_m128d

--------------------------------------------------------------------------------------------------------------
Load two 128-bit values (composed of 2 packed double-precision (64-bit) floating-point elements) from memory,
and combine them into a 256-bit value in "dst".
	"hiaddr" and "loaddr" do not need to be aligned on any
particular boundary.

[algorithm]

dst[127:0] := MEM[loaddr+127:loaddr]
dst[255:128] := MEM[hiaddr+127:hiaddr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_loadu2_m128i

--------------------------------------------------------------------------------------------------------------
Load two 128-bit values (composed of integer data) from memory, and combine them into a 256-bit value in
"dst".
	"hiaddr" and "loaddr" do not need to be aligned on any particular boundary.

[algorithm]

dst[127:0] := MEM[loaddr+127:loaddr]
dst[255:128] := MEM[hiaddr+127:hiaddr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_storeu2_m128

--------------------------------------------------------------------------------------------------------------
Store the high and low 128-bit halves (each composed of 4 packed single-precision (32-bit) floating-point
elements) from "a" into memory two different 128-bit locations.
	"hiaddr" and "loaddr" do not need to be
aligned on any particular boundary.

[algorithm]

MEM[loaddr+127:loaddr] := a[127:0]
MEM[hiaddr+127:hiaddr] := a[255:128]

--------------------------------------------------------------------------------------------------------------

## _mm256_storeu2_m128d

--------------------------------------------------------------------------------------------------------------
Store the high and low 128-bit halves (each composed of 2 packed double-precision (64-bit) floating-point
elements) from "a" into memory two different 128-bit locations.
	"hiaddr" and "loaddr" do not need to be
aligned on any particular boundary.

[algorithm]

MEM[loaddr+127:loaddr] := a[127:0]
MEM[hiaddr+127:hiaddr] := a[255:128]

--------------------------------------------------------------------------------------------------------------

## _mm256_storeu2_m128i

--------------------------------------------------------------------------------------------------------------
Store the high and low 128-bit halves (each composed of integer data) from "a" into memory two different
128-bit locations.
	"hiaddr" and "loaddr" do not need to be aligned on any particular boundary.

[algorithm]

MEM[loaddr+127:loaddr] := a[127:0]
MEM[hiaddr+127:hiaddr] := a[255:128]

--------------------------------------------------------------------------------------------------------------

## VMOVSS - _mm256_cvtss_f32

| VMOVSS_MEMd_XMMd

--------------------------------------------------------------------------------------------------------------
Copy the lower single-precision (32-bit) floating-point element of "a" to "dst".

[algorithm]

dst[31:0] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## VMOVSD - _mm256_cvtsd_f64

| VMOVSD_MEMq_XMMq

--------------------------------------------------------------------------------------------------------------
Copy the lower double-precision (64-bit) floating-point element of "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## VMOVD - _mm256_cvtsi256_si32

| VMOVD_GPR32d_XMMd

--------------------------------------------------------------------------------------------------------------
Copy the lower 32-bit integer in "a" to "dst".

[algorithm]

dst[31:0] := a[31:0]

--------------------------------------------------------------------------------------------------------------
