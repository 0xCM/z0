# EFLAGS Condition Codes Encoding Notes
---------------------------------------------------
| Code   | Description
| ttt0   | Tests the condition
| ttn1   | Tests the negated condition

1-byte primary opcodes => the tttn field is located in bits 3, 2, 1, and 0 of the opcode byte.
2-byte primary opcodes => the tttn field is located in bits 3, 2, 1, and 0 of the second opcode byte.