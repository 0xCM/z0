# F

## FXRSTOR - _fxrstor

| FXRSTOR_MEMmfpxenv

--------------------------------------------------------------------------------------------------------------
Reload the x87 FPU, MMX technology, XMM, and MXCSR registers from the 512-byte memory image at "mem_addr".
This data should have been written to memory previously using the FXSAVE instruction, and in the same format as
required by the operating mode. "mem_addr" must be aligned on a 16-byte boundary.

[algorithm]

state_x87_fpu_mmx_sse := fxrstor(MEM[mem_addr+512*8:mem_addr])

--------------------------------------------------------------------------------------------------------------

## FXRSTOR64 - _fxrstor64

| FXRSTOR64_MEMmfpxenv

--------------------------------------------------------------------------------------------------------------
Reload the x87 FPU, MMX technology, XMM, and MXCSR registers from the 512-byte memory image at "mem_addr".
This data should have been written to memory previously using the FXSAVE64 instruction, and in the same format
as required by the operating mode. "mem_addr" must be aligned on a 16-byte boundary.

[algorithm]

state_x87_fpu_mmx_sse := fxrstor64(MEM[mem_addr+512*8:mem_addr])

--------------------------------------------------------------------------------------------------------------

## FXSAVE - _fxsave

| FXSAVE_MEMmfpxenv

--------------------------------------------------------------------------------------------------------------
Save the current state of the x87 FPU, MMX technology, XMM, and MXCSR registers to a 512-byte memory location
at "mem_addr". The layout of the 512-byte region depends on the operating mode. Bytes [511:464] are available
for software use and will not be overwritten by the processor.

[algorithm]

MEM[mem_addr+512*8:mem_addr] := fxsave(state_x87_fpu_mmx_sse)

--------------------------------------------------------------------------------------------------------------

## FXSAVE64 - _fxsave64

| FXSAVE64_MEMmfpxenv

--------------------------------------------------------------------------------------------------------------
Save the current state of the x87 FPU, MMX technology, XMM, and MXCSR registers to a 512-byte memory location
at "mem_addr". The layout of the 512-byte region depends on the operating mode. Bytes [511:464] are available
for software use and will not be overwritten by the processor.

[algorithm]

MEM[mem_addr+512*8:mem_addr] := fxsave64(state_x87_fpu_mmx_sse)

--------------------------------------------------------------------------------------------------------------
