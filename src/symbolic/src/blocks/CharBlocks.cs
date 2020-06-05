//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Control;

    [ApiHost]
    public readonly partial struct CharBlocks : IApiHost<CharBlocks>
    {
        [MethodImpl(Inline), Op]
        static Span<byte> u8span<T>(in T src)
            where T : struct
                => span8u(ref edit(src));

        [MethodImpl(Inline), Op]
        static Span<ushort> u16span<T>(in T src)
            where T : struct
                => span16u(ref edit(src));

        [MethodImpl(Inline), Op]
        static Span<char> c16span<T>(in T src)
            where T : struct
                => span16c(ref edit(src));

        [MethodImpl(Inline), Op]
        static Span<uint> u32span<T>(in T src)
            where T : struct
                => span32u(ref edit(src));

        [MethodImpl(Inline), Op]
        static Span<ulong> u64span<T>(in T src)
            where T : struct
                => span64u(ref edit(src));

        [MethodImpl(Inline), Op]
        static ref byte u8ref<T>(in T src)
            => ref cast<T,byte>(src);

        [MethodImpl(Inline), Op]
        static ref byte u8ref<T>(in T src, int offset)
            => ref Unsafe.Add(ref cast<T,byte>(src), offset);

        [MethodImpl(Inline), Op]
        static ref ushort u16ref<T>(in T src)
            => ref cast<T,ushort>(src);

        [MethodImpl(Inline), Op]
        static ref ushort u16ref<T>(in T src, int offset)
            => ref Unsafe.Add(ref cast<T,ushort>(src), offset);

        [MethodImpl(Inline), Op]
        static ref uint u32ref<T>(in T src)
            => ref cast<T,uint>(src);

        [MethodImpl(Inline), Op]
        static ref uint u32ref<T>(in T src, int offset)
            => ref Unsafe.Add(ref cast<T,uint>(src), offset);

        [MethodImpl(Inline), Op]
        static ref ulong u64ref<T>(in T src)
            => ref cast<T,ulong>(src);

        [MethodImpl(Inline), Op]
        static ref char c16<T>(in T src)
            => ref cast<T,char>(src);

        [MethodImpl(Inline), Op]
        static ref char c16<T>(in T src, int offset)
            => ref Unsafe.Add(ref cast<T,char>(src), offset);

        [MethodImpl(Inline), Op]
        static Span<char> c16s<T>(in T src)
            where T : struct            
                => span16c(ref edit(src));

        public readonly struct CharBlock1
        {
            public readonly char Data;
        }

        public readonly struct CharBlock2
        {
            public readonly CharBlock1 Lo;

            public readonly CharBlock1 Hi;
        }

        public readonly struct CharBlock3
        {
            public readonly CharBlock2 A;

            public readonly CharBlock1 B;
        }

        public readonly struct CharBlock4
        {
            public readonly CharBlock2 Lo;

            public readonly CharBlock2 Hi;
        }

        public readonly struct CharBlock5
        {
            public readonly CharBlock4 A;

            public readonly CharBlock1 B;
        }

        public readonly struct CharBlock6
        {
            public readonly CharBlock5 A;

            public readonly CharBlock1 B;
        }

        public readonly struct CharBlock7
        {
            public readonly CharBlock6 A;

            public readonly CharBlock1 B;
        }

        public readonly struct CharBlock8
        {
            public readonly CharBlock4 Lo;

            public readonly CharBlock4 Hi;
        }

        public readonly struct CharBlock9
        {
            public readonly CharBlock8 A;

            public readonly CharBlock1 B;
        }

        public readonly struct CharBlock10
        {
            public readonly CharBlock8 A;

            public readonly CharBlock2 B;
        }

        public readonly struct CharBlock11
        {
            public readonly CharBlock10 A;

            public readonly CharBlock1 B;
        }

        public readonly struct CharBlock12
        {
            public readonly CharBlock8 A;

            public readonly CharBlock4 B;
        }

        public readonly struct CharBlock13
        {
            public readonly CharBlock12 A;

            public readonly CharBlock1 B;
        }

        public readonly struct CharBlock14
        {
            public readonly CharBlock7 Lo;

            public readonly CharBlock7 Hi;
        }

        public readonly struct CharBlock15
        {
            public readonly CharBlock10 A;

            public readonly CharBlock5 B;
        }

        public readonly struct CharBlock16
        {
            public readonly CharBlock8 Lo;

            public readonly CharBlock8 Hi;
        }

        public readonly struct CharBlock32
        {
            public readonly CharBlock16 Lo;

            public readonly CharBlock16 Hi;
        }
    }
}