# _AVX-512-KNC

## VADDPD - _mm512_add_pd

| VADDPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := a[i+63:i] + b[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDPD - _mm512_add_round_pd

| VADDPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in
"dst".
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := a[i+63:i] + b[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDPD - _mm512_mask_add_pd

| VADDPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i] + b[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDPD - _mm512_mask_add_round_pd

| VADDPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). 
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i] + b[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDPS - _mm512_add_ps

| VADDPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] + b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDPS - _mm512_add_round_ps

| VADDPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in
"dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] + b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDPS - _mm512_mask_add_ps

| VADDPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] + b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDPS - _mm512_mask_add_round_ps

| VADDPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). 
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] + b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VALIGND - _mm512_alignr_epi32

| VALIGND_ZMMu32_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Concatenate "a" and "b" into a 128-byte immediate result, shift the result right by "imm8" 32-bit elements,
and store the low 64 bytes (16 elements) in "dst".

[algorithm]

temp[1023:512] := a[511:0]
temp[511:0] := b[511:0]
temp[1023:0] := temp[1023:0] &gt;&gt; (32*imm8[3:0])
dst[511:0] := temp[511:0]
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VALIGND - _mm512_mask_alignr_epi32

| VALIGND_ZMMu32_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Concatenate "a" and "b" into a 128-byte immediate result, shift the result right by "imm8" 32-bit elements,
and store the low 64 bytes (16 elements) in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

temp[1023:512] := a[511:0]
temp[511:0] := b[511:0]
temp[1023:0] := temp[1023:0] &gt;&gt; (32*imm8[3:0])
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := temp[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VBLENDMPD - _mm512_mask_blend_pd

| VBLENDMPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Blend packed double-precision (64-bit) floating-point elements from "a" and "b" using control mask "k", and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := b[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VBLENDMPS - _mm512_mask_blend_ps

| VBLENDMPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Blend packed single-precision (32-bit) floating-point elements from "a" and "b" using control mask "k", and
store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := b[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmp_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in mask vector "k".

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
    i := j*64
    k[j] := (a[i+63:i] OP b[i+63:i]) ? 1 : 0
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmp_round_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in mask vector "k". [sae_note]

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
    i := j*64
    k[j] := (a[i+63:i] OP b[i+63:i]) ? 1 : 0
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmpeq_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for equality, and store the
results in mask vector "k".

[algorithm]

FOR j := 0 to 7
    i := j*64
    k[j] := (a[i+63:i] == b[i+63:i]) ? 1 : 0
ENDFOR    
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmple_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for less-than-or-equal, and
store the results in mask vector "k".

[algorithm]

FOR j := 0 to 7
    i := j*64
    k[j] := (a[i+63:i] &lt;= b[i+63:i]) ? 1 : 0
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmplt_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for less-than, and store the
results in mask vector "k".

[algorithm]

FOR j := 0 to 7
    i := j*64
    k[j] := (a[i+63:i] &lt; b[i+63:i]) ? 1 : 0
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmpneq_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-equal, and store the
results in mask vector "k".

[algorithm]

FOR j := 0 to 7
    i := j*64
    k[j] := (a[i+63:i] != b[i+63:i]) ? 1 : 0
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmpnle_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than-or-equal,
and store the results in mask vector "k".

[algorithm]

FOR j := 0 to 7
    i := j*64
    k[j] := (!(a[i+63:i] &lt;= b[i+63:i])) ? 1 : 0
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmpnlt_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than, and store
the results in mask vector "k".

[algorithm]

FOR j := 0 to 7
    i := j*64
    k[j] := (!(a[i+63:i] &lt; b[i+63:i])) ? 1 : 0
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmpord_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" to see if neither is NaN, and
store the results in mask vector "k".

[algorithm]

FOR j := 0 to 7
    i := j*64
    k[j] := (a[i+63:i] != NaN AND b[i+63:i] != NaN) ? 1 : 0 
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_cmpunord_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" to see if either is NaN, and
store the results in mask vector "k".

[algorithm]

FOR j := 0 to 7
    i := j*64
    k[j] := (a[i+63:i] == NaN OR b[i+63:i] == NaN) ? 1 : 0 
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmp_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in mask vector "k" using zeromask "k1" (elements are zeroed
out when the corresponding mask bit is not set).

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
    i := j*64
    IF k1[j]
        k[j] := ( a[i+63:i] OP b[i+63:i] ) ? 1 : 0
    ELSE
        k[j] := 0
    FI
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmp_round_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in mask vector "k" using zeromask "k1" (elements are zeroed
out when the corresponding mask bit is not set). [sae_note]

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
    i := j*64
    IF k1[j]
        k[j] := ( a[i+63:i] OP b[i+63:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmpeq_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for equality, and store the
results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k1[j]
        k[j] := (a[i+63:i] == b[i+63:i]) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR    
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmple_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for less-than-or-equal, and
store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k1[j]
        k[j] := (a[i+63:i] &lt;= b[i+63:i]) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmplt_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for less-than, and store the
results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k1[j]
        k[j] := (a[i+63:i] &lt; b[i+63:i]) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmpneq_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-equal, and store the
results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k1[j]
        k[j] := (a[i+63:i] != b[i+63:i]) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmpnle_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than-or-equal,
and store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding
mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k1[j]
        k[j] := (!(a[i+63:i] &lt;= b[i+63:i])) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmpnlt_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than, and store
the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is
not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k1[j]
        k[j] := (!(a[i+63:i] &lt; b[i+63:i])) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmpord_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" to see if neither is NaN, and
store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k1[j]
        k[j] := (a[i+63:i] != NaN AND b[i+63:i] != NaN) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPD - _mm512_mask_cmpunord_pd_mask

| VCMPPD_MASKmskw_MASKmskw_ZMMf64_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" to see if either is NaN, and
store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k1[j]
        k[j] := (a[i+63:i] == NaN OR b[i+63:i] == NaN) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmp_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in mask vector "k".

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
FOR j := 0 to 15
    i := j*32
    k[j] := (a[i+31:i] OP b[i+31:i]) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmp_round_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in mask vector "k". [sae_note]

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
FOR j := 0 to 15
    i := j*32
    k[j] := (a[i+31:i] OP b[i+31:i]) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmpeq_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for equality, and store the
results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := (a[i+31:i] == b[i+31:i]) ? 1 : 0
ENDFOR    
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmple_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for less-than-or-equal, and
store the results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := (a[i+31:i] &lt;= b[i+31:i]) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmplt_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for less-than, and store the
results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := (a[i+31:i] &lt; b[i+31:i]) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmpneq_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-equal, and store the
results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := (a[i+31:i] != b[i+31:i]) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmpnle_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than-or-equal,
and store the results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := (!(a[i+31:i] &lt;= b[i+31:i])) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmpnlt_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than, and store
the results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := (!(a[i+31:i] &lt; b[i+31:i])) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmpord_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" to see if neither is NaN, and
store the results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ((a[i+31:i] != NaN) AND (b[i+31:i] != NaN)) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_cmpunord_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" to see if either is NaN, and
store the results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ((a[i+31:i] == NaN) OR (b[i+31:i] == NaN)) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmp_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in mask vector "k" using zeromask "k1" (elements are zeroed
out when the corresponding mask bit is not set).

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
FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] OP b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmp_round_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" based on the comparison
operand specified by "imm8", and store the results in mask vector "k" using zeromask "k1" (elements are zeroed
out when the corresponding mask bit is not set). [sae_note]

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
FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] OP b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmpeq_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for equality, and store the
results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := (a[i+31:i] == b[i+31:i]) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR        
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmple_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for less-than-or-equal, and
store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := (a[i+31:i] &lt;= b[i+31:i]) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmplt_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for less-than, and store the
results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := (a[i+31:i] &lt; b[i+31:i]) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmpneq_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-equal, and store the
results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := (a[i+31:i] != b[i+31:i]) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmpnle_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than-or-equal,
and store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding
mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := (!(a[i+31:i] &lt;= b[i+31:i])) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmpnlt_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than, and store
the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is
not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := (!(a[i+31:i] &lt; b[i+31:i])) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmpord_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" to see if neither is NaN, and
store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ((a[i+31:i] != NaN) AND (b[i+31:i] != NaN)) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VCMPPS - _mm512_mask_cmpunord_ps_mask

| VCMPPS_MASKmskw_MASKmskw_ZMMf32_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" to see if either is NaN, and
store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ((a[i+31:i] == NaN) OR (b[i+31:i] == NaN)) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PD - _mm512_fmadd_pd

| VFMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PD - _mm512_fmadd_round_pd

| VFMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst". 
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PD - _mm512_mask3_fmadd_pd

| VFMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from "c"
when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE
        dst[i+63:i] := c[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PD - _mm512_mask3_fmadd_round_pd

| VFMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from "c"
when the corresponding mask bit is not set). 
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE 
        dst[i+63:i] := c[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PD - _mm512_mask_fmadd_pd

| VFMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from "a"
when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PD - _mm512_mask_fmadd_round_pd

| VFMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from "a"
when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PS - _mm512_fmadd_ps

| VFMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PS - _mm512_fmadd_round_ps

| VFMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst". 
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PS - _mm512_mask3_fmadd_ps

| VFMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from "c"
when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := c[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PS - _mm512_mask3_fmadd_round_ps

| VFMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from "c"
when the corresponding mask bit is not set). 
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := c[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PS - _mm512_mask_fmadd_ps

| VFMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from "a"
when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PS - _mm512_mask_fmadd_round_ps

| VFMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from "a"
when the corresponding mask bit is not set). 
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PD - _mm512_fmsub_pd

| VFMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PD - _mm512_fmsub_round_pd

| VFMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst". 
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PD - _mm512_mask3_fmsub_pd

| VFMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst" using writemask "k" (elements are copied from
"c" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := c[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PD - _mm512_mask3_fmsub_round_pd

| VFMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst" using writemask "k" (elements are copied from
"c" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := c[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PD - _mm512_mask_fmsub_pd

| VFMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst" using writemask "k" (elements are copied from
"a" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PD - _mm512_mask_fmsub_round_pd

| VFMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst" using writemask "k" (elements are copied from
"a" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PS - _mm512_fmsub_ps

| VFMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PS - _mm512_fmsub_round_ps

| VFMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst". 
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PS - _mm512_mask3_fmsub_ps

| VFMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst" using writemask "k" (elements are copied from
"c" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := c[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PS - _mm512_mask3_fmsub_round_ps

| VFMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst" using writemask "k" (elements are copied from
"c" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := c[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PS - _mm512_mask_fmsub_ps

| VFMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst" using writemask "k" (elements are copied from
"a" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PS - _mm512_mask_fmsub_round_ps

| VFMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst" using writemask "k" (elements are copied from
"a" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PD - _mm512_fnmadd_pd

| VFNMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) + c[i+63:i]
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PD - _mm512_fnmadd_round_pd

| VFNMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst".
	 [round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) + c[i+63:i]
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PD - _mm512_mask3_fnmadd_pd

| VFNMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from
"c" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE
        dst[i+63:i] := c[i+63:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PD - _mm512_mask3_fnmadd_round_pd

| VFNMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from
"c" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE
        dst[i+63:i] := c[i+63:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PD - _mm512_mask_fnmadd_pd

| VFNMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from
"a" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PD - _mm512_mask_fnmadd_round_pd

| VFNMADD132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMADD231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from
"a" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PS - _mm512_fnmadd_ps

| VFNMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) + c[i+31:i]
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PS - _mm512_fnmadd_round_ps

| VFNMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst". 
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) + c[i+31:i]
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PS - _mm512_mask3_fnmadd_ps

| VFNMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from
"c" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := c[i+31:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PS - _mm512_mask3_fnmadd_round_ps

| VFNMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from
"c" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := c[i+31:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PS - _mm512_mask_fnmadd_ps

| VFNMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from
"a" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PS - _mm512_mask_fnmadd_round_ps

| VFNMADD132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMADD231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst" using writemask "k" (elements are copied from
"a" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PD - _mm512_fnmsub_pd

| VFNMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) - c[i+63:i]
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PD - _mm512_fnmsub_round_pd

| VFNMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst". 
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) - c[i+63:i]
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PD - _mm512_mask3_fnmsub_pd

| VFNMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst" using writemask "k" (elements are
copied from "c" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := c[i+63:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PD - _mm512_mask3_fnmsub_round_pd

| VFNMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst" using writemask "k" (elements are
copied from "c" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := c[i+63:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PD - _mm512_mask_fnmsub_pd

| VFNMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst" using writemask "k" (elements are
copied from "a" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PD - _mm512_mask_fnmsub_round_pd

| VFNMSUB132PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB213PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512 | VFNMSUB231PD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst" using writemask "k" (elements are
copied from "a" when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PS - _mm512_fnmsub_ps

| VFNMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) - c[i+31:i]
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PS - _mm512_fnmsub_round_ps

| VFNMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst". 
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) - c[i+31:i]
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PS - _mm512_mask3_fnmsub_ps

| VFNMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst" using writemask "k" (elements are
copied from "c" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := c[i+31:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PS - _mm512_mask3_fnmsub_round_ps

| VFNMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst" using writemask "k" (elements are
copied from "c" when the corresponding mask bit is not set). [round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := c[i+31:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PS - _mm512_mask_fnmsub_ps

| VFNMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst" using writemask "k" (elements are
copied from "a" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PS - _mm512_mask_fnmsub_round_ps

| VFNMSUB132PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB213PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512 | VFNMSUB231PS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst" using writemask "k" (elements are
copied from "a" when the corresponding mask bit is not set). 
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR    
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPS - _mm512_i32gather_ps

| VGATHERDPS_ZMMf32_MASKmskw_MEMf32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPS - _mm512_mask_i32gather_ps

| VGATHERDPS_ZMMf32_MASKmskw_MEMf32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETEXPPD - _mm512_getexp_pd

| VGETEXPPD_ZMMf64_MASKmskw_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed double-precision (64-bit) floating-point element in "a" to a
double-precision (64-bit) floating-point number representing the integer exponent, and store the results in
"dst". This intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ConvertExpFP64(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETEXPPD - _mm512_getexp_round_pd

| VGETEXPPD_ZMMf64_MASKmskw_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed double-precision (64-bit) floating-point element in "a" to a
double-precision (64-bit) floating-point number representing the integer exponent, and store the results in
"dst". This intrinsic essentially calculates "floor(log2(x))" for each element.
	[sae_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ConvertExpFP64(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETEXPPD - _mm512_mask_getexp_pd

| VGETEXPPD_ZMMf64_MASKmskw_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed double-precision (64-bit) floating-point element in "a" to a
double-precision (64-bit) floating-point number representing the integer exponent, and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). This
intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ConvertExpFP64(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETEXPPD - _mm512_mask_getexp_round_pd

| VGETEXPPD_ZMMf64_MASKmskw_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed double-precision (64-bit) floating-point element in "a" to a
double-precision (64-bit) floating-point number representing the integer exponent, and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). This
intrinsic essentially calculates "floor(log2(x))" for each element.
	[sae_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ConvertExpFP64(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETEXPPS - _mm512_getexp_ps

| VGETEXPPS_ZMMf32_MASKmskw_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed single-precision (32-bit) floating-point element in "a" to a
single-precision (32-bit) floating-point number representing the integer exponent, and store the results in
"dst". This intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ConvertExpFP32(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETEXPPS - _mm512_getexp_round_ps

| VGETEXPPS_ZMMf32_MASKmskw_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed single-precision (32-bit) floating-point element in "a" to a
single-precision (32-bit) floating-point number representing the integer exponent, and store the results in
"dst". This intrinsic essentially calculates "floor(log2(x))" for each element.
	[sae_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ConvertExpFP32(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETEXPPS - _mm512_mask_getexp_ps

| VGETEXPPS_ZMMf32_MASKmskw_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed single-precision (32-bit) floating-point element in "a" to a
single-precision (32-bit) floating-point number representing the integer exponent, and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). This
intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ConvertExpFP32(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETEXPPS - _mm512_mask_getexp_round_ps

| VGETEXPPS_ZMMf32_MASKmskw_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed single-precision (32-bit) floating-point element in "a" to a
single-precision (32-bit) floating-point number representing the integer exponent, and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). This
intrinsic essentially calculates "floor(log2(x))" for each element.
	[sae_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ConvertExpFP32(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETMANTPD - _mm512_getmant_pd

| VGETMANTPD_ZMMf64_MASKmskw_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Normalize the mantissas of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst". This intrinsic essentially calculates "±(2^k)*|x.significand|", where "k" depends on the
interval range defined by "interv" and the sign depends on "sc" and the source sign.
	[getmant_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := GetNormalizedMantissa(a[i+63:i], sc, interv)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETMANTPD - _mm512_getmant_round_pd

| VGETMANTPD_ZMMf64_MASKmskw_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Normalize the mantissas of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst". This intrinsic essentially calculates "±(2^k)*|x.significand|", where "k" depends on the
interval range defined by "interv" and the sign depends on "sc" and the source sign.
	[getmant_note][sae_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := GetNormalizedMantissa(a[i+63:i], sc, interv)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETMANTPD - _mm512_mask_getmant_pd

| VGETMANTPD_ZMMf64_MASKmskw_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Normalize the mantissas of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set). This intrinsic essentially calculates "±(2^k)*|x.significand|", where "k" depends on the interval range
defined by "interv" and the sign depends on "sc" and the source sign.
	[getmant_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := GetNormalizedMantissa(a[i+63:i], sc, interv)
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETMANTPD - _mm512_mask_getmant_round_pd

| VGETMANTPD_ZMMf64_MASKmskw_ZMMf64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Normalize the mantissas of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set). This intrinsic essentially calculates "±(2^k)*|x.significand|", where "k" depends on the interval range
defined by "interv" and the sign depends on "sc" and the source sign.
	[getmant_note][sae_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := GetNormalizedMantissa(a[i+63:i], sc, interv)
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETMANTPS - _mm512_getmant_ps

| VGETMANTPS_ZMMf32_MASKmskw_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Normalize the mantissas of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst". This intrinsic essentially calculates "±(2^k)*|x.significand|", where "k" depends on the
interval range defined by "interv" and the sign depends on "sc" and the source sign.
	[getmant_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := GetNormalizedMantissa(a[i+31:i], sc, interv)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETMANTPS - _mm512_getmant_round_ps

| VGETMANTPS_ZMMf32_MASKmskw_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Normalize the mantissas of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst". This intrinsic essentially calculates "±(2^k)*|x.significand|", where "k" depends on the
interval range defined by "interv" and the sign depends on "sc" and the source sign.
	[getmant_note][sae_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := GetNormalizedMantissa(a[i+31:i], sc, interv)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETMANTPS - _mm512_mask_getmant_ps

| VGETMANTPS_ZMMf32_MASKmskw_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Normalize the mantissas of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set). This intrinsic essentially calculates "±(2^k)*|x.significand|", where "k" depends on the interval range
defined by "interv" and the sign depends on "sc" and the source sign.
	[getmant_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := GetNormalizedMantissa(a[i+31:i], sc, interv)
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGETMANTPS - _mm512_mask_getmant_round_ps

| VGETMANTPS_ZMMf32_MASKmskw_ZMMf32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Normalize the mantissas of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set). This intrinsic essentially calculates "±(2^k)*|x.significand|", where "k" depends on the interval range
defined by "interv" and the sign depends on "sc" and the source sign.
	[getmant_note][sae_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := GetNormalizedMantissa(a[i+31:i], sc, interv)
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm512_load_pd

| VMOVAPD_ZMMf64_MASKmskw_MEMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Load 512-bits (composed of 8 packed double-precision (64-bit) floating-point elements) from memory into "dst".
"mem_addr" must be aligned on a 64-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[511:0] := MEM[mem_addr+511:mem_addr]
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm512_mask_load_pd

| VMOVAPD_ZMMf64_MASKmskw_MEMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Load packed double-precision (64-bit) floating-point elements from memory into "dst" using writemask "k"
(elements are copied from "src" when the corresponding mask bit is not set). "mem_addr" must be aligned on a
64-byte boundary or a general-protection exception may be generated.

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := MEM[mem_addr+i+63:mem_addr+i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm512_mask_mov_pd

| VMOVAPD_ZMMf64_MASKmskw_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Move packed double-precision (64-bit) floating-point elements from "a" to "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm512_mask_store_pd

| VMOVAPD_MEMf64_MASKmskw_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Store packed double-precision (64-bit) floating-point elements from "a" into memory using writemask
"k".
	"mem_addr" must be aligned on a 64-byte boundary or a general-protection exception may be generated.

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        MEM[mem_addr+i+63:mem_addr+i] := a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm512_store_pd

| VMOVAPD_MEMf64_MASKmskw_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Store 512-bits (composed of 8 packed double-precision (64-bit) floating-point elements) from "a" into
memory.
	"mem_addr" must be aligned on a 64-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+511:mem_addr] := a[511:0]

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm512_load_ps

| VMOVAPS_ZMMf32_MASKmskw_MEMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Load 512-bits (composed of 16 packed single-precision (32-bit) floating-point elements) from memory into
"dst". 
	"mem_addr" must be aligned on a 64-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[511:0] := MEM[mem_addr+511:mem_addr]
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm512_mask_load_ps

| VMOVAPS_ZMMf32_MASKmskw_MEMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Load packed single-precision (32-bit) floating-point elements from memory into "dst" using writemask "k"
(elements are copied from "src" when the corresponding mask bit is not set). "mem_addr" must be aligned on a
64-byte boundary or a general-protection exception may be generated.

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := MEM[mem_addr+i+31:mem_addr+i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm512_mask_mov_ps

| VMOVAPS_ZMMf32_MASKmskw_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Move packed single-precision (32-bit) floating-point elements from "a" to "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm512_mask_store_ps

| VMOVAPS_MEMf32_MASKmskw_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Store packed single-precision (32-bit) floating-point elements from "a" into memory using writemask
"k".
	"mem_addr" must be aligned on a 64-byte boundary or a general-protection exception may be generated.

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        MEM[mem_addr+i+31:mem_addr+i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm512_store_ps

| VMOVAPS_MEMf32_MASKmskw_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Store 512-bits (composed of 16 packed single-precision (32-bit) floating-point elements) from "a" into memory.
"mem_addr" must be aligned on a 64-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+511:mem_addr] := a[511:0]

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_load_epi32

| VMOVDQA32_ZMMu32_MASKmskw_MEMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Load 512-bits (composed of 16 packed 32-bit integers) from memory into "dst". 
	"mem_addr" must be aligned on
a 64-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[511:0] := MEM[mem_addr+511:mem_addr]
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_load_si512

| VMOVDQA32_ZMMu32_MASKmskw_MEMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Load 512-bits of integer data from memory into "dst". 
	"mem_addr" must be aligned on a 64-byte boundary or a
general-protection exception may be generated.

[algorithm]

dst[511:0] := MEM[mem_addr+511:mem_addr]
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_mask_load_epi32

| VMOVDQA32_ZMMu32_MASKmskw_MEMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Load packed 32-bit integers from memory into "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).
	"mem_addr" must be aligned on a 64-byte boundary or a
general-protection exception may be generated.

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := MEM[mem_addr+i+31:mem_addr+i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_mask_mov_epi32

| VMOVDQA32_ZMMu32_MASKmskw_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Move packed 32-bit integers from "a" to "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_mask_store_epi32

| VMOVDQA32_MEMu32_MASKmskw_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Store packed 32-bit integers from "a" into memory using writemask "k".
	"mem_addr" must be aligned on a
64-byte boundary or a general-protection exception may be generated.

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        MEM[mem_addr+i+31:mem_addr+i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_store_epi32

| VMOVDQA32_MEMu32_MASKmskw_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Store 512-bits (composed of 16 packed 32-bit integers) from "a" into memory. 
	"mem_addr" must be aligned on a
64-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+511:mem_addr] := a[511:0]

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_store_si512

| VMOVDQA32_MEMu32_MASKmskw_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Store 512-bits of integer data from "a" into memory. 
	"mem_addr" must be aligned on a 64-byte boundary or a
general-protection exception may be generated.

[algorithm]

MEM[mem_addr+511:mem_addr] := a[511:0]

--------------------------------------------------------------------------------------------------------------

## VMOVDQA64 - _mm512_load_epi64

| VMOVDQA64_ZMMu64_MASKmskw_MEMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Load 512-bits (composed of 8 packed 64-bit integers) from memory into "dst". 
	"mem_addr" must be aligned on a
64-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[511:0] := MEM[mem_addr+511:mem_addr]
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA64 - _mm512_mask_load_epi64

| VMOVDQA64_ZMMu64_MASKmskw_MEMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Load packed 64-bit integers from memory into "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set). 
	"mem_addr" must be aligned on a 64-byte boundary or a
general-protection exception may be generated.

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := MEM[mem_addr+i+63:mem_addr+i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA64 - _mm512_mask_mov_epi64

| VMOVDQA64_ZMMu64_MASKmskw_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Move packed 64-bit integers from "a" to "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA64 - _mm512_mask_store_epi64

| VMOVDQA64_MEMu64_MASKmskw_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Store packed 64-bit integers from "a" into memory using writemask "k".
	"mem_addr" must be aligned on a
64-byte boundary or a general-protection exception may be generated.

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        MEM[mem_addr+i+63:mem_addr+i] := a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVDQA64 - _mm512_store_epi64

| VMOVDQA64_MEMu64_MASKmskw_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Store 512-bits (composed of 8 packed 64-bit integers) from "a" into memory. 
	"mem_addr" must be aligned on a
64-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+511:mem_addr] := a[511:0]

--------------------------------------------------------------------------------------------------------------

## VMULPD - _mm512_mask_mul_pd

| VMULPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). RM.

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i] * b[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMULPD - _mm512_mask_mul_round_pd

| VMULPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).
[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i] * b[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMULPD - _mm512_mul_pd

| VMULPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := a[i+63:i] * b[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMULPD - _mm512_mul_round_pd

| VMULPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in
"dst". 
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := a[i+63:i] * b[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMULPS - _mm512_mask_mul_ps

| VMULPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). RM.

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] * b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMULPS - _mm512_mask_mul_round_ps

| VMULPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).
[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] * b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMULPS - _mm512_mul_ps

| VMULPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] * b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMULPS - _mm512_mul_round_ps

| VMULPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in
"dst". 
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] * b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDD - _mm512_add_epi32

| VPADDD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed 32-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] + b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDD - _mm512_mask_add_epi32

| VPADDD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Add packed 32-bit integers in "a" and "b", and store the results in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] + b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDD - _mm512_and_epi32

| VPANDD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of packed 32-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] AND b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDD - _mm512_and_si512

| VPANDD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 512 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[511:0] := (a[511:0] AND b[511:0])
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDND - _mm512_andnot_epi32

| VPANDND_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of packed 32-bit integers in "a" and then AND with "b", and store the results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (NOT a[i+31:i]) AND b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDND - _mm512_andnot_si512

| VPANDND_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 512 bits (representing integer data) in "a" and then AND with "b", and store the
result in "dst".

[algorithm]

dst[511:0] := ((NOT a[511:0]) AND b[511:0])
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDND - _mm512_mask_andnot_epi32

| VPANDND_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of packed 32-bit integers in "a" and then AND with "b", and store the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ((NOT a[i+31:i]) AND b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDNQ - _mm512_andnot_epi64

| VPANDNQ_ZMMu64_MASKmskw_ZMMu64_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 512 bits (composed of packed 64-bit integers) in "a" and then AND with "b", and
store the results in "dst".

[algorithm]

dst[511:0] := ((NOT a[511:0]) AND b[511:0])
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDNQ - _mm512_mask_andnot_epi64

| VPANDNQ_ZMMu64_MASKmskw_ZMMu64_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of packed 64-bit integers in "a" and then AND with "b", and store the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ((NOT a[i+63:i]) AND b[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDQ - _mm512_and_epi64

| VPANDQ_ZMMu64_MASKmskw_ZMMu64_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 512 bits (composed of packed 64-bit integers) in "a" and "b", and store the results
in "dst".

[algorithm]

dst[511:0] := (a[511:0] AND b[511:0])
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDQ - _mm512_mask_and_epi64

| VPANDQ_ZMMu64_MASKmskw_ZMMu64_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of packed 64-bit integers in "a" and "b", and store the results in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i] AND b[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPBLENDMD - _mm512_mask_blend_epi32

| VPBLENDMD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Blend packed 32-bit integers from "a" and "b" using control mask "k", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := b[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPBLENDMQ - _mm512_mask_blend_epi64

| VPBLENDMQ_ZMMu64_MASKmskw_ZMMu64_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Blend packed 64-bit integers from "a" and "b" using control mask "k", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := b[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPD - _mm512_cmp_epi32_mask

| VPCMPD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" based on the comparison operand specified by "imm8", and
store the results in mask vector "k".

[algorithm]

CASE (imm8[2:0]) OF
0: OP := _MM_CMPINT_EQ
1: OP := _MM_CMPINT_LT
2: OP := _MM_CMPINT_LE
3: OP := _MM_CMPINT_FALSE
4: OP := _MM_CMPINT_NE
5: OP := _MM_CMPINT_NLT
6: OP := _MM_CMPINT_NLE
7: OP := _MM_CMPINT_TRUE
ESAC
FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] OP b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPEQD - _mm512_cmpeq_epi32_mask

| VPCMPEQD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed 32-bit integers in "a" and "b" for equality, and store the results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] == b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPD - _mm512_cmpge_epi32_mask

| VPCMPD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for greater-than-or-equal, and store the results in mask
vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] &gt;= b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPGTD - _mm512_cmpgt_epi32_mask

| VPCMPGTD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for greater-than, and store the results in mask vector
"k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] &gt; b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPD - _mm512_cmple_epi32_mask

| VPCMPD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for less-than-or-equal, and store the results in mask
vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] &lt;= b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPD - _mm512_cmpneq_epi32_mask

| VPCMPD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed 32-bit integers in "a" and "b" for not-equal, and store the results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] != b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPD - _mm512_mask_cmp_epi32_mask

| VPCMPD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" based on the comparison operand specified by "imm8", and
store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask
bit is not set).

[algorithm]

CASE (imm8[2:0]) OF
0: OP := _MM_CMPINT_EQ
1: OP := _MM_CMPINT_LT
2: OP := _MM_CMPINT_LE
3: OP := _MM_CMPINT_FALSE
4: OP := _MM_CMPINT_NE
5: OP := _MM_CMPINT_NLT
6: OP := _MM_CMPINT_NLE
7: OP := _MM_CMPINT_TRUE
ESAC
FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] OP b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPEQD - _mm512_mask_cmpeq_epi32_mask

| VPCMPEQD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed 32-bit integers in "a" and "b" for equality, and store the results in mask vector "k" using
zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] == b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPD - _mm512_mask_cmpge_epi32_mask

| VPCMPD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for greater-than-or-equal, and store the results in mask
vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] &gt;= b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPGTD - _mm512_mask_cmpgt_epi32_mask

| VPCMPGTD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for greater-than, and store the results in mask vector
"k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] &gt; b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPD - _mm512_mask_cmple_epi32_mask

| VPCMPD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for less-than, and store the results in mask vector "k"
using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] &lt;= b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPD - _mm512_mask_cmpneq_epi32_mask

| VPCMPD_MASKmskw_MASKmskw_ZMMi32_ZMMi32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed 32-bit integers in "a" and "b" for not-equal, and store the results in mask vector "k" using
zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] != b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_cmp_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" based on the comparison operand specified by "imm8",
and store the results in mask vector "k".

[algorithm]

CASE (imm8[2:0]) OF
0: OP := _MM_CMPINT_EQ
1: OP := _MM_CMPINT_LT
2: OP := _MM_CMPINT_LE
3: OP := _MM_CMPINT_FALSE
4: OP := _MM_CMPINT_NE
5: OP := _MM_CMPINT_NLT
6: OP := _MM_CMPINT_NLE
7: OP := _MM_CMPINT_TRUE
ESAC
FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] OP b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_cmpeq_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for equality, and store the results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] == b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_cmpge_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for greater-than-or-equal, and store the results in
mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] &gt;= b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_cmpgt_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for greater-than, and store the results in mask vector
"k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] &gt; b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_cmple_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for less-than-or-equal, and store the results in mask
vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] &lt;= b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_cmplt_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for less-than, and store the results in mask vector
"k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] &lt; b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_cmpneq_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for not-equal, and store the results in mask vector
"k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] != b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_mask_cmp_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" based on the comparison operand specified by "imm8",
and store the results in mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding
mask bit is not set).

[algorithm]

CASE (imm8[2:0]) OF
0: OP := _MM_CMPINT_EQ
1: OP := _MM_CMPINT_LT
2: OP := _MM_CMPINT_LE
3: OP := _MM_CMPINT_FALSE
4: OP := _MM_CMPINT_NE
5: OP := _MM_CMPINT_NLT
6: OP := _MM_CMPINT_NLE
7: OP := _MM_CMPINT_TRUE
ESAC
FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] OP b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_mask_cmpeq_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for equality, and store the results in mask vector "k"
using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] == b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_mask_cmpge_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for greater-than-or-equal, and store the results in
mask vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] &gt;= b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_mask_cmpgt_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for greater-than, and store the results in mask vector
"k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] &gt; b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_mask_cmple_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for less-than, and store the results in mask vector "k"
using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] &lt;= b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_mask_cmplt_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for less-than-or-equal, and store the results in mask
vector "k" using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] &lt; b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPUD - _mm512_mask_cmpneq_epu32_mask

| VPCMPUD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b" for not-equal, and store the results in mask vector "k"
using zeromask "k1" (elements are zeroed out when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ( a[i+31:i] != b[i+31:i] ) ? 1 : 0
    ELSE 
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMD - _mm512_mask_permutevar_epi32

| VPERMD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Shuffle 32-bit integers in "a" across lanes using the corresponding index in "idx", and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). Note
that this intrinsic shuffles across 128-bit lanes, unlike past intrinsics that use the "permutevar" name. This
intrinsic is identical to "_mm512_mask_permutexvar_epi32", and it is recommended that you use that intrinsic
name.

[algorithm]

FOR j := 0 to 15
    i := j*32
    id := idx[i+3:i]*32
    IF k[j]
        dst[i+31:i] := a[id+31:id]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMD - _mm512_permutevar_epi32

| VPERMD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Shuffle 32-bit integers in "a" across lanes using the corresponding index in "idx", and store the results in
"dst". Note that this intrinsic shuffles across 128-bit lanes, unlike past intrinsics that use the "permutevar"
name. This intrinsic is identical to "_mm512_permutexvar_epi32", and it is recommended that you use that
intrinsic name.

[algorithm]

FOR j := 0 to 15
    i := j*32
    id := idx[i+3:i]*32
    dst[i+31:i] := a[id+31:id]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDD - _mm512_i32gather_epi32

| VPGATHERDD_ZMMu32_MASKmskw_MEMu32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDD - _mm512_mask_i32gather_epi32

| VPGATHERDD_ZMMu32_MASKmskw_MEMu32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMAXSD - _mm512_mask_max_epi32

| VPMAXSD_ZMMi32_MASKmskw_ZMMi32_ZMMi32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b", and store packed maximum values in "dst" using writemask
"k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMAXSD - _mm512_max_epi32

| VPMAXSD_ZMMi32_MASKmskw_ZMMi32_ZMMi32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMAXUD - _mm512_mask_max_epu32

| VPMAXUD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b", and store packed maximum values in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMAXUD - _mm512_max_epu32

| VPMAXUD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINSD - _mm512_mask_min_epi32

| VPMINSD_ZMMi32_MASKmskw_ZMMi32_ZMMi32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b", and store packed minimum values in "dst" using writemask
"k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINSD - _mm512_min_epi32

| VPMINSD_ZMMi32_MASKmskw_ZMMi32_ZMMi32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINUD - _mm512_mask_min_epu32

| VPMINUD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b", and store packed minimum values in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINUD - _mm512_min_epu32

| VPMINUD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULLD - _mm512_mask_mullo_epi32

| VPMULLD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 32-bit integers in "a" and "b", producing intermediate 64-bit integers, and store the low
32 bits of the intermediate integers in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        tmp[63:0] := a[i+31:i] * b[i+31:i]
        dst[i+31:i] := tmp[31:0]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULLD - _mm512_mullo_epi32

| VPMULLD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 32-bit integers in "a" and "b", producing intermediate 64-bit integers, and store the low
32 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    tmp[63:0] := a[i+31:i] * b[i+31:i]
    dst[i+31:i] := tmp[31:0]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPORD - _mm512_mask_or_epi32

| VPORD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of packed 32-bit integers in "a" and "b", and store the results in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] OR b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPORD - _mm512_or_epi32

| VPORD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of packed 32-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] OR b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPORD - _mm512_or_si512

| VPORD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of 512 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[511:0] := (a[511:0] OR b[511:0])
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPORQ - _mm512_mask_or_epi64

| VPORQ_ZMMu64_MASKmskw_ZMMu64_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of packed 64-bit integers in "a" and "b", and store the results in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i] OR b[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPORQ - _mm512_or_epi64

| VPORQ_ZMMu64_MASKmskw_ZMMu64_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of packed 64-bit integers in "a" and "b", and store the resut in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := a[i+63:i] OR b[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSCATTERDD - _mm512_i32scatter_epi32

| VPSCATTERDD_MEMu32_MASKmskw_ZMMu32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Scatter 32-bit integers from "a" into memory using 32-bit indices. 32-bit elements are stored at addresses
starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in
"scale"). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    MEM[addr+31:addr] := a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPSCATTERDD - _mm512_mask_i32scatter_epi32

| VPSCATTERDD_MEMu32_MASKmskw_ZMMu32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Scatter 32-bit integers from "a" into memory using 32-bit indices. 32-bit elements are stored at addresses
starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in
"scale") subject to mask "k" (elements are not stored when the corresponding mask bit is not set). "scale"
should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        MEM[addr+31:addr] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPSHUFD - _mm512_mask_shuffle_epi32

| VPSHUFD_ZMMu32_MASKmskw_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Shuffle 32-bit integers in "a" within 128-bit lanes using the control in "imm8", and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

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
tmp_dst[31:0] := SELECT4(a[127:0], imm8[1:0])
tmp_dst[63:32] := SELECT4(a[127:0], imm8[3:2])
tmp_dst[95:64] := SELECT4(a[127:0], imm8[5:4])
tmp_dst[127:96] := SELECT4(a[127:0], imm8[7:6])
tmp_dst[159:128] := SELECT4(a[255:128], imm8[1:0])
tmp_dst[191:160] := SELECT4(a[255:128], imm8[3:2])
tmp_dst[223:192] := SELECT4(a[255:128], imm8[5:4])
tmp_dst[255:224] := SELECT4(a[255:128], imm8[7:6])
tmp_dst[287:256] := SELECT4(a[383:256], imm8[1:0])
tmp_dst[319:288] := SELECT4(a[383:256], imm8[3:2])
tmp_dst[351:320] := SELECT4(a[383:256], imm8[5:4])
tmp_dst[383:352] := SELECT4(a[383:256], imm8[7:6])
tmp_dst[415:384] := SELECT4(a[511:384], imm8[1:0])
tmp_dst[447:416] := SELECT4(a[511:384], imm8[3:2])
tmp_dst[479:448] := SELECT4(a[511:384], imm8[5:4])
tmp_dst[511:480] := SELECT4(a[511:384], imm8[7:6])
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := tmp_dst[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSHUFD - _mm512_shuffle_epi32

| VPSHUFD_ZMMu32_MASKmskw_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Shuffle 32-bit integers in "a" within 128-bit lanes using the control in "imm8", and store the results in
"dst".

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
dst[287:256] := SELECT4(a[383:256], imm8[1:0])
dst[319:288] := SELECT4(a[383:256], imm8[3:2])
dst[351:320] := SELECT4(a[383:256], imm8[5:4])
dst[383:352] := SELECT4(a[383:256], imm8[7:6])
dst[415:384] := SELECT4(a[511:384], imm8[1:0])
dst[447:416] := SELECT4(a[511:384], imm8[3:2])
dst[479:448] := SELECT4(a[511:384], imm8[5:4])
dst[511:480] := SELECT4(a[511:384], imm8[7:6])
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLD - _mm512_mask_slli_epi32

| VPSLLD_ZMMu32_MASKmskw_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        IF imm8[7:0] &gt; 31
            dst[i+31:i] := 0
        ELSE
            dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; imm8[7:0])
        FI
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLD - _mm512_slli_epi32

| VPSLLD_ZMMu32_MASKmskw_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLVD - _mm512_mask_sllv_epi32

| VPSLLVD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by the amount specified by the corresponding element in "count" while
shifting in zeros, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        IF count[i+31:i] &lt; 32
            dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; count[i+31:i])
        ELSE
            dst[i+31:i] := 0
        FI
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI    
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLVD - _mm512_sllv_epi32

| VPSLLVD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by the amount specified by the corresponding element in "count" while
shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF count[i+31:i] &lt; 32
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; count[i+31:i])
    ELSE
        dst[i+31:i] := 0
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAD - _mm512_mask_srai_epi32

| VPSRAD_ZMMu32_MASKmskw_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        IF imm8[7:0] &gt; 31
            dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
        ELSE
            dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
        FI
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAD - _mm512_srai_epi32

| VPSRAD_ZMMu32_MASKmskw_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
    ELSE
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAVD - _mm512_mask_srav_epi32

| VPSRAVD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in sign bits, and store the results in "dst" using writemask "k" (elements are copied from "src"
when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        IF count[i+31:i] &lt; 32
            dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; count[i+31:i])
        ELSE
            dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0)
        FI
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI    
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAVD - _mm512_srav_epi32

| VPSRAVD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in sign bits, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF count[i+31:i] &lt; 32
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; count[i+31:i])
    ELSE
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0)
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLD - _mm512_mask_srli_epi32

| VPSRLD_ZMMu32_MASKmskw_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        IF imm8[7:0] &gt; 31
            dst[i+31:i] := 0
        ELSE
            dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
        FI
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLD - _mm512_srli_epi32

| VPSRLD_ZMMu32_MASKmskw_ZMMu32_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLVD - _mm512_mask_srlv_epi32

| VPSRLVD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in zeros, and store the results in "dst" using writemask "k" (elements are copied from "src"
when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        IF count[i+31:i] &lt; 32
            dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; count[i+31:i])
        ELSE
            dst[i+31:i] := 0
        FI
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI    
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLVD - _mm512_srlv_epi32

| VPSRLVD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF count[i+31:i] &lt; 32
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; count[i+31:i])
    ELSE
        dst[i+31:i] := 0
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBD - _mm512_mask_sub_epi32

| VPSUBD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed 32-bit integers in "b" from packed 32-bit integers in "a", and store the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] - b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI    
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBD - _mm512_sub_epi32

| VPSUBD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed 32-bit integers in "b" from packed 32-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] - b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPTESTMD - _mm512_mask_test_epi32_mask

| VPTESTMD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of packed 32-bit integers in "a" and "b", producing intermediate 32-bit values, and
set the corresponding bit in result mask "k" (subject to writemask "k") if the intermediate value is non-zero.

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k[j] := ((a[i+31:i] AND b[i+31:i]) != 0) ? 1 : 0
    ELSE
        k[j] := 0
    FI
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPTESTMD - _mm512_test_epi32_mask

| VPTESTMD_MASKmskw_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of packed 32-bit integers in "a" and "b", producing intermediate 32-bit values, and
set the corresponding bit in result mask "k" if the intermediate value is non-zero.

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ((a[i+31:i] AND b[i+31:i]) != 0) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPXORD - _mm512_mask_xor_epi32

| VPXORD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of packed 32-bit integers in "a" and "b", and store the results in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] XOR b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPXORD - _mm512_xor_epi32

| VPXORD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of packed 32-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] XOR b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPXORD - _mm512_xor_si512

| VPXORD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of 512 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[511:0] := (a[511:0] XOR b[511:0])
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPXORQ - _mm512_mask_xor_epi64

| VPXORQ_ZMMu64_MASKmskw_ZMMu64_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of packed 64-bit integers in "a" and "b", and store the results in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i] XOR b[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPXORQ - _mm512_xor_epi64

| VPXORQ_ZMMu64_MASKmskw_ZMMu64_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of packed 64-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := a[i+63:i] XOR b[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSCATTERDPS - _mm512_i32scatter_ps

| VSCATTERDPS_MEMf32_MASKmskw_ZMMf32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Scatter single-precision (32-bit) floating-point elements from "a" into memory using 32-bit indices. 32-bit
elements are stored at addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each
index is scaled by the factor in "scale"). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    MEM[addr+31:addr] := a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VSCATTERDPS - _mm512_mask_i32scatter_ps

| VSCATTERDPS_MEMf32_MASKmskw_ZMMf32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Scatter single-precision (32-bit) floating-point elements from "a" into memory using 32-bit indices. 32-bit
elements are stored at addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each
index is scaled by the factor in "scale") subject to mask "k" (elements are not stored when the corresponding
mask bit is not set). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        MEM[addr+31:addr] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VSUBPD - _mm512_mask_sub_pd

| VSUBPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed double-precision (64-bit) floating-point elements in "b" from packed double-precision (64-bit)
floating-point elements in "a", and store the results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i] - b[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBPD - _mm512_mask_sub_round_pd

| VSUBPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed double-precision (64-bit) floating-point elements in "b" from packed double-precision (64-bit)
floating-point elements in "a", and store the results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := a[i+63:i] - b[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBPD - _mm512_sub_pd

| VSUBPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed double-precision (64-bit) floating-point elements in "b" from packed double-precision (64-bit)
floating-point elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := a[i+63:i] - b[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBPD - _mm512_sub_round_pd

| VSUBPD_ZMMf64_MASKmskw_ZMMf64_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed double-precision (64-bit) floating-point elements in "b" from packed double-precision (64-bit)
floating-point elements in "a", and store the results in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := a[i+63:i] - b[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBPS - _mm512_mask_sub_ps

| VSUBPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed single-precision (32-bit) floating-point elements in "b" from packed single-precision (32-bit)
floating-point elements in "a", and store the results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] - b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI    
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBPS - _mm512_mask_sub_round_ps

| VSUBPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed single-precision (32-bit) floating-point elements in "b" from packed single-precision (32-bit)
floating-point elements in "a", and store the results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] - b[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI    
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBPS - _mm512_sub_ps

| VSUBPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed single-precision (32-bit) floating-point elements in "b" from packed single-precision (32-bit)
floating-point elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] - b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBPS - _mm512_sub_round_ps

| VSUBPS_ZMMf32_MASKmskw_ZMMf32_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Subtract packed single-precision (32-bit) floating-point elements in "b" from packed single-precision (32-bit)
floating-point elements in "a", and store the results in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] - b[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_castpd_ps

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m512d to type __m512.
	This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm512_castpd_si512

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m512d to type __m512i.
	This intrinsic is only used for compilation and does not
generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm512_castps_pd

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m512 to type __m512d.
	This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm512_castps_si512

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m512 to type __m512i.
	This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm512_castsi512_pd

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m512i to type __m512d.
	This intrinsic is only used for compilation and does not
generate any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm512_castsi512_ps

--------------------------------------------------------------------------------------------------------------
Cast vector of type __m512i to type __m512.
	This intrinsic is only used for compilation and does not generate
any instructions, thus it has zero latency.

[missing]

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_add_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed 32-bit integers in "a" by addition using mask "k". Returns the sum of all active elements in
"a".

[algorithm]

dst[31:0] := 0
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := dst[31:0] + a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_add_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed 64-bit integers in "a" by addition using mask "k". Returns the sum of all active elements in
"a".

[algorithm]

dst[63:0] := 0
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := dst[63:0] + a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_add_pd

--------------------------------------------------------------------------------------------------------------
Reduce the packed double-precision (64-bit) floating-point elements in "a" by addition using mask "k". Returns
the sum of all active elements in "a".

[algorithm]

dst[63:0] := 0.0
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := dst[63:0] + a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_add_ps

--------------------------------------------------------------------------------------------------------------
Reduce the packed single-precision (32-bit) floating-point elements in "a" by addition using mask "k". Returns
the sum of all active elements in "a".

[algorithm]

dst[31:0] := 0.0
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := dst[31:0] + a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_and_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed 32-bit integers in "a" by bitwise AND using mask "k". Returns the bitwise AND of all active
elements in "a".

[algorithm]

dst[31:0] := 0xFFFFFFFF
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := dst[31:0] AND a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_and_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed 64-bit integers in "a" by bitwise AND using mask "k". Returns the bitwise AND of all active
elements in "a".

[algorithm]

dst[63:0] := 0xFFFFFFFFFFFFFFFF
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := dst[63:0] AND a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_max_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed signed 32-bit integers in "a" by maximum using mask "k". Returns the maximum of all active
elements in "a".

[algorithm]

dst[31:0] := Int32(-0x80000000)
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := (dst[31:0] &gt; a[i+31:i] ? dst[31:0] : a[i+31:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_max_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed signed 64-bit integers in "a" by maximum using mask "k". Returns the maximum of all active
elements in "a".

[algorithm]

dst[63:0] := Int64(-0x8000000000000000)
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := (dst[63:0] &gt; a[i+63:i] ? dst[63:0] : a[i+63:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_max_epu32

--------------------------------------------------------------------------------------------------------------
Reduce the packed unsigned 32-bit integers in "a" by maximum using mask "k". Returns the maximum of all active
elements in "a".

[algorithm]

dst[31:0] := 0
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := (dst[31:0] &gt; a[i+31:i] ? dst[31:0] : a[i+31:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_max_epu64

--------------------------------------------------------------------------------------------------------------
Reduce the packed unsigned 64-bit integers in "a" by maximum using mask "k". Returns the maximum of all active
elements in "a".

[algorithm]

dst[63:0] := 0
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := (dst[63:0] &gt; a[i+63:i] ? dst[63:0] : a[i+63:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_max_pd

--------------------------------------------------------------------------------------------------------------
Reduce the packed double-precision (64-bit) floating-point elements in "a" by maximum using mask "k". Returns
the maximum of all active elements in "a".

[algorithm]

dst[63:0] := Cast_FP64(0xFFEFFFFFFFFFFFFF)
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := (dst[63:0] &gt; a[i+63:i] ? dst[63:0] : a[i+63:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_max_ps

--------------------------------------------------------------------------------------------------------------
Reduce the packed single-precision (32-bit) floating-point elements in "a" by maximum using mask "k". Returns
the maximum of all active elements in "a".

[algorithm]

dst[31:0] := Cast_FP32(0xFF7FFFFF)
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := (dst[31:0] &gt; a[i+31:i] ? dst[31:0] : a[i+31:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_min_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed signed 32-bit integers in "a" by maximum using mask "k". Returns the minimum of all active
elements in "a".

[algorithm]

dst[31:0] := Int32(0x7FFFFFFF)
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := (dst[31:0] &lt; a[i+31:i] ? dst[31:0] : a[i+31:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_min_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed signed 64-bit integers in "a" by maximum using mask "k". Returns the minimum of all active
elements in "a".

[algorithm]

dst[63:0] := Int64(0x7FFFFFFFFFFFFFFF)
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := (dst[63:0] &lt; a[i+63:i] ? dst[63:0] : a[i+63:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_min_epu32

--------------------------------------------------------------------------------------------------------------
Reduce the packed unsigned 32-bit integers in "a" by maximum using mask "k". Returns the minimum of all active
elements in "a".

[algorithm]

dst[31:0] := 0xFFFFFFFF
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := (dst[31:0] &lt; a[i+31:i] ? dst[31:0] : a[i+31:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_min_epu64

--------------------------------------------------------------------------------------------------------------
Reduce the packed unsigned 64-bit integers in "a" by minimum using mask "k". Returns the minimum of all active
elements in "a".

[algorithm]

dst[63:0] := 0xFFFFFFFFFFFFFFFF
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := (dst[63:0] &lt; a[i+63:i] ? dst[63:0] : a[i+63:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_min_pd

--------------------------------------------------------------------------------------------------------------
Reduce the packed double-precision (64-bit) floating-point elements in "a" by maximum using mask "k". Returns
the minimum of all active elements in "a".

[algorithm]

dst[63:0] := Cast_FP64(0x7FEFFFFFFFFFFFFF)
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := (dst[63:0] &lt; a[i+63:i] ? dst[63:0] : a[i+63:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_min_ps

--------------------------------------------------------------------------------------------------------------
Reduce the packed single-precision (32-bit) floating-point elements in "a" by maximum using mask "k". Returns
the minimum of all active elements in "a".

[algorithm]

dst[31:0] := Cast_FP32(0x7F7FFFFF)
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := (dst[31:0] &lt; a[i+31:i] ? dst[31:0] : a[i+31:i])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_mul_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed 32-bit integers in "a" by multiplication using mask "k". Returns the product of all active
elements in "a".

[algorithm]

dst[31:0] := 1
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := dst[31:0] * a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_mul_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed 64-bit integers in "a" by multiplication using mask "k". Returns the product of all active
elements in "a".

[algorithm]

dst[63:0] := 1
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := dst[63:0] * a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_mul_pd

--------------------------------------------------------------------------------------------------------------
Reduce the packed double-precision (64-bit) floating-point elements in "a" by multiplication using mask "k".
Returns the product of all active elements in "a".

[algorithm]

dst[63:0] := 1.0
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := dst[63:0] * a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_mul_ps

--------------------------------------------------------------------------------------------------------------
Reduce the packed single-precision (32-bit) floating-point elements in "a" by multiplication using mask "k".
Returns the product of all active elements in "a".

[algorithm]

dst[31:0] := FP32(1.0)
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := dst[31:0] * a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_or_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed 32-bit integers in "a" by bitwise OR using mask "k". Returns the bitwise OR of all active
elements in "a".

[algorithm]

dst[31:0] := 0
FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[31:0] := dst[31:0] OR a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_reduce_or_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed 64-bit integers in "a" by bitwise OR using mask "k". Returns the bitwise OR of all active
elements in "a".

[algorithm]

dst[63:0] := 0
FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[63:0] := dst[63:0] OR a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_add_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed 32-bit integers in "a" by addition. Returns the sum of all elements in "a".

[algorithm]

dst[31:0] := 0
FOR j := 0 to 15
    i := j*32
    dst[31:0] := dst[31:0] + a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_add_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed 64-bit integers in "a" by addition. Returns the sum of all elements in "a".

[algorithm]

dst[63:0] := 0
FOR j := 0 to 7
    i := j*64
    dst[63:0] := dst[63:0] + a[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_add_pd

--------------------------------------------------------------------------------------------------------------
Reduce the packed double-precision (64-bit) floating-point elements in "a" by addition. Returns the sum of all
elements in "a".

[algorithm]

dst[63:0] := 0.0
FOR j := 0 to 7
    i := j*64
    dst[63:0] := dst[63:0] + a[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_add_ps

--------------------------------------------------------------------------------------------------------------
Reduce the packed single-precision (32-bit) floating-point elements in "a" by addition. Returns the sum of all
elements in "a".

[algorithm]

dst[31:0] := 0.0
FOR j := 0 to 15
    i := j*32
    dst[31:0] := dst[31:0] + a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_and_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed 32-bit integers in "a" by bitwise AND. Returns the bitwise AND of all elements in "a".

[algorithm]

dst[31:0] := 0xFFFFFFFF
FOR j := 0 to 15
    i := j*32
    dst[31:0] := dst[31:0] AND a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_and_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed 64-bit integers in "a" by bitwise AND. Returns the bitwise AND of all elements in "a".

[algorithm]

dst[63:0] := 0xFFFFFFFFFFFFFFFF
FOR j := 0 to 7
    i := j*64
    dst[63:0] := dst[63:0] AND a[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_max_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed signed 32-bit integers in "a" by maximum. Returns the maximum of all elements in "a".

[algorithm]

dst[31:0] := Int32(-0x80000000)
FOR j := 0 to 15
    i := j*32
    dst[31:0] := (dst[31:0] &gt; a[i+31:i] ? dst[31:0] : a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_max_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed signed 64-bit integers in "a" by maximum. Returns the maximum of all elements in "a".

[algorithm]

dst[63:0] := Int64(-0x8000000000000000)
FOR j := 0 to 7
    i := j*64
    dst[63:0] := (dst[63:0] &gt; a[i+63:i] ? dst[63:0] : a[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_max_epu32

--------------------------------------------------------------------------------------------------------------
Reduce the packed unsigned 32-bit integers in "a" by maximum. Returns the maximum of all elements in "a".

[algorithm]

dst[31:0] := 0
FOR j := 0 to 15
    i := j*32
    dst[31:0] := (dst[31:0] &gt; a[i+31:i] ? dst[31:0] : a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_max_epu64

--------------------------------------------------------------------------------------------------------------
Reduce the packed unsigned 64-bit integers in "a" by maximum. Returns the maximum of all elements in "a".

[algorithm]

dst[63:0] := 0
FOR j := 0 to 7
    i := j*64
    dst[63:0] := (dst[63:0] &gt; a[i+63:i] ? dst[63:0] : a[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_max_pd

--------------------------------------------------------------------------------------------------------------
Reduce the packed double-precision (64-bit) floating-point elements in "a" by maximum. Returns the maximum of
all elements in "a".

[algorithm]

dst[63:0] := Cast_FP64(0xFFEFFFFFFFFFFFFF)
FOR j := 0 to 7
    i := j*64
    dst[63:0] := (dst[63:0] &gt; a[i+63:i] ? dst[63:0] : a[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_max_ps

--------------------------------------------------------------------------------------------------------------
Reduce the packed single-precision (32-bit) floating-point elements in "a" by maximum. Returns the maximum of
all elements in "a".

[algorithm]

dst[31:0] := Cast_FP32(0xFF7FFFFF)
FOR j := 0 to 15
    i := j*32
    dst[31:0] := (dst[31:0] &gt; a[i+31:i] ? dst[31:0] : a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_min_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed signed 32-bit integers in "a" by minimum. Returns the minimum of all elements in "a".

[algorithm]

dst[31:0] := Int32(0x7FFFFFFF)
FOR j := 0 to 15
    i := j*32
    dst[31:0] := (dst[31:0] &lt; a[i+31:i] ? dst[31:0] : a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_min_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed signed 64-bit integers in "a" by minimum. Returns the minimum of all elements in "a".

[algorithm]

dst[63:0] := Int64(0x7FFFFFFFFFFFFFFF)
FOR j := 0 to 7
    i := j*64
    dst[63:0] := (dst[63:0] &lt; a[i+63:i] ? dst[63:0] : a[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_min_epu32

--------------------------------------------------------------------------------------------------------------
Reduce the packed unsigned 32-bit integers in "a" by minimum. Returns the minimum of all elements in "a".

[algorithm]

dst[31:0] := 0xFFFFFFFF
FOR j := 0 to 15
    i := j*32
    dst[31:0] := (dst[31:0] &lt; a[i+31:i] ? dst[31:0] : a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_min_epu64

--------------------------------------------------------------------------------------------------------------
Reduce the packed unsigned 64-bit integers in "a" by minimum. Returns the minimum of all elements in "a".

[algorithm]

dst[63:0] := 0xFFFFFFFFFFFFFFFF
FOR j := 0 to 7
    i := j*64
    dst[63:0] := (dst[63:0] &lt; a[i+63:i] ? dst[63:0] : a[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_min_pd

--------------------------------------------------------------------------------------------------------------
Reduce the packed double-precision (64-bit) floating-point elements in "a" by minimum. Returns the minimum of
all elements in "a".

[algorithm]

dst[63:0] := Cast_FP64(0x7FEFFFFFFFFFFFFF)
FOR j := 0 to 7
    i := j*64
    dst[63:0] := (dst[63:0] &lt; a[i+63:i] ? dst[63:0] : a[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_min_ps

--------------------------------------------------------------------------------------------------------------
Reduce the packed single-precision (32-bit) floating-point elements in "a" by minimum. Returns the minimum of
all elements in "a".

[algorithm]

dst[31:0] := Cast_FP32(0x7F7FFFFF)
FOR j := 0 to 15
    i := j*32
    dst[31:0] := (dst[31:0] &lt; a[i+31:i] ? dst[31:0] : a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_mul_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed 32-bit integers in "a" by multiplication. Returns the product of all elements in "a".

[algorithm]

dst[31:0] := 1
FOR j := 0 to 15
    i := j*32
    dst[31:0] := dst[31:0] * a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_mul_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed 64-bit integers in "a" by multiplication. Returns the product of all elements in "a".

[algorithm]

dst[63:0] := 1
FOR j := 0 to 7
    i := j*64
    dst[63:0] := dst[63:0] * a[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_mul_pd

--------------------------------------------------------------------------------------------------------------
Reduce the packed double-precision (64-bit) floating-point elements in "a" by multiplication. Returns the
product of all elements in "a".

[algorithm]

dst[63:0] := 1.0
FOR j := 0 to 7
    i := j*64
    dst[63:0] := dst[63:0] * a[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_mul_ps

--------------------------------------------------------------------------------------------------------------
Reduce the packed single-precision (32-bit) floating-point elements in "a" by multiplication. Returns the
product of all elements in "a".

[algorithm]

dst[31:0] := FP32(1.0)
FOR j := 0 to 15
    i := j*32
    dst[31:0] := dst[31:0] * a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_or_epi32

--------------------------------------------------------------------------------------------------------------
Reduce the packed 32-bit integers in "a" by bitwise OR. Returns the bitwise OR of all elements in "a".

[algorithm]

dst[31:0] := 0
FOR j := 0 to 15
    i := j*32
    dst[31:0] := dst[31:0] OR a[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## _mm512_reduce_or_epi64

--------------------------------------------------------------------------------------------------------------
Reduce the packed 64-bit integers in "a" by bitwise OR. Returns the bitwise OR of all elements in "a".

[algorithm]

dst[63:0] := 0
FOR j := 0 to 7
    i := j*64
    dst[63:0] := dst[63:0] OR a[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPANDD - _mm512_mask_and_epi32

| VPANDD_ZMMu32_MASKmskw_ZMMu32_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Performs element-by-element bitwise AND between packed 32-bit integer elements of "v2" and "v3", storing the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := v2[i+31:i] &amp; v3[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPS2PD - _mm512_cvtpslo_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of the lower half of packed single-precision (32-bit) floating-point
elements in "v2" to packed double-precision (64-bit) floating-point elements, storing the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    n := j*64
    dst[n+63:n] := Convert_FP32_To_FP64(v2[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPS2PD - _mm512_mask_cvtpslo_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of the lower half of packed single-precision (32-bit) floating-point
elements in "v2" to packed double-precision (64-bit) floating-point elements, storing the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*32
    l := j*64
    IF k[j]
        dst[l+63:l] := Convert_FP32_To_FP64(v2[i+31:i])
    ELSE
        dst[l+63:l] := src[l+63:l]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTDQ2PD - _mm512_cvtepi32lo_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of the lower half of packed 32-bit integer elements in "v2" to packed
double-precision (64-bit) floating-point elements, storing the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    l := j*64
    dst[l+63:l] := Convert_Int32_To_FP64(v2[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTDQ2PD - _mm512_mask_cvtepi32lo_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of the lower half of packed 32-bit integer elements in "v2" to packed
double-precision (64-bit) floating-point elements, storing the results in "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*32
    n := j*64
    IF k[j]
        dst[n+63:n] := Convert_Int32_To_FP64(v2[i+31:i])
    ELSE
        dst[n+63:n] := src[n+63:n]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTUDQ2PD - _mm512_cvtepu32lo_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of the lower half of packed 32-bit unsigned integer elements in "v2" to
packed double-precision (64-bit) floating-point elements, storing the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    n := j*64
    dst[n+63:n] := Convert_Int32_To_FP64(v2[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTUDQ2PD - _mm512_mask_cvtepu32lo_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of the lower half of 32-bit unsigned integer elements in "v2" to packed
double-precision (64-bit) floating-point elements, storing the results in "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*32
    l := j*64
    IF k[j]
        dst[l+63:l] := Convert_Int32_To_FP64(v2[i+31:i])
    ELSE
        dst[l+63:l] := src[l+63:l]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDD - _mm512_i32extgather_epi32

| VPGATHERDD_ZMMu32_MASKmskw_MEMu32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Up-converts 16 memory locations starting at location "base_addr" at packed 32-bit integer indices stored in
"vindex" scaled by "scale" using "conv" to 32-bit integer elements and stores them in "dst". AVX512 only
supports _MM_UPCONV_EPI32_NONE.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:   dst[i+31:i] := MEM[addr+31:addr]
    _MM_UPCONV_EPI32_UINT8:  dst[i+31:i] := ZeroExtend32(MEM[addr+7:addr])
    _MM_UPCONV_EPI32_SINT8:  dst[i+31:i] := SignExtend32(MEM[addr+7:addr])
    _MM_UPCONV_EPI32_UINT16: dst[i+31:i] := ZeroExtend32(MEM[addr+15:addr])
    _MM_UPCONV_EPI32_SINT16: dst[i+31:i] := SignExtend32(MEM[addr+15:addr])
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDD - _mm512_mask_i32extgather_epi32

| VPGATHERDD_ZMMu32_MASKmskw_MEMu32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Up-converts 16 single-precision (32-bit) memory locations starting at location "base_addr" at packed 32-bit
integer indices stored in "vindex" scaled by "scale" using "conv" to 32-bit integer elements and stores them in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). AVX512
only supports _MM_UPCONV_EPI32_NONE.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
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
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDQ - _mm512_i32loextgather_epi64

| VPGATHERDQ_ZMMu64_MASKmskw_MEMu64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Up-converts 8 double-precision (64-bit) memory locations starting at location "base_addr" at packed 32-bit
integer indices stored in the lower half of "vindex" scaled by "scale" using "conv" to 64-bit integer elements
and stores them in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_UPCONV_EPI64_NONE: dst[i+63:i] := MEM[addr+63:addr]
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDQ - _mm512_mask_i32loextgather_epi64

| VPGATHERDQ_ZMMu64_MASKmskw_MEMu64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Up-converts 8 double-precision (64-bit) memory locations starting at location "base_addr" at packed 32-bit
integer indices stored in the lower half of "vindex" scaled by "scale" using "conv" to 64-bit integer elements
and stores them in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is
not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
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

## VGATHERDPS - _mm512_i32extgather_ps

| VGATHERDPS_ZMMf32_MASKmskw_MEMf32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Up-converts 16 memory locations starting at location "base_addr" at packed 32-bit integer indices stored in
"vindex" scaled by "scale" using "conv" to single-precision (32-bit) floating-point elements and stores them in
"dst". AVX512 only supports _MM_UPCONV_PS_NONE.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_UPCONV_PS_NONE:    dst[i+31:i] := MEM[addr+31:addr]
    _MM_UPCONV_PS_FLOAT16: dst[i+31:i] := Convert_FP16_To_FP32(MEM[addr+15:addr])
    _MM_UPCONV_PS_UINT8:   dst[i+31:i] := Convert_UInt8_To_FP32(MEM[addr+7:addr])
    _MM_UPCONV_PS_SINT8:   dst[i+31:i] := Convert_Int8_To_FP32(MEM[addr+7:addr])
    _MM_UPCONV_PS_UINT16:  dst[i+31:i] := Convert_UInt16_To_FP32(MEM[addr+15:addr])
    _MM_UPCONV_PS_SINT16:  dst[i+31:i] := Convert_Int16_To_FP32(MEM[addr+15:addr])
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPS - _mm512_mask_i32extgather_ps

| VGATHERDPS_ZMMf32_MASKmskw_MEMf32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Up-converts 16 single-precision (32-bit) memory locations starting at location "base_addr" at packed 32-bit
integer indices stored in "vindex" scaled by "scale" using "conv" to single-precision (32-bit) floating-point
elements and stores them in "dst" using writemask "k" (elements are copied from "src" when the corresponding
mask bit is not set). AVX512 only supports _MM_UPCONV_PS_NONE.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
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
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPD - _mm512_i32loextgather_pd

| VGATHERDPD_ZMMf64_MASKmskw_MEMf64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Up-converts 8 double-precision (64-bit) floating-point elements in memory locations starting at location
"base_addr" at packed 32-bit integer indices stored in the lower half of "vindex" scaled by "scale" using
"conv" to 64-bit floating-point elements and stores them in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_UPCONV_PD_NONE: dst[i+63:i] := MEM[addr+63:addr]
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPD - _mm512_mask_i32loextgather_pd

| VGATHERDPD_ZMMf64_MASKmskw_MEMf64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Up-converts 8 double-precision (64-bit) floating-point elements in memory locations starting at location
"base_addr" at packed 32-bit integer indices stored in the lower half of "vindex" scaled by "scale" using
"conv" to 64-bit floating-point elements and stores them in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_UPCONV_PD_NONE:
            dst[i+63:i] := MEM[addr+63:addr]
        ESAC
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSCATTERDPS - _mm512_i32extscatter_ps

| VSCATTERDPS_MEMf32_MASKmskw_ZMMf32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Down-converts 16 packed single-precision (32-bit) floating-point elements in "a" and stores them in memory
locations starting at location "base_addr" at packed 32-bit integer indices stored in "vindex" scaled by
"scale" using "conv". AVX512 only supports _MM_DOWNCONV_PS_NONE.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
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

## VSCATTERDPS - _mm512_mask_i32extscatter_ps

| VSCATTERDPS_MEMf32_MASKmskw_ZMMf32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Down-converts 16 packed single-precision (32-bit) floating-point elements in "a" according to "conv" and
stores them in memory locations starting at location "base_addr" at packed 32-bit integer indices stored in
"vindex" scaled by "scale" using writemask "k" (elements are written only when the corresponding mask bit is
not set). AVX512 only supports _MM_DOWNCONV_PS_NONE.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
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

## VSCATTERDPD - _mm512_i32loextscatter_pd

| VSCATTERDPD_MEMf64_MASKmskw_ZMMf64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed double-precision (64-bit) floating-point elements in "a" and stores them in memory
locations starting at location "base_addr" at packed 32-bit integer indices stored in "vindex" scaled by
"scale" using "conv".

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_DOWNCONV_PD_NONE: MEM[addr+63:addr] := a[i+63:i]
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VSCATTERDPD - _mm512_mask_i32loextscatter_pd

| VSCATTERDPD_MEMf64_MASKmskw_ZMMf64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed double-precision (64-bit) floating-point elements in "a" and stores them in memory
locations starting at location "base_addr" at packed 32-bit integer indices stored in "vindex" scaled by
"scale" using "conv". Only those elements whose corresponding mask bit is set in writemask "k" are written to
memory.

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_PD_NONE: MEM[addr+63:addr] := a[i+63:i]
        ESAC
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPSCATTERDQ - _mm512_i32loextscatter_epi64

| VPSCATTERDQ_MEMu64_MASKmskw_ZMMu64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed 64-bit integer elements in "a" and stores them in memory locations starting at location
"base_addr" at packed 32-bit integer indices stored in "vindex" scaled by "scale" using "conv".

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_DOWNCONV_EPI64_NONE: MEM[addr+63:addr] := a[i+63:i]
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPSCATTERDQ - _mm512_mask_i32loextscatter_epi64

| VPSCATTERDQ_MEMu64_MASKmskw_ZMMu64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Down-converts 8 packed 64-bit integer elements in "a" and stores them in memory locations starting at location
"base_addr" at packed 32-bit integer indices stored in "vindex" scaled by "scale" using "conv". Only those
elements whose corresponding mask bit is set in writemask "k" are written to memory.

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_EPI64_NONE: MEM[addr+63:addr] := a[i+63:i]
        ESAC
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VCVTPD2PS - _mm512_cvtpd_pslo

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element conversion of packed double-precision (64-bit) floating-point elements in "v2"
to single-precision (32-bit) floating-point elements and stores them in "dst". The elements are stored in the
lower half of the results vector, while the remaining upper half locations are set to 0.

[algorithm]

FOR j := 0 to 7
    i := j*64
    k := j*32
    dst[k+31:k] := Convert_FP64_To_FP32(v2[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPD2PS - _mm512_mask_cvtpd_pslo

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element conversion of packed double-precision (64-bit) floating-point elements in "v2"
to single-precision (32-bit) floating-point elements and stores them in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set). The elements are stored in the lower half of the
results vector, while the remaining upper half locations are set to 0.

[algorithm]

FOR j := 0 to 7
    i := j*64
    l := j*32
    IF k[j]
        dst[l+31:l] := Convert_FP64_To_FP32(v2[i+63:i])
    ELSE
        dst[l+31:l] := src[l+31:l]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDQ - _mm512_i32logather_epi64

| VPGATHERDQ_ZMMu64_MASKmskw_MEMu64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Loads 8 64-bit integer elements from memory starting at location "base_addr" at packed 32-bit integer indices
stored in the lower half of "vindex" scaled by "scale" and stores them in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDQ - _mm512_mask_i32logather_epi64

| VPGATHERDQ_ZMMu64_MASKmskw_MEMu64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Loads 8 64-bit integer elements from memory starting at location "base_addr" at packed 32-bit integer indices
stored in the lower half of "vindex" scaled by "scale" and stores them in "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPD - _mm512_i32logather_pd

| VGATHERDPD_ZMMf64_MASKmskw_MEMf64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Loads 8 double-precision (64-bit) floating-point elements stored at memory locations starting at location
"base_addr" at packed 32-bit integer indices stored in the lower half of "vindex" scaled by "scale" them in
"dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPD - _mm512_mask_i32logather_pd

| VGATHERDPD_ZMMf64_MASKmskw_MEMf64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Loads 8 double-precision (64-bit) floating-point elements from memory starting at location "base_addr" at
packed 32-bit integer indices stored in the lower half of "vindex" scaled by "scale" into "dst" using writemask
"k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSCATTERDPD - _mm512_i32loscatter_pd

| VSCATTERDPD_MEMf64_MASKmskw_ZMMf64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Stores 8 packed double-precision (64-bit) floating-point elements in "a" and to memory locations starting at
location "base_addr" at packed 32-bit integer indices stored in "vindex" scaled by "scale".

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    MEM[addr+63:addr] := a[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VSCATTERDPD - _mm512_mask_i32loscatter_pd

| VSCATTERDPD_MEMf64_MASKmskw_ZMMf64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Stores 8 packed double-precision (64-bit) floating-point elements in "a" to memory locations starting at
location "base_addr" at packed 32-bit integer indices stored in "vindex" scaled by "scale". Only those elements
whose corresponding mask bit is set in writemask "k" are written to memory.

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        MEM[addr+63:addr] := a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPANDD - _mm512_abs_ps

| VPANDD_ZMMu32_MASKmskw_ZMMu32_MEMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Finds the absolute value of each packed single-precision (32-bit) floating-point element in "v2", storing the
results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ABS(v2[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDD - _mm512_mask_abs_ps

| VPANDD_ZMMu32_MASKmskw_ZMMu32_MEMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Finds the absolute value of each packed single-precision (32-bit) floating-point element in "v2", storing the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ABS(v2[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDQ - _mm512_abs_pd

| VPANDQ_ZMMu64_MASKmskw_ZMMu64_MEMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Finds the absolute value of each packed double-precision (64-bit) floating-point element in "v2", storing the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ABS(v2[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDQ - _mm512_mask_abs_pd

| VPANDQ_ZMMu64_MASKmskw_ZMMu64_MEMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Finds the absolute value of each packed double-precision (64-bit) floating-point element in "v2", storing the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ABS(v2[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSCATTERDD - _mm512_i32extscatter_epi32

| VPSCATTERDD_MEMu32_MASKmskw_ZMMu32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Down-converts 16 packed 32-bit integer elements in "a" using "conv" and stores them in memory locations
starting at location "base_addr" at packed 32-bit integer indices stored in "vindex" scaled by "scale". "hint"
indicates to the processor whether the data is non-temporal. AVX512 only supports _MM_DOWNCONV_EPI32_NONE.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    CASE conv OF
    _MM_DOWNCONV_EPI32_NONE:   MEM[addr+31:addr] := a[i+31:i]
    _MM_DOWNCONV_EPI32_UINT8:  MEM[addr+ 7:addr] := Truncate8(a[i+31:i])
    _MM_DOWNCONV_EPI32_SINT8:  MEM[addr+ 7:addr] := Saturate8(a[i+31:i])
    _MM_DOWNCONV_EPI32_UINT16: MEM[addr+15:addr] := Truncate16(a[i+31:i])
    _MM_DOWNCONV_EPI32_SINT16: MEM[addr+15:addr] := Saturate16(a[i+15:i])
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPSCATTERDD - _mm512_mask_i32extscatter_epi32

| VPSCATTERDD_MEMu32_MASKmskw_ZMMu32_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Down-converts 16 packed 32-bit integer elements in "a" using "conv" and stores them in memory locations
starting at location "base_addr" at packed 32-bit integer indices stored in "vindex" scaled by "scale".
Elements are written using writemask "k" (elements are only written when the corresponding mask bit is set;
otherwise, elements are left unchanged in memory). "hint" indicates to the processor whether the data is
non-temporal. AVX512 only supports _MM_DOWNCONV_EPI32_NONE.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_EPI32_NONE:   MEM[addr+31:addr] := a[i+31:i]
        _MM_DOWNCONV_EPI32_UINT8:  MEM[addr+ 7:addr] := Truncate8(a[i+31:i])
        _MM_DOWNCONV_EPI32_SINT8:  MEM[addr+ 7:addr] := Saturate8(a[i+31:i])
        _MM_DOWNCONV_EPI32_UINT16: MEM[addr+15:addr] := Truncate16(a[i+31:i])
        _MM_DOWNCONV_EPI32_SINT16: MEM[addr+15:addr] := Saturate16(a[i+15:i])
        ESAC
    FI 
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VGATHERPF0DPS - _mm512_mask_prefetch_i32gather_ps

| VGATHERPF0DPS_MEMf32_MASKmskw_AVX512PF_VL512 | VGATHERPF1DPS_MEMf32_MASKmskw_AVX512PF_VL512

--------------------------------------------------------------------------------------------------------------
Prefetch single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements
are loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged in cache using writemask "k" (elements are
brought into cache only when their corresponding mask bits are set). "scale" should be 1, 2, 4 or 8. The "hint"
parameter may be 1 (_MM_HINT_T0) for prefetching to L1 cache, or 2 (_MM_HINT_T1) for prefetching to L2 cache.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        Prefetch(MEM[addr+31:addr], hint)
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VGATHERPF0DPS - _mm512_prefetch_i32extgather_ps

| VGATHERPF0DPS_MEMf32_MASKmskw_AVX512PF_VL512 | VGATHERPF1DPS_MEMf32_MASKmskw_AVX512PF_VL512

--------------------------------------------------------------------------------------------------------------
Prefetches a set of 16 single-precision (32-bit) memory locations pointed by base address "base_addr" and
32-bit integer index vector "vindex" with scale "scale" to L1 or L2 level of cache depending on the value of
"hint". The "hint" parameter may be 1 (_MM_HINT_T0) for prefetching to L1 cache, or 2 (_MM_HINT_T1) for
prefetching to L2 cache.
The "conv" parameter specifies the granularity used by compilers to better encode the
instruction. It should be the same as the "conv" parameter specified for the subsequent gather intrinsic.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    Prefetch(MEM[addr+31:addr], hint)
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VGATHERPF0DPS - _mm512_mask_prefetch_i32extgather_ps

| VGATHERPF0DPS_MEMf32_MASKmskw_AVX512PF_VL512 | VGATHERPF1DPS_MEMf32_MASKmskw_AVX512PF_VL512

--------------------------------------------------------------------------------------------------------------
Prefetches a set of 16 single-precision (32-bit) memory locations pointed by base address "base_addr" and
32-bit integer index vector "vindex" with scale "scale" to L1 or L2 level of cache depending on the value of
"hint". Gathered elements are merged in cache using writemask "k" (elements are brought into cache only when
their corresponding mask bits are set). The "hint" parameter may be 1 (_MM_HINT_T0) for prefetching to L1
cache, or 2 (_MM_HINT_T1) for prefetching to L2 cache.
The "conv" parameter specifies the granularity used by
compilers to better encode the instruction. It should be the same as the "conv" parameter specified for the
subsequent gather intrinsic.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        Prefetch(MEM[addr+31:addr], hint)
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VSCATTERPF0DPS - _mm512_prefetch_i32extscatter_ps

| VSCATTERPF0DPS_MEMf32_MASKmskw_AVX512PF_VL512 | VSCATTERPF1DPS_MEMf32_MASKmskw_AVX512PF_VL512

--------------------------------------------------------------------------------------------------------------
Prefetches a set of 16 single-precision (32-bit) memory locations pointed by base address "base_addr" and
32-bit integer index vector "vindex" with scale "scale" to L1 or L2 level of cache depending on the value of
"hint", with a request for exclusive ownership. The "hint" parameter may be one of the following: _MM_HINT_T0 =
1 for prefetching to L1 cache, _MM_HINT_T1 = 2 for prefetching to L2 cache, _MM_HINT_T2 = 3 for prefetching to
L2 cache non-temporal, _MM_HINT_NTA = 0 for prefetching to L1 cache non-temporal. The "conv" parameter
specifies the granularity used by compilers to better encode the instruction. It should be the same as the
"conv" parameter specified for the subsequent scatter intrinsic.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    Prefetch(MEM[addr+31:addr], hint)
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VSCATTERPF0DPS - _mm512_mask_prefetch_i32extscatter_ps

| VSCATTERPF0DPS_MEMf32_MASKmskw_AVX512PF_VL512 | VSCATTERPF1DPS_MEMf32_MASKmskw_AVX512PF_VL512

--------------------------------------------------------------------------------------------------------------
Prefetches a set of 16 single-precision (32-bit) memory locations pointed by base address "base_addr" and
32-bit integer index vector "vindex" with scale "scale" to L1 or L2 level of cache depending on the value of
"hint". The "hint" parameter may be 1 (_MM_HINT_T0) for prefetching to L1 cache, or 2 (_MM_HINT_T1) for
prefetching to L2 cache.
The "conv" parameter specifies the granularity used by compilers to better encode the
instruction. It should be the same as the "conv" parameter specified for the subsequent gather intrinsic. Only
those elements whose corresponding mask bit in "k" is set are loaded into cache.

[algorithm]

cachev := 0
FOR j := 0 to 15
    i := j*32
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        Prefetch(MEM[addr+31:addr], hint)
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VGATHERPF0DPS - _mm512_prefetch_i32gather_ps

| VGATHERPF0DPS_MEMf32_MASKmskw_AVX512PF_VL512 | VGATHERPF1DPS_MEMf32_MASKmskw_AVX512PF_VL512

--------------------------------------------------------------------------------------------------------------
Prefetches 16 single-precision (32-bit) floating-point elements in memory starting at location "base_addr" at
packed 32-bit integer indices stored in "vindex" scaled by "scale". The "hint" parameter may be 1 (_MM_HINT_T0)
for prefetching to L1 cache, or 2 (_MM_HINT_T1) for prefetching to L2 cache.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    Prefetch(MEM[addr+31:addr], hint)
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VSCATTERPF0DPS - _mm512_prefetch_i32scatter_ps

| VSCATTERPF0DPS_MEMf32_MASKmskw_AVX512PF_VL512 | VSCATTERPF1DPS_MEMf32_MASKmskw_AVX512PF_VL512

--------------------------------------------------------------------------------------------------------------
Prefetches 16 single-precision (32-bit) floating-point elements in memory starting at location "base_addr" at
packed 32-bit integer indices stored in "vindex" scaled by "scale". The "hint" parameter may be 1 (_MM_HINT_T0)
for prefetching to L1 cache, or 2 (_MM_HINT_T1) for prefetching to L2 cache.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    Prefetch(MEM[addr+31:addr], hint)
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VSCATTERPF0DPS - _mm512_mask_prefetch_i32scatter_ps

| VSCATTERPF0DPS_MEMf32_MASKmskw_AVX512PF_VL512 | VSCATTERPF1DPS_MEMf32_MASKmskw_AVX512PF_VL512

--------------------------------------------------------------------------------------------------------------
Prefetches 16 single-precision (32-bit) floating-point elements in memory starting at location "base_addr" at
packed 32-bit integer indices stored in "vindex" scaled by "scale". The "hint" parameter may be 1 (_MM_HINT_T0)
for prefetching to L1 cache, or 2 (_MM_HINT_T1) for prefetching to L2 cache. Only those elements whose
corresponding mask bit in "k" is set are loaded into the desired cache.

[algorithm]

FOR j := 0 to 15
    i := j*32
    m := j*32
    IF k[j]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        Prefetch(MEM[addr+31:addr], hint)
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------
