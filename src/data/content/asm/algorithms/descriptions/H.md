# H

## HADDPD - _mm_hadd_pd

| HADDPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of double-precision (64-bit) floating-point elements in "a" and "b", and pack
the results in "dst".

[algorithm]

dst[63:0] := a[127:64] + a[63:0]
dst[127:64] := b[127:64] + b[63:0]

--------------------------------------------------------------------------------------------------------------

## HADDPS - _mm_hadd_ps

| HADDPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of single-precision (32-bit) floating-point elements in "a" and "b", and pack
the results in "dst".

[algorithm]

dst[31:0] := a[63:32] + a[31:0]
dst[63:32] := a[127:96] + a[95:64]
dst[95:64] := b[63:32] + b[31:0]
dst[127:96] := b[127:96] + b[95:64]

--------------------------------------------------------------------------------------------------------------

## HSUBPD - _mm_hsub_pd

| HSUBPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of double-precision (64-bit) floating-point elements in "a" and "b", and
pack the results in "dst".

[algorithm]

dst[63:0] := a[63:0] - a[127:64]
dst[127:64] := b[63:0] - b[127:64]

--------------------------------------------------------------------------------------------------------------

## HSUBPS - _mm_hsub_ps

| HSUBPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of single-precision (32-bit) floating-point elements in "a" and "b", and pack
the results in "dst".

[algorithm]

dst[31:0] := a[31:0] - a[63:32]
dst[63:32] := a[95:64] - a[127:96]
dst[95:64] := b[31:0] - b[63:32]
dst[127:96] := b[95:64] - b[127:96]

--------------------------------------------------------------------------------------------------------------
