# E

## EMMS - _m_empty

| EMMS

--------------------------------------------------------------------------------------------------------------
Empty the MMX state, which marks the x87 FPU registers as available for use by x87 instructions. This
instruction must be used at the end of all MMX technology procedures.

[missing]

--------------------------------------------------------------------------------------------------------------

## EMMS - _mm_empty

| EMMS

--------------------------------------------------------------------------------------------------------------
Empty the MMX state, which marks the x87 FPU registers as available for use by x87 instructions. This
instruction must be used at the end of all MMX technology procedures.

[missing]

--------------------------------------------------------------------------------------------------------------

## ENCLU - _enclu_u32

| ENCLU

--------------------------------------------------------------------------------------------------------------
Invoke the Intel SGX enclave user (non-privilege) leaf function specified by "a", and return the error code.
The "__data" array contains 3 32-bit elements that may act as input, output, or be unused, depending on the
semantics of the specified leaf function; these correspond to ebx, ecx, and edx.

[missing]

--------------------------------------------------------------------------------------------------------------

## ENCLS - _encls_u32

| ENCLS

--------------------------------------------------------------------------------------------------------------
Invoke the Intel SGX enclave system (privileged) leaf function specified by "a", and return the error code.
The "__data" array contains 3 32-bit elements that may act as input, output, or be unused, depending on the
semantics of the specified leaf function; these correspond to ebx, ecx, and edx.

[missing]

--------------------------------------------------------------------------------------------------------------

## ENCLV - _enclv_u32

| ENCLV

--------------------------------------------------------------------------------------------------------------
Invoke the Intel SGX enclave virtualized (VMM) leaf function specified by "a", and return the error code. The
"__data" array contains 3 32-bit elements that may act as input, output, or be unused, depending on the
semantics of the specified leaf function; these correspond to ebx, ecx, and edx.

[missing]

--------------------------------------------------------------------------------------------------------------

## EXTRACTPS - _mm_extract_ps

| EXTRACTPS_GPR32d_XMMdq_IMMb

--------------------------------------------------------------------------------------------------------------
Extract a single-precision (32-bit) floating-point element from "a", selected with "imm8", and store the
result in "dst".

[algorithm]

dst[31:0] := (a[127:0] &gt;&gt; (imm8[1:0] * 32))[31:0]

--------------------------------------------------------------------------------------------------------------
