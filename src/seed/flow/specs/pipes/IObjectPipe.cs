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

    using static Konst;

    public interface IObjectPipe<S,T>  : IObjectPipe
        where S : class
        where T : class
    {

    }

    public interface IObjectPipe : IPipe
    {
        
    }

    public interface IObjectPipe<T> : IObjectPipe
        where T : class
    {
        
    }

    public interface IObjectObserverPipe<T> : IObjectPipe<T>
        where T : class
    {
        ObjectReceiver<T> Receiver {get;}

        [MethodImpl(Inline)]
        ref readonly T Flow(in T src)
        {
            Receiver(src);
            return ref src;
        }

        ObjectRelay<T> Relay 
            => Flow;

        IEnumerable<T> Flow(IEnumerable<T> src)
        {
            foreach(var value in src)
                yield return Flow(in value);
        }

        object IPipe.Flow(object src)
            => Flow(Unsafe.As<object,T>(ref Unsafe.AsRef(in src)));
    }

    public interface IObjectEditorPipe<T> : IObjectPipe<T>
        where T : class
    {
        T Flow(T src);            

        object IPipe.Flow(object src)
            => Flow(Unsafe.As<object,T>(ref Unsafe.AsRef(in src)));
    }    

    /// <summary>
    /// Characterizes a conduit that accepts S-values and produces T-values
    /// </summary>
    /// <typeparam name="S">The source value type</typeparam>
    /// <typeparam name="T">The target value type</typeparam>
    public interface IObjectFactoryPipe<S,T> : IObjectPipe<S,T>
        where S : class
        where T : class
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