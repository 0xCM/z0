//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using static Components;

    partial class Core
    {

        /// <summary>
        /// Defines a non-valued option
        /// </summary>
        /// <typeparam name="T">The value type, if the value existed</typeparam>
        public static Option<T> none<T>()
            => Option<T>.None();
    }
}