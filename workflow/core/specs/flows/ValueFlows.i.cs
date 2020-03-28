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

    using static root;


    public interface IValueFlow : IFlow
    {
     
        [MethodImpl(Inline)]
        object Flow(object src, IValuePipe pipe)
            => pipe.Flow(src);

        [MethodImpl(Inline)]
        IEnumerable<object> Flow(IEnumerable<object> src, IValuePipe pipe)
            => pipe.Flow(src);
    }

    public interface IValueFlow<T> : IValueFlow
        where T : struct
    {
        IEnumerable<T> Flow(IEnumerable<T> src, IValuePipe<T> dst);
    }

    public interface IValueFlow<P,T> : IValueFlow<T>
        where T : struct
        where P : IValuePipe<T>
    {
        IEnumerable<T> Flow(IEnumerable<T> src, P dst);
    }

    public interface IValueFlow<P,S,T>  : IValueFlow
        where S : struct
        where T : struct
        where P : IValuePipe<S,T>
    {
        IEnumerable<T> Flow(IEnumerable<S> src, P dst);
    }

   public interface IValueObserverFlow<T> : IValueFlow<T>
        where T : struct
    {
        IEnumerable<T> Flow(IEnumerable<T> src, IValueObserverPipe<T> pipe)
        {
            foreach(var value in src)
                yield return pipe.Flow(in value);
        }

        IEnumerable<T> Flow(IValueStreamSource<T> src, IValueObserverPipe<T> pipe)
            => Flow(src.Emitter(),pipe);

        IEnumerable<T> IValueFlow<T>.Flow(IEnumerable<T> src, IValuePipe<T> pipe)
            => Flow(src, pipe as IValueObserverPipe<T>);
    }

    public interface IValueObserverFlow<P,T> : IValueObserverFlow<T>, IValueFlow<P,T>
        where T : struct
        where P : IValueObserverPipe<T>
    {
        ref readonly T Flow(in T src, P pipe)
            => ref pipe.Flow(src);

        IEnumerable<T> IValueFlow<P,T>.Flow(IEnumerable<T> src, P pipe)
            => from item in src select pipe.Flow(item);            
    }        


    /// <summary>
    /// Characterizes a coordinator that manages value production
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public interface IValueFactoryFlow<S,T> : IValueFlow
        where S : struct
        where T : struct
    {
        T Flow(in S src, IValueFactoryPipe<S,T> pipe)
            => pipe.Flow(in src);
            
        IEnumerable<T> Flow(IEnumerable<S> src, IValueFactoryPipe<S,T> pipe)
        {
            foreach(var value in src)
                yield return Flow(in value, pipe);
        }
            
    }

    /// <summary>
    /// Characterizes a coordinator that manages value production
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public interface IValueFactoryFlow<P,S,T> : IValueFlow<P,S,T>
        where S : struct
        where T : struct
        where P : IValueFactoryPipe<S,T>        
    {
        T Flow(in S src, P pipe)
            => pipe.Flow(in src);

        IEnumerable<T> IValueFlow<P,S,T>.Flow(IEnumerable<S> src, P dst)
            => dst.Flow(src);
            
        IEnumerable<T> Flow(IEnumerable<S> src, IValueFactoryPipe<S,T> pipe)
            => pipe.Flow(src);
    }    
}