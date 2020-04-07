# Instruction Summaries

## mov

Copies an immediate value or the value in a general-purpose register, segment register, or memory
location (second operand) to a general-purpose register, segment register, or memory location. The
source and destination must be the same size (byte, word, doubleword, or quadword) and cannot both
be memory locations.

## movzx

MOVZX reg16, reg/mem8 0F B6 /r Move the contents of an 8-bit register or memory operand to a 16-bit register with zero-extension.
MOVZX reg32, reg/mem8 0F B6 /r Move the contents of an 8-bit register or memory operand to a 32-bit register with zero-extension.
MOVZX reg64, reg/mem8 0F B6 /r Move the contents of an 8-bit register or memory operand to a 64-bit register with zero-extension.
MOVZX reg32, reg/mem16 0F B7 /r Move the contents of a 16-bit register or memory operand to a 32-bit register with zero-extension.
MOVZX reg64, reg/mem16 0F B7 /r Move the contents of a 16-bit register or memory operand to a 64-bit register with zero-extension.

## Sources

* AMD documentation set
* Intel documetaiton set
