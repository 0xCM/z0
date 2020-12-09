//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    public readonly partial struct RngCases
    {
        [StructLayout(DefaultLayout), Record]
        public struct DomainCase<T> : IRecord<DomainCase<T>>
            where T : unmanaged
        {
            public uint SampleSize;

            public uint SampleCount;

            public ClosedInterval<T> SampleDomain;

            public utf8 Description;
        }

        public struct DomainCase
        {
            const uint SampleSizeDefault = Pow2.T16;

            const uint SampleCountDefault = Pow2.T10;

            public static DomainCase<T> init<T>(T min, T max)
                where T : unmanaged
            {
                var dst = new DomainCase<T>();
                dst.SampleDomain = (min,max);
                dst.SampleSize = SampleSizeDefault;
                dst.SampleCount = SampleCountDefault;
                return dst;
            }
        }
    }
}