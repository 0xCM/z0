//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly partial struct FunctionTables
    {
        [Op]
        public static F8x8 f8(MemoryAddress src, MemoryAddress dst)
            => new F8x8(src, dst);

        [Op]
        public static F16x16 f16(MemoryAddress src, MemoryAddress dst)
            => new F16x16(src, dst);

        /// <summary>
        /// Defines a function u8->u8
        /// </summary>
        public unsafe sealed class F8x8 : FunctionTable<F8x8,byte,byte,byte>
        {
            readonly Ptr<byte> PSrc;

            readonly Ptr<byte> PDst;

            readonly Index<byte> SrcMap;

            uint Size;

            const uint Capacity = 256;

            internal F8x8(MemoryAddress src, MemoryAddress dst)
            {
                Size = 0;
                PSrc = src.Pointer<byte>();
                PDst = dst.Pointer<byte>();
                SrcMap = alloc<byte>(Capacity);
            }

            [MethodImpl(Inline)]
            public F8x8 Define(ReadOnlySpan<byte> src, ReadOnlySpan<byte> dst)
            {
                SrcMap.Clear();
                var count = min(min(src.Length, dst.Length), Capacity);
                Size = (uint)count;
                for(var i=0; i<count; i++)
                {
                    ref readonly var x = ref skip(src,i);
                    ref readonly var y = ref skip(dst,i);
                    SrcMap[x] = (byte)i;
                }
                return this;
            }

            [MethodImpl(Inline)]
            ref readonly byte iY(byte x)
                => ref SrcMap[x];

            [MethodImpl(Inline)]
            public byte Fx(byte x)
                => skip(Target, iY(x));

            public ReadOnlySpan<byte> Source
            {
                [MethodImpl(Inline)]
                get => cover(PSrc.P, Size);
            }

            public ReadOnlySpan<byte> Target
            {
                [MethodImpl(Inline)]
                get => cover(PDst.P, Size);
            }
        }

        /// <summary>
        /// Defines a function u16->u16
        /// </summary>
        public unsafe sealed class F16x16 : FunctionTable<F16x16,ushort,ushort,ushort>
        {
            readonly Ptr<ushort> PSrc;

            readonly Ptr<ushort> PDst;

            readonly Index<ushort> SrcMap;

            uint Size;

            const uint Capacity = ushort.MaxValue + 1;

            internal F16x16(MemoryAddress src, MemoryAddress dst)
            {
                Size = 0;
                PSrc = src.Pointer<ushort>();
                PDst = dst.Pointer<ushort>();
                SrcMap = alloc<ushort>(Capacity);
            }

            [MethodImpl(Inline)]
            public void Define(ReadOnlySpan<ushort> src, ReadOnlySpan<ushort> dst)
            {
                var count = min(min(src.Length, dst.Length), Capacity);
                Size = (uint)count;
                for(var i=0; i<count; i++)
                {
                    ref readonly var x = ref skip(src,i);
                    ref readonly var y = ref skip(dst,i);
                    SrcMap[x] = (byte)i;
                }
            }

            [MethodImpl(Inline)]
            ref readonly ushort iY(ushort x)
                => ref SrcMap[x];

            [MethodImpl(Inline)]
            public ushort Fx(ushort x)
                => skip(Target, iY(x));

            public ReadOnlySpan<ushort> Source
            {
                [MethodImpl(Inline)]
                get => cover(PSrc.P, Size);
            }

            public ReadOnlySpan<ushort> Target
            {
                [MethodImpl(Inline)]
                get => cover(PDst.P, Size);
            }
        }
    }
}