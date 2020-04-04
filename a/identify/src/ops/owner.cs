//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class Identify
    {
        /// <summary>
        /// Produces the formatted identifier of the declaring assembly
        /// </summary>
        /// <param name="host">The source type</param>
        [MethodImpl(Inline)]   
        public static string owner(Type host)
            => host.Assembly.Id().Format();
    }
}