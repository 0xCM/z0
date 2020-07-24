# S

## SAVEPREVSSP - _saveprevssp

| SAVEPREVSSP

--------------------------------------------------------------------------------------------------------------
Save the previous shadow stack pointer context.

[missing]

--------------------------------------------------------------------------------------------------------------

## SETSSBSY - _setssbsy

| SETSSBSY

--------------------------------------------------------------------------------------------------------------
Mark shadow stack pointed to by IA32_PL0_SSP as busy.

[missing]

--------------------------------------------------------------------------------------------------------------

## SPFLT - _mm_spflt_32

| 

--------------------------------------------------------------------------------------------------------------
Set performance monitoring filtering mask to 32-bit unsigned integer "r1".

[algorithm]

SetPerfMonMask(r1[31:0])

--------------------------------------------------------------------------------------------------------------

## SPFLT - _mm_spflt_64

| 

--------------------------------------------------------------------------------------------------------------
Set performance monitoring filtering mask to 64-bit unsigned integer "r1".

[algorithm]

SetPerfMonMask(r1[63:0])

--------------------------------------------------------------------------------------------------------------

## SBB - _subborrow_u32

| SBB_GPRv_GPRv_19

--------------------------------------------------------------------------------------------------------------
Add unsigned 8-bit borrow "c_in" (carry flag) to unsigned 32-bit integer "b", and subtract the result from
unsigned 32-bit integer "a". Store the unsigned 32-bit result in "out", and the carry-out in "dst" (carry or
overflow flag).

[algorithm]

tmp[32:0] := a[31:0] - (b[31:0] + (c_in &gt; 0 ? 1 : 0))
MEM[out+31:out] := tmp[31:0]
dst[0] := tmp[32]
dst[7:1] := 0

--------------------------------------------------------------------------------------------------------------

## SBB - _subborrow_u64

| SBB_GPRv_GPRv_19

--------------------------------------------------------------------------------------------------------------
Add unsigned 8-bit borrow "c_in" (carry flag) to unsigned 64-bit integer "b", and subtract the result from
unsigned 64-bit integer "a". Store the unsigned 64-bit result in "out", and the carry-out in "dst" (carry or
overflow flag).

[algorithm]

tmp[64:0] := a[63:0] - (b[63:0] + (c_in &gt; 0 ? 1 : 0))
MEM[out+63:out] := tmp[63:0]
dst[0] := tmp[64]
dst[7:1] := 0

--------------------------------------------------------------------------------------------------------------

## SERIALIZE - _serialize

| SERIALIZE

--------------------------------------------------------------------------------------------------------------
Serialize instruction execution, ensuring all modifications to flags, registers, and memory by previous
instructions are completed before the next instruction is fetched.

[missing]

--------------------------------------------------------------------------------------------------------------

## SHA1MSG1 - _mm_sha1msg1_epu32

| SHA1MSG1_XMMi32_XMMi32_SHA

--------------------------------------------------------------------------------------------------------------
Perform an intermediate calculation for the next four SHA1 message values (unsigned 32-bit integers) using
previous message values from "a" and "b", and store the result in "dst".

[algorithm]

W0 := a[127:96]
W1 := a[95:64]
W2 := a[63:32]
W3 := a[31:0]
W4 := b[127:96]
W5 := b[95:64]
dst[127:96] := W2 XOR W0
dst[95:64] := W3 XOR W1
dst[63:32] := W4 XOR W2
dst[31:0] := W5 XOR W3

--------------------------------------------------------------------------------------------------------------

## SHA1MSG2 - _mm_sha1msg2_epu32

| SHA1MSG2_XMMi32_XMMi32_SHA

--------------------------------------------------------------------------------------------------------------
Perform the final calculation for the next four SHA1 message values (unsigned 32-bit integers) using the
intermediate result in "a" and the previous message values in "b", and store the result in "dst".

[algorithm]

W13 := b[95:64]
W14 := b[63:32]
W15 := b[31:0]
W16 := (a[127:96] XOR W13) &lt;&lt;&lt; 1
W17 := (a[95:64] XOR W14) &lt;&lt;&lt; 1
W18 := (a[63:32] XOR W15) &lt;&lt;&lt; 1
W19 := (a[31:0] XOR W16) &lt;&lt;&lt; 1
dst[127:96] := W16
dst[95:64] := W17
dst[63:32] := W18
dst[31:0] := W19

--------------------------------------------------------------------------------------------------------------

## SHA1NEXTE - _mm_sha1nexte_epu32

| SHA1NEXTE_XMMi32_XMMi32_SHA

--------------------------------------------------------------------------------------------------------------
Calculate SHA1 state variable E after four rounds of operation from the current SHA1 state variable "a", add
that value to the scheduled values (unsigned 32-bit integers) in "b", and store the result in "dst".

[algorithm]

tmp := (a[127:96] &lt;&lt;&lt; 30)
dst[127:96] := b[127:96] + tmp
dst[95:64] := b[95:64]
dst[63:32] := b[63:32]
dst[31:0] := b[31:0]

--------------------------------------------------------------------------------------------------------------

## SHA1RNDS4 - _mm_sha1rnds4_epu32

| SHA1RNDS4_XMMi32_XMMi32_IMM8_SHA

--------------------------------------------------------------------------------------------------------------
Perform four rounds of SHA1 operation using an initial SHA1 state (A,B,C,D) from "a" and some pre-computed sum
of the next 4 round message values (unsigned 32-bit integers), and state variable E from "b", and store the
updated SHA1 state (A,B,C,D) in "dst". "func" contains the logic functions and round constants.

[algorithm]

IF (func[1:0] == 0)
    f := f0()
    K := K0
ELSE IF (func[1:0] == 1)
    f := f1()
    K := K1
ELSE IF (func[1:0] == 2)
    f := f2()
    K := K2
ELSE IF (func[1:0] == 3)
    f := f3()
    K := K3
FI
A := a[127:96]
B := a[95:64]
C := a[63:32]
D := a[31:0]
W[0] := b[127:96]
W[1] := b[95:64]
W[2] := b[63:32]
W[3] := b[31:0]
A[1] := f(B, C, D) + (A &lt;&lt;&lt; 5) + W[0] + K
B[1] := A
C[1] := B &lt;&lt;&lt; 30
D[1] := C
E[1] := D
FOR i := 1 to 3
    A[i+1] := f(B[i], C[i], D[i]) + (A[i] &lt;&lt;&lt; 5) + W[i] + E[i] + K
    B[i+1] := A[i]
    C[i+1] := B[i] &lt;&lt;&lt; 30
    D[i+1] := C[i]
    E[i+1] := D[i]
ENDFOR
dst[127:96] := A[4]
dst[95:64] := B[4]
dst[63:32] := C[4]
dst[31:0] := D[4]

--------------------------------------------------------------------------------------------------------------

## SHA256MSG1 - _mm_sha256msg1_epu32

| SHA256MSG1_XMMi32_XMMi32_SHA

--------------------------------------------------------------------------------------------------------------
Perform an intermediate calculation for the next four SHA256 message values (unsigned 32-bit integers) using
previous message values from "a" and "b", and store the result in "dst".

[algorithm]

W4 := b[31:0]
W3 := a[127:96]
W2 := a[95:64]
W1 := a[63:32]
W0 := a[31:0]
dst[127:96] := W3 + sigma0(W4)
dst[95:64] := W2 + sigma0(W3)
dst[63:32] := W1 + sigma0(W2)
dst[31:0] := W0 + sigma0(W1)

--------------------------------------------------------------------------------------------------------------

## SHA256MSG2 - _mm_sha256msg2_epu32

| SHA256MSG2_XMMi32_XMMi32_SHA

--------------------------------------------------------------------------------------------------------------
Perform the final calculation for the next four SHA256 message values (unsigned 32-bit integers) using
previous message values from "a" and "b", and store the result in "dst"."

[algorithm]

W14 := b[95:64]
W15 := b[127:96]
W16 := a[31:0] + sigma1(W14)
W17 := a[63:32] + sigma1(W15)
W18 := a[95:64] + sigma1(W16)
W19 := a[127:96] + sigma1(W17)
dst[127:96] := W19
dst[95:64] := W18
dst[63:32] := W17
dst[31:0] := W16

--------------------------------------------------------------------------------------------------------------

## SHA256RNDS2 - _mm_sha256rnds2_epu32

| SHA256RNDS2_XMMi32_XMMi32_SHA

--------------------------------------------------------------------------------------------------------------
Perform 2 rounds of SHA256 operation using an initial SHA256 state (C,D,G,H) from "a", an initial SHA256 state
(A,B,E,F) from "b", and a pre-computed sum of the next 2 round message values (unsigned 32-bit integers) and
the corresponding round constants from "k", and store the updated SHA256 state (A,B,E,F) in "dst".

[algorithm]

A[0] := b[127:96]
B[0] := b[95:64]
C[0] := a[127:96]
D[0] := a[95:64]
E[0] := b[63:32]
F[0] := b[31:0]
G[0] := a[63:32]
H[0] := a[31:0]
W_K[0] := k[31:0]
W_K[1] := k[63:32]
FOR i := 0 to 1
    A[i+1] := Ch(E[i], F[i], G[i]) + sum1(E[i]) + W_K[i] + H[i] + Maj(A[i], B[i], C[i]) + sum0(A[i])
    B[i+1] := A[i]
    C[i+1] := B[i]
    D[i+1] := C[i]
    E[i+1] := Ch(E[i], F[i], G[i]) + sum1(E[i]) + W_K[i] + H[i] + D[i]
    F[i+1] := E[i]
    G[i+1] := F[i]
    H[i+1] := G[i]
ENDFOR
dst[127:96] := A[2]
dst[95:64] := B[2]
dst[63:32] := E[2]
dst[31:0] := F[2]

--------------------------------------------------------------------------------------------------------------

## STMXCSR - _mm_getcsr

| STMXCSR_MEMd

--------------------------------------------------------------------------------------------------------------
Get the unsigned 32-bit value of the MXCSR control and status register.

[algorithm]

dst[31:0] := MXCSR

--------------------------------------------------------------------------------------------------------------

## SFENCE - _mm_sfence

| SFENCE

--------------------------------------------------------------------------------------------------------------
Perform a serializing operation on all store-to-memory instructions that were issued prior to this
instruction. Guarantees that every store instruction that precedes, in program order, is globally visible
before any store instruction which follows the fence in program order.

[missing]

--------------------------------------------------------------------------------------------------------------

## SUBSS - _mm_sub_ss

| SUBSS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Subtract the lower single-precision (32-bit) floating-point element in "b" from the lower single-precision
(32-bit) floating-point element in "a", store the result in the lower element of "dst", and copy the upper 3
packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := a[31:0] - b[31:0]
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## SUBPS - _mm_sub_ps

| SUBPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Subtract packed single-precision (32-bit) floating-point elements in "b" from packed single-precision (32-bit)
floating-point elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[i+31:i] - b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## SQRTSS - _mm_sqrt_ss

| SQRTSS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compute the square root of the lower single-precision (32-bit) floating-point element in "a", store the result
in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := SQRT(a[31:0])
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## SQRTPS - _mm_sqrt_ps

| SQRTPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := SQRT(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## SHUFPS - _mm_shuffle_ps

| SHUFPS_XMMps_XMMps_IMMb

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
dst[95:64] := SELECT4(b[127:0], imm8[5:4])
dst[127:96] := SELECT4(b[127:0], imm8[7:6])

--------------------------------------------------------------------------------------------------------------

## SQRTSD - _mm_sqrt_sd

| SQRTSD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compute the square root of the lower double-precision (64-bit) floating-point element in "b", store the result
in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := SQRT(b[63:0])
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## SQRTPD - _mm_sqrt_pd

| SQRTPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := SQRT(a[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## SUBSD - _mm_sub_sd

| SUBSD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Subtract the lower double-precision (64-bit) floating-point element in "b" from the lower double-precision
(64-bit) floating-point element in "a", store the result in the lower element of "dst", and copy the upper
element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := a[63:0] - b[63:0]
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## SUBPD - _mm_sub_pd

| SUBPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Subtract packed double-precision (64-bit) floating-point elements in "b" from packed double-precision (64-bit)
floating-point elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[i+63:i] - b[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## SHUFPD - _mm_shuffle_pd

| SHUFPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle double-precision (64-bit) floating-point elements using the control in "imm8", and store the results
in "dst".

[algorithm]

dst[63:0] := (imm8[0] == 0) ? a[63:0] : a[127:64]
dst[127:64] := (imm8[1] == 0) ? b[63:0] : b[127:64]

--------------------------------------------------------------------------------------------------------------
