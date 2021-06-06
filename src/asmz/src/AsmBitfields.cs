//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    // ModRM=[mod:[6,7] | reg:[3,5] | r/m:[0,2]]
    // REX=[0100 | W:4 | R:3 | X:2 | B:1 ]
    // SIB=[Scale:[6,7] | Index:[3,5] | Base:[0,2]]
    [ApiHost]
    public readonly struct AsmBitfields
    {
        static ReadOnlySpan<byte> add() => default;

        static ReadOnlySpan<byte> ADD
            => new byte[]{};

        [MethodImpl(Inline)]
        static StringAddress location(string src)
            => StringAddress.resource(src);

        [Op]
        public static BitfieldSection modrm()
            => ModRM.definition();

        [ApiHost("asmbitfields.modrm")]
        public readonly struct ModRM
        {
            [Op]
            public static BitfieldSection definition()
                => BitfieldSpecs.section(FieldName, ModRM.segments().ToArray());

            [MethodImpl(Inline)]
            public static ReadOnlySpan<BitfieldSeg> segments()
            {
                var storage = ByteBlock30.Empty.Bytes;
                var dst = recover<BitfieldSeg>(storage);
                seek(dst,0) = BitfieldSpecs.segment(RmName, 0,2);
                seek(dst,1) = BitfieldSpecs.segment(RegName, 3,5);
                seek(dst,2) = BitfieldSpecs.segment(ModName, 6,7);
                return dst;
            }

            static StringAddress FieldName
            {
                [MethodImpl(Inline)]
                get => location(nameof(ModRM));
            }

            static StringAddress RmName
            {
                [MethodImpl(Inline)]
                get => location("r/m");
            }

            static StringAddress RegName
            {
                [MethodImpl(Inline)]
                get => location("reg");
            }

            static StringAddress ModName
            {
                [MethodImpl(Inline)]
                get => location("mod");
            }
        }
    }
}