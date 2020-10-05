//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;
    using static z;
    using static ClrData;

    partial class ClrDataReader
    {
        [MethodImpl(Inline), Op]
        public ref MethodBodyBlock Read(MethodDefinition src, ref MethodBodyBlock dst)
        {
            dst = Pe.GetMethodBody(src.RelativeVirtualAddress);
            return ref dst;
        }
    }
}