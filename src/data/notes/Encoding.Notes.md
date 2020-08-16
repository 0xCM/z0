# LegacyPrefixes - Notes
-----------------------------------------------------
— BND prefix is encoded using F2H if the following conditions are true:
• CPUID.(EAX=07H, ECX=0):EBX.MPX[bit 14] is set.
• BNDCFGU.EN and/or IA32_BNDCFGS.EN is set.
• When the F2 prefix precedes a near CALL, a near RET, a near JMP, a short Jcc, or a near Jcc instruction
- In 64-bit mode, the CS, DS, ES, and SS segment overrides are ignored.

# Instruction Layout, Intel Vol2A Chapter 2

Instruction = [ Prefix(1..n) | OpCode | ModRM | SIB | Displacement | Immediate]

ModRM = [Mod:[7 6] | ROC:[5 4 3] | RM:[2 1 0] ]
SIB = [Scale:[7 6] | Index:[5 4 3] | Base:[2 1 0]

----------------------------
| FiedSeg |   |   |   |   |
| Prefix  | 0 | 1 | 2 | 3 |
| OpCode  | 1 | 2 | 3 |   |
| ModRM   | 0 | 1 |   |   |
| SIB     | 0 | 1 |   |   |
| Dx      | 0 | 1 | 2 | 4 |
| Imm     | 0 | 1 | 2 | 4 |

# ModR/M Byte Layout
-----------------------------------------------------
Mod[7:6] R[5:3] RM[2:0]


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


# AddressingForms32
# Notes
----------------------------------------------------------------------------
| Symbol   | Description                                                                           |
| [--][--] | A SIB follows the ModR/M byte.                                                        |
| disp32   | Denotes a 32-bit displacement that follows the ModR/M byte                            |
|          | (or the SIB byte if one is present) and that is added to the index.                   |
| disp8    | Denotes an 8-bit displacement that follows the ModR/M byte                            |
|          | (or the SIB byte if one is present) and that is sign-extended and added to the index. |


X0 := [AL | AX | EAX | MM0 | XMM0]
X1 := [CL | CX | ECX | MM1 | XMM1]
X2 := [DL | DX | EDX | MM2 | XMM2]
X3 := [BL | BX | EBX | MM3 | XMM3]
X4 := [AH | SP | ESP | MM4 | XMM4]
X5 := [CH | BP | EBP | MM5 | XMM5]
X6 := [DH | SI | ESI | MM6 | XMM6]
X7 := [BH | DI | EDI | MM7 | XMM7]


Y0 := [EAX | AX | AL | MM0 | XMM0]
Y1 := [ECX | CX | CL | MM  | XMM1]
Y2 := [EDX | DX | DL | MM2 | XMM2]
Y3 := [EBX | BX | BL | MM3 | XMM3]
Y4 := [ESP | SP | AH | MM4 | XMM4]
Y5 := [EBP | BP | CH | MM5 | XMM5]
Y6 := [ESI | SI | DH | MM6 | XMM6]
Y7 := [EDI | DI | BH | MM7 | XMM7]