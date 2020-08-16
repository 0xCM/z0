# MOVZX - Move with Zero-Extend

## Encoding
-----------------------------------------------------------------------------------------------------------------------
| Op/En | Operand 1     | Operand 2     | Operand 3 | Operand 4 |
| RM    | ModRM:reg (w) | ModRM:r/m (r) | NA        | NA        |

## Operation

DEST ← ZeroExtend(SRC);

## Description

Copies the contents of the source operand (register or memory location) to the destination operand (register) and zero 
extends the value. The size of the converted value depends on the operand-size attribute.

In 64-bit mode, the instruction’s default operation size is 32 bits. Use of the REX.R prefix permits access to additional 
registers (R8-R15). Use of the REX.W prefix promotes operation to 64 bit operands. See the summary chart at the 
beginning of this section for encoding data and limits.