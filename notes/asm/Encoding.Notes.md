# LegacyPrefixes - Notes
-----------------------------------------------------
— BND prefix is encoded using F2H if the following conditions are true:
• CPUID.(EAX=07H, ECX=0):EBX.MPX[bit 14] is set.
• BNDCFGU.EN and/or IA32_BNDCFGS.EN is set.
• When the F2 prefix precedes a near CALL, a near RET, a near JMP, a short Jcc, or a near Jcc instruction
- In 64-bit mode, the CS, DS, ES, and SS segment overrides are ignored.


So:

Example:

The instruction CMP(r/m8, r8) has op code {38 /r}

# Sib32
# Notes
------------------------------------------------------------------------------------------------------------
The [*] nomenclature means a disp32 with no base if the MOD is 00B. Otherwise, [*] means disp8 or disp32 + [EBP].

# This provides the following address modes:
------------------------------------------------------------------------------------------------------------
| MOD bits | Effective Address               |
| 00       | [scaled index] + disp32         |
| 01       | [scaled index] + disp8 + [EBP]  |
| 10       | [scaled index] + disp32 + [EBP] |


Y0 := [EAX | AX | AL | MM0 | XMM0]
Y1 := [ECX | CX | CL | MM  | XMM1]
Y2 := [EDX | DX | DL | MM2 | XMM2]
Y3 := [EBX | BX | BL | MM3 | XMM3]
Y4 := [ESP | SP | AH | MM4 | XMM4]
Y5 := [EBP | BP | CH | MM5 | XMM5]
Y6 := [ESI | SI | DH | MM6 | XMM6]
Y7 := [EDI | DI | BH | MM7 | XMM7]