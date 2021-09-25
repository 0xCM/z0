//-----------------------------------------------------------------------------
// Copyright   : (c) LLVM Project
// License     : Apache-2.0 WITH LLVM-exceptions
// Source      : Tablgen: ws/sources/datasets/llvm.tblgen.headers/X86.gen-register-info.h
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public struct MCInst
    {


    }

    public struct MCOperand
    {

    }

    public struct MCExpr
    {


    }

    public enum MCExprKind : byte
    {
        //< Binary expressions.
        Binary,
        //< Constant expressions.
        Constant,
        //< References to labels and assigned expressions.
        SymbolRef,
        //< Unary expressions.
        Unary,
        //< Target specific expression.
        Target
    }

    public enum MachineOperandType : byte
    {
        // Uninitialized.
        kInvalid,
        // Register operand.
        kRegister,
        // Immediate operand.
        kImmediate,
        // Single-floating-point immediate operand.
        kSFPImmediate,
        // Double-Floating-point immediate operand.
        kDFPImmediate,
        // Relocatable immediate operand.
        kExpr,
        // Sub-instruction operand.
        kInst
    };
}