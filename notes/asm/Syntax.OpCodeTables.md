# OpCode Map Description

Tables in this appendix list opcodes of instructions (including required instruction prefixes, opcode extensions in
associated ModR/M byte). Blank cells in the tables indicate opcodes that are reserved or undefined. Cells marked
“Reserved-NOP” are also reserved but may behave as NOP on certain processors. Software should not use opcodes
corresponding blank cells or cells marked “Reserved-NOP” nor depend on the current behavior of those opcodes.
The opcode map tables are organized by hex values of the upper and lower 4 bits of an opcode byte. For 1-byte
encodings (Table A-2), use the four high-order bits of an opcode to index a row of the opcode table; use the four
low-order bits to index a column of the table. For 2-byte opcodes beginning with 0FH (Table A-3), skip any instruc-
tion prefixes, the 0FH byte (0FH may be preceded by 66H, F2H, or F3H) and use the upper and lower 4-bit values
of the next opcode byte to index table rows and columns. Similarly, for 3-byte opcodes beginning with 0F38H or
0F3AH (Table A-4), skip any instruction prefixes, 0F38H or 0F3AH and use the upper and lower 4-bit values of the
third opcode byte to index table rows and columns. See Section A.2.4, “Opcode Look-up Examples for One, Two,
and Three-Byte Opcodes.”

When a ModR/M byte provides opcode extensions, this information qualifies opcode execution. For information on
how an opcode extension in the ModR/M byte modifies the opcode map in Table A-2 and Table A-3, see Section A.4.
The escape (ESC) opcode tables for floating point instructions identify the eight high order bits of opcodes at the
top of each page. See Section A.5. If the accompanying ModR/M byte is in the range of 00H-BFH, bits 3-5 (the top
row of the third table on each page) along with the reg bits of ModR/M determine the opcode. ModR/M bytes
outside the range of 00H-BFH are mapped by the bottom two tables on each page of the section.

Operands are identified by a two-character code of the form Zz. The first character, an uppercase letter, specifies
the addressing method; the second character, a lowercase letter, specifies the type of operand.

# One-byte Opcode Map: (00H — F7H)
-----------------------------------------------------------------------------------
| * | 0      | 1      | 2      | 3      | 4      | 5       | 6        | 7         |
| 0 | ADD    | ADD    | ADD    | ADD    | ADD    | ADD     | PUSH     | POP       |
| 0 | Eb, Gb | Ev, Gv | Gb, Eb | Gv, Ev | AL, Ib | rAX, Iz | ES^{i64} | ES^{i64}  |
| 1 | ADC    | ADC    | ADC    | ADC    | ADC    | ADC     | PUSH     | Pop       |
| 1 | Eb, Gb | Ev, Gv | Gb, Eb | Gv, Ev | AL, Ib | rAX, Iz | SS^{i64} | SS^{i64}  |
| 2 | AND    | AND    | AND    | AND    | AND    | AND     | SEG=ES   | DAA^{i64} |
| 2 | Eb, Gb | Ev, Gv | Gb, Eb | Gv, Ev | AL, Ib | rAX, Iz | (Prefix) |           |
| 3 | XOR    | XOR    | XOR    | XOR    | XOR    | XOR     | SEG=SS   | AAA^{i64} |
| 3 | Eb, Gb | Ev, Gv | Gb, Eb | Gv, Ev | AL, Ib | rAX, Iz | (Prefix) |           |

| 4  | INC i64 general register / REX o64 Prefixes
| eAX
| REX
| eCX
| REX.B
| eDX
| REX.X
| eBX
| REX.XB
| eSP
| REX.R
| eBP
| REX.RB
| eSI
| REX.RX
| eDI
| REX.RXB
| 5  | PUSH d64 general register
| rAX/r8 rCX/r9 rDX/r10 rBX/r11 rSP/r12 rBP/r13 rSI/r14 rDI/r15
| 6  | PUSHA i64 /
| PUSHAD i64
| POPA i64 /
| POPAD i64
| BOUND i64
| Gv, Ma
| ARPL i64
| Ew, Gw
| MOVSXD o64
| Gv, Ev
| SEG=FS
| (Prefix)
| SEG=GS
| (Prefix)
| Operand
| Size
| (Prefix)
| Address
| Size
| (Prefix)
| 7  | Jcc f64 , Jb - Short-displacement jump on condition
| O NO B/NAE/C NB/AE/NC Z/E NZ/NE BE/NA NBE/A
| 8  | Immediate Grp 1 1A TEST XCHG
| Eb, Ib Ev, Iz Eb, Ib i64 Ev, Ib Eb, Gb Ev, Gv Eb, Gb Ev, Gv
| 9  | NOP
| PAUSE(F3)
| XCHG r8, rAX
| XCHG word, double-word or quad-word register with rAX
| rCX/r9 rDX/r10 rBX/r11 rSP/r12 rBP/r13 rSI/r14 rDI/r15
| A  | MOV MOVS/B
| Yb, Xb
| MOVS/W/D/Q
| Yv, Xv
| CMPS/B
| Xb, Yb
| CMPS/W/D
| Xv, Yv
| AL, Ob rAX, Ov Ob, AL Ov, rAX
| B  | MOV immediate byte into byte register
| AL/R8L, Ib CL/R9L, Ib DL/R10L, Ib BL/R11L, Ib AH/R12L, Ib CH/R13L, Ib DH/R14L, Ib BH/R15L, Ib
| C  | Shift Grp 2 1A near RET f64
| Iw
| near RET f64 LES i64
| Gz, Mp
| VEX+2byte
| LDS i64
| Gz, Mp
| VEX+1byte
| Grp 11 1A - MOV
| Eb, Ib Ev, Ib Eb, Ib Ev, Iz
| D  | Shift Grp 2 1A AAM i64
| Ib
| AAD i64
| Ib
| XLAT/
| XLATB
| Eb, 1 Ev, 1 Eb, CL Ev, CL
| E  | LOOPNE f64 /
| LOOPNZ f64
| Jb
| LOOPE f64 /
| LOOPZ f64
| Jb
| LOOP f64
| Jb
| JrCXZ f64 /
| Jb
| IN OUT
| AL, Ib eAX, Ib Ib, AL Ib, eAX
| F  | LOCK
| (Prefix)
| INT1 REPNE
| XACQUIRE
| (Prefix)
| REP/REPE
| XRELEASE
| (Prefix)
| HLT CMC Unary Grp 3 1A
| Eb Ev