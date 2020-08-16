# AND - Logical And

## Encoding
----------------------------------------------------------------------------------------------------------------------------
| Op/En | Operand 1        | Operand 2     | Operand 3 | Operand 4 |
| RM    | ModRM:reg (r, w) | ModRM:r/m (r) | NA        | NA        |
| MR    | ModRM:r/m (r, w) | ModRM:reg (r) | NA        | NA        |
| MI    | ModRM:r/m (r, w) | imm8/16/32    | NA        | NA        |
| I     | AL/AX/EAX/RAX    | imm8/16/32    | NA        | NA        |

## Description
----------------------------------------------------------------------------------------------------------------------------
Performs a bitwise AND operation on the destination (first) and source (second) operands and stores the result in the 
destination operand location. The source operand can be an immediate, a register, or a memory location; the destination 
operand can be a register or a memory location. (However, two memory operands cannot be used in one instruction.) Each bit of 
the result is set to 1 if both corresponding bits of the first and second operands are 1; otherwise, it is set to 0.

This instruction can be used with a LOCK prefix to allow the it to be executed atomically.

In 64-bit mode, the instruction’s default operation size is 32 bits. Using a REX prefix in the form of REX.R permits access 
to additional registers (R8-R15). Using a REX prefix in the form of REX.W promotes operation to 64 bits. See the summary 
chart at the beginning of this section for encoding data and limits.

## Operation
----------------------------------------------------------------------------------------------------------------------------
 DEST ← DEST AND SRC;

## Flags
----------------------------------------------------------------------------------------------------------------------------
The OF and CF flags are cleared; the SF, ZF, and PF flags are set according to the result. The state of the AF flag is undefined.