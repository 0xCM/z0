//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.IO.Pipes;
    using System.Buffers;
    
    using static Root;

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

        public void Send(ReadOnlySequence<InPair<T>> pairs)    
        {

        }

        public ReadOnlySequence<T> Receive()
        {
            return default;
        }        
    }
}