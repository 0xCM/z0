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

    public readonly struct CilOpCodeDataset
    {
        public readonly TableSpan<CilOpCodeRow> Data;

        public static implicit operator CilOpCodeDataset(CilOpCodeRow[] src)
            => new CilOpCodeDataset(src);

        [MethodImpl(Inline), Op]
        public CilOpCodeDataset(CilOpCodeRow[] src)
        {
            Data = src;
        }
    }
}