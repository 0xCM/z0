//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using F = NumericLiteralField;

    partial class BitMasks
    {
        [MethodImpl(Inline), Op]
        public static void render(in BitMaskRow src, IDatasetFormatter<F> dst)
        {
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Base, src.Base);
            dst.Delimit(F.Data, format(base2, src));
            dst.Delimit(F.Text, src.Text);
        }

        static string format(Base2 @base, BitMaskRow src)
            => BitFormatter.bits(src.Data, src.TypeCode);
    }
}