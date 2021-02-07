# SHR — Shift

## Legend

* Not the same form of division as IDIV; rounding is toward negative infinity.
** In 64-bit mode, r/m8 can not be encoded to access the following byte registers if a REX prefix is used: AH, BH, CH, DH
*** The 8086 does not mask the shift count. However, all other IA-32 processors (starting with the Intel 286 processor)
do mask the shift count to 5 bits, resulting in a maximum count of 31. This masking is done in all operating modes
(including the virtual-8086 mode) to reduce the maximum execution time of the instructions.