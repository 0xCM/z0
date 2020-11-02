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

    public readonly struct CilOpCodes
    {
        public readonly TableSpan<CilOpCodeRow> Data;

        public static implicit operator CilOpCodes(CilOpCodeRow[] src)
            => new CilOpCodes(src);

        [MethodImpl(Inline), Op]
        public CilOpCodes(CilOpCodeRow[] src)
        {
            Data = src;
        }
    }
}