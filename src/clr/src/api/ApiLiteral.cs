//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    using api = ApiLiterals;

    /// <summary>
    /// Encodes a literal value and, optionally, it's purpose
    /// </summary>
    /// <remarks>
    /// The <see cref='decimal'/> type is not supported; the <see cref='string'/> type is supported via addressing
    /// </remarks>
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=(int)StorageSize), Blittable(StorageSize)]
    public readonly struct ApiLiteral : ITextual
    {
        public const uint StorageSize = 2*StringAddress.StorageSize + PrimalSizes.U64 + PrimalSizes.U8;

        public StringAddress Source {get;}

        public StringAddress Name {get;}

        public ulong Content {get;}

        public ClrLiteralKind Kind {get;}

        [MethodImpl(Inline)]
        public ApiLiteral(StringAddress source, StringAddress name, ulong content, ClrLiteralKind clr)
        {
            Source = source;
            Name = name;
            Content = content;
            Kind = clr;
        }

        public ApiLiteralValue Value()
            => api.value(this);

        public ApiLiteralSpec Specify()
            => api.specify(this);

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}