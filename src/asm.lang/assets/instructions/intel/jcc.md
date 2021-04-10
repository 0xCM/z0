# JCC - Encoding
-----------------------------------------------------------------------------------------------------------------------
| Op/En | Operand 1 | Operand 2 | Operand 3 | Operand 4 |
| D     | Offset    | NA        | NA        | NA        |

# JCC - Flags Read
-----------------------------------------------------------------------------------------------------------------------
| Jo_rel8_16   | OF         |          | Read |
| Jo_rel8_32   | OF         | INTEL386 | Read |
| Jo_rel8_64   | OF         | X64      | Read |
| Jno_rel8_16  | OF         |          | Read |
| Jno_rel8_32  | OF         | INTEL386 | Read |
| Jno_rel8_64  | OF         | X64      | Read |
| Jb_rel8_16   | CF         |          | Read |
| Jb_rel8_32   | CF         | INTEL386 | Read |
| Jb_rel8_64   | CF         | X64      | Read |
| Jae_rel8_16  | CF         |          | Read |
| Jae_rel8_32  | CF         | INTEL386 | Read |
| Jae_rel8_64  | CF         | X64      | Read |
| Je_rel8_16   | ZF         |          | Read |
| Je_rel8_32   | ZF         | INTEL386 | Read |
| Je_rel8_64   | ZF         | X64      | Read |
| Jne_rel8_16  | ZF         |          | Read |
| Jne_rel8_32  | ZF         | INTEL386 | Read |
| Jne_rel8_64  | ZF         | X64      | Read |
| Jbe_rel8_16  | ZF, CF     |          | Read |
| Jbe_rel8_32  | ZF, CF     | INTEL386 | Read |
| Jbe_rel8_64  | ZF, CF     | X64      | Read |
| Ja_rel8_16   | ZF, CF     |          | Read |
| Ja_rel8_32   | ZF, CF     | INTEL386 | Read |
| Ja_rel8_64   | ZF, CF     | X64      | Read |
| Js_rel8_16   | SF         |          | Read |
| Js_rel8_32   | SF         | INTEL386 | Read |
| Js_rel8_64   | SF         | X64      | Read |
| Jns_rel8_16  | SF         |          | Read |
| Jns_rel8_32  | SF         | INTEL386 | Read |
| Jns_rel8_64  | SF         | X64      | Read |
| Jp_rel8_16   | PF         |          | Read |
| Jp_rel8_32   | PF         | INTEL386 | Read |
| Jp_rel8_64   | PF         | X64      | Read |
| Jnp_rel8_16  | PF         |          | Read |
| Jnp_rel8_32  | PF         | INTEL386 | Read |
| Jnp_rel8_64  | PF         | X64      | Read |
| Jl_rel8_16   | OF, SF     |          | Read |
| Jl_rel8_32   | OF, SF     | INTEL386 | Read |
| Jl_rel8_64   | OF, SF     | X64      | Read |
| Jge_rel8_16  | OF, SF     |          | Read |
| Jge_rel8_32  | OF, SF     | INTEL386 | Read |
| Jge_rel8_64  | OF, SF     | X64      | Read |
| Jle_rel8_16  | OF, SF, ZF |          | Read |
| Jle_rel8_32  | OF, SF, ZF | INTEL386 | Read |
| Jle_rel8_64  | OF, SF, ZF | X64      | Read |
| Jg_rel8_16   | OF, SF, ZF |          | Read |
| Jg_rel8_32   | OF, SF, ZF | INTEL386 | Read |
| Jg_rel8_64   | OF, SF, ZF | X64      | Read |
| Jo_rel16     | OF         | INTEL386 | Read |
| Jo_rel32_32  | OF         | INTEL386 | Read |
| Jo_rel32_64  | OF         | X64      | Read |
| Jno_rel16    | OF         | INTEL386 | Read |
| Jno_rel32_32 | OF         | INTEL386 | Read |
| Jno_rel32_64 | OF         | X64      | Read |
| Jb_rel16     | CF         | INTEL386 | Read |
| Jb_rel32_32  | CF         | INTEL386 | Read |
| Jb_rel32_64  | CF         | X64      | Read |
| Jae_rel16    | CF         | INTEL386 | Read |
| Jae_rel32_32 | CF         | INTEL386 | Read |
| Jae_rel32_64 | CF         | X64      | Read |
| Je_rel16     | ZF         | INTEL386 | Read |
| Je_rel32_32  | ZF         | INTEL386 | Read |
| Je_rel32_64  | ZF         | X64      | Read |
| Jne_rel16    | ZF         | INTEL386 | Read |
| Jne_rel32_32 | ZF         | INTEL386 | Read |
| Jne_rel32_64 | ZF         | X64      | Read |
| Jbe_rel16    | ZF, CF     | INTEL386 | Read |
| Jbe_rel32_32 | ZF, CF     | INTEL386 | Read |
| Jbe_rel32_64 | ZF, CF     | X64      | Read |
| Ja_rel16     | ZF, CF     | INTEL386 | Read |
| Ja_rel32_32  | ZF, CF     | INTEL386 | Read |
| Ja_rel32_64  | ZF, CF     | X64      | Read |
| Js_rel16     | SF         | INTEL386 | Read |
| Js_rel32_32  | SF         | INTEL386 | Read |
| Js_rel32_64  | SF         | X64      | Read |
| Jns_rel16    | SF         | INTEL386 | Read |
| Jns_rel32_32 | SF         | INTEL386 | Read |
| Jns_rel32_64 | SF         | X64      | Read |
| Jp_rel16     | PF         | INTEL386 | Read |
| Jp_rel32_32  | PF         | INTEL386 | Read |
| Jp_rel32_64  | PF         | X64      | Read |
| Jnp_rel16    | PF         | INTEL386 | Read |
| Jnp_rel32_32 | PF         | INTEL386 | Read |
| Jnp_rel32_64 | PF         | X64      | Read |
| Jl_rel16     | OF, SF     | INTEL386 | Read |
| Jl_rel32_32  | OF, SF     | INTEL386 | Read |
| Jl_rel32_64  | OF, SF     | X64      | Read |
| Jge_rel16    | OF, SF     | INTEL386 | Read |
| Jge_rel32_32 | OF, SF     | INTEL386 | Read |
| Jge_rel32_64 | OF, SF     | X64      | Read |
| Jle_rel16    | OF, SF, ZF | INTEL386 | Read |
| Jle_rel32_32 | OF, SF, ZF | INTEL386 | Read |
| Jle_rel32_64 | OF, SF, ZF | X64      | Read |
| Jg_rel16     | OF, SF, ZF | INTEL386 | Read |
| Jg_rel32_32  | OF, SF, ZF | INTEL386 | Read |
| Jg_rel32_64  | OF, SF, ZF | X64      | Read |

# JCC - Operation
-------------------------------------------------------------------------------
IF condition
    THEN
        tempEIP ← EIP + SignExtend(DEST);
        IF OperandSize = 16
            THEN tempEIP ← tempEIP AND 0000FFFFH;
        FI;
    IF tempEIP is not within code segment limit
        THEN #GP(0);
        ELSE EIP ← tempEIP
    FI;
FI;

# Description
------------------------------------------------------------------------------------------------------------------------
Checks the state of one or more of the status flags in the EFLAGS register (CF, OF, PF, SF, and ZF) and, if the flags are in the specified state (condition), performs a jump to the target instruction specified by the destination operand. A condition code (cc) is associated with each instruction to indicate the condition being tested for. If the condition is not satisfied, the jump is not performed and execution continues with the instruction following the Jcc instruction.

The target instruction is specified with a relative offset (a signed offset relative to the current value of the instruction pointer in the EIP register). A relative offset (rel8, rel16, or rel32) is generally specified as a label in assembly code, but at the machine code level, it is encoded as a signed, 8-bit or 32-bit immediate value, which is added to the instruction pointer. Instruction coding is most efficient for offsets of –128 to +127. If the operand-size attribute is 16, the upper two bytes of the EIP register are cleared, resulting in a maximum instruction pointer size of 16 bits.

The conditions for each Jcc mnemonic are given in the “Description” column of the table on the preceding page. The terms “less” and “greater” are used for comparisons of signed integers and the terms “above” and “below” are used for unsigned integers.

Because a particular state of the status flags can sometimes be interpreted in two ways, two mnemonics are defined for some opcodes. For example, the JA (jump if above) instruction and the JNBE (jump if not below or equal) instruction are alternate mnemonics for the opcode 77H.

The Jcc instruction does not support far jumps (jumps to other code segments). When the target for the conditional jump is in a different segment, use the opposite condition from the condition being tested for the Jcc instruction, and then access the target with an unconditional far jump (JMP instruction) to the other segment. For example, the following conditional far jump is illegal:

JZ FARLABEL;

To accomplish this far jump, use the following two instructions:

JNZ BEYOND;

JMP FARLABEL;

BEYOND:

The JRCXZ, JECXZ and JCXZ instructions differ from other Jcc instructions because they do not check status flags. Instead, they check RCX, ECX or CX for 0. The register checked is determined by the address-size attribute. These instructions are useful when used at the beginning of a loop that terminates with a conditional loop instruction (such as LOOPNE). They can be used to prevent an instruction sequence from entering a loop when RCX, ECX or CX is 0. This would cause the loop to execute 264, 232 or 64K times (not zero times).

All conditional jumps are converted to code fetches of one or two cache lines, regardless of jump address or cache-ability.

In 64-bit mode, operand size is fixed at 64 bits. JMP Short is RIP = RIP + 8-bit offset sign extended to 64 bits. JMP Near is RIP = RIP + 32-bit offset sign extended to 64 bits
