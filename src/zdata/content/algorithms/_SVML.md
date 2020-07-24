# _SVML

## _mm256_acos_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cosine of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ACOS(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_acos_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ACOS(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_acosh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic cosine of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ACOSH(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_acosh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic cosine of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ACOSH(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_asin_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse sine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ASIN(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_asin_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse sine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ASIN(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_asinh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic sine of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ASINH(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_asinh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic sine of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ASINH(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_atan_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ATAN(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_atan_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ATAN(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_atan2_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed double-precision (64-bit) floating-point elements in "a" divided by
packed elements in "b", and store the results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ATAN2(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_atan2_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed single-precision (32-bit) floating-point elements in "a" divided by
packed elements in "b", and store the results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ATAN2(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_atanh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic tangent of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ATANH(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_atanh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic tangent of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ATANH(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cbrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the cube root of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := CubeRoot(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cbrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the cube root of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := CubeRoot(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cdfnorm_pd

--------------------------------------------------------------------------------------------------------------
Compute the cumulative distribution function of packed double-precision (64-bit) floating-point elements in
"a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := CDFNormal(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cdfnorm_ps

--------------------------------------------------------------------------------------------------------------
Compute the cumulative distribution function of packed single-precision (32-bit) floating-point elements in
"a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := CDFNormal(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cdfnorminv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cumulative distribution function of packed double-precision (64-bit) floating-point
elements in "a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := InverseCDFNormal(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cdfnorminv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cumulative distribution function of packed single-precision (32-bit) floating-point
elements in "a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := InverseCDFNormal(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cexp_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed complex numbers in "a", and store the
complex results in "dst". Each complex number is composed of two adjacent single-precision (32-bit)
floating-point elements, which defines the complex number "complex = vec.fp32[0] + i * vec.fp32[1]".

[algorithm]

DEFINE CEXP(a[31:0], b[31:0]) {
    result[31:0]  := POW(FP32(e), a[31:0]) * COS(b[31:0])
    result[63:32] := POW(FP32(e), a[31:0]) * SIN(b[31:0])
    RETURN result
}
FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := CEXP(a[i+31:i], a[i+63:i+32])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_clog_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed complex numbers in "a", and store the complex results in "dst". Each
complex number is composed of two adjacent single-precision (32-bit) floating-point elements, which defines the
complex number "complex = vec.fp32[0] + i * vec.fp32[1]".

[algorithm]

DEFINE CLOG(a[31:0], b[31:0]) {
    result[31:0]  := LOG(SQRT(POW(a, 2.0) + POW(b, 2.0)))
    result[63:32] := ATAN2(b, a)
    RETURN result
}
FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := CLOG(a[i+31:i], a[i+63:i+32])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cos_pd

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := COS(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cos_ps

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := COS(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cosd_pd

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := COSD(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cosd_ps

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := COSD(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cosh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := COSH(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_cosh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := COSH(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_csqrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed complex snumbers in "a", and store the complex results in "dst". Each
complex number is composed of two adjacent single-precision (32-bit) floating-point elements, which defines the
complex number "complex = vec.fp32[0] + i * vec.fp32[1]".

[algorithm]

DEFINE CSQRT(a[31:0], b[31:0]) {
    sign[31:0] := (b &lt; 0.0) ? -FP32(1.0) : FP32(1.0)
    result[31:0]  := SQRT((a + SQRT(POW(a, 2.0) + POW(b, 2.0))) / 2.0)
    result[63:32] := sign * SQRT((-a + SQRT(POW(a, 2.0) + POW(b, 2.0))) / 2.0)
    RETURN result
}
FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := CSQRT(a[i+31:i], a[i+63:i+32])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_div_epi8

--------------------------------------------------------------------------------------------------------------
Divide packed signed 8-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 31
    i := 8*j
    IF b[i+7:i] == 0
        #DE
    FI
    dst[i+7:i] := Truncate8(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_div_epi16

--------------------------------------------------------------------------------------------------------------
Divide packed signed 16-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := 16*j
    IF b[i+15:i] == 0
        #DE
    FI
    dst[i+15:i] := Truncate16(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_div_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed signed 32-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    IF b[i+31:i] == 0
        #DE
    FI
    dst[i+31:i] := Truncate32(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_div_epi64

--------------------------------------------------------------------------------------------------------------
Divide packed signed 64-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := 64*j
    IF b[i+63:i] == 0
        #DE
    FI
    dst[i+63:i] := Truncate64(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_div_epu8

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 8-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 31
    i := 8*j
    IF b[i+7:i] == 0
        #DE
    FI
    dst[i+7:i] := Truncate8(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_div_epu16

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 16-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := 16*j
    IF b[i+15:i] == 0
        #DE
    FI
    dst[i+15:i] := Truncate16(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_div_epu32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    IF b[i+31:i] == 0
        #DE
    FI
    dst[i+31:i] := Truncate32(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_div_epu64

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 64-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := 64*j
    IF b[i+63:i] == 0
        #DE
    FI
    dst[i+63:i] := Truncate64(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_erf_pd

--------------------------------------------------------------------------------------------------------------
Compute the error function of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ERF(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_erf_ps

--------------------------------------------------------------------------------------------------------------
Compute the error function of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ERF(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_erfc_pd

--------------------------------------------------------------------------------------------------------------
Compute the complementary error function of packed double-precision (64-bit) floating-point elements in "a",
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := 1.0 - ERF(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_erfc_ps

--------------------------------------------------------------------------------------------------------------
Compute the complementary error function of packed single-precision (32-bit) floating-point elements in "a",
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+63:i] := 1.0 - ERF(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_erfcinv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse complementary error function of packed double-precision (64-bit) floating-point elements
in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := 1.0 / (1.0 - ERF(a[i+63:i]))
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_erfcinv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse complementary error function of packed single-precision (32-bit) floating-point elements
in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+63:i] := 1.0 / (1.0 - ERF(a[i+31:i]))
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_erfinv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse error function of packed double-precision (64-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := 1.0 / ERF(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_erfinv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse error function of packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+63:i] := 1.0 / ERF(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_exp_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := POW(e, a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_exp_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := POW(FP32(e), a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_exp10_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 10 raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := POW(10.0, a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_exp10_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 10 raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := POW(FP32(10.0), a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_exp2_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 2 raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := POW(2.0, a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_exp2_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 2 raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := POW(FP32(2.0), a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_expm1_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed double-precision (64-bit) floating-point
elements in "a", subtract one from each element, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := POW(e, a[i+63:i]) - 1.0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_expm1_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed single-precision (32-bit) floating-point
elements in "a", subtract one from each element, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := POW(FP32(e), a[i+31:i]) - 1.0
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_hypot_pd

--------------------------------------------------------------------------------------------------------------
Compute the length of the hypotenous of a right triangle, with the lengths of the other two sides of the
triangle stored as packed double-precision (64-bit) floating-point elements in "a" and "b", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := SQRT(POW(a[i+63:i], 2.0) + POW(b[i+63:i], 2.0))
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_hypot_ps

--------------------------------------------------------------------------------------------------------------
Compute the length of the hypotenous of a right triangle, with the lengths of the other two sides of the
triangle stored as packed single-precision (32-bit) floating-point elements in "a" and "b", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := SQRT(POW(a[i+31:i], 2.0) + POW(b[i+31:i], 2.0))
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_idiv_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", and store the truncated results in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := TRUNCATE(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_idivrem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", store the truncated results in "dst", and
store the remainders as packed 32-bit integers into memory at "mem_addr".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := TRUNCATE(a[i+31:i] / b[i+31:i])
    MEM[mem_addr+i+31:mem_addr+i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_invcbrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cube root of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := InvCubeRoot(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_invcbrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cube root of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := InvCubeRoot(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_invsqrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse square root of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := InvSQRT(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_invsqrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse square root of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := InvSQRT(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_irem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_log_pd

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := LOG(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_log_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_log10_pd

--------------------------------------------------------------------------------------------------------------
Compute the base-10 logarithm of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := LOG(a[i+63:i]) / LOG(10.0)
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_log10_ps

--------------------------------------------------------------------------------------------------------------
Compute the base-10 logarithm of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i]) / LOG(10.0)
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_log1p_pd

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of one plus packed double-precision (64-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := LOG(1.0 + a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_log1p_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of one plus packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := LOG(1.0 + a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_log2_pd

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := LOG(a[i+63:i]) / LOG(2.0)
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_log2_ps

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i]) / LOG(2.0)
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_logb_pd

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed double-precision (64-bit) floating-point element in "a" to a
double-precision floating-point number representing the integer exponent, and store the results in "dst". This
intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ConvertExpFP64(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_logb_ps

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed single-precision (32-bit) floating-point element in "a" to a
single-precision floating-point number representing the integer exponent, and store the results in "dst". This
intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ConvertExpFP32(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_pow_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of packed double-precision (64-bit) floating-point elements in "a" raised by
packed elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := POW(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_pow_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of packed single-precision (32-bit) floating-point elements in "a" raised by
packed elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := POW(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_rem_epi8

--------------------------------------------------------------------------------------------------------------
Divide packed 8-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 31
    i := 8*j
    dst[i+7:i] := REMAINDER(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_rem_epi16

--------------------------------------------------------------------------------------------------------------
Divide packed 16-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := 16*j
    dst[i+15:i] := REMAINDER(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_rem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_rem_epi64

--------------------------------------------------------------------------------------------------------------
Divide packed 64-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := 64*j
    dst[i+63:i] := REMAINDER(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_rem_epu8

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 8-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 31
    i := 8*j
    dst[i+7:i] := REMAINDER(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_rem_epu16

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 16-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := 16*j
    dst[i+15:i] := REMAINDER(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_rem_epu32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_rem_epu64

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 64-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := 64*j
    dst[i+63:i] := REMAINDER(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_sin_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed double-precision (64-bit) floating-point elements in "a" expressed in radians, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := SIN(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_sin_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed single-precision (32-bit) floating-point elements in "a" expressed in radians, and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := SIN(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_sincos_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine and cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, store the sine in "dst", and store the cosine into memory at "mem_addr".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := SIN(a[i+63:i])
    MEM[mem_addr+i+63:mem_addr+i] := COS(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_sincos_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine and cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, store the sine in "dst", and store the cosine into memory at "mem_addr".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := SIN(a[i+31:i])
    MEM[mem_addr+i+31:mem_addr+i] := COS(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_sind_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := SIND(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_sind_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees, and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := SIND(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_sinh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic sine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := SINH(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_sinh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic sine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := SINH(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_svml_ceil_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" up to an integer value, and store
the results as packed double-precision floating-point elements in "dst". This intrinsic may generate the
"roundpd"/"vroundpd" instruction.

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := CEIL(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_svml_ceil_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" up to an integer value, and store
the results as packed single-precision floating-point elements in "dst". This intrinsic may generate the
"roundps"/"vroundps" instruction.

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := CEIL(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_svml_floor_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" down to an integer value, and store
the results as packed double-precision floating-point elements in "dst". This intrinsic may generate the
"roundpd"/"vroundpd" instruction.

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := FLOOR(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_svml_floor_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" down to an integer value, and store
the results as packed single-precision floating-point elements in "dst". This intrinsic may generate the
"roundps"/"vroundps" instruction.

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := FLOOR(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_svml_round_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" to the nearest integer value, and
store the results as packed double-precision floating-point elements in "dst". This intrinsic may generate the
"roundpd"/"vroundpd" instruction.

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := ROUND(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_svml_round_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" to the nearest integer value, and
store the results as packed single-precision floating-point elements in "dst". This intrinsic may generate the
"roundps"/"vroundps" instruction.

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := ROUND(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_svml_sqrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst". Note that this intrinsic is less efficient than "_mm_sqrt_pd".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := SQRT(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_svml_sqrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst". Note that this intrinsic is less efficient than "_mm_sqrt_ps".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := SQRT(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_tan_pd

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := TAN(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_tan_ps

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := TAN(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_tand_pd

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := TAND(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_tand_ps

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := TAND(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_tanh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := TANH(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_tanh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := TANH(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_trunc_pd

--------------------------------------------------------------------------------------------------------------
Truncate the packed double-precision (64-bit) floating-point elements in "a", and store the results as packed
double-precision floating-point elements in "dst". This intrinsic may generate the "roundpd"/"vroundpd"
instruction.

[algorithm]

FOR j := 0 to 3
    i := j*64
    dst[i+63:i] := TRUNCATE(a[i+63:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_trunc_ps

--------------------------------------------------------------------------------------------------------------
Truncate the packed single-precision (32-bit) floating-point elements in "a", and store the results as packed
single-precision floating-point elements in "dst". This intrinsic may generate the "roundps"/"vroundps"
instruction.

[algorithm]

FOR j := 0 to 7
    i := j*32
    dst[i+31:i] := TRUNCATE(a[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_udiv_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := TRUNCATE(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_udivrem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", store the truncated results in "dst",
and store the remainders as packed unsigned 32-bit integers into memory at "mem_addr".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := TRUNCATE(a[i+31:i] / b[i+31:i])
    MEM[mem_addr+i+31:mem_addr+i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm256_urem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:256] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_acos_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ACOS(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_acos_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ACOS(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_acos_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ACOS(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_acos_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ACOS(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_acosh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic cosine of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ACOSH(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_acosh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic cosine of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ACOSH(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_acosh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic cosine of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ACOSH(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_acosh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic cosine of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ACOSH(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_asin_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse sine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ASIN(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_asin_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse sine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ASIN(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_asin_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse sine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ASIN(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_asin_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse sine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ASIN(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_asinh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic sine of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ASINH(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_asinh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic sine of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ASINH(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_asinh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic sine of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ASINH(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_asinh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic sine of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ASINH(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_atan2_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed double-precision (64-bit) floating-point elements in "a" divided by
packed elements in "b", and store the results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ATAN2(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_atan2_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed double-precision (64-bit) floating-point elements in "a" divided by
packed elements in "b", and store the results in "dst" expressed in radians using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ATAN2(a[i+63:i], b[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_atan2_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed single-precision (32-bit) floating-point elements in "a" divided by
packed elements in "b", and store the results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ATAN2(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_atan2_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed single-precision (32-bit) floating-point elements in "a" divided by
packed elements in "b", and store the results in "dst" expressed in radians using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ATAN2(a[i+31:i], b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_atan_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed double-precision (64-bit) floating-point elements in "a" and store the
results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ATAN(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_atan_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst" expressed in radians using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ATAN(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_atan_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ATAN(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_atan_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ATAN(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_atanh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic tangent of packed double-precision (64-bit) floating-point elements in "a" and
store the results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ATANH(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_atanh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic tangent of packed double-precision (64-bit) floating-point elements in "a", and
store the results in "dst" expressed in radians using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ATANH(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_atanh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperblic tangent of packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ATANH(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_atanh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic tangent of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ATANH(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cbrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the cube root of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := CubeRoot(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cbrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the cube root of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := CubeRoot(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cbrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the cube root of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := CubeRoot(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cbrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the cube root of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := CubeRoot(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cdfnorm_pd

--------------------------------------------------------------------------------------------------------------
Compute the cumulative distribution function of packed double-precision (64-bit) floating-point elements in
"a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := CDFNormal(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cdfnorm_pd

--------------------------------------------------------------------------------------------------------------
Compute the cumulative distribution function of packed double-precision (64-bit) floating-point elements in
"a" using the normal distribution, and store the results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := CDFNormal(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cdfnorm_ps

--------------------------------------------------------------------------------------------------------------
Compute the cumulative distribution function of packed single-precision (32-bit) floating-point elements in
"a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := CDFNormal(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cdfnorm_ps

--------------------------------------------------------------------------------------------------------------
Compute the cumulative distribution function of packed single-precision (32-bit) floating-point elements in
"a" using the normal distribution, and store the results in "dst" using writemask "k" (elements are copied from
"src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := CDFNormal(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cdfnorminv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cumulative distribution function of packed double-precision (64-bit) floating-point
elements in "a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := InverseCDFNormal(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cdfnorminv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cumulative distribution function of packed double-precision (64-bit) floating-point
elements in "a" using the normal distribution, and store the results in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := InverseCDFNormal(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cdfnorminv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cumulative distribution function of packed single-precision (32-bit) floating-point
elements in "a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := InverseCDFNormal(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cdfnorminv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cumulative distribution function of packed single-precision (32-bit) floating-point
elements in "a" using the normal distribution, and store the results in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := InverseCDFNormal(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_ceil_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" up to an integer value, and store
the results as packed double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := CEIL(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_ceil_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" up to an integer value, and store
the results as packed double-precision floating-point elements in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := CEIL(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_ceil_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" up to an integer value, and store
the results as packed single-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := CEIL(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_ceil_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" up to an integer value, and store
the results as packed single-precision floating-point elements in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := CEIL(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cos_pd

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := COS(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cos_pd

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := COS(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cos_ps

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := COS(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cos_ps

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := COS(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cosd_pd

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := COSD(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cosd_pd

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := COSD(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cosd_ps

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := COSD(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cosd_ps

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := COSD(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cosh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := COSH(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cosh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := COSH(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_cosh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := COSH(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_cosh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := COSH(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_erf_pd

--------------------------------------------------------------------------------------------------------------
Compute the error function of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ERF(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_erf_pd

--------------------------------------------------------------------------------------------------------------
Compute the error function of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ERF(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_erfc_pd

--------------------------------------------------------------------------------------------------------------
Compute the complementary error function of packed double-precision (64-bit) floating-point elements in "a",
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := 1.0 - ERF(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_erfc_pd

--------------------------------------------------------------------------------------------------------------
Compute the complementary error function of packed double-precision (64-bit) floating-point elements in "a",
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := 1.0 - ERF(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_erf_ps

--------------------------------------------------------------------------------------------------------------
Compute the error function of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ERF(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_erf_ps

--------------------------------------------------------------------------------------------------------------
Compute the error function of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := ERF(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_erfc_ps

--------------------------------------------------------------------------------------------------------------
Compute the complementary error function of packed single-precision (32-bit) floating-point elements in "a",
and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+63:i] := 1.0 - ERF(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_erfc_ps

--------------------------------------------------------------------------------------------------------------
Compute the complementary error function of packed single-precision (32-bit) floating-point elements in "a",
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+63:i] := 1.0 - ERF(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_erfinv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse error function of packed double-precision (64-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := 1.0 / ERF(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_erfinv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse error function of packed double-precision (64-bit) floating-point elements in "a", and
store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit
is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := 1.0 / ERF(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_erfinv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse error function of packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+63:i] := 1.0 / ERF(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_erfinv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse error function of packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit
is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+63:i] := 1.0 / ERF(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_erfcinv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse complementary error function of packed double-precision (64-bit) floating-point elements
in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := 1.0 / (1.0 - ERF(a[i+63:i]))
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_erfcinv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse complementary error function of packed double-precision (64-bit) floating-point elements
in "a", and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := 1.0 / (1.0 - ERF(a[i+63:i]))
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_erfcinv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse complementary error function of packed single-precision (32-bit) floating-point elements
in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+63:i] := 1.0 / (1.0 - ERF(a[i+31:i]))
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_erfcinv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse complementary error function of packed single-precision (32-bit) floating-point elements
in "a", and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+63:i] := 1.0 / (1.0 - ERF(a[i+31:i]))
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_exp10_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 10 raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := POW(10.0, a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_exp10_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 10 raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := POW(10.0, a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_exp10_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 10 raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := POW(FP32(10.0), a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_exp10_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 10 raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := POW(FP32(10.0), a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_exp2_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 2 raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := POW(2.0, a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_exp2_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 2 raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := POW(2.0, a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_exp2_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 2 raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := POW(FP32(2.0), a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_exp2_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 2 raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := POW(FP32(2.0), a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_exp_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := POW(e, a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_exp_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := POW(e, a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_exp_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := POW(FP32(e), a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_exp_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := POW(FP32(e), a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_expm1_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed double-precision (64-bit) floating-point
elements in "a", subtract one from each element, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := POW(e, a[i+63:i]) - 1.0
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_expm1_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed double-precision (64-bit) floating-point
elements in "a", subtract one from each element, and store the results in "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := POW(e, a[i+63:i]) - 1.0
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_expm1_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed single-precision (32-bit) floating-point
elements in "a", subtract one from each element, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := POW(FP32(e), a[i+31:i]) - 1.0
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_expm1_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed single-precision (32-bit) floating-point
elements in "a", subtract one from each element, and store the results in "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := POW(FP32(e), a[i+31:i]) - 1.0
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_floor_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" down to an integer value, and store
the results as packed double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := FLOOR(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_floor_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" down to an integer value, and store
the results as packed double-precision floating-point elements in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := FLOOR(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_floor_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" down to an integer value, and store
the results as packed single-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := FLOOR(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_floor_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" down to an integer value, and store
the results as packed single-precision floating-point elements in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := FLOOR(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_hypot_pd

--------------------------------------------------------------------------------------------------------------
Compute the length of the hypotenous of a right triangle, with the lengths of the other two sides of the
triangle stored as packed double-precision (64-bit) floating-point elements in "a" and "b", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := SQRT(POW(a[i+63:i], 2.0) + POW(b[i+63:i], 2.0))
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_hypot_pd

--------------------------------------------------------------------------------------------------------------
Compute the length of the hypotenous of a right triangle, with the lengths of the other two sides of the
triangle stored as packed double-precision (64-bit) floating-point elements in "a" and "b", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := SQRT(POW(a[i+63:i], 2.0) + POW(b[i+63:i], 2.0))
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_hypot_ps

--------------------------------------------------------------------------------------------------------------
Compute the length of the hypotenous of a right triangle, with the lengths of the other two sides of the
triangle stored as packed single-precision (32-bit) floating-point elements in "a" and "b", and store the
results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := SQRT(POW(a[i+31:i], 2.0) + POW(b[i+31:i], 2.0))
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_hypot_ps

--------------------------------------------------------------------------------------------------------------
Compute the length of the hypotenous of a right triangle, with the lengths of the other two sides of the
triangle stored as packed single-precision (32-bit) floating-point elements in "a" and "b", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := SQRT(POW(a[i+31:i], 2.0) + POW(b[i+31:i], 2.0))
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_div_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed signed 32-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := 32*j
    IF b[i+31:i] == 0
        #DE
    FI
    dst[i+31:i] := Truncate32(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_div_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed signed 32-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := 32*j
    IF k[j]
        IF b[i+31:i] == 0
            #DE
        FI
        dst[i+31:i] := Truncate32(a[i+31:i] / b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_div_epi8

--------------------------------------------------------------------------------------------------------------
Divide packed signed 8-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 63
    i := 8*j
    IF b[i+7:i] == 0
        #DE
    FI
    dst[i+7:i] := Truncate8(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_div_epi16

--------------------------------------------------------------------------------------------------------------
Divide packed signed 16-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 31
    i := 16*j
    IF b[i+15:i] == 0
        #DE
    FI
    dst[i+15:i] := Truncate16(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_div_epi64

--------------------------------------------------------------------------------------------------------------
Divide packed signed 64-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := 64*j
    IF b[i+63:i] == 0
        #DE
    FI
    dst[i+63:i] := Truncate64(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_invsqrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse square root of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := InvSQRT(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_invsqrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse square root of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := InvSQRT(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_invsqrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse square root of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := InvSQRT(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_invsqrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse square root of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := InvSQRT(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_rem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_rem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := 32*j
    IF k[j]
        dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_rem_epi8

--------------------------------------------------------------------------------------------------------------
Divide packed 8-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 63
    i := 8*j
    dst[i+7:i] := REMAINDER(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_rem_epi16

--------------------------------------------------------------------------------------------------------------
Divide packed 16-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 31
    i := 16*j
    dst[i+15:i] := REMAINDER(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_rem_epi64

--------------------------------------------------------------------------------------------------------------
Divide packed 64-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := 64*j
    dst[i+63:i] := REMAINDER(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_log10_pd

--------------------------------------------------------------------------------------------------------------
Compute the base-10 logarithm of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := LOG(a[i+63:i]) / LOG(10.0)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_log10_pd

--------------------------------------------------------------------------------------------------------------
Compute the base-10 logarithm of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := LOG(a[i+63:i]) / LOG(10.0)
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_log10_ps

--------------------------------------------------------------------------------------------------------------
Compute the base-10 logarithm of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i]) / LOG(10.0)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_log10_ps

--------------------------------------------------------------------------------------------------------------
Compute the base-10 logarithm of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := LOG(a[i+31:i]) / LOG(10.0)
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_log1p_pd

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of one plus packed double-precision (64-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := LOG(1.0 + a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_log1p_pd

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of one plus packed double-precision (64-bit) floating-point elements in "a", and
store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit
is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := LOG(1.0 + a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_log1p_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of one plus packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := LOG(1.0 + a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_log1p_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of one plus packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit
is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := LOG(1.0 + a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_log2_pd

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := LOG(a[i+63:i]) / LOG(2.0)
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_log2_pd

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := LOG(a[i+63:i]) / LOG(2.0)
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_log_pd

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := LOG(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_log_pd

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := LOG(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_log_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_log_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := LOG(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_logb_pd

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed double-precision (64-bit) floating-point element in "a" to a
double-precision floating-point number representing the integer exponent, and store the results in "dst". This
intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ConvertExpFP64(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_logb_pd

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed double-precision (64-bit) floating-point element in "a" to a
double-precision floating-point number representing the integer exponent, and store the results in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). This intrinsic
essentially calculates "floor(log2(x))" for each element.

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

## _mm512_logb_ps

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed single-precision (32-bit) floating-point element in "a" to a
single-precision floating-point number representing the integer exponent, and store the results in "dst". This
intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := ConvertExpFP32(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_logb_ps

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed single-precision (32-bit) floating-point element in "a" to a
single-precision floating-point number representing the integer exponent, and store the results in "dst" using
writemask "k" (elements are copied from "src" when the corresponding mask bit is not set). This intrinsic
essentially calculates "floor(log2(x))" for each element.

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

## _mm512_nearbyint_pd

--------------------------------------------------------------------------------------------------------------
Rounds each packed double-precision (64-bit) floating-point element in "a" to the nearest integer value and
stores the results as packed double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := NearbyInt(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_nearbyint_pd

--------------------------------------------------------------------------------------------------------------
Rounds each packed double-precision (64-bit) floating-point element in "a" to the nearest integer value and
stores the results as packed double-precision floating-point elements in "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := NearbyInt(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_nearbyint_ps

--------------------------------------------------------------------------------------------------------------
Rounds each packed single-precision (32-bit) floating-point element in "a" to the nearest integer value and
stores the results as packed double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := NearbyInt(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_nearbyint_ps

--------------------------------------------------------------------------------------------------------------
Rounds each packed single-precision (32-bit) floating-point element in "a" to the nearest integer value and
stores the results as packed double-precision floating-point elements in "dst" using writemask "k" (elements
are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := NearbyInt(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_pow_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of packed double-precision (64-bit) floating-point elements in "a" raised by
packed elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := POW(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_pow_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of packed double-precision (64-bit) floating-point elements in "a" raised by
packed elements in "b", and store the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := POW(a[i+63:i], b[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_pow_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of packed single-precision (32-bit) floating-point elements in "a" raised by
packed elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := POW(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_pow_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of packed single-precision (32-bit) floating-point elements in "a" raised by
packed elements in "b", and store the results in "dst" using writemask "k" (elements are copied from "src" when
the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := POW(a[i+31:i], b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_recip_pd

--------------------------------------------------------------------------------------------------------------
Computes the reciprocal of packed double-precision (64-bit) floating-point elements in "a", storing the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := (1.0 / a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_recip_pd

--------------------------------------------------------------------------------------------------------------
Computes the reciprocal of packed double-precision (64-bit) floating-point elements in "a", storing the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := (1.0 / a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_recip_ps

--------------------------------------------------------------------------------------------------------------
Computes the reciprocal of packed single-precision (32-bit) floating-point elements in "a", storing the
results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := (1.0 / a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_recip_ps

--------------------------------------------------------------------------------------------------------------
Computes the reciprocal of packed single-precision (32-bit) floating-point elements in "a", storing the
results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not
set).

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

## _mm512_rint_pd

--------------------------------------------------------------------------------------------------------------
Rounds the packed double-precision (64-bit) floating-point elements in "a" to the nearest even integer value
and stores the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := RoundToNearestEven(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_rint_pd

--------------------------------------------------------------------------------------------------------------
Rounds the packed double-precision (64-bit) floating-point elements in "a" to the nearest even integer value
and stores the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := RoundToNearestEven(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_rint_ps

--------------------------------------------------------------------------------------------------------------
Rounds the packed single-precision (32-bit) floating-point elements in "a" to the nearest even integer value
and stores the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := RoundToNearestEven(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_rint_ps

--------------------------------------------------------------------------------------------------------------
Rounds the packed single-precision (32-bit) floating-point elements in "a" to the nearest even integer value
and stores the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := RoundToNearestEven(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_svml_round_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" to the nearest integer value, and
store the results as packed double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := ROUND(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_svml_round_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" to the nearest integer value, and
store the results as packed double-precision floating-point elements in "dst" using writemask "k" (elements are
copied from "src" when the corresponding mask bit is not set).
	[round_note]

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := ROUND(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i] 
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_sin_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed double-precision (64-bit) floating-point elements in "a" expressed in radians, and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := SIN(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_sin_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed double-precision (64-bit) floating-point elements in "a" expressed in radians, and
store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit
is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := SIN(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_sin_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed single-precision (32-bit) floating-point elements in "a" expressed in radians, and
store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := SIN(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_sin_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed single-precision (32-bit) floating-point elements in "a" expressed in radians, and
store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit
is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := SIN(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_sinh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic sine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := SINH(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_sinh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic sine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := SINH(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_sinh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic sine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := SINH(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_sinh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic sine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := SINH(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_sind_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees, and
store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := SIND(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_sind_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees, and
store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit
is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := SIND(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_sind_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees, and
store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := SIND(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_sind_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees, and
store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit
is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := SIND(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_tan_pd

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := TAN(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_tan_pd

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := TAN(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_tan_ps

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := TAN(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_tan_ps

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := TAN(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_tand_pd

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := TAND(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_tand_pd

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := TAND(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_tand_ps

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := TAND(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_tand_ps

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst" using writemask "k" (elements are copied from "src" when the corresponding mask
bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := TAND(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_tanh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := TANH(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_tanh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := TANH(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_tanh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := TANH(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_tanh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := TANH(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_trunc_pd

--------------------------------------------------------------------------------------------------------------
Truncate the packed double-precision (64-bit) floating-point elements in "a", and store the results as packed
double-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := TRUNCATE(a[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_trunc_pd

--------------------------------------------------------------------------------------------------------------
Truncate the packed double-precision (64-bit) floating-point elements in "a", and store the results as packed
double-precision floating-point elements in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := TRUNCATE(a[i+63:i])
    ELSE
        dst[i+63:i] := src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_trunc_ps

--------------------------------------------------------------------------------------------------------------
Truncate the packed single-precision (32-bit) floating-point elements in "a", and store the results as packed
single-precision floating-point elements in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := TRUNCATE(a[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_trunc_ps

--------------------------------------------------------------------------------------------------------------
Truncate the packed single-precision (32-bit) floating-point elements in "a", and store the results as packed
single-precision floating-point elements in "dst" using writemask "k" (elements are copied from "src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := TRUNCATE(a[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_div_epu32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := 32*j
    IF b[i+31:i] == 0
        #DE
    FI
    dst[i+31:i] := Truncate32(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_div_epu32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst" using writemask "k" (elements are copied from "src" when the corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := 32*j
    IF k[j]
        IF b[i+31:i] == 0
            #DE
        FI
        dst[i+31:i] := Truncate32(a[i+31:i] / b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_div_epu8

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 8-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 63
    i := 8*j
    IF b[i+7:i] == 0
        #DE
    FI
    dst[i+7:i] := Truncate8(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_div_epu16

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 16-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 31
    i := 16*j
    IF b[i+15:i] == 0
        #DE
    FI
    dst[i+15:i] := Truncate16(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_div_epu64

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 64-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := 64*j
    IF b[i+63:i] == 0
        #DE
    FI
    dst[i+63:i] := Truncate64(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_rem_epu32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_rem_epu32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst" using writemask "k" (elements are copied from "src" when the corresponding
mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := 32*j
    IF k[j]
        dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
    ELSE
        dst[i+31:i] := src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_rem_epu8

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 8-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 63
    i := 8*j
    dst[i+7:i] := REMAINDER(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_rem_epu16

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 16-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 31
    i := 16*j
    dst[i+15:i] := REMAINDER(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_rem_epu64

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 64-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := 64*j
    dst[i+63:i] := REMAINDER(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_sincos_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine and cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, store the sine in "dst", and store the cosine into memory at "mem_addr".

[algorithm]

FOR j := 0 to 7
    i := j*64
    dst[i+63:i] := SIN(a[i+63:i])
    MEM[mem_addr+i+63:mem_addr+i] := COS(a[i+63:i])
ENDFOR
dst[MAX:512] := 0
cos_res[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_sincos_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine and cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, store the sine in "dst", store the cosine into memory at "mem_addr". Elements are written to their
respective locations using writemask "k" (elements are copied from "sin_src" or "cos_src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 7
    i := j*64
    IF k[j]
        dst[i+63:i] := SIN(a[i+63:i])
        MEM[mem_addr+i+63:mem_addr+i] := COS(a[i+63:i])
    ELSE
        dst[i+63:i] := sin_src[i+63:i]
        MEM[mem_addr+i+63:mem_addr+i] := cos_src[i+63:i]
    FI
ENDFOR
dst[MAX:512] := 0
cos_res[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_sincos_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine and cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, store the sine in "dst", and store the cosine into memory at "mem_addr".

[algorithm]

FOR j := 0 to 15
    i := j*32
    dst[i+31:i] := SIN(a[i+31:i])
    MEM[mem_addr+i+31:mem_addr+i] := COS(a[i+31:i])
ENDFOR
dst[MAX:512] := 0
cos_res[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm512_mask_sincos_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine and cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, store the sine in "dst", store the cosine into memory at "mem_addr". Elements are written to their
respective locations using writemask "k" (elements are copied from "sin_src" or "cos_src" when the
corresponding mask bit is not set).

[algorithm]

FOR j := 0 to 15
    i := j*32
    IF k[j]
        dst[i+31:i] := SIN(a[i+31:i])
        MEM[mem_addr+i+31:mem_addr+i] := COS(a[i+31:i])
    ELSE
        dst[i+31:i] := sin_src[i+31:i]
        MEM[mem_addr+i+31:mem_addr+i] := cos_src[i+31:i]
    FI
ENDFOR
dst[MAX:512] := 0
cos_res[MAX:512] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_acos_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ACOS(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_acos_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ACOS(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_acosh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic cosine of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ACOSH(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_acosh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic cosine of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ACOSH(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_asin_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse sine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ASIN(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_asin_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse sine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ASIN(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_asinh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic sine of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ASINH(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_asinh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic sine of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ASINH(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_atan_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ATAN(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_atan_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ATAN(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_atan2_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed double-precision (64-bit) floating-point elements in "a" divided by
packed elements in "b", and store the results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ATAN2(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_atan2_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse tangent of packed single-precision (32-bit) floating-point elements in "a" divided by
packed elements in "b", and store the results in "dst" expressed in radians.

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ATAN2(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_atanh_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic tangent of packed double-precision (64-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ATANH(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_atanh_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse hyperbolic tangent of packed single-precision (32-bit) floating-point elements in "a"
expressed in radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ATANH(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cbrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the cube root of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := CubeRoot(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cbrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the cube root of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := CubeRoot(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cdfnorm_pd

--------------------------------------------------------------------------------------------------------------
Compute the cumulative distribution function of packed double-precision (64-bit) floating-point elements in
"a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := CDFNormal(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cdfnorm_ps

--------------------------------------------------------------------------------------------------------------
Compute the cumulative distribution function of packed single-precision (32-bit) floating-point elements in
"a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := CDFNormal(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cdfnorminv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cumulative distribution function of packed double-precision (64-bit) floating-point
elements in "a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := InverseCDFNormal(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cdfnorminv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cumulative distribution function of packed single-precision (32-bit) floating-point
elements in "a" using the normal distribution, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := InverseCDFNormal(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cexp_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed complex numbers in "a", and store the
complex results in "dst". Each complex number is composed of two adjacent single-precision (32-bit)
floating-point elements, which defines the complex number "complex = vec.fp32[0] + i * vec.fp32[1]".

[algorithm]

DEFINE CEXP(a[31:0], b[31:0]) {
    result[31:0]  := POW(FP32(e), a[31:0]) * COS(b[31:0])
    result[63:32] := POW(FP32(e), a[31:0]) * SIN(b[31:0])
    RETURN result
}
FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := CEXP(a[i+31:i], a[i+63:i+32])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_clog_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed complex numbers in "a", and store the complex results in "dst". Each
complex number is composed of two adjacent single-precision (32-bit) floating-point elements, which defines the
complex number "complex = vec.fp32[0] + i * vec.fp32[1]".

[algorithm]

DEFINE CLOG(a[31:0], b[31:0]) {
    result[31:0]  := LOG(SQRT(POW(a, 2.0) + POW(b, 2.0)))
    result[63:32] := ATAN2(b, a)
    RETURN result
}
FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := CLOG(a[i+31:i], a[i+63:i+32])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cos_pd

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := COS(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cos_ps

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := COS(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cosd_pd

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := COSD(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cosd_ps

--------------------------------------------------------------------------------------------------------------
Compute the cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := COSD(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cosh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := COSH(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_cosh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := COSH(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_csqrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed complex snumbers in "a", and store the complex results in "dst". Each
complex number is composed of two adjacent single-precision (32-bit) floating-point elements, which defines the
complex number "complex = vec.fp32[0] + i * vec.fp32[1]".

[algorithm]

DEFINE CSQRT(a[31:0], b[31:0]) {
    sign[31:0] := (b &lt; 0.0) ? -FP32(1.0) : FP32(1.0)
    result[31:0]  := SQRT((a + SQRT(POW(a, 2.0) + POW(b, 2.0))) / 2.0)
    result[63:32] := sign * SQRT((-a + SQRT(POW(a, 2.0) + POW(b, 2.0))) / 2.0)
    RETURN result
}
FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := CSQRT(a[i+31:i], a[i+63:i+32])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_div_epi8

--------------------------------------------------------------------------------------------------------------
Divide packed signed 8-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := 8*j
    IF b[i+7:i] == 0
        #DE
    FI
    dst[i+7:i] := Truncate8(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_div_epi16

--------------------------------------------------------------------------------------------------------------
Divide packed signed 16-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := 16*j
    IF b[i+15:i] == 0
        #DE
    FI
    dst[i+15:i] := Truncate16(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_div_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", and store the truncated results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    IF b[i+31:i] == 0
        #DE
    FI
    dst[i+31:i] := Truncate32(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_div_epi64

--------------------------------------------------------------------------------------------------------------
Divide packed signed 64-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    IF b[i+63:i] == 0
        #DE
    FI
    dst[i+63:i] := Truncate64(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_div_epu8

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 8-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 15
    i := 8*j
    IF b[i+7:i] == 0
        #DE
    FI
    dst[i+7:i] := Truncate8(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_div_epu16

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 16-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := 16*j
    IF b[i+15:i] == 0
        #DE
    FI
    dst[i+15:i] := Truncate16(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_div_epu32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    IF b[i+31:i] == 0
        #DE
    FI
    dst[i+31:i] := Truncate32(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_div_epu64

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 64-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    IF b[i+63:i] == 0
        #DE
    FI
    dst[i+63:i] := Truncate64(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_erf_pd

--------------------------------------------------------------------------------------------------------------
Compute the error function of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ERF(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_erf_ps

--------------------------------------------------------------------------------------------------------------
Compute the error function of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ERF(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_erfc_pd

--------------------------------------------------------------------------------------------------------------
Compute the complementary error function of packed double-precision (64-bit) floating-point elements in "a",
and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := 1.0 - ERF(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_erfc_ps

--------------------------------------------------------------------------------------------------------------
Compute the complementary error function of packed single-precision (32-bit) floating-point elements in "a",
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+63:i] := 1.0 - ERF(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_erfcinv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse complementary error function of packed double-precision (64-bit) floating-point elements
in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := 1.0 / (1.0 - ERF(a[i+63:i]))
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_erfcinv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse complementary error function of packed single-precision (32-bit) floating-point elements
in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+63:i] := 1.0 / (1.0 - ERF(a[i+31:i]))
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_erfinv_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse error function of packed double-precision (64-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := 1.0 / ERF(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_erfinv_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse error function of packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+63:i] := 1.0 / ERF(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_exp_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := POW(e, a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_exp_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := POW(FP32(e), a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_exp10_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 10 raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := POW(10.0, a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_exp10_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 10 raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := POW(FP32(10.0), a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_exp2_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 2 raised to the power of packed double-precision (64-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := POW(2.0, a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_exp2_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of 2 raised to the power of packed single-precision (32-bit) floating-point
elements in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := POW(FP32(2.0), a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_expm1_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed double-precision (64-bit) floating-point
elements in "a", subtract one from each element, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := POW(e, a[i+63:i]) - 1.0
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_expm1_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of "e" raised to the power of packed single-precision (32-bit) floating-point
elements in "a", subtract one from each element, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := POW(FP32(e), a[i+31:i]) - 1.0
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_hypot_pd

--------------------------------------------------------------------------------------------------------------
Compute the length of the hypotenous of a right triangle, with the lengths of the other two sides of the
triangle stored as packed double-precision (64-bit) floating-point elements in "a" and "b", and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := SQRT(POW(a[i+63:i], 2.0) + POW(b[i+63:i], 2.0))
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_hypot_ps

--------------------------------------------------------------------------------------------------------------
Compute the length of the hypotenous of a right triangle, with the lengths of the other two sides of the
triangle stored as packed single-precision (32-bit) floating-point elements in "a" and "b", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := SQRT(POW(a[i+31:i], 2.0) + POW(b[i+31:i], 2.0))
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_idiv_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", and store the truncated results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := TRUNCATE(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_idivrem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", store the truncated results in "dst", and
store the remainders as packed 32-bit integers into memory at "mem_addr".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := TRUNCATE(a[i+31:i] / b[i+31:i])
    MEM[mem_addr+i+31:mem_addr+i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_invcbrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse cube root of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := InvCubeRoot(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_invcbrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse cube root of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := InvCubeRoot(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_invsqrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the inverse square root of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := InvSQRT(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_invsqrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the inverse square root of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := InvSQRT(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_irem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_log_pd

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := LOG(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_log_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_log10_pd

--------------------------------------------------------------------------------------------------------------
Compute the base-10 logarithm of packed double-precision (64-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := LOG(a[i+63:i]) / LOG(10.0)
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_log10_ps

--------------------------------------------------------------------------------------------------------------
Compute the base-10 logarithm of packed single-precision (32-bit) floating-point elements in "a", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i]) / LOG(10.0)
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_log1p_pd

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of one plus packed double-precision (64-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := LOG(1.0 + a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_log1p_ps

--------------------------------------------------------------------------------------------------------------
Compute the natural logarithm of one plus packed single-precision (32-bit) floating-point elements in "a", and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := LOG(1.0 + a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_log2_pd

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := LOG(a[i+63:i]) / LOG(2.0)
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_log2_ps

--------------------------------------------------------------------------------------------------------------
Compute the base-2 logarithm of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := LOG(a[i+31:i]) / LOG(2.0)
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_logb_pd

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed double-precision (64-bit) floating-point element in "a" to a
double-precision floating-point number representing the integer exponent, and store the results in "dst". This
intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ConvertExpFP64(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_logb_ps

--------------------------------------------------------------------------------------------------------------
Convert the exponent of each packed single-precision (32-bit) floating-point element in "a" to a
single-precision floating-point number representing the integer exponent, and store the results in "dst". This
intrinsic essentially calculates "floor(log2(x))" for each element.

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ConvertExpFP32(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_pow_pd

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of packed double-precision (64-bit) floating-point elements in "a" raised by
packed elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := POW(a[i+63:i], b[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_pow_ps

--------------------------------------------------------------------------------------------------------------
Compute the exponential value of packed single-precision (32-bit) floating-point elements in "a" raised by
packed elements in "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := POW(a[i+31:i], b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_rem_epi8

--------------------------------------------------------------------------------------------------------------
Divide packed 8-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := 8*j
    dst[i+7:i] := REMAINDER(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_rem_epi16

--------------------------------------------------------------------------------------------------------------
Divide packed 16-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := 16*j
    dst[i+15:i] := REMAINDER(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_rem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed 32-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_rem_epi64

--------------------------------------------------------------------------------------------------------------
Divide packed 64-bit integers in "a" by packed elements in "b", and store the remainders as packed 32-bit
integers in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    dst[i+63:i] := REMAINDER(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_rem_epu8

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 8-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 15
    i := 8*j
    dst[i+7:i] := REMAINDER(a[i+7:i] / b[i+7:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_rem_epu16

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 16-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := 16*j
    dst[i+15:i] := REMAINDER(a[i+15:i] / b[i+15:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_rem_epu32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_rem_epu64

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 64-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    dst[i+63:i] := REMAINDER(a[i+63:i] / b[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_sin_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed double-precision (64-bit) floating-point elements in "a" expressed in radians, and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := SIN(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_sin_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed single-precision (32-bit) floating-point elements in "a" expressed in radians, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := SIN(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_sincos_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine and cosine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, store the sine in "dst", and store the cosine into memory at "mem_addr".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := SIN(a[i+63:i])
    MEM[mem_addr+i+63:mem_addr+i] := COS(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_sincos_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine and cosine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, store the sine in "dst", and store the cosine into memory at "mem_addr".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := SIN(a[i+31:i])
    MEM[mem_addr+i+31:mem_addr+i] := COS(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_sind_pd

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees, and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := SIND(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_sind_ps

--------------------------------------------------------------------------------------------------------------
Compute the sine of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees, and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := SIND(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_sinh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic sine of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := SINH(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_sinh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic sine of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := SINH(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_svml_ceil_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" up to an integer value, and store
the results as packed double-precision floating-point elements in "dst". This intrinsic may generate the
"roundpd"/"vroundpd" instruction.

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := CEIL(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_svml_ceil_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" up to an integer value, and store
the results as packed single-precision floating-point elements in "dst". This intrinsic may generate the
"roundps"/"vroundps" instruction.

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := CEIL(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_svml_floor_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" down to an integer value, and store
the results as packed double-precision floating-point elements in "dst". This intrinsic may generate the
"roundpd"/"vroundpd" instruction.

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := FLOOR(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_svml_floor_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" down to an integer value, and store
the results as packed single-precision floating-point elements in "dst". This intrinsic may generate the
"roundps"/"vroundps" instruction.

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := FLOOR(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_svml_round_pd

--------------------------------------------------------------------------------------------------------------
Round the packed double-precision (64-bit) floating-point elements in "a" to the nearest integer value, and
store the results as packed double-precision floating-point elements in "dst". This intrinsic may generate the
"roundpd"/"vroundpd" instruction.

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ROUND(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_svml_round_ps

--------------------------------------------------------------------------------------------------------------
Round the packed single-precision (32-bit) floating-point elements in "a" to the nearest integer value, and
store the results as packed single-precision floating-point elements in "dst". This intrinsic may generate the
"roundps"/"vroundps" instruction.

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ROUND(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_svml_sqrt_pd

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed double-precision (64-bit) floating-point elements in "a", and store the
results in "dst". Note that this intrinsic is less efficient than "_mm_sqrt_pd".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := SQRT(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_svml_sqrt_ps

--------------------------------------------------------------------------------------------------------------
Compute the square root of packed single-precision (32-bit) floating-point elements in "a", and store the
results in "dst". Note that this intrinsic is less efficient than "_mm_sqrt_ps".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := SQRT(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_tan_pd

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := TAN(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_tan_ps

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in radians,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := TAN(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_tand_pd

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := TAND(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_tand_ps

--------------------------------------------------------------------------------------------------------------
Compute the tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in degrees,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := TAND(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_tanh_pd

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic tangent of packed double-precision (64-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := TANH(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_tanh_ps

--------------------------------------------------------------------------------------------------------------
Compute the hyperbolic tangent of packed single-precision (32-bit) floating-point elements in "a" expressed in
radians, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := TANH(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_trunc_pd

--------------------------------------------------------------------------------------------------------------
Truncate the packed double-precision (64-bit) floating-point elements in "a", and store the results as packed
double-precision floating-point elements in "dst". This intrinsic may generate the "roundpd"/"vroundpd"
instruction.

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := TRUNCATE(a[i+63:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_trunc_ps

--------------------------------------------------------------------------------------------------------------
Truncate the packed single-precision (32-bit) floating-point elements in "a", and store the results as packed
single-precision floating-point elements in "dst". This intrinsic may generate the "roundps"/"vroundps"
instruction.

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := TRUNCATE(a[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_udiv_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the truncated results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := TRUNCATE(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_udivrem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", store the truncated results in "dst",
and store the remainders as packed unsigned 32-bit integers into memory at "mem_addr".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := TRUNCATE(a[i+31:i] / b[i+31:i])
    MEM[mem_addr+i+31:mem_addr+i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------

## _mm_urem_epi32

--------------------------------------------------------------------------------------------------------------
Divide packed unsigned 32-bit integers in "a" by packed elements in "b", and store the remainders as packed
unsigned 32-bit integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    dst[i+31:i] := REMAINDER(a[i+31:i] / b[i+31:i])
ENDFOR
dst[MAX:128] := 0

--------------------------------------------------------------------------------------------------------------
