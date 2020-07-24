# V

## VAESENCLAST - _mm512_aesenclast_epi128

| VAESENCLAST_ZMMu128_ZMMu128_ZMMu128_AVX512

--------------------------------------------------------------------------------------------------------------
Perform the last round of an AES encryption flow on data (state) in "a" using the round key in "RoundKey", and
store the results in "dst"."

[algorithm]

FOR j := 0 to 3
    i := j*128
    a[i+127:i] := ShiftRows(a[i+127:i])
    a[i+127:i] := SubBytes(a[i+127:i])
    dst[i+127:i] := a[i+127:i] XOR RoundKey[i+127:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VAESENC - _mm512_aesenc_epi128

| VAESENC_ZMMu128_ZMMu128_ZMMu128_AVX512

--------------------------------------------------------------------------------------------------------------
Perform one round of an AES encryption flow on data (state) in "a" using the round key in "RoundKey", and
store the results in "dst"."

[algorithm]

FOR j := 0 to 3
    i := j*128
    a[i+127:i] := ShiftRows(a[i+127:i])
    a[i+127:i] := SubBytes(a[i+127:i])
    a[i+127:i] := MixColumns(a[i+127:i])
    dst[i+127:i] := a[i+127:i] XOR RoundKey[i+127:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VAESDECLAST - _mm512_aesdeclast_epi128

| VAESDECLAST_ZMMu128_ZMMu128_ZMMu128_AVX512

--------------------------------------------------------------------------------------------------------------
Perform the last round of an AES decryption flow on data (state) in "a" using the round key in "RoundKey", and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*128
    a[i+127:i] := InvShiftRows(a[i+127:i])
    a[i+127:i] := InvSubBytes(a[i+127:i])
    dst[i+127:i] := a[i+127:i] XOR RoundKey[i+127:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VAESDEC - _mm512_aesdec_epi128

| VAESDEC_ZMMu128_ZMMu128_ZMMu128_AVX512

--------------------------------------------------------------------------------------------------------------
Perform one round of an AES decryption flow on data (state) in "a" using the round key in "RoundKey", and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*128
    a[i+127:i] := InvShiftRows(a[i+127:i])
    a[i+127:i] := InvSubBytes(a[i+127:i])
    a[i+127:i] := InvMixColumns(a[i+127:i])
    dst[i+127:i] := a[i+127:i] XOR RoundKey[i+127:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOG2PS - _mm512_log2_ps

| 

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i]) / LOG(2.0)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOG2PS - _mm512_mask_log2_ps

| 

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := LOG(a[i+31:i]) / LOG(2.0)
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PD - _mm_fmadd_pd

| VFMADD132PD_XMMdq_XMMdq_XMMdq | VFMADD213PD_XMMdq_XMMdq_XMMdq | VFMADD231PD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PD - _mm256_fmadd_pd

| VFMADD132PD_YMMqq_YMMqq_YMMqq | VFMADD213PD_YMMqq_YMMqq_YMMqq | VFMADD231PD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PS - _mm_fmadd_ps

| VFMADD132PS_XMMdq_XMMdq_XMMdq | VFMADD213PS_XMMdq_XMMdq_XMMdq | VFMADD231PS_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132PS - _mm256_fmadd_ps

| VFMADD132PS_YMMqq_YMMqq_YMMqq | VFMADD213PS_YMMqq_YMMqq_YMMqq | VFMADD231PS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the intermediate result
to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132SD - _mm_fmadd_sd

| VFMADD132SD_XMMdq_XMMq_XMMq | VFMADD213SD_XMMdq_XMMq_XMMq | VFMADD231SD_XMMdq_XMMq_XMMq

--------------------------------------------------------------------------------------------------------------
Multiply the lower double-precision (64-bit) floating-point elements in "a" and "b", and add the intermediate
result to the lower element in "c". Store the result in the lower element of "dst", and copy the upper element
from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := (a[63:0] * b[63:0]) + c[63:0]
dst[127:64] := a[127:64]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD132SS - _mm_fmadd_ss

| VFMADD132SS_XMMdq_XMMd_XMMd | VFMADD213SS_XMMdq_XMMd_XMMd | VFMADD231SS_XMMdq_XMMd_XMMd

--------------------------------------------------------------------------------------------------------------
Multiply the lower single-precision (32-bit) floating-point elements in "a" and "b", and add the intermediate
result to the lower element in "c". Store the result in the lower element of "dst", and copy the upper 3 packed
elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := (a[31:0] * b[31:0]) + c[31:0]
dst[127:32] := a[127:32]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADDSUB132PD - _mm_fmaddsub_pd

| VFMADDSUB132PD_XMMdq_XMMdq_XMMdq | VFMADDSUB213PD_XMMdq_XMMdq_XMMdq | VFMADDSUB231PD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", alternatively add and
subtract packed elements in "c" to/from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF ((j &amp; 1) == 0) 
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADDSUB132PD - _mm256_fmaddsub_pd

| VFMADDSUB132PD_YMMqq_YMMqq_YMMqq | VFMADDSUB213PD_YMMqq_YMMqq_YMMqq | VFMADDSUB231PD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", alternatively add and
subtract packed elements in "c" to/from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF ((j &amp; 1) == 0) 
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
    ELSE
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADDSUB132PS - _mm_fmaddsub_ps

| VFMADDSUB132PS_XMMdq_XMMdq_XMMdq | VFMADDSUB213PS_XMMdq_XMMdq_XMMdq | VFMADDSUB231PS_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", alternatively add and
subtract packed elements in "c" to/from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF ((j &amp; 1) == 0) 
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADDSUB132PS - _mm256_fmaddsub_ps

| VFMADDSUB132PS_YMMqq_YMMqq_YMMqq | VFMADDSUB213PS_YMMqq_YMMqq_YMMqq | VFMADDSUB231PS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", alternatively add and
subtract packed elements in "c" to/from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF ((j &amp; 1) == 0) 
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
    ELSE
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PD - _mm_fmsub_pd

| VFMSUB132PD_XMMdq_XMMdq_XMMdq | VFMSUB213PD_XMMdq_XMMdq_XMMdq | VFMSUB231PD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PD - _mm256_fmsub_pd

| VFMSUB132PD_YMMqq_YMMqq_YMMqq | VFMSUB213PD_YMMqq_YMMqq_YMMqq | VFMSUB231PD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PS - _mm_fmsub_ps

| VFMSUB132PS_XMMdq_XMMdq_XMMdq | VFMSUB213PS_XMMdq_XMMdq_XMMdq | VFMSUB231PS_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132PS - _mm256_fmsub_ps

| VFMSUB132PS_YMMqq_YMMqq_YMMqq | VFMSUB213PS_YMMqq_YMMqq_YMMqq | VFMSUB231PS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132SD - _mm_fmsub_sd

| VFMSUB132SD_XMMdq_XMMq_XMMq | VFMSUB213SD_XMMdq_XMMq_XMMq | VFMSUB231SD_XMMdq_XMMq_XMMq

--------------------------------------------------------------------------------------------------------------
Multiply the lower double-precision (64-bit) floating-point elements in "a" and "b", and subtract the lower
element in "c" from the intermediate result. Store the result in the lower element of "dst", and copy the upper
element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := (a[63:0] * b[63:0]) - c[63:0]
dst[127:64] := a[127:64]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUB132SS - _mm_fmsub_ss

| VFMSUB132SS_XMMdq_XMMd_XMMd | VFMSUB213SS_XMMdq_XMMd_XMMd | VFMSUB231SS_XMMdq_XMMd_XMMd

--------------------------------------------------------------------------------------------------------------
Multiply the lower single-precision (32-bit) floating-point elements in "a" and "b", and subtract the lower
element in "c" from the intermediate result. Store the result in the lower element of "dst", and copy the upper
3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := (a[31:0] * b[31:0]) - c[31:0]
dst[127:32] := a[127:32]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUBADD132PD - _mm_fmsubadd_pd

| VFMSUBADD132PD_XMMdq_XMMdq_XMMdq | VFMSUBADD213PD_XMMdq_XMMdq_XMMdq | VFMSUBADD231PD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", alternatively subtract and
add packed elements in "c" from/to the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF ((j &amp; 1) == 0) 
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUBADD132PD - _mm256_fmsubadd_pd

| VFMSUBADD132PD_YMMqq_YMMqq_YMMqq | VFMSUBADD213PD_YMMqq_YMMqq_YMMqq | VFMSUBADD231PD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", alternatively subtract and
add packed elements in "c" from/to the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    IF ((j &amp; 1) == 0) 
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) + c[i+63:i]
    ELSE
        dst[i+63:i] := (a[i+63:i] * b[i+63:i]) - c[i+63:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUBADD132PS - _mm_fmsubadd_ps

| VFMSUBADD132PS_XMMdq_XMMdq_XMMdq | VFMSUBADD213PS_XMMdq_XMMdq_XMMdq | VFMSUBADD231PS_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", alternatively subtract and
add packed elements in "c" from/to the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF ((j &amp; 1) == 0) 
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFMSUBADD132PS - _mm256_fmsubadd_ps

| VFMSUBADD132PS_YMMqq_YMMqq_YMMqq | VFMSUBADD213PS_YMMqq_YMMqq_YMMqq | VFMSUBADD231PS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", alternatively subtract and
add packed elements in "c" from/to the intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    IF ((j &amp; 1) == 0) 
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
    ELSE
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) - c[i+31:i]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PD - _mm_fnmadd_pd

| VFNMADD132PD_XMMdq_XMMdq_XMMdq | VFNMADD213PD_XMMdq_XMMdq_XMMdq | VFNMADD231PD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) + c[i+63:i]
ENDFOR    
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PD - _mm256_fnmadd_pd

| VFNMADD132PD_YMMqq_YMMqq_YMMqq | VFNMADD213PD_YMMqq_YMMqq_YMMqq | VFNMADD231PD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) + c[i+63:i]
ENDFOR    
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PS - _mm_fnmadd_ps

| VFNMADD132PS_XMMdq_XMMdq_XMMdq | VFNMADD213PS_XMMdq_XMMdq_XMMdq | VFNMADD231PS_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) + c[i+31:i]
ENDFOR    
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132PS - _mm256_fnmadd_ps

| VFNMADD132PS_YMMqq_YMMqq_YMMqq | VFNMADD213PS_YMMqq_YMMqq_YMMqq | VFNMADD231PS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", add the negated intermediate
result to packed elements in "c", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) + c[i+31:i]
ENDFOR    
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132SD - _mm_fnmadd_sd

| VFNMADD132SD_XMMdq_XMMq_XMMq | VFNMADD213SD_XMMdq_XMMq_XMMq | VFNMADD231SD_XMMdq_XMMq_XMMq

--------------------------------------------------------------------------------------------------------------
Multiply the lower double-precision (64-bit) floating-point elements in "a" and "b", and add the negated
intermediate result to the lower element in "c". Store the result in the lower element of "dst", and copy the
upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := -(a[63:0] * b[63:0]) + c[63:0]
dst[127:64] := a[127:64]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMADD132SS - _mm_fnmadd_ss

| VFNMADD132SS_XMMdq_XMMd_XMMd | VFNMADD213SS_XMMdq_XMMd_XMMd | VFNMADD231SS_XMMdq_XMMd_XMMd

--------------------------------------------------------------------------------------------------------------
Multiply the lower single-precision (32-bit) floating-point elements in "a" and "b", and add the negated
intermediate result to the lower element in "c". Store the result in the lower element of "dst", and copy the
upper 3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := -(a[31:0] * b[31:0]) + c[31:0]
dst[127:32] := a[127:32]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PD - _mm_fnmsub_pd

| VFNMSUB132PD_XMMdq_XMMdq_XMMdq | VFNMSUB213PD_XMMdq_XMMdq_XMMdq | VFNMSUB231PD_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) - c[i+63:i]
ENDFOR    
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PD - _mm256_fnmsub_pd

| VFNMSUB132PD_YMMqq_YMMqq_YMMqq | VFNMSUB213PD_YMMqq_YMMqq_YMMqq | VFNMSUB231PD_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := -(a[i+63:i] * b[i+63:i]) - c[i+63:i]
ENDFOR    
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PS - _mm_fnmsub_ps

| VFNMSUB132PS_XMMdq_XMMdq_XMMdq | VFNMSUB213PS_XMMdq_XMMdq_XMMdq | VFNMSUB231PS_XMMdq_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) - c[i+31:i]
ENDFOR    
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132PS - _mm256_fnmsub_ps

| VFNMSUB132PS_YMMqq_YMMqq_YMMqq | VFNMSUB213PS_YMMqq_YMMqq_YMMqq | VFNMSUB231PS_YMMqq_YMMqq_YMMqq

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", subtract packed elements in
"c" from the negated intermediate result, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := -(a[i+31:i] * b[i+31:i]) - c[i+31:i]
ENDFOR    
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132SD - _mm_fnmsub_sd

| VFNMSUB132SD_XMMdq_XMMq_XMMq | VFNMSUB213SD_XMMdq_XMMq_XMMq | VFNMSUB231SD_XMMdq_XMMq_XMMq

--------------------------------------------------------------------------------------------------------------
Multiply the lower double-precision (64-bit) floating-point elements in "a" and "b", and subtract the lower
element in "c" from the negated intermediate result. Store the result in the lower element of "dst", and copy
the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := -(a[63:0] * b[63:0]) - c[63:0]
dst[127:64] := a[127:64]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VFNMSUB132SS - _mm_fnmsub_ss

| VFNMSUB132SS_XMMdq_XMMd_XMMd | VFNMSUB213SS_XMMdq_XMMd_XMMd | VFNMSUB231SS_XMMdq_XMMd_XMMd

--------------------------------------------------------------------------------------------------------------
Multiply the lower single-precision (32-bit) floating-point elements in "a" and "b", and subtract the lower
element in "c" from the negated intermediate result. Store the result in the lower element of "dst", and copy
the upper 3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := -(a[31:0] * b[31:0]) - c[31:0]
dst[127:32] := a[127:32]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPH2PS - _mm256_cvtph_ps

| VCVTPH2PS_YMMqq_XMMdq

--------------------------------------------------------------------------------------------------------------
Convert packed half-precision (16-bit) floating-point elements in "a" to packed single-precision (32-bit)
floating-point elements, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    m := j*16
    dst[i+31:i] := Convert_FP16_To_FP32(a[m+15:m])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPS2PH - _mm256_cvtps_ph

| VCVTPS2PH_XMMdq_YMMqq_IMMb

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed half-precision (16-bit)
floating-point elements, and store the results in "dst".
	[sae_note]

[algorithm]

FOR j := 0 to 7
    i := 16*j
    l := 32*j
    dst[i+15:i] := Convert_FP32_To_FP16(a[l+31:l])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPH2PS - _mm_cvtph_ps

| VCVTPH2PS_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Convert packed half-precision (16-bit) floating-point elements in "a" to packed single-precision (32-bit)
floating-point elements, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    m := j*16
    dst[i+31:i] := Convert_FP16_To_FP32(a[m+15:m])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPS2PH - _mm_cvtps_ph

| VCVTPS2PH_XMMq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed half-precision (16-bit)
floating-point elements, and store the results in "dst".
	[sae_note]

[algorithm]

FOR j := 0 to 3
    i := 16*j
    l := 32*j
    dst[i+15:i] := Convert_FP32_To_FP16(a[l+31:l])
ENDFOR
dst[MAX:64] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8MULB - _mm512_maskz_gf2p8mul_epi8

| VGF2P8MULB_ZMMu8_MASKmskw_ZMMu8_ZMMu8_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 8-bit integers in "a" and "b" in the finite field GF(2^8), and store the results in "dst"
using zeromask "k" (elements are zeroed out when the corresponding mask bit is not set). The field GF(2^8) is
represented in polynomial representation with the reduction polynomial x^8 + x^4 + x^3 + x + 1.

[algorithm]

DEFINE gf2p8mul_byte(src1byte, src2byte) {
    tword := 0
    FOR i := 0 to 7
        IF src2byte.bit[i]
            tword := tword XOR (src1byte &lt;&lt; i)
        FI
    ENDFOR
    FOR i := 14 downto 8
        p := 0x11B &lt;&lt; (i-8)
        IF tword.bit[i]
            tword := tword XOR p
        FI
    ENDFOR
    RETURN tword.byte[0]
}
FOR j := 0 TO 63
    IF k[j]
        dst.byte[j] := gf2p8mul_byte(a.byte[j], b.byte[j])
    ELSE
        dst.byte[j] := 0
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8MULB - _mm512_mask_gf2p8mul_epi8

| VGF2P8MULB_ZMMu8_MASKmskw_ZMMu8_ZMMu8_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 8-bit integers in "a" and "b" in the finite field GF(2^8), and store the results in "dst"
using writemask "k" (elements are copied from "src"" when the corresponding mask bit is not set). The field
GF(2^8) is represented in polynomial representation with the reduction polynomial x^8 + x^4 + x^3 + x + 1.

[algorithm]

DEFINE gf2p8mul_byte(src1byte, src2byte) {
    tword := 0
    FOR i := 0 to 7
        IF src2byte.bit[i]
            tword := tword XOR (src1byte &lt;&lt; i)
        FI
    ENDFOR
    FOR i := 14 downto 8
        p := 0x11B &lt;&lt; (i-8)
        IF tword.bit[i]
            tword := tword XOR p
        FI
    ENDFOR
    RETURN tword.byte[0]
}
FOR j := 0 TO 63
    IF k[j]
        dst.byte[j] := gf2p8mul_byte(a.byte[j], b.byte[j])
    ELSE
        dst.byte[j] := src.byte[j]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8MULB - _mm512_gf2p8mul_epi8

| VGF2P8MULB_ZMMu8_MASKmskw_ZMMu8_ZMMu8_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 8-bit integers in "a" and "b" in the finite field GF(2^8), and store the results in "dst".
The field GF(2^8) is represented in polynomial representation with the reduction polynomial x^8 + x^4 + x^3 + x
+ 1.

[algorithm]

DEFINE gf2p8mul_byte(src1byte, src2byte) {
    tword := 0
    FOR i := 0 to 7
        IF src2byte.bit[i]
            tword := tword XOR (src1byte &lt;&lt; i)
        FI
    ENDFOR
    FOR i := 14 downto 8
        p := 0x11B &lt;&lt; (i-8)
        IF tword.bit[i]
            tword := tword XOR p
        FI
    ENDFOR
    RETURN tword.byte[0]
}
FOR j := 0 TO 63
    dst.byte[j] := gf2p8mul_byte(a.byte[j], b.byte[j])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8MULB - _mm256_maskz_gf2p8mul_epi8

| VGF2P8MULB_YMMu8_MASKmskw_YMMu8_YMMu8_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 8-bit integers in "a" and "b" in the finite field GF(2^8), and store the results in "dst"
using zeromask "k" (elements are zeroed out when the corresponding mask bit is not set). The field GF(2^8) is
represented in polynomial representation with the reduction polynomial x^8 + x^4 + x^3 + x + 1.

[algorithm]

DEFINE gf2p8mul_byte(src1byte, src2byte) {
    tword := 0
    FOR i := 0 to 7
        IF src2byte.bit[i]
            tword := tword XOR (src1byte &lt;&lt; i)
        FI
    ENDFOR
    FOR i := 14 downto 8
        p := 0x11B &lt;&lt; (i-8)
        IF tword.bit[i]
            tword := tword XOR p
        FI
    ENDFOR
    RETURN tword.byte[0]
}
FOR j := 0 TO 31
    IF k[j]
        dst.byte[j] := gf2p8mul_byte(a.byte[j], b.byte[j])
    ELSE
        dst.byte[j] := 0
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8MULB - _mm256_mask_gf2p8mul_epi8

| VGF2P8MULB_YMMu8_MASKmskw_YMMu8_YMMu8_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 8-bit integers in "a" and "b" in the finite field GF(2^8), and store the results in "dst"
using writemask "k" (elements are copied from "src"" when the corresponding mask bit is not set). The field
GF(2^8) is represented in polynomial representation with the reduction polynomial x^8 + x^4 + x^3 + x + 1.

[algorithm]

DEFINE gf2p8mul_byte(src1byte, src2byte) {
    tword := 0
    FOR i := 0 to 7
        IF src2byte.bit[i]
            tword := tword XOR (src1byte &lt;&lt; i)
        FI
    ENDFOR
    FOR i := 14 downto 8
        p := 0x11B &lt;&lt; (i-8)
        IF tword.bit[i]
            tword := tword XOR p
        FI
    ENDFOR
    RETURN tword.byte[0]
}
FOR j := 0 TO 31
    IF k[j]
        dst.byte[j] := gf2p8mul_byte(a.byte[j], b.byte[j])
    ELSE
        dst.byte[j] := src.byte[j]
    FI
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8MULB - _mm256_gf2p8mul_epi8

| VGF2P8MULB_YMMu8_MASKmskw_YMMu8_YMMu8_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 8-bit integers in "a" and "b" in the finite field GF(2^8), and store the results in "dst".
The field GF(2^8) is represented in polynomial representation with the reduction polynomial x^8 + x^4 + x^3 + x
+ 1.

[algorithm]

DEFINE gf2p8mul_byte(src1byte, src2byte) {
    tword := 0
    FOR i := 0 to 7
        IF src2byte.bit[i]
            tword := tword XOR (src1byte &lt;&lt; i)
        FI
    ENDFOR
    FOR i := 14 downto 8
        p := 0x11B &lt;&lt; (i-8)
        IF tword.bit[i]
            tword := tword XOR p
        FI
    ENDFOR
    RETURN tword.byte[0]
}
FOR j := 0 TO 31
    dst.byte[j] := gf2p8mul_byte(a.byte[j], b.byte[j])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8MULB - _mm_maskz_gf2p8mul_epi8

| VGF2P8MULB_XMMu8_MASKmskw_XMMu8_XMMu8_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 8-bit integers in "a" and "b" in the finite field GF(2^8), and store the results in "dst"
using zeromask "k" (elements are zeroed out when the corresponding mask bit is not set). The field GF(2^8) is
represented in polynomial representation with the reduction polynomial x^8 + x^4 + x^3 + x + 1.

[algorithm]

DEFINE gf2p8mul_byte(src1byte, src2byte) {
    tword := 0
    FOR i := 0 to 7
        IF src2byte.bit[i]
            tword := tword XOR (src1byte &lt;&lt; i)
        FI
    ENDFOR
    FOR i := 14 downto 8
        p := 0x11B &lt;&lt; (i-8)
        IF tword.bit[i]
            tword := tword XOR p
        FI
    ENDFOR
    RETURN tword.byte[0]
}
FOR j := 0 TO 15
    IF k[j]
        dst.byte[j] := gf2p8mul_byte(a.byte[j], b.byte[j])
    ELSE
        dst.byte[j] := 0
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8MULB - _mm_mask_gf2p8mul_epi8

| VGF2P8MULB_XMMu8_MASKmskw_XMMu8_XMMu8_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 8-bit integers in "a" and "b" in the finite field GF(2^8), and store the results in "dst"
using writemask "k" (elements are copied from "src"" when the corresponding mask bit is not set). The field
GF(2^8) is represented in polynomial representation with the reduction polynomial x^8 + x^4 + x^3 + x + 1.

[algorithm]

DEFINE gf2p8mul_byte(src1byte, src2byte) {
    tword := 0
    FOR i := 0 to 7
        IF src2byte.bit[i]
            tword := tword XOR (src1byte &lt;&lt; i)
        FI
    ENDFOR
    FOR i := 14 downto 8
        p := 0x11B &lt;&lt; (i-8)
        IF tword.bit[i]
            tword := tword XOR p
        FI
    ENDFOR
    RETURN tword.byte[0]
}
FOR j := 0 TO 15
    IF k[j]
        dst.byte[j] := gf2p8mul_byte(a.byte[j], b.byte[j])
    ELSE
        dst.byte[j] := src.byte[j]
    FI
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8MULB - _mm_gf2p8mul_epi8

| VGF2P8MULB_XMMu8_MASKmskw_XMMu8_XMMu8_AVX512

--------------------------------------------------------------------------------------------------------------
Multiply the packed 8-bit integers in "a" and "b" in the finite field GF(2^8), and store the results in "dst".
The field GF(2^8) is represented in polynomial representation with the reduction polynomial x^8 + x^4 + x^3 + x
+ 1.

[algorithm]

DEFINE gf2p8mul_byte(src1byte, src2byte) {
    tword := 0
    FOR i := 0 to 7
        IF src2byte.bit[i]
            tword := tword XOR (src1byte &lt;&lt; i)
        FI
    ENDFOR
    FOR i := 14 downto 8
        p := 0x11B &lt;&lt; (i-8)
        IF tword.bit[i]
            tword := tword XOR p
        FI
    ENDFOR
    RETURN tword.byte[0]
}
FOR j := 0 TO 15
    dst.byte[j] := gf2p8mul_byte(a.byte[j], b.byte[j])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEQB - _mm512_maskz_gf2p8affine_epi64_epi8

| VGF2P8AFFINEQB_ZMMu8_MASKmskw_ZMMu8_ZMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" * "x" +
"b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant immediate
byte. Store the packed 8-bit results in "dst" using zeromask "k" (elements are zeroed out when the
corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND src1byte) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 7
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := 0
        FI
    ENDFOR
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEQB - _mm512_mask_gf2p8affine_epi64_epi8

| VGF2P8AFFINEQB_ZMMu8_MASKmskw_ZMMu8_ZMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" * "x" +
"b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant immediate
byte. Store the packed 8-bit results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND src1byte) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 7
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := src.qword[j].byte[i]
        FI
    ENDFOR
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEQB - _mm512_gf2p8affine_epi64_epi8

| VGF2P8AFFINEQB_ZMMu8_MASKmskw_ZMMu8_ZMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" * "x" +
"b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant immediate
byte. Store the packed 8-bit results in "dst".

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND src1byte) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 7
    FOR i := 0 to 7
        dst.qword[j].byte[i] := affine_byte(A.qword[j], x.qword[j].byte[i], b)
    ENDFOR
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEQB - _mm256_maskz_gf2p8affine_epi64_epi8

| VGF2P8AFFINEQB_YMMu8_MASKmskw_YMMu8_YMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" * "x" +
"b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant immediate
byte. Store the packed 8-bit results in "dst" using zeromask "k" (elements are zeroed out when the
corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND src1byte) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 3
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := 0
        FI
    ENDFOR
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEQB - _mm256_mask_gf2p8affine_epi64_epi8

| VGF2P8AFFINEQB_YMMu8_MASKmskw_YMMu8_YMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" * "x" +
"b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant immediate
byte. Store the packed 8-bit results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND src1byte) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 3
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := src.qword[j].byte[i]
        FI
    ENDFOR
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEQB - _mm256_gf2p8affine_epi64_epi8

| VGF2P8AFFINEQB_YMMu8_MASKmskw_YMMu8_YMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" * "x" +
"b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant immediate
byte. Store the packed 8-bit results in "dst".

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND src1byte) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 3
    FOR i := 0 to 7
        dst.qword[j].byte[i] := affine_byte(A.qword[j], x.qword[j].byte[i], b)
    ENDFOR
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEQB - _mm_maskz_gf2p8affine_epi64_epi8

| VGF2P8AFFINEQB_XMMu8_MASKmskw_XMMu8_XMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" * "x" +
"b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant immediate
byte. Store the packed 8-bit results in "dst" using zeromask "k" (elements are zeroed out when the
corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND src1byte) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 1
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := 0
        FI
    ENDFOR
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEQB - _mm_mask_gf2p8affine_epi64_epi8

| VGF2P8AFFINEQB_XMMu8_MASKmskw_XMMu8_XMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" * "x" +
"b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant immediate
byte. Store the packed 8-bit results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND src1byte) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 1
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := src.qword[j].byte[i]
        FI
    ENDFOR
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEQB - _mm_gf2p8affine_epi64_epi8

| VGF2P8AFFINEQB_XMMu8_MASKmskw_XMMu8_XMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" * "x" +
"b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant immediate
byte. Store the packed 8-bit results in "dst".

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND src1byte) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 1
    FOR i := 0 to 7
        dst.qword[j].byte[i] := affine_byte(A.qword[j], x.qword[j].byte[i], b)
    ENDFOR
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEINVQB - _mm512_maskz_gf2p8affineinv_epi64_epi8

| VGF2P8AFFINEINVQB_ZMMu8_MASKmskw_ZMMu8_ZMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an inverse affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" *
"x" + "b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant
immediate byte. The inverse of the 8-bit values in "x" is defined with respect to the reduction polynomial x^8
+ x^4 + x^3 + x + 1. Store the packed 8-bit results in "dst" using zeromask "k" (elements are zeroed out when
the corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_inverse_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND inverse(src1byte)) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 7
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_inverse_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := 0
        FI
    ENDFOR
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEINVQB - _mm512_mask_gf2p8affineinv_epi64_epi8

| VGF2P8AFFINEINVQB_ZMMu8_MASKmskw_ZMMu8_ZMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an inverse affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" *
"x" + "b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant
immediate byte. The inverse of the 8-bit values in "x" is defined with respect to the reduction polynomial x^8
+ x^4 + x^3 + x + 1. Store the packed 8-bit results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_inverse_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND inverse(src1byte)) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 7
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_inverse_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := src.qword[j].byte[b]
        FI
    ENDFOR
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEINVQB - _mm512_gf2p8affineinv_epi64_epi8

| VGF2P8AFFINEINVQB_ZMMu8_MASKmskw_ZMMu8_ZMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an inverse affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" *
"x" + "b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant
immediate byte. The inverse of the 8-bit values in "x" is defined with respect to the reduction polynomial x^8
+ x^4 + x^3 + x + 1. Store the packed 8-bit results in "dst".

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_inverse_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND inverse(src1byte)) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 7
    FOR i := 0 to 7
        dst.qword[j].byte[i] := affine_inverse_byte(A.qword[j], x.qword[j].byte[i], b)
    ENDFOR
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEINVQB - _mm256_maskz_gf2p8affineinv_epi64_epi8

| VGF2P8AFFINEINVQB_YMMu8_MASKmskw_YMMu8_YMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an inverse affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" *
"x" + "b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant
immediate byte. The inverse of the 8-bit values in "x" is defined with respect to the reduction polynomial x^8
+ x^4 + x^3 + x + 1. Store the packed 8-bit results in "dst" using zeromask "k" (elements are zeroed out when
the corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_inverse_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND inverse(src1byte)) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 3
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_inverse_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := 0
        FI
    ENDFOR
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEINVQB - _mm256_mask_gf2p8affineinv_epi64_epi8

| VGF2P8AFFINEINVQB_YMMu8_MASKmskw_YMMu8_YMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an inverse affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" *
"x" + "b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant
immediate byte. The inverse of the 8-bit values in "x" is defined with respect to the reduction polynomial x^8
+ x^4 + x^3 + x + 1. Store the packed 8-bit results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_inverse_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND inverse(src1byte)) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 3
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_inverse_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := src.qword[j].byte[i]
        FI
    ENDFOR
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEINVQB - _mm256_gf2p8affineinv_epi64_epi8

| VGF2P8AFFINEINVQB_YMMu8_MASKmskw_YMMu8_YMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an inverse affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" *
"x" + "b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant
immediate byte. The inverse of the 8-bit values in "x" is defined with respect to the reduction polynomial x^8
+ x^4 + x^3 + x + 1. Store the packed 8-bit results in "dst".

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_inverse_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND inverse(src1byte)) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 3
    FOR i := 0 to 7
        dst.qword[j].byte[i] := affine_inverse_byte(A.qword[j], x.qword[j].byte[i], b)
    ENDFOR
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEINVQB - _mm_maskz_gf2p8affineinv_epi64_epi8

| VGF2P8AFFINEINVQB_XMMu8_MASKmskw_XMMu8_XMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an inverse affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" *
"x" + "b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant
immediate byte. The inverse of the 8-bit values in "x" is defined with respect to the reduction polynomial x^8
+ x^4 + x^3 + x + 1. Store the packed 8-bit results in "dst" using zeromask "k" (elements are zeroed out when
the corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_inverse_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND inverse(src1byte)) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 1
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_inverse_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := 0
        FI
    ENDFOR
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEINVQB - _mm_mask_gf2p8affineinv_epi64_epi8

| VGF2P8AFFINEINVQB_XMMu8_MASKmskw_XMMu8_XMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an inverse affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" *
"x" + "b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant
immediate byte. The inverse of the 8-bit values in "x" is defined with respect to the reduction polynomial x^8
+ x^4 + x^3 + x + 1. Store the packed 8-bit results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_inverse_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND inverse(src1byte)) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 1
    FOR i := 0 to 7
        IF k[j*8+i]
            dst.qword[j].byte[i] := affine_inverse_byte(A.qword[j], x.qword[j].byte[i], b)
        ELSE
            dst.qword[j].byte[i] := src.qword[j].byte[i]
        FI
    ENDFOR
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VGF2P8AFFINEINVQB - _mm_gf2p8affineinv_epi64_epi8

| VGF2P8AFFINEINVQB_XMMu8_MASKmskw_XMMu8_XMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Compute an inverse affine transformation in the Galois Field 2^8. An affine transformation is defined by "A" *
"x" + "b", where "A" represents an 8 by 8 bit matrix, "x" represents an 8-bit vector, and "b" is a constant
immediate byte. The inverse of the 8-bit values in "x" is defined with respect to the reduction polynomial x^8
+ x^4 + x^3 + x + 1. Store the packed 8-bit results in "dst".

[algorithm]

DEFINE parity(x) {
    t := 0
    FOR i := 0 to 7
        t := t XOR x.bit[i]
    ENDFOR
    RETURN t
}
DEFINE affine_inverse_byte(tsrc2qw, src1byte, imm8) {
    FOR i := 0 to 7
        retbyte.bit[i] := parity(tsrc2qw.byte[7-i] AND inverse(src1byte)) XOR imm8.bit[i]
    ENDFOR
    RETURN retbyte
}
FOR j := 0 TO 1
    FOR i := 0 to 7
        dst.qword[j].byte[i] := affine_inverse_byte(A.qword[j], x.qword[j].byte[i], b)
    ENDFOR
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## VPREFETCH0 - _mm_prefetch

|  |  |  |  |  |  |  | 

--------------------------------------------------------------------------------------------------------------
Fetch the line of data from memory that contains address "p" to a location in the cache heirarchy specified by
the locality hint "i".

[missing]

--------------------------------------------------------------------------------------------------------------

## VPCMPLTD - _mm512_cmplt_epi32_mask

| 

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for less-than, and store the results in mask vector "k".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k[j] := ( a[i+31:i] &lt; b[i+31:i] ) ? 1 : 0
ENDFOR
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## VPCMPLTD - _mm512_mask_cmplt_epi32_mask

| 

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for less-than-or-equal, and store the results in mask
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

## VMOVAPS - _mm512_extload_ps

| VMOVAPS_ZMMf32_MASKmskw_MEMf32_AVX512 | VBROADCASTF32X4_ZMMf32_MASKmskw_MEMf32_AVX512 | VBROADCASTSS_ZMMf32_MASKmskw_MEMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Depending on "bc", loads 1, 4, or 16 elements of type and size determined by "conv" from memory address "mt"
and converts all elements to single-precision (32-bit) floating-point elements, storing the results in "dst".
"hint" indicates to the processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 15
    i := j*32
    CASE bc OF
    _MM_BROADCAST32_NONE:
        CASE conv OF
        _MM_UPCONV_PS_NONE:
            n     := j*32
            dst[i+31:i] := addr[n+31:n]
        _MM_UPCONV_PS_FLOAT16:
            n     := j*16
            dst[i+31:i] := Convert_FP16_To_FP32(addr[n+15:n])
        _MM_UPCONV_PS_UINT8:
            n     := j*8
            dst[i+31:i] := Convert_UInt8_To_FP32(addr[n+7:n])
        _MM_UPCONV_PS_SINT8:
            n     := j*8
            dst[i+31:i] := Convert_Int8_To_FP32(addr[n+7:n])
        _MM_UPCONV_PS_UINT16:
            n     := j*16
            dst[i+31:i] := Convert_UInt16_To_FP32(addr[n+15:n])
        _MM_UPCONV_PS_SINT16:
            n     := j*16
            dst[i+31:i] := Convert_Int16_To_FP32(addr[n+15:n])
        ESAC
    _MM_BROADCAST_1X16:
        CASE conv OF
        _MM_UPCONV_PS_NONE:
            n     := j*32
            dst[i+31:i] := addr[31:0]
        _MM_UPCONV_PS_FLOAT16:
            n     := j*16
            dst[i+31:i] := Convert_FP16_To_FP32(addr[15:0])
        _MM_UPCONV_PS_UINT8:
            n     := j*8
            dst[i+31:i] := Convert_UInt8_To_FP32(addr[7:0])
        _MM_UPCONV_PS_SINT8:
            n     := j*8
            dst[i+31:i] := Convert_Int8_To_FP32(addr[7:0])
        _MM_UPCONV_PS_UINT16:
            n     := j*16
            dst[i+31:i] := Convert_UInt16_To_FP32(addr[15:0])
        _MM_UPCONV_PS_SINT16:
            n     := j*16
            dst[i+31:i] := Convert_Int16_To_FP32(addr[15:0])
        ESAC
    _MM_BROADCAST_4X16:
        mod := j%4
        CASE conv OF
        _MM_UPCONV_PS_NONE:
            n := mod*32
            dst[i+31:i] := addr[n+31:n]
        _MM_UPCONV_PS_FLOAT16:
            n := mod*16
            dst[i+31:i] := Convert_FP16_To_FP32(addr[n+15:n])
        _MM_UPCONV_PS_UINT8:
            n := mod*8
            dst[i+31:i] := Convert_UInt8_To_FP32(addr[n+7:n])
        _MM_UPCONV_PS_SINT8:
            n := mod*8
            dst[i+31:i] := Convert_Int8_To_FP32(addr[n+7:n])
        _MM_UPCONV_PS_UINT16:
            n := mod*16
            dst[i+31:i] := Convert_UInt16_To_FP32(addr[n+15:n])
        _MM_UPCONV_PS_SINT16:
            n := mod*16
            dst[i+31:i] := Convert_Int16_To_FP32(addr[n+15:n])
        ESAC
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm512_mask_extload_ps

| VMOVAPS_ZMMf32_MASKmskw_MEMf32_AVX512 | VBROADCASTF32X4_ZMMf32_MASKmskw_MEMf32_AVX512 | VBROADCASTSS_ZMMf32_MASKmskw_MEMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Depending on "bc", loads 1, 4, or 16 elements of type and size determined by "conv" from memory address "mt"
and converts all elements to single-precision (32-bit) floating-point elements, storing the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). "hint"
indicates to the processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 15
    i := j*32
    IF k[j]
        CASE bc OF
        _MM_BROADCAST32_NONE:
            CASE conv OF
            _MM_UPCONV_PS_NONE:
                n     := j*32
                dst[i+31:i] := addr[n+31:n]
            _MM_UPCONV_PS_FLOAT16:
                n     := j*16
                dst[i+31:i] := Convert_FP16_To_FP32(addr[n+15:n])
            _MM_UPCONV_PS_UINT8:
                n     := j*8
                dst[i+31:i] := Convert_UInt8_To_FP32(addr[n+7:n])
            _MM_UPCONV_PS_SINT8:
                n     := j*8
                dst[i+31:i] := Convert_Int8_To_FP32(addr[n+7:n])
            _MM_UPCONV_PS_UINT16:
                n     := j*16
                dst[i+31:i] := Convert_UInt16_To_FP32(addr[n+15:n])
            _MM_UPCONV_PS_SINT16:
                n     := j*16
                dst[i+31:i] := Convert_Int16_To_FP32(addr[n+15:n])
            ESAC
        _MM_BROADCAST_1X16:
            CASE conv OF
            _MM_UPCONV_PS_NONE:
                n     := j*32
                dst[i+31:i] := addr[31:0]
            _MM_UPCONV_PS_FLOAT16:
                n     := j*16
                dst[i+31:i] := Convert_FP16_To_FP32(addr[15:0])
            _MM_UPCONV_PS_UINT8:
                n     := j*8
                dst[i+31:i] := Convert_UInt8_To_FP32(addr[7:0])
            _MM_UPCONV_PS_SINT8:
                n     := j*8
                dst[i+31:i] := Convert_Int8_To_FP32(addr[7:0])
            _MM_UPCONV_PS_UINT16:
                n     := j*16
                dst[i+31:i] := Convert_UInt16_To_FP32(addr[15:0])
            _MM_UPCONV_PS_SINT16:
                n     := j*16
                dst[i+31:i] := Convert_Int16_To_FP32(addr[15:0])
            ESAC
        _MM_BROADCAST_4X16:
            mod := j%4
            CASE conv OF
            _MM_UPCONV_PS_NONE:
                n := mod*32
                dst[i+31:i] := addr[n+31:n]
            _MM_UPCONV_PS_FLOAT16:
                n := mod*16
                dst[i+31:i] := Convert_FP16_To_FP32(addr[n+15:n])
            _MM_UPCONV_PS_UINT8:
                n := mod*8
                dst[i+31:i] := Convert_UInt8_To_FP32(addr[n+7:n])
            _MM_UPCONV_PS_SINT8:
                n := mod*8
                dst[i+31:i] := Convert_Int8_To_FP32(addr[n+7:n])
            _MM_UPCONV_PS_UINT16:
                n := mod*16
                dst[i+31:i] := Convert_UInt16_To_FP32(addr[n+15:n])
            _MM_UPCONV_PS_SINT16:
                n := mod*16
                dst[i+31:i] := Convert_Int16_To_FP32(addr[n+15:n])
            ESAC
        ESAC
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_extload_epi32

| VMOVDQA32_ZMMu32_MASKmskw_MEMu32_AVX512 | VBROADCASTI32X4_ZMMu32_MASKmskw_MEMu32_AVX512 | VPBROADCASTD_ZMMu32_MASKmskw_MEMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Depending on "bc", loads 1, 4, or 16 elements of type and size determined by "conv" from memory address "mt"
and converts all elements to 32-bit integer elements, storing the results in "dst". "hint" indicates to the
processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 15
    i := j*32
    CASE bc OF
    _MM_BROADCAST32_NONE:
        CASE conv OF
        _MM_UPCONV_EPI32_NONE:
            n     := j*32
            dst[i+31:i] := addr[n+31:n]
        _MM_UPCONV_EPI32_UINT8:
            n     := j*8
            dst[i+31:i] := ZeroExtend32(addr[n+7:n])
        _MM_UPCONV_EPI32_SINT8:
            n     := j*8
            dst[i+31:i] := SignExtend32(addr[n+7:n])
        _MM_UPCONV_EPI32_UINT16:
            n     := j*16
            dst[i+31:i] := ZeroExtend32(addr[n+15:n])
        _MM_UPCONV_EPI32_SINT16:
            n     := j*16
            dst[i+31:i] := SignExtend32(addr[n+15:n])
        ESAC
    _MM_BROADCAST_1X16:
        CASE conv OF
        _MM_UPCONV_EPI32_NONE:
            n     := j*32
            dst[i+31:i] := addr[31:0]
        _MM_UPCONV_EPI32_UINT8:
            n     := j*8
            dst[i+31:i] := ZeroExtend32(addr[7:0])
        _MM_UPCONV_EPI32_SINT8:
            n     := j*8
            dst[i+31:i] := SignExtend32(addr[7:0])
        _MM_UPCONV_EPI32_UINT16:
            n     := j*16
            dst[i+31:i] := ZeroExtend32(addr[15:0])
        _MM_UPCONV_EPI32_SINT16:
            n     := j*16
            dst[i+31:i] := SignExtend32(addr[15:0])
        ESAC
    _MM_BROADCAST_4X16:
        mod := j%4
        CASE conv OF
        _MM_UPCONV_EPI32_NONE:
            n := mod*32
            dst[i+31:i] := addr[n+31:n]
        _MM_UPCONV_EPI32_UINT8:
            n := mod*8
            dst[i+31:i] := ZeroExtend32(addr[n+7:n])
        _MM_UPCONV_EPI32_SINT8:
            n := mod*8
            dst[i+31:i] := SignExtend32(addr[n+7:n])
        _MM_UPCONV_EPI32_UINT16:
            n := mod*16
            dst[i+31:i] := ZeroExtend32(addr[n+15:n])
        _MM_UPCONV_EPI32_SINT16:
            n := mod*16
            dst[i+31:i] := SignExtend32(addr[n+15:n])
        ESAC
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_mask_extload_epi32

| VMOVDQA32_ZMMu32_MASKmskw_MEMu32_AVX512 | VBROADCASTI32X4_ZMMu32_MASKmskw_MEMu32_AVX512 | VPBROADCASTD_ZMMu32_MASKmskw_MEMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Depending on "bc", loads 1, 4, or 16 elements of type and size determined by "conv" from memory address "mt"
and converts all elements to 32-bit integer elements, storing the results in "dst" using writemask "k"
(elements are copied from "src" when the corresponding mask bit is not set). "hint" indicates to the processor
whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 15
    i := j*32
    IF k[j]
        CASE bc OF
        _MM_BROADCAST32_NONE:
            CASE conv OF
            _MM_UPCONV_EPI32_NONE:
                n     := j*32
                dst[i+31:i] := addr[n+31:n]
            _MM_UPCONV_EPI32_UINT8:
                n     := j*8
                dst[i+31:i] := ZeroExtend32(addr[n+7:n])
            _MM_UPCONV_EPI32_SINT8:
                n     := j*8
                dst[i+31:i] := SignExtend32(addr[n+7:n])
            _MM_UPCONV_EPI32_UINT16:
                n     := j*16
                dst[i+31:i] := ZeroExtend32(addr[n+15:n])
            _MM_UPCONV_EPI32_SINT16:
                n     := j*16
                dst[i+31:i] := SignExtend32(addr[n+15:n])
            ESAC
        _MM_BROADCAST_1X16:
            CASE conv OF
            _MM_UPCONV_EPI32_NONE:
                n     := j*32
                dst[i+31:i] := addr[31:0]
            _MM_UPCONV_EPI32_UINT8:
                n     := j*8
                dst[i+31:i] := ZeroExtend32(addr[7:0])
            _MM_UPCONV_EPI32_SINT8:
                n     := j*8
                dst[i+31:i] := SignExtend32(addr[7:0])
            _MM_UPCONV_EPI32_UINT16:
                n     := j*16
                dst[i+31:i] := ZeroExtend32(addr[15:0])
            _MM_UPCONV_EPI32_SINT16:
                n     := j*16
                dst[i+31:i] := SignExtend32(addr[15:0])
            ESAC
        _MM_BROADCAST_4X16:
            mod := j%4
            CASE conv OF
            _MM_UPCONV_EPI32_NONE:
                n := mod*32
                dst[i+31:i] := addr[n+31:n]
            _MM_UPCONV_EPI32_UINT8:
                n := mod*8
                dst[i+31:i] := ZeroExtend32(addr[n+7:n])
            _MM_UPCONV_EPI32_SINT8:
                n := mod*8
                dst[i+31:i] := SignExtend32(addr[n+7:n])
            _MM_UPCONV_EPI32_UINT16:
                n := mod*16
                dst[i+31:i] := ZeroExtend32(addr[n+15:n])
            _MM_UPCONV_EPI32_SINT16:
                n := mod*16
                dst[i+31:i] := SignExtend32(addr[n+15:n])
            ESAC
        ESAC
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm512_extload_pd

| VMOVAPD_ZMMf64_MASKmskw_MEMf64_AVX512 | VBROADCASTF64X4_ZMMf64_MASKmskw_MEMf64_AVX512 | VBROADCASTSD_ZMMf64_MASKmskw_MEMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Depending on "bc", loads 1, 4, or 8 elements of type and size determined by "conv" from memory address "mt"
and converts all elements to double-precision (64-bit) floating-point elements, storing the results in "dst".
"hint" indicates to the processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 7
    i := j*64
    CASE bc OF
    _MM_BROADCAST64_NONE:
        CASE conv OF
        _MM_UPCONV_PD_NONE:
            n := j*64
            dst[i+63:i] := addr[n+63:n]
        ESAC
    _MM_BROADCAST_1X8:
        CASE conv OF
        _MM_UPCONV_PD_NONE:
            n := j*64
            dst[i+63:i] := addr[63:0]
        ESAC
    _MM_BROADCAST_4X8:
        mod := j%4
        CASE conv OF
        _MM_UPCONV_PD_NONE:
            n := mod*64
            dst[i+63:i] := addr[n+63:n]
        ESAC
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm512_mask_extload_pd

| VMOVAPD_ZMMf64_MASKmskw_MEMf64_AVX512 | VBROADCASTF64X4_ZMMf64_MASKmskw_MEMf64_AVX512 | VBROADCASTSD_ZMMf64_MASKmskw_MEMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Depending on "bc", loads 1, 4, or 8 elements of type and size determined by "conv" from memory address "mt"
and converts all elements to double-precision (64-bit) floating-point elements, storing the results in "dst"
using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). "hint"
indicates to the processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 7
    i := j*64
    IF k[j]
        CASE bc OF
        _MM_BROADCAST64_NONE:
            CASE conv OF
            _MM_UPCONV_PD_NONE:
                n := j*64
                dst[i+63:i] := addr[n+63:n]
            ESAC
        _MM_BROADCAST_1X8:
            CASE conv OF
            _MM_UPCONV_PD_NONE:
                n := j*64
                dst[i+63:i] := addr[63:0]
            ESAC
        _MM_BROADCAST_4X8:
            mod := j%4
            CASE conv OF
            _MM_UPCONV_PD_NONE:
                n := mod*64
                dst[i+63:i] := addr[n+63:n]
            ESAC
        ESAC
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA64 - _mm512_extload_epi64

| VMOVDQA64_ZMMu64_MASKmskw_MEMu64_AVX512 | VBROADCASTI64X4_ZMMu64_MASKmskw_MEMu64_AVX512 | VPBROADCASTQ_ZMMu64_MASKmskw_MEMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Depending on "bc", loads 1, 4, or 8 elements of type and size determined by "conv" from memory address "mt"
and converts all elements to 64-bit integer elements, storing the results in "dst". "hint" indicates to the
processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 7
    i := j*64
    CASE bc OF
    _MM_BROADCAST64_NONE:
        CASE conv OF
        _MM_UPCONV_EPI64_NONE:
            n := j*64
            dst[i+63:i] := addr[n+63:n]
        ESAC
    _MM_BROADCAST_1X8:
        CASE conv OF
        _MM_UPCONV_EPI64_NONE:
            n := j*64
            dst[i+63:i] := addr[63:0]
        ESAC
    _MM_BROADCAST_4X8:
        mod := j%4
        CASE conv OF
        _MM_UPCONV_EPI64_NONE:
            n := mod*64
            dst[i+63:i] := addr[n+63:n]
        ESAC
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVDQA64 - _mm512_mask_extload_epi64

| VMOVDQA64_MEMu64_MASKmskw_ZMMu64_AVX512 | VBROADCASTI64X4_ZMMu64_MASKmskw_MEMu64_AVX512 | VPBROADCASTQ_ZMMu64_MASKmskw_MEMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Depending on "bc", loads 1, 4, or 8 elements of type and size determined by "conv" from memory address "mt"
and converts all elements to 64-bit integer elements, storing the results in "dst" using writemask "k"
(elements are copied from "src" when the corresponding mask bit is not set). "hint" indicates to the processor
whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 7
    i := j*64
    IF k[j]
        CASE bc OF
        _MM_BROADCAST64_NONE:
            CASE conv OF
            _MM_UPCONV_EPI64_NONE:
                n := j*64
                dst[i+63:i] := addr[n+63:n]
            ESAC
        _MM_BROADCAST_1X8:
            CASE conv OF
            _MM_UPCONV_EPI64_NONE:
                n := j*64
                dst[i+63:i] := addr[63:0]
            ESAC
        _MM_BROADCAST_4X8:
            mod := j%4
            CASE conv OF
            _MM_UPCONV_EPI64_NONE:
                n := mod*64
                dst[i+63:i] := addr[n+63:n]
            ESAC
        ESAC
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm512_extstore_ps

| VMOVAPS_MEMf32_MASKmskw_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Downconverts packed single-precision (32-bit) floating-point elements stored in "v" to a smaller type
depending on "conv" and stores them in memory location "mt". "hint" indicates to the processor whether the data
is non-temporal.

[algorithm]

addr := MEM[mt]        
FOR j := 0 to 15
    i := j*32
    CASE conv OF
    _MM_DOWNCONV_PS_NONE:
        addr[i+31:i] := v[i+31:i]
    _MM_DOWNCONV_PS_FLOAT16:
        n := j*16
        addr[n+15:n] := Convert_FP32_To_FP16(v[i+31:i])
    _MM_DOWNCONV_PS_UINT8:
        n := j*8
        addr[n+7:n] := Convert_FP32_To_UInt8(v[i+31:i])
    _MM_DOWNCONV_PS_SINT8:
        n := j*8
        addr[n+7:n] := Convert_FP32_To_Int8(v[i+31:i])
    _MM_DOWNCONV_PS_UINT16:
        n := j*16
        addr[n+15:n] := Convert_FP32_To_UInt16(v[i+31:i])
    _MM_DOWNCONV_PS_SINT16:
        n := j*16
        addr[n+15:n] := Convert_FP32_To_Int16(v[i+31:i])
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_extstore_epi32

| VMOVDQA32_MEMu32_MASKmskw_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Downconverts packed 32-bit integer elements stored in "v" to a smaller type depending on "conv" and stores
them in memory location "mt". "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 15
    i := j*32
    CASE conv OF
    _MM_DOWNCONV_EPI32_NONE:
        addr[i+31:i] := v[i+31:i]
    _MM_DOWNCONV_EPI32_UINT8:
        n := j*8
        addr[n+7:n] := Int32ToUInt8(v[i+31:i])
    _MM_DOWNCONV_EPI32_SINT8:
        n := j*8
        addr[n+7:n] := Int32ToSInt8(v[i+31:i])
    _MM_DOWNCONV_EPI32_UINT16:
        n := j*16
        addr[n+15:n] := Int32ToUInt16(v[i+31:i])
    _MM_DOWNCONV_EPI32_SINT16:
        n := j*16
        addr[n+15:n] := Int32ToSInt16(v[i+31:i])
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm512_extstore_pd

| VMOVAPD_MEMf64_MASKmskw_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Downconverts packed double-precision (64-bit) floating-point elements stored in "v" to a smaller type
depending on "conv" and stores them in memory location "mt". "hint" indicates to the processor whether the data
is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 7
    i := j*64
    CASE conv OF
    _MM_DOWNCONV_PS_NONE:
        addr[i+63:i] := v[i+63:i]
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVDQA64 - _mm512_extstore_epi64

| VMOVDQA64_MEMu64_MASKmskw_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Downconverts packed 64-bit integer elements stored in "v" to a smaller type depending on "conv" and stores
them in memory location "mt". "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 7
    i := j*64
    CASE conv OF
    _MM_DOWNCONV_EPI64_NONE: addr[i+63:i] := v[i+63:i]
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVAPS - _mm512_mask_extstore_ps

| VMOVAPS_MEMf32_MASKmskw_ZMMf32_AVX512

--------------------------------------------------------------------------------------------------------------
Downconverts packed single-precision (32-bit) floating-point elements stored in "v" to a smaller type
depending on "conv" and stores them in memory location "mt" using writemask "k" (elements are not written to
memory when the corresponding mask bit is not set). "hint" indicates to the processor whether the data is
non-temporal.

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_PS_NONE:
            mt[i+31:i] := v[i+31:i]
        _MM_DOWNCONV_PS_FLOAT16:
            n := j*16
            mt[n+15:n] := Convert_FP32_To_FP16(v[i+31:i])
        _MM_DOWNCONV_PS_UINT8:
            n := j*8
            mt[n+7:n] := Convert_FP32_To_UInt8(v[i+31:i])
        _MM_DOWNCONV_PS_SINT8:
            n := j*8
            mt[n+7:n] := Convert_FP32_To_Int8(v[i+31:i])
        _MM_DOWNCONV_PS_UINT16:
            n := j*16
            mt[n+15:n] := Convert_FP32_To_UInt16(v[i+31:i])
        _MM_DOWNCONV_PS_SINT16:
            n := j*16
            mt[n+15:n] := Convert_FP32_To_Int16(v[i+31:i])
        ESAC
     FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVAPD - _mm512_mask_extstore_pd

| VMOVAPD_MEMf64_MASKmskw_ZMMf64_AVX512

--------------------------------------------------------------------------------------------------------------
Downconverts packed double-precision (64-bit) floating-point elements stored in "v" to a smaller type
depending on "conv" and stores them in memory location "mt" (elements in "mt" are unaltered when the
corresponding mask bit is not set). "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]        
FOR j := 0 to 7
    i := j*64
    CASE conv OF
    _MM_DOWNCONV_PD_NONE:
        IF k[j]
            mt[i+63:i] := v[i+63:i]
        FI
    ESAC
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVDQA32 - _mm512_mask_extstore_epi32

| VMOVDQA32_MEMu32_MASKmskw_ZMMu32_AVX512

--------------------------------------------------------------------------------------------------------------
Downconverts packed 32-bit integer elements stored in "v" to a smaller type depending on "conv" and stores
them in memory location "mt" (elements in "mt" are unaltered when the corresponding mask bit is not set).
"hint" indicates to the processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 15
    i := j*32
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_EPI32_NONE:
            addr[i+31:i] := v[i+31:i]
        _MM_DOWNCONV_EPI32_UINT8:
            n := j*8
            addr[n+7:n] := Int32ToUInt8(v[i+31:i])
        _MM_DOWNCONV_EPI32_SINT8:
            n := j*8
            addr[n+7:n] := Int32ToSInt8(v[i+31:i])
        _MM_DOWNCONV_EPI32_UINT16:
            n := j*16
            addr[n+15:n] := Int32ToUInt16(v[i+31:i])
        _MM_DOWNCONV_EPI32_SINT16:
            n := j*16
            addr[n+15:n] := Int32ToSInt16(v[i+31:i])
        ESAC
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVDQA64 - _mm512_mask_extstore_epi64

| VMOVDQA64_MEMu64_MASKmskw_ZMMu64_AVX512

--------------------------------------------------------------------------------------------------------------
Downconverts packed 64-bit integer elements stored in "v" to a smaller type depending on "conv" and stores
them in memory location "mt" (elements in "mt" are unaltered when the corresponding mask bit is not set).
"hint" indicates to the processor whether the data is non-temporal.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 7
    i := j*64
    IF k[j]
        CASE conv OF
        _MM_DOWNCONV_EPI64_NONE: addr[i+63:i] := v[i+63:i]
        ESAC
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVNRAPS - _mm512_storenr_ps

| 

--------------------------------------------------------------------------------------------------------------
Stores packed single-precision (32-bit) floating-point elements from "v" to memory address "mt" with a no-read
hint to the processor.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 15
    i := j*32
    addr[i+31:i] := v[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVNRAPD - _mm512_storenr_pd

| 

--------------------------------------------------------------------------------------------------------------
Stores packed double-precision (64-bit) floating-point elements from "v" to memory address "mt" with a no-read
hint to the processor.

[algorithm]

addr := MEM[mt]
FOR j := 0 to 7
    i := j*64
    addr[i+63:i] := v[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVNRNGOAPS - _mm512_storenrngo_ps

| 

--------------------------------------------------------------------------------------------------------------
Stores packed single-precision (32-bit) floating-point elements from "v" to memory address "mt" with a no-read
hint and using a weakly-ordered memory consistency model (stores performed with this function are not globally
ordered, and subsequent stores from the same thread can be observed before them).

[algorithm]

addr := MEM[mt]
FOR j := 0 to 15
    i := j*32
    addr[i+31:i] := v[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VMOVNRNGOAPD - _mm512_storenrngo_pd

| 

--------------------------------------------------------------------------------------------------------------
Stores packed double-precision (64-bit) floating-point elements from "v" to memory address "mt" with a no-read
hint and using a weakly-ordered memory consistency model (stores performed with this function are not globally
ordered, and subsequent stores from the same thread can be observed before them).

[algorithm]

addr := MEM[mt]
FOR j := 0 to 7
    i := j*64
    addr[i+63:i] := v[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPADCD - _mm512_adc_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element addition of packed 32-bit integers in "v2" and "v3" and the corresponding bit in
"k2", storing the result of the addition in "dst" and the result of the carry in "k2_res".

[algorithm]

FOR j := 0 to 15
    i := j*32
    k2_res[j]   := Carry(v2[i+31:i] + v3[i+31:i] + k2[j])
    dst[i+31:i] := v2[i+31:i] + v3[i+31:i] + k2[j]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPADCD - _mm512_mask_adc_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element addition of packed 32-bit integers in "v2" and "v3" and the corresponding bit in
"k2", storing the result of the addition in "dst" and the result of the carry in "k2_res" using writemask "k1"
(elements are copied from "v2" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        k2_res[j]   := Carry(v2[i+31:i] + v3[i+31:i] + k2[j])
        dst[i+31:i] := v2[i+31:i] + v3[i+31:i] + k2[j]
    ELSE
        dst[i+31:i] := v2[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDNPD - _mm512_addn_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element addition between packed double-precision (64-bit) floating-point elements in "v2"
and "v3" and negates their sum, storing the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := -(v2[i+63:i] + v3[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDNPD - _mm512_mask_addn_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element addition between packed double-precision (64-bit) floating-point elements in "v2"
and "v3" and negates their sum, storing the results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(v2[i+63:i] + v3[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDNPS - _mm512_addn_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element addition between packed single-precision (32-bit) floating-point elements in "v2"
and "v3" and negates their sum, storing the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := -(v2[i+31:i] + v3[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDNPS - _mm512_mask_addn_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element addition between packed single-precision (32-bit) floating-point elements in "v2"
and "v3" and negates their sum, storing the results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(v2[i+31:i] + v3[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDNPD - _mm512_addn_round_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element by element addition between packed double-precision (64-bit) floating-point elements in "v2"
and "v3" and negates the sum, storing the result in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := -(v2[i+63:i] + v3[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDNPD - _mm512_mask_addn_round_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element by element addition between packed double-precision (64-bit) floating-point elements in "v2"
and "v3" and negates the sum, storing the result in "dst" using writemask "k" (elements are copied from "src"
when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := -(v2[i+63:i] + v3[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDNPS - _mm512_addn_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element by element addition between packed single-precision (32-bit) floating-point elements in "v2"
and "v3" and negates the sum, storing the result in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := -(v2[i+31:i] + v3[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDNPS - _mm512_mask_addn_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element by element addition between packed single-precision (32-bit) floating-point elements in "v2"
and "v3" and negates the sum, storing the result in "dst" using writemask "k" (elements are copied from "src"
when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := -(v2[i+31:i] + v3[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBRPD - _mm512_subr_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed double-precision (64-bit) floating-point elements in "v2"
from "v3" storing the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := v3[i+63:i] - v2[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBRPD - _mm512_mask_subr_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed double-precision (64-bit) floating-point elements in "v2"
from "v3" storing the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := v3[i+63:i] - v2[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBRPS - _mm512_subr_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed single-precision (32-bit) floating-point elements in "v2"
from "v3" storing the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v3[i+31:i] - v2[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBRPS - _mm512_mask_subr_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed single-precision (32-bit) floating-point elements in "v2"
from "v3" storing the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := v3[i+31:i] - v2[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBRPD - _mm512_subr_round_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed double-precision (64-bit) floating-point elements in "v2"
from "v3" storing the results in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := v3[i+63:i] - v2[i+63:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBRPD - _mm512_mask_subr_round_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed double-precision (64-bit) floating-point elements in "v2"
from "v3" storing the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := v3[i+63:i] - v2[i+63:i]
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBRPS - _mm512_subr_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed single-precision (32-bit) floating-point elements in "v2"
from "v3" storing the results in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v3[i+31:i] - v2[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSUBRPS - _mm512_mask_subr_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed single-precision (32-bit) floating-point elements in "v2"
from "v3" storing the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := v3[i+31:i] - v2[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBRD - _mm512_subr_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed 32-bit integer elements in "v2" from "v3" storing the
results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v3[i+31:i] - v2[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBRD - _mm512_mask_subr_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed 32-bit integer elements in "v2" from "v3" storing the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set)

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := v3[i+31:i] - v2[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDSETCD - _mm512_addsetc_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element addition of packed 32-bit integer elements in "v2" and "v3", storing the resultant
carry in "k2_res" (carry flag) and the addition results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v2[i+31:i] + v3[i+31:i]
    k2_res[j] := Carry(v2[i+31:i] + v3[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDSETCD - _mm512_mask_addsetc_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element addition of packed 32-bit integer elements in "v2" and "v3", storing the resultant
carry in "k2_res" (carry flag) and the addition results in "dst" using writemask "k" (elements are copied from
"v2" and "k_old" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := v2[i+31:i] + v3[i+31:i]
    ELSE
        dst[i+31:i] := v2[i+31:i]
        k2_res[j] := k_old[j]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDSETSD - _mm512_addsets_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element addition of packed 32-bit integer elements in "v2" and "v3", storing the
results in "dst" and the sign of the sum in "sign" (sign flag).

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v2[i+31:i] + v3[i+31:i]
    sign[j] := v2[i+31:i] &amp; v3[i+31:i] &amp; 0x80000000
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPADDSETSD - _mm512_mask_addsets_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element addition of packed 32-bit integer elements in "v2" and "v3", storing the
results in "dst" and the sign of the sum in "sign" (sign flag). Results are stored using writemask "k"
(elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := v2[i+31:i] + v3[i+31:i]
        sign[j] := v2[i+31:i] &amp; v3[i+31:i] &amp; 0x80000000
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDSETSPS - _mm512_addsets_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element addition of packed single-precision (32-bit) floating-point elements in "v2"
and "v3", storing the results in "dst" and the sign of the sum in "sign" (sign flag).

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v2[i+31:i] + v3[i+31:i]
    sign[j] := v2[i+31:i] &amp; v3[i+31:i] &amp; 0x80000000
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDSETSPS - _mm512_mask_addsets_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element addition of packed single-precision (32-bit) floating-point elements in "v2"
and "v3", storing the results in "dst" and the sign of the sum in "sign" (sign flag). Results are stored using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := v2[i+31:i] + v3[i+31:i]
        sign[j] := v2[i+31:i] &amp; v3[i+31:i] &amp; 0x80000000
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDSETSPS - _mm512_addsets_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element addition of packed single-precision (32-bit) floating-point elements in "v2"
and "v3", storing the results in "dst" and the sign of the sum in "sign" (sign flag).
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v2[i+31:i] + v3[i+31:i]
    sign[j] := v2[i+31:i] &amp; v3[i+31:i] &amp; 0x80000000
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VADDSETSPS - _mm512_mask_addsets_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element addition of packed single-precision (32-bit) floating-point elements in "v2"
and "v3", storing the results in "dst" and the sign of the sum in "sign" (sign flag). Results are stored using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := v2[i+31:i] + v3[i+31:i]
        sign[j] := v2[i+31:i] &amp; v3[i+31:i] &amp; 0x80000000
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBSETBD - _mm512_subsetb_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed 32-bit integer elements in "v3" from "v2", storing the
results in "dst" and the nth borrow bit in the nth position of "borrow" (borrow flag).

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v2[i+31:i] - v3[i+31:i]
    borrow[j] := Borrow(v2[i+31:i] - v3[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBSETBD - _mm512_mask_subsetb_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed 32-bit integer elements in "v3" from "v2", storing the
results in "dst" and the nth borrow bit in the nth position of "borrow" (borrow flag). Results are stored using
writemask "k" (elements are copied from "v2" and "k_old" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := v2[i+31:i] - v3[i+31:i]
        borrow[j] := Borrow(v2[i+31:i] - v3[i+31:i])
    ELSE
        dst[i+31:i] := v3[i+31:i]
        borrow[j] := k_old[j]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBRSETBD - _mm512_subrsetb_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed 32-bit integer elements in "v2" from "v3", storing the
results in "dst" and "v2". The borrowed value from the subtraction difference for the nth element is written to
the nth bit of "borrow" (borrow flag).

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v3[i+31:i] - v2[i+31:i]
    borrow[j] := Borrow(v3[i+31:i] - v2[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSUBRSETBD - _mm512_mask_subrsetb_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element subtraction of packed 32-bit integer elements in "v2" from "v3", storing the
results in "dst" and "v2". The borrowed value from the subtraction difference for the nth element is written to
the nth bit of "borrow" (borrow flag). Results are written using writemask "k" (elements are copied from "k" to
"k_old" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        diff := v3[i+31:i] - v2[i+31:i]
        borrow[j] := Borrow(v3[i+31:i] - v2[i+31:i])
        dst[i+31:i] := diff
        v2[i+31:i] := diff
    ELSE
        borrow[j] := k_old[j]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSBBD - _mm512_sbb_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element three-input subtraction of packed 32-bit integer elements of "v3" as well as the
corresponding bit from "k" from "v2". The borrowed value from the subtraction difference for the nth element is
written to the nth bit of "borrow" (borrow flag). Results are stored in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v2[i+31:i] - v3[i+31:i] - k[j]
    borrow[j] := Borrow(v2[i+31:i] - v3[i+31:i] - k[j])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSBBD - _mm512_mask_sbb_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element three-input subtraction of packed 32-bit integer elements of "v3" as well as the
corresponding bit from "k2" from "v2". The borrowed value from the subtraction difference for the nth element
is written to the nth bit of "borrow" (borrow flag). Results are stored in "dst" using writemask "k1" (elements
are copied from "v2" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        dst[i+31:i] := v2[i+31:i] - v3[i+31:i] - k2[j]
        borrow[j] := Borrow(v2[i+31:i] - v3[i+31:i] - k2[j])
    ELSE
        dst[i+31:i] := v2[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSBBRD - _mm512_sbbr_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element three-input subtraction of packed 32-bit integer elements of "v2" as well as the
corresponding bit from "k" from "v3". The borrowed value from the subtraction difference for the nth element is
written to the nth bit of "borrow" (borrow flag). Results are stored in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v3[i+31:i] - v2[i+31:i] - k[j]
    borrow[j] := Borrow(v2[i+31:i] - v3[i+31:i] - k[j])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSBBRD - _mm512_mask_sbbr_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element three-input subtraction of packed 32-bit integer elements of "v2" as well as the
corresponding bit from "k2" from "v3". The borrowed value from the subtraction difference for the nth element
is written to the nth bit of "borrow" (borrow flag). Results are stored in "dst" using writemask "k1" (elements
are copied from "v2" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k1[j]
        dst[i+31:i] := v3[i+31:i] - v2[i+31:i] - k2[j]
        borrow[j] := Borrow(v2[i+31:i] - v3[i+31:i] - k2[j])
    ELSE
        dst[i+31:i] := v2[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPD2PS - _mm512_cvt_roundpd_pslo

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of packed double-precision (64-bit) floating-point elements in "v2" to
packed single-precision (32-bit) floating-point elements, storing the results in "dst". Results are written to
the lower half of "dst", and the upper half locations are set to '0'.
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    k := j*32
    dst[k+31:k] := Convert_FP64_To_FP32(v2[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTPD2PS - _mm512_mask_cvt_roundpd_pslo

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of packed double-precision (64-bit) floating-point elements in "v2" to
packed single-precision (32-bit) floating-point elements, storing the results in "dst" using writemask "k"
(elements are copied from "src" when the corresponding mask bit is not set). Results are written to the lower
half of "dst", and the upper half locations are set to '0'.
	[round_note]

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

## VCVTFXPNTPD2UDQ - _mm512_cvtfxpnt_roundpd_epu32lo

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of packed double-precision (64-bit) floating-point elements in "v2" to
packed 32-bit unsigned integer elements, storing the results in "dst". Results are written to the lower half of
"dst", and the upper half locations are set to '0'.
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    k := j*32
    dst[k+31:k] := Convert_FP64_To_Int32(v2[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTFXPNTPD2UDQ - _mm512_mask_cvtfxpnt_roundpd_epu32lo

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of packed double-precision (64-bit) floating-point elements in "v2" to
packed 32-bit unsigned integer elements, storing the results in "dst" using writemask "k" (elements are copied
from "src" when the corresponding mask bit is not set). Results are written to the lower half of "dst", and the
upper half locations are set to '0'.
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    l := j*32
    IF k[j]
        dst[l+31:l] := Convert_FP64_To_Int32(v2[i+63:i])
    ELSE
        dst[l+31:l] := src[l+31:l]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTFXPNTPS2DQ - _mm512_cvtfxpnt_round_adjustps_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of packed single-precision (32-bit) floating-point elements in "v2" to
packed 32-bit integer elements and performs an optional exponent adjust using "expadj", storing the results in
"dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v2[i+31:i]
    CASE expadj OF
    _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
    _MM_EXPADJ_4:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
    _MM_EXPADJ_5:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
    _MM_EXPADJ_8:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
    _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
    _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
    _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
    _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
    ESAC
    dst[i+31:i] := Float32ToInt32(dst[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTFXPNTPS2UDQ - _mm512_cvtfxpnt_round_adjustps_epu32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of packed single-precision (32-bit) floating-point elements in "v2" to
packed 32-bit unsigned integer elements and performing an optional exponent adjust using "expadj", storing the
results in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := v2[i+31:i]
    CASE expadj OF
    _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
    _MM_EXPADJ_4:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
    _MM_EXPADJ_5:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
    _MM_EXPADJ_8:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
    _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
    _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
    _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
    _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
    ESAC
    dst[i+31:i] := Float32ToUInt32(dst[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTFXPNTUDQ2PS - _mm512_cvtfxpnt_round_adjustepu32_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of packed 32-bit unsigned integer elements in "v2" to packed
single-precision (32-bit) floating-point elements and performing an optional exponent adjust using "expadj",
storing the results in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := UInt32ToFloat32(v2[i+31:i])
    CASE expadj OF
    _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
    _MM_EXPADJ_4:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
    _MM_EXPADJ_5:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
    _MM_EXPADJ_8:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
    _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
    _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
    _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
    _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTFXPNTUDQ2PS - _mm512_mask_cvtfxpnt_round_adjustepu32_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of packed 32-bit unsigned integer elements in "v2" to packed
single-precision (32-bit) floating-point elements and performing an optional exponent adjust using "expadj",
storing the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := Int32ToFloat32(v2[i+31:i])
        CASE expadj OF
        _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
        _MM_EXPADJ_4:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
        _MM_EXPADJ_5:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
        _MM_EXPADJ_8:     dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
        _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
        _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
        _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
        _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
        ESAC
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VEXP223PS - _mm512_exp223_ps

| 

--------------------------------------------------------------------------------------------------------------
Approximates the base-2 exponent of the packed single-precision (32-bit) floating-point elements in "v2" with
eight bits for sign and magnitude and 24 bits for the fractional part. Results are stored in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := exp223(v2[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VEXP223PS - _mm512_mask_exp223_ps

| 

--------------------------------------------------------------------------------------------------------------
Approximates the base-2 exponent of the packed single-precision (32-bit) floating-point elements in "v2" with
eight bits for sign and magnitude and 24 bits for the fractional part. Results are stored in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := exp223(v2[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFIXUPNANPD - _mm512_fixupnan_pd

| 

--------------------------------------------------------------------------------------------------------------
Fixes up NaN's from packed double-precision (64-bit) floating-point elements in "v1" and "v2", storing the
results in "dst" and storing the quietized NaN's from "v1" in "v3".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := FixupNaNs(v1[i+63:i], v2[i+63:i])
    v3[i+63:i] := QuietizeNaNs(v1[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFIXUPNANPD - _mm512_mask_fixupnan_pd

| 

--------------------------------------------------------------------------------------------------------------
Fixes up NaN's from packed double-precision (64-bit) floating-point elements in "v1" and "v2", storing the
results in "dst" using writemask "k" (only elements whose corresponding mask bit is set are used in the
computation). Quietized NaN's from "v1" are stored in "v3".

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := FixupNaNs(v1[i+63:i], v2[i+63:i])
        v3[i+63:i] := QuietizeNaNs(v1[i+63:i])
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFIXUPNANPS - _mm512_fixupnan_ps

| 

--------------------------------------------------------------------------------------------------------------
Fixes up NaN's from packed single-precision (32-bit) floating-point elements in "v1" and "v2", storing the
results in "dst" and storing the quietized NaN's from "v1" in "v3".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := FixupNaNs(v1[i+31:i], v2[i+31:i])
    v3[i+31:i] := QuietizeNaNs(v1[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFIXUPNANPS - _mm512_mask_fixupnan_ps

| 

--------------------------------------------------------------------------------------------------------------
Fixes up NaN's from packed single-precision (32-bit) floating-point elements in "v1" and "v2", storing the
results in "dst" using writemask "k" (only elements whose corresponding mask bit is set are used in the
computation). Quietized NaN's from "v1" are stored in "v3".

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := FixupNaNs(v1[i+31:i], v2[i+31:i])
        v3[i+31:i] := QuietizeNaNs(v1[i+31:i])
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHD - _mm512_extloadunpackhi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt-64, up-converted depending on the value of "conv", and expanded into packed 32-bit integers in "dst". The
initial values of "dst" are copied from "src". Only those converted doublewords that occur at or after the
first 64-byte-aligned address following (mt-64) are loaded. Elements in the resulting vector that do not map to
those doublewords are taken from "src". "hint" indicates to the processor whether the loaded data is
non-temporal.

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_EPI32_UINT8:
        RETURN ZeroExtend32(MEM[addr + offset])
    _MM_UPCONV_EPI32_SINT8:
        RETURN SignExtend32(MEM[addr + offset])
    _MM_UPCONV_EPI32_UINT16:
        RETURN ZeroExtend32(MEM[addr + 2*offset])
    _MM_UPCONV_EPI32_SINT16:
        RETURN SignExtend32(MEM[addr + 2*offset])
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:
        RETURN 4
    _MM_UPCONV_EPI32_UINT8:
        RETURN 1
    _MM_UPCONV_EPI32_SINT8:
        RETURN 1
    _MM_UPCONV_EPI32_UINT16:
        RETURN 2
    _MM_UPCONV_EPI32_SINT16:
        RETURN 2
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
upSize := UPCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 15
    IF foundNext64BytesBoundary == false
        IF (addr + (loadOffset + 1)*upSize % 64) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*32
        dst[i+31:i] := UPCONVERT(addr, loadOffset, conv)
    FI
    loadOffset := loadOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHD - _mm512_mask_extloadunpackhi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt-64, up-converted depending on the value of "conv", and expanded into packed 32-bit integers in "dst". The
initial values of "dst" are copied from "src". Only those converted doublewords that occur at or after the
first 64-byte-aligned address following (mt-64) are loaded. Elements in the resulting vector that do not map to
those doublewords are taken from "src". "hint" indicates to the processor whether the loaded data is
non-temporal. Elements are copied to "dst" according to element selector "k" (elements are skipped when the
corresponding mask bit is not set).

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_EPI32_UINT8:
        RETURN ZeroExtend32(MEM[addr + offset])
    _MM_UPCONV_EPI32_SINT8:
        RETURN SignExtend32(MEM[addr + offset])
    _MM_UPCONV_EPI32_UINT16:
        RETURN ZeroExtend32(MEM[addr + 2*offset])
    _MM_UPCONV_EPI32_SINT16:
        RETURN SignExtend32(MEM[addr + 2*offset])
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:
        RETURN 4
    _MM_UPCONV_EPI32_UINT8:
        RETURN 1
    _MM_UPCONV_EPI32_SINT8:
        RETURN 1
    _MM_UPCONV_EPI32_UINT16:
        RETURN 2
    _MM_UPCONV_EPI32_SINT16:
        RETURN 2
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
upSize := UPCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 15
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF (addr + (loadOffset + 1)*upSize % 64) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*32
            dst[i+31:i] := UPCONVERT(addr, loadOffset, conv)
        FI
        loadOffset := loadOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLD - _mm512_extloadunpacklo_epi32

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt, up-converted depending on the value of "conv", and expanded into packed 32-bit integers in "dst". The
initial values of "dst" are copied from "src". Only those converted doublewords that occur before first
64-byte-aligned address following "mt" are loaded. Elements in the resulting vector that do not map to those
doublewords are taken from "src". "hint" indicates to the processor whether the loaded data is non-temporal.

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_EPI32_UINT8:
        RETURN ZeroExtend32(MEM[addr + offset])
    _MM_UPCONV_EPI32_SINT8:
        RETURN SignExtend32(MEM[addr + offset])
    _MM_UPCONV_EPI32_UINT16:
        RETURN ZeroExtend32(MEM[addr + 2*offset])
    _MM_UPCONV_EPI32_SINT16:
        RETURN SignExtend32(MEM[addr + 2*offset])
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:
        RETURN 4
    _MM_UPCONV_EPI32_UINT8:
        RETURN 1
    _MM_UPCONV_EPI32_SINT8:
        RETURN 1
    _MM_UPCONV_EPI32_UINT16:
        RETURN 2
    _MM_UPCONV_EPI32_SINT16:
        RETURN 2
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
upSize := UPCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := UPCONVERT(addr, loadOffset, conv)
    loadOffset := loadOffset + 1
    IF (mt + loadOffset * upSize) % 64 == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLD - _mm512_mask_extloadunpacklo_epi32

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt, up-converted depending on the value of "conv", and expanded into packed 32-bit integers in "dst". The
initial values of "dst" are copied from "src". Only those converted doublewords that occur before first
64-byte-aligned address following "mt" are loaded. Elements in the resulting vector that do not map to those
doublewords are taken from "src". "hint" indicates to the processor whether the loaded data is non-temporal.
Elements are copied to "dst" according to element selector "k" (elements are skipped when the corresponding
mask bit is not set).

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_EPI32_UINT8:
        RETURN ZeroExtend32(MEM[addr + offset])
    _MM_UPCONV_EPI32_SINT8:
        RETURN SignExtend32(MEM[addr + offset])
    _MM_UPCONV_EPI32_UINT16:
        RETURN ZeroExtend32(MEM[addr + 2*offset])
    _MM_UPCONV_EPI32_SINT16:
        RETURN SignExtend32(MEM[addr + 2*offset])
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI32_NONE:
        RETURN 4
    _MM_UPCONV_EPI32_UINT8:
        RETURN 1
    _MM_UPCONV_EPI32_SINT8:
        RETURN 1
    _MM_UPCONV_EPI32_UINT16:
        RETURN 2
    _MM_UPCONV_EPI32_SINT16:
        RETURN 2
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
upSize := UPCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 15
    IF k[j]
        i := j*32
        dst[i+31:i] := UPCONVERT(addr, loadOffset, conv)
        loadOffset := loadOffset + 1
        IF (mt + loadOffset * upSize) % 64 == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHQ - _mm512_extloadunpackhi_epi64

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the quadword stream starting at element-aligned address mt-64,
up-converted depending on the value of "conv", and expanded into packed 64-bit integers in "dst". The initial
values of "dst" are copied from "src". Only those converted quadwords that occur at or after the first
64-byte-aligned address following (mt-64) are loaded. Elements in the resulting vector that do not map to those
quadwords are taken from "src". "hint" indicates to the processor whether the loaded data is non-temporal.

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI64_NONE:
        RETURN MEM[addr + 8*offset]
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI64_NONE:
        RETURN 8
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
upSize := UPCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 7
    IF foundNext64BytesBoundary == false
        IF (addr + (loadOffset + 1)*upSize) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*64
        dst[i+63:i] := UPCONVERT(addr, loadOffset, conv)
    FI
    loadOffset := loadOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHQ - _mm512_mask_extloadunpackhi_epi64

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the quadword stream starting at element-aligned address mt-64,
up-converted depending on the value of "conv", and expanded into packed 64-bit integers in "dst". The initial
values of "dst" are copied from "src". Only those converted quadwords that occur at or after the first
64-byte-aligned address following (mt-64) are loaded. Elements in the resulting vector that do not map to those
quadwords are taken from "src". "hint" indicates to the processor whether the loaded data is non-temporal.
Elements are copied to "dst" according to element selector "k" (elements are skipped when the corresponding
mask bit is not set).

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI64_NONE:
        RETURN MEM[addr + 8*offset]
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI64_NONE:
        RETURN 8
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
upSize := UPCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 7
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF (addr + (loadOffset + 1)*upSize) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*64
            dst[i+63:i] := UPCONVERT(addr, loadOffset, conv)
        FI
        loadOffset := loadOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLQ - _mm512_extloadunpacklo_epi64

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the quadword stream starting at element-aligned address mt,
up-converted depending on the value of "conv", and expanded into packed 64-bit integers in "dst". The initial
values of "dst" are copied from "src". Only those converted quad that occur before first 64-byte-aligned
address following "mt" are loaded. Elements in the resulting vector that do not map to those quadwords are
taken from "src". "hint" indicates to the processor whether the loaded data is non-temporal.

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI64_NONE:
        RETURN MEM[addr + 8*offset]
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI64_NONE:
        RETURN 8
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
upSize := UPCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := UPCONVERT(addr, loadOffset, conv)
    loadOffset := loadOffset + 1
    IF (addr + loadOffset*upSize % 64) == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLQ - _mm512_mask_extloadunpacklo_epi64

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the quadword stream starting at element-aligned address mt,
up-converted depending on the value of "conv", and expanded into packed 64-bit integers in "dst". The initial
values of "dst" are copied from "src". Only those converted quadwords that occur before first 64-byte-aligned
address following "mt" are loaded. Elements in the resulting vector that do not map to those quadwords are
taken from "src". "hint" indicates to the processor whether the loaded data is non-temporal. Elements are
copied to "dst" according to element selector "k" (elements are skipped when the corresponding mask bit is not
set).

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI64_NONE:
        RETURN MEM[addr + 8*offset]
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_EPI64_NONE:
        RETURN 8
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
upSize := UPCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 7
    IF k[j]
        i := j*64
        dst[i+63:i] := UPCONVERT(addr, loadOffset, conv)
        loadOffset := loadOffset + 1
        IF (addr + loadOffset*upSize % 64) == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHPS - _mm512_extloadunpackhi_ps

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt-64, up-converted depending on the value of "conv", and expanded into packed single-precision (32-bit)
floating-point elements in "dst". The initial values of "dst" are copied from "src". Only those converted
quadwords that occur at or after the first 64-byte-aligned address following (mt-64) are loaded. Elements in
the resulting vector that do not map to those quadwords are taken from "src". "hint" indicates to the processor
whether the loaded data is non-temporal.

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PS_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP16_To_FP32(MEM[addr + 4*offset])
    _MM_UPCONV_PS_UINT8:
        RETURN Convert_UInt8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_SINT8:
        RETURN Convert_Int8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_UINT16:
        RETURN Convert_UInt16_To_FP32(MEM[addr + 2*offset])
    _MM_UPCONV_PS_SINT16:
        RETURN Convert_Int16_To_FP32(MEM[addr + 2*offset])
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_PS_NONE:
        RETURN 4
    _MM_UPCONV_PS_FLOAT16:
        RETURN 2
    _MM_UPCONV_PS_UINT8:
        RETURN 1
    _MM_UPCONV_PS_SINT8:
        RETURN 1
    _MM_UPCONV_PS_UINT16:
        RETURN 2
    _MM_UPCONV_PS_SINT16:
        RETURN 2
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
upSize := UPCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 15
    IF foundNext64BytesBoundary == false
        IF (addr + (loadOffset + 1)*upSize % 64) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*32
        dst[i+31:i] := UPCONVERT(addr, loadOffset, conv)
    FI
    loadOffset := loadOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHPS - _mm512_mask_extloadunpackhi_ps

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt-64, up-converted depending on the value of "conv", and expanded into packed single-precision (32-bit)
floating-point elements in "dst". The initial values of "dst" are copied from "src". Only those converted
quadwords that occur at or after the first 64-byte-aligned address following (mt-64) are loaded. Elements in
the resulting vector that do not map to those quadwords are taken from "src". "hint" indicates to the processor
whether the loaded data is non-temporal. Elements are copied to "dst" according to element selector "k"
(elements are skipped when the corresponding mask bit is not set).

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PS_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP16_To_FP32(MEM[addr + 4*offset])
    _MM_UPCONV_PS_UINT8:
        RETURN Convert_UInt8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_SINT8:
        RETURN Convert_Int8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_UINT16:
        RETURN Convert_UInt16_To_FP32(MEM[addr + 2*offset])
    _MM_UPCONV_PS_SINT16:
        RETURN Convert_Int16_To_FP32(MEM[addr + 2*offset])
    ESAC
}
DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PS_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP16_To_FP32(MEM[addr + 4*offset])
    _MM_UPCONV_PS_UINT8:
        RETURN Convert_UInt8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_SINT8:
        RETURN Convert_Int8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_UINT16:
        RETURN Convert_UInt16_To_FP32(MEM[addr + 2*offset])
    _MM_UPCONV_PS_SINT16:
        RETURN Convert_Int16_To_FP32(MEM[addr + 2*offset])
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
upSize := UPCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 15
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF (addr + (loadOffset + 1)*upSize % 64) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*32
            dst[i+31:i] := UPCONVERT(addr, loadOffset, conv)
        FI
        loadOffset := loadOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLPS - _mm512_extloadunpacklo_ps

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt, up-converted depending on the value of "conv", and expanded into packed single-precision (32-bit)
floating-point elements in "dst". The initial values of "dst" are copied from "src". Only those converted
doublewords that occur before first 64-byte-aligned address following "mt" are loaded. Elements in the
resulting vector that do not map to those doublewords are taken from "src". "hint" indicates to the processor
whether the loaded data is non-temporal.

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PS_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP16_To_FP32(MEM[addr + 4*offset])
    _MM_UPCONV_PS_UINT8:
        RETURN Convert_UInt8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_SINT8:
        RETURN Convert_Int8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_UINT16:
        RETURN Convert_UInt16_To_FP32(MEM[addr + 2*offset])
    _MM_UPCONV_PS_SINT16:
        RETURN Convert_Int16_To_FP32(MEM[addr + 2*offset])
    ESAC
}
DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PS_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP16_To_FP32(MEM[addr + 4*offset])
    _MM_UPCONV_PS_UINT8:
        RETURN Convert_UInt8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_SINT8:
        RETURN Convert_Int8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_UINT16:
        RETURN Convert_UInt16_To_FP32(MEM[addr + 2*offset])
    _MM_UPCONV_PS_SINT16:
        RETURN Convert_Int16_To_FP32(MEM[addr + 2*offset])
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
upSize := UPCONVERTSIZE(conv)
addr := MEM[mt]
FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := UPCONVERT(addr, loadOffset, conv)
    loadOffset := loadOffset + 1
    IF (mt + loadOffset * upSize) % 64 == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLPS - _mm512_mask_extloadunpacklo_ps

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt, up-converted depending on the value of "conv", and expanded into packed single-precision (32-bit)
floating-point elements in "dst". The initial values of "dst" are copied from "src". Only those converted
doublewords that occur before first 64-byte-aligned address following "mt" are loaded. Elements in the
resulting vector that do not map to those doublewords are taken from "src". "hint" indicates to the processor
whether the loaded data is non-temporal. Elements are copied to "dst" according to element selector "k"
(elements are skipped when the corresponding mask bit is not set).

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PS_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP16_To_FP32(MEM[addr + 4*offset])
    _MM_UPCONV_PS_UINT8:
        RETURN Convert_UInt8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_SINT8:
        RETURN Convert_Int8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_UINT16:
        RETURN Convert_UInt16_To_FP32(MEM[addr + 2*offset])
    _MM_UPCONV_PS_SINT16:
        RETURN Convert_Int16_To_FP32(MEM[addr + 2*offset])
    ESAC
}
DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PS_NONE:
        RETURN MEM[addr + 4*offset]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP16_To_FP32(MEM[addr + 4*offset])
    _MM_UPCONV_PS_UINT8:
        RETURN Convert_UInt8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_SINT8:
        RETURN Convert_Int8_To_FP32(MEM[addr + offset])
    _MM_UPCONV_PS_UINT16:
        RETURN Convert_UInt16_To_FP32(MEM[addr + 2*offset])
    _MM_UPCONV_PS_SINT16:
        RETURN Convert_Int16_To_FP32(MEM[addr + 2*offset])
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
upSize := UPCONVERTSIZE(conv)
addr := MEM[mt]
FOR j := 0 to 15
    IF k[j]
        i := j*32
        dst[i+31:i] := UPCONVERT(addr, loadOffset, conv)
        loadOffset := loadOffset + 1
        IF (mt + loadOffset * upSize) % 64 == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHPD - _mm512_extloadunpackhi_pd

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the quadword stream starting at element-aligned address mt-64,
up-converted depending on the value of "conv", and expanded into packed double-precision (64-bit)
floating-point values in "dst". The initial values of "dst" are copied from "src". Only those converted
quadwords that occur at or after the first 64-byte-aligned address following (mt-64) are loaded. Elements in
the resulting vector that do not map to those quadwords are taken from "src". "hint" indicates to the processor
whether the loaded data is non-temporal.

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PD_NONE:
        RETURN MEM[addr + 8*offset]
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_PD_NONE:
        RETURN 8
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
upSize := UPCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 7
    IF foundNext64BytesBoundary == false
        IF (addr + (loadOffset + 1)*upSize) % 64 == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*64
        dst[i+63:i] := UPCONVERT(addr, loadOffset, conv)
    FI
    loadOffset := loadOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHPD - _mm512_mask_extloadunpackhi_pd

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the quadword stream starting at element-aligned address mt-64,
up-converted depending on the value of "conv", and expanded into packed double-precision (64-bit)
floating-point values in "dst". The initial values of "dst" are copied from "src". Only those converted
quadwords that occur at or after the first 64-byte-aligned address following (mt-64) are loaded. Elements in
the resulting vector that do not map to those quadwords are taken from "src". "hint" indicates to the processor
whether the loaded data is non-temporal. Elements are copied to "dst" according to element selector "k"
(elements are skipped when the corresponding mask bit is not set).

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PD_NONE:
        RETURN MEM[addr + 8*offset]
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_PD_NONE:
        RETURN 8
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
upSize := UPCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 7
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF (addr + (loadOffset + 1)*upSize) % 64 == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*64
            dst[i+63:i] := UPCONVERT(addr, loadOffset, conv)
        FI
        loadOffset := loadOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLPD - _mm512_extloadunpacklo_pd

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the quadword stream starting at element-aligned address mt,
up-converted depending on the value of "conv", and expanded into packed double-precision (64-bit)
floating-point elements in "dst". The initial values of "dst" are copied from "src". Only those converted quad
that occur before first 64-byte-aligned address following "mt" are loaded. Elements in the resulting vector
that do not map to those quadwords are taken from "src". "hint" indicates to the processor whether the loaded
data is non-temporal.

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PD_NONE:
        RETURN MEM[addr + 8*offset]
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_PD_NONE:
        RETURN 8
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
upSize := UPCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := UPCONVERT(addr, loadOffset, conv)
    loadOffset := loadOffset + 1
    IF (mt + loadOffset * upSize) % 64 == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLPD - _mm512_mask_extloadunpacklo_pd

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the quadword stream starting at element-aligned address mt,
up-converted depending on the value of "conv", and expanded into packed double-precision (64-bit)
floating-point elements in "dst". The initial values of "dst" are copied from "src". Only those converted quad
that occur before first 64-byte-aligned address following "mt" are loaded. Elements in the resulting vector
that do not map to those quadwords are taken from "src". "hint" indicates to the processor whether the loaded
data is non-temporal. Elements are copied to "dst" according to element selector "k" (elemenst are skipped when
the corresponding mask bit is not set).

[algorithm]

DEFINE UPCONVERT(addr, offset, convertTo) {
    CASE conv OF
    _MM_UPCONV_PD_NONE:
        RETURN MEM[addr + 8*offset]
    ESAC
}
DEFINE UPCONVERTSIZE(convertTo) {
    CASE conv OF
    _MM_UPCONV_PD_NONE:
        RETURN 8
    ESAC
}
dst[511:0] := src[511:0]
loadOffset := 0
upSize := UPCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 7
    IF k[j]
        i := j*64
        dst[i+63:i] := UPCONVERT(addr, loadOffset, conv)
        loadOffset := loadOffset + 1
        IF (mt + loadOffset * upSize) % 64 == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHD - _mm512_extpackstorehi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed 32-bit integer elements of "v1" into a byte/word/doubleword stream according
to "conv" at a logically mapped starting address (mt-64), storing the high-64-byte elements of that stream
(those elemetns of the stream that map at or after the first 64-byte-aligned address following (m5-64)). "hint"
indicates to the processor whether the data is non-temporal.

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_DOWNCONV_EPI32_NONE:
        RETURN element[31:0]
    _MM_DOWNCONV_EPI32_UINT8:
        RETURN Truncate8(element[31:0])
    _MM_DOWNCONV_EPI32_SINT8:
        RETURN Saturate8(element[31:0])
    _MM_DOWNCONV_EPI32_UINT16:
        RETURN Truncate16(element[31:0])
    _MM_DOWNCONV_EPI32_SINT16:
        RETURN Saturate16(element[31:0])
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_DOWNCONV_EPI32_NONE:
        RETURN 4
    _MM_DOWNCONV_EPI32_UINT8:
        RETURN 1
    _MM_DOWNCONV_EPI32_SINT8:
        RETURN 1
    _MM_DOWNCONV_EPI32_UINT16:
        RETURN 2
    _MM_DOWNCONV_EPI32_SINT16:
        RETURN 2
    ESAC
}
storeOffset := 0
foundNext64BytesBoundary := false
downSize := DOWNCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 15
    IF foundNext64BytesBoundary == false
        IF ((addr + (storeOffset + 1)*downSize) % 64) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*32
        tmp := DOWNCONVERT(v1[i+31:i], conv)
        storeAddr := addr + storeOffset * downSize
        CASE downSize OF
        4: MEM[storeAddr] := tmp[31:0]
        2: MEM[storeAddr] := tmp[15:0]
        1: MEM[storeAddr] := tmp[7:0]
        ESAC
    FI
    storeOffset := storeOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHD - _mm512_mask_extpackstorehi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed 32-bit integer elements of "v1" into a byte/word/doubleword stream according
to "conv" at a logically mapped starting address (mt-64), storing the high-64-byte elements of that stream
(those elemetns of the stream that map at or after the first 64-byte-aligned address following (m5-64)). "hint"
indicates to the processor whether the data is non-temporal. Elements are stored to memory according to element
selector "k" (elements are skipped when the corresonding mask bit is not set).

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_DOWNCONV_EPI32_NONE:
        RETURN element[31:0]
    _MM_DOWNCONV_EPI32_UINT8:
        RETURN Truncate8(element[31:0])
    _MM_DOWNCONV_EPI32_SINT8:
        RETURN Saturate8(element[31:0])
    _MM_DOWNCONV_EPI32_UINT16:
        RETURN Truncate16(element[31:0])
    _MM_DOWNCONV_EPI32_SINT16:
        RETURN Saturate16(element[31:0])
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_DOWNCONV_EPI32_NONE:
        RETURN 4
    _MM_DOWNCONV_EPI32_UINT8:
        RETURN 1
    _MM_DOWNCONV_EPI32_SINT8:
        RETURN 1
    _MM_DOWNCONV_EPI32_UINT16:
        RETURN 2
    _MM_DOWNCONV_EPI32_SINT16:
        RETURN 2
    ESAC
}
storeOffset := 0
foundNext64BytesBoundary := false
downSize := DOWNCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 15
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF ((addr + (storeOffset + 1)*downSize) % 64) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*32
            tmp := DOWNCONVERT(v1[i+31:i], conv)
            storeAddr := addr + storeOffset * downSize
            CASE downSize OF
            4: MEM[storeAddr] := tmp[31:0]
            2: MEM[storeAddr] := tmp[15:0]
            1: MEM[storeAddr] := tmp[7:0]
            ESAC
        FI
        storeOffset := storeOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELD - _mm512_extpackstorelo_epi32

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed 32-bit integer elements of "v1" into a byte/word/doubleword stream according
to "conv" at a logically mapped starting address "mt", storing the low-64-byte elements of that stream (those
elements of the stream that map before the first 64-byte-aligned address follwing "mt"). "hint" indicates to
the processor whether the data is non-temporal.

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_DOWNCONV_EPI32_NONE:
        RETURN element[31:0]
    _MM_DOWNCONV_EPI32_UINT8:
        RETURN Truncate8(element[31:0])
    _MM_DOWNCONV_EPI32_SINT8:
        RETURN Saturate8(element[31:0])
    _MM_DOWNCONV_EPI32_UINT16:
        RETURN Truncate16(element[31:0])
    _MM_DOWNCONV_EPI32_SINT16:
        RETURN Saturate16(element[31:0])
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_DOWNCONV_EPI32_NONE:
        RETURN 4
    _MM_DOWNCONV_EPI32_UINT8:
        RETURN 1
    _MM_DOWNCONV_EPI32_SINT8:
        RETURN 1
    _MM_DOWNCONV_EPI32_UINT16:
        RETURN 2
    _MM_DOWNCONV_EPI32_SINT16:
        RETURN 2
    ESAC
}
storeOffset := 0
downSize := DOWNCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 15
    i := j*32
    tmp := DOWNCONVERT(v1[i+31:i], conv)
    storeAddr := addr + storeOffset * downSize
    CASE downSize OF
    4: MEM[storeAddr] := tmp[31:0]
    2: MEM[storeAddr] := tmp[15:0]
    1: MEM[storeAddr] := tmp[7:0]
    ESAC
    storeOffset := storeOffset + 1
    IF ((addr + storeOffset * downSize) % 64) == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELD - _mm512_mask_extpackstorelo_epi32

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed 32-bit integer elements of "v1" into a byte/word/doubleword stream according
to "conv" at a logically mapped starting address "mt", storing the low-64-byte elements of that stream (those
elements of the stream that map before the first 64-byte-aligned address follwing "mt"). "hint" indicates to
the processor whether the data is non-temporal. Elements are written to memory according to element selector
"k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_DOWNCONV_EPI32_NONE:
        RETURN element[31:0]
    _MM_DOWNCONV_EPI32_UINT8:
        RETURN Truncate8(element[31:0])
    _MM_DOWNCONV_EPI32_SINT8:
        RETURN Saturate8(element[31:0])
    _MM_DOWNCONV_EPI32_UINT16:
        RETURN Truncate16(element[31:0])
    _MM_DOWNCONV_EPI32_SINT16:
        RETURN Saturate16(element[31:0])
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_DOWNCONV_EPI32_NONE:
        RETURN 4
    _MM_DOWNCONV_EPI32_UINT8:
        RETURN 1
    _MM_DOWNCONV_EPI32_SINT8:
        RETURN 1
    _MM_DOWNCONV_EPI32_UINT16:
        RETURN 2
    _MM_DOWNCONV_EPI32_SINT16:
        RETURN 2
    ESAC
}
storeOffset := 0
downSize := DOWNCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 15
    IF k[j]
        i := j*32
        tmp := DOWNCONVERT(v1[i+31:i], conv)
        storeAddr := addr + storeOffset * downSize
        CASE downSize OF
        4: MEM[storeAddr] := tmp[31:0]
        2: MEM[storeAddr] := tmp[15:0]
        1: MEM[storeAddr] := tmp[7:0]
        ESAC
        storeOffset := storeOffset + 1
        IF ((addr + storeOffset * downSize) % 64) == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHQ - _mm512_extpackstorehi_epi64

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed 64-bit integer elements of "v1" into a quadword stream according to "conv" at
a logically mapped starting address (mt-64), storing the high-64-byte elements of that stream (those elemetns
of the stream that map at or after the first 64-byte-aligned address following (m5-64)). "hint" indicates to
the processor whether the data is non-temporal.

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_EPI64_NONE:
        RETURN element[63:0]
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_EPI64_NONE:
        RETURN 8
    ESAC
}
storeOffset := 0
foundNext64BytesBoundary := false
downSize := DOWNCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 7
    IF foundNext64BytesBoundary == false
        IF ((addr + (storeOffset + 1)*downSize) % 64) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*64
        tmp := DOWNCONVERT(v1[i+63:i], conv)
        storeAddr := addr + storeOffset * downSize
        CASE downSize OF
        8: MEM[storeAddr] := tmp[63:0]
        ESAC
    FI
    storeOffset := storeOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHQ - _mm512_mask_extpackstorehi_epi64

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed 64-bit integer elements of "v1" into a quadword stream according to "conv" at
a logically mapped starting address (mt-64), storing the high-64-byte elements of that stream (those elemetns
of the stream that map at or after the first 64-byte-aligned address following (mt-64)). "hint" indicates to
the processor whether the data is non-temporal. Elements are stored to memory according to element selector "k"
(elements are skipped when the corresonding mask bit is not set).

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_EPI64_NONE:
        RETURN element[63:0]
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_EPI64_NONE:
        RETURN 8
    ESAC
}
storeOffset := 0
foundNext64BytesBoundary := false
downSize := DOWNCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 7
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF ((addr + (storeOffset + 1)*downSize) % 64) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*64
            tmp := DOWNCONVERT(v1[i+63:i], conv)
            storeAddr := addr + storeOffset * downSize
            CASE downSize OF
            8: MEM[storeAddr] := tmp[63:0]
            ESAC
        FI
        storeOffset := storeOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELQ - _mm512_extpackstorelo_epi64

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed 64-bit integer elements of "v1" into a quadword stream according to "conv" at
a logically mapped starting address "mt", storing the low-64-byte elements of that stream (those elements of
the stream that map before the first 64-byte-aligned address follwing "mt"). "hint" indicates to the processor
whether the data is non-temporal.

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_EPI64_NONE:
        RETURN element[63:0]
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_EPI64_NONE:
        RETURN 8
    ESAC
}
storeOffset := 0
downSize := DOWNCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 7
    i := j*63
    tmp := DOWNCONVERT(v1[i+63:i], conv)
    storeAddr := addr + storeOffset * downSize
    CASE downSize OF
    8: MEM[storeAddr] := tmp[63:0]
    ESAC
    storeOffset := storeOffset + 1
    IF ((addr + storeOffset * downSize) % 64) == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELQ - _mm512_mask_extpackstorelo_epi64

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed 64-bit integer elements of "v1" into a quadword stream according to "conv" at
a logically mapped starting address "mt", storing the low-64-byte elements of that stream (those elements of
the stream that map before the first 64-byte-aligned address follwing "mt"). "hint" indicates to the processor
whether the data is non-temporal. Elements are stored to memory according to element selector "k" (elements are
skipped whent he corresponding mask bit is not set).

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_EPI64_NONE:
        RETURN element[63:0]
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_EPI64_NONE:
        RETURN 8
    ESAC
}
storeOffset := 0
downSize := DOWNCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 7
    IF k[j]
        i := j*63
        tmp := DOWNCONVERT(v1[i+63:i], conv)
        storeAddr := addr + storeOffset * downSize
        CASE downSize OF
        8: MEM[storeAddr] := tmp[63:0]
        ESAC
        storeOffset := storeOffset + 1
        IF ((addr + storeOffset * downSize) % 64) == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHPS - _mm512_extpackstorehi_ps

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed single-precision (32-bit) floating-point elements of "v1" into a
byte/word/doubleword stream according to "conv" at a logically mapped starting address (mt-64), storing the
high-64-byte elements of that stream (those elemetns of the stream that map at or after the first
64-byte-aligned address following (m5-64)). "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PS_NONE:
        RETURN element[31:0]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP32_To_FP16(element[31:0])
    _MM_UPCONV_PS_UINT8:
        RETURN Truncate8(element[31:0])
    _MM_UPCONV_PS_SINT8:
        RETURN Saturate8(element[31:0])
    _MM_UPCONV_PS_UINT16:
        RETURN Truncate16(element[31:0])
    _MM_UPCONV_PS_SINT16:
        RETURN Saturate16(element[31:0])
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PS_NONE:
        RETURN 4
    _MM_UPCONV_PS_FLOAT16:
        RETURN 2
    _MM_UPCONV_PS_UINT8:
        RETURN 1
    _MM_UPCONV_PS_SINT8:
        RETURN 1
    _MM_UPCONV_PS_UINT16:
        RETURN 2
    _MM_UPCONV_PS_SINT16:
        RETURN 2
    ESAC
}
storeOffset := 0
foundNext64BytesBoundary := false
downSize := DOWNCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 15
    IF foundNext64BytesBoundary == false
        IF ((addr + (storeOffset + 1)*downSize) % 64) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*32
        tmp := DOWNCONVERT(v1[i+31:i], conv)
        storeAddr := addr + storeOffset * downSize
        CASE downSize OF
        4: MEM[storeAddr] := tmp[31:0]
        2: MEM[storeAddr] := tmp[15:0]
        1: MEM[storeAddr] := tmp[7:0]
        ESAC
    FI
    storeOffset := storeOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHPS - _mm512_mask_extpackstorehi_ps

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed single-precision (32-bit) floating-point elements of "v1" into a
byte/word/doubleword stream according to "conv" at a logically mapped starting address (mt-64), storing the
high-64-byte elements of that stream (those elemetns of the stream that map at or after the first
64-byte-aligned address following (m5-64)). "hint" indicates to the processor whether the data is non-temporal.
Elements are stored to memory according to element selector "k" (elements are skipped when the corresponding
mask bit is not set).

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PS_NONE:
        RETURN element[31:0]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP32_To_FP16(element[31:0])
    _MM_UPCONV_PS_UINT8:
        RETURN Truncate8(element[31:0])
    _MM_UPCONV_PS_SINT8:
        RETURN Saturate8(element[31:0])
    _MM_UPCONV_PS_UINT16:
        RETURN Truncate16(element[31:0])
    _MM_UPCONV_PS_SINT16:
        RETURN Saturate16(element[31:0])
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PS_NONE:
        RETURN 4
    _MM_UPCONV_PS_FLOAT16:
        RETURN 2
    _MM_UPCONV_PS_UINT8:
        RETURN 1
    _MM_UPCONV_PS_SINT8:
        RETURN 1
    _MM_UPCONV_PS_UINT16:
        RETURN 2
    _MM_UPCONV_PS_SINT16:
        RETURN 2
    ESAC
}
storeOffset := 0
foundNext64BytesBoundary := false
downSize := DOWNCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 15
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF ((addr + (storeOffset + 1)*downSize) % 64) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*32
            tmp := DOWNCONVERT(v1[i+31:i], conv)
            storeAddr := addr + storeOffset * downSize
            CASE downSize OF
            4: MEM[storeAddr] := tmp[31:0]
            2: MEM[storeAddr] := tmp[15:0]
            1: MEM[storeAddr] := tmp[7:0]
            ESAC
        FI
        storeOffset := storeOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELPS - _mm512_extpackstorelo_ps

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed single-precision (32-bit) floating-point elements of "v1" into a
byte/word/doubleword stream according to "conv" at a logically mapped starting address "mt", storing the
low-64-byte elements of that stream (those elements of the stream that map before the first 64-byte-aligned
address follwing "mt"). "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PS_NONE:
        RETURN element[31:0]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP32_To_FP16(element[31:0])
    _MM_UPCONV_PS_UINT8:
        RETURN Truncate8(element[31:0])
    _MM_UPCONV_PS_SINT8:
        RETURN Saturate8(element[31:0])
    _MM_UPCONV_PS_UINT16:
        RETURN Truncate16(element[31:0])
    _MM_UPCONV_PS_SINT16:
        RETURN Saturate16(element[31:0])
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PS_NONE:
        RETURN 4
    _MM_UPCONV_PS_FLOAT16:
        RETURN 2
    _MM_UPCONV_PS_UINT8:
        RETURN 1
    _MM_UPCONV_PS_SINT8:
        RETURN 1
    _MM_UPCONV_PS_UINT16:
        RETURN 2
    _MM_UPCONV_PS_SINT16:
        RETURN 2
    ESAC
}
storeOffset := 0
downSize := DOWNCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 15
    i := j*32
    tmp := DOWNCONVERT(v1[i+31:i], conv)
    storeAddr := addr + storeOffset * downSize
    CASE downSize OF
    4: MEM[storeAddr] := tmp[31:0]
    2: MEM[storeAddr] := tmp[15:0]
    1: MEM[storeAddr] := tmp[7:0]
    ESAC
    storeOffset := storeOffset + 1
    IF ((addr + storeOffset * downSize) % 64) == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELPS - _mm512_mask_extpackstorelo_ps

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed single-precision (32-bit) floating-point elements of "v1" into a
byte/word/doubleword stream according to "conv" at a logically mapped starting address "mt", storing the
low-64-byte elements of that stream (those elements of the stream that map before the first 64-byte-aligned
address follwing "mt"). "hint" indicates to the processor whether the data is non-temporal. Elements are stored
to memory according to element selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PS_NONE:
        RETURN element[31:0]
    _MM_UPCONV_PS_FLOAT16:
        RETURN Convert_FP32_To_FP16(element[31:0])
    _MM_UPCONV_PS_UINT8:
        RETURN Truncate8(element[31:0])
    _MM_UPCONV_PS_SINT8:
        RETURN Saturate8(element[31:0])
    _MM_UPCONV_PS_UINT16:
        RETURN Truncate16(element[31:0])
    _MM_UPCONV_PS_SINT16:
        RETURN Saturate16(element[31:0])
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PS_NONE:
        RETURN 4
    _MM_UPCONV_PS_FLOAT16:
        RETURN 2
    _MM_UPCONV_PS_UINT8:
        RETURN 1
    _MM_UPCONV_PS_SINT8:
        RETURN 1
    _MM_UPCONV_PS_UINT16:
        RETURN 2
    _MM_UPCONV_PS_SINT16:
        RETURN 2
    ESAC
}
storeOffset := 0
downSize := DOWNCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 15
    IF k[j]
        i := j*32
        tmp := DOWNCONVERT(v1[i+31:i], conv)
        storeAddr := addr + storeOffset * downSize
        CASE downSize OF
        4: MEM[storeAddr] := tmp[31:0]
        2: MEM[storeAddr] := tmp[15:0]
        1: MEM[storeAddr] := tmp[7:0]
        ESAC
        storeOffset := storeOffset + 1
        IF ((addr + storeOffset * downSize) % 64) == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHPD - _mm512_extpackstorehi_pd

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed double-precision (64-bit) floating-point elements of "v1" into a quadword
stream according to "conv" at a logically mapped starting address (mt-64), storing the high-64-byte elements of
that stream (those elemetns of the stream that map at or after the first 64-byte-aligned address following
(m5-64)). "hint" indicates to the processor whether the data is non-temporal.

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PD_NONE:
        RETURN element[63:0]
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PD_NONE:
        RETURN 8
    ESAC
}
storeOffset := 0
foundNext64BytesBoundary := false
downSize := DOWNCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 7
    IF foundNext64BytesBoundary == false
        IF ((addr + (storeOffset + 1)*downSize) % 64) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*64
        tmp := DOWNCONVERT(v1[i+63:i], conv)
        storeAddr := addr + storeOffset * downSize
        CASE downSize OF
        8: MEM[storeAddr] := tmp[63:0]
        ESAC
    FI
    storeOffset := storeOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHPD - _mm512_mask_extpackstorehi_pd

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed double-precision (64-bit) floating-point elements of "v1" into a quadword
stream according to "conv" at a logically mapped starting address (mt-64), storing the high-64-byte elements of
that stream (those elemetns of the stream that map at or after the first 64-byte-aligned address following
(m5-64)). "hint" indicates to the processor whether the data is non-temporal. Elements are stored to memory
according to element selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PD_NONE:
        RETURN element[63:0]
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PD_NONE:
        RETURN 8
    ESAC
}
storeOffset := 0
foundNext64BytesBoundary := false
downSize := DOWNCONVERTSIZE(conv)
addr := mt-64
FOR j := 0 to 7
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF ((addr + (storeOffset + 1)*downSize) % 64) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*64
            tmp := DOWNCONVERT(v1[i+63:i], conv)
            storeAddr := addr + storeOffset * downSize
            CASE downSize OF
            8: MEM[storeAddr] := tmp[63:0]
            ESAC
        FI
        storeOffset := storeOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELPD - _mm512_extpackstorelo_pd

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed double-precision (64-bit) floating-point elements of "v1" into a quadword
stream according to "conv" at a logically mapped starting address "mt", storing the low-64-byte elements of
that stream (those elements of the stream that map before the first 64-byte-aligned address follwing "mt").
"hint" indicates to the processor whether the data is non-temporal.

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PD_NONE:
        RETURN element[63:0]
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PD_NONE:
        RETURN 8
    ESAC
}
storeOffset := 0
downSize := DOWNCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 7
    i := j*63
    tmp := DOWNCONVERT(v1[i+63:i], conv)
    storeAddr := addr + storeOffset * downSize
    CASE downSize OF
    8: MEM[storeAddr] := tmp[63:0]
    ESAC
    storeOffset := storeOffset + 1
    IF ((addr + storeOffset * downSize) % 64) == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELPD - _mm512_mask_extpackstorelo_pd

| 

--------------------------------------------------------------------------------------------------------------
Down-converts and stores packed double-precision (64-bit) floating-point elements of "v1" into a quadword
stream according to "conv" at a logically mapped starting address "mt", storing the low-64-byte elements of
that stream (those elements of the stream that map before the first 64-byte-aligned address follwing "mt").
"hint" indicates to the processor whether the data is non-temporal. Elements are stored to memory according to
element selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

DEFINE DOWNCONVERT(element, convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PD_NONE:
        RETURN element[63:0]
    ESAC
}
DEFINE DOWNCONVERTSIZE(convertTo) {
    CASE convertTo OF
    _MM_UPCONV_PD_NONE:
        RETURN 8
    ESAC
}
storeOffset := 0
downSize := DOWNCONVERTSIZE(conv)
addr := mt
FOR j := 0 to 7
    IF k[j]
        i := j*63
        tmp := DOWNCONVERT(v1[i+63:i], conv)
        storeAddr := addr + storeOffset * downSize
        CASE downSize OF
        8: MEM[storeAddr] := tmp[63:0]
        ESAC
        storeOffset := storeOffset + 1
        IF ((addr + storeOffset * downSize) % 64) == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPSCATTERDQ - _mm512_i32loscatter_epi64

| VPSCATTERDQ_MEMu64_MASKmskw_ZMMu64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Stores 8 packed 64-bit integer elements located in "a" and stores them in memory locations starting at
location "base_addr" at packed 32-bit integer indices stored in "vindex" scaled by "scale".

[algorithm]

FOR j := 0 to 7
    i := j*64
    m := j*32
    addr := base_addr + SignExtend64(vindex[m+31:m]) * ZeroExtend64(scale) * 8
    MEM[addr+63:addr] := a[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPSCATTERDQ - _mm512_mask_i32loscatter_epi64

| VPSCATTERDQ_MEMu64_MASKmskw_ZMMu64_AVX512_VL512

--------------------------------------------------------------------------------------------------------------
Stores 8 packed 64-bit integer elements located in "a" and stores them in memory locations starting at
location "base_addr" at packed 32-bit integer indices stored in "vindex" scaled by "scale" using writemask "k"
(elements whose corresponding mask bit is not set are not written to memory).

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

## VLOADUNPACKHD - _mm512_loadunpackhi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt-64 and expands them into packed 32-bit integers in "dst". The initial values of "dst" are copied from "src".
Only those converted doublewords that occur at or after the first 64-byte-aligned address following (mt-64) are
loaded. Elements in the resulting vector that do not map to those doublewords are taken from "src".

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
addr := mt-64
FOR j := 0 to 15
    IF foundNext64BytesBoundary == false
        IF (addr + (loadOffset + 1)*4 % 64) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*32
        tmp := MEM[addr + loadOffset*4]
        dst[i+31:i] := tmp[i+31:i]
    FI
    loadOffset := loadOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHD - _mm512_mask_loadunpackhi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt-64 and expands them into packed 32-bit integers in "dst". The initial values of "dst" are copied from "src".
Only those converted doublewords that occur at or after the first 64-byte-aligned address following (mt-64) are
loaded. Elements in the resulting vector that do not map to those doublewords are taken from "src". Elements
are loaded from memory according to element selector "k" (elements are skipped when the corresponding mask bit
is not set).

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
addr := mt-64
FOR j := 0 to 15
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF (addr + (loadOffset + 1)*4 % 64) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*32
            tmp := MEM[addr + loadOffset*4]
            dst[i+31:i] := tmp[i+31:i]
        FI
        loadOffset := loadOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLD - _mm512_loadunpacklo_epi32

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt and expanded into packed 32-bit integers in "dst". The initial values of "dst" are copied from "src". Only
those converted doublewords that occur before first 64-byte-aligned address following "mt" are loaded. Elements
in the resulting vector that do not map to those doublewords are taken from "src".

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
addr := mt
FOR j := 0 to 15
    i := j*32
    tmp := MEM[addr + loadOffset*4]
    dst[i+31:i] := tmp[i+31:i]
    loadOffset := loadOffset + 1
    IF (mt + loadOffset * 4) % 64 == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLD - _mm512_mask_loadunpacklo_epi32

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt and expands them into packed 32-bit integers in "dst". The initial values of "dst" are copied from "src".
Only those converted doublewords that occur before first 64-byte-aligned address following "mt" are loaded.
Elements in the resulting vector that do not map to those doublewords are taken from "src". Elements are loaded
from memory according to element selector "k" (elements are skipped when the corresponding mask bit is not
set).

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
addr := mt
FOR j := 0 to 15
    i := j*32
    IF k[j]
        tmp := MEM[addr + loadOffset*4]
        dst[i+31:i] := tmp[i+31:i]
        loadOffset := loadOffset + 1
        IF (mt + loadOffset * 4) % 64 == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHQ - _mm512_loadunpackhi_epi64

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the quadword stream starting at element-aligned address mt-64 and
expands them into packed 64-bit integers in "dst". The initial values of "dst" are copied from "src". Only
those converted quadwords that occur at or after the first 64-byte-aligned address following (mt-64) are
loaded. Elements in the resulting vector that do not map to those quadwords are taken from "src".

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
addr := mt-64
FOR j := 0 to 7
    IF foundNext64BytesBoundary == false
        IF (addr + (loadOffset + 1)*8) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*64
        tmp := MEM[addr + loadOffset*8]
        dst[i+63:i] := tmp[i+63:i]
    FI
    loadOffset := loadOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHQ - _mm512_mask_loadunpackhi_epi64

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the quadword stream starting at element-aligned address mt-64 and
expands them into packed 64-bit integers in "dst". The initial values of "dst" are copied from "src". Only
those converted quadwords that occur at or after the first 64-byte-aligned address following (mt-64) are
loaded. Elements in the resulting vector that do not map to those quadwords are taken from "src". Elements are
loaded from memory according to element selector "k" (elements are skipped when the corresponding mask bit is
not set).

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
addr := mt-64
FOR j := 0 to 7
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF (addr + (loadOffset + 1)*8) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*64
            tmp := MEM[addr + loadOffset*8]
            dst[i+63:i] := tmp[i+63:i]
        FI
        loadOffset := loadOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLQ - _mm512_loadunpacklo_epi64

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the quadword stream starting at element-aligned address mt and
expands them into packed 64-bit integers in "dst". The initial values of "dst" are copied from "src". Only
those converted quad that occur before first 64-byte-aligned address following "mt" are loaded. Elements in the
resulting vector that do not map to those quadwords are taken from "src".

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
addr := mt
FOR j := 0 to 7
    i := j*64
    tmp := MEM[addr + loadOffset*8]
    dst[i+63:i] := tmp[i+63:i]
    loadOffset := loadOffset + 1
    IF (addr + loadOffset*8 % 64) == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLQ - _mm512_mask_loadunpacklo_epi64

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the quadword stream starting at element-aligned address mt and
expands them into packed 64-bit integers in "dst". The initial values of "dst" are copied from "src". Only
those converted quad that occur before first 64-byte-aligned address following "mt" are loaded. Elements in the
resulting vector that do not map to those quadwords are taken from "src". Elements are loaded from memory
according to element selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
addr := mt
FOR j := 0 to 7
    i := j*64
    IF k[j]
        tmp := MEM[addr + loadOffset*8]
        dst[i+63:i] := tmp[i+63:i]
        loadOffset := loadOffset + 1
        IF (addr + loadOffset*8 % 64) == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHPS - _mm512_loadunpackhi_ps

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the byte/word/doubleword stream starting at element-aligned address
mt-64 and expands them into packed single-precision (32-bit) floating-point elements in "dst". The initial
values of "dst" are copied from "src". Only those converted quadwords that occur at or after the first
64-byte-aligned address following (mt-64) are loaded. Elements in the resulting vector that do not map to those
quadwords are taken from "src".

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
addr := mt-64
FOR j := 0 to 15
    IF foundNext64BytesBoundary == false
        IF (addr + (loadOffset + 1)*4 % 64) == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*32
        tmp := MEM[addr + loadOffset*4]
        dst[i+31:i] := tmp[i+31:i]
    FI
    loadOffset := loadOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHPS - _mm512_mask_loadunpackhi_ps

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the doubleword stream starting at element-aligned address mt-64 and
expands them into packed single-precision (32-bit) floating-point elements in "dst". The initial values of
"dst" are copied from "src". Only those converted quadwords that occur at or after the first 64-byte-aligned
address following (mt-64) are loaded. Elements in the resulting vector that do not map to those quadwords are
taken from "src". Elements are loaded from memory according to element selector "k" (elements are skipped when
the corresponding mask bit is not set).

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
addr := mt-64
FOR j := 0 to 15
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF (addr + (loadOffset + 1)*4 % 64) == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*32
            tmp := MEM[addr + loadOffset*4]
            dst[i+31:i] := tmp[i+31:i]
        FI
        loadOffset := loadOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLPS - _mm512_loadunpacklo_ps

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the doubleword stream starting at element-aligned address mt and
expanded into packed single-precision (32-bit) floating-point elements in "dst". The initial values of "dst"
are copied from "src". Only those converted doublewords that occur before first 64-byte-aligned address
following "mt" are loaded. Elements in the resulting vector that do not map to those doublewords are taken from
"src".

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
addr := mt
FOR j := 0 to 15
    i := j*32
    tmp := MEM[addr + loadOffset*4]
    dst[i+31:i] := tmp[i+31:i]
    loadOffset := loadOffset + 1
    IF (mt + loadOffset * 4) % 64 == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLPS - _mm512_mask_loadunpacklo_ps

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the doubleword stream starting at element-aligned address mt and
expanded into packed single-precision (32-bit) floating-point elements in "dst". The initial values of "dst"
are copied from "src". Only those converted doublewords that occur before first 64-byte-aligned address
following "mt" are loaded. Elements in the resulting vector that do not map to those doublewords are taken from
"src". Elements are loaded from memory according to element selector "k" (elements are skipped when the
corresponding mask bit is not set).

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
addr := mt
FOR j := 0 to 15
    i := j*32
    IF k[j]
        tmp := MEM[addr + loadOffset*4]
        dst[i+31:i] := tmp[i+31:i]
        loadOffset := loadOffset + 1
        IF (mt + loadOffset * 4) % 64 == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHPD - _mm512_loadunpackhi_pd

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the quadword stream starting at element-aligned address mt-64 and
expands them into packed double-precision (64-bit) floating-point values in "dst". The initial values of "dst"
are copied from "src". Only those converted quadwords that occur at or after the first 64-byte-aligned address
following (mt-64) are loaded. Elements in the resulting vector that do not map to those quadwords are taken
from "src".

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
addr := mt-64
FOR j := 0 to 7
    IF foundNext64BytesBoundary == false
        IF (addr + (loadOffset + 1)*8) % 64 == 0
            foundNext64BytesBoundary := true
        FI
    ELSE
        i := j*64
        tmp := MEM[addr + loadOffset*8]
        dst[i+63:i] := tmp[i+63:i]
    FI
    loadOffset := loadOffset + 1
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKHPD - _mm512_mask_loadunpackhi_pd

| 

--------------------------------------------------------------------------------------------------------------
Loads the high-64-byte-aligned portion of the quadword stream starting at element-aligned address mt-64 and
expands them into packed double-precision (64-bit) floating-point values in "dst". The initial values of "dst"
are copied from "src". Only those converted quadwords that occur at or after the first 64-byte-aligned address
following (mt-64) are loaded. Elements in the resulting vector that do not map to those quadwords are taken
from "src". Elements are loaded from memory according to element selector "k" (elements are skipped when the
corresponding mask bit is not set).

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
foundNext64BytesBoundary := false
addr := mt-64
FOR j := 0 to 7
    IF k[j]
        IF foundNext64BytesBoundary == false
            IF (addr + (loadOffset + 1)*8) % 64 == 0
                foundNext64BytesBoundary := true
            FI
        ELSE
            i := j*64
            tmp := MEM[addr + loadOffset*8]
            dst[i+63:i] := tmp[i+63:i]
        FI
        loadOffset := loadOffset + 1
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLPD - _mm512_loadunpacklo_pd

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the quadword stream starting at element-aligned address mt and
expands them into packed double-precision (64-bit) floating-point elements in "dst". The initial values of
"dst" are copied from "src". Only those converted quad that occur before first 64-byte-aligned address
following "mt" are loaded. Elements in the resulting vector that do not map to those quadwords are taken from
"src".

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
addr := mt
FOR j := 0 to 7
    i := j*64
    tmp := MEM[addr + loadOffset*8]
    dst[i+63:i] := tmp[i+63:i]
    loadOffset := loadOffset + 1
    IF ((addr + 8*loadOffset) % 64) == 0
        BREAK
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOADUNPACKLPD - _mm512_mask_loadunpacklo_pd

| 

--------------------------------------------------------------------------------------------------------------
Loads the low-64-byte-aligned portion of the quadword stream starting at element-aligned address mt and
expands them into packed double-precision (64-bit) floating-point values in "dst". The initial values of "dst"
are copied from "src". Only those converted quad that occur before first 64-byte-aligned address following "mt"
are loaded. Elements in the resulting vector that do not map to those quadwords are taken from "src". Elements
are loaded from memory according to element selector "k" (elements are skipped when the corresponding mask bit
is not set).

[algorithm]

dst[511:0] := src[511:0]
loadOffset := 0
addr := mt
FOR j := 0 to 7
    i := j*64
    IF k[j]
        tmp := MEM[addr + loadOffset*8]
        dst[i+63:i] := tmp[i+63:i]
        loadOffset := loadOffset + 1
        IF ((addr + 8*loadOffset) % 64) == 0
            BREAK
        FI
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHD - _mm512_packstorehi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Stores packed 32-bit integer elements of "v1" into a doubleword stream at a logically mapped starting address
(mt-64), storing the high-64-byte elements of that stream (those elements of the stream that map at or after
the first 64-byte-aligned address following (m5-64)).

[algorithm]

storeOffset := 0
foundNext64BytesBoundary := 0
addr := mt-64
FOR j := 0 to 15
    IF foundNext64BytesBoundary == 0
        IF ((addr + (storeOffset + 1)*4) % 64) == 0
            foundNext64BytesBoundary := 1
        FI
    ELSE
        i := j*32
        MEM[addr + storeOffset*4] := v1[i+31:i]
    FI
    storeOffset := storeOffset + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHD - _mm512_mask_packstorehi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Stores packed 32-bit integer elements of "v1" into a doubleword stream at a logically mapped starting address
(mt-64), storing the high-64-byte elements of that stream (those elements of the stream that map at or after
the first 64-byte-aligned address following (m5-64)). Elements are loaded from memory according to element
selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

storeOffset := 0
foundNext64BytesBoundary := 0
addr := mt-64
FOR j := 0 to 15
    IF k[j]
        IF foundNext64BytesBoundary == 0
            IF ((addr + (storeOffset + 1)*4) % 64) == 0
                foundNext64BytesBoundary := 1
            FI
        ELSE
            i := j*32
            MEM[addr + storeOffset*4] := v1[i+31:i]
        FI
        storeOffset := storeOffset + 1
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELD - _mm512_packstorelo_epi32

| 

--------------------------------------------------------------------------------------------------------------
Stores packed 32-bit integer elements of "v1" into a doubleword stream at a logically mapped starting address
"mt", storing the low-64-byte elements of that stream (those elements of the stream that map before the first
64-byte-aligned address follwing "mt").

[algorithm]

storeOffset := 0
addr := mt
FOR j := 0 to 15
    i := j*32
    MEM[addr + storeOffset*4] := v1[i+31:i]
    storeOffset := storeOffset + 1
    IF ((addr + storeOffset*4) % 64) == 0
        BREAK
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELD - _mm512_mask_packstorelo_epi32

| 

--------------------------------------------------------------------------------------------------------------
Stores packed 32-bit integer elements of "v1" into a doubleword stream at a logically mapped starting address
"mt", storing the low-64-byte elements of that stream (those elements of the stream that map before the first
64-byte-aligned address follwing "mt"). Elements are loaded from memory according to element selector "k"
(elements are skipped when the corresponding mask bit is not set).

[algorithm]

storeOffset := 0
addr := mt
FOR j := 0 to 15
    IF k[j]
        i := j*32
        MEM[addr + storeOffset*4] := v1[i+31:i]
        storeOffset := storeOffset + 1
        IF ((addr + storeOffset*4) % 64) == 0
            BREAK
        FI
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHQ - _mm512_packstorehi_epi64

| 

--------------------------------------------------------------------------------------------------------------
Stores packed 64-bit integer elements of "v1" into a quadword stream at a logically mapped starting address
(mt-64), storing the high-64-byte elements of that stream (those elemetns of the stream that map at or after
the first 64-byte-aligned address following (m5-64)).

[algorithm]

storeOffset := 0
foundNext64BytesBoundary := 0
addr := mt-64
FOR j := 0 to 7
    IF foundNext64BytesBoundary == 0
        IF ((addr + (storeOffset + 1)*8) % 64) == 0
            foundNext64BytesBoundary := 1
        FI
    ELSE
        i := j*64
        MEM[addr + storeOffset*8] := v1[i+63:i]
    FI
    storeOffset := storeOffset + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHQ - _mm512_mask_packstorehi_epi64

| 

--------------------------------------------------------------------------------------------------------------
Stores packed 64-bit integer elements of "v1" into a quadword stream at a logically mapped starting address
(mt-64), storing the high-64-byte elements of that stream (those elemetns of the stream that map at or after
the first 64-byte-aligned address following (m5-64)). Elements are loaded from memory according to element
selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

storeOffset := 0
foundNext64BytesBoundary := 0
addr := mt-64
FOR j := 0 to 7
    IF k[j]
        IF foundNext64BytesBoundary == 0
            IF ((addr + (storeOffset + 1)*8) % 64) == 0
                foundNext64BytesBoundary := 1
            FI
        ELSE
            i := j*64
            MEM[addr + storeOffset*8] := v1[i+63:i]
        FI
        storeOffset := storeOffset + 1
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELQ - _mm512_packstorelo_epi64

| 

--------------------------------------------------------------------------------------------------------------
Stores packed 64-bit integer elements of "v1" into a quadword stream at a logically mapped starting address
"mt", storing the low-64-byte elements of that stream (those elements of the stream that map before the first
64-byte-aligned address follwing "mt").

[algorithm]

storeOffset := 0
addr := mt
FOR j := 0 to 7
    i := j*64
    MEM[addr + storeOffset*8] := v1[i+63:i]
    storeOffset := storeOffset + 1
    IF ((addr + storeOffset*8) % 64) == 0
        BREAK
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELQ - _mm512_mask_packstorelo_epi64

| 

--------------------------------------------------------------------------------------------------------------
Stores packed 64-bit integer elements of "v1" into a quadword stream at a logically mapped starting address
"mt", storing the low-64-byte elements of that stream (those elements of the stream that map before the first
64-byte-aligned address follwing "mt"). Elements are loaded from memory according to element selector "k"
(elements are skipped when the corresponding mask bit is not set).

[algorithm]

storeOffset := 0
addr := mt
FOR j := 0 to 7
    IF k[j]
        i := j*64
        MEM[addr + storeOffset*8] := v1[i+63:i]
        storeOffset := storeOffset + 1
        IF ((addr + storeOffset*8) % 64) == 0
            BREAK
        FI
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHPS - _mm512_packstorehi_ps

| 

--------------------------------------------------------------------------------------------------------------
Stores packed single-precision (32-bit) floating-point elements of "v1" into a doubleword stream at a
logically mapped starting address (mt-64), storing the high-64-byte elements of that stream (those elemetns of
the stream that map at or after the first 64-byte-aligned address following (m5-64)).

[algorithm]

storeOffset := 0
foundNext64BytesBoundary := 0
addr := mt-64
FOR j := 0 to 15
    IF foundNext64BytesBoundary == 0
        IF ((addr + (storeOffset + 1)*4) % 64) == 0
            foundNext64BytesBoundary := 1
        FI
    ELSE
        i := j*32
        MEM[addr + storeOffset*4] := v1[i+31:i]
    FI
    storeOffset := storeOffset + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHPS - _mm512_mask_packstorehi_ps

| 

--------------------------------------------------------------------------------------------------------------
Stores packed single-precision (32-bit) floating-point elements of "v1" into a doubleword stream at a
logically mapped starting address (mt-64), storing the high-64-byte elements of that stream (those elemetns of
the stream that map at or after the first 64-byte-aligned address following (m5-64)). Elements are loaded from
memory according to element selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

storeOffset := 0
foundNext64BytesBoundary := 0
addr := mt-64
FOR j := 0 to 15
    IF k[j]
        IF foundNext64BytesBoundary == 0
            IF ((addr + (storeOffset + 1)*4) % 64) == 0
                foundNext64BytesBoundary := 1
            FI
        ELSE
            i := j*32
            MEM[addr + storeOffset*4] := v1[i+31:i]
        FI
        storeOffset := storeOffset + 1
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELPS - _mm512_packstorelo_ps

| 

--------------------------------------------------------------------------------------------------------------
Stores packed single-precision (32-bit) floating-point elements of "v1" into a doubleword stream at a
logically mapped starting address "mt", storing the low-64-byte elements of that stream (those elements of the
stream that map before the first 64-byte-aligned address follwing "mt").

[algorithm]

storeOffset := 0
addr := mt
FOR j := 0 to 15
    i := j*32
    MEM[addr + storeOffset*4] := v1[i+31:i]
    storeOffset := storeOffset + 1
    IF ((addr + storeOffset*4) % 64) == 0
        BREAK
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELPS - _mm512_mask_packstorelo_ps

| 

--------------------------------------------------------------------------------------------------------------
Stores packed single-precision (32-bit) floating-point elements of "v1" into a doubleword stream at a
logically mapped starting address "mt", storing the low-64-byte elements of that stream (those elements of the
stream that map before the first 64-byte-aligned address follwing "mt"). Elements are loaded from memory
according to element selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

storeOffset := 0
addr := mt
FOR j := 0 to 15
    IF k[j]
        i := j*32
        MEM[addr + storeOffset*4] := v1[i+31:i]
        storeOffset := storeOffset + 1
        IF ((addr + storeOffset*4) % 64) == 0
            BREAK
        FI
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHPD - _mm512_packstorehi_pd

| 

--------------------------------------------------------------------------------------------------------------
Stores packed double-precision (64-bit) floating-point elements of "v1" into a quadword stream at a logically
mapped starting address (mt-64), storing the high-64-byte elements of that stream (those elemetns of the stream
that map at or after the first 64-byte-aligned address following (m5-64)).

[algorithm]

storeOffset := 0
foundNext64BytesBoundary := 0
addr := mt-64
FOR j := 0 to 7
    IF foundNext64BytesBoundary == 0
        IF ((addr + (storeOffset + 1)*8) % 64) == 0
            foundNext64BytesBoundary := 1
        FI
    ELSE
        i := j*64
        MEM[addr + storeOffset*4] := v1[i+63:i]
    FI
    storeOffset := storeOffset + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTOREHPD - _mm512_mask_packstorehi_pd

| 

--------------------------------------------------------------------------------------------------------------
Stores packed double-precision (64-bit) floating-point elements of "v1" into a quadword stream at a logically
mapped starting address (mt-64), storing the high-64-byte elements of that stream (those elemetns of the stream
that map at or after the first 64-byte-aligned address following (m5-64)). Elements are loaded from memory
according to element selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

storeOffset := 0
foundNext64BytesBoundary := 0
addr := mt-64
FOR j := 0 to 7
    IF k[j]
        IF foundNext64BytesBoundary == 0
            IF ((addr + (storeOffset + 1)*8) % 64) == 0
                foundNext64BytesBoundary := 1
            FI
        ELSE
            i := j*64
            MEM[addr + storeOffset*4] := v1[i+63:i]
        FI
        storeOffset := storeOffset + 1
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELPD - _mm512_packstorelo_pd

| 

--------------------------------------------------------------------------------------------------------------
Stores packed double-precision (64-bit) floating-point elements of "v1" into a quadword stream at a logically
mapped starting address "mt", storing the low-64-byte elements of that stream (those elements of the stream
that map before the first 64-byte-aligned address follwing "mt").

[algorithm]

storeOffset := 0
addr := mt
FOR j := 0 to 7
    i := j*64
    MEM[addr + storeOffset*8] := v1[i+63:i]
    storeOffset := storeOffset + 1
    IF ((addr + storeOffset*8) % 64) == 0
        BREAK
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VPACKSTORELPD - _mm512_mask_packstorelo_pd

| 

--------------------------------------------------------------------------------------------------------------
Stores packed double-precision (64-bit) floating-point elements of "v1" into a quadword stream at a logically
mapped starting address "mt", storing the low-64-byte elements of that stream (those elements of the stream
that map before the first 64-byte-aligned address follwing "mt"). Elements are loaded from memory according to
element selector "k" (elements are skipped when the corresponding mask bit is not set).

[algorithm]

storeOffset := 0
addr := mt
FOR j := 0 to 7
    IF k[j]
        i := j*64
        MEM[addr + storeOffset*8] := v1[i+63:i]
        storeOffset := storeOffset + 1
        IF ((addr + storeOffset*8) % 64) == 0
            BREAK
        FI
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## VCVTFXPNTPD2DQ - _mm512_cvtfxpnt_roundpd_epi32lo

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element conversion of elements in packed double-precision (64-bit) floating-point
vector "v2" to 32-bit integer elements, storing them in the lower half of "dst". The elements in the upper half
of "dst" are set to 0.
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    k := j*32
    dst[k+31:k] := Convert_FP64_To_Int32(v2[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTFXPNTPD2DQ - _mm512_mask_cvtfxpnt_roundpd_epi32lo

| 

--------------------------------------------------------------------------------------------------------------
Performs an element-by-element conversion of elements in packed double-precision (64-bit) floating-point
vector "v2" to 32-bit integer elements, storing them in the lower half of "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set). The elements in the upper half of "dst" are
set to 0.
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    l := j*32
    IF k[j]
        dst[l+31:l] := Convert_FP64_To_Int32(v2[i+63:i])
    ELSE
        dst[l+31:l] := src[l+31:l]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VCVTFXPNTDQ2PS - _mm512_cvtfxpnt_round_adjustepi32_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element conversion of packed 32-bit integer elements in "v2" to packed single-precision
(32-bit) floating-point elements and performing an optional exponent adjust using "expadj", storing the results
in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := Int32ToFloat32(v2[i+31:i])
    CASE expadj OF
    _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
    _MM_EXPADJ_4:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
    _MM_EXPADJ_5:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
    _MM_EXPADJ_8:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
    _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
    _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
    _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
    _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOG2PS - _mm512_log2ae23_ps

| 

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed single-precision (32-bit) floating-point elements in "a" with absolute
error of 2^(-23) and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i]) / LOG(2.0)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VLOG2PS - _mm512_mask_log2ae23_ps

| 

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed single-precision (32-bit) floating-point elements in "a" with absolute
error of 2^(-23) and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := LOG(a[i+31:i]) / LOG(2.0)
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMADD231D - _mm512_fmadd_epi32

| 

--------------------------------------------------------------------------------------------------------------
Multiply packed 32-bit integer elements in "a" and "b", add the intermediate result to packed elements in "c"
and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) + c[i+31:i]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMADD231D - _mm512_mask_fmadd_epi32

| 

--------------------------------------------------------------------------------------------------------------
Multiply packed 32-bit integer elements in "a" and "b", add the intermediate result to packed elements in "c"
and store the results in "dst" using writemask "k" (elements are copied from "a" when the corresponding mask
bit is not set).

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

## VPMADD231D - _mm512_mask3_fmadd_epi32

| 

--------------------------------------------------------------------------------------------------------------
Multiply packed 32-bit integer elements in "a" and "b", add the intermediate result to packed elements in "c"
and store the results in "dst" using writemask "k" (elements are copied from "c" when the corresponding mask
bit is not set).

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

## VPMADD233D - _mm512_fmadd233_epi32

| 

--------------------------------------------------------------------------------------------------------------
Multiply packed 32-bit integer elements in each 4-element set of "a" and by element 1 of the corresponding
4-element set from "b", add the intermediate result to element 0 of the corresponding 4-element set from "b",
and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    base := (j &amp; ~0x3) * 32
    scale[31:0] := b[base+63:base+32]
    bias[31:0]  := b[base+31:base]
    dst[i+31:i] := (a[i+31:i] * scale[31:0]) + bias[31:0]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMADD233D - _mm512_mask_fmadd233_epi32

| 

--------------------------------------------------------------------------------------------------------------
Multiply packed 32-bit integer elements in each 4-element set of "a" and by element 1 of the corresponding
4-element set from "b", add the intermediate result to element 0 of the corresponding 4-element set from "b",
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        base := (j &amp; ~0x3) * 32
        scale[31:0] := b[base+63:base+32]
        bias[31:0]  := b[base+31:base]
        dst[i+31:i] := (a[i+31:i] * scale[31:0]) + bias[31:0]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD233PS - _mm512_fmadd233_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in each 4-element set of "a" and by element
1 of the corresponding 4-element set from "b", add the intermediate result to element 0 of the corresponding
4-element set from "b", and store the results in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    base := (j &amp; ~0x3) * 32
    scale[31:0] := b[base+63:base+32]
    bias[31:0]  := b[base+31:base]
    dst[i+31:i] := (a[i+31:i] * scale[31:0]) + bias[31:0]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD233PS - _mm512_mask_fmadd233_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in each 4-element set of "a" and by element
1 of the corresponding 4-element set from "b", add the intermediate result to element 0 of the corresponding
4-element set from "b", and store the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        base := (j &amp; ~0x3) * 32
        scale[31:0] := b[base+63:base+32]
        bias[31:0]  := b[base+31:base]
        dst[i+31:i] := (a[i+31:i] * scale[31:0]) + bias[31:0]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMAXABSPS - _mm512_maxabs_ps

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of the absolute elements of each pair of corresponding elements of packed
single-precision (32-bit) floating-point elements in "a" and "b", storing the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := FpMax(ABS(a[i+31:i]), ABS(b[i+31:i]))
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMAXABSPS - _mm512_mask_maxabs_ps

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of the absolute elements of each pair of corresponding elements of packed
single-precision (32-bit) floating-point elements in "a" and "b", storing the results in "dst" using writemask
"k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := FpMax(ABS(a[i+31:i]), ABS(b[i+31:i]))
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMAXPS - _mm512_gmax_ps

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of each pair of corresponding elements in packed single-precision (32-bit)
floating-point elements in "a" and "b", storing the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := FpMax(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMAXPS - _mm512_mask_gmax_ps

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of each pair of corresponding elements of packed single-precision (32-bit)
floating-point elements in "a" and "b", storing the results in "dst" using writemask "k" (elements are copied
from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := FpMax(a[i+31:i], b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMAXABSPS - _mm512_gmaxabs_ps

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of the absolute elements of each pair of corresponding elements of packed
single-precision (32-bit) floating-point elements in "a" and "b", storing the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := FpMax(ABS(a[i+31:i]), ABS(b[i+31:i]))
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMAXABSPS - _mm512_mask_gmaxabs_ps

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of the absolute elements of each pair of corresponding elements of packed
single-precision (32-bit) floating-point elements in "a" and "b", storing the results in "dst" using writemask
"k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := FpMax(ABS(a[i+31:i]), ABS(b[i+31:i]))
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMAXPD - _mm512_gmax_pd

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of each pair of corresponding elements in packed double-precision (64-bit)
floating-point elements in "a" and "b", storing the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := FpMax(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMAXPD - _mm512_mask_gmax_pd

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of each pair of corresponding elements of packed double-precision (64-bit)
floating-point elements in "a" and "b", storing the results in "dst" using writemask "k" (elements are copied
from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := FpMax(a[i+63:i], b[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMINPS - _mm512_gmin_ps

| 

--------------------------------------------------------------------------------------------------------------
Determines the minimum of each pair of corresponding elements in packed single-precision (32-bit)
floating-point elements in "a" and "b", storing the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := FpMin(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMINPS - _mm512_mask_gmin_ps

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of each pair of corresponding elements of packed single-precision (32-bit)
floating-point elements in "a" and "b", storing the results in "dst" using writemask "k" (elements are copied
from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := FpMin(a[i+31:i], b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMINPD - _mm512_gmin_pd

| 

--------------------------------------------------------------------------------------------------------------
Determines the minimum of each pair of corresponding elements in packed double-precision (64-bit)
floating-point elements in "a" and "b", storing the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := FpMin(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VGMINPD - _mm512_mask_gmin_pd

| 

--------------------------------------------------------------------------------------------------------------
Determines the maximum of each pair of corresponding elements of packed double-precision (64-bit)
floating-point elements in "a" and "b", storing the results in "dst" using writemask "k" (elements are copied
from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := FpMin(a[i+63:i], b[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULHD - _mm512_mulhi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element multiplication between packed 32-bit integer elements in "a" and "b" and stores
the high 32 bits of each result into "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) &gt;&gt; 32
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULHD - _mm512_mask_mulhi_epi32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element multiplication between packed 32-bit integer elements in "a" and "b" and stores
the high 32 bits of each result into "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) &gt;&gt; 32
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULHUD - _mm512_mulhi_epu32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element multiplication between packed unsigned 32-bit integer elements in "a" and "b" and
stores the high 32 bits of each result into "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (a[i+31:i] * b[i+31:i]) &gt;&gt; 32
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPMULHUD - _mm512_mask_mulhi_epu32

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element multiplication between packed unsigned 32-bit integer elements in "a" and "b" and
stores the high 32 bits of each result into "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (a[i+31:i] * b[i+31:i]) &gt;&gt; 32
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMF32X4 - _mm512_permute4f128_epi32

| 

--------------------------------------------------------------------------------------------------------------
Permutes 128-bit blocks of the packed 32-bit integer vector "a" using constant "imm8". The results are stored
in "dst".

[algorithm]

DEFINE SELECT4(src, control)  {
    CASE control[1:0] OF
    0: tmp[127:0] := src[127:0]
    1: tmp[127:0] := src[255:128]
    2: tmp[127:0] := src[383:256]
    3: tmp[127:0] := src[511:384]
    ESAC
    RETURN tmp[127:0]
}
FOR j := 0 to 3
    i := j*128
    n := j*2
    dst[i+127:i] := SELECT4(a[511:0], imm8[n+1:n])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMF32X4 - _mm512_mask_permute4f128_epi32

| 

--------------------------------------------------------------------------------------------------------------
Permutes 128-bit blocks of the packed 32-bit integer vector "a" using constant "imm8". The results are stored
in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

DEFINE SELECT4(src, control)  {
    CASE control[1:0] OF
    0: tmp[127:0] := src[127:0]
    1: tmp[127:0] := src[255:128]
    2: tmp[127:0] := src[383:256]
    3: tmp[127:0] := src[511:384]
    ESAC
    RETURN tmp[127:0]
}
tmp[511:0] := 0
FOR j := 0 to 3
    i := j*128
    n := j*2
    tmp[i+127:i] := SELECT4(a[511:0], imm8[n+1:n])
ENDFOR
FOR j := 0 to 15
    IF k[j]
        dst[i+31:i] := tmp[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VRCP23PS - _mm512_rcp23_ps

| 

--------------------------------------------------------------------------------------------------------------
Approximates the reciprocals of packed single-precision (32-bit) floating-point elements in "a" to 23 bits of
precision, storing the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (1.0 / a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VRCP23PS - _mm512_mask_rcp23_ps

| 

--------------------------------------------------------------------------------------------------------------
Approximates the reciprocals of packed single-precision (32-bit) floating-point elements in "a" to 23 bits of
precision, storing the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := (1.0 / a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VROUNDPS - _mm512_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" to the nearest integer value using
"expadj" and in the direction of "rounding", and store the results as packed single-precision floating-point
elements in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ROUND(a[i+31:i])
    CASE expadj OF
    _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
    _MM_EXPADJ_4:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
    _MM_EXPADJ_5:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
    _MM_EXPADJ_8:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
    _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
    _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
    _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
    _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VROUNDPS - _mm512_mask_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" to the nearest integer value using
"expadj" and in the direction of "rounding", and store the results as packed single-precision floating-point
elements in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ROUND(a[i+31:i])
        CASE expadj OF
        _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
        _MM_EXPADJ_4:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
        _MM_EXPADJ_5:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
        _MM_EXPADJ_8:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
        _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
        _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
        _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
        _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
        ESAC
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VRNDFXPNTPS - _mm512_roundfxpnt_adjust_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element rounding of packed single-precision (32-bit) floating-point elements in "a" using
"expadj" and in the direction of "rounding" and stores results in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ROUND(a[i+31:i])
    CASE expadj OF
    _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
    _MM_EXPADJ_4:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
    _MM_EXPADJ_5:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
    _MM_EXPADJ_8:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
    _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
    _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
    _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
    _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VRNDFXPNTPS - _mm512_mask_roundfxpnt_adjust_ps

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element rounding of packed single-precision (32-bit) floating-point elements in "a" using
"expadj" and in the direction of "rounding" and stores results in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ROUND(a[i+31:i])
        CASE expadj OF
        _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
        _MM_EXPADJ_4:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
        _MM_EXPADJ_5:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
        _MM_EXPADJ_8:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
        _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
        _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
        _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
        _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
        ESAC
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VRNDFXPNTPD - _mm512_roundfxpnt_adjust_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element rounding of packed double-precision (64-bit) floating-point elements in "a" using
"expadj" and in the direction of "rounding" and stores results in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ROUND(a[i+63:i])
    CASE expadj OF
    _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
    _MM_EXPADJ_4:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
    _MM_EXPADJ_5:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
    _MM_EXPADJ_8:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
    _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
    _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
    _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
    _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
    ESAC
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VRNDFXPNTPD - _mm512_mask_roundfxpnt_adjust_pd

| 

--------------------------------------------------------------------------------------------------------------
Performs element-by-element rounding of packed double-precision (64-bit) floating-point elements in "a" using
"expadj" and in the direction of "rounding" and stores results in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ROUND(a[i+63:i])
        CASE expadj OF
        _MM_EXPADJ_NONE: dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 0)
        _MM_EXPADJ_4:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 4)
        _MM_EXPADJ_5:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 5)
        _MM_EXPADJ_8:    dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 8)
        _MM_EXPADJ_16:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 16)
        _MM_EXPADJ_24:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 24)
        _MM_EXPADJ_31:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 31)
        _MM_EXPADJ_32:   dst[i+31:i] := dst[i+31:i] * (2 &lt;&lt; 32)
        ESAC
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VRSQRT23PS - _mm512_rsqrt23_ps

| 

--------------------------------------------------------------------------------------------------------------
Calculates the reciprocal square root of packed single-precision (32-bit) floating-point elements in "a" to 23
bits of accuracy and stores the result in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := Sqrt(1.0 / a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VRSQRT23PS - _mm512_mask_rsqrt23_ps

| 

--------------------------------------------------------------------------------------------------------------
Calculates the reciprocal square root of packed single-precision (32-bit) floating-point elements in "a" to 23
bits of accuracy and stores the result in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := Sqrt(1.0 / a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSCALEPS - _mm512_scale_ps

| 

--------------------------------------------------------------------------------------------------------------
Scales each single-precision (32-bit) floating-point element in "a" by multiplying it by 2**exponent, where
the exponent is the corresponding 32-bit integer element in "b", storing results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] * POW(2.0, FP32(b[i+31:i]))
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSCALEPS - _mm512_mask_scale_ps

| 

--------------------------------------------------------------------------------------------------------------
Scales each single-precision (32-bit) floating-point element in "a" by multiplying it by 2**exponent, where
the exponent is the corresponding 32-bit integer element in "b", storing results in "dst" using writemask "k"
(elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] * POW(2.0, FP32(b[i+31:i]))
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSCALEPS - _mm512_scale_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Scales each single-precision (32-bit) floating-point element in "a" by multiplying it by 2**exponent, where
the exponent is the corresponding 32-bit integer element in "b", storing results in "dst". Intermediate
elements are rounded using "rounding".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := a[i+31:i] * POW(2.0,FP32(b[i+31:i]))
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VSCALEPS - _mm512_mask_scale_round_ps

| 

--------------------------------------------------------------------------------------------------------------
Scales each single-precision (32-bit) floating-point element in "a" by multiplying it by 2**exp, where the exp
is the corresponding 32-bit integer element in "b", storing results in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set). Results are rounded using constant
"rounding".
	[round_note]

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := a[i+31:i] * POW(2.0, FP32(b[i+31:i]))
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD233PS - _mm512_fmadd233_ps

| 

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in each 4-element set of "a" and by element
1 of the corresponding 4-element set from "b", add the intermediate result to element 0 of the corresponding
4-element set from "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    base := (j &amp; ~0x3) * 32
    scale[31:0] := b[base+63:base+32]
    bias[31:0]  := b[base+31:base]
    dst[i+31:i] := (a[i+31:i] * scale[31:0]) + bias[31:0]
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VFMADD233PS - _mm512_mask_fmadd233_ps

| 

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in each 4-element set of "a" and by element
1 of the corresponding 4-element set from "b", add the intermediate result to element 0 of the corresponding
4-element set from "b", and store the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        base := (j &amp; ~0x3) * 32
        scale[31:0] := b[base+63:base+32]
        bias[31:0]  := b[base+31:base]
        dst[i+31:i] := (a[i+31:i] * scale[31:0]) + bias[31:0]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMF32X4 - _mm512_permute4f128_ps

| 

--------------------------------------------------------------------------------------------------------------
Permutes 128-bit blocks of the packed single-precision (32-bit) floating-point elements in "a" using constant
"imm8". The results are stored in "dst".

[algorithm]

DEFINE SELECT4(src, control)  {
    CASE control[1:0] OF
    0: tmp[127:0] := src[127:0]
    1: tmp[127:0] := src[255:128]
    2: tmp[127:0] := src[383:256]
    3: tmp[127:0] := src[511:384]
    ESAC
    RETURN tmp[127:0]
}
FOR j := 0 to 3
    i := j*128
    n := j*2
    dst[i+127:i] := SELECT4(a[511:0], imm8[n+1:n])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPERMF32X4 - _mm512_mask_permute4f128_ps

| 

--------------------------------------------------------------------------------------------------------------
Permutes 128-bit blocks of the packed single-precision (32-bit) floating-point elements in "a" using constant
"imm8". The results are stored in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

DEFINE SELECT4(src, control)  {
    CASE control[1:0] OF
    0: tmp[127:0] := src[127:0]
    1: tmp[127:0] := src[255:128]
    2: tmp[127:0] := src[383:256]
    3: tmp[127:0] := src[511:384]
    ESAC
    RETURN tmp[127:0]
}
tmp[511:0] := 0
FOR j := 0 to 3
    i := j*128
    n := j*2
    tmp[i+127:i] := SELECT4(a[511:0], imm8[n+1:n])
ENDFOR
FOR j := 0 to 15
    IF k[j]
        dst[i+31:i] := tmp[i+31:i]
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VAESENCLAST - _mm256_aesenclast_epi128

| VAESENCLAST_YMMu128_YMMu128_YMMu128

--------------------------------------------------------------------------------------------------------------
Perform the last round of an AES encryption flow on data (state) in "a" using the round key in "RoundKey", and
store the results in "dst"."

[algorithm]

FOR j := 0 to 1
    i := j*128
    a[i+127:i] := ShiftRows(a[i+127:i])
    a[i+127:i] := SubBytes(a[i+127:i])
    dst[i+127:i] := a[i+127:i] XOR RoundKey[i+127:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VAESENC - _mm256_aesenc_epi128

| VAESENC_YMMu128_YMMu128_YMMu128

--------------------------------------------------------------------------------------------------------------
Perform one round of an AES encryption flow on data (state) in "a" using the round key in "RoundKey", and
store the results in "dst"."

[algorithm]

FOR j := 0 to 1
    i := j*128
    a[i+127:i] := ShiftRows(a[i+127:i])
    a[i+127:i] := SubBytes(a[i+127:i])
    a[i+127:i] := MixColumns(a[i+127:i])
    dst[i+127:i] := a[i+127:i] XOR RoundKey[i+127:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VAESDECLAST - _mm256_aesdeclast_epi128

| VAESDECLAST_YMMu128_YMMu128_YMMu128

--------------------------------------------------------------------------------------------------------------
Perform the last round of an AES decryption flow on data (state) in "a" using the round key in "RoundKey", and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*128
    a[i+127:i] := InvShiftRows(a[i+127:i])
    a[i+127:i] := InvSubBytes(a[i+127:i])
    dst[i+127:i] := a[i+127:i] XOR RoundKey[i+127:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VAESDEC - _mm256_aesdec_epi128

| VAESDEC_YMMu128_YMMu128_YMMu128

--------------------------------------------------------------------------------------------------------------
Perform one round of an AES decryption flow on data (state) in "a" using the round key in "RoundKey", and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*128
    a[i+127:i] := InvShiftRows(a[i+127:i])
    a[i+127:i] := InvSubBytes(a[i+127:i])
    a[i+127:i] := InvMixColumns(a[i+127:i])
    dst[i+127:i] := a[i+127:i] XOR RoundKey[i+127:i]
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## VPCLMULQDQ - _mm512_clmulepi64_epi128

| VPCLMULQDQ_ZMMu128_ZMMu64_ZMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Carry-less multiplication of one quadword of
		'b' by one quadword of 'c', stores
		the 128-bit result in
'dst'. The immediate 'Imm8' is
		used to determine which quadwords of 'b'
		and 'c' should be used.

[algorithm]

DEFINE PCLMUL128(X,Y) {
    FOR i := 0 to 63
        TMP[i] := X[ 0 ] and Y[ i ]
        FOR j := 1 to i
            TMP[i] := TMP[i] xor (X[ j ] and Y[ i - j ])
        ENDFOR
        DEST[ i ] := TMP[ i ]
    ENDFOR
    FOR i := 64 to 126
        TMP[i] := 0
        FOR j := i - 63 to 63
            TMP[i] := TMP[i] xor (X[ j ] and Y[ i - j ])
        ENDFOR
        DEST[ i ] := TMP[ i ]
    ENDFOR
    DEST[127] := 0
    RETURN DEST // 128b vector
}
FOR i := 0 to 3
    IF Imm8[0] == 0
        TEMP1 := b.m128[i].qword[0]
    ELSE
        TEMP1 := b.m128[i].qword[1]
    FI
    IF Imm8[4] == 0
        TEMP2 := c.m128[i].qword[0]
    ELSE
        TEMP2 := c.m128[i].qword[1]
    FI
    dst.m128[i] := PCLMUL128(TEMP1, TEMP2)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## VPCLMULQDQ - _mm256_clmulepi64_epi128

| VPCLMULQDQ_YMMu128_YMMu64_YMMu64_IMM8_AVX512

--------------------------------------------------------------------------------------------------------------
Carry-less multiplication of one quadword of
		'b' by one quadword of 'c', stores
		the 128-bit result in
'dst'. The immediate 'Imm8' is
		used to determine which quadwords of 'b'
		and 'c' should be used.

[algorithm]

DEFINE PCLMUL128(X,Y) {
    FOR i := 0 to 63
        TMP[i] := X[ 0 ] and Y[ i ]
        FOR j := 1 to i
            TMP[i] := TMP[i] xor (X[ j ] and Y[ i - j ])
        ENDFOR
        DEST[ i ] := TMP[ i ]
    ENDFOR
    FOR i := 64 to 126
        TMP[i] := 0
        FOR j := i - 63 to 63
            TMP[i] := TMP[i] xor (X[ j ] and Y[ i - j ])
        ENDFOR
        DEST[ i ] := TMP[ i ]
    ENDFOR
    DEST[127] := 0
    RETURN DEST // 128b vector
}
FOR i := 0 to 1
    IF Imm8[0] == 0
        TEMP1 := b.m128[i].qword[0]
    ELSE
        TEMP1 := b.m128[i].qword[1]
    FI
    IF Imm8[4] == 0
        TEMP2 := c.m128[i].qword[0]
    ELSE
        TEMP2 := c.m128[i].qword[1]
    FI
    dst.m128[i] := PCLMUL128(TEMP1, TEMP2)
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------
