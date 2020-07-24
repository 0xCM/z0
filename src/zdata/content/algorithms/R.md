# R

## RDSSPD - _rdsspd_i32

| RDSSPD_GPR32u32

--------------------------------------------------------------------------------------------------------------
Read the low 32-bits of the current shadow stack pointer, and store the result in "dst".

[algorithm]

dst := SSP[31:0]

--------------------------------------------------------------------------------------------------------------

## RDSSPQ - _rdsspq_i64

| RDSSPQ_GPR64u64

--------------------------------------------------------------------------------------------------------------
Read the current shadow stack pointer, and store the result in "dst".

[algorithm]

dst := SSP[63:0]

--------------------------------------------------------------------------------------------------------------

## RSTORSSP - _rstorssp

| RSTORSSP_MEMu64

--------------------------------------------------------------------------------------------------------------
Restore the saved shadow stack pointer from the shadow stack restore token previously created on shadow stack
by saveprevssp.

[missing]

--------------------------------------------------------------------------------------------------------------

## RDSSPD - _get_ssp

| RDSSPD_GPR32u32

--------------------------------------------------------------------------------------------------------------
If CET is enabled, read the low 32-bits of the current shadow stack pointer, and store the result in "dst".
Otherwise return 0.

[algorithm]

dst := SSP[31:0]

--------------------------------------------------------------------------------------------------------------

## RDSSPQ - _get_ssp

| RDSSPQ_GPR64u64

--------------------------------------------------------------------------------------------------------------
If CET is enabled, read the current shadow stack pointer, and store the result in "dst". Otherwise return 0.

[algorithm]

dst := SSP[63:0]

--------------------------------------------------------------------------------------------------------------

## RDFSBASE - _readfsbase_u32

| RDFSBASE_GPRy

--------------------------------------------------------------------------------------------------------------
Read the FS segment base register and store the 32-bit result in "dst".

[algorithm]

dst[31:0] := FS_Segment_Base_Register
dst[63:32] := 0

--------------------------------------------------------------------------------------------------------------

## RDFSBASE - _readfsbase_u64

| RDFSBASE_GPRy

--------------------------------------------------------------------------------------------------------------
Read the FS segment base register and store the 64-bit result in "dst".

[algorithm]

dst[63:0] := FS_Segment_Base_Register

--------------------------------------------------------------------------------------------------------------

## RDGSBASE - _readgsbase_u32

| RDGSBASE_GPRy

--------------------------------------------------------------------------------------------------------------
Read the GS segment base register and store the 32-bit result in "dst".

[algorithm]

dst[31:0] := GS_Segment_Base_Register
dst[63:32] := 0

--------------------------------------------------------------------------------------------------------------

## RDGSBASE - _readgsbase_u64

| RDGSBASE_GPRy

--------------------------------------------------------------------------------------------------------------
Read the GS segment base register and store the 64-bit result in "dst".

[algorithm]

dst[63:0] := GS_Segment_Base_Register

--------------------------------------------------------------------------------------------------------------

## ROL - _lrotl

| ROL_GPRv_IMMb | ROL_GPRv_IMMb

--------------------------------------------------------------------------------------------------------------
Shift the bits of unsigned long integer "a" left by the number of bits specified in "shift", rotating the
most-significant bit to the least-significant bit location, and store the unsigned result in "dst".

[algorithm]

// size := 32 or 64
dst := a
count := shift AND (size - 1)
DO WHILE (count &gt; 0)
    tmp[0] := dst[size - 1]
    dst := (dst &lt;&lt; 1) OR tmp[0]
    count := count - 1
OD

--------------------------------------------------------------------------------------------------------------

## ROR - _lrotr

| ROR_GPRv_IMMb

--------------------------------------------------------------------------------------------------------------
Shift the bits of unsigned long integer "a" right by the number of bits specified in "shift", rotating the
least-significant bit to the most-significant bit location, and store the unsigned result in "dst".

[algorithm]

// size := 32 or 64
dst := a
count := shift AND (size - 1)
DO WHILE (count &gt; 0)
    tmp[size - 1] := dst[0]
    dst := (dst &gt;&gt; 1) OR tmp[size - 1]
    count := count - 1
OD

--------------------------------------------------------------------------------------------------------------

## RDPMC - _rdpmc

| RDPMC

--------------------------------------------------------------------------------------------------------------
Read the Performance Monitor Counter (PMC) specified by "a", and store up to 64-bits in "dst". The width of
performance counters is implementation specific.

[algorithm]

dst[63:0] := ReadPMC(a)

--------------------------------------------------------------------------------------------------------------

## ROL - _rotl

| ROL_GPRv_IMMb

--------------------------------------------------------------------------------------------------------------
Shift the bits of unsigned 32-bit integer "a" left by the number of bits specified in "shift", rotating the
most-significant bit to the least-significant bit location, and store the unsigned result in "dst".

[algorithm]

dst := a
count := shift AND 31
DO WHILE (count &gt; 0)
    tmp[0] := dst[31]
    dst := (dst &lt;&lt; 1) OR tmp[0]
    count := count - 1
OD

--------------------------------------------------------------------------------------------------------------

## ROR - _rotr

| ROR_GPRv_IMMb

--------------------------------------------------------------------------------------------------------------
Shift the bits of unsigned 32-bit integer "a" right by the number of bits specified in "shift", rotating the
least-significant bit to the most-significant bit location, and store the unsigned result in "dst".

[algorithm]

dst := a
count := shift AND 31
DO WHILE (count &gt; 0)
    tmp[31] := dst[0]
    dst := (dst &gt;&gt; 1) OR tmp
    count := count - 1
OD

--------------------------------------------------------------------------------------------------------------

## ROL - _rotwl

| ROL_GPRv_IMMb

--------------------------------------------------------------------------------------------------------------
Shift the bits of unsigned 16-bit integer "a" left by the number of bits specified in "shift", rotating the
most-significant bit to the least-significant bit location, and store the unsigned result in "dst".

[algorithm]

dst := a
count := shift AND 15
DO WHILE (count &gt; 0)
    tmp[0] := dst[15]
    dst := (dst &lt;&lt; 1) OR tmp[0]
    count := count - 1
OD

--------------------------------------------------------------------------------------------------------------

## ROR - _rotwr

| ROR_GPRv_IMMb

--------------------------------------------------------------------------------------------------------------
Shift the bits of unsigned 16-bit integer "a" right by the number of bits specified in "shift", rotating the
least-significant bit to the most-significant bit location, and store the unsigned result in "dst".

[algorithm]

dst := a
count := shift AND 15
DO WHILE (count &gt; 0)
    tmp[15] := dst[0]
    dst := (dst &gt;&gt; 1) OR tmp
    count := count - 1
OD

--------------------------------------------------------------------------------------------------------------

## ROL - _rotl64

| ROL_GPRv_IMMb

--------------------------------------------------------------------------------------------------------------
Shift the bits of unsigned 64-bit integer "a" left by the number of bits specified in "shift", rotating the
most-significant bit to the least-significant bit location, and store the unsigned result in "dst".

[algorithm]

dst := a
count := shift AND 63
DO WHILE (count &gt; 0)
    tmp[0] := dst[63]
    dst := (dst &lt;&lt; 1) OR tmp[0]
    count := count - 1
OD

--------------------------------------------------------------------------------------------------------------

## ROR - _rotr64

| ROR_GPRv_IMMb

--------------------------------------------------------------------------------------------------------------
Shift the bits of unsigned 64-bit integer "a" right by the number of bits specified in "shift", rotating the
least-significant bit to the most-significant bit location, and store the unsigned result in "dst".

[algorithm]

dst := a
count := shift AND 63
DO WHILE (count &gt; 0)
    tmp[63] := dst[0]
    dst := (dst &gt;&gt; 1) OR tmp[63]
    count := count - 1
OD

--------------------------------------------------------------------------------------------------------------

## RDPID - _rdpid_u32

| RDPID_GPR32u32

--------------------------------------------------------------------------------------------------------------
Copy the IA32_TSC_AUX MSR (signature value) into "dst".

[algorithm]

dst[31:0] := IA32_TSC_AUX[31:0]

--------------------------------------------------------------------------------------------------------------

## RDRAND - _rdrand16_step

| RDRAND_GPRv

--------------------------------------------------------------------------------------------------------------
Read a hardware generated 16-bit random value and store the result in "val". Return 1 if a random value was
generated, and 0 otherwise.

[algorithm]

IF HW_RND_GEN.ready == 1
    val[15:0] := HW_RND_GEN.data
    dst := 1
ELSE
    val[15:0] := 0
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## RDRAND - _rdrand32_step

| RDRAND_GPRv

--------------------------------------------------------------------------------------------------------------
Read a hardware generated 32-bit random value and store the result in "val". Return 1 if a random value was
generated, and 0 otherwise.

[algorithm]

IF HW_RND_GEN.ready == 1
    val[31:0] := HW_RND_GEN.data
    dst := 1
ELSE
    val[31:0] := 0
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## RDRAND - _rdrand64_step

| RDRAND_GPRv

--------------------------------------------------------------------------------------------------------------
Read a hardware generated 64-bit random value and store the result in "val". Return 1 if a random value was
generated, and 0 otherwise.

[algorithm]

IF HW_RND_GEN.ready == 1
    val[63:0] := HW_RND_GEN.data
    dst := 1
ELSE
    val[63:0] := 0
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## RDSEED - _rdseed16_step

| RDSEED_GPRv

--------------------------------------------------------------------------------------------------------------
Read a 16-bit NIST SP800-90B and SP800-90C compliant random value and store in "val". Return 1 if a random
value was generated, and 0 otherwise.

[algorithm]

IF HW_NRND_GEN.ready == 1
    val[15:0] := HW_NRND_GEN.data
    dst := 1
ELSE
    val[15:0] := 0
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## RDSEED - _rdseed32_step

| RDSEED_GPRv

--------------------------------------------------------------------------------------------------------------
Read a 32-bit NIST SP800-90B and SP800-90C compliant random value and store in "val". Return 1 if a random
value was generated, and 0 otherwise.

[algorithm]

IF HW_NRND_GEN.ready == 1
    val[31:0] := HW_NRND_GEN.data
    dst := 1
ELSE
    val[31:0] := 0
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## RDSEED - _rdseed64_step

| RDSEED_GPRv

--------------------------------------------------------------------------------------------------------------
Read a 64-bit NIST SP800-90B and SP800-90C compliant random value and store in "val". Return 1 if a random
value was generated, and 0 otherwise.

[algorithm]

IF HW_NRND_GEN.ready == 1
    val[63:0] := HW_NRND_GEN.data
    dst := 1
ELSE
    val[63:0] := 0
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## RDTSCP - __rdtscp

| RDTSCP

--------------------------------------------------------------------------------------------------------------
Copy the current 64-bit value of the processor's time-stamp counter into "dst", and store the IA32_TSC_AUX MSR
(signature value) into memory at "mem_addr".

[algorithm]

dst[63:0] := TimeStampCounter
MEM[mem_addr+31:mem_addr] := IA32_TSC_AUX[31:0]

--------------------------------------------------------------------------------------------------------------

## RCPSS - _mm_rcp_ss

| RCPSS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compute the approximate reciprocal of the lower single-precision (32-bit) floating-point element in "a", store
the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements
of "dst". The maximum relative error for this approximation is less than 1.5*2^-12.

[algorithm]

dst[31:0] := (1.0 / a[31:0])
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## RCPPS - _mm_rcp_ps

| RCPPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Compute the approximate reciprocal of packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst". The maximum relative error for this approximation is less than 1.5*2^-12.

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := (1.0 / a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## RSQRTSS - _mm_rsqrt_ss

| RSQRTSS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compute the approximate reciprocal square root of the lower single-precision (32-bit) floating-point element
in "a", store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the
upper elements of "dst". The maximum relative error for this approximation is less than 1.5*2^-12.

[algorithm]

dst[31:0] := (1.0 / SQRT(a[31:0]))
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## RSQRTPS - _mm_rsqrt_ps

| RSQRTPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Compute the approximate reciprocal square root of packed single-precision (32-bit) floating-point elements in
"a", and store the results in "dst". The maximum relative error for this approximation is less than 1.5*2^-12.

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := (1.0 / SQRT(a[i+31:i]))
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ROUNDPD - _mm_round_pd

| ROUNDPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" using the "rounding" parameter, and
store the results as packed double-precision floating-point elements in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ROUND(a[i+63:i], rounding)
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ROUNDPD - _mm_floor_pd

| ROUNDPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" down to an integer value, and store
the results as packed double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := FLOOR(a[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ROUNDPD - _mm_ceil_pd

| ROUNDPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" up to an integer value, and store
the results as packed double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := CEIL(a[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ROUNDPS - _mm_round_ps

| ROUNDPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" using the "rounding" parameter, and
store the results as packed single-precision floating-point elements in "dst".
	[round_note]

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ROUND(a[i+31:i], rounding)
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ROUNDPS - _mm_floor_ps

| ROUNDPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" down to an integer value, and store
the results as packed single-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := FLOOR(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ROUNDPS - _mm_ceil_ps

| ROUNDPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" up to an integer value, and store
the results as packed single-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := CEIL(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ROUNDSD - _mm_round_sd

| ROUNDSD_XMMq_XMMq_IMMb

--------------------------------------------------------------------------------------------------------------
Round the lower double-precision (64-bit) floating-point element in "b" using the "rounding" parameter, store
the result as a double-precision floating-point element in the lower element of "dst", and copy the upper
element from "a" to the upper element of "dst".
	[round_note]

[algorithm]

dst[63:0] := ROUND(b[63:0], rounding)
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## ROUNDSD - _mm_floor_sd

| ROUNDSD_XMMq_XMMq_IMMb

--------------------------------------------------------------------------------------------------------------
Round the lower double-precision (64-bit) floating-point element in "b" down to an integer value, store the
result as a double-precision floating-point element in the lower element of "dst", and copy the upper element
from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := FLOOR(b[63:0])
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## ROUNDSD - _mm_ceil_sd

| ROUNDSD_XMMq_XMMq_IMMb

--------------------------------------------------------------------------------------------------------------
Round the lower double-precision (64-bit) floating-point element in "b" up to an integer value, store the
result as a double-precision floating-point element in the lower element of "dst", and copy the upper element
from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := CEIL(b[63:0])
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## ROUNDSS - _mm_round_ss

| ROUNDSS_XMMd_XMMd_IMMb

--------------------------------------------------------------------------------------------------------------
Round the lower single-precision (32-bit) floating-point element in "b" using the "rounding" parameter, store
the result as a single-precision floating-point element in the lower element of "dst", and copy the upper 3
packed elements from "a" to the upper elements of "dst".
	[round_note]

[algorithm]

dst[31:0] := ROUND(b[31:0], rounding)
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## ROUNDSS - _mm_floor_ss

| ROUNDSS_XMMd_XMMd_IMMb

--------------------------------------------------------------------------------------------------------------
Round the lower single-precision (32-bit) floating-point element in "b" down to an integer value, store the
result as a single-precision floating-point element in the lower element of "dst", and copy the upper 3 packed
elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := FLOOR(b[31:0])
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## ROUNDSS - _mm_ceil_ss

| ROUNDSS_XMMd_XMMd_IMMb

--------------------------------------------------------------------------------------------------------------
Round the lower single-precision (32-bit) floating-point element in "b" up to an integer value, store the
result as a single-precision floating-point element in the lower element of "dst", and copy the upper 3 packed
elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := CEIL(b[31:0])
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## RDTSC - _rdtsc

| RDTSC

--------------------------------------------------------------------------------------------------------------
Copy the current 64-bit value of the processor's time-stamp counter into "dst".

[algorithm]

dst[63:0] := TimeStampCounter

--------------------------------------------------------------------------------------------------------------
