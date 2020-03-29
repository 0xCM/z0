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
        /// Defines a valued option
        /// </summary>
        /// <param name="value">The value</param>
        /// <typeparam name="T">The type of the extant value</typeparam>
        public static Option<T> some<T>(T value)
            => Option<T>.Some(value);
    }
}