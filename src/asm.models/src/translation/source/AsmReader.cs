//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ice
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using B = InstructionBytes;

    [ApiHost]
    public readonly struct AsmReader
    {
        [MethodImpl(Inline)]
        public static Span<T> slice<T>(in IceInstructionData src, B start, B end)
            where T : unmanaged
                => z.recover<byte,T>(z.slice(@bytes(src), (byte)start, (byte)(end - start)));

        [MethodImpl(Inline), Op]
        public static ref ulong nextRip(in IceInstructionData src)
            => ref first(slice<ulong>(src, B.NextRipStart, B.NextRipEnd));

        [MethodImpl(Inline), Op]
        public static ref CodeFlags codeFlags(in IceInstructionData src)
            => ref first(slice<CodeFlags>(src, B.CodeFlagsStart, B.CodeFlagsEnd));

        [MethodImpl(Inline), Op]
        public static ref OpKindFlags opKindFlags(in IceInstructionData src)
            => ref first(slice<OpKindFlags>(src, B.OpKindFlagsStart, B.OpKindFlagsEnd));

        [MethodImpl(Inline), Op]
        public static ref uint imm(in IceInstructionData src)
            => ref first(slice<uint>(src, B.ImmStart, B.ImmEnd));

        [MethodImpl(Inline), Op]
        public static ref uint memdx(in IceInstructionData src)
            => ref first(slice<uint>(src, B.MemDxStart, B.MemDxEnd));

        [MethodImpl(Inline), Op]
        public static ref MemFlags memFlags(in IceInstructionData src)
            => ref first(slice<MemFlags>(src, B.MemFlagsStart, B.MemFlagsEnd));

        [MethodImpl(Inline), Op]
        public static ref byte basereg(in IceInstructionData src)
            => ref first(slice<byte>(src, B.BaseRegStart, B.BaseRegEnd));

        [MethodImpl(Inline), Op]
        public static ref byte indexreg(in IceInstructionData src)
            => ref first(slice<byte>(src, B.IndexRegStart, B.IndexRegEnd));

        [MethodImpl(Inline), Op]
        public static ref byte reg0(in IceInstructionData src)
            => ref first(slice<byte>(src, B.Reg0Start, B.Reg0End));

        [MethodImpl(Inline), Op]
        public static ref byte reg1(in IceInstructionData src)
            => ref first(slice<byte>(src, B.Reg1Start, B.Reg1End));

        [MethodImpl(Inline), Op]
        public static ref byte reg2(in IceInstructionData src)
            => ref first(slice<byte>(src, B.Reg2Start, B.Reg2End));

        [MethodImpl(Inline), Op]
        public static ref byte reg3(in IceInstructionData src)
            => ref first(slice<byte>(src, B.Reg3Start, B.Reg3End));
    }
}