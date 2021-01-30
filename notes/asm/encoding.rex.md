# REX Prefix

REX prefixes are instruction-prefix bytes used in 64-bit mode. They do the following:
* Specify GPRs and SSE registers.
* Specify 64-bit operand size.
* Specify extended control registers.

Not all instructions require a REX prefix in 64-bit mode.
* A prefix is necessary only if an instruction references one of the extended registers or uses a 64-bit operand.
* If a REX prefix is used when it has no meaning, it is ignored.
* Only one REX prefix is allowed per instruction.
* If used, the REX prefix byte must immediately precede the opcode byte or the escape opcode byte (0FH).
* When a REX prefix is used in conjunction with an instruction containing a mandatory prefix, the mandatory prefix must
  come before the REX so the REX prefix can be immediately preceding the opcode or the escape byte.

For example, CVTDQ2PD with a REX prefix should have REX placed between F3 and 0F E6. Other placements are ignored.

## 64-bit Mode Prefix Ordering

Instruction = [Prefix(1..n) | OpCode | ModRM | SIB | Disp | Imm]
ModRM = [ Mod:[7:6] | ROC:[5:3] | RM:[2:0] ]
SIB = [ Scale:[7:6] | Index:[5:3] | Base:[2:0]

----------------------------
| FiedSeg |   |   |   |   |
| Prefix  | 0 | 1 | 2 | 3 |
| OpCode  | 1 | 2 | 3 |   |
| ModRM   | 0 | 1 |   |   |
| SIB     | 0 | 1 |   |   |
| Disp    | 0 | 1 | 2 | 4 |
| Imm     | 0 | 1 | 2 | 4 |

InstructionLayout64 = LegacyPrefixes | RexPrefix | Opcode | ModRM | SIB | AddressDisp | Imm

LegacyPrefixes = LegacyGroup1 | LegacyGroup2 | LegacyGroup3 | LegacyGroup1

RexPrefix = 40h | 41h | 42h | 43h | 44h | 45h | 46h | 47h | 49h | 4a | 4b | 4c | 4d | 4e | 4f

OpCode = OneByteOpCode | TwoByteOpCode | ThreeByteOpCode

Disp = OneByteDisp | TwoByteDisp | FourByteDisp

Imm = Imm8 | Imm16 | Imm32

## Encoding

Intel 64 and IA-32 instruction formats specify up to three registers by using 3-bit fields in the encoding, depending on the format

* ModR/M: the reg and r/m fields of the ModR/M byte.
* ModR/M with SIB: the reg field of the ModR/M byte, the base and index fields of the SIB (scale, index, base) byte.
* Instructions without ModR/M: the reg field of the opcode.
* In 64-bit mode, these formats do not change. Bits needed to define fields in the 64-bit context are provided by the addition of REX prefixes.

REX prefixes are a set of 16 opcodes that span one row of the opcode map and occupy entries 40H to 4FH. These
opcodes represent valid instructions (INC or DEC) in IA-32 operating modes and in compatibility mode. In 64-bit
mode, the same opcodes represent the instruction prefix REX and are not treated as individual instructions.
The single-byte-opcode forms of the INC/DEC instructions are not available in 64-bit mode. INC/DEC functionality
is still available using ModR/M forms of the same instructions (opcodes FF/0 and FF/1).
See Table 2-4 for a summary of the REX prefix format. Figure 2-4 though Figure 2-7 show examples of REX prefix
fields in use. Some combinations of REX prefix fields are invalid. In such cases, the prefix is ignored. Some addi-
tional information follows:

* Setting REX.W can be used to determine the operand size but does not solely determine operand width. Like the 66H size prefix, 64-bit operand size override has no effect on byte-specific operations.
* For non-byte operations: if a 66H prefix is used with prefix (REX.W = 1), 66H is ignored.
* If a 66H override is used with REX and REX.W = 0, the operand size is 16 bits.
* REX.R modifies the ModR/M reg field when that field encodes a GPR, SSE, control or debug register. REX.R is ignored when ModR/M specifies other registers or defines an extended opcode.
* REX.X bit modifies the SIB index field.
* REX.B either modifies the base in the ModR/M r/m field or SIB base field; or it modifies the opcode reg field used for accessing GPRs.

RexBitField := DDDD.W.R.X.B
| FieldName | BitPosition | Definition                                                             |
| D         | 7:4         | 0100                                                                   |
| W         | 3           | 0 => Operand size determined by CS.D, 1 => 64 Bit Operand Size         |
| R         | 2           | Extension of the ModR/M reg field                                      |
| X         | 1           | Extension of the SIB index field                                       |
| B         | 0           | Extension of the ModR/M r/m field, SIB base field, or Opcode reg field |

D is an abbreviation for the invariant/constant bitstring 0100

## References

Intel Combined Reference, page 512