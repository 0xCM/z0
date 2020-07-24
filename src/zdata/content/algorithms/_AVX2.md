# _AVX2

## _mm256_extract_epi8

--------------------------------------------------------------------------------------------------------------
Extract an 8-bit integer from "a", selected with "index", and store the result in "dst".

[algorithm]

dst[7:0] := (a[255:0] &gt;&gt; (index[4:0] * 8))[7:0]

--------------------------------------------------------------------------------------------------------------

## _mm256_extract_epi16

--------------------------------------------------------------------------------------------------------------
Extract a 16-bit integer from "a", selected with "index", and store the result in "dst".

[algorithm]

dst[15:0] := (a[255:0] &gt;&gt; (index[3:0] * 16))[15:0]

--------------------------------------------------------------------------------------------------------------

## VPABSB - _mm256_abs_epi8

| VPABSB_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the absolute value of packed signed 8-bit integers in "a", and store the unsigned results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := ABS(a[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPABSW - _mm256_abs_epi16

| VPABSW_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the absolute value of packed signed 16-bit integers in "a", and store the unsigned results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := ABS(a[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPABSD - _mm256_abs_epi32

| VPABSD_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the absolute value of packed signed 32-bit integers in "a", and store the unsigned results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ABS(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDB - _mm256_add_epi8

| VPADDB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed 8-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := a[i+7:i] + b[i+7:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDW - _mm256_add_epi16

| VPADDW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed 16-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := a[i+15:i] + b[i+15:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDD - _mm256_add_epi32

| VPADDD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed 32-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[i+31:i] + b[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDQ - _mm256_add_epi64

| VPADDQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed 64-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[i+63:i] + b[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDSB - _mm256_adds_epi8

| VPADDSB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed 8-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := Saturate8( a[i+7:i] + b[i+7:i] )
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDSW - _mm256_adds_epi16

| VPADDSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed 16-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := Saturate16( a[i+15:i] + b[i+15:i] )
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDUSB - _mm256_adds_epu8

| VPADDUSB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed unsigned 8-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := SaturateU8( a[i+7:i] + b[i+7:i] )
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDUSW - _mm256_adds_epu16

| VPADDUSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Add packed unsigned 16-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := SaturateU16( a[i+15:i] + b[i+15:i] )
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPALIGNR - _mm256_alignr_epi8

| VPALIGNR_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Concatenate pairs of 16-byte blocks in "a" and "b" into a 32-byte temporary result, shift the result right by
"imm8" bytes, and store the low 16 bytes in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*128
    tmp[255:0] := ((a[i+127:i] &lt;&lt; 128)[255:0] OR b[i+127:i]) &gt;&gt; (imm8*8)
    dst[i+127:i] := tmp[127:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPAND - _mm256_and_si256

| VPAND_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 256 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[255:0] := (a[255:0] AND b[255:0])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPANDN - _mm256_andnot_si256

| VPANDN_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 256 bits (representing integer data) in "a" and then AND with "b", and store the
result in "dst".

[algorithm]

dst[255:0] := ((NOT a[255:0]) AND b[255:0])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPAVGB - _mm256_avg_epu8

| VPAVGB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Average packed unsigned 8-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := (a[i+7:i] + b[i+7:i] + 1) &gt;&gt; 1
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPAVGW - _mm256_avg_epu16

| VPAVGW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Average packed unsigned 16-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := (a[i+15:i] + b[i+15:i] + 1) &gt;&gt; 1
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPBLENDW - _mm256_blend_epi16

| VPBLENDW_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Blend packed 16-bit integers from "a" and "b" within 128-bit lanes using control mask "imm8", and store the
results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    IF imm8[j%8]
        dst[i+15:i] := b[i+15:i]
    ELSE
        dst[i+15:i] := a[i+15:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPBLENDD - _mm_blend_epi32

| VPBLENDD_XMMdq_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Blend packed 32-bit integers from "a" and "b" using control mask "imm8", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF imm8[j]
        dst[i+31:i] := b[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPBLENDD - _mm256_blend_epi32

| VPBLENDD_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Blend packed 32-bit integers from "a" and "b" using control mask "imm8", and store the results in "dst".

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

## VPBLENDVB - _mm256_blendv_epi8

| VPBLENDVB_YMMqq_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Blend packed 8-bit integers from "a" and "b" using "mask", and store the results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    IF mask[i+7]
        dst[i+7:i] := b[i+7:i]
    ELSE
        dst[i+7:i] := a[i+7:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPBROADCASTB - _mm_broadcastb_epi8

| VPBROADCASTB_XMMdq_XMMb

--------------------------------------------------------------------------------------------------------------
Broadcast the low packed 8-bit integer from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := a[7:0]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPBROADCASTB - _mm256_broadcastb_epi8

| VPBROADCASTB_YMMqq_XMMb

--------------------------------------------------------------------------------------------------------------
Broadcast the low packed 8-bit integer from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := a[7:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPBROADCASTD - _mm_broadcastd_epi32

| VPBROADCASTD_XMMdq_XMMd

--------------------------------------------------------------------------------------------------------------
Broadcast the low packed 32-bit integer from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPBROADCASTD - _mm256_broadcastd_epi32

| VPBROADCASTD_YMMqq_XMMd

--------------------------------------------------------------------------------------------------------------
Broadcast the low packed 32-bit integer from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPBROADCASTQ - _mm_broadcastq_epi64

| VPBROADCASTQ_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Broadcast the low packed 64-bit integer from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPBROADCASTQ - _mm256_broadcastq_epi64

| VPBROADCASTQ_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Broadcast the low packed 64-bit integer from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## MOVDDUP - _mm_broadcastsd_pd

| MOVDDUP_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Broadcast the low double-precision (64-bit) floating-point element from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTSD - _mm256_broadcastsd_pd

| VBROADCASTSD_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Broadcast the low double-precision (64-bit) floating-point element from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[63:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTI128 - _mm_broadcastsi128_si256

| VBROADCASTI128_YMMqq_MEMdq

--------------------------------------------------------------------------------------------------------------
Broadcast 128 bits of integer data from "a" to all 128-bit lanes in "dst".

[algorithm]

dst[127:0] := a[127:0]
dst[255:128] := a[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTI128 - _mm256_broadcastsi128_si256

| VBROADCASTI128_YMMqq_MEMdq

--------------------------------------------------------------------------------------------------------------
Broadcast 128 bits of integer data from "a" to all 128-bit lanes in "dst".

[algorithm]

dst[127:0] := a[127:0]
dst[255:128] := a[127:0]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTSS - _mm_broadcastss_ps

| VBROADCASTSS_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Broadcast the low single-precision (32-bit) floating-point element from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VBROADCASTSS - _mm256_broadcastss_ps

| VBROADCASTSS_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Broadcast the low single-precision (32-bit) floating-point element from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[31:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPBROADCASTW - _mm_broadcastw_epi16

| VPBROADCASTW_XMMdq_XMMw

--------------------------------------------------------------------------------------------------------------
Broadcast the low packed 16-bit integer from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := a[15:0]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPBROADCASTW - _mm256_broadcastw_epi16

| VPBROADCASTW_YMMqq_XMMw

--------------------------------------------------------------------------------------------------------------
Broadcast the low packed 16-bit integer from "a" to all elements of "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := a[15:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPEQB - _mm256_cmpeq_epi8

| VPCMPEQB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed 8-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := ( a[i+7:i] == b[i+7:i] ) ? 0xFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPEQW - _mm256_cmpeq_epi16

| VPCMPEQW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed 16-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := ( a[i+15:i] == b[i+15:i] ) ? 0xFFFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPEQD - _mm256_cmpeq_epi32

| VPCMPEQD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed 32-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ( a[i+31:i] == b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPEQQ - _mm256_cmpeq_epi64

| VPCMPEQQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed 64-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ( a[i+63:i] == b[i+63:i] ) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPGTB - _mm256_cmpgt_epi8

| VPCMPGTB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 8-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := ( a[i+7:i] &gt; b[i+7:i] ) ? 0xFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPGTW - _mm256_cmpgt_epi16

| VPCMPGTW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := ( a[i+15:i] &gt; b[i+15:i] ) ? 0xFFFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPGTD - _mm256_cmpgt_epi32

| VPCMPGTD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ( a[i+31:i] &gt; b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPGTQ - _mm256_cmpgt_epi64

| VPCMPGTQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 64-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ( a[i+63:i] &gt; b[i+63:i] ) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVSXWD - _mm256_cvtepi16_epi32

| VPMOVSXWD_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Sign extend packed 16-bit integers in "a" to packed 32-bit integers, and store the results in "dst".

[algorithm]

FOR j:= 0 to 7
    i := 32*j
    k := 16*j
    dst[i+31:i] := SignExtend32(a[k+15:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVSXWQ - _mm256_cvtepi16_epi64

| VPMOVSXWQ_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Sign extend packed 16-bit integers in "a" to packed 64-bit integers, and store the results in "dst".

[algorithm]

FOR j:= 0 to 3
    i := 64*j
    k := 16*j
    dst[i+63:i] := SignExtend64(a[k+15:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVSXDQ - _mm256_cvtepi32_epi64

| VPMOVSXDQ_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Sign extend packed 32-bit integers in "a" to packed 64-bit integers, and store the results in "dst".

[algorithm]

FOR j:= 0 to 3
    i := 64*j
    k := 32*j
    dst[i+63:i] := SignExtend64(a[k+31:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVSXBW - _mm256_cvtepi8_epi16

| VPMOVSXBW_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Sign extend packed 8-bit integers in "a" to packed 16-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    l := j*16
    dst[l+15:l] := SignExtend16(a[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVSXBD - _mm256_cvtepi8_epi32

| VPMOVSXBD_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Sign extend packed 8-bit integers in "a" to packed 32-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    k := 8*j
    dst[i+31:i] := SignExtend32(a[k+7:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVSXBQ - _mm256_cvtepi8_epi64

| VPMOVSXBQ_YMMqq_XMMd

--------------------------------------------------------------------------------------------------------------
Sign extend packed 8-bit integers in the low 8 bytes of "a" to packed 64-bit integers, and store the results
in "dst".

[algorithm]

FOR j := 0 to 3
    i := 64*j
    k := 8*j
    dst[i+63:i] := SignExtend64(a[k+7:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVZXWD - _mm256_cvtepu16_epi32

| VPMOVZXWD_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 16-bit integers in "a" to packed 32-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    k := 16*j
    dst[i+31:i] := ZeroExtend32(a[k+15:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVZXWQ - _mm256_cvtepu16_epi64

| VPMOVZXWQ_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 16-bit integers in "a" to packed 64-bit integers, and store the results in "dst".

[algorithm]

FOR j:= 0 to 3
    i := 64*j
    k := 16*j
    dst[i+63:i] := ZeroExtend64(a[k+15:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVZXDQ - _mm256_cvtepu32_epi64

| VPMOVZXDQ_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 32-bit integers in "a" to packed 64-bit integers, and store the results in "dst".

[algorithm]

FOR j:= 0 to 3
    i := 64*j
    k := 32*j
    dst[i+63:i] := ZeroExtend64(a[k+31:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVZXBW - _mm256_cvtepu8_epi16

| VPMOVZXBW_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 8-bit integers in "a" to packed 16-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    l := j*16
    dst[l+15:l] := ZeroExtend16(a[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVZXBD - _mm256_cvtepu8_epi32

| VPMOVZXBD_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 8-bit integers in "a" to packed 32-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    k := 8*j
    dst[i+31:i] := ZeroExtend32(a[k+7:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVZXBQ - _mm256_cvtepu8_epi64

| VPMOVZXBQ_YMMqq_XMMd

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 8-bit integers in the low 8 byte sof "a" to packed 64-bit integers, and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 64*j
    k := 8*j
    dst[i+63:i] := ZeroExtend64(a[k+7:k])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VEXTRACTI128 - _mm256_extracti128_si256

| VEXTRACTI128_XMMdq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract 128 bits (composed of integer data) from "a", selected with "imm8", and store the result in "dst".

[algorithm]

CASE imm8[0] OF
0: dst[127:0] := a[127:0]
1: dst[127:0] := a[255:128]
ESAC
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPHADDW - _mm256_hadd_epi16

| VPHADDW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in
"dst".

[algorithm]

dst[15:0] := a[31:16] + a[15:0]
dst[31:16] := a[63:48] + a[47:32]
dst[47:32] := a[95:80] + a[79:64]
dst[63:48] := a[127:112] + a[111:96]
dst[79:64] := b[31:16] + b[15:0]
dst[95:80] := b[63:48] + b[47:32]
dst[111:96] := b[95:80] + b[79:64]
dst[127:112] := b[127:112] + b[111:96]
dst[143:128] := a[159:144] + a[143:128]
dst[159:144] := a[191:176] + a[175:160]
dst[175:160] := a[223:208] + a[207:192]
dst[191:176] := a[255:240] + a[239:224]
dst[207:192] := b[159:144] + b[143:128]
dst[223:208] := b[191:176] + b[175:160]
dst[239:224] := b[223:208] + b[207:192]
dst[255:240] := b[255:240] + b[239:224]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPHADDD - _mm256_hadd_epi32

| VPHADDD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in
"dst".

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

## VPHADDSW - _mm256_hadds_epi16

| VPHADDSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the signed
16-bit results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[31:16] + a[15:0])
dst[31:16] := Saturate16(a[63:48] + a[47:32])
dst[47:32] := Saturate16(a[95:80] + a[79:64])
dst[63:48] := Saturate16(a[127:112] + a[111:96])
dst[79:64] := Saturate16(b[31:16] + b[15:0])
dst[95:80] := Saturate16(b[63:48] + b[47:32])
dst[111:96] := Saturate16(b[95:80] + b[79:64])
dst[127:112] := Saturate16(b[127:112] + b[111:96])
dst[143:128] := Saturate16(a[159:144] + a[143:128])
dst[159:144] := Saturate16(a[191:176] + a[175:160])
dst[175:160] := Saturate16(a[223:208] + a[207:192])
dst[191:176] := Saturate16(a[255:240] + a[239:224])
dst[207:192] := Saturate16(b[159:144] + b[143:128])
dst[223:208] := Saturate16(b[191:176] + b[175:160])
dst[239:224] := Saturate16(b[223:208] + b[207:192])
dst[255:240] := Saturate16(b[255:240] + b[239:224])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPHSUBW - _mm256_hsub_epi16

| VPHSUBW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in
"dst".

[algorithm]

dst[15:0] := a[15:0] - a[31:16]
dst[31:16] := a[47:32] - a[63:48]
dst[47:32] := a[79:64] - a[95:80]
dst[63:48] := a[111:96] - a[127:112]
dst[79:64] := b[15:0] - b[31:16]
dst[95:80] := b[47:32] - b[63:48]
dst[111:96] := b[79:64] - b[95:80]
dst[127:112] := b[111:96] - b[127:112]
dst[143:128] := a[143:128] - a[159:144]
dst[159:144] := a[175:160] - a[191:176]
dst[175:160] := a[207:192] - a[223:208]
dst[191:176] := a[239:224] - a[255:240]
dst[207:192] := b[143:128] - b[159:144]
dst[223:208] := b[175:160] - b[191:176]
dst[239:224] := b[207:192] - b[223:208]
dst[255:240] := b[239:224] - b[255:240]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPHSUBD - _mm256_hsub_epi32

| VPHSUBD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in
"dst".

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

## VPHSUBSW - _mm256_hsubs_epi16

| VPHSUBSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the
signed 16-bit results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[15:0] - a[31:16])
dst[31:16] := Saturate16(a[47:32] - a[63:48])
dst[47:32] := Saturate16(a[79:64] - a[95:80])
dst[63:48] := Saturate16(a[111:96] - a[127:112])
dst[79:64] := Saturate16(b[15:0] - b[31:16])
dst[95:80] := Saturate16(b[47:32] - b[63:48])
dst[111:96] := Saturate16(b[79:64] - b[95:80])
dst[127:112] := Saturate16(b[111:96] - b[127:112])
dst[143:128] := Saturate16(a[143:128] - a[159:144])
dst[159:144] := Saturate16(a[175:160] - a[191:176])
dst[175:160] := Saturate16(a[207:192] - a[223:208])
dst[191:176] := Saturate16(a[239:224] - a[255:240])
dst[207:192] := Saturate16(b[143:128] - b[159:144])
dst[223:208] := Saturate16(b[175:160] - b[191:176])
dst[239:224] := Saturate16(b[207:192] - b[223:208])
dst[255:240] := Saturate16(b[239:224] - b[255:240])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPD - _mm_i32gather_pd

| VGATHERDPD_XMMf64_MEMf64_XMMi64_VL128

--------------------------------------------------------------------------------------------------------------
Gather double-precision (64-bit) floating-point elements from memory using 32-bit indices. 64-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPD - _mm256_i32gather_pd

| VGATHERDPD_YMMf64_MEMf64_YMMi64_VL256

--------------------------------------------------------------------------------------------------------------
Gather double-precision (64-bit) floating-point elements from memory using 32-bit indices. 64-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPS - _mm_i32gather_ps

| VGATHERDPS_XMMf32_MEMf32_XMMi32_VL128

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPS - _mm256_i32gather_ps

| VGATHERDPS_YMMf32_MEMf32_YMMi32_VL256

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDD - _mm_i32gather_epi32

| VPGATHERDD_XMMu32_MEMd_XMMi32_VL128

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDD - _mm256_i32gather_epi32

| VPGATHERDD_YMMu32_MEMd_YMMi32_VL256

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDQ - _mm_i32gather_epi64

| VPGATHERDQ_XMMu64_MEMq_XMMi64_VL128

--------------------------------------------------------------------------------------------------------------
Gather 64-bit integers from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDQ - _mm256_i32gather_epi64

| VPGATHERDQ_YMMu64_MEMq_YMMi64_VL256

--------------------------------------------------------------------------------------------------------------
Gather 64-bit integers from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERQPD - _mm_i64gather_pd

| VGATHERQPD_XMMf64_MEMf64_XMMi64_VL128

--------------------------------------------------------------------------------------------------------------
Gather double-precision (64-bit) floating-point elements from memory using 64-bit indices. 64-bit elements are
loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERQPD - _mm256_i64gather_pd

| VGATHERQPD_YMMf64_MEMf64_YMMi64_VL256

--------------------------------------------------------------------------------------------------------------
Gather double-precision (64-bit) floating-point elements from memory using 64-bit indices. 64-bit elements are
loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERQPS - _mm_i64gather_ps

| VGATHERQPS_XMMf32_MEMf32_XMMi32_VL128

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 64-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:64] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERQPS - _mm256_i64gather_ps

| VGATHERQPS_XMMf32_MEMf32_XMMi32_VL256

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 64-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERQD - _mm_i64gather_epi32

| VPGATHERQD_XMMu32_MEMd_XMMi32_VL128

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:64] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERQD - _mm256_i64gather_epi32

| VPGATHERQD_XMMu32_MEMd_XMMi32_VL256

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+31:i] := MEM[addr+31:addr]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERQQ - _mm_i64gather_epi64

| VPGATHERQQ_XMMu64_MEMq_XMMi64_VL128

--------------------------------------------------------------------------------------------------------------
Gather 64-bit integers from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at
"base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERQQ - _mm256_i64gather_epi64

| VPGATHERQQ_YMMu64_MEMq_YMMi64_VL256

--------------------------------------------------------------------------------------------------------------
Gather 64-bit integers from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at
"base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst". "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*64
    m := j*64
    addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
    dst[i+63:i] := MEM[addr+63:addr]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VINSERTI128 - _mm256_inserti128_si256

| VINSERTI128_YMMqq_YMMqq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", then insert 128 bits (composed of integer data) from "b" into "dst" at the location
specified by "imm8".

[algorithm]

dst[255:0] := a[255:0]
CASE (imm8[0]) OF
0: dst[127:0] := b[127:0]
1: dst[255:128] := b[127:0]
ESAC
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMADDWD - _mm256_madd_epi16

| VPMADDWD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers.
Horizontally add adjacent pairs of intermediate 32-bit integers, and pack the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := SignExtend32(a[i+31:i+16]*b[i+31:i+16]) + SignExtend32(a[i+15:i]*b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMADDUBSW - _mm256_maddubs_epi16

| VPMADDUBSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Vertically multiply each unsigned 8-bit integer from "a" with the corresponding signed 8-bit integer from "b",
producing intermediate signed 16-bit integers. Horizontally add adjacent pairs of intermediate signed 16-bit
integers, and pack the saturated results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := Saturate16( a[i+15:i+8]*b[i+15:i+8] + a[i+7:i]*b[i+7:i] )
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPD - _mm_mask_i32gather_pd

| VGATHERDPD_XMMf64_MEMf64_XMMi64_VL128

--------------------------------------------------------------------------------------------------------------
Gather double-precision (64-bit) floating-point elements from memory using 32-bit indices. 64-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied
from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*64
    m := j*32
    IF mask[i+63]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
mask[MAX:128] := 0
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPD - _mm256_mask_i32gather_pd

| VGATHERDPD_YMMf64_MEMf64_YMMi64_VL256

--------------------------------------------------------------------------------------------------------------
Gather double-precision (64-bit) floating-point elements from memory using 32-bit indices. 64-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied
from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*64
    m := j*32
    IF mask[i+63]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
mask[MAX:256] := 0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPS - _mm_mask_i32gather_ps

| VGATHERDPS_XMMf32_MEMf32_XMMi32_VL128

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied
from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*32
    IF mask[i+31]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
mask[MAX:128] := 0
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERDPS - _mm256_mask_i32gather_ps

| VGATHERDPS_YMMf32_MEMf32_YMMi32_VL256

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 32-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 32-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied
from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*32
    IF mask[i+31]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
mask[MAX:256] := 0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDD - _mm_mask_i32gather_epi32

| VPGATHERDD_XMMu32_MEMd_XMMi32_VL128

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is
not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*32
    IF mask[i+31]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
mask[MAX:128] := 0
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDD - _mm256_mask_i32gather_epi32

| VPGATHERDD_YMMu32_MEMd_YMMi32_VL256

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 32-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is
not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*32
    IF mask[i+31]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
mask[MAX:256] := 0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDQ - _mm_mask_i32gather_epi64

| VPGATHERDQ_XMMu64_MEMq_XMMi64_VL128

--------------------------------------------------------------------------------------------------------------
Gather 64-bit integers from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is
not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*64
    m := j*32
    IF mask[i+63]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
mask[MAX:128] := 0
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERDQ - _mm256_mask_i32gather_epi64

| VPGATHERDQ_YMMu64_MEMq_YMMi64_VL256

--------------------------------------------------------------------------------------------------------------
Gather 64-bit integers from memory using 32-bit indices. 64-bit elements are loaded from addresses starting at
"base_addr" and offset by each 32-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is
not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*64
    m := j*32
    IF mask[i+63]
        addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
mask[MAX:256] := 0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERQPD - _mm_mask_i64gather_pd

| VGATHERQPD_XMMf64_MEMf64_XMMi64_VL128

--------------------------------------------------------------------------------------------------------------
Gather double-precision (64-bit) floating-point elements from memory using 64-bit indices. 64-bit elements are
loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied
from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*64
    m := j*64
    IF mask[i+63]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
mask[MAX:128] := 0
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERQPD - _mm256_mask_i64gather_pd

| VGATHERQPD_YMMf64_MEMf64_YMMi64_VL256

--------------------------------------------------------------------------------------------------------------
Gather double-precision (64-bit) floating-point elements from memory using 64-bit indices. 64-bit elements are
loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied
from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*64
    m := j*64
    IF mask[i+63]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
mask[MAX:256] := 0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERQPS - _mm_mask_i64gather_ps

| VGATHERQPS_XMMf32_MEMf32_XMMi32_VL128

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 64-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied
from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*32
    m := j*64
    IF mask[i+31]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
mask[MAX:64] := 0
dst[MAX:64] := 0

--------------------------------------------------------------------------------------------------------------

## VGATHERQPS - _mm256_mask_i64gather_ps

| VGATHERQPS_XMMf32_MEMf32_XMMi32_VL256

--------------------------------------------------------------------------------------------------------------
Gather single-precision (32-bit) floating-point elements from memory using 64-bit indices. 32-bit elements are
loaded from addresses starting at "base_addr" and offset by each 64-bit element in "vindex" (each index is
scaled by the factor in "scale"). Gathered elements are merged into "dst" using "mask" (elements are copied
from "src" when the highest bit is not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*64
    IF mask[i+31]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
mask[MAX:128] := 0
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERQD - _mm_mask_i64gather_epi32

| VPGATHERQD_XMMu32_MEMd_XMMi32_VL128

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is
not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*32
    m := j*64
    IF mask[i+31]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
mask[MAX:64] := 0
dst[MAX:64] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERQD - _mm256_mask_i64gather_epi32

| VPGATHERQD_XMMu32_MEMd_XMMi32_VL256

--------------------------------------------------------------------------------------------------------------
Gather 32-bit integers from memory using 64-bit indices. 32-bit elements are loaded from addresses starting at
"base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is
not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*64
    IF mask[i+31]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+31:i] := MEM[addr+31:addr]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
mask[MAX:128] := 0
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERQQ - _mm_mask_i64gather_epi64

| VPGATHERQQ_XMMu64_MEMq_XMMi64_VL128

--------------------------------------------------------------------------------------------------------------
Gather 64-bit integers from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at
"base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is
not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 1
    i := j*64
    m := j*64
    IF mask[i+63]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
mask[MAX:128] := 0
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPGATHERQQ - _mm256_mask_i64gather_epi64

| VPGATHERQQ_YMMu64_MEMq_YMMi64_VL256

--------------------------------------------------------------------------------------------------------------
Gather 64-bit integers from memory using 64-bit indices. 64-bit elements are loaded from addresses starting at
"base_addr" and offset by each 64-bit element in "vindex" (each index is scaled by the factor in "scale").
Gathered elements are merged into "dst" using "mask" (elements are copied from "src" when the highest bit is
not set in the corresponding element). "scale" should be 1, 2, 4 or 8.

[algorithm]

FOR j := 0 to 3
    i := j*64
    m := j*64
    IF mask[i+63]
        addr := base_addr + vindex[m+63:m] * ZeroExtend64(scale) * 8
        dst[i+63:i] := MEM[addr+63:addr]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
mask[MAX:256] := 0
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMASKMOVD - _mm_maskload_epi32

| VPMASKMOVD_XMMdq_XMMdq_MEMdq

--------------------------------------------------------------------------------------------------------------
Load packed 32-bit integers from memory into "dst" using "mask" (elements are zeroed out when the highest bit
is not set in the corresponding element).

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

## VPMASKMOVD - _mm256_maskload_epi32

| VPMASKMOVD_YMMqq_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load packed 32-bit integers from memory into "dst" using "mask" (elements are zeroed out when the highest bit
is not set in the corresponding element).

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

## VPMASKMOVQ - _mm_maskload_epi64

| VPMASKMOVQ_XMMdq_XMMdq_MEMdq

--------------------------------------------------------------------------------------------------------------
Load packed 64-bit integers from memory into "dst" using "mask" (elements are zeroed out when the highest bit
is not set in the corresponding element).

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

## VPMASKMOVQ - _mm256_maskload_epi64

| VPMASKMOVQ_YMMqq_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load packed 64-bit integers from memory into "dst" using "mask" (elements are zeroed out when the highest bit
is not set in the corresponding element).

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

## VPMASKMOVD - _mm_maskstore_epi32

| VPMASKMOVD_MEMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Store packed 32-bit integers from "a" into memory using "mask" (elements are not stored when the highest bit
is not set in the corresponding element).

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF mask[i+31]
        MEM[mem_addr+i+31:mem_addr+i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPMASKMOVD - _mm256_maskstore_epi32

| VPMASKMOVD_MEMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store packed 32-bit integers from "a" into memory using "mask" (elements are not stored when the highest bit
is not set in the corresponding element).

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF mask[i+31]
        MEM[mem_addr+i+31:mem_addr+i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPMASKMOVQ - _mm_maskstore_epi64

| VPMASKMOVQ_MEMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Store packed 64-bit integers from "a" into memory using "mask" (elements are not stored when the highest bit
is not set in the corresponding element).

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF mask[i+63]
        MEM[mem_addr+i+63:mem_addr+i] := a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPMASKMOVQ - _mm256_maskstore_epi64

| VPMASKMOVQ_MEMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Store packed 64-bit integers from "a" into memory using "mask" (elements are not stored when the highest bit
is not set in the corresponding element).

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF mask[i+63]
        MEM[mem_addr+i+63:mem_addr+i] := a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPMAXSB - _mm256_max_epi8

| VPMAXSB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 8-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := MAX(a[i+7:i], b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMAXSW - _mm256_max_epi16

| VPMAXSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := MAX(a[i+15:i], b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMAXSD - _mm256_max_epi32

| VPMAXSD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMAXUB - _mm256_max_epu8

| VPMAXUB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 8-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := MAX(a[i+7:i], b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMAXUW - _mm256_max_epu16

| VPMAXUW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 16-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := MAX(a[i+15:i], b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMAXUD - _mm256_max_epu32

| VPMAXUD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINSB - _mm256_min_epi8

| VPMINSB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 8-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := MIN(a[i+7:i], b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINSW - _mm256_min_epi16

| VPMINSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := MIN(a[i+15:i], b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINSD - _mm256_min_epi32

| VPMINSD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINUB - _mm256_min_epu8

| VPMINUB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 8-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := MIN(a[i+7:i], b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINUW - _mm256_min_epu16

| VPMINUW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 16-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := MIN(a[i+15:i], b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMINUD - _mm256_min_epu32

| VPMINUD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMOVMSKB - _mm256_movemask_epi8

| VPMOVMSKB_GPR32d_YMMqq

--------------------------------------------------------------------------------------------------------------
Create mask from the most significant bit of each 8-bit element in "a", and store the result in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[j] := a[i+7]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMPSADBW - _mm256_mpsadbw_epu8

| VMPSADBW_YMMqq_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Compute the sum of absolute differences (SADs) of quadruplets of unsigned 8-bit integers in "a" compared to
those in "b", and store the 16-bit results in "dst".
	Eight SADs are performed for each 128-bit lane using one
quadruplet from "b" and eight quadruplets from "a". One quadruplet is selected from "b" starting at on the
offset specified in "imm8". Eight quadruplets are formed from sequential 8-bit integers selected from "a"
starting at the offset specified in "imm8".

[algorithm]

DEFINE MPSADBW(a[127:0], b[127:0], imm8[2:0]) {
    a_offset := imm8[2]*32
    b_offset := imm8[1:0]*32
    FOR j := 0 to 7
        i := j*8
        k := a_offset+i
        l := b_offset
        tmp[i*2+15:i*2] := ABS(Signed(a[k+7:k] - b[l+7:l])) + ABS(Signed(a[k+15:k+8] - b[l+15:l+8])) + \
                           ABS(Signed(a[k+23:k+16] - b[l+23:l+16])) + ABS(Signed(a[k+31:k+24] - b[l+31:l+24]))
    ENDFOR
    RETURN tmp[127:0]
}
dst[127:0] := MPSADBW(a[127:0], b[127:0], imm8[2:0])
dst[255:128] := MPSADBW(a[255:128], b[255:128], imm8[5:3])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULDQ - _mm256_mul_epi32

| VPMULDQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply the low signed 32-bit integers from each packed 64-bit element in "a" and "b", and store the signed
64-bit results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := SignExtend64(a[i+31:i]) * SignExtend64(b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULUDQ - _mm256_mul_epu32

| VPMULUDQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply the low unsigned 32-bit integers from each packed 64-bit element in "a" and "b", and store the
unsigned 64-bit results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[i+31:i] * b[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULHW - _mm256_mulhi_epi16

| VPMULHW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply the packed signed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store
the high 16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    tmp[31:0] := SignExtend32(a[i+15:i]) * SignExtend32(b[i+15:i])
    dst[i+15:i] := tmp[31:16]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULHUW - _mm256_mulhi_epu16

| VPMULHUW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply the packed unsigned 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store
the high 16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    tmp[31:0] := a[i+15:i] * b[i+15:i]
    dst[i+15:i] := tmp[31:16]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULHRSW - _mm256_mulhrs_epi16

| VPMULHRSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers. Truncate
each intermediate integer to the 18 most significant bits, round by adding 1, and store bits [16:1] to "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    tmp[31:0] := ((SignExtend32(a[i+15:i]) * SignExtend32(b[i+15:i])) &gt;&gt; 14) + 1
    dst[i+15:i] := tmp[16:1]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULLW - _mm256_mullo_epi16

| VPMULLW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply the packed signed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store
the low 16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    tmp[31:0] := SignExtend32(a[i+15:i]) * SignExtend32(b[i+15:i])
    dst[i+15:i] := tmp[15:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULLD - _mm256_mullo_epi32

| VPMULLD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply the packed signed 32-bit integers in "a" and "b", producing intermediate 64-bit integers, and store
the low 32 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    tmp[63:0] := a[i+31:i] * b[i+31:i]
    dst[i+31:i] := tmp[31:0]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPOR - _mm256_or_si256

| VPOR_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of 256 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[255:0] := (a[255:0] OR b[255:0])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSSWB - _mm256_packs_epi16

| VPACKSSWB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using signed saturation, and
store the results in "dst".

[algorithm]

dst[7:0] := Saturate8(a[15:0])
dst[15:8] := Saturate8(a[31:16])
dst[23:16] := Saturate8(a[47:32])
dst[31:24] := Saturate8(a[63:48])
dst[39:32] := Saturate8(a[79:64])
dst[47:40] := Saturate8(a[95:80])
dst[55:48] := Saturate8(a[111:96])
dst[63:56] := Saturate8(a[127:112])
dst[71:64] := Saturate8(b[15:0])
dst[79:72] := Saturate8(b[31:16])
dst[87:80] := Saturate8(b[47:32])
dst[95:88] := Saturate8(b[63:48])
dst[103:96] := Saturate8(b[79:64])
dst[111:104] := Saturate8(b[95:80])
dst[119:112] := Saturate8(b[111:96])
dst[127:120] := Saturate8(b[127:112])
dst[135:128] := Saturate8(a[143:128])
dst[143:136] := Saturate8(a[159:144])
dst[151:144] := Saturate8(a[175:160])
dst[159:152] := Saturate8(a[191:176])
dst[167:160] := Saturate8(a[207:192])
dst[175:168] := Saturate8(a[223:208])
dst[183:176] := Saturate8(a[239:224])
dst[191:184] := Saturate8(a[255:240])
dst[199:192] := Saturate8(b[143:128])
dst[207:200] := Saturate8(b[159:144])
dst[215:208] := Saturate8(b[175:160])
dst[223:216] := Saturate8(b[191:176])
dst[231:224] := Saturate8(b[207:192])
dst[239:232] := Saturate8(b[223:208])
dst[247:240] := Saturate8(b[239:224])
dst[255:248] := Saturate8(b[255:240])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSSDW - _mm256_packs_epi32

| VPACKSSDW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using signed saturation, and
store the results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[31:0])
dst[31:16] := Saturate16(a[63:32])
dst[47:32] := Saturate16(a[95:64])
dst[63:48] := Saturate16(a[127:96])
dst[79:64] := Saturate16(b[31:0])
dst[95:80] := Saturate16(b[63:32])
dst[111:96] := Saturate16(b[95:64])
dst[127:112] := Saturate16(b[127:96])
dst[143:128] := Saturate16(a[159:128])
dst[159:144] := Saturate16(a[191:160])
dst[175:160] := Saturate16(a[223:192])
dst[191:176] := Saturate16(a[255:224])
dst[207:192] := Saturate16(b[159:128])
dst[223:208] := Saturate16(b[191:160])
dst[239:224] := Saturate16(b[223:192])
dst[255:240] := Saturate16(b[255:224])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKUSWB - _mm256_packus_epi16

| VPACKUSWB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using unsigned saturation, and
store the results in "dst".

[algorithm]

dst[7:0] := SaturateU8(a[15:0])
dst[15:8] := SaturateU8(a[31:16])
dst[23:16] := SaturateU8(a[47:32])
dst[31:24] := SaturateU8(a[63:48])
dst[39:32] := SaturateU8(a[79:64])
dst[47:40] := SaturateU8(a[95:80])
dst[55:48] := SaturateU8(a[111:96])
dst[63:56] := SaturateU8(a[127:112])
dst[71:64] := SaturateU8(b[15:0])
dst[79:72] := SaturateU8(b[31:16])
dst[87:80] := SaturateU8(b[47:32])
dst[95:88] := SaturateU8(b[63:48])
dst[103:96] := SaturateU8(b[79:64])
dst[111:104] := SaturateU8(b[95:80])
dst[119:112] := SaturateU8(b[111:96])
dst[127:120] := SaturateU8(b[127:112])
dst[135:128] := SaturateU8(a[143:128])
dst[143:136] := SaturateU8(a[159:144])
dst[151:144] := SaturateU8(a[175:160])
dst[159:152] := SaturateU8(a[191:176])
dst[167:160] := SaturateU8(a[207:192])
dst[175:168] := SaturateU8(a[223:208])
dst[183:176] := SaturateU8(a[239:224])
dst[191:184] := SaturateU8(a[255:240])
dst[199:192] := SaturateU8(b[143:128])
dst[207:200] := SaturateU8(b[159:144])
dst[215:208] := SaturateU8(b[175:160])
dst[223:216] := SaturateU8(b[191:176])
dst[231:224] := SaturateU8(b[207:192])
dst[239:232] := SaturateU8(b[223:208])
dst[247:240] := SaturateU8(b[239:224])
dst[255:248] := SaturateU8(b[255:240])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKUSDW - _mm256_packus_epi32

| VPACKUSDW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using unsigned saturation,
and store the results in "dst".

[algorithm]

dst[15:0] := SaturateU16(a[31:0])
dst[31:16] := SaturateU16(a[63:32])
dst[47:32] := SaturateU16(a[95:64])
dst[63:48] := SaturateU16(a[127:96])
dst[79:64] := SaturateU16(b[31:0])
dst[95:80] := SaturateU16(b[63:32])
dst[111:96] := SaturateU16(b[95:64])
dst[127:112] := SaturateU16(b[127:96])
dst[143:128] := SaturateU16(a[159:128])
dst[159:144] := SaturateU16(a[191:160])
dst[175:160] := SaturateU16(a[223:192])
dst[191:176] := SaturateU16(a[255:224])
dst[207:192] := SaturateU16(b[159:128])
dst[223:208] := SaturateU16(b[191:160])
dst[239:224] := SaturateU16(b[223:192])
dst[255:240] := SaturateU16(b[255:224])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERM2I128 - _mm256_permute2x128_si256

| VPERM2I128_YMMqq_YMMqq_YMMqq_IMMb

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

## VPERMQ - _mm256_permute4x64_epi64

| VPERMQ_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 64-bit integers in "a" across lanes using the control in "imm8", and store the results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[63:0] := src[63:0]
    1:    tmp[63:0] := src[127:64]
    2:    tmp[63:0] := src[191:128]
    3:    tmp[63:0] := src[255:192]
    ESAC
    RETURN tmp[63:0]
}
dst[63:0] := SELECT4(a[255:0], imm8[1:0])
dst[127:64] := SELECT4(a[255:0], imm8[3:2])
dst[191:128] := SELECT4(a[255:0], imm8[5:4])
dst[255:192] := SELECT4(a[255:0], imm8[7:6])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMPD - _mm256_permute4x64_pd

| VPERMPD_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle double-precision (64-bit) floating-point elements in "a" across lanes using the control in "imm8", and
store the results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[63:0] := src[63:0]
    1:    tmp[63:0] := src[127:64]
    2:    tmp[63:0] := src[191:128]
    3:    tmp[63:0] := src[255:192]
    ESAC
    RETURN tmp[63:0]
}
dst[63:0] := SELECT4(a[255:0], imm8[1:0])
dst[127:64] := SELECT4(a[255:0], imm8[3:2])
dst[191:128] := SELECT4(a[255:0], imm8[5:4])
dst[255:192] := SELECT4(a[255:0], imm8[7:6])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMD - _mm256_permutevar8x32_epi32

| VPERMD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shuffle 32-bit integers in "a" across lanes using the corresponding index in "idx", and store the results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    id := idx[i+2:i]*32
    dst[i+31:i] := a[id+31:id]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMPS - _mm256_permutevar8x32_ps

| VPERMPS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shuffle single-precision (32-bit) floating-point elements in "a" across lanes using the corresponding index in
"idx".

[algorithm]

FOR j := 0 to 7
    i := j*32
    id := idx[i+2:i]*32
    dst[i+31:i] := a[id+31:id]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSADBW - _mm256_sad_epu8

| VPSADBW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the absolute differences of packed unsigned 8-bit integers in "a" and "b", then horizontally sum each
consecutive 8 differences to produce four unsigned 16-bit integers, and pack these unsigned 16-bit integers in
the low 16 bits of 64-bit elements in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    tmp[i+7:i] := ABS(a[i+7:i] - b[i+7:i])
ENDFOR
FOR j := 0 to 3
    i := j*64
    dst[i+15:i] := tmp[i+7:i] + tmp[i+15:i+8] + tmp[i+23:i+16] + tmp[i+31:i+24] + \
                   tmp[i+39:i+32] + tmp[i+47:i+40] + tmp[i+55:i+48] + tmp[i+63:i+56]
    dst[i+63:i+16] := 0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSHUFD - _mm256_shuffle_epi32

| VPSHUFD_YMMqq_YMMqq_IMMb

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
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSHUFB - _mm256_shuffle_epi8

| VPSHUFB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shuffle 8-bit integers in "a" within 128-bit lanes according to shuffle control mask in the corresponding
8-bit element of "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    IF b[i+7] == 1
        dst[i+7:i] := 0
    ELSE
        index[3:0] := b[i+3:i]
        dst[i+7:i] := a[index*8+7:index*8]
    FI
    IF b[128+i+7] == 1
        dst[128+i+7:128+i] := 0
    ELSE
        index[3:0] := b[128+i+3:128+i]
        dst[128+i+7:128+i] := a[128+index*8+7:128+index*8]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSHUFHW - _mm256_shufflehi_epi16

| VPSHUFHW_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 16-bit integers in the high 64 bits of 128-bit lanes of "a" using the control in "imm8". Store the
results in the high 64 bits of 128-bit lanes of "dst", with the low 64 bits of 128-bit lanes being copied from
from "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]
dst[79:64] := (a &gt;&gt; (imm8[1:0] * 16))[79:64]
dst[95:80] := (a &gt;&gt; (imm8[3:2] * 16))[79:64]
dst[111:96] := (a &gt;&gt; (imm8[5:4] * 16))[79:64]
dst[127:112] := (a &gt;&gt; (imm8[7:6] * 16))[79:64]
dst[191:128] := a[191:128]
dst[207:192] := (a &gt;&gt; (imm8[1:0] * 16))[207:192]
dst[223:208] := (a &gt;&gt; (imm8[3:2] * 16))[207:192]
dst[239:224] := (a &gt;&gt; (imm8[5:4] * 16))[207:192]
dst[255:240] := (a &gt;&gt; (imm8[7:6] * 16))[207:192]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSHUFLW - _mm256_shufflelo_epi16

| VPSHUFLW_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 16-bit integers in the low 64 bits of 128-bit lanes of "a" using the control in "imm8". Store the
results in the low 64 bits of 128-bit lanes of "dst", with the high 64 bits of 128-bit lanes being copied from
from "a" to "dst".

[algorithm]

dst[15:0] := (a &gt;&gt; (imm8[1:0] * 16))[15:0]
dst[31:16] := (a &gt;&gt; (imm8[3:2] * 16))[15:0]
dst[47:32] := (a &gt;&gt; (imm8[5:4] * 16))[15:0]
dst[63:48] := (a &gt;&gt; (imm8[7:6] * 16))[15:0]
dst[127:64] := a[127:64]
dst[143:128] := (a &gt;&gt; (imm8[1:0] * 16))[143:128]
dst[159:144] := (a &gt;&gt; (imm8[3:2] * 16))[143:128]
dst[175:160] := (a &gt;&gt; (imm8[5:4] * 16))[143:128]
dst[191:176] := (a &gt;&gt; (imm8[7:6] * 16))[143:128]
dst[255:192] := a[255:192]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSIGNB - _mm256_sign_epi8

| VPSIGNB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Negate packed signed 8-bit integers in "a" when the corresponding signed 8-bit integer in "b" is negative, and
store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.

[algorithm]

FOR j := 0 to 31
    i := j*8
    IF b[i+7:i] &lt; 0
        dst[i+7:i] := -(a[i+7:i])
    ELSE IF b[i+7:i] == 0
        dst[i+7:i] := 0
    ELSE
        dst[i+7:i] := a[i+7:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSIGNW - _mm256_sign_epi16

| VPSIGNW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Negate packed signed 16-bit integers in "a" when the corresponding signed 16-bit integer in "b" is negative,
and store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.

[algorithm]

FOR j := 0 to 15
    i := j*16
    IF b[i+15:i] &lt; 0
        dst[i+15:i] := -(a[i+15:i])
    ELSE IF b[i+15:i] == 0
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := a[i+15:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSIGND - _mm256_sign_epi32

| VPSIGND_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Negate packed signed 32-bit integers in "a" when the corresponding signed 32-bit integer in "b" is negative,
and store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF b[i+31:i] &lt; 0
        dst[i+31:i] := -(a[i+31:i])
    ELSE IF b[i+31:i] == 0
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLDQ - _mm256_slli_si256

| VPSLLDQ_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift 128-bit lanes in "a" left by "imm8" bytes while shifting in zeros, and store the results in "dst".

[algorithm]

tmp := imm8[7:0]
IF tmp &gt; 15
    tmp := 16
FI
dst[127:0] := a[127:0] &lt;&lt; (tmp*8)
dst[255:128] := a[255:128] &lt;&lt; (tmp*8)
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLDQ - _mm256_bslli_epi128

| VPSLLDQ_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift 128-bit lanes in "a" left by "imm8" bytes while shifting in zeros, and store the results in "dst".

[algorithm]

tmp := imm8[7:0]
IF tmp &gt; 15
    tmp := 16
FI
dst[127:0] := a[127:0] &lt;&lt; (tmp*8)
dst[255:128] := a[255:128] &lt;&lt; (tmp*8)
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLW - _mm256_sll_epi16

| VPSLLW_YMMqq_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &lt;&lt; count[63:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLW - _mm256_slli_epi16

| VPSLLW_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLD - _mm256_sll_epi32

| VPSLLD_YMMqq_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; count[63:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLD - _mm256_slli_epi32

| VPSLLD_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLQ - _mm256_sll_epi64

| VPSLLQ_YMMqq_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF count[63:0] &gt; 63
        dst[i+63:i] := 0
    ELSE
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &lt;&lt; count[63:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLQ - _mm256_slli_epi64

| VPSLLQ_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF imm8[7:0] &gt; 63
        dst[i+63:i] := 0
    ELSE
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLVD - _mm_sllv_epi32

| VPSLLVD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by the amount specified by the corresponding element in "count" while
shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF count[i+31:i] &lt; 32
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; count[i+31:i])
    ELSE
        dst[i+31:i] := 0
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLVD - _mm256_sllv_epi32

| VPSLLVD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by the amount specified by the corresponding element in "count" while
shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF count[i+31:i] &lt; 32
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; count[i+31:i])
    ELSE
        dst[i+31:i] := 0
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLVQ - _mm_sllv_epi64

| VPSLLVQ_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" left by the amount specified by the corresponding element in "count" while
shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF count[i+63:i] &lt; 64
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &lt;&lt; count[i+63:i])
    ELSE
        dst[i+63:i] := 0
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPSLLVQ - _mm256_sllv_epi64

| VPSLLVQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" left by the amount specified by the corresponding element in "count" while
shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF count[i+63:i] &lt; 64
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &lt;&lt; count[i+63:i])
    ELSE
        dst[i+63:i] := 0
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAW - _mm256_sra_epi16

| VPSRAW_YMMqq_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "count" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := (a[i+15] ? 0xFFFF : 0x0)
    ELSE
        dst[i+15:i] := SignExtend16(a[i+15:i] &gt;&gt; count[63:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAW - _mm256_srai_epi16

| VPSRAW_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := (a[i+15] ? 0xFFFF : 0x0)
    ELSE
        dst[i+15:i] := SignExtend16(a[i+15:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAD - _mm256_sra_epi32

| VPSRAD_YMMqq_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "count" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
    ELSE
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; count[63:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAD - _mm256_srai_epi32

| VPSRAD_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
    ELSE
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAVD - _mm_srav_epi32

| VPSRAVD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in sign bits, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF count[i+31:i] &lt; 32
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; count[i+31:i])
    ELSE
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0)
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRAVD - _mm256_srav_epi32

| VPSRAVD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in sign bits, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF count[i+31:i] &lt; 32
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; count[i+31:i])
    ELSE
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0)
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLDQ - _mm256_srli_si256

| VPSRLDQ_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift 128-bit lanes in "a" right by "imm8" bytes while shifting in zeros, and store the results in "dst".

[algorithm]

tmp := imm8[7:0]
IF tmp &gt; 15
    tmp := 16
FI
dst[127:0] := a[127:0] &gt;&gt; (tmp*8)
dst[255:128] := a[255:128] &gt;&gt; (tmp*8)
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLDQ - _mm256_bsrli_epi128

| VPSRLDQ_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift 128-bit lanes in "a" right by "imm8" bytes while shifting in zeros, and store the results in "dst".

[algorithm]

tmp := imm8[7:0]
IF tmp &gt; 15
    tmp := 16
FI
dst[127:0] := a[127:0] &gt;&gt; (tmp*8)
dst[255:128] := a[255:128] &gt;&gt; (tmp*8)
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLW - _mm256_srl_epi16

| VPSRLW_YMMqq_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &gt;&gt; count[63:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLW - _mm256_srli_epi16

| VPSRLW_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLD - _mm256_srl_epi32

| VPSRLD_YMMqq_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; count[63:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLD - _mm256_srli_epi32

| VPSRLD_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLQ - _mm256_srl_epi64

| VPSRLQ_YMMqq_YMMqq_XMMq

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF count[63:0] &gt; 63
        dst[i+63:i] := 0
    ELSE
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &gt;&gt; count[63:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLQ - _mm256_srli_epi64

| VPSRLQ_YMMqq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF imm8[7:0] &gt; 63
        dst[i+63:i] := 0
    ELSE
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLVD - _mm_srlv_epi32

| VPSRLVD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF count[i+31:i] &lt; 32
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; count[i+31:i])
    ELSE
        dst[i+31:i] := 0
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLVD - _mm256_srlv_epi32

| VPSRLVD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF count[i+31:i] &lt; 32
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; count[i+31:i])
    ELSE
        dst[i+31:i] := 0
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLVQ - _mm_srlv_epi64

| VPSRLVQ_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF count[i+63:i] &lt; 64
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &gt;&gt; count[i+63:i])
    ELSE
        dst[i+63:i] := 0
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPSRLVQ - _mm256_srlv_epi64

| VPSRLVQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" right by the amount specified by the corresponding element in "count"
while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF count[i+63:i] &lt; 64
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &gt;&gt; count[i+63:i])
    ELSE
        dst[i+63:i] := 0
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVNTDQA - _mm256_stream_load_si256

| VMOVNTDQA_YMMqq_MEMqq

--------------------------------------------------------------------------------------------------------------
Load 256-bits of integer data from memory into "dst" using a non-temporal memory hint.
	"mem_addr" must be
aligned on a 32-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[255:0] := MEM[mem_addr+255:mem_addr]
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBB - _mm256_sub_epi8

| VPSUBB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed 8-bit integers in "b" from packed 8-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := a[i+7:i] - b[i+7:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBW - _mm256_sub_epi16

| VPSUBW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed 16-bit integers in "b" from packed 16-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := a[i+15:i] - b[i+15:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBD - _mm256_sub_epi32

| VPSUBD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed 32-bit integers in "b" from packed 32-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := a[i+31:i] - b[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBQ - _mm256_sub_epi64

| VPSUBQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed 64-bit integers in "b" from packed 64-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := a[i+63:i] - b[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBSB - _mm256_subs_epi8

| VPSUBSB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed signed 8-bit integers in "b" from packed 8-bit integers in "a" using saturation, and store the
results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := Saturate8(a[i+7:i] - b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBSW - _mm256_subs_epi16

| VPSUBSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed signed 16-bit integers in "b" from packed 16-bit integers in "a" using saturation, and store
the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := Saturate16(a[i+15:i] - b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBUSB - _mm256_subs_epu8

| VPSUBUSB_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed unsigned 8-bit integers in "b" from packed unsigned 8-bit integers in "a" using saturation,
and store the results in "dst".

[algorithm]

FOR j := 0 to 31
    i := j*8
    dst[i+7:i] := SaturateU8(a[i+7:i] - b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBUSW - _mm256_subs_epu16

| VPSUBUSW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Subtract packed unsigned 16-bit integers in "b" from packed unsigned 16-bit integers in "a" using saturation,
and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*16
    dst[i+15:i] := SaturateU16(a[i+15:i] - b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPXOR - _mm256_xor_si256

| VPXOR_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of 256 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[255:0] := (a[255:0] XOR b[255:0])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPUNPCKHBW - _mm256_unpackhi_epi8

| VPUNPCKHBW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 8-bit integers from the high half of each 128-bit lane in "a" and "b", and store the
results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_BYTES(src1[127:0], src2[127:0]) {
    dst[7:0] := src1[71:64] 
    dst[15:8] := src2[71:64] 
    dst[23:16] := src1[79:72] 
    dst[31:24] := src2[79:72] 
    dst[39:32] := src1[87:80] 
    dst[47:40] := src2[87:80] 
    dst[55:48] := src1[95:88] 
    dst[63:56] := src2[95:88] 
    dst[71:64] := src1[103:96] 
    dst[79:72] := src2[103:96] 
    dst[87:80] := src1[111:104] 
    dst[95:88] := src2[111:104] 
    dst[103:96] := src1[119:112] 
    dst[111:104] := src2[119:112] 
    dst[119:112] := src1[127:120] 
    dst[127:120] := src2[127:120] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_HIGH_BYTES(a[127:0], b[127:0])
dst[255:128] := INTERLEAVE_HIGH_BYTES(a[255:128], b[255:128])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPUNPCKHWD - _mm256_unpackhi_epi16

| VPUNPCKHWD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 16-bit integers from the high half of each 128-bit lane in "a" and "b", and store the
results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_WORDS(src1[127:0], src2[127:0]) {
    dst[15:0] := src1[79:64]
    dst[31:16] := src2[79:64] 
    dst[47:32] := src1[95:80] 
    dst[63:48] := src2[95:80] 
    dst[79:64] := src1[111:96] 
    dst[95:80] := src2[111:96] 
    dst[111:96] := src1[127:112] 
    dst[127:112] := src2[127:112] 
    RETURN dst[127:0]
}
dst[127:0] := INTERLEAVE_HIGH_WORDS(a[127:0], b[127:0])
dst[255:128] := INTERLEAVE_HIGH_WORDS(a[255:128], b[255:128])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPUNPCKHDQ - _mm256_unpackhi_epi32

| VPUNPCKHDQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 32-bit integers from the high half of each 128-bit lane in "a" and "b", and store the
results in "dst".

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

## VPUNPCKHQDQ - _mm256_unpackhi_epi64

| VPUNPCKHQDQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 64-bit integers from the high half of each 128-bit lane in "a" and "b", and store the
results in "dst".

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

## VPUNPCKLBW - _mm256_unpacklo_epi8

| VPUNPCKLBW_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 8-bit integers from the low half of each 128-bit lane in "a" and "b", and store the
results in "dst".

[algorithm]

DEFINE INTERLEAVE_BYTES(src1[127:0], src2[127:0]) {
    dst[7:0] := src1[7:0] 
    dst[15:8] := src2[7:0] 
    dst[23:16] := src1[15:8] 
    dst[31:24] := src2[15:8] 
    dst[39:32] := src1[23:16] 
    dst[47:40] := src2[23:16] 
    dst[55:48] := src1[31:24] 
    dst[63:56] := src2[31:24] 
    dst[71:64] := src1[39:32]
    dst[79:72] := src2[39:32] 
    dst[87:80] := src1[47:40] 
    dst[95:88] := src2[47:40] 
    dst[103:96] := src1[55:48] 
    dst[111:104] := src2[55:48] 
    dst[119:112] := src1[63:56] 
    dst[127:120] := src2[63:56] 
    RETURN dst[127:0]
}
dst[127:0] := INTERLEAVE_BYTES(a[127:0], b[127:0])
dst[255:128] := INTERLEAVE_BYTES(a[255:128], b[255:128])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPUNPCKLWD - _mm256_unpacklo_epi16

| VPUNPCKLWD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 16-bit integers from the low half of each 128-bit lane in "a" and "b", and store the
results in "dst".

[algorithm]

DEFINE INTERLEAVE_WORDS(src1[127:0], src2[127:0]) {
    dst[15:0] := src1[15:0] 
    dst[31:16] := src2[15:0] 
    dst[47:32] := src1[31:16] 
    dst[63:48] := src2[31:16] 
    dst[79:64] := src1[47:32] 
    dst[95:80] := src2[47:32] 
    dst[111:96] := src1[63:48] 
    dst[127:112] := src2[63:48] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_WORDS(a[127:0], b[127:0])
dst[255:128] := INTERLEAVE_WORDS(a[255:128], b[255:128])
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPUNPCKLDQ - _mm256_unpacklo_epi32

| VPUNPCKLDQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 32-bit integers from the low half of each 128-bit lane in "a" and "b", and store the
results in "dst".

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

## VPUNPCKLQDQ - _mm256_unpacklo_epi64

| VPUNPCKLQDQ_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 64-bit integers from the low half of each 128-bit lane in "a" and "b", and store the
results in "dst".

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
