//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    partial struct Part
    {

        /// <summary>
        /// Retrieves the part identifier, if any, of the entry assembly
        /// </summary>
        public static PartId ExecutingPart        
            => id(Assembly.GetEntryAssembly());
        
        public static PartId CallingPart
            => id(Assembly.GetCallingAssembly());
    }
}