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

    using B = IceInstructionBytes;

    [ApiComplete]
    public readonly ref struct IceInstructions
    {
        [Ignore]
        public static IceInstructions init()
            => new IceInstructions(Enums.literals<IceInstructionFieldIndex>(), Enums.literals<IceInstructionFieldSize>());

        public readonly ReadOnlySpan<IceInstructionFieldIndex> Indices;

        public readonly ReadOnlySpan<IceInstructionFieldSize> Sizes;

        public IceInstructions(IceInstructionFieldIndex[] fields, IceInstructionFieldSize[] sizes)
        {
            Indices = fields;
            Sizes = sizes;
        }

        [MethodImpl(Inline)]
        public ref readonly byte Index(IceInstructionField field)
            => ref @as<IceInstructionFieldIndex,byte>(skip(Indices, (byte)field));

        [MethodImpl(Inline)]
        public ref readonly byte Size(IceInstructionField field)
            => ref @as<IceInstructionFieldSize,byte>(skip(Sizes, (byte)field));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T Segment<T>(IceInstructionField field, in IceInstructionData src)
            where T : unmanaged
        {
            ref readonly var idx = ref Index(field);
            ref readonly var size = ref Size(field);
            var b = @bytes(src);
            var seg = memory.slice(b,idx,size);
            return ref first(recover<T>(seg));
        }

        [MethodImpl(Inline)]
        public static Span<T> slice<T>(in IceInstructionData src, B start, B end)
            where T : unmanaged
                => memory.recover<byte,T>(z.slice(@bytes(src), (byte)start, (byte)(end - start)));

        [MethodImpl(Inline), Op]
        public static ref ulong nextRip(in IceInstructionData src)
            => ref first(slice<ulong>(src, B.NextRipStart, B.NextRipEnd));

        [MethodImpl(Inline), Op]
        public static ref IceCodeFlags codeFlags(in IceInstructionData src)
            => ref first(slice<IceCodeFlags>(src, B.CodeFlagsStart, B.CodeFlagsEnd));

        [MethodImpl(Inline), Op]
        public static ref IceOpKindFlags opKindFlags(in IceInstructionData src)
            => ref first(slice<IceOpKindFlags>(src, B.OpKindFlagsStart, B.OpKindFlagsEnd));

        [MethodImpl(Inline), Op]
        public static ref uint imm(in IceInstructionData src)
            => ref first(slice<uint>(src, B.ImmStart, B.ImmEnd));

        [MethodImpl(Inline), Op]
        public static ref uint memdx(in IceInstructionData src)
            => ref first(slice<uint>(src, B.MemDxStart, B.MemDxEnd));

        [MethodImpl(Inline), Op]
        public static ref IceMemFlags memFlags(in IceInstructionData src)
            => ref first(slice<IceMemFlags>(src, B.MemFlagsStart, B.MemFlagsEnd));

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