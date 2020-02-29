//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Adapter for client code that expects to interface with the System.Random class
    /// </summary>
    public class SysRand : System.Random
    {
        /// <summary>
        /// Derives the system random rng from polyrand
        /// </summary>
        /// <param name="random">The source rng</param>
        public static System.Random From(IPolyrand random)
            => new SysRand(random);

        public SysRand(IPolyrand random)
            => this.Polyrand = random;

        readonly IPolyrand Polyrand;

        public override int Next()
            => Polyrand.Next(Int32.MaxValue);

        public override int Next(int maxValue)
            => Polyrand.Next(maxValue);

        public override int Next(int minValue, int maxValue)
            => Polyrand.Next(minValue,maxValue);

        public override void NextBytes(byte[] buffer)
        {
            var src = Polyrand.Bytes().Take(buffer.Length);
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                buffer[i++] = it.Current;
        }

        public override void NextBytes(Span<byte> buffer)
        {
            var src = Polyrand.Bytes().Take(buffer.Length);
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                buffer[i++] = it.Current;
        }
     
        public override double NextDouble()
            => Polyrand.Next<double>();
    }
}