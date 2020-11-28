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
    using static CheckNumeric;

    public readonly struct RngTestCase
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


    public class t_pcg : t_polyrand<t_pcg>
    {
        public void t_pcg64x8()
        {
            var config = RngTestCase.init(uint8(32), uint8(128));
            var source = Rng.pcg64();
            var buffer = span<byte>(config.SampleSize);

            for(var i=0u; i<config.SampleCount; i++)
            {
                buffer.Clear();
                source.Fill(config.SampleDomain, buffer);
                check(config, buffer);
            }
        }

        public void t_splitmix64x64()
        {
            var config = RngTestCase.init(150ul, 0xFFFFFFFFFFul);
            var source = Rng.splitmix();
            var buffer = span<ulong>(config.SampleSize);

            for(var i=0u; i<config.SampleCount; i++)
            {
                buffer.Clear();
                source.Fill(config.SampleDomain, buffer);
                check(config, buffer);
            }
        }

        void check<T>(in RngTestCase<T> spec, ReadOnlySpan<T> points)
            where T : unmanaged
        {
            var domain = spec.SampleDomain;
            for(var i=0; i<points.Length; i++)
            {
                ref readonly var point = ref skip(points,i);
                //contains(domain, point);
                CheckNumeric.lteq(point, domain.Max);
                CheckNumeric.gteq(point, domain.Min);
            }
        }
    }
}