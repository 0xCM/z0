# T

## TZCNT - _tzcnt_u32

| TZCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of trailing zero bits in unsigned 32-bit integer "a", and return that count in "dst".

[algorithm]

tmp := 0
dst := 0
DO WHILE ((tmp &lt; 32) AND a[tmp] == 0)
    tmp := tmp + 1
    dst := dst + 1
OD

--------------------------------------------------------------------------------------------------------------

## TZCNT - _tzcnt_u64

| TZCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of trailing zero bits in unsigned 64-bit integer "a", and return that count in "dst".

[algorithm]

tmp := 0
dst := 0
DO WHILE ((tmp &lt; 64) AND a[tmp] == 0)
    tmp := tmp + 1
    dst := dst + 1
OD

--------------------------------------------------------------------------------------------------------------

## TZCNT - _mm_tzcnt_32

| TZCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of trailing zero bits in unsigned 32-bit integer "a", and return that count in "dst".

[algorithm]

tmp := 0
dst := 0
DO WHILE ((tmp &lt; 32) AND a[tmp] == 0)
    tmp := tmp + 1
    dst := dst + 1
OD

--------------------------------------------------------------------------------------------------------------

## TZCNT - _mm_tzcnt_64

| TZCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of trailing zero bits in unsigned 64-bit integer "a", and return that count in "dst".

[algorithm]

tmp := 0
dst := 0
DO WHILE ((tmp &lt; 64) AND a[tmp] == 0)
    tmp := tmp + 1
    dst := dst + 1
OD

--------------------------------------------------------------------------------------------------------------

## TZCNTI - _mm_tzcnti_32

| 

--------------------------------------------------------------------------------------------------------------
Count the number of trailing zero bits in unsigned 32-bit integer "x" starting at bit "a", and return that
count in "dst".

[algorithm]

tmp := a
IF tmp &lt; 0
    tmp := 0
FI
dst := 0
IF tmp &gt; 31
    dst := 32
ELSE
    DO WHILE ((tmp &lt; 32) AND x[tmp] == 0)
        tmp := tmp + 1
        dst := dst + 1
    OD
FI

--------------------------------------------------------------------------------------------------------------

## TZCNTI - _mm_tzcnti_64

| 

--------------------------------------------------------------------------------------------------------------
Count the number of trailing zero bits in unsigned 64-bit integer "x" starting at bit "a", and return that
count in "dst".

[algorithm]

tmp := a
IF tmp &lt; 0
    tmp := 0
FI
dst := 0
IF tmp &gt; 63
    dst := 64
ELSE
    DO WHILE ((tmp &lt; 64) AND x[tmp] == 0)
        tmp := tmp + 1
        dst := dst + 1
    OD
FI

--------------------------------------------------------------------------------------------------------------

## TPAUSE - _tpause

| TPAUSE_GPR32u32

--------------------------------------------------------------------------------------------------------------
Directs the processor to enter an implementation-dependent optimized state until the TSC reaches or exceeds
the value specified in "counter". Bit 0 of "ctrl" selects between a lower power (cleared) or faster wakeup
(set) optimized state. Returns the carry flag (CF).

[missing]

--------------------------------------------------------------------------------------------------------------
