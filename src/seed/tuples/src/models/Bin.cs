//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Represents one or more occurrence of a value within an interval
    /// </summary>
    /// <typeparam name="T">The value domain</typeparam>
    public struct Bin<T>
        where T : unmanaged
    {
        int Counter;

        public readonly Interval<T> Domain;

        [MethodImpl(Inline)]
        public static Bin<T> operator ++(Bin<T> src)
            => src.Increment();

        [MethodImpl(Inline)]
        public Bin(in Interval<T> domain, int count = 0)
        {
            Domain = domain;
            Counter = count;
        }

        public int Count 
        {
            [MethodImpl(Inline)]
            get => Counter;
        }

        public string Format()
            => $"{Domain}: {Count}";

        [MethodImpl(Inline)]
        public Bin<T> Increment()
        {
            Interlocked.Increment(ref Counter);
            return this;
        }

        public override string ToString()
            => Format();
    }
}