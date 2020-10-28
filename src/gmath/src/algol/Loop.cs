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

    public struct Loop<I>
        where I : unmanaged
    {
        public I LowerBound;

        public bool LowerInclusive;

        public I UpperBound;

        public bool UpperInclusive;
    }
}