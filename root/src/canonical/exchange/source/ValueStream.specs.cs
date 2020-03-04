//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Security;


    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <param name="count">If specified, the number of elements to produce</param>
    /// <typeparam name="T">The emission type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate IEnumerable<T> ValueStreamEmitter<T>(int? count = null)
        where T : struct;    

    public interface IValueStream<T> : IEnumerable<T>, IValueSource<T>
        where T : struct
    {
    }

    public interface IValueStreamSource<T> : IStreamSource<T>, IValueSource<T>
        where T : struct
    {        
        ValueStreamEmitter<T> Emitter {get;}
        
        IEnumerable<T> IStreamSource<T>.Stream 
            => Emitter();
    }
}