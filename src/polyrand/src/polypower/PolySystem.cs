//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    /// <summary>
    /// Adapter for client code that expects to interface with the System.Random class
    /// </summary>
    public class PolySystem : System.Random
    {
        /// <summary>
        /// Derives the system random rng from polyrand
        /// </summary>
        /// <param name="random">The source rng</param>
        public static System.Random From(IPolySource random)
            => new PolySystem(random);

        public PolySystem(IPolySource random)
            => Random = random;

        readonly IPolySource Random;

        public override int Next()
            => Random.Next(Int32.MaxValue);

        public override int Next(int maxValue)
            => Random.Next(maxValue);

        public override int Next(int minValue, int maxValue)
            => Random.Next(minValue,maxValue);

        public override void NextBytes(byte[] buffer)
        {
            var src = Random.Bytes().Take(buffer.Length);
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                buffer[i++] = it.Current;
        }

        public override void NextBytes(Span<byte> buffer)
        {
            var src = Random.Bytes().Take(buffer.Length);
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext())
                buffer[i++] = it.Current;
        }

        public override double NextDouble()
            => Random.Next<double>();
    }
}