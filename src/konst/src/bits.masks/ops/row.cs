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

    partial class BitMasks
    {
        [MethodImpl(Inline), Op]
        public static BitMaskRow row(NumericLiteral src)
        {
            var dst = new BitMaskRow();
            return map(src, ref dst);
        }

        [MethodImpl(Inline), Op]
        static ref BitMaskRow map(in NumericLiteral src, ref BitMaskRow dst)
        {
            dst.Name = src.Name;
            dst.TypeCode = src.TypeCode;
            dst.Data = src.Data;
            dst.Text = src.Text;
            dst.Base = src.Base;
            return ref dst;
        }
    }
}