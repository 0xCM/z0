//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XApiId
    {
        /// <summary>
        /// Identifies a delegate
        /// </summary>
        /// <param name="m">The method to identify</param>
        [Op]
        public static OpIdentity Identify(this Delegate m)
            => ApiIdentity.identify(m);
    }
}