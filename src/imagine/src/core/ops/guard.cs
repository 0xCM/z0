//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class core
    {
        // /// <summary>
        // /// Evaluates a function if a predicate is satisfied; otherwise, returns None
        // /// </summary>
        // /// <typeparam name="X">The type of value to evaluate</typeparam>
        // /// <typeparam name="Y">The evaluation type</typeparam>
        // /// <param name="x">The point of evaluation</param>
        // /// <param name="predicate">A precondition for evaulation to proceed</param>
        // /// <param name="f">The evaluation function</param>
        // [MethodImpl(Inline)]   
        // public static Option<Y> guard<X,Y>(X x, Func<X,bool> predicate, Func<X,Option<Y>> f)
        //     => predicate(x) ? f(x) : none<Y>();
    }
}