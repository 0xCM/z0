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

    /// <summary>
    /// Characterizes a function that produces a stream of values
    /// </summary>
    /// <typeparam name="T">The emission type</typeparam>
    public delegate IEnumerable<T> ValueEmitter<T>()
        where T : struct;
    
    /// <summary>
    /// Characterizes a value emission facility
    /// </summary>
    /// <typeparam name="T">The emission type</typeparam>
    public interface IValueSource<T> : IDataSource
        where T : struct
    {
        
        ValueEmitter<T> Emitter {get;}
     
        IEnumerable<T> Values
            => Emitter();

        IEnumerable<object> IDataSource.Data
            => Values.Cast<object>();
    }

    readonly struct ValueSource<T> : IValueSource<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public ValueSource(ValueEmitter<T> emitter)
            => Emitter = emitter;

        [MethodImpl(Inline)]
        public ValueSource(IEnumerable<T> stream)
            => Emitter = () => stream;

        public ValueEmitter<T> Emitter {get;}
    }
}