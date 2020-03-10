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
    /// Characterizes a data emission facility
    /// </summary>
    public interface IDataSource
    {
        
    }
    
    public interface ISpanSource<T> : IDataSource
    {
        Span<T> Data {get;}   

    }

    /// <summary>
    /// Characterizes a value emission facility
    /// </summary>
    /// <typeparam name="T">The emission type</typeparam>
    public interface IValueSource<T> : IDataSource
        where T : struct
    {        
        ValueStreamEmitter<T> Emitter {get;}
     
        IEnumerable<T> Stream
            => Emitter();
    }    
}