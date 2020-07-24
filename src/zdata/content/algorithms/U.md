# U

## UCOMISS - _mm_ucomieq_ss

| UCOMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for equality, and return the
boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[31:0] == b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISS - _mm_ucomilt_ss

| UCOMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for less-than, and return
the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[31:0] &lt; b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISS - _mm_ucomile_ss

| UCOMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for less-than-or-equal, and
return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[31:0] &lt;= b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISS - _mm_ucomigt_ss

| UCOMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for greater-than, and return
the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[31:0] &gt; b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISS - _mm_ucomige_ss

| UCOMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for greater-than-or-equal,
and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[31:0] &gt;= b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISS - _mm_ucomineq_ss

| UCOMISS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point element in "a" and "b" for not-equal, and return
the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[31:0] != b[31:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UNPCKHPS - _mm_unpackhi_ps

| UNPCKHPS_XMMps_XMMdq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave single-precision (32-bit) floating-point elements from the high half "a" and "b", and
store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_DWORDS(src1[127:0], src2[127:0]) {
    dst[31:0] := src1[95:64] 
    dst[63:32] := src2[95:64] 
    dst[95:64] := src1[127:96] 
    dst[127:96] := src2[127:96] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_HIGH_DWORDS(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## UNPCKLPS - _mm_unpacklo_ps

| UNPCKLPS_XMMps_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave single-precision (32-bit) floating-point elements from the low half of "a" and "b", and
store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_DWORDS(src1[127:0], src2[127:0]) {
    dst[31:0] := src1[31:0] 
    dst[63:32] := src2[31:0] 
    dst[95:64] := src1[63:32] 
    dst[127:96] := src2[63:32] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_DWORDS(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## UCOMISD - _mm_ucomieq_sd

| UCOMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for equality, and return the
boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[63:0] == b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISD - _mm_ucomilt_sd

| UCOMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for less-than, and return
the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[63:0] &lt; b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISD - _mm_ucomile_sd

| UCOMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for less-than-or-equal, and
return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[63:0] &lt;= b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISD - _mm_ucomigt_sd

| UCOMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for greater-than, and return
the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[63:0] &gt; b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISD - _mm_ucomige_sd

| UCOMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for greater-than-or-equal,
and return the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[63:0] &gt;= b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UCOMISD - _mm_ucomineq_sd

| UCOMISD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point element in "a" and "b" for not-equal, and return
the boolean result (0 or 1). This instruction will not signal an exception for QNaNs.

[algorithm]

RETURN ( a[63:0] != b[63:0] ) ? 1 : 0

--------------------------------------------------------------------------------------------------------------

## UNPCKHPD - _mm_unpackhi_pd

| UNPCKHPD_XMMpd_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave double-precision (64-bit) floating-point elements from the high half of "a" and "b", and
store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_QWORDS(src1[127:0], src2[127:0]) {
    dst[63:0] := src1[127:64] 
    dst[127:64] := src2[127:64] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_HIGH_QWORDS(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## UNPCKLPD - _mm_unpacklo_pd

| UNPCKLPD_XMMpd_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave double-precision (64-bit) floating-point elements from the low half of "a" and "b", and
store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_QWORDS(src1[127:0], src2[127:0]) {
    dst[63:0] := src1[63:0] 
    dst[127:64] := src2[63:0] 
    RETURN dst[127:0]
}
dst[127:0] := INTERLEAVE_QWORDS(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## UMWAIT - _umwait

| UMWAIT_GPR32

--------------------------------------------------------------------------------------------------------------
Directs the processor to enter an implementation-dependent optimized state while monitoring a range of
addresses. The instruction wakes up when the TSC reaches or exceeds the value specified in "counter" (if the
monitoring hardware did not trigger beforehand). Bit 0 of "ctrl" selects between a lower power (cleared) or
faster wakeup (set) optimized state. Returns the carry flag (CF).

[missing]

--------------------------------------------------------------------------------------------------------------

## UMONITOR - _umonitor

| UMONITOR_GPRa

--------------------------------------------------------------------------------------------------------------
Sets up a linear address range to be
		monitored by hardware and activates the
		monitor. The address range
should be a writeback
		memory caching type. The address is
		contained in "a".

[missing]

--------------------------------------------------------------------------------------------------------------
