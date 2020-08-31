//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Table]
    public struct ImageResourceRecord
    {
        public long Offset;

        public string Name;

        public string Attribute;

        public string Data;
    }
}