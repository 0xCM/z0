# I

## INCSSPD - _incsspd

| INCSSPD_GPR32u8

--------------------------------------------------------------------------------------------------------------
Increment the shadow stack pointer by 4 times the value specified in bits [7:0] of "a".

[algorithm]

SSP := SSP + a[7:0] * 4

--------------------------------------------------------------------------------------------------------------

## INCSSPQ - _incsspq

| INCSSPQ_GPR64u8

--------------------------------------------------------------------------------------------------------------
Increment the shadow stack pointer by 8 times the value specified in bits [7:0] of "a".

[algorithm]

SSP := SSP + a[7:0] * 8

--------------------------------------------------------------------------------------------------------------

## INCSSPD - _inc_ssp

| INCSSPD_GPR32u8

--------------------------------------------------------------------------------------------------------------
Increment the shadow stack pointer by 4 times the value specified in bits [7:0] of "a".

[algorithm]

SSP := SSP + a[7:0] * 4

--------------------------------------------------------------------------------------------------------------

## INVPCID - _invpcid

| INVPCID_GPR32_MEMdq

--------------------------------------------------------------------------------------------------------------
Invalidate mappings in the Translation Lookaside Buffers (TLBs) and paging-structure caches for the processor
context identifier (PCID) specified by "descriptor" based on the invalidation type specified in "type". 
	The
PCID "descriptor" is specified as a 16-byte memory operand (with no alignment restrictions) where bits [11:0]
specify the PCID, and bits [127:64] specify the linear address; bits [63:12] are reserved.
	The types supported
are:
		0) Individual-address invalidation: If "type" is 0, the logical processor invalidates mappings for a
single linear address and tagged with the PCID specified in "descriptor", except global translations. The
instruction may also invalidate global translations, mappings for other linear addresses, or mappings tagged
with other PCIDs.
		1) Single-context invalidation: If "type" is 1, the logical processor invalidates all
mappings tagged with the PCID specified in "descriptor" except global translations. In some cases, it may
invalidate mappings for other PCIDs as well.
		2) All-context invalidation: If "type" is 2, the logical
processor invalidates all mappings tagged with any PCID.
		3) All-context invalidation, retaining global
translations: If "type" is 3, the logical processor invalidates all mappings tagged with any PCID except global
translations, ignoring "descriptor". The instruction may also invalidate global translations as well.

[algorithm]

CASE type[1:0] OF
0: // individual-address invalidation retaining global translations
    OP_PCID := MEM[descriptor+11:descriptor]
    ADDR := MEM[descriptor+127:descriptor+64]
    BREAK
1: // single PCID invalidation retaining globals
    OP_PCID := MEM[descriptor+11:descriptor]
    // invalidate all mappings tagged with OP_PCID except global translations
    BREAK
2: // all PCID invalidation
    // invalidate all mappings tagged with any PCID
    BREAK
3: // all PCID invalidation retaining global translations
    // invalidate all mappings tagged with any PCID except global translations
    BREAK
ESAC

--------------------------------------------------------------------------------------------------------------

## INSERTPS - _mm_insert_ps

| INSERTPS_XMMps_XMMps_IMMb

--------------------------------------------------------------------------------------------------------------
Copy "a" to "tmp", then insert a single-precision (32-bit) floating-point element from "b" into "tmp" using
the control in "imm8". Store "tmp" to "dst" using the mask in "imm8" (elements are zeroed out when the
corresponding bit is set).

[algorithm]

tmp2[127:0] := a[127:0]
CASE (imm8[7:6]) OF
0: tmp1[31:0] := b[31:0]
1: tmp1[31:0] := b[63:32]
2: tmp1[31:0] := b[95:64]
3: tmp1[31:0] := b[127:96]
ESAC
CASE (imm8[5:4]) OF
0: tmp2[31:0] := tmp1[31:0]
1: tmp2[63:32] := tmp1[31:0]
2: tmp2[95:64] := tmp1[31:0]
3: tmp2[127:96] := tmp1[31:0]
ESAC
FOR j := 0 to 3
    i := j*32
    IF imm8[j%8]
        dst[i+31:i] := 0
    ELSE
        dst[i+31:i] := tmp2[i+31:i]
    FI
ENDFOR

--------------------------------------------------------------------------------------------------------------
