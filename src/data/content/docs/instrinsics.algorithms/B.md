# B

## BEXTR - _bextr_u32

| BEXTR_VGPR32d_VGPR32d_VGPR32d

--------------------------------------------------------------------------------------------------------------
Extract contiguous bits from unsigned 32-bit integer "a", and store the result in "dst". Extract the number of
bits specified by "len", starting at the bit specified by "start".

[algorithm]

tmp[511:0] := a
dst[31:0] := ZeroExtend32(tmp[(start[7:0] + len[7:0] - 1):start[7:0]])

--------------------------------------------------------------------------------------------------------------

## BEXTR - _bextr2_u32

| BEXTR_VGPR32d_VGPR32d_VGPR32d

--------------------------------------------------------------------------------------------------------------
Extract contiguous bits from unsigned 32-bit integer "a", and store the result in "dst". Extract the number of
bits specified by bits 15:8 of "control", starting at the bit specified by bits 0:7 of "control".

[algorithm]

start := control[7:0]
len := control[15:8]
tmp[511:0] := a
dst[31:0] := ZeroExtend32(tmp[(start[7:0] + len[7:0] - 1):start[7:0]])

--------------------------------------------------------------------------------------------------------------

## BEXTR - _bextr_u64

| BEXTR_VGPR64q_VGPR64q_VGPR64q

--------------------------------------------------------------------------------------------------------------
Extract contiguous bits from unsigned 64-bit integer "a", and store the result in "dst". Extract the number of
bits specified by "len", starting at the bit specified by "start".

[algorithm]

tmp[511:0] := a
dst[63:0] := ZeroExtend64(tmp[(start[7:0] + len[7:0] - 1):start[7:0]])

--------------------------------------------------------------------------------------------------------------

## BEXTR - _bextr2_u64

| BEXTR_VGPR64q_VGPR64q_VGPR64q

--------------------------------------------------------------------------------------------------------------
Extract contiguous bits from unsigned 64-bit integer "a", and store the result in "dst". Extract the number of
bits specified by bits 15:8 of "control", starting at the bit specified by bits 0:7 of "control"..

[algorithm]

start := control[7:0]
len := control[15:8]
tmp[511:0] := a
dst[63:0] := ZeroExtend64(tmp[(start[7:0] + len[7:0] - 1):start[7:0]])

--------------------------------------------------------------------------------------------------------------

## BLSI - _blsi_u32

| BLSI_VGPR32d_VGPR32d

--------------------------------------------------------------------------------------------------------------
Extract the lowest set bit from unsigned 32-bit integer "a" and set the corresponding bit in "dst". All other
bits in "dst" are zeroed, and all bits are zeroed if no bits are set in "a".

[algorithm]

dst := (-a) AND a

--------------------------------------------------------------------------------------------------------------

## BLSI - _blsi_u64

| BLSI_VGPR64q_VGPR64q

--------------------------------------------------------------------------------------------------------------
Extract the lowest set bit from unsigned 64-bit integer "a" and set the corresponding bit in "dst". All other
bits in "dst" are zeroed, and all bits are zeroed if no bits are set in "a".

[algorithm]

dst := (-a) AND a

--------------------------------------------------------------------------------------------------------------

## BLSMSK - _blsmsk_u32

| BLSMSK_VGPR32d_VGPR32d

--------------------------------------------------------------------------------------------------------------
Set all the lower bits of "dst" up to and including the lowest set bit in unsigned 32-bit integer "a".

[algorithm]

dst := (a - 1) XOR a

--------------------------------------------------------------------------------------------------------------

## BLSMSK - _blsmsk_u64

| BLSMSK_VGPR64q_VGPR64q

--------------------------------------------------------------------------------------------------------------
Set all the lower bits of "dst" up to and including the lowest set bit in unsigned 64-bit integer "a".

[algorithm]

dst := (a - 1) XOR a

--------------------------------------------------------------------------------------------------------------

## BLSR - _blsr_u32

| BLSR_VGPR32d_VGPR32d

--------------------------------------------------------------------------------------------------------------
Copy all bits from unsigned 32-bit integer "a" to "dst", and reset (set to 0) the bit in "dst" that
corresponds to the lowest set bit in "a".

[algorithm]

dst := (a - 1) AND a

--------------------------------------------------------------------------------------------------------------

## BLSR - _blsr_u64

| BLSR_VGPR64q_VGPR64q

--------------------------------------------------------------------------------------------------------------
Copy all bits from unsigned 64-bit integer "a" to "dst", and reset (set to 0) the bit in "dst" that
corresponds to the lowest set bit in "a".

[algorithm]

dst := (a - 1) AND a

--------------------------------------------------------------------------------------------------------------

## BZHI - _bzhi_u32

| BZHI_VGPR32d_VGPR32d_VGPR32d

--------------------------------------------------------------------------------------------------------------
Copy all bits from unsigned 32-bit integer "a" to "dst", and reset (set to 0) the high bits in "dst" starting
at "index".

[algorithm]

n := index[7:0]
dst := a
IF (n &lt; 32)
    dst[31:n] := 0
FI

--------------------------------------------------------------------------------------------------------------

## BZHI - _bzhi_u64

| BZHI_VGPR64q_VGPR64q_VGPR64q

--------------------------------------------------------------------------------------------------------------
Copy all bits from unsigned 64-bit integer "a" to "dst", and reset (set to 0) the high bits in "dst" starting
at "index".

[algorithm]

n := index[7:0]
dst := a
IF (n &lt; 64)
    dst[63:n] := 0
FI

--------------------------------------------------------------------------------------------------------------

## BNDMK - _bnd_set_ptr_bounds

| BNDMK_BND_AGEN

--------------------------------------------------------------------------------------------------------------
Make a pointer with the value of "srcmem" and bounds set to ["srcmem", "srcmem" + "size" - 1], and store the
result in "dst".

[algorithm]

dst := srcmem
dst.LB := srcmem.LB
dst.UB := srcmem + size - 1

--------------------------------------------------------------------------------------------------------------

## BNDSTX - _bnd_store_ptr_bounds

| BNDSTX_MEMbnd64_BND

--------------------------------------------------------------------------------------------------------------
Stores the bounds of "ptr_val" pointer in memory at address "ptr_addr".

[algorithm]

MEM[ptr_addr].LB := ptr_val.LB
MEM[ptr_addr].UB := ptr_val.UB

--------------------------------------------------------------------------------------------------------------

## BNDCL - _bnd_chk_ptr_lbounds

| BNDCL_BND_AGEN

--------------------------------------------------------------------------------------------------------------
Checks if "q" is within its lower bound, and throws a #BR if not.

[algorithm]

IF q &lt; q.LB
    #BR
FI

--------------------------------------------------------------------------------------------------------------

## BNDCU - _bnd_chk_ptr_ubounds

| BNDCU_BND_AGEN | BNDCN_BND_AGEN

--------------------------------------------------------------------------------------------------------------
Checks if "q" is within its upper bound, and throws a #BR if not.

[algorithm]

IF q &gt; q.UB
    #BR
FI

--------------------------------------------------------------------------------------------------------------

## BNDCU - _bnd_chk_ptr_bounds

| BNDCU_BND_AGEN | BNDCN_BND_AGEN

--------------------------------------------------------------------------------------------------------------
Checks if ["q", "q" + "size" - 1] is within the lower and upper bounds of "q" and throws a #BR if not.

[algorithm]

IF (q + size - 1) &lt; q.LB OR (q + size - 1) &gt; q.UB
    #BR
FI

--------------------------------------------------------------------------------------------------------------

## BSF - _bit_scan_forward

| BSF_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Set "dst" to the index of the lowest set bit in 32-bit integer "a". If no bits are set in "a" then "dst" is
undefined.

[algorithm]

tmp := 0
IF a == 0
    // dst is undefined
ELSE
    DO WHILE ((tmp &lt; 32) AND a[tmp] == 0)
        tmp := tmp + 1
    OD
FI
dst := tmp

--------------------------------------------------------------------------------------------------------------

## BSR - _bit_scan_reverse

| BSR_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Set "dst" to the index of the highest set bit in 32-bit integer "a". If no bits are set in "a" then "dst" is
undefined.

[algorithm]

tmp := 31
IF a == 0
    // dst is undefined
ELSE
    DO WHILE ((tmp &gt; 0) AND a[tmp] == 0)
        tmp := tmp - 1
    OD
FI
dst := tmp

--------------------------------------------------------------------------------------------------------------

## BSF - _BitScanForward

| BSF_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Set "index" to the index of the lowest set bit in 32-bit integer "mask". If no bits are set in "a", then
"index" is undefined and "dst" is set to 0, otherwise "dst" is set to 1.

[algorithm]

tmp := 0
IF a == 0
    // MEM[index+31:index] is undefined
    dst := 0
ELSE
    DO WHILE ((tmp &lt; 32) AND a[tmp] == 0)
        tmp := tmp + 1
    OD
    MEM[index+31:index] := tmp
    dst := (tmp == 31) ? 0 : 1
FI

--------------------------------------------------------------------------------------------------------------

## BSR - _BitScanReverse

| BSR_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Set "index" to the index of the highest set bit in 32-bit integer "mask". If no bits are set in "a", then
"index" is undefined and "dst" is set to 0, otherwise "dst" is set to 1.

[algorithm]

tmp := 31
IF a == 0
    // MEM[index+31:index] is undefined
    dst := 0
ELSE
    DO WHILE ((tmp &gt; 0) AND a[tmp] == 0)
        tmp := tmp - 1
    OD
    MEM[index+31:index] := tmp
    dst := (tmp == 0) ? 0 : 1
FI

--------------------------------------------------------------------------------------------------------------

## BSF - _BitScanForward64

| BSF_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Set "index" to the index of the lowest set bit in 32-bit integer "mask". If no bits are set in "a", then
"index" is undefined and "dst" is set to 0, otherwise "dst" is set to 1.

[algorithm]

tmp := 0
IF a == 0
    // MEM[index+31:index] is undefined
    dst := 0
ELSE
    DO WHILE ((tmp &lt; 64) AND a[tmp] == 0)
        tmp := tmp + 1
    OD
    MEM[index+31:index] := tmp
    dst := (tmp == 63) ? 0 : 1
FI

--------------------------------------------------------------------------------------------------------------

## BSR - _BitScanReverse64

| BSR_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Set "index" to the index of the highest set bit in 32-bit integer "mask". If no bits are set in "a", then
"index" is undefined and "dst" is set to 0, otherwise "dst" is set to 1.

[algorithm]

tmp := 63
IF a == 0
    // MEM[index+31:index] is undefined
    dst := 0
ELSE
    DO WHILE ((tmp &gt; 0) AND a[tmp] == 0)
        tmp := tmp - 1
    OD
    MEM[index+31:index] := tmp
    dst := (tmp == 0) ? 0 : 1
FI

--------------------------------------------------------------------------------------------------------------

## BT - _bittest

| BT_MEMv_GPRv

--------------------------------------------------------------------------------------------------------------
Return the bit at index "b" of 32-bit integer "a".

[algorithm]

addr := a + ZeroExtend64(b)
dst[0] := MEM[addr]

--------------------------------------------------------------------------------------------------------------

## BTC - _bittestandcomplement

| BTC_MEMv_GPRv

--------------------------------------------------------------------------------------------------------------
Return the bit at index "b" of 32-bit integer "a", and set that bit to its complement.

[algorithm]

addr := a + ZeroExtend64(b)
dst[0] := MEM[addr]
MEM[addr] := ~dst[0]

--------------------------------------------------------------------------------------------------------------

## BTR - _bittestandreset

| BTR_MEMv_GPRv

--------------------------------------------------------------------------------------------------------------
Return the bit at index "b" of 32-bit integer "a", and set that bit to zero.

[algorithm]

addr := a + ZeroExtend64(b)
dst[0] := MEM[addr]
MEM[addr] := 0

--------------------------------------------------------------------------------------------------------------

## BTS - _bittestandset

| BTS_MEMv_GPRv

--------------------------------------------------------------------------------------------------------------
Return the bit at index "b" of 32-bit integer "a", and set that bit to one.

[algorithm]

addr := a + ZeroExtend64(b)
dst[0] := MEM[addr]
MEM[addr] := 1

--------------------------------------------------------------------------------------------------------------

## BT - _bittest64

| BT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Return the bit at index "b" of 64-bit integer "a".

[algorithm]

addr := a + b
dst[0] := MEM[addr]

--------------------------------------------------------------------------------------------------------------

## BTC - _bittestandcomplement64

| BTC_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Return the bit at index "b" of 64-bit integer "a", and set that bit to its complement.

[algorithm]

addr := a + b
dst[0] := MEM[addr]
MEM[addr] := ~dst[0]

--------------------------------------------------------------------------------------------------------------

## BTR - _bittestandreset64

| BTR_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Return the bit at index "b" of 64-bit integer "a", and set that bit to zero.

[algorithm]

addr := a + b
dst[0] := MEM[addr]
MEM[addr] := 0

--------------------------------------------------------------------------------------------------------------

## BTS - _bittestandset64

| BTS_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Return the bit at index "b" of 64-bit integer "a", and set that bit to one.

[algorithm]

addr := a + b
dst[0] := MEM[addr]
MEM[addr] := 1

--------------------------------------------------------------------------------------------------------------

## BSWAP - _bswap

| BSWAP_GPRv

--------------------------------------------------------------------------------------------------------------
Reverse the byte order of 32-bit integer "a", and store the result in "dst". This intrinsic is provided for
conversion between little and big endian values.

[algorithm]

dst[7:0] := a[31:24]
dst[15:8] := a[23:16]
dst[23:16] := a[15:8]
dst[31:24] := a[7:0]

--------------------------------------------------------------------------------------------------------------

## BSWAP - _bswap64

| BSWAP_GPRv

--------------------------------------------------------------------------------------------------------------
Reverse the byte order of 64-bit integer "a", and store the result in "dst". This intrinsic is provided for
conversion between little and big endian values.

[algorithm]

dst[7:0] := a[63:56]
dst[15:8] := a[55:48]
dst[23:16] := a[47:40]
dst[31:24] := a[39:32]
dst[39:32] := a[31:24]
dst[47:40] := a[23:16]
dst[55:48] := a[15:8]
dst[63:56] := a[7:0]

--------------------------------------------------------------------------------------------------------------

## BLENDPD - _mm_blend_pd

| BLENDPD_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Blend packed double-precision (64-bit) floating-point elements from "a" and "b" using control mask "imm8", and
store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF imm8[j]
        dst[i+63:i] := b[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## BLENDPS - _mm_blend_ps

| BLENDPS_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Blend packed single-precision (32-bit) floating-point elements from "a" and "b" using control mask "imm8", and
store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF imm8[j]
        dst[i+31:i] := b[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## BLENDVPD - _mm_blendv_pd

| BLENDVPD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Blend packed double-precision (64-bit) floating-point elements from "a" and "b" using "mask", and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF mask[i+63]
        dst[i+63:i] := b[i+63:i]
    ELSE
        dst[i+63:i] := a[i+63:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## BLENDVPS - _mm_blendv_ps

| BLENDVPS_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Blend packed single-precision (32-bit) floating-point elements from "a" and "b" using "mask", and store the
results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF mask[i+31]
        dst[i+31:i] := b[i+31:i]
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------
