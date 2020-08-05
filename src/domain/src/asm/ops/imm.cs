//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using Z0.Asm;
    
    using static Konst;

    using W = NumericWidth;
   
    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(byte value, bool direct)
            => new AsmImmInfo(W.W8, value, direct, null);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(short value, bool direct, SignExensionKind sek)
            => new AsmImmInfo(W.W16, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(ushort value, bool direct)
            => new AsmImmInfo(W.W16, value, direct, null);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(int value, bool direct, SignExensionKind sek)
            => new AsmImmInfo(W.W32, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(uint value, bool direct)
            => new AsmImmInfo(W.W32, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(long value, bool direct, SignExensionKind sek)
            => new AsmImmInfo(W.W64, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(ulong value, bool direct)
            => new AsmImmInfo(W.W64, value, direct);
    }
}