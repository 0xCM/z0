# Encoding

* <https://pyokagan.name/blog/2019-09-20-x86encoding/>
* <https://sandpile.org/>
* <https://cs61.seas.harvard.edu/site/2018/Asm1/>
* <https://stackoverflow.com/questions/15017659/how-to-read-the-intel-opcode-notation>
* <https://stackoverflow.com/questions/34058101/referencing-the-contents-of-a-memory-location-x86-addressing-modes>
* <https://stackoverflow.com/questions/27936196/a-couple-of-questions-about-base-indexscale-disp>
* <https://stackoverflow.com/questions/27466597/how-to-fix-x86-64-memory-offsets-gas>

## LegacyPrefixes
— BND prefix is encoded using F2H if the following conditions are true:
    • CPUID.(EAX=07H, ECX=0):EBX.MPX[bit 14] is set.
    • BNDCFGU.EN and/or IA32_BNDCFGS.EN is set.
    • When the F2 prefix precedes a near CALL, a near RET, a near JMP, a short Jcc, or a near Jcc instruction
- In 64-bit mode, the CS, DS, ES, and SS segment overrides are ignored.

## 64-bit Mode Prefix Ordering

Instruction = [Prefix(1..n) | OpCode | ModRM | SIB | Disp | Imm]
ModRM = [ Mod[7:6] | R[5:3] | RM[2:0] ]
SIB = [ Scale:[7:6] | Index:[5:3] | Base:[2:0] ]
REX = [ [0100] | W:4 | R:3 | X:2 | B:1 ]

----------------------------
| FieldSeg  |   |   |   |   |
| Prefix    | 0 | 1 | 2 | 3 |
| OpCode    | 1 | 2 | 3 |   |
| ModRM     | 0 | 1 |   |   |
| SIB       | 0 | 1 |   |   |
| Disp      | 0 | 1 | 2 | 4 |
| Imm       | 0 | 1 | 2 | 4 |

Layout64 = LegacyPrefixes | RexPrefix | Opcode | ModRM | SIB | AddressDisp | Imm

LegacyPrefixes = LegacyGroup1 | LegacyGroup2 | LegacyGroup3 | LegacyGroup1

RexPrefix = 40h | 41h | 42h | 43h | 44h | 45h | 46h | 47h | 49h | 4a | 4b | 4c | 4d | 4e | 4f

OpCode = OneByteOpCode | TwoByteOpCode | ThreeByteOpCode

Disp = OneByteDisp | TwoByteDisp | FourByteDisp

Imm = Imm8 | Imm16 | Imm32

# The ModRM Byte


Many instructions that refer to an operand in memory have an addressing-form specifier byte (called the ModR/M
byte) following the primary opcode. The ModR/M byte contains three fields of information:

* The mod field combines with the r/m field to form 32 possible values: eight registers and 24 addressing modes.
* The reg/opcode field specifies either a register number or three more bits of opcode information. The purpose of the reg/opcode field is specified in the primary opcode.
* The r/m field can specify a register as an operand or it can be combined with the mod field to encode an addressing mode. Sometimes, certain combinations of the mod field and the r/m field are used to express opcode information for some instructions.

Certain encodings of the ModR/M byte require a second addressing byte (the SIB byte). The base-plus-index and scale-plus-index forms of 32-bit addressing require the SIB byte. The SIB byte includes the following fields:
• The scale field specifies the scale factor.
• The index field specifies the register number of the index register.
• The base field specifies the register number of the base register.
See Section 2.1.5 for the encodings of the ModR/M and SIB bytes.

## REX Prefix

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

## Register Digits

[000] <=> [AL | AX | EAX | MM0 | XMM0]
[001] <=> [CL | CX | ECX | MM1 | XMM1]
[010] <=> [DL | DX | EDX | MM2 | XMM2]
[011] <=> [BL | BX | EBX | MM3 | XMM3]
[100] <=> [AH | SP | ESP | MM4 | XMM4]
[101] <=> [CH | BP | EBP | MM5 | XMM5]
[110] <=> [DH | SI | ESI | MM6 | XMM6]
[111] <=> [BH | DI | EDI | MM7 | XMM7]


Example:

The instruction CMP(r/m8, r8) has op code {38 /r}

## Addressing


## RIP register usage

Taken from <https://stackoverflow.com/questions/42215105/understanding-rip-register-in-intel-assembly>


Example for accessing locals relative to `rbp:

```asm
push rbp                  ; save rbp
mov rbp,rsp               ; rbp = pointer to return address (8 bytes)
sub rsp,64                ; reserve 64 bytes for local variables
mov rax,[rbp+8]           ; rax = the last stack-passed qword parameter (if any)
mov rdx,[rbp]             ; rdx = return address
mov rcx,[rbp-8]           ; rcx = first qword local variable (this is undefined now)
mov r8, [rbp-16]          ; r8  = second qword local variable (this is undefined now)
.
.
mov rsp,rbp
pop rbp
ret
```

## RIP-relative addressing (ATT syntax)

x86-64 code often refers to globals using %rip-relative addressing: a global variable named a is referenced as a(%rip) rather than a.

This style of reference supports position-independent code (PIC), a security feature. It specifically supports
position-independent executables (PIEs), which are programs that work independently of where their code is loaded into memory.

To run a conventional program, the operating system loads the program’s instructions into memory at a fixed address that’s the
same every time, then starts executing the program at its first instruction. This works great, and runs the program in
a predictable execution environment (the addresses of functions and global variables are the same every time). Unfortunately,
the very predictability of this environment makes the program easier to attack.

In a position-independent executable, the operating system loads the program at varying locations: every time it runs,
the program’s functions and global variables have different addresses. This makes the program harder to attack (though not impossible).

Program startup performance matters, so the operating system doesn’t recompile the program with different addresses each time.
Instead, the compiler does most of the work in advance by using relative addressing.

When the operating system loads a PIE, it picks a starting point and loads all instructions and globals relative to that starting point.
The PIE’s instructions never refer to global variables using direct addressing: you’ll never see movl global_int, %eax. Globals are
referenced relatively instead, using deltas relative to the next %rip: movl global_int(%rip), %eax.

These relative addresses work great independent of starting point! For instance, consider an instruction located at
(starting-point + 0x80) that loads a variable g located at (starting-point + 0x1000) into %rax. In a non-PIE, the instruction might be
written movq 0x400080, %rax (in compiler output, movq g, %rax); but this relies on g having a fixed address.
In a PIE, the instruction might be written movq 0xf80(%rip), %rax (in compiler output, movq g(%rip), %rax),
which works out beautifully no matter the starting point.

| If the starting point is… | The instruction is at… | g is at… | With delta… |
| 0x400000                  | 0x400080               | 0x401000 | 0xF80       |
| 0x404000                  | 0x404080               | 0x405000 | 0xF80       |
| 0x4003F0                  | 0x400470               | 0x4013F0 | 0xF80       |

# Effective Operand and Address Size Attributes; Table 3-3 Intel Vol1
-------------------------------------------------------------------------------------------------------------------
| D Flag in Code Segment Descriptor | 0  | 0  | 0  | 0  | 1  | 1  | 1  | 1  |
| Operand-Size Prefix 66H           | N  | N  | Y  | Y  | N  | N  | Y  | Y  |
| Address-Size Prefix 67H           | N  | Y  | N  | Y  | N  | Y  | N  | Y  |
| Effective Operand Size            | 16 | 16 | 32 | 32 | 32 | 32 | 16 | 16 |
| Effective Address Size            | 16 | 32 | 16 | 32 | 32 | 16 | 32 | 16 |
## References

Intel Combined Reference, page 512