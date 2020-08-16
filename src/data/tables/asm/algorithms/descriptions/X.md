# X

## XABORT - _xabort

| XABORT_IMMb

--------------------------------------------------------------------------------------------------------------
Force an RTM abort. The EAX register is updated to reflect an XABORT instruction caused the abort, and the
"imm8" parameter will be provided in bits [31:24] of EAX.
	Following an RTM abort, the logical processor
resumes execution at the fallback address computed through the outermost XBEGIN instruction.

[algorithm]

IF RTM_ACTIVE == 0
    // nop
ELSE
    // restore architectural register state
    // discard memory updates performed in transaction
    // update EAX with status and imm8 value
    eax[31:24] := imm8[7:0]
    RTM_NEST_COUNT := 0
    RTM_ACTIVE := 0
    IF _64_BIT_MODE
        RIP := fallbackRIP
    ELSE
        EIP := fallbackEIP
    FI
FI

--------------------------------------------------------------------------------------------------------------

## XBEGIN - _xbegin

| XBEGIN_RELBRz

--------------------------------------------------------------------------------------------------------------
Specify the start of an RTM code region. 
	If the logical processor was not already in transactional
execution, then this call causes the logical processor to transition into transactional execution. 
	On an RTM
abort, the logical processor discards all architectural register and memory updates performed during the RTM
execution, restores architectural state, and starts execution beginning at the fallback address computed from
the outermost XBEGIN instruction. Return status of ~0 (0xFFFF) if continuing inside transaction; all other
codes are aborts.

[algorithm]

IF RTM_NEST_COUNT &lt; MAX_RTM_NEST_COUNT
    RTM_NEST_COUNT := RTM_NEST_COUNT + 1
    IF RTM_NEST_COUNT == 1
        IF _64_BIT_MODE
            fallbackRIP := RIP
        ELSE IF _32_BIT_MODE
            fallbackEIP := EIP
        FI
        
        RTM_ACTIVE := 1
        // enter RTM execution, record register state, start tracking memory state
    FI
ELSE
    // RTM abort (see _xabort)
FI

--------------------------------------------------------------------------------------------------------------

## XEND - _xend

| XEND

--------------------------------------------------------------------------------------------------------------
Specify the end of an RTM code region.
	If this corresponds to the outermost scope, the logical processor will
attempt to commit the logical processor state atomically. 
	If the commit fails, the logical processor will
perform an RTM abort.

[algorithm]

IF RTM_ACTIVE == 1
    RTM_NEST_COUNT := RTM_NEST_COUNT - 1
    IF RTM_NEST_COUNT == 0
        // try to commit transaction
        IF FAIL_TO_COMMIT_TRANSACTION
            // RTM abort (see _xabort)
        ELSE
            RTM_ACTIVE := 0
        FI
    FI
FI

--------------------------------------------------------------------------------------------------------------

## XTEST - _xtest

| XTEST

--------------------------------------------------------------------------------------------------------------
Query the transactional execution status, return 1 if inside a transactionally executing RTM or HLE region,
and return 0 otherwise.

[algorithm]

IF (RTM_ACTIVE == 1 OR HLE_ACTIVE == 1)
    dst := 1
ELSE
    dst := 0
FI

--------------------------------------------------------------------------------------------------------------

## XORPS - _mm_xor_ps

| XORPS_XMMxud_XMMxud

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of packed single-precision (32-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 3
    i := j*32
    dst[i+31:i] := a[i+31:i] XOR b[i+31:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XORPS - _mm_setzero_ps

| XORPS_XMMxud_XMMxud

--------------------------------------------------------------------------------------------------------------
Return vector of type __m128 with all elements set to zero.

[algorithm]

dst[MAX:0] := 0

--------------------------------------------------------------------------------------------------------------

## XORPD - _mm_xor_pd

| XORPD_XMMxuq_XMMxuq

--------------------------------------------------------------------------------------------------------------
Compute the bitwise XOR of packed double-precision (64-bit) floating-point elements in "a" and "b", and store
the results in "dst".

[algorithm]

FOR j := 0 to 1
    i := j*64
    dst[i+63:i] := a[i+63:i] XOR b[i+63:i]
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XORPD - _mm_setzero_pd

| XORPD_XMMxuq_XMMxuq

--------------------------------------------------------------------------------------------------------------
Return vector of type __m128d with all elements set to zero.

[algorithm]

dst[MAX:0] := 0

--------------------------------------------------------------------------------------------------------------

## XSUSLDTRK - _xsusldtrk

| XSUSLDTRK

--------------------------------------------------------------------------------------------------------------
Mark the start of a TSX (HLE/RTM) suspend load address tracking region. If this is used inside a transactional
region, subsequent loads are not added to the read set of the transaction. If this is used inside a suspend
load address tracking region it will cause transaction abort. If this is used outside of a transactional region
it behaves like a NOP.

[missing]

--------------------------------------------------------------------------------------------------------------

## XRESLDTRK - _xresldtrk

| XRESLDTRK

--------------------------------------------------------------------------------------------------------------
Mark the end of a TSX (HLE/RTM) suspend load address tracking region. If this is used inside a suspend load
address tracking region it will end the suspend region and all following load addresses will be added to the
transaction read set. If this is used inside an active transaction but not in a suspend region it will cause
transaction abort. If this is used outside of a transactional region it behaves like a NOP.

[missing]

--------------------------------------------------------------------------------------------------------------

## XGETBV - _xgetbv

| XGETBV

--------------------------------------------------------------------------------------------------------------
Copy up to 64-bits from the value of the extended control register (XCR) specified by "a" into "dst".
Currently only XFEATURE_ENABLED_MASK XCR is supported.

[algorithm]

dst[63:0] := XCR[a]

--------------------------------------------------------------------------------------------------------------

## XRSTOR - _xrstor

| XRSTOR_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial restore of the enabled processor states using the state information stored in memory
at "mem_addr". State is restored based on bits [62:0] in "rs_mask", "XCR0", and "mem_addr.HEADER.XSTATE_BV".
"mem_addr" must be aligned on a 64-byte boundary.

[algorithm]

st_mask := mem_addr.HEADER.XSTATE_BV[62:0]
FOR i := 0 to 62
    IF (rs_mask[i] AND XCR0[i])
        IF st_mask[i]
            CASE (i) OF
            0: ProcessorState[x87_FPU] := mem_addr.FPUSSESave_Area[FPU]
            1: ProcessorState[SSE] := mem_addr.FPUSSESaveArea[SSE]
            DEFAULT: ProcessorState[i] := mem_addr.Ext_Save_Area[i]
            ESAC
        ELSE
            // ProcessorExtendedState := Processor Supplied Values
            CASE (i) OF
            1: MXCSR := mem_addr.FPUSSESave_Area[SSE]
            ESAC
        FI
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XRSTOR64 - _xrstor64

| XRSTOR64_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial restore of the enabled processor states using the state information stored in memory
at "mem_addr". State is restored based on bits [62:0] in "rs_mask", "XCR0", and "mem_addr.HEADER.XSTATE_BV".
"mem_addr" must be aligned on a 64-byte boundary.

[algorithm]

st_mask := mem_addr.HEADER.XSTATE_BV[62:0]
FOR i := 0 to 62
    IF (rs_mask[i] AND XCR0[i])
        IF st_mask[i]
            CASE (i) OF
            0: ProcessorState[x87_FPU] := mem_addr.FPUSSESave_Area[FPU]
            1: ProcessorState[SSE] := mem_addr.FPUSSESaveArea[SSE]
            DEFAULT: ProcessorState[i] := mem_addr.Ext_Save_Area[i]
            ESAC
        ELSE
            // ProcessorExtendedState := Processor Supplied Values
            CASE (i) OF
            1: MXCSR := mem_addr.FPUSSESave_Area[SSE]
            ESAC
        FI
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XSAVE - _xsave

| XSAVE_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial save of the enabled processor states to memory at "mem_addr". State is saved based
on bits [62:0] in "save_mask" and "XCR0". "mem_addr" must be aligned on a 64-byte boundary.

[algorithm]

mask[62:0] := save_mask[62:0] AND XCR0[62:0]
FOR i := 0 to 62
    IF mask[i]
        CASE (i) OF
        0: mem_addr.FPUSSESave_Area[FPU] := ProcessorState[x87_FPU]
        1: mem_addr.FPUSSESaveArea[SSE] := ProcessorState[SSE]
        DEFAULT: mem_addr.Ext_Save_Area[i] := ProcessorState[i]
        ESAC
        mem_addr.HEADER.XSTATE_BV[i] := INIT_FUNCTION[i]
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XSAVE64 - _xsave64

| XSAVE64_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial save of the enabled processor states to memory at "mem_addr". State is saved based
on bits [62:0] in "save_mask" and "XCR0". "mem_addr" must be aligned on a 64-byte boundary.

[algorithm]

mask[62:0] := save_mask[62:0] AND XCR0[62:0]
FOR i := 0 to 62
    IF mask[i]
        CASE (i) OF
        0: mem_addr.FPUSSESave_Area[FPU] := ProcessorState[x87_FPU]
        1: mem_addr.FPUSSESaveArea[SSE] := ProcessorState[SSE]
        DEFAULT: mem_addr.Ext_Save_Area[i] := ProcessorState[i]
        ESAC
        mem_addr.HEADER.XSTATE_BV[i] := INIT_FUNCTION[i]
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XSAVEOPT - _xsaveopt

| XSAVEOPT_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial save of the enabled processor states to memory at "mem_addr". State is saved based
on bits [62:0] in "save_mask" and "XCR0". "mem_addr" must be aligned on a 64-byte boundary. The hardware may
optimize the manner in which data is saved. The performance of this instruction will be equal to or better than
using the XSAVE instruction.

[algorithm]

mask[62:0] := save_mask[62:0] AND XCR0[62:0]
FOR i := 0 to 62
    IF mask[i]
        CASE (i) OF
        0: mem_addr.FPUSSESave_Area[FPU] := ProcessorState[x87_FPU]
        1: mem_addr.FPUSSESaveArea[SSE] := ProcessorState[SSE]
        2: mem_addr.EXT_SAVE_Area2[YMM] := ProcessorState[YMM]
        DEFAULT: mem_addr.Ext_Save_Area[i] := ProcessorState[i]
        ESAC
        mem_addr.HEADER.XSTATE_BV[i] := INIT_FUNCTION[i]
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XSAVEOPT64 - _xsaveopt64

| XSAVEOPT64_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial save of the enabled processor states to memory at "mem_addr". State is saved based
on bits [62:0] in "save_mask" and "XCR0". "mem_addr" must be aligned on a 64-byte boundary. The hardware may
optimize the manner in which data is saved. The performance of this instruction will be equal to or better than
using the XSAVE64 instruction.

[algorithm]

mask[62:0] := save_mask[62:0] AND XCR0[62:0]
FOR i := 0 to 62
    IF mask[i]
        CASE (i) OF
        0: mem_addr.FPUSSESave_Area[FPU] := ProcessorState[x87_FPU]
        1: mem_addr.FPUSSESaveArea[SSE] := ProcessorState[SSE]
        2: mem_addr.EXT_SAVE_Area2[YMM] := ProcessorState[YMM]
        DEFAULT: mem_addr.Ext_Save_Area[i] := ProcessorState[i]
        ESAC
        mem_addr.HEADER.XSTATE_BV[i] := INIT_FUNCTION[i]
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XSETBV - _xsetbv

| XSETBV

--------------------------------------------------------------------------------------------------------------
Copy 64-bits from "val" to the extended control register (XCR) specified by "a". Currently only
XFEATURE_ENABLED_MASK XCR is supported.

[algorithm]

XCR[a] := val[63:0]

--------------------------------------------------------------------------------------------------------------

## XSAVEC - _xsavec

| XSAVEC_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial save of the enabled processor states to memory at "mem_addr"; xsavec differs from
xsave in that it uses compaction and that it may use init optimization. State is saved based on bits [62:0] in
"save_mask" and "XCR0". "mem_addr" must be aligned on a 64-byte boundary.

[algorithm]

mask[62:0] := save_mask[62:0] AND XCR0[62:0]
FOR i := 0 to 62
    IF mask[i]
        CASE (i) OF
        0: mem_addr.FPUSSESave_Area[FPU] := ProcessorState[x87_FPU]
        1: mem_addr.FPUSSESaveArea[SSE] := ProcessorState[SSE]
        DEFAULT: mem_addr.Ext_Save_Area[i] := ProcessorState[i]
        ESAC
        mem_addr.HEADER.XSTATE_BV[i] := INIT_FUNCTION[i]
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XSAVES - _xsaves

| XSAVES_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial save of the enabled processor states to memory at "mem_addr"; xsaves differs from
xsave in that it can save state components corresponding to bits set in IA32_XSS MSR and that it may use the
modified optimization. State is saved based on bits [62:0] in "save_mask" and "XCR0". "mem_addr" must be
aligned on a 64-byte boundary.

[algorithm]

mask[62:0] := save_mask[62:0] AND XCR0[62:0]
FOR i := 0 to 62
    IF mask[i]
        CASE (i) OF
        0: mem_addr.FPUSSESave_Area[FPU] := ProcessorState[x87_FPU]
        1: mem_addr.FPUSSESaveArea[SSE] := ProcessorState[SSE]
        DEFAULT: mem_addr.Ext_Save_Area[i] := ProcessorState[i]
        ESAC
        mem_addr.HEADER.XSTATE_BV[i] := INIT_FUNCTION[i]
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XSAVEC64 - _xsavec64

| XSAVEC64_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial save of the enabled processor states to memory at "mem_addr"; xsavec differs from
xsave in that it uses compaction and that it may use init optimization. State is saved based on bits [62:0] in
"save_mask" and "XCR0". "mem_addr" must be aligned on a 64-byte boundary.

[algorithm]

mask[62:0] := save_mask[62:0] AND XCR0[62:0]
FOR i := 0 to 62
    IF mask[i]
        CASE (i) OF
        0: mem_addr.FPUSSESave_Area[FPU] := ProcessorState[x87_FPU]
        1: mem_addr.FPUSSESaveArea[SSE] := ProcessorState[SSE]
        DEFAULT: mem_addr.Ext_Save_Area[i] := ProcessorState[i]
        ESAC
        mem_addr.HEADER.XSTATE_BV[i] := INIT_FUNCTION[i]
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XSAVEC64 - _xsaves64

| XSAVEC64_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial save of the enabled processor states to memory at "mem_addr"; xsaves differs from
xsave in that it can save state components corresponding to bits set in IA32_XSS MSR and that it may use the
modified optimization. State is saved based on bits [62:0] in "save_mask" and "XCR0". "mem_addr" must be
aligned on a 64-byte boundary.

[algorithm]

mask[62:0] := save_mask[62:0] AND XCR0[62:0]
FOR i := 0 to 62
    IF mask[i]
        CASE (i) OF
        0: mem_addr.FPUSSESave_Area[FPU] := ProcessorState[x87_FPU]
        1: mem_addr.FPUSSESaveArea[SSE] := ProcessorState[SSE]
        DEFAULT: mem_addr.Ext_Save_Area[i] := ProcessorState[i]
        ESAC
        mem_addr.HEADER.XSTATE_BV[i] := INIT_FUNCTION[i]
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------

## XRSTORS - _xrstors

| XRSTORS_MEMmxsave

--------------------------------------------------------------------------------------------------------------
Perform a full or partial restore of the enabled processor states using the state information stored in memory
at "mem_addr". xrstors differs from xrstor in that it can restore state components corresponding to bits set in
the IA32_XSS MSR; xrstors cannot restore from an xsave area in which the extended region is in the standard
form. State is restored based on bits [62:0] in "rs_mask", "XCR0", and "mem_addr.HEADER.XSTATE_BV". "mem_addr"
must be aligned on a 64-byte boundary.

[algorithm]

st_mask := mem_addr.HEADER.XSTATE_BV[62:0]
FOR i := 0 to 62
    IF (rs_mask[i] AND XCR0[i])
        IF st_mask[i]
            CASE (i) OF
            0: ProcessorState[x87_FPU] := mem_addr.FPUSSESave_Area[FPU]
            1: ProcessorState[SSE] := mem_addr.FPUSSESaveArea[SSE]
            DEFAULT: ProcessorState[i] := mem_addr.Ext_Save_Area[i]
            ESAC
        ELSE
            // ProcessorExtendedState := Processor Supplied Values
            CASE (i) OF
            1: MXCSR := mem_addr.FPUSSESave_Area[SSE]
            ESAC
        FI
    FI
    i := i + 1
ENDFOR

--------------------------------------------------------------------------------------------------------------
