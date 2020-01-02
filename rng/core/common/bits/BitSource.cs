//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class BitSource<T> : IRandomStream<bit>, IPointStream<bit>
        where T : unmanaged
    {
        const int BufferSize = Pow2.T10;

        [MethodImpl(Inline)]
        public static IRandomStream<bit> From(IPointSource<T> src)
                => new BitSource<T>(src);
        
        [MethodImpl(Inline)]
        public BitSource(IPointSource<T> random)
        {
            this.RngKind = random.RngKind;
            this.Stream = random.Stream().GetEnumerator().ToBitStream();
            this.BitQueue = new Queue<bit>(BufferSize);
        }
                
        Queue<bit> BitQueue {get;}

        public RngKind RngKind {get;}

        public IEnumerable<bit> Stream {get;}

        [MethodImpl(Inline)]
        public bit Next()
        {
            if(BitQueue.TryDequeue(out bit bit))
                return bit;

            BitQueue.Enqueue(Stream.Take(BufferSize));
            return Next();
        }

        public IEnumerable<bit> Next(int count)
        {
            for(var i=0; i<count; i++)
                yield return Next();
        }

        public IEnumerator<bit> GetEnumerator()
            => Stream.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}