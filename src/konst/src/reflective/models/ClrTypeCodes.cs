//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct ClrTypeCodes
    {
        [MethodImpl(Inline), Op]
        public static bool primitive(ClrTypeCode src)
        {
            return src >= ClrTypeCode.Bool8 && src <= ClrTypeCode.Float64
                || src == ClrTypeCode.IntI || src == ClrTypeCode.IntU
                || src == ClrTypeCode.Ptr || src == ClrTypeCode.PtrFx;
        }
    }
}