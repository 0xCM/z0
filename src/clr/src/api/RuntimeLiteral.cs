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
    /// Specifies the content of a <see cref='CompilationLiteral'/> at runtime
    /// </summary>
    /// <remarks>
    /// The <see cref='decimal'/> type is not supported; the <see cref='string'/> type is supported via addressing
    /// </remarks>
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=(int)StorageSize), Blittable(StorageSize), Record(TableName)]
    public readonly struct RuntimeLiteral : ITextual, IRuntimeLiteral
    {
        public const string TableName = "literals.runtime";

        public const uint StorageSize = 2*StringAddress.SZ + PrimalSizes.U64 + PrimalSizes.U8;

        public StringAddress Source {get;}

        public StringAddress Name {get;}

        public ulong Data {get;}

        public ClrLiteralKind Kind {get;}

        [MethodImpl(Inline)]
        public RuntimeLiteral(StringAddress source, StringAddress name, ulong content, ClrLiteralKind clr)
        {
            Source = source;
            Name = name;
            Data = content;
            Kind = clr;
        }

        public RuntimeLiteralValue<string> Value()
            => api.value(this);

        public CompilationLiteral Specify()
            => api.specify(this);

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}