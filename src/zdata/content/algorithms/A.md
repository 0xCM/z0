# A

## ADCX - _addcarryx_u32

| ADCX_GPR32d_GPR32d | ADOX_GPR32d_GPR32d

--------------------------------------------------------------------------------------------------------------
Add unsigned 32-bit integers "a" and "b" with unsigned 8-bit carry-in "c_in" (carry or overflow flag), and
store the unsigned 32-bit result in "out", and the carry-out in "dst" (carry or overflow flag).

[algorithm]

tmp[32:0] := a[31:0] + b[31:0] + (c_in &gt; 0 ? 1 : 0)
MEM[out+31:out] := tmp[31:0]
dst[0] := tmp[32]
dst[7:1] := 0

--------------------------------------------------------------------------------------------------------------

## ADCX - _addcarryx_u64

| ADCX_GPR64q_GPR64q | ADOX_GPR64q_GPR64q

--------------------------------------------------------------------------------------------------------------
Add unsigned 64-bit integers "a" and "b" with unsigned 8-bit carry-in "c_in" (carry or overflow flag), and
store the unsigned 64-bit result in "out", and the carry-out in "dst" (carry or overflow flag).

[algorithm]

tmp[64:0] := a[63:0] + b[63:0] + (c_in &gt; 0 ? 1 : 0)
MEM[out+63:out] := tmp[63:0]
dst[0] := tmp[64]
dst[7:1] := 0

--------------------------------------------------------------------------------------------------------------

## AESENC - _mm_aesenc_si128

| AESENC_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Perform one round of an AES encryption flow on data (state) in "a" using the round key in "RoundKey", and
store the result in "dst"."

[algorithm]

a[127:0] := ShiftRows(a[127:0])
a[127:0] := SubBytes(a[127:0])
a[127:0] := MixColumns(a[127:0])
dst[127:0] := a[127:0] XOR RoundKey[127:0]

--------------------------------------------------------------------------------------------------------------

## AESENCLAST - _mm_aesenclast_si128

| AESENCLAST_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Perform the last round of an AES encryption flow on data (state) in "a" using the round key in "RoundKey", and
store the result in "dst"."

[algorithm]

a[127:0] := ShiftRows(a[127:0])
a[127:0] := SubBytes(a[127:0])
dst[127:0] := a[127:0] XOR RoundKey[127:0]

--------------------------------------------------------------------------------------------------------------

## AESDEC - _mm_aesdec_si128

| AESDEC_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Perform one round of an AES decryption flow on data (state) in "a" using the round key in "RoundKey", and
store the result in "dst".

[algorithm]

a[127:0] := InvShiftRows(a[127:0])
a[127:0] := InvSubBytes(a[127:0])
a[127:0] := InvMixColumns(a[127:0])
dst[127:0] := a[127:0] XOR RoundKey[127:0]

--------------------------------------------------------------------------------------------------------------

## AESDECLAST - _mm_aesdeclast_si128

| AESDECLAST_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Perform the last round of an AES decryption flow on data (state) in "a" using the round key in "RoundKey", and
store the result in "dst".

[algorithm]

a[127:0] := InvShiftRows(a[127:0])
a[127:0] := InvSubBytes(a[127:0])
dst[127:0] := a[127:0] XOR RoundKey[127:0]

--------------------------------------------------------------------------------------------------------------

## AESIMC - _mm_aesimc_si128

| AESIMC_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Perform the InvMixColumns transformation on "a" and store the result in "dst".

[algorithm]

dst[127:0] := InvMixColumns(a[127:0])

--------------------------------------------------------------------------------------------------------------

## AESKEYGENASSIST - _mm_aeskeygenassist_si128

| AESKEYGENASSIST_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Assist in expanding the AES cipher key by computing steps towards generating a round key for encryption cipher
using data from "a" and an 8-bit round constant specified in "imm8", and store the result in "dst"."

[algorithm]

X3[31:0] := a[127:96]
X2[31:0] := a[95:64]
X1[31:0] := a[63:32]
X0[31:0] := a[31:0]
RCON[31:0] := ZeroExtend32(imm8[7:0])
dst[31:0] := SubWord(X1)
dst[63:32] := RotWord(SubWord(X1)) XOR RCON
dst[95:64] := SubWord(X3)
dst[127:96] := RotWord(SubWord(X3)) XOR RCON

--------------------------------------------------------------------------------------------------------------

## ANDN - _andn_u32

| ANDN_VGPR32d_VGPR32d_VGPR32d

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 32-bit integer "a" and then AND with b, and store the results in dst.

[algorithm]

dst[31:0] := ((NOT a[31:0]) AND b[31:0])

--------------------------------------------------------------------------------------------------------------

## ANDN - _andn_u64

| ANDN_VGPR64q_VGPR64q_VGPR64q

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 64-bit integer "a" and then AND with b, and store the results in dst.

[algorithm]

dst[63:0] := ((NOT a[63:0]) AND b[63:0])

--------------------------------------------------------------------------------------------------------------

## ADC - _addcarry_u32

| ADC_GPRv_GPRv_11

--------------------------------------------------------------------------------------------------------------
Add unsigned 32-bit integers "a" and "b" with unsigned 8-bit carry-in "c_in" (carry flag), and store the
unsigned 32-bit result in "out", and the carry-out in "dst" (carry or overflow flag).

[algorithm]

tmp[32:0] := a[31:0] + b[31:0] + (c_in &gt; 0 ? 1 : 0)
MEM[out+31:out] := tmp[31:0]
dst[0] := tmp[32]
dst[7:1] := 0

--------------------------------------------------------------------------------------------------------------

## ADC - _addcarry_u64

| ADC_GPRv_GPRv_11

--------------------------------------------------------------------------------------------------------------
Add unsigned 64-bit integers "a" and "b" with unsigned 8-bit carry-in "c_in" (carry flag), and store the
unsigned 64-bit result in "out", and the carry-out in "dst" (carry or overflow flag).

[algorithm]

tmp[64:0] := a[63:0] + b[63:0] + (c_in &gt; 0 ? 1 : 0)
MEM[out+63:out] := tmp[63:0]
dst[0] := tmp[64]
dst[7:1] := 0

--------------------------------------------------------------------------------------------------------------

## ADDSS - _mm_add_ss

| ADDSS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Add the lower single-precision (32-bit) floating-point element in "a" and "b", store the result in the lower
element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := a[31:0] + b[31:0]
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## ADDPS - _mm_add_ps

| ADDPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Add packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[i+31:i] + b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ANDPS - _mm_and_ps

| ANDPS_XMMxud_XMMxud

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of packed single-precision (32-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := (a[i+31:i] AND b[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ANDNPS - _mm_andnot_ps

| ANDNPS_XMMxud_XMMxud

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of packed single-precision (32-bit) floating-point elements in "a" and then AND with
"b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ((NOT a[i+31:i]) AND b[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ADDSD - _mm_add_sd

| ADDSD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Add the lower double-precision (64-bit) floating-point element in "a" and "b", store the result in the lower
element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := a[63:0] + b[63:0]
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## ADDPD - _mm_add_pd

| ADDPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Add packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[i+63:i] + b[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ANDPD - _mm_and_pd

| ANDPD_XMMxuq_XMMxuq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of packed double-precision (64-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] AND b[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ANDNPD - _mm_andnot_pd

| ANDNPD_XMMxuq_XMMxuq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of packed double-precision (64-bit) floating-point elements in "a" and then AND with
"b", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ((NOT a[i+63:i]) AND b[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ADDSUBPS - _mm_addsub_ps

| ADDSUBPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Alternatively add and subtract packed single-precision (32-bit) floating-point elements in "a" to/from packed
elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF ((j &amp; 1) == 0)
        dst[i+31:i] := a[i+31:i] - b[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i] + b[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ADDSUBPD - _mm_addsub_pd

| ADDSUBPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Alternatively add and subtract packed double-precision (64-bit) floating-point elements in "a" to/from packed
elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF ((j &amp; 1) == 0)
        dst[i+63:i] := a[i+63:i] - b[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i] + b[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------
