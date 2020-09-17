//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct MemberString
    {
        public Sequential<int> Sequence;

        public Address32 Offset;

        public ByteSize HeapSize;

        public string Content;
    }
}