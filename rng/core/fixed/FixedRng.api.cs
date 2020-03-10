//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;
    
    public static partial class FixedRng
    {
        /// <summary>
        /// Creates a primal emitter predicated on a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        static NumericEmitter<T> numeric<T>(IPolyrand random)
            where T : unmanaged
                => new NumericEmitter<T>(random);

        /// <summary>
        /// Captures a delegate and presents it as a binary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        static EmitterSurrogate<T> surrogate<T>(Func<T> f, string name, T t = default)
            => new EmitterSurrogate<T>(f,name);        
    }
}