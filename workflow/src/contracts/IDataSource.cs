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
        IEnumerable<object> Data {get;}
    }
}