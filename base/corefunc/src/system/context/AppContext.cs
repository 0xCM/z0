//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Base type for application-wide contexts
    /// </summary>
    /// <typeparam name="T">The reifying subtype</typeparam>
    public abstract class AppContext<T> : Context<T>
        where T : AppContext<T>, new()
    {
        protected AppContext(IPolyrand rng)
            : base(rng)
        {

        }

        public abstract void Run();

        public static void RunApp()
            => new T().Run();
    }
}