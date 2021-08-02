//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    [ApiHost]
    public readonly partial struct Part
    {
        /// <summary>
        /// Retrieves the part identifier, if any, of the entry assembly
        /// </summary>
        public static PartId ExecutingPart
            => Root.id(Assembly.GetEntryAssembly());
    }
}