//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct HashBlocks
    {
        [Op]
        public static HashBlock32 alloc(W32 w, N64 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N128 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N256 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N512 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N1024 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N2048 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N4096 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N8192 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N16384 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

        [Op]
        public static HashBlock32 alloc(W32 w, N32768 n)
            => new HashBlock32(memory.alloc<Hash32>(n));

    }


    public readonly struct HashBlock32
    {
        readonly Index<Hash32> Data;

        [MethodImpl(Inline)]
        internal HashBlock32(Index<Hash32> src)
        {
            Data = src;
        }

        public uint SlotCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Span<Hash32> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<Hash32> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref Hash32 this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }

    public readonly struct HashBlock32<N>
        where N : unmanaged, ITypeNat
    {
        readonly Index<Hash32> Data;

        public uint SlotCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Span<Hash32> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<Hash32> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

    }

    public readonly struct HashBlock<T>
        where T : unmanaged, IHashCode<T,T>
    {
        readonly Index<Hash<T>> Data;

        public ref Hash<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint SlotCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Span<Hash<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<Hash<T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

    }

    public readonly struct HashBlock<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged, IHashCode<T,T>
    {
        readonly Index<Hash<T>> Data;

        public ref Hash<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint SlotCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Span<Hash<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<Hash<T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }

    public readonly struct Hash<T>
        where T : unmanaged, IHashCode<T,T>
    {
        T HashCode {get;}

        [MethodImpl(Inline)]
        public Hash(T src)
        {
            HashCode = src;
        }

        public T Value
        {
            [MethodImpl(Inline)]
            get => HashCode.Value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Hash<T>(T src)
            => new Hash<T>(src);
    }
}