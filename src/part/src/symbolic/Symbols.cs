//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    [ApiHost]
    public readonly partial struct Symbols
    {
        const NumericKind Closure = UnsignedInts;

        public static Outcome parse(TextLine src, out SymLiteral dst)
        {
            var outcome = Outcome.Success;
            var j=0;
            var cells = src.Split(Chars.Pipe);
            if(cells.Length != SymLiteral.FieldCount)
            {
                dst = default;
                return (false, AppMsg.FieldCountMismatch.Format(SymLiteral.FieldCount, cells.Length));
            }

            outcome += DataParser.parse(skip(cells,j), out dst.Component);
            outcome += DataParser.parse(skip(cells,j), out dst.Type);
            outcome += DataParser.parse(skip(cells,j), out dst.Position);
            outcome += DataParser.parse(skip(cells,j), out dst.Name);
            outcome += DataParser.parse(skip(cells,j), out dst.Symbol);
            outcome += DataParser.eparse(skip(cells,j), out dst.DataType);
            outcome += DataParser.parse(skip(cells,j), out dst.ScalarValue);
            outcome += DataParser.parse(skip(cells,j), out dst.Hidden);
            outcome += DataParser.parse(skip(cells,j), out dst.Description);
            outcome += DataParser.parse(skip(cells,j), out dst.Identity);
            return outcome;
        }
   }
}