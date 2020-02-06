//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    public delegate void ValueReceiver<T>(in T src)
        where T : struct;

    public delegate ref readonly T ValueRelay<T>(in T src)
        where T : struct;
    
    public interface IValueObserverPipe : IValuePipe
    {

    }
    
    public interface IValueObserverPipe<T> : IValueObserverPipe, IValuePipe<T>
        where T : struct
    {
        ValueReceiver<T> Receiver {get;}

        [MethodImpl(Inline)]
        ref readonly T Flow(in T src)
        {
            Receiver(src);
            return ref src;
        }

        ValueRelay<T> Relay 
            => Flow;

        IEnumerable<T> Flow(IEnumerable<T> src)
        {
            foreach(var value in src)
                yield return Flow(in value);
        }

        [MethodImpl(Inline)]
        object IPipe.Flow(object src)
            => Flow(in Unsafe.As<object,T>(ref Unsafe.AsRef(in src)));
    }

    readonly struct ValueObserverPipe<T> : IValueObserverPipe<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static ValueObserverPipe<T> Create(ValueReceiver<T> receiver)
            => new ValueObserverPipe<T>(receiver);
                
        [MethodImpl(Inline)]
        ValueObserverPipe(ValueReceiver<T> receiver)
            => this.Receiver = receiver;
        
        public readonly ValueReceiver<T> Receiver {get;}
    }
}