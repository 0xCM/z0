//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Constructs a non-valued option
    /// </summary>
    /// <typeparam name="A">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static Option<A> none<A>() 
        => Option.none<A>();
    
    /// <summary>
    /// Constructs a valued option
    /// </summary>
    /// <param name="value">The option value</param>
    /// <typeparam name="A">The underlying type</typeparam>
    [MethodImpl(Inline)]   
    public static Option<A> some<A>(A value) 
        => Option.some(value);
        
}