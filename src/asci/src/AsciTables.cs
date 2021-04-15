//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static AsciCharData;

    using F = AsciCodeFacets;

    [Flags]
    public enum AsciTableKind : byte
    {
        None = 0,

        Digits = 1,

        LowerLetters = 2,

        UpperLetters = 4,
    }

    public readonly struct AsciCodeTable
    {
        readonly Cell128 Data;

        readonly Cell128 Facets;

        [MethodImpl(Inline)]
        internal AsciCodeTable(Cell128 src, byte count, AsciTableKind kind)
        {
            Data = src;
            Facets = default;
            seek(Facets,0) = count;
            seek(Facets,1) = (byte)kind;
        }

        public byte Count
        {
            [MethodImpl(Inline)]
            get => skip(Facets.Bytes,0);
        }

        public AsciTableKind Kind
        {
            [MethodImpl(Inline)]
            get => (AsciTableKind)skip(Facets.Bytes,1);
        }

        public ReadOnlySpan<AsciCharCode> Codes
        {
            [MethodImpl(Inline), Op]
            get => slice(recover<AsciCharCode>(Data.Bytes),0, Count);
        }

        public ReadOnlySpan<char> Chars
        {
            [MethodImpl(Inline), Op]
            get => recover<char>(bytes(cpu.vinflate256x16u(Data.ToVector<byte>())));
        }
    }

    [ApiHost]
    public readonly struct AsciTables
    {
        [MethodImpl(Inline), Op]
        static AsciCodeTable table(Cell128 data, byte count, AsciTableKind kind)
            => new AsciCodeTable(data,count,kind);

        [MethodImpl(Inline), Op]
        static AsciCodeTable table(AsciCharCode min, byte count, AsciTableKind kind)
        {
            var codes = bytes(Codes);
            var storage = Cells.alloc(w128);
            var dst = storage.Bytes;
            var selected = slice(codes, (byte)min, count);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(selected,i);
            return table(storage, count,kind);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> digits()
            => slice(Codes,(byte)F.MinDigitCode,F.DigitCount);

        [MethodImpl(Inline), Op]
        public static ref AsciCodeTable digits(out AsciCodeTable dst)
        {
            dst = table(F.MinDigitCode,F.DigitCount, AsciTableKind.Digits);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> letters(LowerCased @case)
            => slice(Codes,(byte)F.MinLowerCode,F.LowerCount);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> letters(UpperCased @case)
            => slice(Codes,(byte)F.MinUpperCode,F.UpperCount);
    }
}