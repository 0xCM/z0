//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.IO;
    using System.IO.Pipes;
    using System.Buffers;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public readonly struct InputPair<T>
        where T : unmanaged
    {
        public static implicit operator (T x, T y)(InputPair<T> src)
            => (src.x, src.y);

        public static implicit operator InputPair<T> ((T x, T y) src)
            => new InputPair<T>(src.x, src.y);

        public InputPair(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public readonly T x;

        public readonly T y; 
    }

    public readonly struct InPort<T>
        where T : unmanaged
    {
        public static readonly BitSize PortWidth = bitsize<T>();

        public void Send(ReadOnlySequence<T> x)
        {

        }
    }

    public readonly struct OutPort<T>
        where T : unmanaged
    {

        public static readonly BitSize PortWidth = bitsize<T>();

        public ReadOnlySequence<T> Receive()
        {
            return default;
        }
    }

    public readonly struct IoPort<T>
        where T : unmanaged
    {
        public static readonly BitSize PortWidth = bitsize<T>();

        public void Send(ReadOnlySequence<T> x)
        {

        }

        public ReadOnlySequence<T> Receive()
        {
            return default;
        }
    }

    public readonly struct Reducer<T>
        where T : unmanaged
    {

        public void Send(ReadOnlySequence<InputPair<T>> pairs)    
        {

        }

        public ReadOnlySequence<T> Receive()
        {
            return default;
        }
        
    
    }
}