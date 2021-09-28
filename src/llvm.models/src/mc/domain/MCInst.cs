//-----------------------------------------------------------------------------
// Copyright   : (c) LLVM Project
// License     : Apache-2.0 WITH LLVM-exceptions
// Source      : Tablgen: ws/sources/datasets/llvm.tblgen.headers/X86.gen-register-info.h
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    /// <summary>
    /// Defines an X86 instruction representation compatible with MC tooling output/input
    /// </summary>
    public readonly partial struct MCDomain
    {
        public struct MCOperand
        {
            ByteBlock16 Data;

            public MCOperandKind Kind
            {
                [MethodImpl(Inline)]
                get => (MCOperandKind)Data[15];
                set => Data[15] = (byte)value;
            }
        }

        public struct MCReg
        {
            ByteBlock16 Data;

            public RegId Id
            {
                [MethodImpl(Inline)]
                get => (RegId)Data.A;

                [MethodImpl(Inline)]
                set => Data.A = (ulong)value;
            }
        }

        public struct MCImm
        {
            ByteBlock16 Data;

            public long Value
            {
                [MethodImpl(Inline)]
                get => (long)Data.A;

                [MethodImpl(Inline)]
                set => Data.B = (ulong)value;
            }
        }

        public struct MCMem
        {
            ByteBlock16 Data;
        }

        public struct MCEncoding
        {
            public HexArray16 Value;
        }

        public enum MCOperandKind
        {
            None,

            Reg,

            Imm,

            Mem,

            Expr
        }

        public struct MCInst
        {
            public AsmId Id;

            public MCEncoding Encoding;
        }

        public struct MCExpr
        {
            ByteBlock16 Data;
        }
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