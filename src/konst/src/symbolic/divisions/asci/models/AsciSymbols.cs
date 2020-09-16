//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    /// <summary>
    /// Encoded x86 bytes extracted from a memory source
    /// </summary>
    [ApiHost]
    public readonly struct AsciSymbols
    {
        /// <summary>
        /// The encoded bytes
        /// </summary>
        public readonly AsciSymbol[] Data;

        public Span<byte> ByteEdit
        {
            [MethodImpl(Inline), Op]
            get => recover<AsciSymbol,byte>(span(Data));
        }

        public ReadOnlySpan<byte> ByteView
        {
            [MethodImpl(Inline), Op]
            get => ByteEdit;
        }

        /// <summary>
        /// Returns a reference to the encoded data
        /// </summary>
        public Ref Ref
        {
            [MethodImpl(Inline), Op]
            get => memory.@ref(First, Size);
        }

        public ref AsciSymbol First
        {
            [MethodImpl(Inline), Op]
            get => ref Data[0];
        }

        public uint Count
        {
            [MethodImpl(Inline), Op]
            get => (uint)Length;
        }

        public int Length
        {
            [MethodImpl(Inline), Op]
            get => Data?.Length ?? 0;
        }

        public uint Size
        {
            [MethodImpl(Inline), Op]
            get => (uint) Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline), Op]
            get => Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline), Op]
            get => Length > 0;
        }

        public ref AsciSymbol this[uint index]
        {
            [MethodImpl(Inline), Op]
            get => ref Data[index];
        }

        [MethodImpl(Inline), Op]
        public AsciSymbols(AsciSymbol[] bytes)
            => Data = bytes ?? new AsciSymbol[0];

        [MethodImpl(Inline), Op]
        public static implicit operator AsciSymbol[](in AsciSymbols src)
            => src.Data;

        [MethodImpl(Inline), Op]
        public static implicit operator AsciSymbols(AsciSymbol[] src)
            => new AsciSymbols(src);

        [MethodImpl(Inline), Op]
        public static implicit operator ReadOnlySpan<byte>(in AsciSymbols src)
            => src.ByteEdit;

        [MethodImpl(Inline), Op]
        public static bool operator==(in AsciSymbols a, in AsciSymbols b)
            => a.Equals(b);

        [MethodImpl(Inline), Op]
        public static bool operator!=(in AsciSymbols a, in AsciSymbols b)
            => !a.Equals(b);

        [MethodImpl(Inline), Op]
        public bool Equals(AsciSymbols src)
        {
            if(IsNonEmpty && src.IsNonEmpty)
                return Data.SequenceEqual(src.Data);
            else
                return false;
        }

        [MethodImpl(Inline), Op]
        public string Format()
            => Hex.format(ByteView);

        [MethodImpl(Inline), Op]
        public string Format(in HexFormatOptions config)
            => Hex.format(ByteView, config);

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is AsciSymbols x && Equals(x);

        public override string ToString()
            => Format();

        public static AsciSymbols Empty
            => default;
    }
}