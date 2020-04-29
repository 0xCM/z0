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
    /// Defines a memory extract that is sourced from an identified operation
    /// </summary>
    public readonly struct EncodedHexLine : IFormattable<EncodedHexLine>
    {
        public static FileExtension FileExt => FileExtensions.Hex;

        public readonly OpUri Uri;

        public readonly LocatedCode Encoded;

        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        public static Option<EncodedHexLine> Parse(string formatted)
        {
            try
            {
                var parser = HexParsers.Bytes;
                var uri = OpUri.Parse(formatted.TakeBefore(Chars.Space).Trim()).ToOption().Require();
                var bytes = formatted.TakeAfter(Chars.Space)
                                     .Split(HexSpecs.DataDelimiter, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(parser.ParseByte)
                                     .ToArray();

                return new EncodedHexLine(uri, LocatedCode.Define(bytes));                
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }
        
        [MethodImpl(Inline)]
        internal EncodedHexLine(OpUri uri, LocatedCode encoded)
        {
            this.Uri = uri;
            this.Encoded = encoded;
        }
        
        public string Format()
            => string.Concat(Uri.Identifier.PadRight(0), CharText.Space,  Encoded.Format()); 

        public string Format(int idpad)
            => string.Concat(Uri.Identifier.PadRight(idpad), CharText.Space, Encoded.Format());

        public override string ToString()
            => Format();
    }
}