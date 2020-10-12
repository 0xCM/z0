//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    public readonly unsafe struct InstructionTable
    {
        readonly ushort[] Keys;

        readonly byte[] Data;

        public ushort EntryCount {get;}

        [MethodImpl(Inline)]
        public InstructionTable(ushort count)
        {
            EntryCount = count;
            Keys = new ushort[EntryCount];
            Data = new byte[EntryCount];
        }

        ushort LastIndex
        {
            [MethodImpl(Inline)]
            get => (ushort)(EntryCount - 1);
        }

        [MethodImpl(Inline)]
        bool IsLastIndex(ushort index)
            => index == LastIndex;

        [MethodImpl(Inline)]
        ref ushort Key(ushort index)
            => ref Keys[index];

        [MethodImpl(Inline)]
        public Entry Item(ushort index)
        {
            var data = span(Data);
            ref readonly var key = ref Key(index);
            if(IsLastIndex(index))
                return new Entry(key,slice(data, key));
            else
            {
                ref readonly var next = ref Key(math.inc(index));
                var length = math.sub(skip(data,key), skip(data,next));
                return new Entry(key,slice(data, key, length));
            }
        }

        public readonly ref struct Entry
        {
            public ushort Key {get;}

            readonly Span<byte> Data;

            [MethodImpl(Inline)]
            public Entry(ushort key, Span<byte> data)
            {
                Key = key;
                Data = data;
            }

            public uint4 Size
            {
                [MethodImpl(Inline)]
                get => (byte)Data.Length;
            }

            public Span<byte> Edit
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public ReadOnlySpan<byte> View
            {
                [MethodImpl(Inline)]
                get => Data;
            }
        }
    }
}