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

## ModR/M Byte Layout

Mod[7:6] R[5:3] RM[2:0]


## Table 2.2

Table 2-2. 32-Bit Addressing Forms with the ModR/M Byte

The Effective Address column lists 32 effective addresses that can be assigned to the first operand of an instruction
by using the Mod and R/M fields of the ModR/M byte. The first 24 options provide ways of specifying a memory location;
the last eight (Mod = 11B) provide ways of specifying general-purpose, MMX technology and XMM registers.

## Notation

| Symbol   | Description
| [--][--] | A SIB follows the ModR/M byte.
| disp32   | Denotes a 32-bit displacement that follows the ModR/M byte (or the SIB byte if one is present) and that is added to the index.
| disp8    | Denotes an 8-bit displacement that follows the ModR/M byte (or the SIB byte if one is present) and that is sign-extended and added to the index.

## Register Digits

[000] <=> [AL | AX | EAX | MM0 | XMM0]
[001] <=> [CL | CX | ECX | MM1 | XMM1]
[010] <=> [DL | DX | EDX | MM2 | XMM2]
[011] <=> [BL | BX | EBX | MM3 | XMM3]
[100] <=> [AH | SP | ESP | MM4 | XMM4]
[101] <=> [CH | BP | EBP | MM5 | XMM5]
[110] <=> [DH | SI | ESI | MM6 | XMM6]
[111] <=> [BH | DI | EDI | MM7 | XMM7]



## References

Intel Combined Reference, page 507