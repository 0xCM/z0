//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a memory extract, from an *unspecified* location, that is sourced from an identified operation
    /// </summary>
    public readonly struct UriCode : ITextual
    {
        /// <summary>
        /// The uri of the defining operation
        /// </summary>
        public readonly OpUri Uri;

        /// <summary>
        /// The encoded data
        /// </summary>
        public readonly BinaryCode Encoded;

        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        public static Option<UriCode> Parse(string formatted)
        {
            try
            {
                var parser = HexParsers.Bytes;
                var uri = OpUri.Parse(formatted.TakeBefore(Chars.Space).Trim()).ToOption().Require();
                var bytes = formatted.TakeAfter(Chars.Space)
                                     .Split(HexSpecs.DataDelimiter, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(parser.ParseByte)
                                     .ToArray();
                return new UriCode(uri, BinaryCode.Define(bytes));                
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }
        
        [MethodImpl(Inline)]
        internal UriCode(OpUri uri, BinaryCode encoded)
        {
            this.Uri = uri;
            this.Encoded = encoded;
        }

        /// <summary>
        /// The api host
        /// </summary>
        public ApiHostUri Host { [MethodImpl(Inline)] get => Uri.HostPath; }

        public string Format()
            => string.Concat(Uri.IdentityText.PadRight(0), CharText.Space,  Encoded.Format()); 

        public string Format(int idpad)
            => string.Concat(Uri.IdentityText.PadRight(idpad), CharText.Space, Encoded.Format());

        public override string ToString()
            => Format();
    }
}