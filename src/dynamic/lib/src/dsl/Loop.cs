//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public struct Loop<I>
        where I : unmanaged
    {
        public I LowerBound;

        public bit LowerInclusive;

        public I UpperBound;

        public bit UpperInclusive;

        public I Step;
    }
}