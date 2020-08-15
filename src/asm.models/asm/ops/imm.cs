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
        public static ImmInfo imm(byte value, bool direct)
            => new ImmInfo(W.W8, value, direct, null);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(short value, bool direct, SignExensionKind sek)
            => new ImmInfo(W.W16, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(ushort value, bool direct)
            => new ImmInfo(W.W16, value, direct, null);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(int value, bool direct, SignExensionKind sek)
            => new ImmInfo(W.W32, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(uint value, bool direct)
            => new ImmInfo(W.W32, value, direct);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(long value, bool direct, SignExensionKind sek)
            => new ImmInfo(W.W64, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(ulong value, bool direct)
            => new ImmInfo(W.W64, value, direct);
    }
}