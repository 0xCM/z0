# D

## DELAY - _mm_delay_32

| 

--------------------------------------------------------------------------------------------------------------
Stalls a thread without blocking other threads for 32-bit unsigned integer "r1" clock cycles.

[algorithm]

BlockThread(r1)

--------------------------------------------------------------------------------------------------------------

## DELAY - _mm_delay_64

| 

--------------------------------------------------------------------------------------------------------------
Stalls a thread without blocking other threads for 64-bit unsigned integer "r1" clock cycles.

[algorithm]

BlockThread(r1)

--------------------------------------------------------------------------------------------------------------

## DIVSS - _mm_div_ss

| DIVSS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Divide the lower single-precision (32-bit) floating-point element in "a" by the lower single-precision
(32-bit) floating-point element in "b", store the result in the lower element of "dst", and copy the upper 3
packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := a[31:0] / b[31:0]
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## DIVPS - _mm_div_ps

| DIVPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Divide packed single-precision (32-bit) floating-point elements in "a" by packed elements in "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := a[i+31:i] / b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## DIVSD - _mm_div_sd

| DIVSD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Divide the lower double-precision (64-bit) floating-point element in "a" by the lower double-precision
(64-bit) floating-point element in "b", store the result in the lower element of "dst", and copy the upper
element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := a[63:0] / b[63:0]
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## DIVPD - _mm_div_pd

| DIVPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Divide packed double-precision (64-bit) floating-point elements in "a" by packed elements in "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    dst[i+63:i] := a[i+63:i] / b[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## DPPD - _mm_dp_pd

| DPPD_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Conditionally multiply the packed double-precision (64-bit) floating-point elements in "a" and "b" using the
high 4 bits in "imm8", sum the four products, and conditionally store the sum in "dst" using the low 4 bits of
"imm8".

[algorithm]

DEFINE DP(a[127:0], b[127:0], imm8[7:0]) {
    FOR j := 0 to 1
        i := j*64
        IF imm8[(4+j)%8]
            temp[i+63:i] := a[i+63:i] * b[i+63:i]
        ELSE
            temp[i+63:i] := 0.0
        FI
    ENDFOR
    
    sum[63:0] := temp[127:64] + temp[63:0]
    
    FOR j := 0 to 1
        i := j*64
        IF imm8[j%8]
            tmpdst[i+63:i] := sum[63:0]
        ELSE
            tmpdst[i+63:i] := 0.0
        FI
    ENDFOR
    RETURN tmpdst[127:0]
}
dst[127:0] := DP(a[127:0], b[127:0], imm8[7:0])

--------------------------------------------------------------------------------------------------------------

## DPPS - _mm_dp_ps

| DPPS_XMMdq_XMMdq_IMMb

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
            temp[i+31:i] := 0
        FI
    ENDFOR
    
    sum[31:0] := (temp[127:96] + temp[95:64]) + (temp[63:32] + temp[31:0])
    
    FOR j := 0 to 3
        i := j*32
        IF imm8[j%8]
            tmpdst[i+31:i] := sum[31:0]
        ELSE
            tmpdst[i+31:i] := 0
        FI
    ENDFOR
    RETURN tmpdst[127:0]
}
dst[127:0] := DP(a[127:0], b[127:0], imm8[7:0])

--------------------------------------------------------------------------------------------------------------
