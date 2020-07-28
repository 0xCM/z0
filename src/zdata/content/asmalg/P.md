# P

## PDEP - _pdep_u32

| PDEP_VGPR32d_VGPR32d_VGPR32d

--------------------------------------------------------------------------------------------------------------
Deposit contiguous low bits from unsigned 32-bit integer "a" to "dst" at the corresponding bit locations
specified by "mask"; all other bits in "dst" are set to zero.

[algorithm]

tmp := a
dst := 0
m := 0
k := 0
DO WHILE m &lt; 32
    IF mask[m] == 1
        dst[m] := tmp[k]
        k := k + 1
    FI
    m := m + 1
OD

--------------------------------------------------------------------------------------------------------------

## PDEP - _pdep_u64

| PDEP_VGPR64q_VGPR64q_VGPR64q

--------------------------------------------------------------------------------------------------------------
Deposit contiguous low bits from unsigned 64-bit integer "a" to "dst" at the corresponding bit locations
specified by "mask"; all other bits in "dst" are set to zero.

[algorithm]

tmp := a
dst := 0
m := 0
k := 0
DO WHILE m &lt; 64
    IF mask[m] == 1
        dst[m] := tmp[k]
        k := k + 1
    FI
    m := m + 1
OD

--------------------------------------------------------------------------------------------------------------

## PEXT - _pext_u32

| PEXT_VGPR32d_VGPR32d_VGPR32d

--------------------------------------------------------------------------------------------------------------
Extract bits from unsigned 32-bit integer "a" at the corresponding bit locations specified by "mask" to
contiguous low bits in "dst"; the remaining upper bits in "dst" are set to zero.

[algorithm]

tmp := a
dst := 0
m := 0
k := 0
DO WHILE m &lt; 32
    IF mask[m] == 1
        dst[k] := tmp[m]
        k := k + 1
    FI
    m := m + 1
OD

--------------------------------------------------------------------------------------------------------------

## PEXT - _pext_u64

| PEXT_VGPR64q_VGPR64q_VGPR64q

--------------------------------------------------------------------------------------------------------------
Extract bits from unsigned 64-bit integer "a" at the corresponding bit locations specified by "mask" to
contiguous low bits in "dst"; the remaining upper bits in "dst" are set to zero.

[algorithm]

tmp := a
dst := 0
m := 0
k := 0
DO WHILE m &lt; 64
    IF mask[m] == 1
        dst[k] := tmp[m]
        k := k + 1
    FI
    m := m + 1
OD

--------------------------------------------------------------------------------------------------------------

## POPCNT - _mm_countbits_32

| POPCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Counts the number of set bits in 32-bit unsigned integer "r1", returning the results in "dst".

[algorithm]

dst[31:0] := PopCount(r1[31:0])

--------------------------------------------------------------------------------------------------------------

## POPCNT - _mm_countbits_64

| POPCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Counts the number of set bits in 64-bit unsigned integer "r1", returning the results in "dst".

[algorithm]

dst[63:0] := PopCount(r1[63:0])

--------------------------------------------------------------------------------------------------------------

## PACKSSWB - _m_packsswb

| PACKSSWB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using signed saturation, and
store the results in "dst".

[algorithm]

dst[7:0] := Saturate8(a[15:0])
dst[15:8] := Saturate8(a[31:16])
dst[23:16] := Saturate8(a[47:32])
dst[31:24] := Saturate8(a[63:48])
dst[39:32] := Saturate8(b[15:0])
dst[47:40] := Saturate8(b[31:16])
dst[55:48] := Saturate8(b[47:32])
dst[63:56] := Saturate8(b[63:48])

--------------------------------------------------------------------------------------------------------------

## PACKSSDW - _m_packssdw

| PACKSSDW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using signed saturation, and
store the results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[31:0])
dst[31:16] := Saturate16(a[63:32])
dst[47:32] := Saturate16(b[31:0])
dst[63:48] := Saturate16(b[63:32])

--------------------------------------------------------------------------------------------------------------

## PACKUSWB - _m_packuswb

| PACKUSWB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using unsigned saturation, and
store the results in "dst".

[algorithm]

dst[7:0] := SaturateU8(a[15:0])
dst[15:8] := SaturateU8(a[31:16])
dst[23:16] := SaturateU8(a[47:32])
dst[31:24] := SaturateU8(a[63:48])
dst[39:32] := SaturateU8(b[15:0])
dst[47:40] := SaturateU8(b[31:16])
dst[55:48] := SaturateU8(b[47:32])
dst[63:56] := SaturateU8(b[63:48])

--------------------------------------------------------------------------------------------------------------

## PUNPCKHBW - _m_punpckhbw

| PUNPCKHBW_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 8-bit integers from the high half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_BYTES(src1[63:0], src2[63:0]) {
    dst[7:0] := src1[39:32]
    dst[15:8] := src2[39:32] 
    dst[23:16] := src1[47:40]
    dst[31:24] := src2[47:40]
    dst[39:32] := src1[55:48]
    dst[47:40] := src2[55:48]
    dst[55:48] := src1[63:56]
    dst[63:56] := src2[63:56]
    RETURN dst[63:0]
}
dst[63:0] := INTERLEAVE_HIGH_BYTES(a[63:0], b[63:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKLBW - _m_punpckhwd

| PUNPCKLBW_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 16-bit integers from the high half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_WORDS(src1[63:0], src2[63:0]) {
    dst[15:0] := src1[47:32]
    dst[31:16] := src2[47:32]
    dst[47:32] := src1[63:48]
    dst[63:48] := src2[63:48]
    RETURN dst[63:0]
}
dst[63:0] := INTERLEAVE_HIGH_WORDS(a[63:0], b[63:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKHDQ - _m_punpckhdq

| PUNPCKHDQ_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 32-bit integers from the high half of "a" and "b", and store the results in "dst".

[algorithm]

dst[31:0] := a[63:32]
dst[63:32] := b[63:32]

--------------------------------------------------------------------------------------------------------------

## PUNPCKLBW - _m_punpcklbw

| PUNPCKLBW_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 8-bit integers from the low half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_BYTES(src1[63:0], src2[63:0]) {
    dst[7:0] := src1[7:0] 
    dst[15:8] := src2[7:0] 
    dst[23:16] := src1[15:8] 
    dst[31:24] := src2[15:8] 
    dst[39:32] := src1[23:16] 
    dst[47:40] := src2[23:16] 
    dst[55:48] := src1[31:24] 
    dst[63:56] := src2[31:24] 
    RETURN dst[63:0]    
}
dst[63:0] := INTERLEAVE_BYTES(a[63:0], b[63:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKLWD - _m_punpcklwd

| PUNPCKLWD_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 16-bit integers from the low half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_WORDS(src1[63:0], src2[63:0]) {
    dst[15:0] := src1[15:0] 
    dst[31:16] := src2[15:0] 
    dst[47:32] := src1[31:16] 
    dst[63:48] := src2[31:16] 
    RETURN dst[63:0]    
}
dst[63:0] := INTERLEAVE_WORDS(a[63:0], b[63:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKLDQ - _m_punpckldq

| PUNPCKLDQ_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 32-bit integers from the low half of "a" and "b", and store the results in "dst".

[algorithm]

dst[31:0] := a[31:0]
dst[63:32] := b[31:0]

--------------------------------------------------------------------------------------------------------------

## PADDB - _m_paddb

| PADDB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed 8-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := a[i+7:i] + b[i+7:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDW - _m_paddw

| PADDW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed 16-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := a[i+15:i] + b[i+15:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDD - _m_paddd

| PADDD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed 32-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := a[i+31:i] + b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDSB - _m_paddsb

| PADDSB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed signed 8-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := Saturate8( a[i+7:i] + b[i+7:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDSW - _m_paddsw

| PADDSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed signed 16-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := Saturate16( a[i+15:i] + b[i+15:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDUSB - _m_paddusb

| PADDUSB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed unsigned 8-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := SaturateU8( a[i+7:i] + b[i+7:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDUSW - _m_paddusw

| PADDUSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed unsigned 16-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := SaturateU16( a[i+15:i] + b[i+15:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBB - _m_psubb

| PSUBB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed 8-bit integers in "b" from packed 8-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := a[i+7:i] - b[i+7:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBW - _m_psubw

| PSUBW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed 16-bit integers in "b" from packed 16-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := a[i+15:i] - b[i+15:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBD - _m_psubd

| PSUBD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed 32-bit integers in "b" from packed 32-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := a[i+31:i] - b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBSB - _m_psubsb

| PSUBSB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed signed 8-bit integers in "b" from packed 8-bit integers in "a" using saturation, and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := Saturate8(a[i+7:i] - b[i+7:i])    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBSW - _m_psubsw

| PSUBSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed signed 16-bit integers in "b" from packed 16-bit integers in "a" using saturation, and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := Saturate16(a[i+15:i] - b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBUSB - _m_psubusb

| PSUBUSB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed unsigned 8-bit integers in "b" from packed unsigned 8-bit integers in "a" using saturation,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := SaturateU8(a[i+7:i] - b[i+7:i])    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBUSW - _m_psubusw

| PSUBUSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed unsigned 16-bit integers in "b" from packed unsigned 16-bit integers in "a" using saturation,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := SaturateU16(a[i+15:i] - b[i+15:i])    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMADDWD - _m_pmaddwd

| PMADDWD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers.
Horizontally add adjacent pairs of intermediate 32-bit integers, and pack the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := SignExtend32(a[i+31:i+16]*b[i+31:i+16]) + SignExtend32(a[i+15:i]*b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULHW - _m_pmulhw

| PMULHW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply the packed signed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store
the high 16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    tmp[31:0] := SignExtend32(a[i+15:i]) * SignExtend32(b[i+15:i])
    dst[i+15:i] := tmp[31:16]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULLW - _m_pmullw

| PMULLW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply the packed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store the low
16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    tmp[31:0] := a[i+15:i] * b[i+15:i]
    dst[i+15:i] := tmp[15:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLW - _m_psllw

| PSLLW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &lt;&lt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLW - _m_psllwi

| PSLLW_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLD - _m_pslld

| PSLLD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLD - _m_pslldi

| PSLLD_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLQ - _m_psllq

| PSLLQ_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift 64-bit integer "a" left by "count" while shifting in zeros, and store the result in "dst".

[algorithm]

IF count[63:0] &gt; 63
    dst[63:0] := 0
ELSE
    dst[63:0] := ZeroExtend64(a[63:0] &lt;&lt; count[63:0])
FI

--------------------------------------------------------------------------------------------------------------

## PSLLQ - _m_psllqi

| PSLLQ_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift 64-bit integer "a" left by "imm8" while shifting in zeros, and store the result in "dst".

[algorithm]

IF imm8[7:0] &gt; 63
    dst[63:0] := 0
ELSE
    dst[63:0] := ZeroExtend64(a[63:0] &lt;&lt; imm8[7:0])
FI

--------------------------------------------------------------------------------------------------------------

## PSRAW - _m_psraw

| PSRAW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "count" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := (a[i+15] ? 0xFFFF : 0x0)
    ELSE
        dst[i+15:i] := SignExtend16(a[i+15:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAW - _m_psrawi

| PSRAW_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := (a[i+15] ? 0xFFFF : 0x0)
    ELSE
        dst[i+15:i] := SignExtend16(a[i+15:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAD - _m_psrad

| PSRAD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "count" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
    ELSE
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAD - _m_psradi

| PSRAD_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
    ELSE
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLW - _m_psrlw

| PSRLW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLW - _m_psrlwi

| PSRLW_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLD - _m_psrld

| PSRLD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLD - _m_psrldi

| PSRLD_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLQ - _m_psrlq

| PSRLQ_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift 64-bit integer "a" right by "count" while shifting in zeros, and store the result in "dst".

[algorithm]

IF count[63:0] &gt; 63
    dst[63:0] := 0
ELSE
    dst[63:0] := ZeroExtend64(a[63:0] &gt;&gt; count[63:0])
FI

--------------------------------------------------------------------------------------------------------------

## PSRLQ - _m_psrlqi

| PSRLQ_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift 64-bit integer "a" right by "imm8" while shifting in zeros, and store the result in "dst".

[algorithm]

IF imm8[7:0] &gt; 63
    dst[63:0] := 0
ELSE
    dst[63:0] := ZeroExtend64(a[63:0] &gt;&gt; imm8[7:0])
FI

--------------------------------------------------------------------------------------------------------------

## PAND - _m_pand

| PAND_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 64 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[63:0] := (a[63:0] AND b[63:0])

--------------------------------------------------------------------------------------------------------------

## PANDN - _m_pandn

| PANDN_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 64 bits (representing integer data) in "a" and then AND with "b", and store the
result in "dst".

[algorithm]

dst[63:0] := ((NOT a[63:0]) AND b[63:0])

--------------------------------------------------------------------------------------------------------------

## POR - _m_por

| POR_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of 64 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[63:0] := (a[63:0] OR b[63:0])

--------------------------------------------------------------------------------------------------------------

## PXOR - _m_pxor

| PXOR_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of 64 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[63:0] := (a[63:0] XOR b[63:0])

--------------------------------------------------------------------------------------------------------------

## PCMPEQB - _m_pcmpeqb

| PCMPEQB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed 8-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := ( a[i+7:i] == b[i+7:i] ) ? 0xFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPEQW - _m_pcmpeqw

| PCMPEQW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed 16-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := ( a[i+15:i] == b[i+15:i] ) ? 0xFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPEQD - _m_pcmpeqd

| PCMPEQD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed 32-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := ( a[i+31:i] == b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTB - _m_pcmpgtb

| PCMPGTB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed 8-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := ( a[i+7:i] &gt; b[i+7:i] ) ? 0xFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTW - _m_pcmpgtw

| PCMPGTW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed 16-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := ( a[i+15:i] &gt; b[i+15:i] ) ? 0xFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTD - _m_pcmpgtd

| PCMPGTD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed 32-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := ( a[i+31:i] &gt; b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDB - _mm_add_pi8

| PADDB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed 8-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := a[i+7:i] + b[i+7:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDW - _mm_add_pi16

| PADDW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed 16-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := a[i+15:i] + b[i+15:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDD - _mm_add_pi32

| PADDD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed 32-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := a[i+31:i] + b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDSB - _mm_adds_pi8

| PADDSB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed signed 8-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := Saturate8( a[i+7:i] + b[i+7:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDSW - _mm_adds_pi16

| PADDSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed signed 16-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := Saturate16( a[i+15:i] + b[i+15:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDUSB - _mm_adds_pu8

| PADDUSB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed unsigned 8-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := SaturateU8( a[i+7:i] + b[i+7:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDUSW - _mm_adds_pu16

| PADDUSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add packed unsigned 16-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := SaturateU16( a[i+15:i] + b[i+15:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBB - _mm_sub_pi8

| PSUBB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed 8-bit integers in "b" from packed 8-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := a[i+7:i] - b[i+7:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBW - _mm_sub_pi16

| PSUBW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed 16-bit integers in "b" from packed 16-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := a[i+15:i] - b[i+15:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBD - _mm_sub_pi32

| PSUBD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed 32-bit integers in "b" from packed 32-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := a[i+31:i] - b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBSB - _mm_subs_pi8

| PSUBSB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed signed 8-bit integers in "b" from packed 8-bit integers in "a" using saturation, and store the
results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := Saturate8(a[i+7:i] - b[i+7:i])    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBSW - _mm_subs_pi16

| PSUBSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed signed 16-bit integers in "b" from packed 16-bit integers in "a" using saturation, and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := Saturate16(a[i+15:i] - b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBUSB - _mm_subs_pu8

| PSUBUSB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed unsigned 8-bit integers in "b" from packed unsigned 8-bit integers in "a" using saturation,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := SaturateU8(a[i+7:i] - b[i+7:i])    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBUSW - _mm_subs_pu16

| PSUBUSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract packed unsigned 16-bit integers in "b" from packed unsigned 16-bit integers in "a" using saturation,
and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := SaturateU16(a[i+15:i] - b[i+15:i])    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMADDWD - _mm_madd_pi16

| PMADDWD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers.
Horizontally add adjacent pairs of intermediate 32-bit integers, and pack the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := SignExtend32(a[i+31:i+16]*b[i+31:i+16]) + SignExtend32(a[i+15:i]*b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULHW - _mm_mulhi_pi16

| PMULHW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply the packed signed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store
the high 16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    tmp[31:0] := SignExtend32(a[i+15:i]) * SignExtend32(b[i+15:i])
    dst[i+15:i] := tmp[31:16]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULLW - _mm_mullo_pi16

| PMULLW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply the packed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store the low
16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    tmp[31:0] := a[i+15:i] * b[i+15:i]
    dst[i+15:i] := tmp[15:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLW - _mm_sll_pi16

| PSLLW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &lt;&lt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLW - _mm_slli_pi16

| PSLLW_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLD - _mm_sll_pi32

| PSLLD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLD - _mm_slli_pi32

| PSLLD_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLQ - _mm_sll_si64

| PSLLQ_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift 64-bit integer "a" left by "count" while shifting in zeros, and store the result in "dst".

[algorithm]

IF count[63:0] &gt; 63
    dst[63:0] := 0
ELSE
    dst[63:0] := ZeroExtend64(a[63:0] &lt;&lt; count[63:0])
FI

--------------------------------------------------------------------------------------------------------------

## PSLLQ - _mm_slli_si64

| PSLLQ_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift 64-bit integer "a" left by "imm8" while shifting in zeros, and store the result in "dst".

[algorithm]

IF imm8[7:0] &gt; 63
    dst[63:0] := 0
ELSE
    dst[63:0] := ZeroExtend64(a[63:0] &lt;&lt; imm8[7:0])
FI

--------------------------------------------------------------------------------------------------------------

## PSRAW - _mm_sra_pi16

| PSRAW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "count" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := (a[i+15] ? 0xFFFF : 0x0)
    ELSE
        dst[i+15:i] := SignExtend16(a[i+15:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAW - _mm_srai_pi16

| PSRAW_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := (a[i+15] ? 0xFFFF : 0x0)
    ELSE
        dst[i+15:i] := SignExtend16(a[i+15:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAD - _mm_sra_pi32

| PSRAD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "count" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
    ELSE
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAD - _mm_srai_pi32

| PSRAD_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
    ELSE
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLW - _mm_srl_pi16

| PSRLW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLW - _mm_srli_pi16

| PSRLW_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLD - _mm_srl_pi32

| PSRLD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLD - _mm_srli_pi32

| PSRLD_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLQ - _mm_srl_si64

| PSRLQ_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shift 64-bit integer "a" right by "count" while shifting in zeros, and store the result in "dst".

[algorithm]

IF count[63:0] &gt; 63
    dst[63:0] := 0
ELSE
    dst[63:0] := ZeroExtend64(a[63:0] &gt;&gt; count[63:0])
FI

--------------------------------------------------------------------------------------------------------------

## PSRLQ - _mm_srli_si64

| PSRLQ_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift 64-bit integer "a" right by "imm8" while shifting in zeros, and store the result in "dst".

[algorithm]

IF imm8[7:0] &gt; 63
    dst[63:0] := 0
ELSE
    dst[63:0] := ZeroExtend64(a[63:0] &gt;&gt; imm8[7:0])
FI

--------------------------------------------------------------------------------------------------------------

## PAND - _mm_and_si64

| PAND_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 64 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[63:0] := (a[63:0] AND b[63:0])

--------------------------------------------------------------------------------------------------------------

## PANDN - _mm_andnot_si64

| PANDN_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 64 bits (representing integer data) in "a" and then AND with "b", and store the
result in "dst".

[algorithm]

dst[63:0] := ((NOT a[63:0]) AND b[63:0])

--------------------------------------------------------------------------------------------------------------

## POR - _mm_or_si64

| POR_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of 64 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[63:0] := (a[63:0] OR b[63:0])

--------------------------------------------------------------------------------------------------------------

## PXOR - _mm_xor_si64

| PXOR_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of 64 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[63:0] := (a[63:0] XOR b[63:0])

--------------------------------------------------------------------------------------------------------------

## PCMPEQB - _mm_cmpeq_pi8

| PCMPEQB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed 8-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := ( a[i+7:i] == b[i+7:i] ) ? 0xFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPEQW - _mm_cmpeq_pi16

| PCMPEQW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed 16-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := ( a[i+15:i] == b[i+15:i] ) ? 0xFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPEQD - _mm_cmpeq_pi32

| PCMPEQD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed 32-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := ( a[i+31:i] == b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTB - _mm_cmpgt_pi8

| PCMPGTB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 8-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := ( a[i+7:i] &gt; b[i+7:i] ) ? 0xFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTW - _mm_cmpgt_pi16

| PCMPGTW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := ( a[i+15:i] &gt; b[i+15:i] ) ? 0xFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTD - _mm_cmpgt_pi32

| PCMPGTD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := ( a[i+31:i] &gt; b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PXOR - _mm_setzero_si64

| PXOR_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Return vector of type __m64 with all elements set to zero.

[algorithm]

dst[MAX:0] := 0

--------------------------------------------------------------------------------------------------------------

## PACKSSWB - _mm_packs_pi16

| PACKSSWB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using signed saturation, and
store the results in "dst".

[algorithm]

dst[7:0] := Saturate8(a[15:0])
dst[15:8] := Saturate8(a[31:16])
dst[23:16] := Saturate8(a[47:32])
dst[31:24] := Saturate8(a[63:48])
dst[39:32] := Saturate8(b[15:0])
dst[47:40] := Saturate8(b[31:16])
dst[55:48] := Saturate8(b[47:32])
dst[63:56] := Saturate8(b[63:48])

--------------------------------------------------------------------------------------------------------------

## PACKSSDW - _mm_packs_pi32

| PACKSSDW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using signed saturation, and
store the results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[31:0])
dst[31:16] := Saturate16(a[63:32])
dst[47:32] := Saturate16(b[31:0])
dst[63:48] := Saturate16(b[63:32])

--------------------------------------------------------------------------------------------------------------

## PACKUSWB - _mm_packs_pu16

| PACKUSWB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using unsigned saturation, and
store the results in "dst".

[algorithm]

dst[7:0] := SaturateU8(a[15:0])
dst[15:8] := SaturateU8(a[31:16])
dst[23:16] := SaturateU8(a[47:32])
dst[31:24] := SaturateU8(a[63:48])
dst[39:32] := SaturateU8(b[15:0])
dst[47:40] := SaturateU8(b[31:16])
dst[55:48] := SaturateU8(b[47:32])
dst[63:56] := SaturateU8(b[63:48])

--------------------------------------------------------------------------------------------------------------

## PUNPCKHBW - _mm_unpackhi_pi8

| PUNPCKHBW_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 8-bit integers from the high half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_BYTES(src1[63:0], src2[63:0]) {
    dst[7:0] := src1[39:32]
    dst[15:8] := src2[39:32] 
    dst[23:16] := src1[47:40]
    dst[31:24] := src2[47:40]
    dst[39:32] := src1[55:48]
    dst[47:40] := src2[55:48]
    dst[55:48] := src1[63:56]
    dst[63:56] := src2[63:56]
    RETURN dst[63:0]    
}
dst[63:0] := INTERLEAVE_HIGH_BYTES(a[63:0], b[63:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKLBW - _mm_unpackhi_pi16

| PUNPCKLBW_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 16-bit integers from the high half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_WORDS(src1[63:0], src2[63:0]) {
    dst[15:0] := src1[47:32]
    dst[31:16] := src2[47:32]
    dst[47:32] := src1[63:48]
    dst[63:48] := src2[63:48]
    RETURN dst[63:0]
}
dst[63:0] := INTERLEAVE_HIGH_WORDS(a[63:0], b[63:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKHDQ - _mm_unpackhi_pi32

| PUNPCKHDQ_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 32-bit integers from the high half of "a" and "b", and store the results in "dst".

[algorithm]

dst[31:0] := a[63:32]
dst[63:32] := b[63:32]

--------------------------------------------------------------------------------------------------------------

## PUNPCKLBW - _mm_unpacklo_pi8

| PUNPCKLBW_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 8-bit integers from the low half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_BYTES(src1[63:0], src2[63:0]) {
    dst[7:0] := src1[7:0] 
    dst[15:8] := src2[7:0] 
    dst[23:16] := src1[15:8] 
    dst[31:24] := src2[15:8] 
    dst[39:32] := src1[23:16] 
    dst[47:40] := src2[23:16] 
    dst[55:48] := src1[31:24] 
    dst[63:56] := src2[31:24] 
    RETURN dst[63:0]    
}
dst[63:0] := INTERLEAVE_BYTES(a[63:0], b[63:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKLWD - _mm_unpacklo_pi16

| PUNPCKLWD_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 16-bit integers from the low half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_WORDS(src1[63:0], src2[63:0]) {
    dst[15:0] := src1[15:0] 
    dst[31:16] := src2[15:0] 
    dst[47:32] := src1[31:16] 
    dst[63:48] := src2[31:16] 
    RETURN dst[63:0]    
}
dst[63:0] := INTERLEAVE_WORDS(a[63:0], b[63:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKLDQ - _mm_unpacklo_pi32

| PUNPCKLDQ_MMXq_MMXd

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 32-bit integers from the low half of "a" and "b", and store the results in "dst".

[algorithm]

dst[31:0] := a[31:0]
dst[63:32] := b[31:0]

--------------------------------------------------------------------------------------------------------------

## PTWRITE - _ptwrite32

| PTWRITE_GPRy

--------------------------------------------------------------------------------------------------------------
Insert the 32-bit data from "a" into a Processor Trace stream via a PTW packet. The PTW packet will be
inserted if tracing is currently enabled and ptwrite is currently enabled. The current IP will also be inserted
via a FUP packet if FUPonPTW is enabled.

[missing]

--------------------------------------------------------------------------------------------------------------

## PTWRITE - _ptwrite64

| PTWRITE_GPRy

--------------------------------------------------------------------------------------------------------------
Insert the 64-bit data from "a" into a Processor Trace stream via a PTW packet. The PTW packet will be
inserted if tracing is currently enabled and ptwrite is currently enabled. The current IP will also be inserted
via a FUP packet if FUPonPTW is enabled.

[missing]

--------------------------------------------------------------------------------------------------------------

## PCLMULQDQ - _mm_clmulepi64_si128

| PCLMULQDQ_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Perform a carry-less multiplication of two 64-bit integers, selected from "a" and "b" according to "imm8", and
store the results in "dst".

[algorithm]

IF (imm8[0] == 0)
    TEMP1 := a[63:0]
ELSE
    TEMP1 := a[127:64]
FI 
IF (imm8[4] == 0)
    TEMP2 := b[63:0]
ELSE 
    TEMP2 := b[127:64]
FI
FOR i := 0 to 63
    TEMP[i] := (TEMP1[0] and TEMP2[i])
    FOR j := 1 to i
        TEMP[i] := TEMP[i] XOR (TEMP1[j] AND TEMP2[i-j])
    ENDFOR 
    dst[i] := TEMP[i]
ENDFOR
FOR i := 64 to 127
    TEMP[i] := 0
    FOR j := (i - 63) to 63
        TEMP[i] := TEMP[i] XOR (TEMP1[j] AND TEMP2[i-j])
    ENDFOR
    dst[i] := TEMP[i]
ENDFOR
dst[127] := 0

--------------------------------------------------------------------------------------------------------------

## PCONFIG - _pconfig_u32

| PCONFIG

--------------------------------------------------------------------------------------------------------------
Invoke the PCONFIG leaf function specified by "a". The "__data" array contains 3 32-bit elements that may act
as input, output, or be unused, depending on the semantics of the specified leaf function; these correspond to
rbx, rcx, and rdx. May return the value in eax, depending on the semantics of the specified leaf function.

[missing]

--------------------------------------------------------------------------------------------------------------

## POPCNT - _mm_popcnt_u32

| POPCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of bits set to 1 in unsigned 32-bit integer "a", and return that count in "dst".

[algorithm]

dst := 0
FOR i := 0 to 31
    IF a[i]
        dst := dst + 1
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## POPCNT - _mm_popcnt_u64

| POPCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of bits set to 1 in unsigned 64-bit integer "a", and return that count in "dst".

[algorithm]

dst := 0
FOR i := 0 to 63
    IF a[i]
        dst := dst + 1
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## POPCNT - _popcnt32

| POPCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of bits set to 1 in 32-bit integer "a", and return that count in "dst".

[algorithm]

dst := 0
FOR i := 0 to 31
    IF a[i]
        dst := dst + 1
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## POPCNT - _popcnt64

| POPCNT_GPRv_GPRv

--------------------------------------------------------------------------------------------------------------
Count the number of bits set to 1 in 64-bit integer "a", and return that count in "dst".

[algorithm]

dst := 0
FOR i := 0 to 63
    IF a[i]
        dst := dst + 1
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PREFETCHWT1 - _mm_prefetch

| PREFETCHWT1_MEMu8

--------------------------------------------------------------------------------------------------------------
Fetch the line of data from memory that contains address "p" to a location in the cache heirarchy specified by
the locality hint "i".

[missing]

--------------------------------------------------------------------------------------------------------------

## PREFETCHNTA - _mm_prefetch

| PREFETCHNTA_MEMmprefetch | PREFETCHT0_MEMmprefetch | PREFETCHT1_MEMmprefetch | PREFETCHT2_MEMmprefetch

--------------------------------------------------------------------------------------------------------------
Fetch the line of data from memory that contains address "p" to a location in the cache heirarchy specified by
the locality hint "i".

[missing]

--------------------------------------------------------------------------------------------------------------

## PMAXSW - _mm_max_pi16

| PMAXSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := MAX(a[i+15:i], b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMAXSW - _m_pmaxsw

| PMAXSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := MAX(a[i+15:i], b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMAXUB - _mm_max_pu8

| PMAXUB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 8-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := MAX(a[i+7:i], b[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMAXUB - _m_pmaxub

| PMAXUB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 8-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := MAX(a[i+7:i], b[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINSW - _mm_min_pi16

| PMINSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := MIN(a[i+15:i], b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINSW - _m_pminsw

| PMINSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := MIN(a[i+15:i], b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINUB - _mm_min_pu8

| PMINUB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 8-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := MIN(a[i+7:i], b[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINUB - _m_pminub

| PMINUB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 8-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := MIN(a[i+7:i], b[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULHUW - _mm_mulhi_pu16

| PMULHUW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply the packed unsigned 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store
the high 16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    tmp[31:0] := a[i+15:i] * b[i+15:i]
    dst[i+15:i] := tmp[31:16]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULHUW - _m_pmulhuw

| PMULHUW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply the packed unsigned 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store
the high 16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    tmp[31:0] := a[i+15:i] * b[i+15:i]
    dst[i+15:i] := tmp[31:16]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PAVGB - _mm_avg_pu8

| PAVGB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Average packed unsigned 8-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := (a[i+7:i] + b[i+7:i] + 1) &gt;&gt; 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PAVGB - _m_pavgb

| PAVGB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Average packed unsigned 8-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := (a[i+7:i] + b[i+7:i] + 1) &gt;&gt; 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PAVGW - _mm_avg_pu16

| PAVGW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Average packed unsigned 16-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := (a[i+15:i] + b[i+15:i] + 1) &gt;&gt; 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PAVGW - _m_pavgw

| PAVGW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Average packed unsigned 16-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := (a[i+15:i] + b[i+15:i] + 1) &gt;&gt; 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSADBW - _mm_sad_pu8

| PSADBW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the absolute differences of packed unsigned 8-bit integers in "a" and "b", then horizontally sum each
consecutive 8 differences to produce four unsigned 16-bit integers, and pack these unsigned 16-bit integers in
the low 16 bits of "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    tmp[i+7:i] := ABS(a[i+7:i] - b[i+7:i])
ENDFOR
dst[15:0] := tmp[7:0] + tmp[15:8] + tmp[23:16] + tmp[31:24] + tmp[39:32] + tmp[47:40] + tmp[55:48] + tmp[63:56]
dst[63:16] := 0

--------------------------------------------------------------------------------------------------------------

## PSADBW - _m_psadbw

| PSADBW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the absolute differences of packed unsigned 8-bit integers in "a" and "b", then horizontally sum each
consecutive 8 differences to produce four unsigned 16-bit integers, and pack these unsigned 16-bit integers in
the low 16 bits of "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    tmp[i+7:i] := ABS(a[i+7:i] - b[i+7:i])
ENDFOR
dst[15:0] := tmp[7:0] + tmp[15:8] + tmp[23:16] + tmp[31:24] + tmp[39:32] + tmp[47:40] + tmp[55:48] + tmp[63:56]
dst[63:16] := 0

--------------------------------------------------------------------------------------------------------------

## PEXTRW - _mm_extract_pi16

| PEXTRW_GPR32_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract a 16-bit integer from "a", selected with "imm8", and store the result in the lower element of "dst".

[algorithm]

dst[15:0] := (a[63:0] &gt;&gt; (imm8[1:0] * 16))[15:0]
dst[31:16] := 0

--------------------------------------------------------------------------------------------------------------

## PEXTRW - _m_pextrw

| PEXTRW_GPR32_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract a 16-bit integer from "a", selected with "imm8", and store the result in the lower element of "dst".

[algorithm]

dst[15:0] := (a[63:0] &gt;&gt; (imm8[1:0] * 16))[15:0]
dst[31:16] := 0

--------------------------------------------------------------------------------------------------------------

## PINSRW - _mm_insert_pi16

| PINSRW_MMXq_GPR32_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the 16-bit integer "i" into "dst" at the location specified by "imm8".

[algorithm]

dst[63:0] := a[63:0]
sel := imm8[1:0]*16
dst[sel+15:sel] := i[15:0]

--------------------------------------------------------------------------------------------------------------

## PINSRW - _m_pinsrw

| PINSRW_MMXq_GPR32_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the 16-bit integer "i" into "dst" at the location specified by "imm8".

[algorithm]

dst[63:0] := a[63:0]
sel := imm8[1:0]*16
dst[sel+15:sel] := i[15:0]

--------------------------------------------------------------------------------------------------------------

## PMOVMSKB - _mm_movemask_pi8

| PMOVMSKB_GPR32_MMXq

--------------------------------------------------------------------------------------------------------------
Create mask from the most significant bit of each 8-bit element in "a", and store the result in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[j] := a[i+7]
ENDFOR
dst[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## PMOVMSKB - _m_pmovmskb

| PMOVMSKB_GPR32_MMXq

--------------------------------------------------------------------------------------------------------------
Create mask from the most significant bit of each 8-bit element in "a", and store the result in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[j] := a[i+7]
ENDFOR
dst[MAX:8] := 0

--------------------------------------------------------------------------------------------------------------

## PSHUFW - _mm_shuffle_pi16

| PSHUFW_MMXq_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 16-bit integers in "a" using the control in "imm8", and store the results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[15:0] := src[15:0]
    1:    tmp[15:0] := src[31:16]
    2:    tmp[15:0] := src[47:32]
    3:    tmp[15:0] := src[63:48]
    ESAC
    RETURN tmp[15:0]
}
dst[15:0] := SELECT4(a[63:0], imm8[1:0])
dst[31:16] := SELECT4(a[63:0], imm8[3:2])
dst[47:32] := SELECT4(a[63:0], imm8[5:4])
dst[63:48] := SELECT4(a[63:0], imm8[7:6])

--------------------------------------------------------------------------------------------------------------

## PSHUFW - _m_pshufw

| PSHUFW_MMXq_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 16-bit integers in "a" using the control in "imm8", and store the results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[15:0] := src[15:0]
    1:    tmp[15:0] := src[31:16]
    2:    tmp[15:0] := src[47:32]
    3:    tmp[15:0] := src[63:48]
    ESAC
    RETURN tmp[15:0]
}
dst[15:0] := SELECT4(a[63:0], imm8[1:0])
dst[31:16] := SELECT4(a[63:0], imm8[3:2])
dst[47:32] := SELECT4(a[63:0], imm8[5:4])
dst[63:48] := SELECT4(a[63:0], imm8[7:6])

--------------------------------------------------------------------------------------------------------------

## PAUSE - _mm_pause

| PAUSE

--------------------------------------------------------------------------------------------------------------
Provide a hint to the processor that the code sequence is a spin-wait loop. This can help improve the
performance and power consumption of spin-wait loops.

[missing]

--------------------------------------------------------------------------------------------------------------

## PADDB - _mm_add_epi8

| PADDB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Add packed 8-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := a[i+7:i] + b[i+7:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDW - _mm_add_epi16

| PADDW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Add packed 16-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := a[i+15:i] + b[i+15:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDD - _mm_add_epi32

| PADDD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Add packed 32-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[i+31:i] + b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDQ - _mm_add_si64

| PADDQ_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Add 64-bit integers "a" and "b", and store the result in "dst".

[algorithm]

dst[63:0] := a[63:0] + b[63:0]

--------------------------------------------------------------------------------------------------------------

## PADDQ - _mm_add_epi64

| PADDQ_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Add packed 64-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[i+63:i] + b[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDSB - _mm_adds_epi8

| PADDSB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Add packed signed 8-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := Saturate8( a[i+7:i] + b[i+7:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDSW - _mm_adds_epi16

| PADDSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Add packed signed 16-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := Saturate16( a[i+15:i] + b[i+15:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDUSB - _mm_adds_epu8

| PADDUSB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Add packed unsigned 8-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := SaturateU8( a[i+7:i] + b[i+7:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PADDUSW - _mm_adds_epu16

| PADDUSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Add packed unsigned 16-bit integers in "a" and "b" using saturation, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := SaturateU16( a[i+15:i] + b[i+15:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PAVGB - _mm_avg_epu8

| PAVGB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Average packed unsigned 8-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := (a[i+7:i] + b[i+7:i] + 1) &gt;&gt; 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PAVGW - _mm_avg_epu16

| PAVGW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Average packed unsigned 16-bit integers in "a" and "b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := (a[i+15:i] + b[i+15:i] + 1) &gt;&gt; 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMADDWD - _mm_madd_epi16

| PMADDWD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers.
Horizontally add adjacent pairs of intermediate 32-bit integers, and pack the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := SignExtend32(a[i+31:i+16]*b[i+31:i+16]) + SignExtend32(a[i+15:i]*b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMAXSW - _mm_max_epi16

| PMAXSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := MAX(a[i+15:i], b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMAXUB - _mm_max_epu8

| PMAXUB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 8-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := MAX(a[i+7:i], b[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINSW - _mm_min_epi16

| PMINSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := MIN(a[i+15:i], b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINUB - _mm_min_epu8

| PMINUB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 8-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := MIN(a[i+7:i], b[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULHW - _mm_mulhi_epi16

| PMULHW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply the packed signed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store
the high 16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    tmp[31:0] := SignExtend32(a[i+15:i]) * SignExtend32(b[i+15:i])
    dst[i+15:i] := tmp[31:16]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULHUW - _mm_mulhi_epu16

| PMULHUW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply the packed unsigned 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store
the high 16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    tmp[31:0] := a[i+15:i] * b[i+15:i]
    dst[i+15:i] := tmp[31:16]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULLW - _mm_mullo_epi16

| PMULLW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply the packed 16-bit integers in "a" and "b", producing intermediate 32-bit integers, and store the low
16 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    tmp[31:0] := SignExtend32(a[i+15:i]) * SignExtend32(b[i+15:i])
    dst[i+15:i] := tmp[15:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULUDQ - _mm_mul_su32

| PMULUDQ_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply the low unsigned 32-bit integers from "a" and "b", and store the unsigned 64-bit result in "dst".

[algorithm]

dst[63:0] := a[31:0] * b[31:0]

--------------------------------------------------------------------------------------------------------------

## PMULUDQ - _mm_mul_epu32

| PMULUDQ_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply the low unsigned 32-bit integers from each packed 64-bit element in "a" and "b", and store the
unsigned 64-bit results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[i+31:i] * b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSADBW - _mm_sad_epu8

| PSADBW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the absolute differences of packed unsigned 8-bit integers in "a" and "b", then horizontally sum each
consecutive 8 differences to produce two unsigned 16-bit integers, and pack these unsigned 16-bit integers in
the low 16 bits of 64-bit elements in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    tmp[i+7:i] := ABS(a[i+7:i] - b[i+7:i])
ENDFOR
FOR j := 0 to 1
    i := j*64
    dst[i+15:i] := tmp[i+7:i] + tmp[i+15:i+8] + tmp[i+23:i+16] + tmp[i+31:i+24] + \
                   tmp[i+39:i+32] + tmp[i+47:i+40] + tmp[i+55:i+48] + tmp[i+63:i+56]
    dst[i+63:i+16] := 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBB - _mm_sub_epi8

| PSUBB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Subtract packed 8-bit integers in "b" from packed 8-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := a[i+7:i] - b[i+7:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBW - _mm_sub_epi16

| PSUBW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Subtract packed 16-bit integers in "b" from packed 16-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := a[i+15:i] - b[i+15:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBD - _mm_sub_epi32

| PSUBD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Subtract packed 32-bit integers in "b" from packed 32-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[i+31:i] - b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBQ - _mm_sub_si64

| PSUBQ_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Subtract 64-bit integer "b" from 64-bit integer "a", and store the result in "dst".

[algorithm]

dst[63:0] := a[63:0] - b[63:0]

--------------------------------------------------------------------------------------------------------------

## PSUBQ - _mm_sub_epi64

| PSUBQ_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Subtract packed 64-bit integers in "b" from packed 64-bit integers in "a", and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[i+63:i] - b[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBSB - _mm_subs_epi8

| PSUBSB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Subtract packed signed 8-bit integers in "b" from packed 8-bit integers in "a" using saturation, and store the
results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := Saturate8(a[i+7:i] - b[i+7:i])    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBSW - _mm_subs_epi16

| PSUBSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Subtract packed signed 16-bit integers in "b" from packed 16-bit integers in "a" using saturation, and store
the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := Saturate16(a[i+15:i] - b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBUSB - _mm_subs_epu8

| PSUBUSB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Subtract packed unsigned 8-bit integers in "b" from packed unsigned 8-bit integers in "a" using saturation,
and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := SaturateU8(a[i+7:i] - b[i+7:i])    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSUBUSW - _mm_subs_epu16

| PSUBUSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Subtract packed unsigned 16-bit integers in "b" from packed unsigned 16-bit integers in "a" using saturation,
and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := SaturateU16(a[i+15:i] - b[i+15:i])    
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLDQ - _mm_slli_si128

| PSLLDQ_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift "a" left by "imm8" bytes while shifting in zeros, and store the results in "dst".

[algorithm]

tmp := imm8[7:0]
IF tmp &gt; 15
    tmp := 16
FI
dst[127:0] := a[127:0] &lt;&lt; (tmp*8)

--------------------------------------------------------------------------------------------------------------

## PSLLDQ - _mm_bslli_si128

| PSLLDQ_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift "a" left by "imm8" bytes while shifting in zeros, and store the results in "dst".

[algorithm]

tmp := imm8[7:0]
IF tmp &gt; 15
    tmp := 16
FI
dst[127:0] := a[127:0] &lt;&lt; (tmp*8)

--------------------------------------------------------------------------------------------------------------

## PSRLDQ - _mm_bsrli_si128

| PSRLDQ_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift "a" right by "imm8" bytes while shifting in zeros, and store the results in "dst".

[algorithm]

tmp := imm8[7:0]
IF tmp &gt; 15
    tmp := 16
FI
dst[127:0] := a[127:0] &gt;&gt; (tmp*8)

--------------------------------------------------------------------------------------------------------------

## PSLLW - _mm_slli_epi16

| PSLLW_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLW - _mm_sll_epi16

| PSLLW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &lt;&lt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLD - _mm_slli_epi32

| PSLLD_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLD - _mm_sll_epi32

| PSLLD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &lt;&lt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLQ - _mm_slli_epi64

| PSLLQ_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" left by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF imm8[7:0] &gt; 63
        dst[i+63:i] := 0
    ELSE
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &lt;&lt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSLLQ - _mm_sll_epi64

| PSLLQ_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" left by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF count[63:0] &gt; 63
        dst[i+63:i] := 0
    ELSE
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &lt;&lt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAW - _mm_srai_epi16

| PSRAW_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := (a[i+15] ? 0xFFFF : 0x0)
    ELSE
        dst[i+15:i] := SignExtend16(a[i+15:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAW - _mm_sra_epi16

| PSRAW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "count" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := (a[i+15] ? 0xFFFF : 0x0)
    ELSE
        dst[i+15:i] := SignExtend16(a[i+15:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAD - _mm_srai_epi32

| PSRAD_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
    ELSE
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRAD - _mm_sra_epi32

| PSRAD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "count" while shifting in sign bits, and store the results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := (a[i+31] ? 0xFFFFFFFF : 0x0)
    ELSE
        dst[i+31:i] := SignExtend32(a[i+31:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLDQ - _mm_srli_si128

| PSRLDQ_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift "a" right by "imm8" bytes while shifting in zeros, and store the results in "dst".

[algorithm]

tmp := imm8[7:0]
IF tmp &gt; 15
    tmp := 16
FI
dst[127:0] := a[127:0] &gt;&gt; (tmp*8)

--------------------------------------------------------------------------------------------------------------

## PSRLW - _mm_srli_epi16

| PSRLW_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    IF imm8[7:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLW - _mm_srl_epi16

| PSRLW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 16-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    IF count[63:0] &gt; 15
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := ZeroExtend16(a[i+15:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLD - _mm_srli_epi32

| PSRLD_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF imm8[7:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLD - _mm_srl_epi32

| PSRLD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 32-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF count[63:0] &gt; 31
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := ZeroExtend32(a[i+31:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLQ - _mm_srli_epi64

| PSRLQ_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" right by "imm8" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF imm8[7:0] &gt; 63
        dst[i+63:i] := 0
    ELSE
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &gt;&gt; imm8[7:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSRLQ - _mm_srl_epi64

| PSRLQ_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shift packed 64-bit integers in "a" right by "count" while shifting in zeros, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF count[63:0] &gt; 63
        dst[i+63:i] := 0
    ELSE
        dst[i+63:i] := ZeroExtend64(a[i+63:i] &gt;&gt; count[63:0])
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PAND - _mm_and_si128

| PAND_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[127:0] := (a[127:0] AND b[127:0])

--------------------------------------------------------------------------------------------------------------

## PANDN - _mm_andnot_si128

| PANDN_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of 128 bits (representing integer data) in "a" and then AND with "b", and store the
result in "dst".

[algorithm]

dst[127:0] := ((NOT a[127:0]) AND b[127:0])

--------------------------------------------------------------------------------------------------------------

## POR - _mm_or_si128

| POR_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise OR of 128 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[127:0] := (a[127:0] OR b[127:0])

--------------------------------------------------------------------------------------------------------------

## PXOR - _mm_xor_si128

| PXOR_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of 128 bits (representing integer data) in "a" and "b", and store the result in "dst".

[algorithm]

dst[127:0] := (a[127:0] XOR b[127:0])

--------------------------------------------------------------------------------------------------------------

## PCMPEQB - _mm_cmpeq_epi8

| PCMPEQB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed 8-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := ( a[i+7:i] == b[i+7:i] ) ? 0xFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPEQW - _mm_cmpeq_epi16

| PCMPEQW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed 16-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := ( a[i+15:i] == b[i+15:i] ) ? 0xFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPEQD - _mm_cmpeq_epi32

| PCMPEQD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed 32-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] == b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTB - _mm_cmpgt_epi8

| PCMPGTB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 8-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := ( a[i+7:i] &gt; b[i+7:i] ) ? 0xFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTW - _mm_cmpgt_epi16

| PCMPGTW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := ( a[i+15:i] &gt; b[i+15:i] ) ? 0xFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTD - _mm_cmpgt_epi32

| PCMPGTD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] &gt; b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTB - _mm_cmplt_epi8

| PCMPGTB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 8-bit integers in "a" and "b" for less-than, and store the results in "dst". Note: This
intrinsic emits the pcmpgtb instruction with the order of the operands switched.

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := ( a[i+7:i] &lt; b[i+7:i] ) ? 0xFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTW - _mm_cmplt_epi16

| PCMPGTW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 16-bit integers in "a" and "b" for less-than, and store the results in "dst". Note: This
intrinsic emits the pcmpgtw instruction with the order of the operands switched.

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := ( a[i+15:i] &lt; b[i+15:i] ) ? 0xFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PCMPGTD - _mm_cmplt_epi32

| PCMPGTD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b" for less-than, and store the results in "dst". Note: This
intrinsic emits the pcmpgtd instruction with the order of the operands switched.

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ( a[i+31:i] &lt; b[i+31:i] ) ? 0xFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PXOR - _mm_setzero_si128

| PXOR_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Return vector of type __m128i with all elements set to zero.

[algorithm]

dst[MAX:0] := 0

--------------------------------------------------------------------------------------------------------------

## PACKSSWB - _mm_packs_epi16

| PACKSSWB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using signed saturation, and
store the results in "dst".

[algorithm]

dst[7:0] := Saturate8(a[15:0])
dst[15:8] := Saturate8(a[31:16])
dst[23:16] := Saturate8(a[47:32])
dst[31:24] := Saturate8(a[63:48])
dst[39:32] := Saturate8(a[79:64])
dst[47:40] := Saturate8(a[95:80])
dst[55:48] := Saturate8(a[111:96])
dst[63:56] := Saturate8(a[127:112])
dst[71:64] := Saturate8(b[15:0])
dst[79:72] := Saturate8(b[31:16])
dst[87:80] := Saturate8(b[47:32])
dst[95:88] := Saturate8(b[63:48])
dst[103:96] := Saturate8(b[79:64])
dst[111:104] := Saturate8(b[95:80])
dst[119:112] := Saturate8(b[111:96])
dst[127:120] := Saturate8(b[127:112])

--------------------------------------------------------------------------------------------------------------

## PACKSSDW - _mm_packs_epi32

| PACKSSDW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using signed saturation, and
store the results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[31:0])
dst[31:16] := Saturate16(a[63:32])
dst[47:32] := Saturate16(a[95:64])
dst[63:48] := Saturate16(a[127:96])
dst[79:64] := Saturate16(b[31:0])
dst[95:80] := Saturate16(b[63:32])
dst[111:96] := Saturate16(b[95:64])
dst[127:112] := Saturate16(b[127:96])

--------------------------------------------------------------------------------------------------------------

## PACKUSWB - _mm_packus_epi16

| PACKUSWB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 16-bit integers from "a" and "b" to packed 8-bit integers using unsigned saturation, and
store the results in "dst".

[algorithm]

dst[7:0] := SaturateU8(a[15:0])
dst[15:8] := SaturateU8(a[31:16])
dst[23:16] := SaturateU8(a[47:32])
dst[31:24] := SaturateU8(a[63:48])
dst[39:32] := SaturateU8(a[79:64])
dst[47:40] := SaturateU8(a[95:80])
dst[55:48] := SaturateU8(a[111:96])
dst[63:56] := SaturateU8(a[127:112])
dst[71:64] := SaturateU8(b[15:0])
dst[79:72] := SaturateU8(b[31:16])
dst[87:80] := SaturateU8(b[47:32])
dst[95:88] := SaturateU8(b[63:48])
dst[103:96] := SaturateU8(b[79:64])
dst[111:104] := SaturateU8(b[95:80])
dst[119:112] := SaturateU8(b[111:96])
dst[127:120] := SaturateU8(b[127:112])

--------------------------------------------------------------------------------------------------------------

## PEXTRW - _mm_extract_epi16

| PEXTRW_GPR32_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract a 16-bit integer from "a", selected with "imm8", and store the result in the lower element of "dst".

[algorithm]

dst[15:0] := (a[127:0] &gt;&gt; (imm8[2:0] * 16))[15:0]
dst[31:16] := 0

--------------------------------------------------------------------------------------------------------------

## PINSRW - _mm_insert_epi16

| PINSRW_XMMdq_GPR32_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the 16-bit integer "i" into "dst" at the location specified by "imm8".

[algorithm]

dst[127:0] := a[127:0]
sel := imm8[2:0]*16
dst[sel+15:sel] := i[15:0]

--------------------------------------------------------------------------------------------------------------

## PMOVMSKB - _mm_movemask_epi8

| PMOVMSKB_GPR32_XMMdq

--------------------------------------------------------------------------------------------------------------
Create mask from the most significant bit of each 8-bit element in "a", and store the result in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[j] := a[i+7]
ENDFOR
dst[MAX:16] := 0

--------------------------------------------------------------------------------------------------------------

## PSHUFD - _mm_shuffle_epi32

| PSHUFD_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 32-bit integers in "a" using the control in "imm8", and store the results in "dst".

[algorithm]

DEFINE SELECT4(src, control) {
    CASE(control[1:0]) OF
    0:    tmp[31:0] := src[31:0]
    1:    tmp[31:0] := src[63:32]
    2:    tmp[31:0] := src[95:64]
    3:    tmp[31:0] := src[127:96]
    ESAC
    RETURN tmp[31:0]
}
dst[31:0] := SELECT4(a[127:0], imm8[1:0])
dst[63:32] := SELECT4(a[127:0], imm8[3:2])
dst[95:64] := SELECT4(a[127:0], imm8[5:4])
dst[127:96] := SELECT4(a[127:0], imm8[7:6])

--------------------------------------------------------------------------------------------------------------

## PSHUFHW - _mm_shufflehi_epi16

| PSHUFHW_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 16-bit integers in the high 64 bits of "a" using the control in "imm8". Store the results in the high
64 bits of "dst", with the low 64 bits being copied from from "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]
dst[79:64] := (a &gt;&gt; (imm8[1:0] * 16))[79:64]
dst[95:80] := (a &gt;&gt; (imm8[3:2] * 16))[79:64]
dst[111:96] := (a &gt;&gt; (imm8[5:4] * 16))[79:64]
dst[127:112] := (a &gt;&gt; (imm8[7:6] * 16))[79:64]

--------------------------------------------------------------------------------------------------------------

## PSHUFLW - _mm_shufflelo_epi16

| PSHUFLW_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Shuffle 16-bit integers in the low 64 bits of "a" using the control in "imm8". Store the results in the low 64
bits of "dst", with the high 64 bits being copied from from "a" to "dst".

[algorithm]

dst[15:0] := (a &gt;&gt; (imm8[1:0] * 16))[15:0]
dst[31:16] := (a &gt;&gt; (imm8[3:2] * 16))[15:0]
dst[47:32] := (a &gt;&gt; (imm8[5:4] * 16))[15:0]
dst[63:48] := (a &gt;&gt; (imm8[7:6] * 16))[15:0]
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## PUNPCKHBW - _mm_unpackhi_epi8

| PUNPCKHBW_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 8-bit integers from the high half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_BYTES(src1[127:0], src2[127:0]) {
    dst[7:0] := src1[71:64] 
    dst[15:8] := src2[71:64] 
    dst[23:16] := src1[79:72] 
    dst[31:24] := src2[79:72] 
    dst[39:32] := src1[87:80] 
    dst[47:40] := src2[87:80] 
    dst[55:48] := src1[95:88] 
    dst[63:56] := src2[95:88] 
    dst[71:64] := src1[103:96] 
    dst[79:72] := src2[103:96] 
    dst[87:80] := src1[111:104] 
    dst[95:88] := src2[111:104] 
    dst[103:96] := src1[119:112] 
    dst[111:104] := src2[119:112] 
    dst[119:112] := src1[127:120] 
    dst[127:120] := src2[127:120] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_HIGH_BYTES(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKHWD - _mm_unpackhi_epi16

| PUNPCKHWD_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 16-bit integers from the high half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_WORDS(src1[127:0], src2[127:0]) {
    dst[15:0] := src1[79:64]
    dst[31:16] := src2[79:64] 
    dst[47:32] := src1[95:80] 
    dst[63:48] := src2[95:80] 
    dst[79:64] := src1[111:96] 
    dst[95:80] := src2[111:96] 
    dst[111:96] := src1[127:112] 
    dst[127:112] := src2[127:112] 
    RETURN dst[127:0]
}
dst[127:0] := INTERLEAVE_HIGH_WORDS(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKHDQ - _mm_unpackhi_epi32

| PUNPCKHDQ_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 32-bit integers from the high half of "a" and "b", and store the results in "dst".

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

## PUNPCKHQDQ - _mm_unpackhi_epi64

| PUNPCKHQDQ_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 64-bit integers from the high half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_HIGH_QWORDS(src1[127:0], src2[127:0]) {
    dst[63:0] := src1[127:64] 
    dst[127:64] := src2[127:64] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_HIGH_QWORDS(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKLBW - _mm_unpacklo_epi8

| PUNPCKLBW_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 8-bit integers from the low half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_BYTES(src1[127:0], src2[127:0]) {
    dst[7:0] := src1[7:0] 
    dst[15:8] := src2[7:0] 
    dst[23:16] := src1[15:8] 
    dst[31:24] := src2[15:8] 
    dst[39:32] := src1[23:16] 
    dst[47:40] := src2[23:16] 
    dst[55:48] := src1[31:24] 
    dst[63:56] := src2[31:24] 
    dst[71:64] := src1[39:32]
    dst[79:72] := src2[39:32] 
    dst[87:80] := src1[47:40] 
    dst[95:88] := src2[47:40] 
    dst[103:96] := src1[55:48] 
    dst[111:104] := src2[55:48] 
    dst[119:112] := src1[63:56] 
    dst[127:120] := src2[63:56] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_BYTES(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKLWD - _mm_unpacklo_epi16

| PUNPCKLWD_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 16-bit integers from the low half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_WORDS(src1[127:0], src2[127:0]) {
    dst[15:0] := src1[15:0] 
    dst[31:16] := src2[15:0] 
    dst[47:32] := src1[31:16] 
    dst[63:48] := src2[31:16] 
    dst[79:64] := src1[47:32] 
    dst[95:80] := src2[47:32] 
    dst[111:96] := src1[63:48] 
    dst[127:112] := src2[63:48] 
    RETURN dst[127:0]    
}
dst[127:0] := INTERLEAVE_WORDS(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## PUNPCKLDQ - _mm_unpacklo_epi32

| PUNPCKLDQ_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 32-bit integers from the low half of "a" and "b", and store the results in "dst".

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

## PUNPCKLQDQ - _mm_unpacklo_epi64

| PUNPCKLQDQ_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Unpack and interleave 64-bit integers from the low half of "a" and "b", and store the results in "dst".

[algorithm]

DEFINE INTERLEAVE_QWORDS(src1[127:0], src2[127:0]) {
    dst[63:0] := src1[63:0] 
    dst[127:64] := src2[63:0] 
    RETURN dst[127:0]
}
dst[127:0] := INTERLEAVE_QWORDS(a[127:0], b[127:0])

--------------------------------------------------------------------------------------------------------------

## PBLENDVB - _mm_blendv_epi8

| PBLENDVB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Blend packed 8-bit integers from "a" and "b" using "mask", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    IF mask[i+7]
        dst[i+7:i] := b[i+7:i]
    ELSE
        dst[i+7:i] := a[i+7:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PBLENDW - _mm_blend_epi16

| PBLENDW_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Blend packed 16-bit integers from "a" and "b" using control mask "imm8", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    IF imm8[j]
        dst[i+15:i] := b[i+15:i]
    ELSE
        dst[i+15:i] := a[i+15:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PEXTRB - _mm_extract_epi8

| PEXTRB_GPR32d_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract an 8-bit integer from "a", selected with "imm8", and store the result in the lower element of "dst".

[algorithm]

dst[7:0] := (a[127:0] &gt;&gt; (imm8[3:0] * 8))[7:0]
dst[31:8] := 0

--------------------------------------------------------------------------------------------------------------

## PEXTRD - _mm_extract_epi32

| PEXTRD_GPR32d_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract a 32-bit integer from "a", selected with "imm8", and store the result in "dst".

[algorithm]

dst[31:0] := (a[127:0] &gt;&gt; (imm8[1:0] * 32))[31:0]

--------------------------------------------------------------------------------------------------------------

## PEXTRQ - _mm_extract_epi64

| PEXTRQ_GPR64q_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract a 64-bit integer from "a", selected with "imm8", and store the result in "dst".

[algorithm]

dst[63:0] := (a[127:0] &gt;&gt; (imm8[0] * 64))[63:0]

--------------------------------------------------------------------------------------------------------------

## PINSRB - _mm_insert_epi8

| PINSRB_XMMdq_GPR32d_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the lower 8-bit integer from "i" into "dst" at the location specified by "imm8".

[algorithm]

dst[127:0] := a[127:0]
sel := imm8[3:0]*8
dst[sel+7:sel] := i[7:0]

--------------------------------------------------------------------------------------------------------------

## PINSRD - _mm_insert_epi32

| PINSRD_XMMdq_GPR32d_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the 32-bit integer "i" into "dst" at the location specified by "imm8".

[algorithm]

dst[127:0] := a[127:0]
sel := imm8[1:0]*32
dst[sel+31:sel] := i[31:0]

--------------------------------------------------------------------------------------------------------------

## PINSRQ - _mm_insert_epi64

| PINSRQ_XMMdq_GPR64q_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "dst", and insert the 64-bit integer "i" into "dst" at the location specified by "imm8".

[algorithm]

dst[127:0] := a[127:0]
sel := imm8[0]*64
dst[sel+63:sel] := i[63:0]

--------------------------------------------------------------------------------------------------------------

## PMAXSB - _mm_max_epi8

| PMAXSB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 8-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := MAX(a[i+7:i], b[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMAXSD - _mm_max_epi32

| PMAXSD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMAXUD - _mm_max_epu32

| PMAXUD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMAXUW - _mm_max_epu16

| PMAXUW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 16-bit integers in "a" and "b", and store packed maximum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := MAX(a[i+15:i], b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINSB - _mm_min_epi8

| PMINSB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 8-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := MIN(a[i+7:i], b[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINSD - _mm_min_epi32

| PMINSD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 32-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINUD - _mm_min_epu32

| PMINUD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 32-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMINUW - _mm_min_epu16

| PMINUW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed unsigned 16-bit integers in "a" and "b", and store packed minimum values in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := MIN(a[i+15:i], b[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PACKUSDW - _mm_packus_epi32

| PACKUSDW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Convert packed signed 32-bit integers from "a" and "b" to packed 16-bit integers using unsigned saturation,
and store the results in "dst".

[algorithm]

dst[15:0] := SaturateU16(a[31:0])
dst[31:16] := SaturateU16(a[63:32])
dst[47:32] := SaturateU16(a[95:64])
dst[63:48] := SaturateU16(a[127:96])
dst[79:64] := SaturateU16(b[31:0])
dst[95:80] := SaturateU16(b[63:32])
dst[111:96] := SaturateU16(b[95:64])
dst[127:112] := SaturateU16(b[127:96])

--------------------------------------------------------------------------------------------------------------

## PCMPEQQ - _mm_cmpeq_epi64

| PCMPEQQ_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed 64-bit integers in "a" and "b" for equality, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ( a[i+63:i] == b[i+63:i] ) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVSXBW - _mm_cvtepi8_epi16

| PMOVSXBW_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Sign extend packed 8-bit integers in "a" to packed 16-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    l := j*16
    dst[l+15:l] := SignExtend16(a[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVSXBD - _mm_cvtepi8_epi32

| PMOVSXBD_XMMdq_XMMd

--------------------------------------------------------------------------------------------------------------
Sign extend packed 8-bit integers in "a" to packed 32-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    k := 8*j
    dst[i+31:i] := SignExtend32(a[k+7:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVSXBQ - _mm_cvtepi8_epi64

| PMOVSXBQ_XMMdq_XMMw

--------------------------------------------------------------------------------------------------------------
Sign extend packed 8-bit integers in the low 8 bytes of "a" to packed 64-bit integers, and store the results
in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    k := 8*j
    dst[i+63:i] := SignExtend64(a[k+7:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVSXWD - _mm_cvtepi16_epi32

| PMOVSXWD_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Sign extend packed 16-bit integers in "a" to packed 32-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    k := 16*j
    dst[i+31:i] := SignExtend32(a[k+15:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVSXWQ - _mm_cvtepi16_epi64

| PMOVSXWQ_XMMdq_XMMd

--------------------------------------------------------------------------------------------------------------
Sign extend packed 16-bit integers in "a" to packed 64-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    k := 16*j
    dst[i+63:i] := SignExtend64(a[k+15:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVSXDQ - _mm_cvtepi32_epi64

| PMOVSXDQ_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Sign extend packed 32-bit integers in "a" to packed 64-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    k := 32*j
    dst[i+63:i] := SignExtend64(a[k+31:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVZXBW - _mm_cvtepu8_epi16

| PMOVZXBW_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 8-bit integers in "a" to packed 16-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    l := j*16
    dst[l+15:l] := ZeroExtend16(a[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVZXBD - _mm_cvtepu8_epi32

| PMOVZXBD_XMMdq_XMMd

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 8-bit integers in "a" to packed 32-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    k := 8*j
    dst[i+31:i] := ZeroExtend32(a[k+7:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVZXBQ - _mm_cvtepu8_epi64

| PMOVZXBQ_XMMdq_XMMw

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 8-bit integers in the low 8 byte sof "a" to packed 64-bit integers, and store the
results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    k := 8*j
    dst[i+63:i] := ZeroExtend64(a[k+7:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVZXWD - _mm_cvtepu16_epi32

| PMOVZXWD_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 16-bit integers in "a" to packed 32-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := 32*j
    k := 16*j
    dst[i+31:i] := ZeroExtend32(a[k+15:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVZXWQ - _mm_cvtepu16_epi64

| PMOVZXWQ_XMMdq_XMMd

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 16-bit integers in "a" to packed 64-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    k := 16*j
    dst[i+63:i] := ZeroExtend64(a[k+15:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMOVZXDQ - _mm_cvtepu32_epi64

| PMOVZXDQ_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Zero extend packed unsigned 32-bit integers in "a" to packed 64-bit integers, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := 64*j
    k := 32*j
    dst[i+63:i] := ZeroExtend64(a[k+31:k])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULDQ - _mm_mul_epi32

| PMULDQ_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply the low signed 32-bit integers from each packed 64-bit element in "a" and "b", and store the signed
64-bit results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := SignExtend64(a[i+31:i]) * SignExtend64(b[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULLD - _mm_mullo_epi32

| PMULLD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply the packed 32-bit integers in "a" and "b", producing intermediate 64-bit integers, and store the low
32 bits of the intermediate integers in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    tmp[63:0] := a[i+31:i] * b[i+31:i]
    dst[i+31:i] := tmp[31:0]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PTEST - _mm_testz_si128

| PTEST_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the
result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to
1 if the result is zero, otherwise set "CF" to 0. Return the "ZF" value.

[algorithm]

IF ((a[127:0] AND b[127:0]) == 0)
    ZF := 1
ELSE
    ZF := 0
FI
IF (((NOT a[127:0]) AND b[127:0]) == 0)
    CF := 1
ELSE
    CF := 0
FI
RETURN ZF

--------------------------------------------------------------------------------------------------------------

## PTEST - _mm_testc_si128

| PTEST_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the
result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to
1 if the result is zero, otherwise set "CF" to 0. Return the "CF" value.

[algorithm]

IF ((a[127:0] AND b[127:0]) == 0)
    ZF := 1
ELSE
    ZF := 0
FI
IF (((NOT a[127:0]) AND b[127:0]) == 0)
    CF := 1
ELSE
    CF := 0
FI
RETURN CF

--------------------------------------------------------------------------------------------------------------

## PTEST - _mm_testnzc_si128

| PTEST_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing integer data) in "a" and "b", and set "ZF" to 1 if the
result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "b", and set "CF" to
1 if the result is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero, otherwise
return 0.

[algorithm]

IF ((a[127:0] AND b[127:0]) == 0)
    ZF := 1
ELSE
    ZF := 0
FI
IF (((NOT a[127:0]) AND b[127:0]) == 0)
    CF := 1
ELSE
    CF := 0
FI
IF (ZF == 0 &amp;&amp; CF == 0)
    dst := 1
ELSE
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## PTEST - _mm_test_all_zeros

| PTEST_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing integer data) in "a" and "mask", and return 1 if the result
is zero, otherwise return 0.

[algorithm]

IF ((a[127:0] AND mask[127:0]) == 0)
    ZF := 1
ELSE
    ZF := 0
FI
dst := ZF

--------------------------------------------------------------------------------------------------------------

## PTEST - _mm_test_mix_ones_zeros

| PTEST_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise AND of 128 bits (representing integer data) in "a" and "mask", and set "ZF" to 1 if the
result is zero, otherwise set "ZF" to 0. Compute the bitwise NOT of "a" and then AND with "mask", and set "CF"
to 1 if the result is zero, otherwise set "CF" to 0. Return 1 if both the "ZF" and "CF" values are zero,
otherwise return 0.

[algorithm]

IF ((a[127:0] AND mask[127:0]) == 0)
    ZF := 1
ELSE
    ZF := 0
FI
IF (((NOT a[127:0]) AND mask[127:0]) == 0)
    CF := 1
ELSE
    CF := 0
FI
IF (ZF == 0 &amp;&amp; CF == 0)
    dst := 1
ELSE
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## PCMPEQD - _mm_test_all_ones

| PCMPEQD_XMMdq_XMMdq | PTEST_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise NOT of "a" and then AND with a 128-bit vector containing all 1's, and return 1 if the
result is zero, otherwise return 0.

[algorithm]

FOR j := 0 to 127
    tmp[j] := 1
ENDFOR
IF (((NOT a[127:0]) AND tmp[127:0]) == 0)
    CF := 1
ELSE
    CF := 0
FI
dst := CF

--------------------------------------------------------------------------------------------------------------

## PHMINPOSUW - _mm_minpos_epu16

| PHMINPOSUW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Horizontally compute the minimum amongst the packed unsigned 16-bit integers in "a", store the minimum and
index in "dst", and zero the remaining bits in "dst".

[algorithm]

index[2:0] := 0
min[15:0] := a[15:0]
FOR j := 0 to 7
    i := j*16
    IF a[i+15:i] &lt; min[15:0]
        index[2:0] := j
        min[15:0] := a[i+15:i]
    FI
ENDFOR
dst[15:0] := min[15:0]
dst[18:16] := index[2:0]
dst[127:19] := 0

--------------------------------------------------------------------------------------------------------------

## PCMPISTRM - _mm_cmpistrm

| PCMPISTRM_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings with implicit lengths in "a" and "b" using the control in "imm8", and store the
generated mask in "dst".
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF a[m+size-1:m] == 0
            aInvalid := 1
        FI
        IF b[n+size-1:n] == 0
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
bInvalid := 0
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF b[n+size-1:n] == 0
                bInvalid := 1
            FI
            IF bInvalid // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
IF imm8[6] // byte / word mask
    FOR i := 0 to UpperBound
        j := i*size
        IF IntRes2[i]
            dst[j+size-1:j] := (imm8[0] ? 0xFF : 0xFFFF)
        ELSE
            dst[j+size-1:j] := 0
        FI
    ENDFOR
ELSE // bit mask
    dst[UpperBound:0] := IntRes2[UpperBound:0]
    dst[127:UpperBound+1] := 0
FI

--------------------------------------------------------------------------------------------------------------

## PCMPISTRI - _mm_cmpistri

| PCMPISTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings with implicit lengths in "a" and "b" using the control in "imm8", and store the
generated index in "dst".
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF a[m+size-1:m] == 0
            aInvalid := 1
        FI
        IF b[n+size-1:n] == 0
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
bInvalid := 0
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF b[n+size-1:n] == 0
                bInvalid := 1
            FI
            IF bInvalid // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
IF imm8[6] // most significant bit
    tmp := UpperBound
    dst := tmp
    DO WHILE ((tmp &gt;= 0) AND a[tmp] == 0)
        tmp := tmp - 1
        dst := tmp
    OD
ELSE // least significant bit
    tmp := 0
    dst := tmp
    DO WHILE ((tmp &lt;= UpperBound) AND a[tmp] == 0)
        tmp := tmp + 1
        dst := tmp
    OD
FI

--------------------------------------------------------------------------------------------------------------

## PCMPISTRI - _mm_cmpistrz

| PCMPISTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings with implicit lengths in "a" and "b" using the control in "imm8", and returns 1 if any
character in "b" was null, and 0 otherwise.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
bInvalid := 0
FOR j := 0 to UpperBound
    n := j*size
    IF b[n+size-1:n] == 0
        bInvalid := 1
    FI
ENDFOR
dst := bInvalid

--------------------------------------------------------------------------------------------------------------

## PCMPISTRI - _mm_cmpistrc

| PCMPISTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings with implicit lengths in "a" and "b" using the control in "imm8", and returns 1 if the
resulting mask was non-zero, and 0 otherwise.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF a[m+size-1:m] == 0
            aInvalid := 1
        FI
        IF b[n+size-1:n] == 0
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
bInvalid := 0
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF b[n+size-1:n] == 0
                bInvalid := 1
            FI
            IF bInvalid // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
dst := (IntRes2 != 0)

--------------------------------------------------------------------------------------------------------------

## PCMPISTRI - _mm_cmpistrs

| PCMPISTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings with implicit lengths in "a" and "b" using the control in "imm8", and returns 1 if any
character in "a" was null, and 0 otherwise.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
aInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    IF a[m+size-1:m] == 0
        aInvalid := 1
    FI
ENDFOR
dst := aInvalid

--------------------------------------------------------------------------------------------------------------

## PCMPISTRI - _mm_cmpistro

| PCMPISTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings with implicit lengths in "a" and "b" using the control in "imm8", and returns bit 0 of
the resulting bit mask.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF a[m+size-1:m] == 0
            aInvalid := 1
        FI
        IF b[n+size-1:n] == 0
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
bInvalid := 0
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF b[n+size-1:n] == 0
                bInvalid := 1
            FI
            IF bInvalid // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
dst := IntRes2[0]

--------------------------------------------------------------------------------------------------------------

## PCMPISTRI - _mm_cmpistra

| PCMPISTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings with implicit lengths in "a" and "b" using the control in "imm8", and returns 1 if "b"
did not contain a null character and the resulting mask was zero, and 0 otherwise.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF a[m+size-1:m] == 0
            aInvalid := 1
        FI
        IF b[n+size-1:n] == 0
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
bInvalid := 0
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF b[n+size-1:n] == 0
                bInvalid := 1
            FI
            IF bInvalid // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
dst := (IntRes2 == 0) AND bInvalid

--------------------------------------------------------------------------------------------------------------

## PCMPESTRM - _mm_cmpestrm

| PCMPESTRM_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings in "a" and "b" with lengths "la" and "lb" using the control in "imm8", and store the
generated mask in "dst".
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF i == la
            aInvalid := 1
        FI
        IF j == lb
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF i &gt;= lb // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
IF imm8[6] // byte / word mask
    FOR i := 0 to UpperBound
        j := i*size
        IF IntRes2[i]
            dst[j+size-1:j] := (imm8[0] ? 0xFF : 0xFFFF)
        ELSE
            dst[j+size-1:j] := 0
        FI
    ENDFOR
ELSE // bit mask
    dst[UpperBound:0] := IntRes2[UpperBound:0]
    dst[127:UpperBound+1] := 0
FI

--------------------------------------------------------------------------------------------------------------

## PCMPESTRI - _mm_cmpestri

| PCMPESTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings in "a" and "b" with lengths "la" and "lb" using the control in "imm8", and store the
generated index in "dst".
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF i == la
            aInvalid := 1
        FI
        IF j == lb
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF i &gt;= lb // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
IF imm8[6] // most significant bit
    tmp := UpperBound
    dst := tmp
    DO WHILE ((tmp &gt;= 0) AND a[tmp] == 0)
        tmp := tmp - 1
        dst := tmp
    OD
ELSE // least significant bit
    tmp := 0
    dst := tmp
    DO WHILE ((tmp &lt;= UpperBound) AND a[tmp] == 0)
        tmp := tmp + 1
        dst := tmp
    OD
FI

--------------------------------------------------------------------------------------------------------------

## PCMPESTRI - _mm_cmpestrz

| PCMPESTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings in "a" and "b" with lengths "la" and "lb" using the control in "imm8", and returns 1 if
any character in "b" was null, and 0 otherwise.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
dst := (lb &lt;= UpperBound)

--------------------------------------------------------------------------------------------------------------

## PCMPESTRI - _mm_cmpestrc

| PCMPESTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings in "a" and "b" with lengths "la" and "lb" using the control in "imm8", and returns 1 if
the resulting mask was non-zero, and 0 otherwise.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF i == la
            aInvalid := 1
        FI
        IF j == lb
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF i &gt;= lb // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
dst := (IntRes2 != 0)

--------------------------------------------------------------------------------------------------------------

## PCMPESTRI - _mm_cmpestrs

| PCMPESTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings in "a" and "b" with lengths "la" and "lb" using the control in "imm8", and returns 1 if
any character in "a" was null, and 0 otherwise.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
dst := (la &lt;= UpperBound)

--------------------------------------------------------------------------------------------------------------

## PCMPESTRI - _mm_cmpestro

| PCMPESTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings in "a" and "b" with lengths "la" and "lb" using the control in "imm8", and returns bit
0 of the resulting bit mask.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF i == la
            aInvalid := 1
        FI
        IF j == lb
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF i &gt;= lb // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
dst := IntRes2[0]

--------------------------------------------------------------------------------------------------------------

## PCMPESTRI - _mm_cmpestra

| PCMPESTRI_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compare packed strings in "a" and "b" with lengths "la" and "lb" using the control in "imm8", and returns 1 if
"b" did not contain a null character and the resulting mask was zero, and 0 otherwise.
	[strcmp_note]

[algorithm]

size := (imm8[0] ? 16 : 8) // 8 or 16-bit characters
UpperBound := (128 / size) - 1
BoolRes := 0
// compare all characters
aInvalid := 0
bInvalid := 0
FOR i := 0 to UpperBound
    m := i*size
    FOR j := 0 to UpperBound
        n := j*size
        BoolRes.word[i].bit[j] := (a[m+size-1:m] == b[n+size-1:n]) ? 1 : 0
        
        // invalidate characters after EOS
        IF i == la
            aInvalid := 1
        FI
        IF j == lb
            bInvalid := 1
        FI
        
        // override comparisons for invalid characters
        CASE (imm8[3:2]) OF
        0:  // equal any
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        1:  // ranges
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            FI
        2:  // equal each
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        3:  // equal ordered
            IF (!aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 0
            ELSE IF (aInvalid &amp;&amp; !bInvalid)
                BoolRes.word[i].bit[j] := 1
            ELSE IF (aInvalid &amp;&amp; bInvalid)
                BoolRes.word[i].bit[j] := 1
            FI
        ESAC
    ENDFOR
ENDFOR
// aggregate results
CASE (imm8[3:2]) OF
0:  // equal any
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR BoolRes.word[i].bit[j]
        ENDFOR
    ENDFOR
1:  // ranges
    IntRes1 := 0
    FOR i := 0 to UpperBound
        FOR j := 0 to UpperBound
            IntRes1[i] := IntRes1[i] OR (BoolRes.word[i].bit[j] AND BoolRes.word[i].bit[j+1])
            j += 2
        ENDFOR
    ENDFOR
2:  // equal each
    IntRes1 := 0
    FOR i := 0 to UpperBound
        IntRes1[i] := BoolRes.word[i].bit[i]
    ENDFOR
3:  // equal ordered
    IntRes1 := (imm8[0] ? 0xFF : 0xFFFF)
    FOR i := 0 to UpperBound
        k := i
        FOR j := 0 to UpperBound-i
            IntRes1[i] := IntRes1[i] AND BoolRes.word[k].bit[j]
            k := k+1
        ENDFOR
    ENDFOR
ESAC
// optionally negate results
FOR i := 0 to UpperBound
    IF imm8[4]
        IF imm8[5] // only negate valid
            IF i &gt;= lb // invalid, don't negate
                IntRes2[i] := IntRes1[i]
            ELSE // valid, negate
                IntRes2[i] := -1 XOR IntRes1[i]
            FI
        ELSE // negate all
            IntRes2[i] := -1 XOR IntRes1[i]
        FI
    ELSE // don't negate
        IntRes2[i] := IntRes1[i]
    FI
ENDFOR
// output
dst := (IntRes2 == 0) AND (lb &gt; UpperBound)

--------------------------------------------------------------------------------------------------------------

## PCMPGTQ - _mm_cmpgt_epi64

| PCMPGTQ_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compare packed signed 64-bit integers in "a" and "b" for greater-than, and store the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := ( a[i+63:i] &gt; b[i+63:i] ) ? 0xFFFFFFFFFFFFFFFF : 0
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PABSB - _mm_abs_pi8

| PABSB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the absolute value of packed signed 8-bit integers in "a", and store the unsigned results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := ABS(Int(a[i+7:i]))
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PABSB - _mm_abs_epi8

| PABSB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the absolute value of packed signed 8-bit integers in "a", and store the unsigned results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    dst[i+7:i] := ABS(a[i+7:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PABSW - _mm_abs_pi16

| PABSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the absolute value of packed signed 16-bit integers in "a", and store the unsigned results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := ABS(Int(a[i+15:i]))
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PABSW - _mm_abs_epi16

| PABSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the absolute value of packed signed 16-bit integers in "a", and store the unsigned results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := ABS(a[i+15:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PABSD - _mm_abs_pi32

| PABSD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Compute the absolute value of packed signed 32-bit integers in "a", and store the unsigned results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*32
    dst[i+31:i] := ABS(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PABSD - _mm_abs_epi32

| PABSD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Compute the absolute value of packed signed 32-bit integers in "a", and store the unsigned results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := ABS(a[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSHUFB - _mm_shuffle_epi8

| PSHUFB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Shuffle packed 8-bit integers in "a" according to shuffle control mask in the corresponding 8-bit element of
"b", and store the results in "dst".

[algorithm]

FOR j := 0 to 15
    i := j*8
    IF b[i+7] == 1
        dst[i+7:i] := 0
    ELSE
        index[3:0] := b[i+3:i]
        dst[i+7:i] := a[index*8+7:index*8]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSHUFB - _mm_shuffle_pi8

| PSHUFB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Shuffle packed 8-bit integers in "a" according to shuffle control mask in the corresponding 8-bit element of
"b", and store the results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    IF b[i+7] == 1
        dst[i+7:i] := 0
    ELSE
        index[2:0] := b[i+2:i]
        dst[i+7:i] := a[index*8+7:index*8]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PALIGNR - _mm_alignr_epi8

| PALIGNR_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Concatenate 16-byte blocks in "a" and "b" into a 32-byte temporary result, shift the result right by "imm8"
bytes, and store the low 16 bytes in "dst".

[algorithm]

tmp[255:0] := ((a[127:0] &lt;&lt; 128)[255:0] OR b[127:0]) &gt;&gt; (imm8*8)
dst[127:0] := tmp[127:0]

--------------------------------------------------------------------------------------------------------------

## PALIGNR - _mm_alignr_pi8

| PALIGNR_MMXq_MMXq_IMMb

--------------------------------------------------------------------------------------------------------------
Concatenate 8-byte blocks in "a" and "b" into a 16-byte temporary result, shift the result right by "imm8"
bytes, and store the low 16 bytes in "dst".

[algorithm]

tmp[127:0] := ((a[63:0] &lt;&lt; 64)[127:0] OR b[63:0]) &gt;&gt; (imm8*8)
dst[63:0] := tmp[63:0]

--------------------------------------------------------------------------------------------------------------

## PHADDW - _mm_hadd_epi16

| PHADDW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in
"dst".

[algorithm]

dst[15:0] := a[31:16] + a[15:0]
dst[31:16] := a[63:48] + a[47:32]
dst[47:32] := a[95:80] + a[79:64]
dst[63:48] := a[127:112] + a[111:96]
dst[79:64] := b[31:16] + b[15:0]
dst[95:80] := b[63:48] + b[47:32]
dst[111:96] := b[95:80] + b[79:64]
dst[127:112] := b[127:112] + b[111:96]

--------------------------------------------------------------------------------------------------------------

## PHADDSW - _mm_hadds_epi16

| PHADDSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the signed
16-bit results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[31:16] + a[15:0])
dst[31:16] := Saturate16(a[63:48] + a[47:32])
dst[47:32] := Saturate16(a[95:80] + a[79:64])
dst[63:48] := Saturate16(a[127:112] + a[111:96])
dst[79:64] := Saturate16(b[31:16] + b[15:0])
dst[95:80] := Saturate16(b[63:48] + b[47:32])
dst[111:96] := Saturate16(b[95:80] + b[79:64])
dst[127:112] := Saturate16(b[127:112] + b[111:96])

--------------------------------------------------------------------------------------------------------------

## PHADDD - _mm_hadd_epi32

| PHADDD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in
"dst".

[algorithm]

dst[31:0] := a[63:32] + a[31:0]
dst[63:32] := a[127:96] + a[95:64]
dst[95:64] := b[63:32] + b[31:0]
dst[127:96] := b[127:96] + b[95:64]

--------------------------------------------------------------------------------------------------------------

## PHADDW - _mm_hadd_pi16

| PHADDW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in
"dst".

[algorithm]

dst[15:0] := a[31:16] + a[15:0]
dst[31:16] := a[63:48] + a[47:32]
dst[47:32] := b[31:16] + b[15:0]
dst[63:48] := b[63:48] + b[47:32]

--------------------------------------------------------------------------------------------------------------

## PHADDW - _mm_hadd_pi32

| PHADDW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in
"dst".

[algorithm]

dst[31:0] := a[63:32] + a[31:0]
dst[63:32] := b[63:32] + b[31:0]

--------------------------------------------------------------------------------------------------------------

## PHADDSW - _mm_hadds_pi16

| PHADDSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Horizontally add adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the signed
16-bit results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[31:16] + a[15:0])
dst[31:16] := Saturate16(a[63:48] + a[47:32])
dst[47:32] := Saturate16(b[31:16] + b[15:0])
dst[63:48] := Saturate16(b[63:48] + b[47:32])

--------------------------------------------------------------------------------------------------------------

## PHSUBW - _mm_hsub_epi16

| PHSUBW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in
"dst".

[algorithm]

dst[15:0] := a[15:0] - a[31:16]
dst[31:16] := a[47:32] - a[63:48]
dst[47:32] := a[79:64] - a[95:80]
dst[63:48] := a[111:96] - a[127:112]
dst[79:64] := b[15:0] - b[31:16]
dst[95:80] := b[47:32] - b[63:48]
dst[111:96] := b[79:64] - b[95:80]
dst[127:112] := b[111:96] - b[127:112]

--------------------------------------------------------------------------------------------------------------

## PHSUBSW - _mm_hsubs_epi16

| PHSUBSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the
signed 16-bit results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[15:0] - a[31:16])
dst[31:16] := Saturate16(a[47:32] - a[63:48])
dst[47:32] := Saturate16(a[79:64] - a[95:80])
dst[63:48] := Saturate16(a[111:96] - a[127:112])
dst[79:64] := Saturate16(b[15:0] - b[31:16])
dst[95:80] := Saturate16(b[47:32] - b[63:48])
dst[111:96] := Saturate16(b[79:64] - b[95:80])
dst[127:112] := Saturate16(b[111:96] - b[127:112])

--------------------------------------------------------------------------------------------------------------

## PHSUBD - _mm_hsub_epi32

| PHSUBD_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in
"dst".

[algorithm]

dst[31:0] := a[31:0] - a[63:32]
dst[63:32] := a[95:64] - a[127:96]
dst[95:64] := b[31:0] - b[63:32]
dst[127:96] := b[95:64] - b[127:96]

--------------------------------------------------------------------------------------------------------------

## PHSUBW - _mm_hsub_pi16

| PHSUBW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of 16-bit integers in "a" and "b", and pack the signed 16-bit results in
"dst".

[algorithm]

dst[15:0] := a[15:0] - a[31:16]
dst[31:16] := a[47:32] - a[63:48]
dst[47:32] := b[15:0] - b[31:16]
dst[63:48] := b[47:32] - b[63:48]

--------------------------------------------------------------------------------------------------------------

## PHSUBD - _mm_hsub_pi32

| PHSUBD_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of 32-bit integers in "a" and "b", and pack the signed 32-bit results in
"dst".

[algorithm]

dst[31:0] := a[31:0] - a[63:32]
dst[63:32] := b[31:0] - b[63:32]

--------------------------------------------------------------------------------------------------------------

## PHSUBSW - _mm_hsubs_pi16

| PHSUBSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Horizontally subtract adjacent pairs of signed 16-bit integers in "a" and "b" using saturation, and pack the
signed 16-bit results in "dst".

[algorithm]

dst[15:0] := Saturate16(a[15:0] - a[31:16])
dst[31:16] := Saturate16(a[47:32] - a[63:48])
dst[47:32] := Saturate16(b[15:0] - b[31:16])
dst[63:48] := Saturate16(b[47:32] - b[63:48])

--------------------------------------------------------------------------------------------------------------

## PMADDUBSW - _mm_maddubs_epi16

| PMADDUBSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Vertically multiply each unsigned 8-bit integer from "a" with the corresponding signed 8-bit integer from "b",
producing intermediate signed 16-bit integers. Horizontally add adjacent pairs of intermediate signed 16-bit
integers, and pack the saturated results in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    dst[i+15:i] := Saturate16( a[i+15:i+8]*b[i+15:i+8] + a[i+7:i]*b[i+7:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMADDUBSW - _mm_maddubs_pi16

| PMADDUBSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Vertically multiply each unsigned 8-bit integer from "a" with the corresponding signed 8-bit integer from "b",
producing intermediate signed 16-bit integers. Horizontally add adjacent pairs of intermediate signed 16-bit
integers, and pack the saturated results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    dst[i+15:i] := Saturate16( a[i+15:i+8]*b[i+15:i+8] + a[i+7:i]*b[i+7:i] )
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULHRSW - _mm_mulhrs_epi16

| PMULHRSW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers. Truncate
each intermediate integer to the 18 most significant bits, round by adding 1, and store bits [16:1] to "dst".

[algorithm]

FOR j := 0 to 7
    i := j*16
    tmp[31:0] := ((SignExtend32(a[i+15:i]) * SignExtend32(b[i+15:i])) &gt;&gt; 14) + 1
    dst[i+15:i] := tmp[16:1]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PMULHRSW - _mm_mulhrs_pi16

| PMULHRSW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Multiply packed signed 16-bit integers in "a" and "b", producing intermediate signed 32-bit integers. Truncate
each intermediate integer to the 18 most significant bits, round by adding 1, and store bits [16:1] to "dst".

[algorithm]

FOR j := 0 to 3
    i := j*16
    tmp[31:0] := ((SignExtend32(a[i+15:i]) * SignExtend32(b[i+15:i])) &gt;&gt; 14) + 1
    dst[i+15:i] := tmp[16:1]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSIGNB - _mm_sign_epi8

| PSIGNB_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Negate packed 8-bit integers in "a" when the corresponding signed 8-bit integer in "b" is negative, and store
the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.

[algorithm]

FOR j := 0 to 15
    i := j*8
    IF b[i+7:i] &lt; 0
        dst[i+7:i] := -(a[i+7:i])
    ELSE IF b[i+7:i] == 0
        dst[i+7:i] := 0
    ELSE
        dst[i+7:i] := a[i+7:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSIGNW - _mm_sign_epi16

| PSIGNW_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Negate packed 16-bit integers in "a" when the corresponding signed 16-bit integer in "b" is negative, and
store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.

[algorithm]

FOR j := 0 to 7
    i := j*16
    IF b[i+15:i] &lt; 0
        dst[i+15:i] := -(a[i+15:i])
    ELSE IF b[i+15:i] == 0
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := a[i+15:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSIGND - _mm_sign_epi32

| PSIGND_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Negate packed 32-bit integers in "a" when the corresponding signed 32-bit integer in "b" is negative, and
store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF b[i+31:i] &lt; 0
        dst[i+31:i] := -(a[i+31:i])
    ELSE IF b[i+31:i] == 0
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSIGNB - _mm_sign_pi8

| PSIGNB_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Negate packed 8-bit integers in "a" when the corresponding signed 8-bit integer in "b" is negative, and store
the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.

[algorithm]

FOR j := 0 to 7
    i := j*8
    IF b[i+7:i] &lt; 0
        dst[i+7:i] := -(a[i+7:i])
    ELSE IF b[i+7:i] == 0
        dst[i+7:i] := 0
    ELSE
        dst[i+7:i] := a[i+7:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSIGNW - _mm_sign_pi16

| PSIGNW_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Negate packed 16-bit integers in "a" when the corresponding signed 16-bit integer in "b" is negative, and
store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.

[algorithm]

FOR j := 0 to 3
    i := j*16
    IF b[i+15:i] &lt; 0
        dst[i+15:i] := -(a[i+15:i])
    ELSE IF b[i+15:i] == 0
        dst[i+15:i] := 0
    ELSE
        dst[i+15:i] := a[i+15:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## PSIGND - _mm_sign_pi32

| PSIGND_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Negate packed 32-bit integers in "a" when the corresponding signed 32-bit integer in "b" is negative, and
store the results in "dst". Element in "dst" are zeroed out when the corresponding element in "b" is zero.

[algorithm]

FOR j := 0 to 1
    i := j*32
    IF b[i+31:i] &lt; 0
        dst[i+31:i] := -(a[i+31:i])
    ELSE IF b[i+31:i] == 0
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := a[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------
