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

    using static Root;

    public interface IValuePipe : IPipe
    {
        
    }

    public interface IValuePipe<T> : IValuePipe
        where T : struct
    {
        
    }


    public interface IValuePipe<S,T>  : IValuePipe
        where T : struct
        where S : struct
    {

    }

    public interface IValueRelayPipe<T> : IValuePipe<T>
        where T : struct
    {
        ref readonly T Relay(in T src);

        [MethodImpl(Inline)]
        object IPipe.Flow(object src)
            => Relay(in Unsafe.As<object,T>(ref src));
    }

    public interface IValueEditorPipe<T> : IValuePipe<T>
        where T : struct
    {
        ref T Flow(ref T src);            

        object IPipe.Flow(object src)
            => Flow(ref Unsafe.As<object,T>(ref Unsafe.AsRef(in src)));
    }

    public interface IValueObserverPipe : IValuePipe
    {

    }

    public interface IValueObserverPipe<T> : IValueObserverPipe, IValuePipe<T>
        where T : struct
    {
        Receiver<T> Receiver {get;}

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

    /// <summary>
    /// Characterizes a conduit that accepts S-values and produces T-values
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The target value type</typeparam>
    public interface IValueFactoryPipe<S,T> : IValuePipe<S,T>
        where S : struct
        where T : struct
    {
        /// <summary>
        /// Produces a target value from a source value
        /// </summary>
        /// <param name="src">The source value</param>
        T Flow(in S src);
        
        /// <summary>
        /// Transforms a stream of source values into a stream of target values
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<T> Flow(IEnumerable<S> src)
        {
            foreach(var item in src)
                yield return Flow(in item);
        }

        [MethodImpl(Inline)]
        object IPipe.Flow(object src)
            => Flow(in Unsafe.As<object,S>(ref Unsafe.AsRef(in src)));
    }
}