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
    public interface IValueProvider<T> : IDataProvider
        where T : struct
    {
        
        ValueEmitter<T> Emitter {get;}
     
        IEnumerable<T> Values
            => Emitter();

        IEnumerable<object> IDataProvider.Data
            => Values.Cast<object>();
    }

    readonly struct ValueProvider<T> : IValueProvider<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public ValueProvider(ValueEmitter<T> emitter)
            => Emitter = emitter;

        [MethodImpl(Inline)]
        public ValueProvider(IEnumerable<T> stream)
            => Emitter = () => stream;

        public ValueEmitter<T> Emitter {get;}
    }
}