//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiExtractBlock : IComparable<ApiExtractBlock>
    {
        public static Outcome parse(string src, out ApiExtractBlock dst)
        {
            dst = ApiExtractBlock.Empty;
            try
            {
                var parts = src.SplitClean(FieldDelimiter);
                var parser = HexParsers.bytes();
                if(parts.Length != 3)
                    return (false, $"components = {parts.Length} != 3");

                var address = HexParsers.scalar().Parse(parts[(byte)ApiExtractField.Base]).ValueOrDefault();
                var uri = ApiUri.parse(parts[(byte)ApiExtractField.Uri].Trim()).ValueOrDefault();
                var bytes = parts[(byte)ApiExtractField.Encoded].SplitClean(HexFormatSpecs.DataDelimiter).Select(parser.Succeed);
                dst = new ApiExtractBlock(address, uri.Format(), bytes);
                return true;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        /// <summary>
        /// The Extract's base address
        /// </summary>
        public MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The operation uri
        /// </summary>
        public Name Uri {get;}

        /// <summary>
        /// The enExtractd operation data
        /// </summary>
        public readonly BinaryCode Encoded {get;}

        [MethodImpl(Inline)]
        public ApiExtractBlock(MemoryAddress @base, Name uri, BinaryCode src)
        {
            BaseAddress = @base;
            Uri = uri;
            Encoded = src;
        }

        public MemoryRange Origin
        {
            [MethodImpl(Inline)]
            get => new MemoryRange(BaseAddress, Encoded.Length);
        }

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Encoded.Storage;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Encoded.View;
        }

        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Storage;
        }

        public uint Size
        {
            [MethodImpl(Inline)]
            get => (uint)Encoded.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public ref readonly byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsNonEmpty;
        }


        [MethodImpl(Inline)]
        public bool Equals(ApiExtractBlock src)
            => Encoded.Equals(src.Encoded);

        public string Format(int uripad)
            => string.Concat(BaseAddress.Format(), Space, Uri.Format().PadRight(uripad), Space, Encoded.Format());

        public string Format()
            => Format(60);


        public override string ToString()
            => Format();

        public int CompareTo(ApiExtractBlock src)
            => BaseAddress.CompareTo(src.BaseAddress);

        /// <summary>
        /// No Extract, no identity, no life
        /// </summary>
        public static ApiExtractBlock Empty
            => default;

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(ApiExtractBlock src)
            => src.Encoded;
    }
}