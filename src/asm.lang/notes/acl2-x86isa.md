# ACL2:x86isa

Sources: <http://github/acl2/books/projects/x86isa>, <https://www.cs.utexas.edu/users/moore/acl2/manuals/current/manual/?topic=ACL2____X86ISA>


## Symbols

E := general-purpose register or memory operand specified by the ModRM.r/m field
G := general-purpose register specified by the ModRM.reg field
rAX := AL/AX/EAX/RAX, depending on the operand size
I := immediate data

## X86-add/adc/sub/sbb/or/and/xor/cmp/test-e-g

Operand Fetch and Execute for ADD, ADC, SUB, SBB, OR, AND, XOR, CMP, TEST: Addressing Mode = (E, G)

### Signature
(x86-add/adc/sub/sbb/or/and/xor/cmp/test-e-g
     operation proc-mode start-rip temp-rip
     prefixes rex-byte opcode modr/m sib x86)

  →
x86
Returns
x86 — Type (x86p x86), given (x86p x86).

Op/En = MR: [OP R/M, REG] or [OP E, G]
Where:
    E is the destination operand and G is the source operand.

### Encoding

[OP R/M, REG] Flags Affected
00, 01: ADD c p a z s o
08, 09: OR p z s (o and c cleared, a undefined)
10, 11: ADC c p a z s o
18, 19: SBB c p a z s o
20, 21: AND p z s (o and c cleared, a undefined)
28, 29: SUB c p a z s o
30, 31: XOR p z s (o and c cleared, a undefined)
38, 39: CMP c p a z s o
84, 85: TEST p z s (o and c cleared, a undefined)

## X86-add/adc/sub/sbb/or/and/xor/cmp-g-e

Operand Fetch and Execute for ADD, ADC, SUB, SBB, OR, AND, XOR, CMP: Addressing Mode = (G, E)

### Signature

(x86-add/adc/sub/sbb/or/and/xor/cmp-g-e
     operation proc-mode start-rip temp-rip
     prefixes rex-byte opcode modr/m sib x86)

  →
x86
Returns
x86 — Type (x86p x86), given (x86p x86).

### Encoding
Op/En = MR: [OP R/M, REG] or [OP E, G]
Where:
    E is the destination operand and G is the source operand.

[OP R/M, REG] Flags Affected
00, 01: ADD c p a z s o
08, 09: OR p z s (o and c cleared, a undefined)
10, 11: ADC c p a z s o
18, 19: SBB c p a z s o
20, 21: AND p z s (o and c cleared, a undefined)
28, 29: SUB c p a z s o
30, 31: XOR p z s (o and c cleared, a undefined)
38, 39: CMP c p a z s o
84, 85: TEST p z s (o and c cleared, a undefined)

## X86-add/adc/sub/sbb/or/and/xor/cmp-test-rax-i

### Signature

(x86-add/adc/sub/sbb/or/and/xor/cmp-test-rax-i
     operation proc-mode start-rip temp-rip
     prefixes rex-byte opcode modr/m sib x86)

  →
x86
Returns
x86 — Type (x86p x86), given (x86p x86)

### Encoding

Op/En = I: [OP rAX, IMM] or [OP rAX, I]
Where:
    rAX is the destination operand and I is the source operand

[OP rAX, IMM] Flags Affected
04, 05: ADD c p a z s o
0C, 0D: OR p z s (o and c cleared, a undefined)
14, 15: ADC c p a z s o
1C, 1D: SBB c p a z s o
24, 25: AND p z s (o and c cleared, a undefined)
2C, 2D: SUB c p a z s o
34, 35: XOR p z s (o and c cleared, a undefined)
3C, 3D: CMP c p a z s o
A8, A9: TEST p z s (o and c cleared, a undefined)

## X86-push-segment-register

### Signature

(x86-push-segment-register proc-mode start-rip temp-rip
                           prefixes rex-byte opcode modr/m sib x86)

  →
x86
Returns
x86 — Type (x86p x86), given (x86p x86).

### Encoding

Note that PUSH CS/SS/DS/ES are invalid in 64-bit mode. Only PUSH FS/GS are valid in 64-bit mode.

0E: [PUSH CS]

16: [PUSH SS]

1E: [PUSH DS]

06: [PUSH ES]

0F A0: [PUSH FS]

0F A8: [PUSH GS]

If the source operand is a segment register (16 bits) and the operand size is 64-bits, a zero-extended value is pushed on the stack; if the operand size is 32-bits, either a zero-extended value is pushed on the stack or the segment selector is written on the stack using a 16-bit move. For the last case, all recent Core and Atom processors perform a 16-bit move, leaving the upper portion of the stack location unmodified.

For now, our model handles the last case described above by doing a 16-bit move. This should be how all modern processor work. In the future, we might parameterize the model on a flag that says how this case is handled (modern or legacy).

PUSH doesn’t have a separate instruction semantic function, unlike other opcodes like ADD, SUB, etc. The decoding is coupled with the execution in this case.

## X86-inc/dec-4x

### Signature

(x86-inc/dec-4x proc-mode start-rip temp-rip
                prefixes rex-byte opcode modr/m sib x86)

  →
x86
Returns
x86 — Type (x86p x86), given (x86p x86).

## X86-push-general-register

PUSH: 50+rw/rd

### Signature

(x86-push-general-register proc-mode start-rip temp-rip
                           prefixes rex-byte opcode modr/m sib x86)

  →
x86
Returns
x86 — Type (x86p x86), given (x86p x86).

### Encoding

Op/En: O
50+rw/rd r16/r32/r64

Note that 50+rd r32 is N.E. in 64-bit mode and that 50+rd r64 is N.E. in 32-bit mode.

PUSH does not have a separate instruction semantic function, unlike other opcodes like ADD, SUB, etc.
The decoding is coupled with the execution in this case.

## X86-pop-general-register

POP: 58+rw/rd

### Signature
(x86-pop-general-register proc-mode start-rip temp-rip
                          prefixes rex-byte opcode modr/m sib x86)

  →
x86
Returns
x86 — Type (x86p x86), given (x86p x86).

### Encoding

Op/En: O

58+rw/rd r16/r32/r64

Note that 58+rd r32 is N.E. in the 64-bit mode and that 58+rd r64 is N.E. in 32-bit mode.

POP does not have a separate instruction semantic function, unlike other opcodes like ADD, SUB, etc. The decoding is coupled with the execution in this case.

## X86-sal/sar/shl/shr/rcl/rcr/rol/ror

<file:///j:/source/acl2/books/projects/x86isa/machine/instructions/rotate-and-shift.lisp>

### Signature
(x86-sal/sar/shl/shr/rcl/rcr/rol/ror
     proc-mode start-rip temp-rip
     prefixes rex-byte opcode modr/m sib x86)

  →
x86
Returns
x86 — Type (x86p x86), given (x86p x86).

### Encoding

Op/En: MI
C0/0: ROL r/m8, imm8
C0/1: ROR r/m8, imm8
C0/2: RCL r/m8, imm8
C0/3: RCR r/m8, imm8
C0/4: SAL/SHL r/m8, imm8
C0/5: SHR r/m8, imm8
C0/7: SAR r/m8, imm8
C1/0: ROL r/m16/32/64, imm8
C1/1: ROR r/m16/32/64, imm8
C1/2: RCL r/m16/32/64, imm8
C1/3: RCR r/m16/32/64, imm8
C1/4: SAL/SHL r/m16/32/64, imm8
C1/5: SHR r/m16/32/64, imm8
C1/7: SAR r/m16/32/64. imm8

Op/En: M1
D0/0: ROL r/m8, 1
D0/1: ROR r/m8, 1
D0/2: RCL r/m8, 1
D0/3: RCR r/m8, 1
D0/4: SAL/SHL r/m8, 1
D0/5: SHR r/m8, 1
D0/7: SAR r/m8, 1
D1/0: ROL r/m16/32/64, 1
D1/1: ROR r/m16/32/64, 1
D1/2: RCL r/m16/32/64, 1
D1/3: RCR r/m16/32/64, 1
D1/4: SAL/SHL r/m16/32/64, 1
D1/5: SHR r/m16/32/64, 1
D1/7: SAR r/m16/32/64, 1

Op/En: MC
D2/0: ROL r/m8, CL
D2/1: ROR r/m8, CL
D2/2: RCL r/m8, CL
D2/3: RCR r/m8, CL
D2/4: SAL/SHL r/m8, CL
D2/5: SHR r/m8, CL
D2/7: SAR r/m8, CL
D3/0: ROL r/m16/32/64, CL
D3/1: ROR r/m16/32/64, CL
D3/2: RCL r/m16/32/64, CL
D3/3: RCR r/m16/32/64, CL
D3/4: SAL/SHL r/m16/32/64, CL
D3/5: SHR r/m16/32/64, CL
D3/7: SAR r/m16/32/64, CL