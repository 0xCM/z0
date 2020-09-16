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

    [ApiDataType]
    public readonly ref struct InstructionBitField
    {
        [Ignore]
        public static InstructionBitField init()
            => new InstructionBitField(Enums.literals<InstructionFieldIndex>(), Enums.literals<InstructionFieldSize>());

        public readonly ReadOnlySpan<InstructionFieldIndex> Indices;

        public readonly ReadOnlySpan<InstructionFieldSize> Sizes;

        public InstructionBitField(InstructionFieldIndex[] fields, InstructionFieldSize[] sizes)
        {
            Indices = fields;
            Sizes = sizes;
        }

        [MethodImpl(Inline)]
        public ref readonly byte Index(InstructionField field)
            => ref @as<InstructionFieldIndex,byte>(skip(Indices, (byte)field));

        [MethodImpl(Inline)]
        public ref readonly byte Size(InstructionField field)
            => ref @as<InstructionFieldSize,byte>(skip(Sizes, (byte)field));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T Segment<T>(InstructionField field, in IceInstructionData src)
            where T : unmanaged
        {
            ref readonly var idx = ref Index(field);
            ref readonly var size = ref Size(field);
            var b = @bytes(src);
            var seg = slice(b,idx,size);
            return ref first(recover<T>(seg));
        }
    }
}