//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    [Record, StructLayout(DefaultLayout)]
    public struct RngTestCase<T> : IRecord<RngTestCase<T>>
        where T : unmanaged
    {
        public uint SampleSize;

        public uint SampleCount;

        public ClosedInterval<T> SampleDomain;

        public utf8 Description;
    }
}