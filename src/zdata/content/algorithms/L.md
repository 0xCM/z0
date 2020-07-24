# L

## LZCNT - _lzcnt_u32

| LZCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of leading zero bits in unsigned 32-bit integer "a", and return that count in "dst".

[algorithm]

tmp := 31
dst := 0
DO WHILE (tmp &gt;= 0 AND a[tmp] == 0)
    tmp := tmp - 1
    dst := dst + 1
OD

--------------------------------------------------------------------------------------------------------------

## LZCNT - _lzcnt_u64

| LZCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of leading zero bits in unsigned 64-bit integer "a", and return that count in "dst".

[algorithm]

tmp := 63
dst := 0
DO WHILE (tmp &gt;= 0 AND a[tmp] == 0)
    tmp := tmp - 1
    dst := dst + 1
OD

--------------------------------------------------------------------------------------------------------------

## LDMXCSR - _mm_setcsr

| LDMXCSR_MEMd

--------------------------------------------------------------------------------------------------------------
Set the MXCSR control and status register with the value in unsigned 32-bit integer "a".

[algorithm]

MXCSR := a[31:0]

--------------------------------------------------------------------------------------------------------------

## LFENCE - _mm_lfence

| LFENCE

--------------------------------------------------------------------------------------------------------------
Perform a serializing operation on all load-from-memory instructions that were issued prior to this
instruction. Guarantees that every load instruction that precedes, in program order, is globally visible before
any load instruction which follows the fence in program order.

[missing]

--------------------------------------------------------------------------------------------------------------

## LDDQU - _mm_lddqu_si128

| LDDQU_XMMpd_MEMdq

--------------------------------------------------------------------------------------------------------------
Load 128-bits of integer data from unaligned memory into "dst". This intrinsic may perform better than
"_mm_loadu_si128" when the data crosses a cache line boundary.

[algorithm]

dst[127:0] := MEM[mem_addr+127:mem_addr]

--------------------------------------------------------------------------------------------------------------
