//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial struct Prototypes
    {
        [ApiHost(prototypes + "emitters")]
        public unsafe struct Emitters
        {
            [Op]
            public static byte emit8u_0()
                => BitMasks.Literals.Central8x4x2;

            [Op]
            public static byte emit8u_1()
                => BitMasks.Literals.Central8x8x2;

            [Op]
            public static ushort emit16u_0()
                => BitMasks.Literals.Central16x4x2;

            [Op]
            public static ushort emit16u_1()
                => BitMasks.Literals.Central16x8x2;

            [Op]
            public static ushort emit16u_2()
                => BitMasks.Literals.Central16x16x8;

            [Op]
            public static uint emit32u_0()
                => BitMasks.Literals.Central32x4x2;

            [Op]
            public static uint emit32u_1()
                => BitMasks.Literals.Central32x8x2;

            [Op]
            public static uint emit32u_2()
                => BitMasks.Literals.Central32x16x8;

            [Op]
            public static ulong emit64u_0()
                => BitMasks.Literals.Central64x4x2;

            [Op]
            public static ulong emit64u_1()
                => BitMasks.Literals.Central64x8x2;

            [Op]
            public static ulong emit64u_2()
                => BitMasks.Literals.Central64x16x8;

        }


        [ApiHost(prototypes + "refemtter8")]
        public ref struct RefEmitter8
        {
            readonly ReadOnlySpan<byte> Data;

            int Position;

            [Op]
            public ref readonly byte Next()
            {
                if(Position< Data.Length)
                    return ref skip(Data,Position++);
                else
                {
                    Position=0;
                    return ref skip(Data,Position++);
                }
            }
        }

        [ApiHost(prototypes + "refemtter16")]
        public ref struct RefEmitter16
        {
            readonly ReadOnlySpan<ushort> Data;

            int Position;

            [Op]
            public ref readonly ushort Next()
            {
                if(Position< Data.Length)
                    return ref skip(Data,Position++);
                else
                {
                    Position=0;
                    return ref skip(Data,Position++);
                }
            }
        }

        [ApiHost(prototypes + "refemtter32")]
        public ref struct RefEmitter32
        {
            readonly ReadOnlySpan<uint> Data;

            int Position;

            [Op]
            public ref readonly uint Next()
            {
                if(Position< Data.Length)
                    return ref skip(Data,Position++);
                else
                {
                    Position=0;
                    return ref skip(Data,Position++);
                }
            }
        }

        [ApiHost(prototypes + "refemtter64")]
        public ref struct RefEmitter64
        {
            readonly ReadOnlySpan<ulong> Data;

            int Position;

            [Op]
            public ref readonly ulong Next()
            {
                if(Position< Data.Length)
                    return ref skip(Data,Position++);
                else
                {
                    Position=0;
                    return ref skip(Data,Position++);
                }
            }
        }

        [ApiHost(prototypes + "refemtter128")]
        public ref struct RefEmitter128
        {
            readonly ReadOnlySpan<Cell128> Data;

            int Position;

            [Op]
            public ref readonly Cell128 Next()
            {
                if(Position< Data.Length)
                    return ref skip(Data,Position++);
                else
                {
                    Position=0;
                    return ref skip(Data,Position++);
                }
            }
        }

        [ApiHost(prototypes + "refemtter256")]
        public ref struct RefEmitter256
        {
            readonly ReadOnlySpan<Cell256> Data;

            int Position;

            [Op]
            public ref readonly Cell256 Next()
            {
                if(Position< Data.Length)
                    return ref skip(Data,Position++);
                else
                {
                    Position=0;
                    return ref skip(Data,Position++);
                }
            }
        }
    }
}