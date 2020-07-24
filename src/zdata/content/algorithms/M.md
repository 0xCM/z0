# M

## MULX - _mulx_u32

| MULX_VGPR32d_VGPR32d_MEMd

--------------------------------------------------------------------------------------------------------------
Multiply unsigned 32-bit integers "a" and "b", store the low 32-bits of the result in "dst", and store the
high 32-bits in "hi". This does not read or write arithmetic flags.

[algorithm]

dst[31:0] := (a * b)[31:0]
MEM[hi+31:hi] := (a * b)[63:32]

--------------------------------------------------------------------------------------------------------------

## MULX - _mulx_u64

| MULX_VGPR64q_VGPR64q_MEMq

--------------------------------------------------------------------------------------------------------------
Multiply unsigned 64-bit integers "a" and "b", store the low 64-bits of the result in "dst", and store the
high 64-bits in "hi". This does not read or write arithmetic flags.

[algorithm]

dst[63:0] := (a * b)[63:0]
MEM[hi+63:hi]  := (a * b)[127:64]

--------------------------------------------------------------------------------------------------------------

## MOVQ - _m_from_int64

| MOVQ_MMXq_GPR64

--------------------------------------------------------------------------------------------------------------
Copy 64-bit integer "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVQ - _m_to_int64

| MOVQ_GPR64_MMXq

--------------------------------------------------------------------------------------------------------------
Copy 64-bit integer "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVD - _m_from_int

| MOVD_MMXq_GPR32

--------------------------------------------------------------------------------------------------------------
Copy 32-bit integer "a" to the lower elements of "dst", and zero the upper element of "dst".

[algorithm]

dst[31:0] := a[31:0]
dst[63:32] := 0

--------------------------------------------------------------------------------------------------------------

## MOVD - _m_to_int

| MOVD_GPR32_MMXd

--------------------------------------------------------------------------------------------------------------
Copy the lower 32-bit integer in "a" to "dst".

[algorithm]

dst[31:0] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## MOVD - _mm_cvtsi32_si64

| MOVD_MMXq_GPR32

--------------------------------------------------------------------------------------------------------------
Copy 32-bit integer "a" to the lower elements of "dst", and zero the upper element of "dst".

[algorithm]

dst[31:0] := a[31:0]
dst[63:32] := 0

--------------------------------------------------------------------------------------------------------------

## MOVD - _mm_cvtsi64_si32

| MOVD_GPR32_MMXd

--------------------------------------------------------------------------------------------------------------
Copy the lower 32-bit integer in "a" to "dst".

[algorithm]

dst[31:0] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_cvtm64_si64

| MOVQ_GPR64_MMXq

--------------------------------------------------------------------------------------------------------------
Copy 64-bit integer "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_cvtsi64_m64

| MOVQ_MMXq_GPR64

--------------------------------------------------------------------------------------------------------------
Copy 64-bit integer "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MONITOR - _mm_monitor

| MONITOR

--------------------------------------------------------------------------------------------------------------
Arm address monitoring hardware using the address specified in "p". A store to an address within the specified
address range triggers the monitoring hardware. Specify optional extensions in "extensions", and optional hints
in "hints".

[missing]

--------------------------------------------------------------------------------------------------------------

## MWAIT - _mm_mwait

| MWAIT

--------------------------------------------------------------------------------------------------------------
Hint to the processor that it can enter an implementation-dependent-optimized state while waiting for an event
or store operation to the address range specified by MONITOR.

[missing]

--------------------------------------------------------------------------------------------------------------

## MOVBE - _loadbe_i16

| MOVBE_GPRv_MEMv

--------------------------------------------------------------------------------------------------------------
Load 16 bits from memory, perform a byte swap operation, and store the result in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*8
    dst[i+7:i] := MEM[ptr+15-i:ptr+8-i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MOVBE - _loadbe_i32

| MOVBE_GPRv_MEMv

--------------------------------------------------------------------------------------------------------------
Load 32 bits from memory, perform a byte swap operation, and store the result in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*8
    dst[i+7:i] := MEM[ptr+31-i:ptr+24-i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MOVBE - _loadbe_i64

| MOVBE_GPRv_MEMv

--------------------------------------------------------------------------------------------------------------
Load 64 bits from memory, perform a byte swap operation, and store the result in "dst".

[algorithm]

FOR j := 0 to 7
    i := j*8
    dst[i+7:i] := MEM[ptr+63-i:ptr+56-i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MOVBE - _storebe_i16

| MOVBE_MEMv_GPRv

--------------------------------------------------------------------------------------------------------------
Perform a bit swap operation of the 16 bits in "data", and store the results to memory.

[algorithm]

FOR j := 0 to 1
    i := j*8
    MEM[ptr+i+7:ptr+i] := data[15-i:8-i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MOVBE - _storebe_i32

| MOVBE_MEMv_GPRv

--------------------------------------------------------------------------------------------------------------
Perform a bit swap operation of the 32 bits in "data", and store the results to memory.

[algorithm]

addr := MEM[ptr]
FOR j := 0 to 3
    i := j*8
    MEM[ptr+i+7:ptr+i] := data[31-i:24-i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MOVBE - _storebe_i64

| MOVBE_MEMv_GPRv

--------------------------------------------------------------------------------------------------------------
Perform a bit swap operation of the 64 bits in "data", and store the results to memory.

[algorithm]

addr := MEM[ptr]
FOR j := 0 to 7
    i := j*8
    MEM[ptr+i+7:ptr+i] := data[63-i:56-i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MOVDIR64B - _movdir64b

| MOVDIR64B_GPRa_MEM

--------------------------------------------------------------------------------------------------------------
Move 64-byte (512-bit) value using direct store from source memory address "src" to destination memory address
"dst".

[algorithm]

MEM[dst+511:dst] := MEM[src+511:src]

--------------------------------------------------------------------------------------------------------------

## MOVDIRI - _directstoreu_u64

| MOVDIRI_MEMu64_GPR64u64

--------------------------------------------------------------------------------------------------------------
Store 64-bit integer from "val" into memory using direct store.

[algorithm]

MEM[dst+63:dst] := val[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVDIRI - _directstoreu_u32

| MOVDIRI_MEMu32_GPR32u32

--------------------------------------------------------------------------------------------------------------
Store 32-bit integer from "val" into memory using direct store.

[algorithm]

MEM[dst+31:dst] := val[31:0]

--------------------------------------------------------------------------------------------------------------

## MOVNTQ - _mm_stream_pi

| MOVNTQ_MEMq_MMXq

--------------------------------------------------------------------------------------------------------------
Store 64-bits of integer data from "a" into memory using a non-temporal memory hint.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MASKMOVQ - _mm_maskmove_si64

| MASKMOVQ_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Conditionally store 8-bit integer elements from "a" into memory using "mask" (elements are not stored when the
highest bit is not set in the corresponding element) and a non-temporal memory hint.

[algorithm]

FOR j := 0 to 7
    i := j*8
    IF mask[i+7]
        MEM[mem_addr+i+7:mem_addr+i] := a[i+7:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MASKMOVQ - _m_maskmovq

| MASKMOVQ_MMXq_MMXq

--------------------------------------------------------------------------------------------------------------
Conditionally store 8-bit integer elements from "a" into memory using "mask" (elements are not stored when the
highest bit is not set in the corresponding element).

[algorithm]

FOR j := 0 to 7
    i := j*8
    IF mask[i+7]
        MEM[mem_addr+i+7:mem_addr+i] := a[i+7:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MULSS - _mm_mul_ss

| MULSS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Multiply the lower single-precision (32-bit) floating-point element in "a" and "b", store the result in the
lower element of "dst", and copy the upper 3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := a[31:0] * b[31:0]
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## MULPS - _mm_mul_ps

| MULPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Multiply packed single-precision (32-bit) floating-point elements in "a" and "b", and store the results in
"dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[i+31:i] * b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MINSS - _mm_min_ss

| MINSS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b", store the minimum value in
the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper element of "dst".

[algorithm]

dst[31:0] := MIN(a[31:0], b[31:0])
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## MINPS - _mm_min_ps

| MINPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b", and store packed minimum
values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := MIN(a[i+31:i], b[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MAXSS - _mm_max_ss

| MAXSS_XMMss_XMMss

--------------------------------------------------------------------------------------------------------------
Compare the lower single-precision (32-bit) floating-point elements in "a" and "b", store the maximum value in
the lower element of "dst", and copy the upper 3 packed elements from "a" to the upper element of "dst".

[algorithm]

dst[31:0] := MAX(a[31:0], b[31:0])
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## MAXPS - _mm_max_ps

| MAXPS_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Compare packed single-precision (32-bit) floating-point elements in "a" and "b", and store packed maximum
values in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := MAX(a[i+31:i], b[i+31:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MOVSS - _mm_cvtss_f32

| MOVSS_MEMss_XMMss

--------------------------------------------------------------------------------------------------------------
Copy the lower single-precision (32-bit) floating-point element of "a" to "dst".

[algorithm]

dst[31:0] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## MOVHPS - _mm_loadh_pi

| MOVHPS_XMMq_MEMq

--------------------------------------------------------------------------------------------------------------
Load 2 single-precision (32-bit) floating-point elements from memory into the upper 2 elements of "dst", and
copy the lower 2 elements from "a" to "dst". "mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[31:0] := a[31:0]
dst[63:32] := a[63:32]
dst[95:64] := MEM[mem_addr+31:mem_addr]
dst[127:96] := MEM[mem_addr+63:mem_addr+32]

--------------------------------------------------------------------------------------------------------------

## MOVLPS - _mm_loadl_pi

| MOVLPS_XMMq_MEMq

--------------------------------------------------------------------------------------------------------------
Load 2 single-precision (32-bit) floating-point elements from memory into the lower 2 elements of "dst", and
copy the upper 2 elements from "a" to "dst". "mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[31:0] := MEM[mem_addr+31:mem_addr]
dst[63:32] := MEM[mem_addr+63:mem_addr+32]
dst[95:64] := a[95:64]
dst[127:96] := a[127:96]

--------------------------------------------------------------------------------------------------------------

## MOVSS - _mm_load_ss

| MOVSS_XMMdq_MEMss

--------------------------------------------------------------------------------------------------------------
Load a single-precision (32-bit) floating-point element from memory into the lower of "dst", and zero the
upper 3 elements. "mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[31:0] := MEM[mem_addr+31:mem_addr]
dst[127:32] := 0

--------------------------------------------------------------------------------------------------------------

## MOVAPS - _mm_load_ps

| MOVAPS_XMMps_MEMps

--------------------------------------------------------------------------------------------------------------
Load 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from memory into
"dst".
	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[127:0] := MEM[mem_addr+127:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVUPS - _mm_loadu_ps

| MOVUPS_XMMps_MEMps

--------------------------------------------------------------------------------------------------------------
Load 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from memory into
"dst".
	"mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[127:0] := MEM[mem_addr+127:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVNTPS - _mm_stream_ps

| MOVNTPS_MEMdq_XMMps

--------------------------------------------------------------------------------------------------------------
Store 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from "a" into memory
using a non-temporal memory hint.
	"mem_addr" must be aligned on a 16-byte boundary or a general-protection
exception may be generated.

[algorithm]

MEM[mem_addr+127:mem_addr] := a[127:0]

--------------------------------------------------------------------------------------------------------------

## MOVHPS - _mm_storeh_pi

| MOVHPS_MEMq_XMMps

--------------------------------------------------------------------------------------------------------------
Store the upper 2 single-precision (32-bit) floating-point elements from "a" into memory.

[algorithm]

MEM[mem_addr+31:mem_addr] := a[95:64]
MEM[mem_addr+63:mem_addr+32] := a[127:96]

--------------------------------------------------------------------------------------------------------------

## MOVLPS - _mm_storel_pi

| MOVLPS_MEMq_XMMps

--------------------------------------------------------------------------------------------------------------
Store the lower 2 single-precision (32-bit) floating-point elements from "a" into memory.

[algorithm]

MEM[mem_addr+31:mem_addr] := a[31:0]
MEM[mem_addr+63:mem_addr+32] := a[63:32]

--------------------------------------------------------------------------------------------------------------

## MOVSS - _mm_store_ss

| MOVSS_MEMss_XMMss

--------------------------------------------------------------------------------------------------------------
Store the lower single-precision (32-bit) floating-point element from "a" into memory. "mem_addr" does not
need to be aligned on any particular boundary.

[algorithm]

MEM[mem_addr+31:mem_addr] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## MOVAPS - _mm_store_ps

| MOVAPS_MEMps_XMMps

--------------------------------------------------------------------------------------------------------------
Store 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from "a" into
memory.
	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+127:mem_addr] := a[127:0]

--------------------------------------------------------------------------------------------------------------

## MOVUPS - _mm_storeu_ps

| MOVUPS_MEMps_XMMps

--------------------------------------------------------------------------------------------------------------
Store 128-bits (composed of 4 packed single-precision (32-bit) floating-point elements) from "a" into
memory.
	"mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

MEM[mem_addr+127:mem_addr] := a[127:0]

--------------------------------------------------------------------------------------------------------------

## MOVUPS - _mm_storer_ps

| MOVUPS_MEMps_XMMps

--------------------------------------------------------------------------------------------------------------
Store 4 single-precision (32-bit) floating-point elements from "a" into memory in reverse order.
	"mem_addr"
must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+31:mem_addr] := a[127:96]
MEM[mem_addr+63:mem_addr+32] := a[95:64]
MEM[mem_addr+95:mem_addr+64] := a[63:32]
MEM[mem_addr+127:mem_addr+96] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## MOVSS - _mm_move_ss

| MOVSS_XMMss_XMMss_0F10

--------------------------------------------------------------------------------------------------------------
Move the lower single-precision (32-bit) floating-point element from "b" to the lower element of "dst", and
copy the upper 3 packed elements from "a" to the upper elements of "dst".

[algorithm]

dst[31:0] := b[31:0]
dst[127:32] := a[127:32]

--------------------------------------------------------------------------------------------------------------

## MOVHLPS - _mm_movehl_ps

| MOVHLPS_XMMq_XMMq

--------------------------------------------------------------------------------------------------------------
Move the upper 2 single-precision (32-bit) floating-point elements from "b" to the lower 2 elements of "dst",
and copy the upper 2 elements from "a" to the upper 2 elements of "dst".

[algorithm]

dst[31:0] := b[95:64]
dst[63:32] := b[127:96]
dst[95:64] := a[95:64]
dst[127:96] := a[127:96]

--------------------------------------------------------------------------------------------------------------

## MOVLHPS - _mm_movelh_ps

| MOVLHPS_XMMq_XMMq

--------------------------------------------------------------------------------------------------------------
Move the lower 2 single-precision (32-bit) floating-point elements from "b" to the upper 2 elements of "dst",
and copy the lower 2 elements from "a" to the lower 2 elements of "dst".

[algorithm]

dst[31:0] := a[31:0]
dst[63:32] := a[63:32]
dst[95:64] := b[31:0]
dst[127:96] := b[63:32]

--------------------------------------------------------------------------------------------------------------

## MOVMSKPS - _mm_movemask_ps

| MOVMSKPS_GPR32_XMMps

--------------------------------------------------------------------------------------------------------------
Set each bit of mask "dst" based on the most significant bit of the corresponding packed single-precision
(32-bit) floating-point element in "a".

[algorithm]

FOR j := 0 to 3
    i := j*32
    IF a[i+31]
        dst[j] := 1
    ELSE
        dst[j] := 0
    FI
ENDFOR
dst[MAX:4] := 0

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_loadu_si64

| MOVQ_XMMdq_MEMq_0F6E

--------------------------------------------------------------------------------------------------------------
Load unaligned 64-bit integer from memory into the first element of "dst".

[algorithm]

dst[63:0] := MEM[mem_addr+63:mem_addr]
dst[MAX:64] := 0

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_storeu_si64

| MOVQ_MEMq_XMMq_0F7E

--------------------------------------------------------------------------------------------------------------
Store 64-bit integer from the first element of "a" into memory. "mem_addr" does not need to be aligned on any
particular boundary.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVD - _mm_loadu_si32

| MOVD_XMMdq_MEMd

--------------------------------------------------------------------------------------------------------------
Load unaligned 32-bit integer from memory into the first element of "dst".

[algorithm]

dst[31:0] := MEM[mem_addr+31:mem_addr]
dst[MAX:32] := 0

--------------------------------------------------------------------------------------------------------------

## MOVD - _mm_storeu_si32

| MOVD_MEMd_XMMd

--------------------------------------------------------------------------------------------------------------
Store 32-bit integer from the first element of "a" into memory. "mem_addr" does not need to be aligned on any
particular boundary.

[algorithm]

MEM[mem_addr+31:mem_addr] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## MFENCE - _mm_mfence

| MFENCE

--------------------------------------------------------------------------------------------------------------
Perform a serializing operation on all load-from-memory and store-to-memory instructions that were issued
prior to this instruction. Guarantees that every memory access that precedes, in program order, the memory
fence instruction is globally visible before any memory instruction which follows the fence in program order.

[missing]

--------------------------------------------------------------------------------------------------------------

## MOVD - _mm_cvtsi32_si128

| MOVD_XMMdq_GPR32

--------------------------------------------------------------------------------------------------------------
Copy 32-bit integer "a" to the lower elements of "dst", and zero the upper elements of "dst".

[algorithm]

dst[31:0] := a[31:0]
dst[127:32] := 0

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_cvtsi64_si128

| MOVQ_XMMdq_GPR64

--------------------------------------------------------------------------------------------------------------
Copy 64-bit integer "a" to the lower element of "dst", and zero the upper element.

[algorithm]

dst[63:0] := a[63:0]
dst[127:64] := 0

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_cvtsi64x_si128

| MOVQ_XMMdq_GPR64

--------------------------------------------------------------------------------------------------------------
Copy 64-bit integer "a" to the lower element of "dst", and zero the upper element.

[algorithm]

dst[63:0] := a[63:0]
dst[127:64] := 0

--------------------------------------------------------------------------------------------------------------

## MOVD - _mm_cvtsi128_si32

| MOVD_GPR32_XMMd

--------------------------------------------------------------------------------------------------------------
Copy the lower 32-bit integer in "a" to "dst".

[algorithm]

dst[31:0] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_cvtsi128_si64

| MOVQ_GPR64_XMMq

--------------------------------------------------------------------------------------------------------------
Copy the lower 64-bit integer in "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_cvtsi128_si64x

| MOVQ_GPR64_XMMq

--------------------------------------------------------------------------------------------------------------
Copy the lower 64-bit integer in "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_loadl_epi64

| MOVQ_XMMdq_MEMq_0F7E

--------------------------------------------------------------------------------------------------------------
Load 64-bit integer from memory into the first element of "dst".

[algorithm]

dst[63:0] := MEM[mem_addr+63:mem_addr]
dst[MAX:64] := 0

--------------------------------------------------------------------------------------------------------------

## MOVDQA - _mm_load_si128

| MOVDQA_XMMdq_MEMdq

--------------------------------------------------------------------------------------------------------------
Load 128-bits of integer data from memory into "dst". 
	"mem_addr" must be aligned on a 16-byte boundary or a
general-protection exception may be generated.

[algorithm]

dst[127:0] := MEM[mem_addr+127:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVDQU - _mm_loadu_si128

| MOVDQU_XMMdq_MEMdq

--------------------------------------------------------------------------------------------------------------
Load 128-bits of integer data from memory into "dst".
	"mem_addr" does not need to be aligned on any
particular boundary.

[algorithm]

dst[127:0] := MEM[mem_addr+127:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MASKMOVDQU - _mm_maskmoveu_si128

| MASKMOVDQU_XMMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Conditionally store 8-bit integer elements from "a" into memory using "mask" (elements are not stored when the
highest bit is not set in the corresponding element) and a non-temporal memory hint. "mem_addr" does not need
to be aligned on any particular boundary.

[algorithm]

FOR j := 0 to 15
    i := j*8
    IF mask[i+7]
        MEM[mem_addr+i+7:mem_addr+i] := a[i+7:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MOVDQA - _mm_store_si128

| MOVDQA_MEMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Store 128-bits of integer data from "a" into memory. 
	"mem_addr" must be aligned on a 16-byte boundary or a
general-protection exception may be generated.

[algorithm]

MEM[mem_addr+127:mem_addr] := a[127:0]

--------------------------------------------------------------------------------------------------------------

## MOVDQU - _mm_storeu_si128

| MOVDQU_MEMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Store 128-bits of integer data from "a" into memory.
	"mem_addr" does not need to be aligned on any particular
boundary.

[algorithm]

MEM[mem_addr+127:mem_addr] := a[127:0]

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_storel_epi64

| MOVQ_MEMq_XMMq_0F7E

--------------------------------------------------------------------------------------------------------------
Store 64-bit integer from the first element of "a" into memory.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVNTDQ - _mm_stream_si128

| MOVNTDQ_MEMdq_XMMdq

--------------------------------------------------------------------------------------------------------------
Store 128-bits of integer data from "a" into memory using a non-temporal memory hint. 
	"mem_addr" must be
aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+127:mem_addr] := a[127:0]

--------------------------------------------------------------------------------------------------------------

## MOVNTI - _mm_stream_si32

| MOVNTI_MEMd_GPR32

--------------------------------------------------------------------------------------------------------------
Store 32-bit integer "a" into memory using a non-temporal hint to minimize cache pollution. If the cache line
containing address "mem_addr" is already in the cache, the cache will be updated.

[algorithm]

MEM[mem_addr+31:mem_addr] := a[31:0]

--------------------------------------------------------------------------------------------------------------

## MOVNTI - _mm_stream_si64

| MOVNTI_MEMq_GPR64

--------------------------------------------------------------------------------------------------------------
Store 64-bit integer "a" into memory using a non-temporal hint to minimize cache pollution. If the cache line
containing address "mem_addr" is already in the cache, the cache will be updated.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVDQ2Q - _mm_movepi64_pi64

| MOVDQ2Q_MMXq_XMMq

--------------------------------------------------------------------------------------------------------------
Copy the lower 64-bit integer in "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVQ2DQ - _mm_movpi64_epi64

| MOVQ2DQ_XMMdq_MMXq

--------------------------------------------------------------------------------------------------------------
Copy the 64-bit integer "a" to the lower element of "dst", and zero the upper element.

[algorithm]

dst[63:0] := a[63:0]
dst[127:64] := 0

--------------------------------------------------------------------------------------------------------------

## MOVQ - _mm_move_epi64

| MOVQ_XMMdq_XMMq_0F7E

--------------------------------------------------------------------------------------------------------------
Copy the lower 64-bit integer in "a" to the lower element of "dst", and zero the upper element.

[algorithm]

dst[63:0] := a[63:0]
dst[127:64] := 0

--------------------------------------------------------------------------------------------------------------

## MAXSD - _mm_max_sd

| MAXSD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b", store the maximum value in
the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := MAX(a[63:0], b[63:0])
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## MAXPD - _mm_max_pd

| MAXPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b", and store packed maximum
values in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := MAX(a[i+63:i], b[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MINSD - _mm_min_sd

| MINSD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Compare the lower double-precision (64-bit) floating-point elements in "a" and "b", store the minimum value in
the lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := MIN(a[63:0], b[63:0])
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## MINPD - _mm_min_pd

| MINPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Compare packed double-precision (64-bit) floating-point elements in "a" and "b", and store packed minimum
values in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := MIN(a[i+63:i], b[i+63:i])
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MULSD - _mm_mul_sd

| MULSD_XMMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Multiply the lower double-precision (64-bit) floating-point element in "a" and "b", store the result in the
lower element of "dst", and copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := a[63:0] * b[63:0]
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## MULPD - _mm_mul_pd

| MULPD_XMMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Multiply packed double-precision (64-bit) floating-point elements in "a" and "b", and store the results in
"dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[i+63:i] * b[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## MOVSD - _mm_cvtsd_f64

| MOVSD_XMM_MEMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Copy the lower double-precision (64-bit) floating-point element of "a" to "dst".

[algorithm]

dst[63:0] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVAPD - _mm_load_pd

| MOVAPD_XMMpd_MEMpd

--------------------------------------------------------------------------------------------------------------
Load 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from memory into
"dst".
	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[127:0] := MEM[mem_addr+127:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVAPD - _mm_load1_pd

| MOVAPD_XMMpd_MEMpd

--------------------------------------------------------------------------------------------------------------
Load a double-precision (64-bit) floating-point element from memory into both elements of "dst".

[algorithm]

dst[63:0] := MEM[mem_addr+63:mem_addr]
dst[127:64] := MEM[mem_addr+63:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVAPD - _mm_load_pd1

| MOVAPD_XMMpd_MEMpd

--------------------------------------------------------------------------------------------------------------
Load a double-precision (64-bit) floating-point element from memory into both elements of "dst".

[algorithm]

dst[63:0] := MEM[mem_addr+63:mem_addr]
dst[127:64] := MEM[mem_addr+63:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVAPD - _mm_loadr_pd

| MOVAPD_XMMpd_MEMpd

--------------------------------------------------------------------------------------------------------------
Load 2 double-precision (64-bit) floating-point elements from memory into "dst" in reverse order. mem_addr
must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[63:0] := MEM[mem_addr+127:mem_addr+64]
dst[127:64] := MEM[mem_addr+63:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVUPD - _mm_loadu_pd

| MOVUPD_XMMpd_MEMpd

--------------------------------------------------------------------------------------------------------------
Load 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from memory into
"dst".
	"mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[127:0] := MEM[mem_addr+127:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVSD - _mm_load_sd

| MOVSD_XMM_XMMdq_MEMsd

--------------------------------------------------------------------------------------------------------------
Load a double-precision (64-bit) floating-point element from memory into the lower of "dst", and zero the
upper element. "mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[63:0] := MEM[mem_addr+63:mem_addr]
dst[127:64] := 0

--------------------------------------------------------------------------------------------------------------

## MOVHPD - _mm_loadh_pd

| MOVHPD_XMMsd_MEMq

--------------------------------------------------------------------------------------------------------------
Load a double-precision (64-bit) floating-point element from memory into the upper element of "dst", and copy
the lower element from "a" to "dst". "mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[63:0] := a[63:0]
dst[127:64] := MEM[mem_addr+63:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVLPD - _mm_loadl_pd

| MOVLPD_XMMsd_MEMq

--------------------------------------------------------------------------------------------------------------
Load a double-precision (64-bit) floating-point element from memory into the lower element of "dst", and copy
the upper element from "a" to "dst". "mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

dst[63:0] := MEM[mem_addr+63:mem_addr]
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## MOVNTPD - _mm_stream_pd

| MOVNTPD_MEMdq_XMMpd

--------------------------------------------------------------------------------------------------------------
Store 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from "a" into memory
using a non-temporal memory hint.
	"mem_addr" must be aligned on a 16-byte boundary or a general-protection
exception may be generated.

[algorithm]

MEM[mem_addr+127:mem_addr] := a[127:0]

--------------------------------------------------------------------------------------------------------------

## MOVSD - _mm_store_sd

| MOVSD_XMM_MEMsd_XMMsd

--------------------------------------------------------------------------------------------------------------
Store the lower double-precision (64-bit) floating-point element from "a" into memory. "mem_addr" does not
need to be aligned on any particular boundary.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVAPD - _mm_store_pd

| MOVAPD_MEMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Store 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from "a" into
memory.
	"mem_addr" must be aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

MEM[mem_addr+127:mem_addr] := a[127:0]

--------------------------------------------------------------------------------------------------------------

## MOVUPD - _mm_storeu_pd

| MOVUPD_MEMpd_XMMpd

--------------------------------------------------------------------------------------------------------------
Store 128-bits (composed of 2 packed double-precision (64-bit) floating-point elements) from "a" into
memory.
	"mem_addr" does not need to be aligned on any particular boundary.

[algorithm]

MEM[mem_addr+127:mem_addr] := a[127:0]

--------------------------------------------------------------------------------------------------------------

## MOVHPD - _mm_storeh_pd

| MOVHPD_MEMq_XMMsd

--------------------------------------------------------------------------------------------------------------
Store the upper double-precision (64-bit) floating-point element from "a" into memory.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## MOVLPD - _mm_storel_pd

| MOVLPD_MEMq_XMMsd

--------------------------------------------------------------------------------------------------------------
Store the lower double-precision (64-bit) floating-point element from "a" into memory.

[algorithm]

MEM[mem_addr+63:mem_addr] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVMSKPD - _mm_movemask_pd

| MOVMSKPD_GPR32_XMMpd

--------------------------------------------------------------------------------------------------------------
Set each bit of mask "dst" based on the most significant bit of the corresponding packed double-precision
(64-bit) floating-point element in "a".

[algorithm]

FOR j := 0 to 1
    i := j*64
    IF a[i+63]
        dst[j] := 1
    ELSE
        dst[j] := 0
    FI
ENDFOR
dst[MAX:2] := 0

--------------------------------------------------------------------------------------------------------------

## MOVSD - _mm_move_sd

| MOVSD_XMM_XMMsd_XMMsd_0F10

--------------------------------------------------------------------------------------------------------------
Move the lower double-precision (64-bit) floating-point element from "b" to the lower element of "dst", and
copy the upper element from "a" to the upper element of "dst".

[algorithm]

dst[63:0] := b[63:0]
dst[127:64] := a[127:64]

--------------------------------------------------------------------------------------------------------------

## MOVDDUP - _mm_movedup_pd

| MOVDDUP_XMMdq_XMMq

--------------------------------------------------------------------------------------------------------------
Duplicate the low double-precision (64-bit) floating-point element from "a", and store the results in "dst".

[algorithm]

dst[63:0] := a[63:0]
dst[127:64] := a[63:0]

--------------------------------------------------------------------------------------------------------------

## MOVDDUP - _mm_loaddup_pd

| MOVDDUP_XMMdq_MEMq

--------------------------------------------------------------------------------------------------------------
Load a double-precision (64-bit) floating-point element from memory into both elements of "dst".

[algorithm]

dst[63:0] := MEM[mem_addr+63:mem_addr]
dst[127:64] := MEM[mem_addr+63:mem_addr]

--------------------------------------------------------------------------------------------------------------

## MOVSHDUP - _mm_movehdup_ps

| MOVSHDUP_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Duplicate odd-indexed single-precision (32-bit) floating-point elements from "a", and store the results in
"dst".

[algorithm]

dst[31:0] := a[63:32] 
dst[63:32] := a[63:32]
dst[95:64] := a[127:96] 
dst[127:96] := a[127:96]

--------------------------------------------------------------------------------------------------------------

## MOVSLDUP - _mm_moveldup_ps

| MOVSLDUP_XMMps_XMMps

--------------------------------------------------------------------------------------------------------------
Duplicate even-indexed single-precision (32-bit) floating-point elements from "a", and store the results in
"dst".

[algorithm]

dst[31:0] := a[31:0] 
dst[63:32] := a[31:0]
dst[95:64] := a[95:64] 
dst[127:96] := a[95:64]

--------------------------------------------------------------------------------------------------------------

## MPSADBW - _mm_mpsadbw_epu8

| MPSADBW_XMMdq_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Compute the sum of absolute differences (SADs) of quadruplets of unsigned 8-bit integers in "a" compared to
those in "b", and store the 16-bit results in "dst".
	Eight SADs are performed using one quadruplet from "b"
and eight quadruplets from "a". One quadruplet is selected from "b" starting at on the offset specified in
"imm8". Eight quadruplets are formed from sequential 8-bit integers selected from "a" starting at the offset
specified in "imm8".

[algorithm]

DEFINE MPSADBW(a[127:0], b[127:0], imm8[2:0]) {
    a_offset := imm8[2]*32
    b_offset := imm8[1:0]*32
    FOR j := 0 to 7
        i := j*8
        k := a_offset+i
        l := b_offset
        tmp[i*2+15:i*2] := ABS(Signed(a[k+7:k] - b[l+7:l])) + ABS(Signed(a[k+15:k+8] - b[l+15:l+8])) + \
                           ABS(Signed(a[k+23:k+16] - b[l+23:l+16])) + ABS(Signed(a[k+31:k+24] - b[l+31:l+24]))
    ENDFOR
    RETURN tmp[127:0]
}
dst[127:0] := MPSADBW(a[127:0], b[127:0], imm8[2:0])

--------------------------------------------------------------------------------------------------------------

## MOVNTDQA - _mm_stream_load_si128

| MOVNTDQA_XMMdq_MEMdq

--------------------------------------------------------------------------------------------------------------
Load 128-bits of integer data from memory into "dst" using a non-temporal memory hint.
	"mem_addr" must be
aligned on a 16-byte boundary or a general-protection exception may be generated.

[algorithm]

dst[127:0] := MEM[mem_addr+127:mem_addr]

--------------------------------------------------------------------------------------------------------------
