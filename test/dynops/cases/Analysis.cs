//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static ReferenceImplementations;
    using static FunctionDisassembly;

    public readonly struct ReferenceImplementations
    {
        /// <summary>
        /// Computes the sum of two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        public static byte add(byte x, byte y)
            => (byte)(x+y);

        /// <summary>
        /// Computes the difference between two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        public static byte sub(byte x, byte y)
            => (byte)(x-y);

        /// <summary>
        /// Computes the product of two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        public static byte mul(byte x, byte y)
            => (byte)(x*y);

        /// <summary>
        /// Computes the quotient between two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        public static byte div(byte x, byte y)
            => (byte)(x/y);

        /// <summary>
        /// Computes the bitwise and between two unsigned 8-bit integers
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <remarks>Note that plainy idiotic casting required to teach the compiler that
        /// multiplication of unsigned 8-bit integers should not produce a 32-bit signed integer</remarks>
        public static byte and(byte x, byte y)
            => (byte)(x&y);
    }

    public readonly struct FunctionDisassembly
    {
        /// <summary>
        /// X86-executable code obtained by dissasembling a c# function with implementation identical to <see cref="add"/>
        /// </summary>
        public static ReadOnlySpan<byte> add_ᐤ8iㆍ8iᐤ 
            => new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x0f,0xbe,0xc1,0x48,0x0f,0xbe,0xd2,0x03,0xc2,0x48,0x0f,0xbe,0xc0,0xc3};

        /// <summary>
        /// X86-executable code obtained by dissasembling a c# function with implementation identical to <see cref="sub"/>
        /// </summary>
        public static ReadOnlySpan<byte> sub_ᐤ8uㆍ8uᐤ 
            => new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x2b,0xc2,0x0f,0xb6,0xc0,0xc3};

        /// <summary>
        /// X86-executable code obtained by dissasembling a c# function with implementation identical to <see cref="mul"/>
        /// </summary>
        public static ReadOnlySpan<byte> mul_ᐤ8uㆍ8uᐤ
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0xc3};    

        /// <summary>
        /// X86-executable code obtained by dissasembling a c# function with implementation identical to <see cref="mul"/>
        /// </summary>
        public static ReadOnlySpan<byte> div_ᐤ8uㆍ8uᐤ 
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xca,0x99,0xf7,0xf9,0x0f,0xb6,0xc0,0xc3};

        /// <summary>
        /// X86-executable code obtained by dissasembling a c# function with implementation identical to <see cref="and"/>
        /// </summary>
        public static ReadOnlySpan<byte> and_ᐤ8uㆍ8uᐤ 
            => new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x23,0xc2,0x0f,0xb6,0xc0,0xc3};            
    }

    public readonly struct DisassemblyInvocation
    {
        /// <summary>
        /// Executes the code defined by <see cref="mul_ᐤ8uㆍ8uᐤ" over caller-supplied operands/>
        /// </summary>
        /// <param name="f">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static byte eval(Kinds.Mul f, byte x, byte y)
            => ExecutionEngine.eval(x,y, mul_ᐤ8uㆍ8uᐤ);

        /// <summary>
        /// Executes the code defined by <see cref="sub_ᐤ8uㆍ8uᐤ" over caller-supplied operands/>
        /// </summary>
        /// <param name="f">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static byte eval(Kinds.Sub f, byte x, byte y)
            => ExecutionEngine.eval(x, y, sub_ᐤ8uㆍ8uᐤ);

        /// <summary>
        /// Executes the code defined by <see cref="and_ᐤ8uㆍ8uᐤ" over caller-supplied operands/>
        /// </summary>
        /// <param name="f">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static byte eval(Kinds.And f, byte x, byte y)
            => ExecutionEngine.eval(x, y, and_ᐤ8uㆍ8uᐤ);

        /// <summary>
        /// Tests whether the disassembled code, when executed, agrees with the reference implemenation
        /// </summary>
        /// <param name="kind">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static bit check(Kinds.And f, byte x, byte y)
        {
            var expect = mul(x,y);
            var actual = eval(f, x, y);
            return actual == expect;
        }

        public static byte eval(byte x, byte y)
        {
            var f = mul_ᐤ8uㆍ8uᐤ;
            return ExecutionEngine.eval(x, y, mul_ᐤ8uㆍ8uᐤ);
        }                

    }
}