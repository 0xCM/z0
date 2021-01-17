//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [Record(TableId)]
    public struct RngTestCase<T> : IRecord<RngTestCase<T>>
        where T : unmanaged
    {
        public const string TableId = "testcase-rng";

        public uint SampleSize;

        public uint SampleCount;

        public ClosedInterval<T> SampleDomain;

        public utf8 Description;
    }


    public readonly partial struct RngCases
    {
        public struct DomainCase
        {
            const uint SampleSizeDefault = Pow2.T16;

            const uint SampleCountDefault = Pow2.T10;

            public static RngTestCase<T> init<T>(T min, T max)
                where T : unmanaged
            {
                var dst = new RngTestCase<T>();
                dst.SampleDomain = (min,max);
                dst.SampleSize = SampleSizeDefault;
                dst.SampleCount = SampleCountDefault;
                return dst;
            }
        }
    }
}