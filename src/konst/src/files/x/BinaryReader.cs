//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Collections.Generic;

    partial class XFs
    {
        public static BinaryReader BinaryReader(this Stream src)
            => new BinaryReader(src);

        public static BinaryReader BinaryReader(this StreamReader src)
            => new BinaryReader(src.BaseStream);
    }
}