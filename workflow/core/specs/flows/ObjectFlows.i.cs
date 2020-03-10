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

    /// <summary>
    /// Characterizes a function that produces T-objects from S-objects
    /// </summary>
    /// <param name="src">The source object</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public delegate T ObjectTransformer<S,T>(in S src)
        where S : class        
        where T : class;


    /// <summary>
    /// Characterizes a function that receives/emits an object without modification
    /// </summary>
    /// <param name="src">The source object</param>
    /// <typeparam name="T">The object type</typeparam>
    public delegate ref readonly T ObjectRelay<T>(in T src)
        where T : class;

    public interface IObjectFlow : IFlow
    {

    }

    public interface IObjectFlow<T> : IObjectFlow
        where T : class
    {
        IEnumerable<T> Flow(IEnumerable<T> src, IObjectPipe<T> pipe);
    }

    public interface IObjectFlow<P,T> : IObjectFlow<T>
        where T : class
        where P : IObjectPipe<T>
    {

    }

    public interface IObjectFlow<P,S,T>  : IObjectFlow
        where S : class
        where T : class
        where P : IObjectPipe<S,T>
    {       
        IEnumerable<T> Flow(IEnumerable<S> src, P pipe);
    }
    public interface IObjectEditorFlow<T> : IObjectFlow<T>
        where T : class
    {
        IEnumerable<T>  Flow(IObjectEditorPipe<T> pipe);
    }

    public interface IObjectEditorFlow<P,T> : IObjectEditorFlow<T>
        where T : class
        where P : IObjectEditorPipe<T>
    {

        IEnumerable<T>  Flow(P pipe);

        IEnumerable<T>  IObjectEditorFlow<T>.Flow(IObjectEditorPipe<T> pipe)
            => Flow((P)pipe);
    }

    /// <summary>
    /// Characterizes a coordinator that manages value production
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public interface IObjectFactoryFlow<P,S,T> : IObjectFlow<P,S,T>
        where S : class
        where T : class
        where P : IObjectFactoryPipe<S,T>        
    {
        T Flow(in S src, P pipe)
            => pipe.Flow(in src);

        IEnumerable<T> IObjectFlow<P,S,T>.Flow(IEnumerable<S> src, P dst)
            => dst.Flow(src);
            
        IEnumerable<T> Flow(IEnumerable<S> src, IObjectFactoryPipe<S,T> pipe)
            => pipe.Flow(src);
    }    

    public interface IObjectObserverFlow<T> : IObjectFlow<T>
        where T : class
    {
        IEnumerable<T>  Flow(IEnumerable<T> src, IObjectObserverPipe<T> pipe)
        {
            foreach(var value in src)
                yield return pipe.Flow(in value);
        }

        IEnumerable<T> IObjectFlow<T>.Flow(IEnumerable<T> src, IObjectPipe<T> pipe)
            => Flow(src, pipe as IObjectObserverPipe<T>);
    }

    public interface IObjectObserverFlow<P,T> : IObjectObserverFlow<T>, IObjectFlow<P,T>
        where T : class
        where P : IObjectObserverPipe<T>
    {

        ref readonly T Flow(in T src, P pipe)
            => ref pipe.Flow(src);

        IEnumerable<T> Flow(IEnumerable<T> src, P pipe)
            => from item in src select pipe.Flow(item);                        
    }    

 
}