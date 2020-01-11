//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Instruction classifier listing
    /// </summary>
    /// <remarks>Derived from https://www.felixcloutier.com/x86/</remarks>
    public enum MnemonicKind
    {
        /// <summary>
        /// ASCII Adjust After Addition
        /// </summary>     
        AAA, 

        /// <summary>
        /// ASCII Adjust AX Before Division
        /// </summary>     
        AAD,  

        /// <summary>
        /// ASCII Adjust AX After Multiply
        /// </summary>     
        AAM,  

        /// <summary>
        /// ASCII Adjust AL After Subtraction
        /// </summary>     
        AAS,  

        /// <summary>
        /// Add with Carry
        /// </summary>     
        ADC,  

        /// <summary>
        /// Unsigned Integer Addition of Two Operands with Carry Flag
        /// </summary>     
        ADCX,  

        /// <summary>
        /// Add
        /// </summary>     
        ADD, 

        /// <summary>
        /// Add Packed Double-Precision Floating-Point Values
        /// </summary>     
        ADDPD,  

        /// <summary>
        /// Add Packed Single-Precision Floating-Point Values
        /// </summary>     
        ADDPS,

        /// <summary>
        /// Add Scalar Double-Precision Floating-Point Values
        /// </summary>     
        ADDSD, 

        /// <summary>
        /// Add Scalar Single-Precision Floating-Point Values
        /// </summary>     
        ADDSS, 

        /// <summary>
        ///  Packed Double-FP Add/Subtract
        /// </summary>     
        ADDSUBPD,

        /// <summary>
        /// Packed Single-FP Add/Subtract
        /// </summary>     
        ADDSUBPS,  

        /// <summary>
        /// Unsigned Integer Addition of Two Operands with Overflow Flag
        /// </summary>     
        ADOX, 

        /// <summary>
        /// Perform One Round of an AES Decryption Flow
        /// </summary>     
        AESDEC, 

        /// <summary>
        ///  Perform Last Round of an AES Decryption Flow
        /// </summary>     
        AESDECLAST,

        /// <summary>
        /// Perform One Round of an AES Encryption Flow
        /// </summary>     
        AESENC,

        /// <summary>
        /// Perform Last Round of an AES Encryption Flow
        /// </summary>     
        AESENCLAST,

        /// <summary>
        ///
        /// </summary>     
        AESIMC, // Perform the AES InvMixColumn Transformation

        /// <summary>
        ///
        /// </summary>     
        AESKEYGENASSIST, // AES Round Key Generation Assist

        /// <summary>
        ///
        /// </summary>     
        AND, // Logical AND

        /// <summary>
        ///
        /// </summary>     
        ANDN, // Logical AND NOT

        /// <summary>
        ///
        /// </summary>     
        ANDNPD, // Bitwise Logical AND NOT of Packed Double Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        ANDNPS, // Bitwise Logical AND NOT of Packed Single Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        ANDPD, // Bitwise Logical AND of Packed Double Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        ANDPS, // Bitwise Logical AND of Packed Single Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        ARPL, // Adjust RPL Field of Segment Selector

        /// <summary>
        ///
        /// </summary>     
        BEXTR, // Bit Field Extract

        /// <summary>
        ///
        /// </summary>     
        BLENDPD, // Blend Packed Double Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        BLENDPS, // Blend Packed Single Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        BLENDVPD, // Variable Blend Packed Double Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        BLENDVPS, // Variable Blend Packed Single Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        BLSI, // Extract Lowest Set Isolated Bit

        /// <summary>
        ///
        /// </summary>     
        BLSMSK, // Get Mask Up to Lowest Set Bit

        /// <summary>
        ///
        /// </summary>     
        BLSR, // Reset Lowest Set Bit

        /// <summary>
        ///
        /// </summary>     
        BNDCL, // Check Lower Bound

        /// <summary>
        ///
        /// </summary>     
        BNDCN, // Check Upper Bound

        /// <summary>
        ///
        /// </summary>     
        BNDCU, // Check Upper Bound

        /// <summary>
        ///
        /// </summary>     
        BNDLDX, // Load Extended Bounds Using Address Translation

        /// <summary>
        ///
        /// </summary>     
        BNDMK, // Make Bounds

        /// <summary>
        ///
        /// </summary>     
        BNDMOV, // Move Bounds

        /// <summary>
        ///
        /// </summary>     
        BNDSTX, // Store Extended Bounds Using Address Translation

        /// <summary>
        ///
        /// </summary>     
        BOUND, // Check Array Index Against Bounds

        /// <summary>
        ///
        /// </summary>     
        BSF, // Bit Scan Forward

        /// <summary>
        ///
        /// </summary>     
        BSR, // Bit Scan Reverse

        /// <summary>
        ///
        /// </summary>     
        BSWAP, // Byte Swap

        /// <summary>
        ///
        /// </summary>     
        BT, // Bit Test

        /// <summary>
        ///
        /// </summary>     
        BTC, // Bit Test and Complement

        /// <summary>
        ///
        /// </summary>     
        BTR, // Bit Test and Reset

        /// <summary>
        ///
        /// </summary>     
        BTS, // Bit Test and Set

        /// <summary>
        ///
        /// </summary>     
        BZHI, // Zero High Bits Starting with Specified Bit Position

        /// <summary>
        ///
        /// </summary>     
        CALL, // Call Procedure

        /// <summary>
        ///
        /// </summary>     
        CBW, // Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword

        /// <summary>
        ///
        /// </summary>     
        CDQ, // Convert Word to Doubleword/Convert Doubleword to Quadword

        /// <summary>
        ///
        /// </summary>     
        CDQE, // Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword

        /// <summary>
        ///
        /// </summary>     
        CLAC, // Clear AC Flag in EFLAGS Register

        /// <summary>
        ///
        /// </summary>     
        CLC, // Clear Carry Flag

        /// <summary>
        ///
        /// </summary>     
        CLD, // Clear Direction Flag

        /// <summary>
        ///
        /// </summary>     
        CLDEMOTE, // Cache Line Demote

        /// <summary>
        ///
        /// </summary>     
        CLFLUSH, // Flush Cache Line

        /// <summary>
        ///
        /// </summary>     
        CLFLUSHOPT, // Flush Cache Line Optimized

        /// <summary>
        ///
        /// </summary>     
        CLI, // Clear Interrupt Flag

        /// <summary>
        ///
        /// </summary>     
        CLTS, // Clear Task-Switched Flag in CR0

        /// <summary>
        ///
        /// </summary>     
        CLWB, // Cache Line Write Back

        /// <summary>
        /// Complement Carry Flag
        /// </summary>     
        CMC,  

        /// <summary>
        /// Conditional Move
        /// </summary>     
        CMOVcc,

        /// <summary>
        /// Compare Two Operands
        /// </summary>     
        CMP, 

        /// <summary>
        /// Compare Packed Double-Precision Floating-Point Values
        /// </summary>     
        CMPPD,

        /// <summary>
        ///
        /// </summary>     
        CMPPS, // Compare Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        CMPS, // Compare String Operands

        /// <summary>
        ///
        /// </summary>     
        CMPSB, // Compare String Operands

        /// <summary>
        ///
        /// </summary>     
        CMPSD, // Compare String Operands

        /// <summary>
        ///
        /// </summary>     
        CMPSD_1, // Compare Scalar Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        CMPSQ, // Compare String Operands

        /// <summary>
        ///
        /// </summary>     
        CMPSS, // Compare Scalar Single-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        CMPSW, // Compare String Operands

        /// <summary>
        ///
        /// </summary>     
        CMPXCHG, // Compare and Exchange

        /// <summary>
        ///
        /// </summary>     
        CMPXCHG16B, // Compare and Exchange Bytes

        /// <summary>
        ///
        /// </summary>     
        CMPXCHG8B, // Compare and Exchange Bytes

        /// <summary>
        ///
        /// </summary>     
        COMISD, // Compare Scalar Ordered Double-Precision Floating-Point Values and Set EFLAGS

        /// <summary>
        ///
        /// </summary>     
        COMISS, // Compare Scalar Ordered Single-Precision Floating-Point Values and Set EFLAGS

        /// <summary>
        ///
        /// </summary>     
        CPUID, // CPU Identification

        /// <summary>
        ///
        /// </summary>     
        CQO, // Convert Word to Doubleword/Convert Doubleword to Quadword

        /// <summary>
        ///
        /// </summary>     
        CRC32, // Accumulate CRC32 Value

        /// <summary>
        ///
        /// </summary>     
        CVTDQ2PD, // Convert Packed Doubleword Integers to Packed Double-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        CVTDQ2PS, // Convert Packed Doubleword Integers to Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        CVTPD2DQ, // Convert Packed Double-Precision Floating-Point Values to Packed Doubleword Integers

        /// <summary>
        ///
        /// </summary>     
        CVTPD2PI, // Convert Packed Double-Precision FP Values to Packed Dword Integers

        /// <summary>
        ///
        /// </summary>     
        CVTPD2PS, // Convert Packed Double-Precision Floating-Point Values to Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        CVTPI2PD, // Convert Packed Dword Integers to Packed Double-Precision FP Values

        /// <summary>
        ///
        /// </summary>     
        CVTPI2PS, // Convert Packed Dword Integers to Packed Single-Precision FP Values

        /// <summary>
        ///
        /// </summary>     
        CVTPS2DQ, // Convert Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values

        /// <summary>
        ///
        /// </summary>     
        CVTPS2PD, // Convert Packed Single-Precision Floating-Point Values to Packed Double-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        CVTPS2PI, // Convert Packed Single-Precision FP Values to Packed Dword Integers

        /// <summary>
        ///
        /// </summary>     
        CVTSD2SI, // Convert Scalar Double-Precision Floating-Point Value to Doubleword Integer

        /// <summary>
        ///
        /// </summary>     
        CVTSD2SS, // Convert Scalar Double-Precision Floating-Point Value to Scalar Single-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        CVTSI2SD, // Convert Doubleword Integer to Scalar Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        CVTSI2SS, // Convert Doubleword Integer to Scalar Single-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        CVTSS2SD, // Convert Scalar Single-Precision Floating-Point Value to Scalar Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        CVTSS2SI, // Convert Scalar Single-Precision Floating-Point Value to Doubleword Integer

        /// <summary>
        ///
        /// </summary>     
        CVTTPD2DQ, // Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Doubleword Integers

        /// <summary>
        ///
        /// </summary>     
        CVTTPD2PI, // Convert with Truncation Packed Double-Precision FP Values to Packed Dword Integers

        /// <summary>
        ///
        /// </summary>     
        CVTTPS2DQ, // Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Signed Doubleword Integer Values

        /// <summary>
        ///
        /// </summary>     
        CVTTPS2PI, // Convert with Truncation Packed Single-Precision FP Values to Packed Dword Integers

        /// <summary>
        ///
        /// </summary>     
        CVTTSD2SI, // Convert with Truncation Scalar Double-Precision Floating-Point Value to Signed Integer

        /// <summary>
        ///
        /// </summary>     
        CVTTSS2SI, // Convert with Truncation Scalar Single-Precision Floating-Point Value to Integer

        /// <summary>
        ///
        /// </summary>     
        CWD, // Convert Word to Doubleword/Convert Doubleword to Quadword

        /// <summary>
        ///
        /// </summary>     
        CWDE, // Convert Byte to Word/Convert Word to Doubleword/Convert Doubleword to Quadword

        /// <summary>
        ///
        /// </summary>     
        DAA, // Decimal Adjust AL after Addition

        /// <summary>
        ///
        /// </summary>     
        DAS, // Decimal Adjust AL after Subtraction

        /// <summary>
        ///
        /// </summary>     
        DEC, // Decrement by 1

        /// <summary>
        ///
        /// </summary>     
        DIV, // Unsigned Divide

        /// <summary>
        ///
        /// </summary>     
        DIVPD, // Divide Packed Double-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        DIVPS, // Divide Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        DIVSD, // Divide Scalar Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        DIVSS, // Divide Scalar Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        DPPD, // Dot Product of Packed Double Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        DPPS, // Dot Product of Packed Single Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        EMMS, // Empty MMX Technology State

        /// <summary>
        ///
        /// </summary>     
        ENTER, // Make Stack Frame for Procedure Parameters

        /// <summary>
        ///
        /// </summary>     
        EXTRACTPS, // Extract Packed Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        F2XM1, // Compute 2x–1
        
        /// <summary>
        ///
        /// </summary>     
        FABS, // Absolute Value

        /// <summary>
        ///
        /// </summary>     
        FADD, // Add

        /// <summary>
        ///
        /// </summary>     
        FADDP, // Add
        
        /// <summary>
        ///
        /// </summary>     
        FBLD, // Load Binary Coded Decimal

        /// <summary>
        ///
        /// </summary>     
        FBSTP, // Store BCD Integer and Pop

        /// <summary>
        ///
        /// </summary>     
        FCHS, // Change Sign

        /// <summary>
        ///
        /// </summary>     
        FCLEX, // Clear Exceptions

        /// <summary>
        ///
        /// </summary>     
        FCMOVcc, // Floating-Point Conditional Move

        /// <summary>
        ///
        /// </summary>     
        FCOM, // Compare Floating Point Values

        /// <summary>
        ///
        /// </summary>     
        FCOMI, // Compare Floating Point Values and Set EFLAGS

        /// <summary>
        ///
        /// </summary>     
        FCOMIP, // Compare Floating Point Values and Set EFLAGS

        /// <summary>
        ///
        /// </summary>     
        FCOMP, // Compare Floating Point Values

        /// <summary>
        ///
        /// </summary>     
        FCOMPP, // Compare Floating Point Values

        /// <summary>
        ///
        /// </summary>     
        FCOS, // Cosine

        /// <summary>
        ///
        /// </summary>     
        FDECSTP, // Decrement Stack-Top Pointer

        /// <summary>
        ///
        /// </summary>     
        FDIV, // Divide

        /// <summary>
        ///
        /// </summary>     
        FDIVP, // Divide

        /// <summary>
        ///
        /// </summary>     
        FDIVR, // Reverse Divide

        /// <summary>
        ///
        /// </summary>     
        FDIVRP, // Reverse Divide

        /// <summary>
        ///
        /// </summary>     
        FFREE, // Free Floating-Point Register

        /// <summary>
        ///
        /// </summary>     
        FIADD, // Add

        /// <summary>
        ///
        /// </summary>     
        FICOM, // Compare Integer

        /// <summary>
        /// Compare Integer
        /// </summary>     
        FICOMP,

        /// <summary>
        ///
        /// </summary>     
        FIDIV, // Divide

        /// <summary>
        ///
        /// </summary>     
        FIDIVR, // Reverse Divide

        /// <summary>
        ///
        /// </summary>     
        FILD, // Load Integer

        /// <summary>
        ///
        /// </summary>     
        FIMUL, // Multiply

        /// <summary>
        ///
        /// </summary>     
        FINCSTP, // Increment Stack-Top Pointer

        /// <summary>
        ///
        /// </summary>     
        FINIT, // Initialize Floating-Point Unit

        /// <summary>
        /// Store Integer
        /// </summary>     
        FIST,
        
        /// <summary>
        ///
        /// </summary>     
        FISTP, // Store Integer

        /// <summary>
        ///
        /// </summary>     
        FISTTP, // Store Integer with Truncation

        /// <summary>
        ///
        /// </summary>     
        FISUB, // Subtract

        /// <summary>
        ///
        /// </summary>     
        FISUBR, // Reverse Subtract

        /// <summary>
        ///
        /// </summary>     
        FLD, // Load Floating Point Value

        /// <summary>
        ///
        /// </summary>     
        FLD1, // Load Constant

        /// <summary>
        /// Load x87 FPU Control Word
        /// </summary>     
        FLDCW,

        /// <summary>
        ///
        /// </summary>     
        FLDENV, // Load x87 FPU Environment

        /// <summary>
        ///
        /// </summary>     
        FLDL2E, // Load Constant

        /// <summary>
        ///
        /// </summary>     
        FLDL2T, // Load Constant

        /// <summary>
        ///
        /// </summary>     
        FLDLG2, // Load Constant

        /// <summary>
        ///
        /// </summary>     
        FLDLN2, // Load Constant

        /// <summary>
        ///
        /// </summary>     
        FLDPI, // Load Constant

        /// <summary>
        ///
        /// </summary>     
        FLDZ, // Load Constant

        /// <summary>
        ///
        /// </summary>     
        FMUL, // Multiply

        /// <summary>
        ///
        /// </summary>     
        FMULP, // Multiply

        /// <summary>
        ///
        /// </summary>     
        FNCLEX, // Clear Exceptions

        /// <summary>
        ///
        /// </summary>     
        FNINIT, // Initialize Floating-Point Unit

        /// <summary>
        ///
        /// </summary>     
        FNOP, // No Operation

        /// <summary>
        ///
        /// </summary>     
        FNSAVE, // Store x87 FPU State

        /// <summary>
        ///
        /// </summary>     
        FNSTCW, // Store x87 FPU Control Word

        /// <summary>
        /// Store x87 FPU Environment
        /// </summary>     
        FNSTENV,

        /// <summary>
        ///
        /// </summary>     
        FNSTSW, // Store x87 FPU Status Word

        /// <summary>
        ///
        /// </summary>     
        FPATAN, // Partial Arctangent

        /// <summary>
        ///
        /// </summary>     
        FPREM, // Partial Remainder

        /// <summary>
        ///
        /// </summary>     
        FPREM1, // Partial Remainder

        /// <summary>
        ///
        /// </summary>     
        FPTAN, // Partial Tangent

        /// <summary>
        ///
        /// </summary>     
        FRNDINT, // Round to Integer

        /// <summary>
        ///
        /// </summary>     
        FRSTOR, // Restore x87 FPU State

        /// <summary>
        ///
        /// </summary>     
        FSAVE, // Store x87 FPU State

        /// <summary>
        ///
        /// </summary>     
        FSCALE, // Scale

        /// <summary>
        ///
        /// </summary>     
        FSIN, // Sine

        /// <summary>
        ///
        /// </summary>     
        FSINCOS, // Sine and Cosine

        /// <summary>
        ///
        /// </summary>     
        FSQRT, // Square Root

        /// <summary>
        ///
        /// </summary>     
        FST, // Store Floating Point Value

        /// <summary>
        ///
        /// </summary>     
        FSTCW, // Store x87 FPU Control Word

        /// <summary>
        ///
        /// </summary>     
        FSTENV, // Store x87 FPU Environment

        /// <summary>
        /// Store Floating Point Value
        /// </summary>     
        FSTP,

        /// <summary>
        ///
        /// </summary>     
        FSTSW, // Store x87 FPU Status Word

        /// <summary>
        ///
        /// </summary>     
        FSUB, // Subtract

        /// <summary>
        ///
        /// </summary>     
        FSUBP, // Subtract

        /// <summary>
        ///
        /// </summary>     
        FSUBR, // Reverse Subtract

        /// <summary>
        ///
        /// </summary>     
        FSUBRP, // Reverse Subtract

        /// <summary>
        ///
        /// </summary>     
        FTST, // TEST

        /// <summary>
        ///
        /// </summary>     
        FUCOM, // Unordered Compare Floating Point Values

        /// <summary>
        ///
        /// </summary>     
        FUCOMI, // Compare Floating Point Values and Set EFLAGS

        /// <summary>
        ///
        /// </summary>     
        FUCOMIP, // Compare Floating Point Values and Set EFLAGS

        /// <summary>
        ///
        /// </summary>     
        FUCOMP, // Unordered Compare Floating Point Values

        /// <summary>
        ///
        /// </summary>     
        FUCOMPP, // Unordered Compare Floating Point Values

        /// <summary>
        ///
        /// </summary>     
        FWAIT, // Wait

        /// <summary>
        ///
        /// </summary>     
        FXAM, // Examine Floating-Point

        /// <summary>
        ///
        /// </summary>     
        FXCH, // Exchange Register Contents

        /// <summary>
        ///
        /// </summary>     
        FXRSTOR, // Restore x87 FPU, MMX, XMM, and MXCSR State

        /// <summary>
        ///
        /// </summary>     
        FXSAVE, // Save x87 FPU, MMX Technology, and SSE State

        /// <summary>
        ///
        /// </summary>     
        FXTRACT, // Extract Exponent and Significand

        /// <summary>
        ///
        /// </summary>     
        FYL2X, // Compute y ∗ log2x

        /// <summary>
        ///
        /// </summary>     
        FYL2XP1, // Compute y ∗ log2(x +1)

        /// <summary>
        ///
        /// </summary>     
        GF2P8AFFINEINVQB, // Galois Field Affine Transformation Inverse

        /// <summary>
        ///
        /// </summary>     
        GF2P8AFFINEQB, // Galois Field Affine Transformation

        /// <summary>
        ///
        /// </summary>     
        GF2P8MULB, // Galois Field Multiply Bytes

        /// <summary>
        ///
        /// </summary>     
        HADDPD, // Packed Double-FP Horizontal Add

        /// <summary>
        ///
        /// </summary>     
        HADDPS, // Packed Single-FP Horizontal Add

        /// <summary>
        ///
        /// </summary>     
        HLT, // Halt

        /// <summary>
        ///
        /// </summary>     
        HSUBPD, // Packed Double-FP Horizontal Subtract

        /// <summary>
        ///
        /// </summary>     
        HSUBPS, // Packed Single-FP Horizontal Subtract

        /// <summary>
        ///
        /// </summary>     
        IDIV, // Signed Divide

        /// <summary>
        ///
        /// </summary>     
        IMUL, // Signed Multiply

        /// <summary>
        ///
        /// </summary>     
        IN, // Input from Port

        /// <summary>
        ///
        /// </summary>     
        INC, // Increment by 1

        /// <summary>
        ///
        /// </summary>     
        INS, // Input from Port to String

        /// <summary>
        ///
        /// </summary>     
        INSB, // Input from Port to String

        /// <summary>
        ///
        /// </summary>     
        INSD, // Input from Port to String
        
        /// <summary>
        ///
        /// </summary>     
        INSERTPS, // Insert Scalar Single-Precision Floating-Point Value
        
        /// <summary>
        ///
        /// </summary>     
        INSW, // Input from Port to String

        /// <summary>
        ///
        /// </summary>     
        INT_n, // Call to Interrupt Procedure

        /// <summary>
        ///
        /// </summary>     
        INT1, // Call to Interrupt Procedure

        /// <summary>
        ///
        /// </summary>     
        INT3, // Call to Interrupt Procedure

        /// <summary>
        ///
        /// </summary>     
        INTO, // Call to Interrupt Procedure

        /// <summary>
        ///
        /// </summary>     
        INVD, // Invalidate Internal Caches

        /// <summary>
        ///
        /// </summary>     
        INVLPG, // Invalidate TLB Entries

        /// <summary>
        ///
        /// </summary>     
        INVPCID, // Invalidate Process-Context Identifier

        /// <summary>
        ///
        /// </summary>     
        IRET, // Interrupt Return

        /// <summary>
        ///
        /// </summary>     
        IRETD, // Interrupt Return

        /// <summary>
        ///
        /// </summary>     
        JMP, // Jump

        /// <summary>
        ///
        /// </summary>     
        Jcc, // Jump if Condition Is Met

        /// <summary>
        ///
        /// </summary>     
        KADDB, // ADD Two Masks

        /// <summary>
        ///
        /// </summary>     
        KADDD, // ADD Two Masks

        /// <summary>
        ///
        /// </summary>     
        KADDQ, // ADD Two Masks

        /// <summary>
        ///
        /// </summary>     
        KADDW, // ADD Two Masks

        /// <summary>
        ///
        /// </summary>     
        KANDB, // Bitwise Logical AND Masks

        /// <summary>
        ///
        /// </summary>     
        KANDD, // Bitwise Logical AND Masks

        /// <summary>
        ///
        /// </summary>     
        KANDNB, // Bitwise Logical AND NOT Masks

        /// <summary>
        ///
        /// </summary>     
        KANDND, // Bitwise Logical AND NOT Masks

        /// <summary>
        ///
        /// </summary>     
        KANDNQ, // Bitwise Logical AND NOT Masks

        /// <summary>
        ///
        /// </summary>     
        KANDNW, // Bitwise Logical AND NOT Masks

        /// <summary>
        ///
        /// </summary>     
        KANDQ, // Bitwise Logical AND Masks

        /// <summary>
        ///
        /// </summary>     
        KANDW, // Bitwise Logical AND Masks

        /// <summary>
        ///
        /// </summary>     
        KMOVB, // Move from and to Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KMOVD, // Move from and to Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KMOVQ, // Move from and to Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KMOVW, // Move from and to Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KNOTB, // NOT Mask Register

        /// <summary>
        ///
        /// </summary>     
        KNOTD, // NOT Mask Register

        /// <summary>
        ///
        /// </summary>     
        KNOTQ, // NOT Mask Register

        /// <summary>
        ///
        /// </summary>     
        KNOTW, // NOT Mask Register

        /// <summary>
        ///
        /// </summary>     
        KORB, // Bitwise Logical OR Masks

        /// <summary>
        ///
        /// </summary>     
        KORD, // Bitwise Logical OR Masks

        /// <summary>
        ///
        /// </summary>     
        KORQ, // Bitwise Logical OR Masks

        /// <summary>
        ///
        /// </summary>     
        KORTESTB, // OR Masks And Set Flags

        /// <summary>
        ///
        /// </summary>     
        KORTESTD, // OR Masks And Set Flags

        /// <summary>
        ///
        /// </summary>     
        KORTESTQ, // OR Masks And Set Flags

        /// <summary>
        ///
        /// </summary>     
        KORTESTW, // OR Masks And Set Flags

        /// <summary>
        ///
        /// </summary>     
        KORW, // Bitwise Logical OR Masks

        /// <summary>
        ///
        /// </summary>     
        KSHIFTLB, // Shift Left Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KSHIFTLD, // Shift Left Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KSHIFTLQ, // Shift Left Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KSHIFTLW, // Shift Left Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KSHIFTRB, // Shift Right Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KSHIFTRD, // Shift Right Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KSHIFTRQ, // Shift Right Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KSHIFTRW, // Shift Right Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KTESTB, // Packed Bit Test Masks and Set Flags

        /// <summary>
        ///
        /// </summary>     
        KTESTD, // Packed Bit Test Masks and Set Flags

        /// <summary>
        ///
        /// </summary>     
        KTESTQ, // Packed Bit Test Masks and Set Flags

        /// <summary>
        ///
        /// </summary>     
        KTESTW, // Packed Bit Test Masks and Set Flags

        /// <summary>
        ///
        /// </summary>     
        KUNPCKBW, // Unpack for Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KUNPCKDQ, // Unpack for Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KUNPCKWD, // Unpack for Mask Registers

        /// <summary>
        ///
        /// </summary>     
        KXNORB, // Bitwise Logical XNOR Masks

        /// <summary>
        ///
        /// </summary>     
        KXNORD, // Bitwise Logical XNOR Masks

        /// <summary>
        ///
        /// </summary>     
        KXNORQ, // Bitwise Logical XNOR Masks

        /// <summary>
        ///
        /// </summary>     
        KXNORW, // Bitwise Logical XNOR Masks

        /// <summary>
        ///
        /// </summary>     
        KXORB, // Bitwise Logical XOR Masks

        /// <summary>
        ///
        /// </summary>     
        KXORD, // Bitwise Logical XOR Masks

        /// <summary>
        ///
        /// </summary>     
        KXORQ, // Bitwise Logical XOR Masks

        /// <summary>
        ///
        /// </summary>     
        KXORW, // Bitwise Logical XOR Masks

        /// <summary>
        ///
        /// </summary>     
        LAHF, // Load Status Flags into AH Register

        /// <summary>
        ///
        /// </summary>     
        LAR, // Load Access Rights Byte

        /// <summary>
        ///
        /// </summary>     
        LDDQU, // Load Unaligned Integer 128 Bits

        /// <summary>
        ///
        /// </summary>     
        LDMXCSR, // Load MXCSR Register

        /// <summary>
        ///
        /// </summary>     
        LDS, // Load Far Pointer

        /// <summary>
        ///
        /// </summary>     
        LEA, // Load Effective Address

        /// <summary>
        ///
        /// </summary>     
        LEAVE, // High Level Procedure Exit

        /// <summary>
        ///
        /// </summary>     
        LES, // Load Far Pointer

        /// <summary>
        ///
        /// </summary>     
        LFENCE, // Load Fence

        /// <summary>
        ///
        /// </summary>     
        LFS, // Load Far Pointer

        /// <summary>
        ///
        /// </summary>     
        LGDT, // Load Global/Interrupt Descriptor Table Register

        /// <summary>
        ///
        /// </summary>     
        LGS, // Load Far Pointer

        /// <summary>
        ///
        /// </summary>     
        LIDT, // Load Global/Interrupt Descriptor Table Register

        /// <summary>
        ///
        /// </summary>     
        LLDT, // Load Local Descriptor Table Register

        /// <summary>
        ///
        /// </summary>     
        LMSW, // Load Machine Status Word

        /// <summary>
        ///
        /// </summary>     
        LOCK, // Assert LOCK# Signal Prefix

        /// <summary>
        ///
        /// </summary>     
        LODS, // Load String

        /// <summary>
        ///
        /// </summary>     
        LODSB, // Load String

        /// <summary>
        ///
        /// </summary>     
        LODSD, // Load String

        /// <summary>
        ///
        /// </summary>     
        LODSQ, // Load String

        /// <summary>
        ///
        /// </summary>     
        LODSW, // Load String

        /// <summary>
        ///
        /// </summary>     
        LOOP, // Loop According to ECX Counter

        /// <summary>
        ///
        /// </summary>     
        LOOPcc, // Loop According to ECX Counter

        /// <summary>
        ///
        /// </summary>     
        LSL, // Load Segment Limit

        /// <summary>
        ///
        /// </summary>     
        LSS, // Load Far Pointer

        /// <summary>
        ///
        /// </summary>     
        LTR, // Load Task Register

        /// <summary>
        ///
        /// </summary>     
        LZCNT, // Count the Number of Leading Zero Bits

        /// <summary>
        ///
        /// </summary>     
        MASKMOVDQU, // Store Selected Bytes of Double Quadword

        /// <summary>
        ///
        /// </summary>     
        MASKMOVQ, // Store Selected Bytes of Quadword

        /// <summary>
        ///
        /// </summary>     
        MAXPD, // Maximum of Packed Double-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MAXPS, // Maximum of Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MAXSD, // Return Maximum Scalar Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        MAXSS, // Return Maximum Scalar Single-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        MFENCE, // Memory Fence

        /// <summary>
        ///
        /// </summary>     
        MINPD, // Minimum of Packed Double-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MINPS, // Minimum of Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MINSD, // Return Minimum Scalar Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        MINSS, // Return Minimum Scalar Single-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        MONITOR, // Set Up Monitor Address

        /// <summary>
        ///
        /// </summary>     
        MOV, // Move

        /// <summary>
        ///
        /// </summary>     
        MOV_1, // Move to/from Control Registers

        /// <summary>
        ///
        /// </summary>     
        MOV_2, // Move to/from Debug Registers

        /// <summary>
        ///
        /// </summary>     
        MOVAPD, // Move Aligned Packed Double-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MOVAPS, // Move Aligned Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MOVBE, // Move Data After Swapping Bytes

        /// <summary>
        ///
        /// </summary>     
        MOVD, // Move Doubleword/Move Quadword

        /// <summary>
        ///
        /// </summary>     
        MOVDDUP, // Replicate Double FP Values

        /// <summary>
        ///
        /// </summary>     
        MOVDIR64B, // Move 64 Bytes as Direct Store

        /// <summary>
        ///
        /// </summary>     
        MOVDIRI, // Move Doubleword as Direct Store

        /// <summary>
        ///
        /// </summary>     
        MOVDQ2Q, // Move Quadword from XMM to MMX Technology Register

        /// <summary>
        ///
        /// </summary>     
        MOVDQA, // Move Aligned Packed Integer Values

        /// <summary>
        ///
        /// </summary>     
        MOVDQU, // Move Unaligned Packed Integer Values

        /// <summary>
        ///
        /// </summary>     
        MOVHLPS, // Move Packed Single-Precision Floating-Point Values High to Low

        /// <summary>
        ///
        /// </summary>     
        MOVHPD, // Move High Packed Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        MOVHPS, // Move High Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MOVLHPS, // Move Packed Single-Precision Floating-Point Values Low to High

        /// <summary>
        ///
        /// </summary>     
        MOVLPD, // Move Low Packed Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        MOVLPS, // Move Low Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MOVMSKPD, // Extract Packed Double-Precision Floating-Point Sign Mask

        /// <summary>
        ///
        /// </summary>     
        MOVMSKPS, // Extract Packed Single-Precision Floating-Point Sign Mask

        /// <summary>
        ///
        /// </summary>     
        MOVNTDQ, // Store Packed Integers Using Non-Temporal Hint

        /// <summary>
        ///
        /// </summary>     
        MOVNTDQA, // Load Double Quadword Non-Temporal Aligned Hint

        /// <summary>
        ///
        /// </summary>     
        MOVNTI, // Store Doubleword Using Non-Temporal Hint

        /// <summary>
        ///
        /// </summary>     
        MOVNTPD, // Store Packed Double-Precision Floating-Point Values Using Non-Temporal Hint

        /// <summary>
        ///
        /// </summary>     
        MOVNTPS, // Store Packed Single-Precision Floating-Point Values Using Non-Temporal Hint

        /// <summary>
        ///
        /// </summary>     
        MOVNTQ, // Store of Quadword Using Non-Temporal Hint

        /// <summary>
        ///
        /// </summary>     
        MOVQ, // Move Doubleword/Move Quadword

        /// <summary>
        ///
        /// </summary>     
        MOVQ_1, // Move Quadword

        /// <summary>
        ///
        /// </summary>     
        MOVQ2DQ, // Move Quadword from MMX Technology to XMM Register

        /// <summary>
        ///
        /// </summary>     
        MOVS, // Move Data from String to String

        /// <summary>
        ///
        /// </summary>     
        MOVSB, // Move Data from String to String

        /// <summary>
        ///
        /// </summary>     
        MOVSD, // Move Data from String to String

        /// <summary>
        ///
        /// </summary>     
        MOVSD_1, // Move or Merge Scalar Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        MOVSHDUP, // Replicate Single FP Values

        /// <summary>
        ///
        /// </summary>     
        MOVSLDUP, // Replicate Single FP Values

        /// <summary>
        ///
        /// </summary>     
        MOVSQ, // Move Data from String to String

        /// <summary>
        ///
        /// </summary>     
        MOVSS, // Move or Merge Scalar Single-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        MOVSW, // Move Data from String to String

        /// <summary>
        ///
        /// </summary>     
        MOVSX, // Move with Sign-Extension

        /// <summary>
        ///
        /// </summary>     
        MOVSXD, // Move with Sign-Extension

        /// <summary>
        ///
        /// </summary>     
        MOVUPD, // Move Unaligned Packed Double-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MOVUPS, // Move Unaligned Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MOVZX, // Move with Zero-Extend

        /// <summary>
        ///
        /// </summary>     
        MPSADBW, // Compute Multiple Packed Sums of Absolute Difference

        /// <summary>
        ///
        /// </summary>     
        MUL, // Unsigned Multiply

        /// <summary>
        ///
        /// </summary>     
        MULPD, // Multiply Packed Double-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MULPS, // Multiply Packed Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MULSD, // Multiply Scalar Double-Precision Floating-Point Value

        /// <summary>
        ///
        /// </summary>     
        MULSS, // Multiply Scalar Single-Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        MULX, // Unsigned Multiply Without Affecting Flags

        /// <summary>
        ///
        /// </summary>     
        MWAIT, // Monitor Wait

        /// <summary>
        ///
        /// </summary>     
        NEG, // Two's Complement Negation

        /// <summary>
        ///
        /// </summary>     
        NOP, // No Operation

        /// <summary>
        /// One's Complement Negation
        /// </summary>     
        NOT,

        /// <summary>
        /// Logical Inclusive OR
        /// </summary>     
        OR, //

        /// <summary>
        /// Bitwise Logical OR of Packed Double Precision Floating-Point Values
        /// </summary>     
        ORPD, //

        /// <summary>
        ///
        /// </summary>     
        ORPS, // Bitwise Logical OR of Packed Single Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        OUT, // Output to Port

        /// <summary>
        ///
        /// </summary>     
        OUTS, // Output String to Port

        /// <summary>
        ///
        /// </summary>     
        OUTSB, // Output String to Port

        /// <summary>
        ///
        /// </summary>     
        OUTSD, // Output String to Port

        /// <summary>
        ///
        /// </summary>     
        OUTSW, // Output String to Port

        /// <summary>
        ///
        /// </summary>     
        PABSB, // Packed Absolute Value

        /// <summary>
        ///
        /// </summary>     
        PABSD, // Packed Absolute Value

        /// <summary>
        ///
        /// </summary>     
        PABSQ, // Packed Absolute Value

        /// <summary>
        ///
        /// </summary>     
        PABSW, // Packed Absolute Value

        /// <summary>
        ///
        /// </summary>     
        PACKSSDW, // Pack with Signed Saturation

        /// <summary>
        ///
        /// </summary>     
        PACKSSWB, // Pack with Signed Saturation

        /// <summary>
        ///
        /// </summary>     
        PACKUSDW, // Pack with Unsigned Saturation

        /// <summary>
        ///
        /// </summary>     
        PACKUSWB, // Pack with Unsigned Saturation

        /// <summary>
        ///
        /// </summary>     
        PADDB, // Add Packed Integers

        /// <summary>
        ///
        /// </summary>     
        PADDD, // Add Packed Integers

        /// <summary>
        ///
        /// </summary>     
        PADDQ, // Add Packed Integers

        /// <summary>
        ///
        /// </summary>     
        PADDSB, // Add Packed Signed Integers with Signed Saturation

        /// <summary>
        ///
        /// </summary>     
        PADDSW, // Add Packed Signed Integers with Signed Saturation

        /// <summary>
        ///
        /// </summary>     
        PADDUSB, // Add Packed Unsigned Integers with Unsigned Saturation

        /// <summary>
        ///
        /// </summary>     
        PADDUSW, // Add Packed Unsigned Integers with Unsigned Saturation

        /// <summary>
        ///
        /// </summary>     
        PADDW, // Add Packed Integers

        /// <summary>
        ///
        /// </summary>     
        PALIGNR, // Packed Align Right

        /// <summary>
        ///
        /// </summary>     
        PAND, // Logical AND

        /// <summary>
        ///
        /// </summary>     
        PANDN, // Logical AND NOT

        /// <summary>
        ///
        /// </summary>     
        PAUSE, // Spin Loop Hint

        /// <summary>
        ///
        /// </summary>     
        PAVGB, // Average Packed Integers

        /// <summary>
        ///
        /// </summary>     
        PAVGW, // Average Packed Integers

        /// <summary>
        ///
        /// </summary>     
        PBLENDVB, // Variable Blend Packed Bytes
        PBLENDW, // Blend Packed Words
        PCLMULQDQ, // Carry-Less Multiplication Quadword
        PCMPEQB, // Compare Packed Data for Equal
        PCMPEQD, // Compare Packed Data for Equal
        PCMPEQQ, // Compare Packed Qword Data for Equal
        PCMPEQW, // Compare Packed Data for Equal
        PCMPESTRI, // Packed Compare Explicit Length Strings, Return Index
        PCMPESTRM, // Packed Compare Explicit Length Strings, Return Mask
        PCMPGTB, // Compare Packed Signed Integers for Greater Than
        PCMPGTD, // Compare Packed Signed Integers for Greater Than
        PCMPGTQ, // Compare Packed Data for Greater Than
        PCMPGTW, // Compare Packed Signed Integers for Greater Than
        PCMPISTRI, // Packed Compare Implicit Length Strings, Return Index
        PCMPISTRM, // Packed Compare Implicit Length Strings, Return Mask
        PDEP, // Parallel Bits Deposit
        PEXT, // Parallel Bits Extract
        PEXTRB, // Extract Byte/Dword/Qword
        PEXTRD, // Extract Byte/Dword/Qword
        PEXTRQ, // Extract Byte/Dword/Qword
        PEXTRW, // Extract Word
        PHADDD, // Packed Horizontal Add
        PHADDSW, // Packed Horizontal Add and Saturate
        PHADDW, // Packed Horizontal Add
        PHMINPOSUW, // Packed Horizontal Word Minimum
        PHSUBD, // Packed Horizontal Subtract
        PHSUBSW, // Packed Horizontal Subtract and Saturate
        PHSUBW, // Packed Horizontal Subtract
        PINSRB, // Insert Byte/Dword/Qword
        PINSRD, // Insert Byte/Dword/Qword
        PINSRQ, // Insert Byte/Dword/Qword
        PINSRW, // Insert Word
        PMADDUBSW, // Multiply and Add Packed Signed and Unsigned Bytes
        PMADDWD, // Multiply and Add Packed Integers
        PMAXSB, // Maximum of Packed Signed Integers
        PMAXSD, // Maximum of Packed Signed Integers
        PMAXSQ, // Maximum of Packed Signed Integers
        PMAXSW, // Maximum of Packed Signed Integers
        PMAXUB, // Maximum of Packed Unsigned Integers
        PMAXUD, // Maximum of Packed Unsigned Integers
        PMAXUQ, // Maximum of Packed Unsigned Integers
        PMAXUW, // Maximum of Packed Unsigned Integers
        PMINSB, // Minimum of Packed Signed Integers
        PMINSD, // Minimum of Packed Signed Integers
        PMINSQ, // Minimum of Packed Signed Integers
        PMINSW, // Minimum of Packed Signed Integers
        PMINUB, // Minimum of Packed Unsigned Integers
        PMINUD, // Minimum of Packed Unsigned Integers
        PMINUQ, // Minimum of Packed Unsigned Integers
        PMINUW, // Minimum of Packed Unsigned Integers
        PMOVMSKB, // Move Byte Mask
        PMOVSX, // Packed Move with Sign Extend
        PMOVZX, // Packed Move with Zero Extend
        PMULDQ, // Multiply Packed Doubleword Integers
        PMULHRSW, // Packed Multiply High with Round and Scale
        PMULHUW, // Multiply Packed Unsigned Integers and Store High Result
        PMULHW, // Multiply Packed Signed Integers and Store High Result
        PMULLD, // Multiply Packed Integers and Store Low Result
        PMULLQ, // Multiply Packed Integers and Store Low Result
        PMULLW, // Multiply Packed Signed Integers and Store Low Result
        PMULUDQ, // Multiply Packed Unsigned Doubleword Integers
        POP, // Pop a Value from the Stack
        POPA, // Pop All General-Purpose Registers
        POPAD, // Pop All General-Purpose Registers
        POPCNT, // Return the Count of Number of Bits Set to 1
        POPF, // Pop Stack into EFLAGS Register
        POPFD, // Pop Stack into EFLAGS Register
        POPFQ, // Pop Stack into EFLAGS Register
        POR, // Bitwise Logical OR
        PREFETCHW, // Prefetch Data into Caches in Anticipation of a Write
        PREFETCHh, // Prefetch Data Into Caches
        PSADBW, // Compute Sum of Absolute Differences
        PSHUFB, // Packed Shuffle Bytes
        PSHUFD, // Shuffle Packed Doublewords
        PSHUFHW, // Shuffle Packed High Words
        PSHUFLW, // Shuffle Packed Low Words
        PSHUFW, // Shuffle Packed Words
        PSIGNB, // Packed SIGN
        PSIGND, // Packed SIGN
        PSIGNW, // Packed SIGN
        PSLLD, // Shift Packed Data Left Logical
        PSLLDQ, // Shift Double Quadword Left Logical
        PSLLQ, // Shift Packed Data Left Logical
        PSLLW, // Shift Packed Data Left Logical
        PSRAD, // Shift Packed Data Right Arithmetic
        PSRAQ, // Shift Packed Data Right Arithmetic
        PSRAW, // Shift Packed Data Right Arithmetic
        PSRLD, // Shift Packed Data Right Logical
        PSRLDQ, // Shift Double Quadword Right Logical
        PSRLQ, // Shift Packed Data Right Logical
        PSRLW, // Shift Packed Data Right Logical
        PSUBB, // Subtract Packed Integers
        PSUBD, // Subtract Packed Integers
        PSUBQ, // Subtract Packed Quadword Integers
        PSUBSB, // Subtract Packed Signed Integers with Signed Saturation
        PSUBSW, // Subtract Packed Signed Integers with Signed Saturation
        PSUBUSB, // Subtract Packed Unsigned Integers with Unsigned Saturation
        PSUBUSW, // Subtract Packed Unsigned Integers with Unsigned Saturation
        PSUBW, // Subtract Packed Integers
        PTEST, // Logical Compare
        PTWRITE, // Write Data to a Processor Trace Packet
        PUNPCKHBW, // Unpack High Data
        PUNPCKHDQ, // Unpack High Data
        PUNPCKHQDQ, // Unpack High Data
        PUNPCKHWD, // Unpack High Data
        PUNPCKLBW, // Unpack Low Data
        PUNPCKLDQ, // Unpack Low Data
        PUNPCKLQDQ, // Unpack Low Data
        PUNPCKLWD, // Unpack Low Data
        PUSH, // Push Word, Doubleword or Quadword Onto the Stack
        PUSHA, // Push All General-Purpose Registers
        PUSHAD, // Push All General-Purpose Registers
        PUSHF, // Push EFLAGS Register onto the Stack
        PUSHFD, // Push EFLAGS Register onto the Stack
        PUSHFQ, // Push EFLAGS Register onto the Stack
        PXOR, // Logical Exclusive OR
        RCL, // Rotate
        RCPPS, // Compute Reciprocals of Packed Single-Precision Floating-Point Values
        RCPSS, // Compute Reciprocal of Scalar Single-Precision Floating-Point Values
        RCR, // Rotate
        RDFSBASE, // Read FS/GS Segment Base
        RDGSBASE, // Read FS/GS Segment Base
        RDMSR, // Read from Model Specific Register
        RDPID, // Read Processor ID
        RDPKRU, // Read Protection Key Rights for User Pages
        RDPMC, // Read Performance-Monitoring Counters
        RDRAND, // Read Random Number
        RDSEED, // Read Random SEED
        RDTSC, // Read Time-Stamp Counter
        RDTSCP, // Read Time-Stamp Counter and Processor ID
        REP, // Repeat String Operation Prefix
        REPE, // Repeat String Operation Prefix
        REPNE, // Repeat String Operation Prefix
        REPNZ, // Repeat String Operation Prefix
        REPZ, // Repeat String Operation Prefix
        RET, // Return from Procedure
        ROL, // Rotate
        ROR, // Rotate
        RORX, // Rotate Right Logical Without Affecting Flags
        ROUNDPD, // Round Packed Double Precision Floating-Point Values
        ROUNDPS, // Round Packed Single Precision Floating-Point Values
        ROUNDSD, // Round Scalar Double Precision Floating-Point Values
        ROUNDSS, // Round Scalar Single Precision Floating-Point Values
        RSM, // Resume from System Management Mode
        RSQRTPS, // Compute Reciprocals of Square Roots of Packed Single-Precision Floating-Point Values
        RSQRTSS, // Compute Reciprocal of Square Root of Scalar Single-Precision Floating-Point Value
        SAHF, // Store AH into Flags
        SAL, // Shift
        SAR, // Shift
        SARX, // Shift Without Affecting Flags
        SBB, // Integer Subtraction with Borrow
        SCAS, // Scan String
        SCASB, // Scan String
        SCASD, // Scan String
        SCASW, // Scan String
        SETcc, // Set Byte on Condition
        SFENCE, // Store Fence
        SGDT, // Store Global Descriptor Table Register
        SHA1MSG1, // Perform an Intermediate Calculation for the Next Four SHA1 Message Dwords
        SHA1MSG2, // Perform a Final Calculation for the Next Four SHA1 Message Dwords
        SHA1NEXTE, // Calculate SHA1 State Variable E after Four Rounds
        SHA1RNDS4, // Perform Four Rounds of SHA1 Operation
        SHA256MSG1, // Perform an Intermediate Calculation for the Next Four SHA256 Message Dwords
        SHA256MSG2, // Perform a Final Calculation for the Next Four SHA256 Message Dwords
        SHA256RNDS2, // Perform Two Rounds of SHA256 Operation
        SHL, // Shift
        SHLD, // Double Precision Shift Left
        SHLX, // Shift Without Affecting Flags
        SHR, // Shift
        SHRD, // Double Precision Shift Right
        SHRX, // Shift Without Affecting Flags
        SHUFPD, // Packed Interleave Shuffle of Pairs of Double-Precision Floating-Point Values
        SHUFPS, // Packed Interleave Shuffle of Quadruplets of Single-Precision Floating-Point Values
        SIDT, // Store Interrupt Descriptor Table Register
        SLDT, // Store Local Descriptor Table Register
        SMSW, // Store Machine Status Word
        SQRTPD, // Square Root of Double-Precision Floating-Point Values
        SQRTPS, // Square Root of Single-Precision Floating-Point Values
        SQRTSD, // Compute Square Root of Scalar Double-Precision Floating-Point Value
        SQRTSS, // Compute Square Root of Scalar Single-Precision Value
        STAC, // Set AC Flag in EFLAGS Register
        STC, // Set Carry Flag
        STD, // Set Direction Flag
        STI, // Set Interrupt Flag
        STMXCSR, // Store MXCSR Register State
        STOS, // Store String
        STOSB, // Store String
        STOSD, // Store String
        STOSQ, // Store String
        STOSW, // Store String
        STR, // Store Task Register
        SUB, // Subtract
        SUBPD, // Subtract Packed Double-Precision Floating-Point Values
        SUBPS, // Subtract Packed Single-Precision Floating-Point Values
        SUBSD, // Subtract Scalar Double-Precision Floating-Point Value
        SUBSS, // Subtract Scalar Single-Precision Floating-Point Value
        SWAPGS, // Swap GS Base Register
        SYSCALL, // Fast System Call
        SYSENTER, // Fast System Call
        SYSEXIT, // Fast Return from Fast System Call
        SYSRET, // Return From Fast System Call
        TEST, // Logical Compare
        TPAUSE, // Timed PAUSE
        TZCNT, // Count the Number of Trailing Zero Bits
        UCOMISD, // Unordered Compare Scalar Double-Precision Floating-Point Values and Set EFLAGS
        UCOMISS, // Unordered Compare Scalar Single-Precision Floating-Point Values and Set EFLAGS
        UD, // Undefined Instruction
        UMONITOR, // User Level Set Up Monitor Address
        UMWAIT, // User Level Monitor Wait
        UNPCKHPD, // Unpack and Interleave High Packed Double-Precision Floating-Point Values
        UNPCKHPS, // Unpack and Interleave High Packed Single-Precision Floating-Point Values
        UNPCKLPD, // Unpack and Interleave Low Packed Double-Precision Floating-Point Values
        UNPCKLPS, // Unpack and Interleave Low Packed Single-Precision Floating-Point Values
        VALIGND, // Align Doubleword/Quadword Vectors
        VALIGNQ, // Align Doubleword/Quadword Vectors
        VBLENDMPD, // Blend Float64/Float32 Vectors Using an OpMask Control
        VBLENDMPS, // Blend Float64/Float32 Vectors Using an OpMask Control
        VBROADCAST, // Load with Broadcast Floating-Point Data
        VCOMPRESSPD, // Store Sparse Packed Double-Precision Floating-Point Values into Dense Memory
        VCOMPRESSPS, // Store Sparse Packed Single-Precision Floating-Point Values into Dense Memory
        VCVTPD2QQ, // Convert Packed Double-Precision Floating-Point Values to Packed Quadword Integers
        VCVTPD2UDQ, // Convert Packed Double-Precision Floating-Point Values to Packed Unsigned Doubleword Integers
        VCVTPD2UQQ, // Convert Packed Double-Precision Floating-Point Values to Packed Unsigned Quadword Integers
        VCVTPH2PS, // Convert 16-bit FP values to Single-Precision FP values
        VCVTPS2PH, // Convert Single-Precision FP value to 16-bit FP value
        VCVTPS2QQ, // Convert Packed Single Precision Floating-Point Values to Packed Singed Quadword Integer Values
        VCVTPS2UDQ, // Convert Packed Single-Precision Floating-Point Values to Packed Unsigned Doubleword Integer Values
        VCVTPS2UQQ, // Convert Packed Single Precision Floating-Point Values to Packed Unsigned Quadword Integer Values
        VCVTQQ2PD, // Convert Packed Quadword Integers to Packed Double-Precision Floating-Point Values
        VCVTQQ2PS, // Convert Packed Quadword Integers to Packed Single-Precision Floating-Point Values
        VCVTSD2USI, // Convert Scalar Double-Precision Floating-Point Value to Unsigned Doubleword Integer
        VCVTSS2USI, // Convert Scalar Single-Precision Floating-Point Value to Unsigned Doubleword Integer
        VCVTTPD2QQ, // Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Quadword Integers
        VCVTTPD2UDQ, // Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Unsigned Doubleword Integers
        VCVTTPD2UQQ, // Convert with Truncation Packed Double-Precision Floating-Point Values to Packed Unsigned Quadword Integers
        VCVTTPS2QQ, // Convert with Truncation Packed Single Precision Floating-Point Values to Packed Singed Quadword Integer Values
        VCVTTPS2UDQ, // Convert with Truncation Packed Single-Precision Floating-Point Values to Packed Unsigned Doubleword Integer Values
        VCVTTPS2UQQ, // Convert with Truncation Packed Single Precision Floating-Point Values to Packed Unsigned Quadword Integer Values
        VCVTTSD2USI, // Convert with Truncation Scalar Double-Precision Floating-Point Value to Unsigned Integer
        VCVTTSS2USI, // Convert with Truncation Scalar Single-Precision Floating-Point Value to Unsigned Integer
        VCVTUDQ2PD, // Convert Packed Unsigned Doubleword Integers to Packed Double-Precision Floating-Point Values
        VCVTUDQ2PS, // Convert Packed Unsigned Doubleword Integers to Packed Single-Precision Floating-Point Values
        VCVTUQQ2PD, // Convert Packed Unsigned Quadword Integers to Packed Double-Precision Floating-Point Values
        VCVTUQQ2PS, // Convert Packed Unsigned Quadword Integers to Packed Single-Precision Floating-Point Values
        VCVTUSI2SD, // Convert Unsigned Integer to Scalar Double-Precision Floating-Point Value
        VCVTUSI2SS, // Convert Unsigned Integer to Scalar Single-Precision Floating-Point Value
        VDBPSADBW, // Double Block Packed Sum-Absolute-Differences (SAD) on Unsigned Bytes
        VERR, // Verify a Segment for Reading or Writing
        VERW, // Verify a Segment for Reading or Writing
        VEXPANDPD, // Load Sparse Packed Double-Precision Floating-Point Values from Dense Memory
        VEXPANDPS, // Load Sparse Packed Single-Precision Floating-Point Values from Dense Memory
        VEXTRACTF128, // Extra ct Packed Floating-Point Values
        VEXTRACTF32x4, // Extra ct Packed Floating-Point Values
        VEXTRACTF32x8, // Extra ct Packed Floating-Point Values
        VEXTRACTF64x2, // Extra ct Packed Floating-Point Values
        VEXTRACTF64x4, // Extra ct Packed Floating-Point Values
        VEXTRACTI128, // Extract packed Integer Values
        VEXTRACTI32x4, // Extract packed Integer Values
        VEXTRACTI32x8, // Extract packed Integer Values
        VEXTRACTI64x2, // Extract packed Integer Values
        VEXTRACTI64x4, // Extract packed Integer Values
        VFIXUPIMMPD, // Fix Up Special Packed Float64 Values
        VFIXUPIMMPS, // Fix Up Special Packed Float32 Values
        VFIXUPIMMSD, // Fix Up Special Scalar Float64 Value
        VFIXUPIMMSS, // Fix Up Special Scalar Float32 Value
        VFMADD132PD, // Fused Multiply-Add of Packed Double- Precision Floating-Point Values
        VFMADD132PS, // Fused Multiply-Add of Packed Single- Precision Floating-Point Values
        VFMADD132SD, // Fused Multiply-Add of Scalar Double- Precision Floating-Point Values
        VFMADD132SS, // Fused Multiply-Add of Scalar Single-Precision Floating-Point Values
        VFMADD213PD, // Fused Multiply-Add of Packed Double- Precision Floating-Point Values
        VFMADD213PS, // Fused Multiply-Add of Packed Single- Precision Floating-Point Values
        VFMADD213SD, // Fused Multiply-Add of Scalar Double- Precision Floating-Point Values
        VFMADD213SS, // Fused Multiply-Add of Scalar Single-Precision Floating-Point Values
        VFMADD231PD, // Fused Multiply-Add of Packed Double- Precision Floating-Point Values
        VFMADD231PS, // Fused Multiply-Add of Packed Single- Precision Floating-Point Values
        VFMADD231SD, // Fused Multiply-Add of Scalar Double- Precision Floating-Point Values
        VFMADD231SS, // Fused Multiply-Add of Scalar Single-Precision Floating-Point Values
        VFMADDSUB132PD, // Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values
        VFMADDSUB132PS, // Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values
        VFMADDSUB213PD, // Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values
        VFMADDSUB213PS, // Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values
        VFMADDSUB231PD, // Fused Multiply-Alternating Add/Subtract of Packed Double-Precision Floating-Point Values
        VFMADDSUB231PS, // Fused Multiply-Alternating Add/Subtract of Packed Single-Precision Floating-Point Values
        VFMSUB132PD, // Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values
        VFMSUB132PS, // Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values
        VFMSUB132SD, // Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values
        VFMSUB132SS, // Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values
        VFMSUB213PD, // Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values
        VFMSUB213PS, // Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values
        VFMSUB213SD, // Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values
        VFMSUB213SS, // Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values
        VFMSUB231PD, // Fused Multiply-Subtract of Packed Double- Precision Floating-Point Values
        VFMSUB231PS, // Fused Multiply-Subtract of Packed Single- Precision Floating-Point Values
        VFMSUB231SD, // Fused Multiply-Subtract of Scalar Double- Precision Floating-Point Values
        VFMSUB231SS, // Fused Multiply-Subtract of Scalar Single- Precision Floating-Point Values
        VFMSUBADD132PD, // Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values
        VFMSUBADD132PS, // Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values
        VFMSUBADD213PD, // Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values
        VFMSUBADD213PS, // Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values
        VFMSUBADD231PD, // Fused Multiply-Alternating Subtract/Add of Packed Double-Precision Floating-Point Values
        VFMSUBADD231PS, // Fused Multiply-Alternating Subtract/Add of Packed Single-Precision Floating-Point Values
        VFNMADD132PD, // Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values
        VFNMADD132PS, // Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values
        VFNMADD132SD, // Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values
        VFNMADD132SS, // Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values
        VFNMADD213PD, // Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values
        VFNMADD213PS, // Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values
        VFNMADD213SD, // Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values
        VFNMADD213SS, // Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values
        VFNMADD231PD, // Fused Negative Multiply-Add of Packed Double-Precision Floating-Point Values
        VFNMADD231PS, // Fused Negative Multiply-Add of Packed Single-Precision Floating-Point Values
        VFNMADD231SD, // Fused Negative Multiply-Add of Scalar Double-Precision Floating-Point Values
        VFNMADD231SS, // Fused Negative Multiply-Add of Scalar Single-Precision Floating-Point Values
        VFNMSUB132PD, // Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values
        VFNMSUB132PS, // Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values
        VFNMSUB132SD, // Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values
        VFNMSUB132SS, // Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values
        VFNMSUB213PD, // Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values
        VFNMSUB213PS, // Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values
        VFNMSUB213SD, // Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values
        VFNMSUB213SS, // Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values
        VFNMSUB231PD, // Fused Negative Multiply-Subtract of Packed Double-Precision Floating-Point Values
        VFNMSUB231PS, // Fused Negative Multiply-Subtract of Packed Single-Precision Floating-Point Values
        VFNMSUB231SD, // Fused Negative Multiply-Subtract of Scalar Double-Precision Floating-Point Values
        VFNMSUB231SS, // Fused Negative Multiply-Subtract of Scalar Single-Precision Floating-Point Values
        VFPCLASSPD, // Tests Types Of a Packed Float64 Values
        VFPCLASSPS, // Tests Types Of a Packed Float32 Values
        VFPCLASSSD, // Tests Types Of a Scalar Float64 Values
        VFPCLASSSS, // Tests Types Of a Scalar Float32 Values
        VGATHERDPD, // Gather Packed DP FP Values Using Signed Dword/Qword Indices
        VGATHERDPD_1, // Gather Packed Single, Packed Double with Signed Dword
        VGATHERDPS, // Gather Packed SP FP values Using Signed Dword/Qword Indices
        VGATHERDPS_1, // Gather Packed Single, Packed Double with Signed Dword
        VGATHERQPD, // Gather Packed DP FP Values Using Signed Dword/Qword Indices
        VGATHERQPD_1, // Gather Packed Single, Packed Double with Signed Qword Indices
        VGATHERQPS, // Gather Packed SP FP values Using Signed Dword/Qword Indices
        VGATHERQPS_1, // Gather Packed Single, Packed Double with Signed Qword Indices
        VGETEXPPD, // Convert Exponents of Packed DP FP Values to DP FP Values
        VGETEXPPS, // Convert Exponents of Packed SP FP Values to SP FP Values
        VGETEXPSD, // Convert Exponents of Scalar DP FP Values to DP FP Value
        VGETEXPSS, // Convert Exponents of Scalar SP FP Values to SP FP Value
        VGETMANTPD, // Extract Float64 Vector of Normalized Mantissas from Float64 Vector
        VGETMANTPS, // Extract Float32 Vector of Normalized Mantissas from Float32 Vector
        VGETMANTSD, // Extract Float64 of Normalized Mantissas from Float64 Scalar
        VGETMANTSS, // Extract Float32 Vector of Normalized Mantissa from Float32 Vector
        VINSERTF128, // Insert Packed Floating-Point Values
        VINSERTF32x4, // Insert Packed Floating-Point Values
        VINSERTF32x8, // Insert Packed Floating-Point Values
        VINSERTF64x2, // Insert Packed Floating-Point Values
        VINSERTF64x4, // Insert Packed Floating-Point Values
        VINSERTI128, // Insert Packed Integer Values
        VINSERTI32x4, // Insert Packed Integer Values
        VINSERTI32x8, // Insert Packed Integer Values
        VINSERTI64x2, // Insert Packed Integer Values
        VINSERTI64x4, // Insert Packed Integer Values
        VMASKMOV, // Conditional SIMD Packed Loads and Stores
        VMOVDQA32, // Move Aligned Packed Integer Values
        VMOVDQA64, // Move Aligned Packed Integer Values
        VMOVDQU16, // Move Unaligned Packed Integer Values
        VMOVDQU32, // Move Unaligned Packed Integer Values
        VMOVDQU64, // Move Unaligned Packed Integer Values
        VMOVDQU8, // Move Unaligned Packed Integer Values
        VPBLENDD, // Blend Packed Dwords
        VPBLENDMB, // Blend Byte/Word Vectors Using an Opmask Control
        VPBLENDMD, // Blend Int32/Int64 Vectors Using an OpMask Control
        VPBLENDMQ, // Blend Int32/Int64 Vectors Using an OpMask Control
        VPBLENDMW, // Blend Byte/Word Vectors Using an Opmask Control
        VPBROADCAST, // Load Integer and Broadcast
        VPBROADCASTB, // Load with Broadcast Integer Data from General Purpose Register
        VPBROADCASTD, // Load with Broadcast Integer Data from General Purpose Register
        VPBROADCASTM, // Broadcast Mask to Vector Register
        VPBROADCASTQ, // Load with Broadcast Integer Data from General Purpose Register
        VPBROADCASTW, // Load with Broadcast Integer Data from General Purpose Register
        VPCMPB, // Compare Packed Byte Values Into Mask
        VPCMPD, // Compare Packed Integer Values into Mask
        VPCMPQ, // Compare Packed Integer Values into Mask
        VPCMPUB, // Compare Packed Byte Values Into Mask
        VPCMPUD, // Compare Packed Integer Values into Mask
        VPCMPUQ, // Compare Packed Integer Values into Mask
        VPCMPUW, // Compare Packed Word Values Into Mask
        VPCMPW, // Compare Packed Word Values Into Mask
        VPCOMPRESSD, // Store Sparse Packed Doubleword Integer Values into Dense Memory/Register
        VPCOMPRESSQ, // Store Sparse Packed Quadword Integer Values into Dense Memory/Register
        VPCONFLICTD, // Detect Conflicts Within a Vector of Packed Dword/Qword Values into Dense Memory/ Register
        VPCONFLICTQ, // Detect Conflicts Within a Vector of Packed Dword/Qword Values into Dense Memory/ Register
        VPERM2F128, // Permute Floating-Point Values
        VPERM2I128, // Permute Integer Values
        VPERMB, // Permute Packed Bytes Elements
        VPERMD, // Permute Packed Doublewords/Words Elements
        VPERMI2B, // Full Permute of Bytes from Two Tables Overwriting the Index
        VPERMI2D, // Full Permute From Two Tables Overwriting the Index
        VPERMI2PD, // Full Permute From Two Tables Overwriting the Index
        VPERMI2PS, // Full Permute From Two Tables Overwriting the Index
        VPERMI2Q, // Full Permute From Two Tables Overwriting the Index
        VPERMI2W, // Full Permute From Two Tables Overwriting the Index
        VPERMILPD, // Permute In-Lane of Pairs of Double-Precision Floating-Point Values
        VPERMILPS, // Permute In-Lane of Quadruples of Single-Precision Floating-Point Values
        VPERMPD, // Permute Double-Precision Floating-Point Elements
        VPERMPS, // Permute Single-Precision Floating-Point Elements
        VPERMQ, // Qwords Element Permutation
        VPERMT2B, // Full Permute of Bytes from Two Tables Overwriting a Table
        VPERMT2D, // Full Permute from Two Tables Overwriting one Table
        VPERMT2PD, // Full Permute from Two Tables Overwriting one Table
        VPERMT2PS, // Full Permute from Two Tables Overwriting one Table
        VPERMT2Q, // Full Permute from Two Tables Overwriting one Table
        VPERMT2W, // Full Permute from Two Tables Overwriting one Table
        VPERMW, // Permute Packed Doublewords/Words Elements
        VPEXPANDD, // Load Sparse Packed Doubleword Integer Values from Dense Memory / Register
        VPEXPANDQ, // Load Sparse Packed Quadword Integer Values from Dense Memory / Register
        VPGATHERDD, // Gather Packed Dword Values Using Signed Dword/Qword Indices
        VPGATHERDD_1, // Gather Packed Dword, Packed Qword with Signed Dword Indices
        VPGATHERDQ, // Gather Packed Dword, Packed Qword with Signed Dword Indices
        VPGATHERDQ_1, // Gather Packed Qword Values Using Signed Dword/Qword Indices
        VPGATHERQD, // Gather Packed Dword Values Using Signed Dword/Qword Indices
        VPGATHERQD_1, // Gather Packed Dword, Packed Qword with Signed Qword Indices
        VPGATHERQQ, // Gather Packed Qword Values Using Signed Dword/Qword Indices
        VPGATHERQQ_1, // Gather Packed Dword, Packed Qword with Signed Qword Indices
        VPLZCNTD, // Count the Number of Leading Zero Bits for Packed Dword, Packed Qword Values
        VPLZCNTQ, // Count the Number of Leading Zero Bits for Packed Dword, Packed Qword Values
        VPMADD52HUQ, // Packed Multiply of Unsigned 52-bit Unsigned Integers and Add High 52-bit Products to 64-bit Accumulators
        VPMADD52LUQ, // Packed Multiply of Unsigned 52-bit Integers and Add the Low 52-bit Products to Qword Accumulators
        VPMASKMOV, // Conditional SIMD Integer Packed Loads and Stores
        VPMOVB2M, // Convert a Vector Register to a Mask
        VPMOVD2M, // Convert a Vector Register to a Mask
        VPMOVDB, // Down Convert DWord to Byte
        VPMOVDW, // Down Convert DWord to Word
        VPMOVM2B, // Convert a Mask Register to a Vector Register
        VPMOVM2D, // Convert a Mask Register to a Vector Register
        VPMOVM2Q, // Convert a Mask Register to a Vector Register
        VPMOVM2W, // Convert a Mask Register to a Vector Register
        VPMOVQ2M, // Convert a Vector Register to a Mask
        VPMOVQB, // Down Convert QWord to Byte
        VPMOVQD, // Down Convert QWord to DWord
        VPMOVQW, // Down Convert QWord to Word
        VPMOVSDB, // Down Convert DWord to Byte
        VPMOVSDW, // Down Convert DWord to Word
        VPMOVSQB, // Down Convert QWord to Byte
        VPMOVSQD, // Down Convert QWord to DWord
        VPMOVSQW, // Down Convert QWord to Word
        VPMOVSWB, // Down Convert Word to Byte
        VPMOVUSDB, // Down Convert DWord to Byte
        VPMOVUSDW, // Down Convert DWord to Word
        VPMOVUSQB, // Down Convert QWord to Byte
        VPMOVUSQD, // Down Convert QWord to DWord
        VPMOVUSQW, // Down Convert QWord to Word
        VPMOVUSWB, // Down Convert Word to Byte
        VPMOVW2M, // Convert a Vector Register to a Mask
        VPMOVWB, // Down Convert Word to Byte
        VPMULTISHIFTQB, // Select Packed Unaligned Bytes from Quadword Sources
        VPROLD, // Bit Rotate Left
        VPROLQ, // Bit Rotate Left
        VPROLVD, // Bit Rotate Left
        VPROLVQ, // Bit Rotate Left
        VPRORD, // Bit Rotate Right
        VPRORQ, // Bit Rotate Right
        VPRORVD, // Bit Rotate Right
        VPRORVQ, // Bit Rotate Right
        VPSCATTERDD, // Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices
        VPSCATTERDQ, // Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices
        VPSCATTERQD, // Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices
        VPSCATTERQQ, // Scatter Packed Dword, Packed Qword with Signed Dword, Signed Qword Indices
        VPSLLVD, // Variable Bit Shift Left Logical
        VPSLLVQ, // Variable Bit Shift Left Logical
        VPSLLVW, // Variable Bit Shift Left Logical
        VPSRAVD, // Variable Bit Shift Right Arithmetic
        VPSRAVQ, // Variable Bit Shift Right Arithmetic
        VPSRAVW, // Variable Bit Shift Right Arithmetic
        VPSRLVD, // Variable Bit Shift Right Logical
        VPSRLVQ, // Variable Bit Shift Right Logical
        VPSRLVW, // Variable Bit Shift Right Logical
        VPTERNLOGD, // Bitwise Ternary Logic
        VPTERNLOGQ, // Bitwise Ternary Logic
        VPTESTMB, // Logical AND and Set Mask
        VPTESTMD, // Logical AND and Set Mask
        VPTESTMQ, // Logical AND and Set Mask
        VPTESTMW, // Logical AND and Set Mask
        VPTESTNMB, // Logical NAND and Set
        VPTESTNMD, // Logical NAND and Set
        VPTESTNMQ, // Logical NAND and Set
        VPTESTNMW, // Logical NAND and Set
        VRANGEPD, // Range Restriction Calculation For Packed Pairs of Float64 Values
        VRANGEPS, // Range Restriction Calculation For Packed Pairs of Float32 Values
        VRANGESD, // Range Restriction Calculation From a pair of Scalar Float64 Values
        VRANGESS, // Range Restriction Calculation From a Pair of Scalar Float32 Values
        VRCP14PD, // Compute Approximate Reciprocals of Packed Float64 Values
        VRCP14PS, // Compute Approximate Reciprocals of Packed Float32 Values
        VRCP14SD, // Compute Approximate Reciprocal of Scalar Float64 Value
        VRCP14SS, // Compute Approximate Reciprocal of Scalar Float32 Value
        VREDUCEPD, // Perform Reduction Transformation on Packed Float64 Values
        VREDUCEPS, // Perform Reduction Transformation on Packed Float32 Values
        VREDUCESD, // Perform a Reduction Transformation on a Scalar Float64 Value
        VREDUCESS, // Perform a Reduction Transformation on a Scalar Float32 Value
        VRNDSCALEPD, // Round Packed Float64 Values To Include A Given Number Of Fraction Bits
        VRNDSCALEPS, // Round Packed Float32 Values To Include A Given Number Of Fraction Bits
        VRNDSCALESD, // Round Scalar Float64 Value To Include A Given Number Of Fraction Bits
        VRNDSCALESS, // Round Scalar Float32 Value To Include A Given Number Of Fraction Bits
        VRSQRT14PD, // Compute Approximate Reciprocals of Square Roots of Packed Float64 Values
        VRSQRT14PS, // Compute Approximate Reciprocals of Square Roots of Packed Float32 Values
        VRSQRT14SD, // Compute Approximate Reciprocal of Square Root of Scalar Float64 Value
        VRSQRT14SS, // Compute Approximate Reciprocal of Square Root of Scalar Float32 Value
        VSCALEFPD, // Scale Packed Float64 Values With Float64 Values
        VSCALEFPS, // Scale Packed Float32 Values With Float32 Values
        VSCALEFSD, // Scale Scalar Float64 Values With Float64 Values
        VSCALEFSS, // Scale Scalar Float32 Value With Float32 Value
        VSCATTERDPD, // Scatter Packed Single, Packed Double with Signed Dword and Qword Indices
        VSCATTERDPS, // Scatter Packed Single, Packed Double with Signed Dword and Qword Indices
        VSCATTERQPD, // Scatter Packed Single, Packed Double with Signed Dword and Qword Indices
        VSCATTERQPS, // Scatter Packed Single, Packed Double with Signed Dword and Qword Indices
        VSHUFF32x4, // Shuffle Packed Values at 128-bit Granularity
        VSHUFF64x2, // Shuffle Packed Values at 128-bit Granularity
        VSHUFI32x4, // Shuffle Packed Values at 128-bit Granularity
        VSHUFI64x2, // Shuffle Packed Values at 128-bit Granularity
        VTESTPD, // Packed Bit Test
        VTESTPS, // Packed Bit Test
        VZEROALL, // Zero All YMM Registers
        VZEROUPPER, // Zero Upper Bits of YMM Registers
        WAIT, // Wait
        WBINVD, // Write Back and Invalidate Cache
        WRFSBASE, // Write FS/GS Segment Base
        WRGSBASE, // Write FS/GS Segment Base
        WRMSR, // Write to Model Specific Register
        WRPKRU, // Write Data to User Page Key Register
        XABORT, // Transactional Abort
        XACQUIRE, // Hardware Lock Elision Prefix Hints
        XADD, // Exchange and Add
        XBEGIN, // Transactional Begin
        XCHG, // Exchange Register/Memory with Register
        XEND, // Transactional End
        XGETBV, // Get Value of Extended Control Register
        XLAT, // Table Look-up Translation

        /// <summary>
        ///
        /// </summary>     
        XLATB, // Table Look-up Translation

        /// <summary>
        ///
        /// </summary>     
        XOR, // Logical Exclusive OR

        /// <summary>
        ///
        /// </summary>     
        XORPD, // Bitwise Logical XOR of Packed Double Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        XORPS, // Bitwise Logical XOR of Packed Single Precision Floating-Point Values

        /// <summary>
        ///
        /// </summary>     
        XRELEASE, // Hardware Lock Elision Prefix Hints

        /// <summary>
        ///
        /// </summary>     
        XRSTOR, // Restore Processor Extended States

        /// <summary>
        ///
        /// </summary>     
        XRSTORS, // Restore Processor Extended States Supervisor

        /// <summary>
        ///
        /// </summary>     
        XSAVE, // Save Processor Extended States

        /// <summary>
        ///
        /// </summary>     
        XSAVEC, // Save Processor Extended States with Compaction

        /// <summary>
        ///
        /// </summary>     
        XSAVEOPT, // Save Processor Extended States Optimized


        /// <summary>
        ///
        /// </summary>     
        XSAVES, // Save Processor Extended States Supervisor
 

        /// <summary>
        ///
        /// </summary>     
        XSETBV, // Set Extended Control Register
 
        /// <summary>
        /// Test If In Transactional Execution
        /// </summary>     
        XTEST,

    }


}