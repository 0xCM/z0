//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class InstructionModels
    {                
        /// <summary>
        /// Move r8a to r8b
        /// </summary>
        /// <param name="r8a">The source register</param>
        /// <param name="r8b">The target register</param>
        [MethodImpl(Inline), Cmd("88 /r", "MOV r/m8,r8")]
        public Cmd<Reg8,Reg8> mov(Reg8 r8a, Reg8 r8b)
            => cmd(r8a,r8b);

        /// <summary>
        /// Move m8 to r8.
        /// </summary>
        /// <param name="m8">The source memory</param>
        /// <param name="r8">The target register</param>
        [MethodImpl(Inline), Cmd("88 /r", "MOV r/m8,r8")]
        public Cmd<Mem8,Reg8> mov(Mem8 m8, Reg8 r8)
            => cmd(m8,r8);

        /// <summary>
        /// Move r16a to r16b
        /// </summary>
        /// <param name="r16a">The source register</param>
        /// <param name="r16b">The target register</param>
        [MethodImpl(Inline), Cmd("89 /r", "MOV r/m16,r16")]
        public Cmd<Reg16,Reg16> mov(Reg16 r16a, Reg16 r16b)
            => cmd(r16a,r16b);

        /// <summary>
        /// Move m16 to r16
        /// </summary>
        /// <param name="m16">The source memory</param>
        /// <param name="r16">The target register</param>
        [MethodImpl(Inline), Cmd("89 /r", "MOV r/m16,r16")]
        public Cmd<Mem16,Reg16> mov(Mem16 m16, Reg16 r16)
            => cmd(m16,r16);

        /// <summary>
        /// Move r32a to r32b
        /// </summary>
        /// <param name="r32a">The source register</param>
        /// <param name="r32b">The target register</param>
        [MethodImpl(Inline), Cmd("89 /r", "MOV r/m32,r32")]
        public Cmd<Reg32,Reg32> mov(Reg32 r32a, Reg32 r32b)
            => cmd(r32a,r32b);

        /// <summary>
        /// Move m32 to r32
        /// </summary>
        /// <param name="m32">The source memory</param>
        /// <param name="r32">The target register</param>
        [MethodImpl(Inline), Cmd("89 /r", "MOV r/m32,r32")]
        public Cmd<Mem32,Reg32> mov(Mem32 m32, Reg32 r32)
            => cmd(m32,r32);

        /// <summary>
        /// Move r64a to r64b
        /// </summary>
        /// <param name="r64a">The source register</param>
        /// <param name="r64b">The target register</param>
        [MethodImpl(Inline), Cmd("REX.W + 89 /r", "MOV r/m64,r64")]
        public Cmd<Reg64,Reg64> mov(Reg64 r64a, Reg64 r64b)
            => cmd(r64a,r64b);

        /// <summary>
        /// Move m64 to r64
        /// </summary>
        /// <param name="r64a">The source register</param>
        /// <param name="r64">The target register</param>
        [MethodImpl(Inline), Cmd("REX.W + 89 /r", "MOV r/m64,r64")]
        public Cmd<Mem64,Reg64> mov(Mem64 m64, Reg64 r64)
            => cmd(m64,r64);

    }
}