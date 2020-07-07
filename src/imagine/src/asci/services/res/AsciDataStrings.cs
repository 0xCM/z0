//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Konst;
    using static AsciKonst;

    public readonly struct AsciDataStrings
    {
        public static AsciDataStrings Service => default;
        
        string S000
            => "00000000000000000000000000000000 !\"#$%&0()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[0]^_`abcdefghijklmnopqrstuvwxyz{|}~0";

        public ReadOnlySpan<char> C000
            => S000;

        static string LettersLoString
            => "abcdefghijklmnopqrstuvwxyz";

        static string LettersUpString
            => "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static ReadOnlySpan<char> LettersLo
            => LettersLoString;

        public static ReadOnlySpan<char> LettersUp
            => LettersUpString;

        string S001
            => "0123456789ABCDEF";

        public ReadOnlySpan<char> C001
            => S001;

        const int TextResCount = 2;

        const byte DDD = Pow2.T07;

        public static ReadOnlySpan<byte> B001 
            => new byte[16]{0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

        const int ByteResCount = 2;

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> charbytes(N0 index)
            => CharBytes;        

        [MethodImpl(Inline)]
        public ReadOnlySpan<byte> bytes(byte offset, byte count)
            => CharBytes.Slice(offset, count);        

        /// <summary>
        /// Returns the acsci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of codes to select</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<AsciCharCode> codes(sbyte offset, sbyte count)
            => Root.recover<AsciCharCode>(AsciKonst.CodeBytes.Slice(offset,count));

        /// <summary>
        /// Returns the acsci characters corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<char> chars(sbyte offset, sbyte count)
            => Spans.cast<char>(CharBytes).Slice(offset, count);
            
        /// <summary>
        /// Returns the acsci symbols corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<AsciChar> symbols(sbyte offset, sbyte count)
            => Root.recover<char,AsciChar>(chars(offset,count));

        /// <summary>
        /// Returns the uint16 asci scalar values corresponding to the asci codes [offset, ..., offset + count] where offset <= (2^7-1) - count
        /// </summary>
        /// <param name="offset">The zero-based offset</param>
        /// <param name="count">Tne number of characters to select</param>
        [MethodImpl(Inline)]
        public ReadOnlySpan<ushort> scalars(sbyte offset, sbyte count)
            => Root.recover<char,ushort>(chars(offset,count));

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> Text(N0 index)
            => C000;

        ReadOnlySpan<int> ByteResourcLength
        {
            [MethodImpl(Inline)]
            get => new int[2]{CharBytes.Length, B001.Length};
        }

        ReadOnlySpan<int> TextResourcLength
        {
            [MethodImpl(Inline)]
            get => new int[2]{C000.Length, C001.Length};
        }

        ReadOnlySpan<MemoryAddress> ByteResources
        {
            [MethodImpl(Inline)]
            get => new MemoryAddress[2]{Root.address(head(CharBytes)), Root.address(head(B001))};
        }

        ReadOnlySpan<MemoryAddress> TextResources
        {
            [MethodImpl(Inline)]
            get => new MemoryAddress[2]{Root.address(head(C000)), Root.address(head(C001))};
        }

        ReadOnlySpan<ResIdentity<byte>> ByteResInfo
            => new ResIdentity<byte>[ByteResCount]{
                Resources.identify<byte>(
                    name: nameof(CharBytes), 
                    location: Root.address(head(CharBytes)),
                    length: CharBytes.Length),
                Resources.identify<byte>(
                    name: nameof(B001), 
                    location: Root.address(head(B001)),
                    length: B001.Length),
                };

        ReadOnlySpan<ResIdentity<char>> TextResInfo
            => new ResIdentity<char>[TextResCount]{
                Resources.identify<char>(
                    name: nameof(S000), 
                    location: Root.address(head(C000)),
                    length: S000.Length),
                Resources.identify<char>(
                    name: nameof(S001), 
                    location: Root.address(head(C001)),
                    length: S001.Length),
                };            
    }
}