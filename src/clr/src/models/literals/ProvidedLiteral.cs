//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Encodes a literal value and, optionally, it's purpose
    /// </summary>
    /// <remarks>
    /// The <see cref='decimal'/> type is not supported; the <see cref='string'/> type is supported via addressing
    /// </remarks>
    public readonly struct ProvidedLiteral : ITextual
    {
        public StringAddress Name {get;}

        public ulong Content {get;}

        public ClrLiteralKind Kind {get;}

        public LiteralUsage Usage {get;}

        [MethodImpl(Inline)]
        public ProvidedLiteral(StringAddress name, ulong content, ClrLiteralKind clr, LiteralUsage usage= default)
        {
            Name = name;
            Content = content;
            Kind = clr;
            Usage = usage;
        }

        public string Format()
        {
            var c = EmptyString;
            if(Kind == ClrLiteralKind.String)
            {
                c = ((StringAddress)Content).Format();
            }
            else
            {
                c = Content.ToString();
            }
            return string.Format("{0,-32} {1}:{2}", Name, c, Kind);
        }

        public override string ToString()
            => Format();
    }
}