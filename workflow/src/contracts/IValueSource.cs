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

    using static Root;

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
}