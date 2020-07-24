# O

## ORPS - _mm_or_ps

| ORPS_XMMxud_XMMxud

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of packed single-precision (32-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[i+31:i] OR b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## ORPD - _mm_or_pd

| ORPD_XMMxuq_XMMxuq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of packed double-precision (64-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[i+63:i] OR b[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------
