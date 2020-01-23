//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Clasifies user-defined primitive types
    /// </summary>
    public enum UserPrimitiveKind : uint
    {    
        None = 0,
        
        /// <summary>
        /// Identifies a user-defined bit type
        /// </summary>
        Bit = 1,        
    }
}