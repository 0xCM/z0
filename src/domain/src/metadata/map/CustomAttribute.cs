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

    partial class ImageMap
    {
        [MethodImpl(Inline), Op]
        public void Read(TableSpan<CustomAttributeHandle> src, Receiver<CustomAttribute> dst)
            => src.Iter(handle => dst(CliReader.GetCustomAttribute(handle)));
    }
}