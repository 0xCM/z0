//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Identifies a delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        public static OpIdentity Identify(this Delegate m)
            => Identity.identify(m);
    }
}