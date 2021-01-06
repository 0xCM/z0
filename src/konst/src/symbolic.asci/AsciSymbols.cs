//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Part;
    using static AsciKonst;

    [ApiHost(ApiNames.AsciSymbols, true)]
    public readonly struct AsciSymbols
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> charbytes(N0 index)
            => CharBytes;

        [MethodImpl(Inline), Op]
        public static string @string(sbyte offset, sbyte count)
            => text.slice(AsciCharString, offset, count);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(in asci16 src)
            => recover<AsciCharCode>(bytes(src));

        /// <summary>
        /// Returns the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of codes to select</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(sbyte offset, sbyte count)
            => recover<AsciCharCode>(AsciKonst.CodeBytes.Slice(offset,count));

        /// <summary>
        /// Returns the asci characters corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(sbyte offset, sbyte count)
            => slice(recover<char>(CharBytes), offset, count);

        /// <summary>
        /// Returns the asci symbols corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciSymbol> symbols(sbyte offset, sbyte count)
            => recover<char,AsciSymbol>(chars(offset,count));

        /// <summary>
        /// Returns the uint16 asci scalar values corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ushort> scalars(sbyte offset, sbyte count)
            => recover<char,ushort>(chars(offset,count));

        ReadOnlySpan<MemoryAddress> ByteResources
        {
            [MethodImpl(Inline), Op]
            get => new MemoryAddress[2]{address(first(CharBytes)), address(first(B001))};
        }

        ReadOnlySpan<MemoryAddress> TextResources
        {
            [MethodImpl(Inline), Op]
            get => new MemoryAddress[2]{address(first(AsciChars)), address(first(UppercaseHexDigits))};
        }

        public static string AsciCharString
        {
            [Op]
            get => "00000000000000000000000000000000 !\"#$%&0()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[0]^_`abcdefghijklmnopqrstuvwxyz{|}~0";
        }

        public static ReadOnlySpan<char> AsciChars
        {
            [MethodImpl(Inline)]
            get => AsciCharString;
        }

        public static string LowercaseLetterString
        {
            [Op]
            get => "abcdefghijklmnopqrstuvwxyz";
        }

        public static string UppercaseLetterString
        {
            [Op]
            get => "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        public static ReadOnlySpan<char> LowercaseLetters
        {
            [Op]
            get => LowercaseLetterString;
        }

        public static ReadOnlySpan<char> UppercaseLetters
        {
            [Op]
            get => UppercaseLetterString;
        }

        public static string UppercaseHexString
        {
            [Op]
            get => "0123456789ABCDEF";
        }

        public static ReadOnlySpan<char> UppercaseHexDigits
        {
            [Op]
            get => UppercaseHexString;
        }

        const int TextResCount = 2;

        const int ByteResCount = 2;

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
                    name: nameof(UppercaseHexString),
                    location: address(first(UppercaseHexDigits)),
                    length: UppercaseHexString.Length),
                };

        static ReadOnlySpan<byte> B001
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
    }
}