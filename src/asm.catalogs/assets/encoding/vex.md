# VEX Prefix, AMD Vol4.1.2

Layout

[XOP | RXB.map_select | W.vvvv.L.pp | Opcode]


XOP := encoding escape prefix
RXB := 3-bit field representing R, X, B bit values
08  := 5-bit map_select field
W   := W-bit
L   := L-bit
PP  := pp-field

* Example

sig:=VPCMOV ymm1, ymm2, ymm3/mem256, ymm4
opcode:=A2 /r ib

8F RXB.08 0.src.1.00 A2 /r ib
XOP | RXB | map_select | W | vvvv | L.pp | Opcode
8F  | RXB | 08         | 0 | src  | 1.00 | A2 /r ib

## Two-Operand Instructions

Two-operand instructions use ModRM-based operand assignment. For most instructions, the first
operand is the destination, selected by the ModRM.reg field, and the second operand is either a register
or a memory source, selected by the ModRM.r/m field.

The destination register is selected by ModRM.reg. The size of the destination register is determined
by VEX.L. The source is either a YMM/XMM register or a memory location specified by ModRM.r/m
Because this instruction converts packed doubleword integers to double-precision floating-point
values, the source data size is smaller than the destination data size.

VEX.vvvv is not used and must be set to 1111b.

## Three-Operand Instructions

These extended instructions have two source operands and a destination operand.
VPROTB is an example of a three-operand XOP instruction.
There are versions of the instruction for variable-count rotation and for fixed-count rotation.
VPROTB dest, src, variable-count
VPROTB dest, src, fixed-count