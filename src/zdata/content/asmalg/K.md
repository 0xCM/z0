# K

## KANDN - _mm512_kandn

| 

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 16-bit masks "a" and then AND with "b", and store the result in "k".

[algorithm]

k[15:0] := (NOT a[15:0]) AND b[15:0]
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## KAND - _mm512_kand

| 

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 16-bit masks "a" and "b", and store the result in "k".

[algorithm]

k[15:0] := a[15:0] AND b[15:0]
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## KMOV - _mm512_kmov

| 

--------------------------------------------------------------------------------------------------------------
Copy 16-bit mask "a" to "k".

[algorithm]

k[15:0] := a[15:0]
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## KNOT - _mm512_knot

| 

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 16-bit mask "a", and store the result in "k".

[algorithm]

k[15:0] := NOT a[15:0]
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## KOR - _mm512_kor

| 

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of 16-bit masks "a" and "b", and store the result in "k".

[algorithm]

k[15:0] := a[15:0] OR b[15:0]
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## KXNOR - _mm512_kxnor

| 

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XNOR of 16-bit masks "a" and "b", and store the result in "k".

[algorithm]

k[15:0] := NOT (a[15:0] XOR b[15:0])
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## KXOR - _mm512_kxor

| 

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of 16-bit masks "a" and "b", and store the result in "k".

[algorithm]

k[15:0] := a[15:0] XOR b[15:0]
k[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## KMERGE2L1L - _mm512_kmovlhb

| 

--------------------------------------------------------------------------------------------------------------
Inserts the low byte of mask "k2" into the high byte of "dst", and copies the low byte of "k1" to the low byte
of "dst".

[algorithm]

dst[7:0] := k1[7:0]
dst[15:8] := k2[7:0]

--------------------------------------------------------------------------------------------------------------

## KANDNR - _mm512_kandnr

| 

--------------------------------------------------------------------------------------------------------------
Performs a bitwise AND operation between NOT of "k2" and "k1", storing the result in "dst".

[algorithm]

dst[15:0] := NOT(k2[15:0]) &amp; k1[15:0]

--------------------------------------------------------------------------------------------------------------

## KMERGE2L1H - _mm512_kswapb

| 

--------------------------------------------------------------------------------------------------------------
Moves high byte from "k2" to low byte of "k1", and moves low byte of "k2" to high byte of "k1".

[algorithm]

tmp[7:0] := k2[15:8]
k2[15:8] := k1[7:0]
k1[7:0]  := tmp[7:0]
tmp[7:0] := k2[7:0]
k2[7:0]  := k1[15:8]
k1[15:8] := tmp[7:0]

--------------------------------------------------------------------------------------------------------------

## KORTEST - _mm512_kortestz

| 

--------------------------------------------------------------------------------------------------------------
Performs bitwise OR between "k1" and "k2", storing the result in "dst". ZF flag is set if "dst" is 0.

[algorithm]

dst[15:0] := k1[15:0] | k2[15:0]
IF dst == 0
    SetZF()
FI

--------------------------------------------------------------------------------------------------------------

## KORTEST - _mm512_kortestc

| 

--------------------------------------------------------------------------------------------------------------
Performs bitwise OR between "k1" and "k2", storing the result in "dst". CF flag is set if "dst" consists of
all 1's.

[algorithm]

dst[15:0] := k1[15:0] | k2[15:0]
IF PopCount(dst[15:0]) == 16
    SetCF()
FI

--------------------------------------------------------------------------------------------------------------

## KMOV - _mm512_mask2int

| 

--------------------------------------------------------------------------------------------------------------
Converts bit mask "k1" into an integer value, storing the results in "dst".

[algorithm]

dst := ZeroExtend32(k1)

--------------------------------------------------------------------------------------------------------------

## KMOV - _mm512_int2mask

| 

--------------------------------------------------------------------------------------------------------------
Converts integer "mask" into bitmask, storing the result in "dst".

[algorithm]

dst := mask[15:0]

--------------------------------------------------------------------------------------------------------------

## KCONCATH - _mm512_kconcathi_64

| 

--------------------------------------------------------------------------------------------------------------
Packs masks "k1" and "k2" into the high 32 bits of "dst". The rest of "dst" is set to 0.

[algorithm]

dst[63:48] := k1[15:0]
dst[47:32] := k2[15:0]
dst[31:0]  := 0

--------------------------------------------------------------------------------------------------------------

## KCONCATL - _mm512_kconcatlo_64

| 

--------------------------------------------------------------------------------------------------------------
Packs masks "k1" and "k2" into the low 32 bits of "dst". The rest of "dst" is set to 0.

[algorithm]

dst[31:16] := k1[15:0]
dst[15:0]  := k2[15:0]
dst[63:32] := 0

--------------------------------------------------------------------------------------------------------------

## KEXTRACT - _mm512_kextract_64

| 

--------------------------------------------------------------------------------------------------------------
Extracts 16-bit value "b" from 64-bit integer "a", storing the result in "dst".

[algorithm]

CASE b[1:0] OF
0: dst[15:0] := a[63:48]
1: dst[15:0] := a[47:32]
2: dst[15:0] := a[31:16]
3: dst[15:0] := a[15:0]
ESAC
dst[MAX:15] := 0

--------------------------------------------------------------------------------------------------------------

## KMERGE2L1H - _mm512_kmerge2l1h

| 

--------------------------------------------------------------------------------------------------------------
Move the high element from "k1" to the low element of "k1", and insert the low element of "k2" into the high
element of "k1".

[algorithm]

tmp[7:0] := k1[15:8]
k1[15:8] := k2[7:0]
k1[7:0]  := tmp[7:0]

--------------------------------------------------------------------------------------------------------------

## KMERGE2L1L - _mm512_kmerge2l1l

| 

--------------------------------------------------------------------------------------------------------------
Insert the low element of "k2" into the high element of "k1".

[algorithm]

k1[15:8] := k2[7:0]

--------------------------------------------------------------------------------------------------------------