//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct PartsPlaceholder
    {
        /// <summary>
        /// Retrieves the part identifier, if any, of a specified assembly
        /// </summary>
        /// <param name="src">The source assembly</param>
        [MethodImpl(Inline)]
        public static PartId id(Assembly src)
            =>  src.GetTag<PartIdAttribute>()?.Id ?? PartId.None;     

        /// <summary>
        /// Retrieves the part identifier, if any, of the entry assembly
        /// </summary>
        public static PartId ExecutingPart        
            => Assembly.GetEntryAssembly().Id();
    }
}