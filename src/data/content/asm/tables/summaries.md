
## Data Transfer Instructions

MOV Move data between general-purpose registers; move data between memory and general-
purpose or segment registers; move immediates to general-purpose registers.
CMOVE/CMOVZ Conditional move if equal/Conditional move if zero.
CMOVNE/CMOVNZ Conditional move if not equal/Conditional move if not zero.
CMOVA/CMOVNBE Conditional move if above/Conditional move if not below or equal.
CMOVAE/CMOVNB Conditional move if above or equal/Conditional move if not below.
CMOVB/CMOVNAE Conditional move if below/Conditional move if not above or equal.
CMOVBE/CMOVNA Conditional move if below or equal/Conditional move if not above.
CMOVG/CMOVNLE Conditional move if greater/Conditional move if not less or equal.
CMOVGE/CMOVNL Conditional move if greater or equal/Conditional move if not less.
CMOVL/CMOVNGE Conditional move if less/Conditional move if not greater or equal.
CMOVLE/CMOVNG Conditional move if less or equal/Conditional move if not greater.
CMOVC Conditional move if carry.
CMOVNC Conditional move if not carry.
CMOVO Conditional move if overflow.
CMOVNO Conditional move if not overflow.
CMOVS Conditional move if sign (negative).
CMOVNS Conditional move if not sign (non-negative).
CMOVP/CMOVPE Conditional move if parity/Conditional move if parity even.
CMOVNP/CMOVPO Conditional move if not parity/Conditional move if parity odd.
XCHG Exchange.
BSWAP Byte swap.
XADD Exchange and add.
CMPXCHG Compare and exchange.
CMPXCHG8B Compare and exchange 8 bytes.
PUSH Push onto stack.
POP Pop off of stack.
PUSHA/PUSHAD Push general-purpose registers onto stack.
POPA/POPAD Pop general-purpose registers from stack.
CWD/CDQ Convert word to doubleword/Convert doubleword to quadword.
CBW/CWDE Convert byte to word/Convert word to doubleword in EAX register.
MOVSX Move and sign extend.

## Binary Arithmetic Instructions
ADCX Unsigned integer add with carry.
ADOX Unsigned integer add with overflow.
ADD Integer add.
ADC Add with carry.
SUB Subtract.
SBB Subtract with borrow.
IMUL Signed multiply.
MUL Unsigned multiply.
IDIV Signed divide.
DIV Unsigned divide.
INC Increment.
DEC Decrement.
NEG Negate.
CMP Compare.

## Decimal Arithmetic Instructions

DAA Decimal adjust after addition.
DAS Decimal adjust after subtraction.
AAA ASCII adjust after addition.
AAS ASCII adjust after subtraction.
AAM ASCII adjust after multiplication.
AAD ASCII adjust before division.

## Logical Instructions

AND Perform bitwise logical AND.
OR Perform bitwise logical OR.
XOR Perform bitwise logical exclusive OR.
NOT Perform bitwise logical NOT

## Shift and Rotate Instructions

SAR Shift arithmetic right.
SHR Shift logical right.
SAL/SHL Shift arithmetic left/Shift logical left.
SHRD Shift right double.
SHLD Shift left double.
ROR Rotate right.
ROL Rotate left.
RCR Rotate through carry right.
RCL Rotate through carry left.

## Bit and Byte Instructions

BT Bit test.
BTS Bit test and set.
BTR Bit test and reset.
BTC Bit test and complement.
BSF Bit scan forward.
BSR Bit scan reverse.
SETE/SETZ Set byte if equal/Set byte if zero.
SETNE/SETNZ Set byte if not equal/Set byte if not zero.
SETA/SETNBE Set byte if above/Set byte if not below or equal.
SETAE/SETNB/SETNC Set byte if above or equal/Set byte if not below/Set byte if not carry.
SETB/SETNAE/SETC Set byte if below/Set byte if not above or equal/Set byte if carry.
SETBE/SETNA Set byte if below or equal/Set byte if not above.
SETG/SETNLE Set byte if greater/Set byte if not less or equal.
SETGE/SETNL Set byte if greater or equal/Set byte if not less.
SETL/SETNGE Set byte if less/Set byte if not greater or equal.
SETLE/SETNG Set byte if less or equal/Set byte if not greater.
SETS Set byte if sign (negative).
SETNS Set byte if not sign (non-negative).
SETO Set byte if overflow.
SETNO Set byte if not overflow.
SETPE/SETP Set byte if parity even/Set byte if parity.
SETPO/SETNP Set byte if parity odd/Set byte if not parity.
TEST Logical compare.
CRC32 1 Provides hardware acceleration to calculate cyclic redundancy checks for fast and efficient
implementation of data integrity protocols.
POPCNT 2 This instruction calculates of number of bits set to 1 in the second operand (source) and
returns the count in the first operand (a destination register).

## Control Transfer Instructions

JMP Jump.
JE/JZ Jump if equal/Jump if zero.
JNE/JNZ Jump if not equal/Jump if not zero.
JA/JNBE Jump if above/Jump if not below or equal.
JAE/JNB Jump if above or equal/Jump if not below.
JB/JNAE Jump if below/Jump if not above or equal.
JBE/JNA Jump if below or equal/Jump if not above.
JG/JNLE Jump if greater/Jump if not less or equal.
JGE/JNL Jump if greater or equal/Jump if not less.
JL/JNGE Jump if less/Jump if not greater or equal.
JLE/JNG Jump if less or equal/Jump if not greater.
JC Jump if carry.
JNC Jump if not carry.
JO Jump if overflow.
JNO Jump if not overflow.
JS Jump if sign (negative).
JNS Jump if not sign (non-negative).
JPO/JNP Jump if parity odd/Jump if not parity.
JPE/JP Jump if parity even/Jump if parity.
JCXZ/JECXZ Jump register CX zero/Jump register ECX zero.
LOOP Loop with ECX counter.
LOOPZ/LOOPE Loop with ECX and zero/Loop with ECX and equal.
LOOPNZ/LOOPNE Loop with ECX and not zero/Loop with ECX and not equal.
CALL Call procedure.
RET Return.
IRET Return from interrupt.
INT Software interrupt.
INTO Interrupt on overflow.
BOUND Detect value out of range.
ENTER High-level procedure entry.
LEAVE High-level procedure exit.

## String Instructions

MOVS/MOVSB Move string/Move byte string.
MOVS/MOVSW Move string/Move word string.
MOVS/MOVSD Move string/Move doubleword string.
CMPS/CMPSB Compare string/Compare byte string.
CMPS/CMPSW Compare string/Compare word string.
CMPS/CMPSD Compare string/Compare doubleword string.
SCAS/SCASB Scan string/Scan byte string.
SCAS/SCASW Scan string/Scan word string.
SCAS/SCASD Scan string/Scan doubleword string.
LODS/LODSB Load string/Load byte string.
LODS/LODSW Load string/Load word string.
LODS/LODSD Load string/Load doubleword string.
STOS/STOSB Store string/Store byte string.
STOS/STOSW Store string/Store word string.
STOS/STOSD Store string/Store doubleword string.
REP Repeat while ECX not zero.
REPE/REPZ Repeat while equal/Repeat while zero.
REPNE/REPNZ Repeat while not equal/Repeat while not zero.

## I/O Instructions

IN Read from a port.
OUT Write to a port.
INS/INSB Input string from port/Input byte string from port.
INS/INSW Input string from port/Input word string from port.
INS/INSD Input string from port/Input doubleword string from port.
OUTS/OUTSB Output string to port/Output byte string to port.
OUTS/OUTSW Output string to port/Output word string to port.
OUTS/OUTSD Output string to port/Output doubleword string to port.

## Enter and Leave Instructions

ENTER High-level procedure entry.
LEAVE High-level procedure exit.

## Flag Control (EFLAG) instructions

STC Set carry flag.
CLC Clear the carry flag.
CMC Complement the carry flag.
CLD Clear the direction flag.
STD Set direction flag.
LAHF Load flags into AH register.
SAHF Store AH register into flags.
PUSHF/PUSHFD Push EFLAGS onto stack.
POPF/POPFD Pop EFLAGS from stack.
STI Set interrupt flag.
CLI Clear the interrupt flag.

## Segment Register Instructions

LDS Load far pointer using DS.
LES Load far pointer using ES.
LFS Load far pointer using FS.
LGS Load far pointer using GS.
LSS Load far pointer using SS.

## Misc

LEA Load effective address.
NOP No operation.
UD Undefined instruction.
XLAT/XLATB Table lookup translation.
CPUID Processor identification.
MOVBE 1 Move data after swapping data bytes.
PREFETCHW Prefetch data into cache in anticipation of write.
PREFETCHWT1 Prefetch hint T1 with intent to write.
CLFLUSH Flushes and invalidates a memory operand and its associated cache line from all levels of
the processor’s cache hierarchy.
CLFLUSHOPT Flushes and invalidates a memory operand and its associated cache line from all levels of
the processor’s cache hierarchy with optimized memory system throughput.

## User Mode Extended Sate Save/Restore Instructions

XSAVE Save processor extended states to memory.
XSAVEC Save processor extended states with compaction to memory.
XSAVEOPT Save processor extended states to memory, optimized.
XRSTOR Restore processor extended states from memory.
XGETBV Reads the state of an extended control register.

## Random Number Generator Instructions

RDRAND Retrieves a random number generated from hardware.
RDSEED Retrieves a random number generated from hardware.

## BMI1, BMI2

ANDN Bitwise AND of first source with inverted 2nd source operands.
BEXTR Contiguous bitwise extract.
BLSI Extract lowest set bit.
BLSMSK Set all lower bits below first set bit to 1.
BLSR Reset lowest set bit.
BZHI Zero high bits starting from specified bit position.
LZCNT Count the number leading zero bits.
MULX Unsigned multiply without affecting arithmetic flags.
PDEP Parallel deposit of bits using a mask.
PEXT Parallel extraction of bits using a mask.
RORX Rotate right without affecting arithmetic flags.
SARX Shift arithmetic right.
SHLX Shift logic left.
SHRX Shift logic right.
TZCNT Count the number trailing zero bits.

## MMX Data Transfer Instructions

MOVD Move doubleword.
MOVQ Move quadword

## MMX Conversion Functions

PACKSSWB Pack words into bytes with signed saturation.
PACKSSDW Pack doublewords into words with signed saturation.
PACKUSWB Pack words into bytes with unsigned saturation.
PUNPCKHBW Unpack high-order bytes.
PUNPCKHWD Unpack high-order words.
PUNPCKHDQ Unpack high-order doublewords.
PUNPCKLBW Unpack low-order bytes.
PUNPCKLWD Unpack low-order words.
PUNPCKLDQ Unpack low-order doublewords.

## MMX Packed Arithmetic Instructions

PADDB Add packed byte integers.
PADDW Add packed word integers.
PADDD Add packed doubleword integers.
PADDSB Add packed signed byte integers with signed saturation.
PADDSW Add packed signed word integers with signed saturation.
PADDUSB Add packed unsigned byte integers with unsigned saturation.
PADDUSW Add packed unsigned word integers with unsigned saturation.
PSUBB Subtract packed byte integers.
PSUBW Subtract packed word integers.
PSUBD Subtract packed doubleword integers.
PSUBSB Subtract packed signed byte integers with signed saturation.
PSUBSW Subtract packed signed word integers with signed saturation.
PSUBUSB Subtract packed unsigned byte integers with unsigned saturation.
PSUBUSW Subtract packed unsigned word integers with unsigned saturation.
PMULHW Multiply packed signed word integers and store high result.
PMULLW Multiply packed signed word integers and store low result.
PMADDWD Multiply and add packed word integers.

## MMX Comparison Instructions

PCMPEQB Compare packed bytes for equal.
PCMPEQW Compare packed words for equal.
PCMPEQD Compare packed doublewords for equal.
PCMPGTB Compare packed signed byte integers for greater than.
PCMPGTW Compare packed signed word integers for greater than.
PCMPGTD Compare packed signed doubleword integers for greater than.

## MMX Logical Instructions

PAND Bitwise logical AND.
PANDN Bitwise logical AND NOT.
POR Bitwise logical OR.
PXOR Bitwise logical exclusive OR.

## MMX Shift and Rotate Instructions

PSLLW Shift packed words left logical.
PSLLD Shift packed doublewords left logical.
PSLLQ Shift packed quadword left logical.
PSRLW Shift packed words right logical.
PSRLD Shift packed doublewords right logical.
PSRLQ Shift packed quadword right logical.
PSRAW Shift packed words right arithmetic.
PSRAD Shift packed doublewords right arithmetic.

## MMX State Management Instructions

EMMS Empty MMX state

## SSE Data Transfer Instructions

MOVAPS Move four aligned packed single-precision floating-point values between XMM registers or
between and XMM register and memory.
MOVUPS Move four unaligned packed single-precision floating-point values between XMM registers
or between and XMM register and memory.
MOVHPS Move two packed single-precision floating-point values to an from the high quadword of an
XMM register and memory.
MOVHLPS Move two packed single-precision floating-point values from the high quadword of an XMM
register to the low quadword of another XMM register.
MOVLPS Move two packed single-precision floating-point values to an from the low quadword of an
XMM register and memory.
MOVLHPS Move two packed single-precision floating-point values from the low quadword of an XMM
register to the high quadword of another XMM register.
MOVMSKPS Extract sign mask from four packed single-precision floating-point values.

## SSE Packed Arithmetic Instructions

* SSE packed arithmetic instructions perform packed and scalar arithmetic operations on packed and scalar single-precision floating-point operands.

ADDPS Add packed single-precision floating-point values.
ADDSS Add scalar single-precision floating-point values.
SUBPS Subtract packed single-precision floating-point values.
SUBSS Subtract scalar single-precision floating-point values.
MULPS Multiply packed single-precision floating-point values.
MULSS Multiply scalar single-precision floating-point values.
DIVPS Divide packed single-precision floating-point values.
DIVSS Divide scalar single-precision floating-point values.
RCPPS Compute reciprocals of packed single-precision floating-point values.
RCPSS Compute reciprocal of scalar single-precision floating-point values.
SQRTPS Compute square roots of packed single-precision floating-point values.
SQRTSS Compute square root of scalar single-precision floating-point values.
RSQRTPS Compute reciprocals of square roots of packed single-precision floating-point values.
RSQRTSS Compute reciprocal of square root of scalar single-precision floating-point values.
MAXPS Return maximum packed single-precision floating-point values.
MAXSS Return maximum scalar single-precision floating-point values.
MINPS Return minimum packed single-precision floating-point values.
MINSS Return minimum scalar single-precision floating-point values.

## SSE Comparison Instructions

CMPPS Compare packed single-precision floating-point values.
CMPSS Compare scalar single-precision floating-point values.
COMISS Perform ordered comparison of scalar single-precision floating-point values and set flags in EFLAGS register.
UCOMISS Perform unordered comparison of scalar single-precision floating-point values and set flags in EFLAGS register.

## SSE Logical Instructions

* SSE logical instructions perform bitwise AND, AND NOT, OR, and XOR operations on packed single-precision floating-point operands

ANDPS Perform bitwise logical AND of packed single-precision floating-point values.
ANDNPS Perform bitwise logical AND NOT of packed single-precision floating-point values.
ORPS Perform bitwise logical OR of packed single-precision floating-point values.
XORPS Perform bitwise logical XOR of packed single-precision floating-point values.

## SSE Shuffle and Unpack Instructions

SHUFPS Shuffles values in packed single-precision floating-point operands.
UNPCKHPS Unpacks and interleaves the two high-order values from two single-precision floating-point operands.
UNPCKLPS Unpacks and interleaves the two low-order values from two single-precision floating-point operands.

## SSE Conversion Instructions
* SSE conversion instructions convert packed and individual doubleword integers into packed and scalar single-precision floating-point values and vice versa.

CVTPI2PS Convert packed doubleword integers to packed single-precision floating-point values.
CVTSI2SS Convert doubleword integer to scalar single-precision floating-point value.
CVTPS2PI Convert packed single-precision floating-point values to packed doubleword integers.
CVTTPS2PI Convert with truncation packed single-precision floating-point values to packed double-word integers.
CVTSS2SI Convert a scalar single-precision floating-point value to a doubleword integer.
CVTTSS2SI Convert with truncation a scalar single-precision floating-point value to a scalar double-word integer.

## SSE MXCSR State Management Instructions

* MXCSR state management instructions allow saving and restoring the state of the MXCSR control and status register

LDMXCSR Load MXCSR register.
STMXCSR Save MXCSR register state.

## SSE 64-Bit SIMD Integer Instructions

* These SSE 64-bit SIMD integer instructions perform additional operations on packed bytes, words, or doublewords contained in MMX registers.

PAVGB Compute a verage of packed unsigned byte integers.
PAVGW Compute a verage of packed unsigned word integers.
PEXTRW Extract word.
PINSRW Insert word.
PMAXUB Maximum of packed unsigned byte integers.
PMAXSW Maximum of packed signed word integers.
PMINUB Minimum of packed unsigned byte integers.
PMINSW Minimum of packed signed word integers.
PMOVMSKB Move byte mask.
PMULHUW Multiply packed unsigned integers and store high result.
PSADBW Compute sum of absolute differences.
PSHUFW Shuffle packed integer word in MMX register.

## SSE Cacheability Control, Prefetch, and Instruction Ordering Instructions

* The cacheability control instructions provide control over the caching of non-temporal data when storing data from
the MMX and XMM registers to memory. The PREFETCHh allows data to be prefetched to a selected cache level. The
SFENCE instruction controls instruction ordering on store operations.

MASKMOVQ Non-temporal store of selected bytes from an MMX register into memory.
MOVNTQ Non-temporal store of quadword from an MMX register into memory.
MOVNTPS Non-temporal store of four packed single-precision floating-point values from an XMM register into memory.
PREFETCHh Load 32 or more of bytes from memory to a selected level of the processor’s cache hierarchy
SFENCE Serializes store operations.

## SSE2 Data Movement Instructions

MOVAPD Move two aligned packed double-precision floating-point values between XMM registers or
between and XMM register and memory.
MOVUPD Move two unaligned packed double-precision floating-point values between XMM registers
or between and XMM register and memory.
MOVHPD Move high packed double-precision floating-point value to an from the high quadword of an
XMM register and memory.
MOVLPD Move low packed single-precision floating-point value to an from the low quadword of an
XMM register and memory.
MOVMSKPD Extract sign mask from two packed double-precision floating-point values.
MOVSD Move scalar double-precision floating-point value between XMM registers or between an
XMM register and memory.

## SSE2 Packed Arithmetic Instructions

ADDPD Add packed double-precision floating-point values.
ADDSD Add scalar double precision floating-point values.
SUBPD Subtract packed double-precision floating-point values.
SUBSD Subtract scalar double-precision floating-point values.
MULPD Multiply packed double-precision floating-point values.
MULSD Multiply scalar double-precision floating-point values.
DIVPD Divide packed double-precision floating-point values.
DIVSD Divide scalar double-precision floating-point values.
SQRTPD Compute packed square roots of packed double-precision floating-point values.
SQRTSD Compute scalar square root of scalar double-precision floating-point values.
MAXPD Return maximum packed double-precision floating-point values.
MAXSD Return maximum scalar double-precision floating-point values.
MINPD Return minimum packed double-precision floating-point values.
MINSD Return minimum scalar double-precision floating-point values.

## SSE2 Logical Instructions

ANDPD Perform bitwise logical AND of packed double-precision floating-point values.
ANDNPD Perform bitwise logical AND NOT of packed double-precision floating-point values.
ORPD Perform bitwise logical OR of packed double-precision floating-point values.
XORPD Perform bitwise logical XOR of packed double-precision floating-point values.

## SSE2 Compare Instructions

CMPPD Compare packed double-precision floating-point values.
CMPSD Compare scalar double-precision floating-point values.
COMISD Perform ordered comparison of scalar double-precision floating-point values and set flags in EFLAGS register.
UCOMISD Perform unordered comparison of scalar double-precision floating-point values and set flags in EFLAGS register.

## SSE2 Shuffle and Unpack Instructions

SHUFPD Shuffles values in packed double-precision floating-point operands.
UNPCKHPD Unpacks and interleaves the high values from two packed double-precision floating-point operands.
UNPCKLPD Unpacks and interleaves the low values from two packed double-precision floating-point operands.

## SSE2 Conversion Instructions

CVTPD2PI Convert packed double-precision floating-point values to packed doubleword integers.
CVTTPD2PI Convert with truncation packed double-precision floating-point values to packed double-word integers.
CVTPI2PD Convert packed doubleword integers to packed double-precision floating-point values.
CVTPD2DQ Convert packed double-precision floating-point values to packed doubleword integers.
CVTTPD2DQ Convert with truncation packed double-precision floating-point values to packed double-word integers.
CVTDQ2PD Convert packed doubleword integers to packed double-precision floating-point values.
CVTPS2PD Convert packed single-precision floating-point values to packed double-precision floating-point values.
CVTPD2PS Convert packed double-precision floating-point values to packed single-precision floating-point values.
CVTSS2SD Convert scalar single-precision floating-point values to scalar double-precision floating-point values.
CVTSD2SS Convert scalar double-precision floating-point values to scalar single-precision floating-point values.
CVTSD2SI Convert scalar double-precision floating-point values to a doubleword integer.
CVTTSD2SI Convert with truncation scalar double-precision floating-point values to scalar doubleword integers.
CVTSI2SD Convert doubleword integer to scalar double-precision floating-point value.

## SSE2 Packed Single-Precision Floating-Point Instruction

CVTDQ2PS Convert packed doubleword integers to packed single-precision floating-point values.
CVTPS2DQ Convert packed single-precision floating-point values to packed doubleword integers.
CVTTPS2DQ Convert with truncation packed single-precision floating-point values to packed double-word integers.

## SSE2 128-Bit SIMD Integer Instructions

MOVDQA Move aligned double quadword.
MOVDQU Move unaligned double quadword.
MOVQ2DQ Move quadword integer from MMX to XMM registers.
MOVDQ2Q Move quadword integer from XMM to MMX registers.
PMULUDQ Multiply packed unsigned doubleword integers.
PADDQ Add packed quadword integers.
PSUBQ Subtract packed quadword integers.
PSHUFLW Shuffle packed low words.
PSHUFHW Shuffle packed high words.
PSHUFD Shuffle packed doublewords.
PSLLDQ Shift double quadword left logical.
PSRLDQ Shift double quadword right logical.
PUNPCKHQDQ Unpack high quadwords.
PUNPCKLQDQ Unpack low quadwords.

## SSE2 Cacheability Control and Ordering Instructions

CLFLUSH See Section 5.1.13.
LFENCE Serializes load operations.
MFENCE Serializes load and store operations.
PAUSE Improves the performance of “spin-wait loops”.
MASKMOVDQU Non-temporal store of selected bytes from an XMM register into memory.
MOVNTPD Non-temporal store of two packed double-precision floating-point values from an XMM register into memory.
MOVNTDQ Non-temporal store of double quadword from an XMM register into memory.
MOVNTI Non-temporal store of a doubleword from a general-purpose register into memory.