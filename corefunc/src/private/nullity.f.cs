//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{

    /// <summary>
    /// Evaluates a function over a value if the value is not null; otherwise,
    /// returns the default result value
    /// </summary>
    /// <typeparam name="X">The operand type</typeparam>
    /// <typeparam name="Y">The return type</typeparam>
    /// <param name="x">The operand</param>
    /// <param name="f1">The function to potentially evaluate</param>
    [MethodImpl(Inline)]
    static Y ifNotNull<X, Y>(X x, Func<X, Y> f1, Y @default = default)
        => x != null ? f1(x) : @default;

    /// <summary>
    /// Returns the supplied value if not null, otherwise invokes a function to provide
    /// a non-null value as a replacement
    /// </summary>
    /// <typeparam name="T">The object type</typeparam>
    /// <param name="x">The object to test</param>
    /// <param name="replace">The function that yields a replacement value in the event that the supplied value is null</param>
    [MethodImpl(Inline)]
    static T ifNull<T>(T x, Func<T> replace)
        where T : class => x ?? replace();



    

}