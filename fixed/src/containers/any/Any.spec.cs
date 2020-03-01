//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;

    /// <summary>
    /// Characterizes any refiication
    /// </summary>
    /// <typeparam name="T">The ensconsed </typeparam>
    public interface IAny<T> : IFormattable<T>, IEquatable<T>
        where T : IAny<T>
    {
        
    }

}