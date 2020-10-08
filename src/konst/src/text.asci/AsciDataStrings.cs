//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;
    using static AsciKonst;

    [ApiHost]
    public readonly struct AsciDataStrings
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> charbytes(N0 index)
            => CharBytes;

        [MethodImpl(Inline), Op]
        public string @string(sbyte offset, sbyte count)
            => slice(AsciCharString, offset, count);

        /// <summary>
        /// Returns the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of codes to select</param>
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciCharCode> codes(sbyte offset, sbyte count)
            => recover<AsciCharCode>(AsciKonst.CodeBytes.Slice(offset,count));

        /// <summary>
        /// Returns the asci characters corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<char> chars(sbyte offset, sbyte count)
            => z.slice(z.recover<char>(CharBytes), offset, count);

        /// <summary>
        /// Returns the asci symbols corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<AsciChar> symbols(sbyte offset, sbyte count)
            => recover<char,AsciChar>(chars(offset,count));

        /// <summary>
        /// Returns the uint16 asci scalar values corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<ushort> scalars(sbyte offset, sbyte count)
            => recover<char,ushort>(chars(offset,count));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<char> Text(N0 index)
            => AsciChars;

        ReadOnlySpan<int> ByteResourceLength
        {
            [MethodImpl(Inline), Op]
            get => new int[2]{CharBytes.Length, B001.Length};
        }

        ReadOnlySpan<int> TextResourceLength
        {
            [MethodImpl(Inline), Op]
            get => new int[2]{AsciChars.Length, C001.Length};
        }

        ReadOnlySpan<MemoryAddress> ByteResources
        {
            [MethodImpl(Inline), Op]
            get => new MemoryAddress[2]{address(first(CharBytes)), address(first(B001))};
        }

        ReadOnlySpan<MemoryAddress> TextResources
        {
            [MethodImpl(Inline), Op]
            get => new MemoryAddress[2]{address(first(AsciChars)), address(first(C001))};
        }

        ReadOnlySpan<ResIdentity<byte>> ByteResInfo
            => new ResIdentity<byte>[ByteResCount]{
                Resources.identify<byte>(
                    name: nameof(CharBytes),
                    location: address(first(CharBytes)),
                    length: CharBytes.Length),
                Resources.identify<byte>(
                    name: nameof(B001),
                    location: address(first(B001)),
                    length: B001.Length),
                };

        ReadOnlySpan<ResIdentity<char>> TextResInfo
            => new ResIdentity<char>[TextResCount]{
                Resources.identify<char>(
                    name: nameof(AsciCharString),
                    location: address(first(AsciChars)),
                    length: AsciCharString.Length),
                Resources.identify<char>(
                    name: nameof(S001),
                    location: address(first(C001)),
                    length: S001.Length),
                };


        public static AsciDataStrings Service
            => default;

        string AsciCharString
        {
            [Op]
            get => "00000000000000000000000000000000 !\"#$%&0()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[0]^_`abcdefghijklmnopqrstuvwxyz{|}~0";
        }

        public ReadOnlySpan<char> AsciChars
        {
            [MethodImpl(Inline)]
            get => AsciCharString;
        }

        static string LoLetterData
        {
            [Op]
            get => "abcdefghijklmnopqrstuvwxyz";
        }

        static string UpLetterData
        {
            [Op]
            get => "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public static ReadOnlySpan<char> LettersLo
        {
            [Op]
            get => LoLetterData;
        }

        public static ReadOnlySpan<char> LettersUp
        {
            [Op]
            get => UpLetterData;
        }

        string S001
        {
            [Op]
            get => "0123456789ABCDEF";
        }

        public ReadOnlySpan<char> C001
        {
            [Op]
            get => S001;
        }

        const int TextResCount = 2;

        const int ByteResCount = 2;

        public static ReadOnlySpan<byte> B001
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
    }
}