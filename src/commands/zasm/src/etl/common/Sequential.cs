//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class Sequential
    {
        [MethodImpl(Inline)]
        public static Sequential<T> Define<T>(int seq, T value)
            => (seq,value);
    }

    public readonly struct Sequential<T> : ISequential
    {
        public int Sequence {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public static implicit operator Sequential<T>((int seq, T value) src)
            => new Sequential<T>(src.seq, src.value);

        [MethodImpl(Inline)]
        public Sequential(int seq, T value)
        {
            Sequence = seq;
            Value = value;
        }        
    }
}