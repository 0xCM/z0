//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Polyfun;

    public static class RngSys
    {        
        /// <summary>
        /// Converts a polyrand to the pitiful System.Random
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static System.Random ToSysRand(this IPolyrand random)
            => SysRand.From(random);
    }

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
            => this.Random = random;

        readonly IPolyrand Random;

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