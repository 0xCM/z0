# C

## CLRSSBSY - _clrssbsy

| CLRSSBSY_MEMu64

--------------------------------------------------------------------------------------------------------------
Mark shadow stack pointed to by "p" as not busy.

[missing]

--------------------------------------------------------------------------------------------------------------

## CLDEMOTE - _mm_cldemote

| CLDEMOTE_MEMu8

--------------------------------------------------------------------------------------------------------------
Hint to hardware that the cache line that contains "p" should be demoted from the cache closest to the
processor core to a level more distant from the processor core.

[missing]

--------------------------------------------------------------------------------------------------------------

## CLFLUSHOPT - _mm_clflushopt

| CLFLUSHOPT_MEMmprefetch

--------------------------------------------------------------------------------------------------------------
Invalidate and flush the cache line that contains "p" from all levels of the cache hierarchy.

[missing]

--------------------------------------------------------------------------------------------------------------

## CLWB - _mm_clwb

| CLWB_MEMmprefetch

--------------------------------------------------------------------------------------------------------------
Write back to memory the cache line that contains "p" from any level of the cache hierarchy in the cache
coherence domain.

[missing]

--------------------------------------------------------------------------------------------------------------

## CLEVICT0 - _mm_clevict

|  | 

--------------------------------------------------------------------------------------------------------------
Evicts the cache line containing the address "ptr" from cache level "level" (can be either 0 or 1).

[algorithm]

CacheLineEvict(ptr, level)

--------------------------------------------------------------------------------------------------------------

## CVTSI2SS - _mm_cvtsi32_ss

| CVTSI2SS_XMMss_GPR32d

--------------------------------------------------------------------------------------------------------------
Convert the signed 32-bit integer "b" to a single-precision (32-bit) floating-point element, store the result
in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := Convert_Int32_To_FP32(b[31:0])
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CVTSI2SS - _mm_cvt_si2ss

| CVTSI2SS_XMMss_GPR32d

--------------------------------------------------------------------------------------------------------------
Convert the signed 32-bit integer "b" to a single-precision (32-bit) floating-point element, store the result
in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := Convert_Int32_To_FP32(b[31:0])
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CVTSI2SS - _mm_cvtsi64_ss

| CVTSI2SS_XMMss_GPR64q

--------------------------------------------------------------------------------------------------------------
Convert the signed 64-bit integer "b" to a single-precision (32-bit) floating-point element, store the result
in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := Convert_Int64_To_FP32(b[63:0])
dst[127:32] := a[127:32]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## CVTPI2PS - _mm_cvtpi32_ps

| CVTPI2PS_XMMq_MMXq

--------------------------------------------------------------------------------------------------------------
Convert packed 32-bit integers in "b" to packed single-precision (32-bit) floating-point elements, store the
results in the lower 2 elements of "dst", and copy the upper 2 packed elements from "a" to the upper elements
of "dst".

[algorithm]

dst[31:0] := Convert_Int32_To_FP32(b[31:0])
dst[63:32] := Convert_Int32_To_FP32(b[63:32])
dst[95:64] := a[95:64]
dst[127:96] := a[127:96]

--------------------------------------------------------------------------------------------------------------

## CVTPI2PS - _mm_cvt_pi2ps

| CVTPI2PS_XMMq_MMXq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers in "b" to packed single-precision (32-bit) floating-point elements,
store the results in the lower 2 elements of "dst", and copy the upper 2 packed elements from "a" to the upper
elements of "dst".

[algorithm]

dst[31:0] := Convert_Int32_To_FP32(b[31:0])
dst[63:32] := Convert_Int32_To_FP32(b[63:32])
dst[95:64] := a[95:64]
dst[127:96] := a[127:96]

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpeq_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for equality, store the
result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of
"dst".

[algorithm]

dst[31:0] := ( a[31:0] == b[31:0] ) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpeq_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for equality, and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] == b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmplt_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for less-than, store the
result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of
"dst".

[algorithm]

dst[31:0] := ( a[31:0] &lt; b[31:0] ) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmplt_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for less-than, and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] &lt; b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmple_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for less-than-or-equal,
store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper
elements of "dst".

[algorithm]

dst[31:0] := ( a[31:0] &lt;= b[31:0] ) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmple_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for less-than-or-equal, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] &lt;= b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpgt_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for greater-than, store the
result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of
"dst".

[algorithm]

dst[31:0] := ( a[31:0] &gt; b[31:0] ) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpgt_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for greater-than, and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] &gt; b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpge_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for greater-than-or-equal,
store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper
elements of "dst".

[algorithm]

dst[31:0] := ( a[31:0] &gt;= b[31:0] ) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpge_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for greater-than-or-equal, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] &gt;= b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpneq_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for not-equal, store the
result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of
"dst".

[algorithm]

dst[31:0] := ( a[31:0] != b[31:0] ) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpneq_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-equal, and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] != b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpnlt_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than, store
the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements
of "dst".

[algorithm]

dst[31:0] := (!( a[31:0] &lt; b[31:0] )) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpnlt_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than, and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := !( a[i+31:i] &lt; b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpnle_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than-or-equal,
store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper
elements of "dst".

[algorithm]

dst[31:0] := (!( a[31:0] &lt;= b[31:0] )) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpnle_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-less-than-or-equal,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := (!( a[i+31:i] &lt;= b[i+31:i] )) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpngt_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for not-greater-than, store
the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements
of "dst".

[algorithm]

dst[31:0] := (!( a[31:0] &gt; b[31:0] )) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpngt_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-greater-than, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := (!( a[i+31:i] &gt; b[i+31:i] )) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpnge_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" for
not-greater-than-or-equal, store the result in the lower element of "dst", and copy the upper 3 packed elements
from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := (!( a[31:0] &gt;= b[31:0] )) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpnge_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" for not-greater-than-or-equal,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := (!( a[i+31:i] &gt;= b[i+31:i] )) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpord_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" to see if neither is NaN,
store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper
elements of "dst".

[algorithm]

dst[31:0] := ( a[31:0] != NaN AND b[31:0] != NaN ) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpord_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" to see if neither is NaN, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] != NaN AND b[i+31:i] != NaN ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSS - _mm_cmpunord_ss

| CMPSS_XMMss_XMMss_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b" to see if either is NaN,
store the result in the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper
elements of "dst".

[algorithm]

dst[31:0] := ( a[31:0] == NaN OR b[31:0] == NaN ) ? 0xFFFFFFFF : 0
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## CMPPS - _mm_cmpunord_ps

| CMPPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b" to see if either is NaN, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] == NaN OR b[i+31:i] == NaN ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## COMISS - _mm_comieq_ss

| COMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for equality, and return the
boolean result (0 or 1).

[algorithm]

RETURN ( a[31:0] == b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISS - _mm_comilt_ss

| COMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for less-than, and return
the boolean result (0 or 1).

[algorithm]

RETURN ( a[31:0] &lt; b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISS - _mm_comile_ss

| COMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for less-than-or-equal, and
return the boolean result (0 or 1).

[algorithm]

RETURN ( a[31:0] &lt;= b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISS - _mm_comigt_ss

| COMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for greater-than, and return
the boolean result (0 or 1).

[algorithm]

RETURN ( a[31:0] &gt; b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISS - _mm_comige_ss

| COMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for greater-than-or-equal,
and return the boolean result (0 or 1).

[algorithm]

RETURN ( a[31:0] &gt;= b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISS - _mm_comineq_ss

| COMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for not-equal, and return
the boolean result (0 or 1).

[algorithm]

RETURN ( a[31:0] != b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## CVTSS2SI - _mm_cvtss_si32

| CVTSS2SI_GPR32d_XMMss

--------------------------------------------------------------------------------------------------------------
Convert the lower single-precision (32-bit) floating-point element in "a" to a 32-bit integer, and store the
result in "dst".

[algorithm]

dst[31:0] := Convert_FP32_To_Int32(a[31:0])

--------------------------------------------------------------------------------------------------------------

## CVTSS2SI - _mm_cvt_ss2si

| CVTSS2SI_GPR32d_XMMss

--------------------------------------------------------------------------------------------------------------
Convert the lower single-precision (32-bit) floating-point element in "a" to a 32-bit integer, and store the
result in "dst".

[algorithm]

dst[31:0] := Convert_FP32_To_Int32(a[31:0])

--------------------------------------------------------------------------------------------------------------

## CVTSS2SI - _mm_cvtss_si64

| CVTSS2SI_GPR64q_XMMss

--------------------------------------------------------------------------------------------------------------
Convert the lower single-precision (32-bit) floating-point element in "a" to a 64-bit integer, and store the
result in "dst".

[algorithm]

dst[63:0] := Convert_FP32_To_Int64(a[31:0])

--------------------------------------------------------------------------------------------------------------

## CVTPS2PI - _mm_cvtps_pi32

| CVTPS2PI_MMXq_XMMq

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers, and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 32*j
    dst[i+31:i] := Convert_FP32_To_Int32(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTPS2PI - _mm_cvt_ps2pi

| CVTPS2PI_MMXq_XMMq

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers, and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 32*j
    dst[i+31:i] := Convert_FP32_To_Int32(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTTSS2SI - _mm_cvttss_si32

| CVTTSS2SI_GPR32d_XMMss

--------------------------------------------------------------------------------------------------------------
Convert the lower single-precision (32-bit) floating-point element in "a" to a 32-bit integer with truncation,
and store the result in "dst".

[algorithm]

dst[31:0] := Convert_FP32_To_Int32_Truncate(a[31:0])

--------------------------------------------------------------------------------------------------------------

## CVTTSS2SI - _mm_cvtt_ss2si

| CVTTSS2SI_GPR32d_XMMss

--------------------------------------------------------------------------------------------------------------
Convert the lower single-precision (32-bit) floating-point element in "a" to a 32-bit integer with truncation,
and store the result in "dst".

[algorithm]

dst[31:0] := Convert_FP32_To_Int32_Truncate(a[31:0])

--------------------------------------------------------------------------------------------------------------

## CVTTSS2SI - _mm_cvttss_si64

| CVTTSS2SI_GPR64q_XMMss

--------------------------------------------------------------------------------------------------------------
Convert the lower single-precision (32-bit) floating-point element in "a" to a 64-bit integer with truncation,
and store the result in "dst".

[algorithm]

dst[63:0] := Convert_FP32_To_Int64_Truncate(a[31:0])

--------------------------------------------------------------------------------------------------------------

## CVTTPS2PI - _mm_cvttps_pi32

| CVTTPS2PI_MMXq_XMMq

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers with
truncation, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 32*j
    dst[i+31:i] := Convert_FP32_To_Int32_Truncate(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTTPS2PI - _mm_cvtt_ps2pi

| CVTTPS2PI_MMXq_XMMq

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers with
truncation, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 32*j
    dst[i+31:i] := Convert_FP32_To_Int32_Truncate(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CLFLUSH - _mm_clflush

| CLFLUSH_MEMmprefetch

--------------------------------------------------------------------------------------------------------------
Invalidate and flush the cache line that contains "p" from all levels of the cache hierarchy.

[missing]

--------------------------------------------------------------------------------------------------------------

## CVTDQ2PD - _mm_cvtepi32_pd

| CVTDQ2PD_XMMpd_XMMq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers in "a" to packed double-precision (64-bit) floating-point elements, and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    m := j*64
    dst[m+63:m] := Convert_Int32_To_FP64(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTSI2SD - _mm_cvtsi32_sd

| CVTSI2SD_XMMsd_GPR32d

--------------------------------------------------------------------------------------------------------------
Convert the signed 32-bit integer "b" to a double-precision (64-bit) floating-point element, store the result
in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := Convert_Int32_To_FP64(b[31:0])
dst[127:64] := a[127:64]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## CVTSI2SD - _mm_cvtsi64_sd

| CVTSI2SD_XMMsd_GPR64q

--------------------------------------------------------------------------------------------------------------
Convert the signed 64-bit integer "b" to a double-precision (64-bit) floating-point element, store the result
in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := Convert_Int64_To_FP64(b[63:0])
dst[127:64] := a[127:64]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## CVTSI2SD - _mm_cvtsi64x_sd

| CVTSI2SD_XMMsd_GPR64q

--------------------------------------------------------------------------------------------------------------
Convert the signed 64-bit integer "b" to a double-precision (64-bit) floating-point element, store the result
in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := Convert_Int64_To_FP64(b[63:0])
dst[127:64] := a[127:64]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## CVTDQ2PS - _mm_cvtepi32_ps

| CVTDQ2PS_XMMps_XMMdq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers in "a" to packed single-precision (32-bit) floating-point elements, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := Convert_Int32_To_FP32(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTPI2PD - _mm_cvtpi32_pd

| CVTPI2PD_XMMpd_MMXq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers in "a" to packed double-precision (64-bit) floating-point elements, and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    m := j*64
    dst[m+63:m] := Convert_Int32_To_FP64(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpeq_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for equality, store the
result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := (a[63:0] == b[63:0]) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmplt_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for less-than, store the
result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := (a[63:0] &lt; b[63:0]) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmple_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for less-than-or-equal,
store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of
"dst".

[algorithm]

dst[63:0] := (a[63:0] &lt;= b[63:0]) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpgt_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for greater-than, store the
result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := (a[63:0] &gt; b[63:0]) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpge_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for greater-than-or-equal,
store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of
"dst".

[algorithm]

dst[63:0] := (a[63:0] &gt;= b[63:0]) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpord_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" to see if neither is NaN,
store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of
"dst".

[algorithm]

dst[63:0] := (a[63:0] != NaN AND b[63:0] != NaN) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpunord_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" to see if either is NaN,
store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of
"dst".

[algorithm]

dst[63:0] := (a[63:0] == NaN OR b[63:0] == NaN) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpneq_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for not-equal, store the
result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := (a[63:0] != b[63:0]) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpnlt_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than, store
the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := (!(a[63:0] &lt; b[63:0])) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpnle_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than-or-equal,
store the result in the lower element of "dst", and copy the upper element from "a" to the upper element of
"dst".

[algorithm]

dst[63:0] := (!(a[63:0] &lt;= b[63:0])) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpngt_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for not-greater-than, store
the result in the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := (!(a[63:0] &gt; b[63:0])) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPSD - _mm_cmpnge_sd

| CMPSD_XMM_XMMsd_XMMsd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b" for
not-greater-than-or-equal, store the result in the lower element of "dst", and copy the upper element from "a"
to the upper element of "dst".

[algorithm]

dst[63:0] := (!(a[63:0] &gt;= b[63:0])) ? 0xFFFFFFFFFFFFFFFF : 0
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpeq_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for equality, and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] == b[i+63:i]) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmplt_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for less-than, and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] &lt; b[i+63:i]) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmple_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for less-than-or-equal, and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] &lt;= b[i+63:i]) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpgt_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for greater-than, and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] &gt; b[i+63:i]) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpge_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for greater-than-or-equal, and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] &gt;= b[i+63:i]) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpord_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" to see if neither is NaN, and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] != NaN AND b[i+63:i] != NaN) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpunord_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" to see if either is NaN, and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] == NaN OR b[i+63:i] == NaN) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpneq_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-equal, and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (a[i+63:i] != b[i+63:i]) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpnlt_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than, and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (!(a[i+63:i] &lt; b[i+63:i])) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpnle_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-less-than-or-equal,
and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (!(a[i+63:i] &lt;= b[i+63:i])) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpngt_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-greater-than, and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (!(a[i+63:i] &gt; b[i+63:i])) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CMPPD - _mm_cmpnge_pd

| CMPPD_XMMpd_XMMpd_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b" for not-greater-than-or-equal,
and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := (!(a[i+63:i] &gt;= b[i+63:i])) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## COMISD - _mm_comieq_sd

| COMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for equality, and return the
boolean result (0 or 1).

[algorithm]

RETURN ( a[63:0] == b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISD - _mm_comilt_sd

| COMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for less-than, and return
the boolean result (0 or 1).

[algorithm]

RETURN ( a[63:0] &lt; b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISD - _mm_comile_sd

| COMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for less-than-or-equal, and
return the boolean result (0 or 1).

[algorithm]

RETURN ( a[63:0] &lt;= b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISD - _mm_comigt_sd

| COMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for greater-than, and return
the boolean result (0 or 1).

[algorithm]

RETURN ( a[63:0] &gt; b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISD - _mm_comige_sd

| COMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for greater-than-or-equal,
and return the boolean result (0 or 1).

[algorithm]

RETURN ( a[63:0] &gt;= b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## COMISD - _mm_comineq_sd

| COMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for not-equal, and return
the boolean result (0 or 1).

[algorithm]

RETURN ( a[63:0] != b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## CVTPD2PS - _mm_cvtpd_ps

| CVTPD2PS_XMMps_XMMpd

--------------------------------------------------------------------------------------------------------------
Convert packed double-precision (64-bit) floating-point elements in "a" to packed single-precision (32-bit)
floating-point elements, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 32*j
    k := 64*j
    dst[i+31:i] := Convert_FP64_To_FP32(a[k+63:k])
ENDFOR
dst[127:64] := 0

--------------------------------------------------------------------------------------------------------------

## CVTPS2PD - _mm_cvtps_pd

| CVTPS2PD_XMMpd_XMMq

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed double-precision (64-bit)
floating-point elements, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    k := 32*j
    dst[i+63:i] := Convert_FP32_To_FP64(a[k+31:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTPD2DQ - _mm_cvtpd_epi32

| CVTPD2DQ_XMMdq_XMMpd

--------------------------------------------------------------------------------------------------------------
Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers, and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 32*j
    k := 64*j
    dst[i+31:i] := Convert_FP64_To_Int32(a[k+63:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTSD2SI - _mm_cvtsd_si32

| CVTSD2SI_GPR32d_XMMsd

--------------------------------------------------------------------------------------------------------------
Convert the lower double-precision (64-bit) floating-point element in "a" to a 32-bit integer, and store the
result in "dst".

[algorithm]

dst[31:0] := Convert_FP64_To_Int32(a[63:0])

--------------------------------------------------------------------------------------------------------------

## CVTSD2SI - _mm_cvtsd_si64

| CVTSD2SI_GPR64q_XMMsd

--------------------------------------------------------------------------------------------------------------
Convert the lower double-precision (64-bit) floating-point element in "a" to a 64-bit integer, and store the
result in "dst".

[algorithm]

dst[63:0] := Convert_FP64_To_Int64(a[63:0])

--------------------------------------------------------------------------------------------------------------

## CVTSD2SI - _mm_cvtsd_si64x

| CVTSD2SI_GPR64q_XMMsd

--------------------------------------------------------------------------------------------------------------
Convert the lower double-precision (64-bit) floating-point element in "a" to a 64-bit integer, and store the
result in "dst".

[algorithm]

dst[63:0] := Convert_FP64_To_Int64(a[63:0])

--------------------------------------------------------------------------------------------------------------

## CVTSD2SS - _mm_cvtsd_ss

| CVTSD2SS_XMMss_XMMsd

--------------------------------------------------------------------------------------------------------------
Convert the lower double-precision (64-bit) floating-point element in "b" to a single-precision (32-bit)
floating-point element, store the result in the lower element of "dst", and copy the upper 3 packed elements
from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := Convert_FP64_To_FP32(b[63:0])
dst[127:32] := a[127:32]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## CVTSS2SD - _mm_cvtss_sd

| CVTSS2SD_XMMsd_XMMss

--------------------------------------------------------------------------------------------------------------
Convert the lower single-precision (32-bit) floating-point element in "b" to a double-precision (64-bit)
floating-point element, store the result in the lower element of "dst", and copy the upper element from "a" to
the upper element of "dst".

[algorithm]

dst[63:0] := Convert_FP32_To_FP64(b[31:0])
dst[127:64] := a[127:64]
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## CVTTPD2DQ - _mm_cvttpd_epi32

| CVTTPD2DQ_XMMdq_XMMpd

--------------------------------------------------------------------------------------------------------------
Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers with
truncation, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 32*j
    k := 64*j
    dst[i+31:i] := Convert_FP64_To_Int32_Truncate(a[k+63:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTTSD2SI - _mm_cvttsd_si32

| CVTTSD2SI_GPR32d_XMMsd

--------------------------------------------------------------------------------------------------------------
Convert the lower double-precision (64-bit) floating-point element in "a" to a 32-bit integer with truncation,
and store the result in "dst".

[algorithm]

dst[31:0] := Convert_FP64_To_Int32_Truncate(a[63:0])

--------------------------------------------------------------------------------------------------------------

## CVTTSD2SI - _mm_cvttsd_si64

| CVTTSD2SI_GPR64q_XMMsd

--------------------------------------------------------------------------------------------------------------
Convert the lower double-precision (64-bit) floating-point element in "a" to a 64-bit integer with truncation,
and store the result in "dst".

[algorithm]

dst[63:0] := Convert_FP64_To_Int64_Truncate(a[63:0])

--------------------------------------------------------------------------------------------------------------

## CVTTSD2SI - _mm_cvttsd_si64x

| CVTTSD2SI_GPR64q_XMMsd

--------------------------------------------------------------------------------------------------------------
Convert the lower double-precision (64-bit) floating-point element in "a" to a 64-bit integer with truncation,
and store the result in "dst".

[algorithm]

dst[63:0] := Convert_FP64_To_Int64_Truncate(a[63:0])

--------------------------------------------------------------------------------------------------------------

## CVTPS2DQ - _mm_cvtps_epi32

| CVTPS2DQ_XMMdq_XMMps

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers, and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := Convert_FP32_To_Int32(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTTPS2DQ - _mm_cvttps_epi32

| CVTTPS2DQ_XMMdq_XMMps

--------------------------------------------------------------------------------------------------------------
Convert packed single-precision (32-bit) floating-point elements in "a" to packed 32-bit integers with
truncation, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := Convert_FP32_To_Int32_Truncate(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTPD2PI - _mm_cvtpd_pi32

| CVTPD2PI_MMXq_XMMpd

--------------------------------------------------------------------------------------------------------------
Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers, and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 32*j
    k := 64*j
    dst[i+31:i] := Convert_FP64_To_Int32(a[k+63:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CVTTPD2PI - _mm_cvttpd_pi32

| CVTTPD2PI_MMXq_XMMpd

--------------------------------------------------------------------------------------------------------------
Convert packed double-precision (64-bit) floating-point elements in "a" to packed 32-bit integers with
truncation, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 32*j
    k := 64*j
    dst[i+31:i] := Convert_FP64_To_Int32_Truncate(a[k+63:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## CRC32 - _mm_crc32_u8

| CRC32_GPRyy_GPR8b

--------------------------------------------------------------------------------------------------------------
Starting with the initial value in "crc", accumulates a CRC32 value for unsigned 8-bit integer "v", and stores
the result in "dst".

[algorithm]

tmp1[7:0] := v[0:7] // bit reflection
tmp2[31:0] := crc[0:31] // bit reflection
tmp3[39:0] := tmp1[7:0] &lt;&lt; 32 
tmp4[39:0] := tmp2[31:0] &lt;&lt; 8
tmp5[39:0] := tmp3[39:0] XOR tmp4[39:0]
tmp6[31:0] := MOD2(tmp5[39:0], 0x11EDC6F41) // remainder from polynomial division modulus 2
dst[31:0] := tmp6[0:31] // bit reflection

--------------------------------------------------------------------------------------------------------------

## CRC32 - _mm_crc32_u16

| CRC32_GPRyy_GPRv

--------------------------------------------------------------------------------------------------------------
Starting with the initial value in "crc", accumulates a CRC32 value for unsigned 16-bit integer "v", and
stores the result in "dst".

[algorithm]

tmp1[15:0] := v[0:15] // bit reflection
tmp2[31:0] := crc[0:31] // bit reflection
tmp3[47:0] := tmp1[15:0] &lt;&lt; 32
tmp4[47:0] := tmp2[31:0] &lt;&lt; 16
tmp5[47:0] := tmp3[47:0] XOR tmp4[47:0]
tmp6[31:0] := MOD2(tmp5[47:0], 0x11EDC6F41) // remainder from polynomial division modulus 2
dst[31:0] := tmp6[0:31] // bit reflection

--------------------------------------------------------------------------------------------------------------

## CRC32 - _mm_crc32_u32

| CRC32_GPRyy_GPRv

--------------------------------------------------------------------------------------------------------------
Starting with the initial value in "crc", accumulates a CRC32 value for unsigned 32-bit integer "v", and
stores the result in "dst".

[algorithm]

tmp1[31:0] := v[0:31] // bit reflection
tmp2[31:0] := crc[0:31] // bit reflection
tmp3[63:0] := tmp1[31:0] &lt;&lt; 32
tmp4[63:0] := tmp2[31:0] &lt;&lt; 32
tmp5[63:0] := tmp3[63:0] XOR tmp4[63:0]
tmp6[31:0] := MOD2(tmp5[63:0], 0x11EDC6F41) // remainder from polynomial division modulus 2
dst[31:0] := tmp6[0:31] // bit reflection

--------------------------------------------------------------------------------------------------------------

## CRC32 - _mm_crc32_u64

| CRC32_GPRyy_GPRv

--------------------------------------------------------------------------------------------------------------
Starting with the initial value in "crc", accumulates a CRC32 value for unsigned 64-bit integer "v", and
stores the result in "dst".

[algorithm]

tmp1[63:0] := v[0:63] // bit reflection
tmp2[31:0] := crc[0:31] // bit reflection
tmp3[95:0] := tmp1[31:0] &lt;&lt; 32
tmp4[95:0] := tmp2[63:0] &lt;&lt; 64
tmp5[95:0] := tmp3[95:0] XOR tmp4[95:0]
tmp6[31:0] := MOD2(tmp5[95:0], 0x11EDC6F41) // remainder from polynomial division modulus 2
dst[31:0] := tmp6[0:31] // bit reflection

--------------------------------------------------------------------------------------------------------------
