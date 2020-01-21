//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static zfunc;

    /// <summary>
    /// Represents a contiguous block of memory that represents the machine code for a delate
    /// </summary>
    sealed class NativeDelegateData : NativeMemberData<Delegate>
    {        
        public static NativeDelegateData Empty => default;

        public static NativeDelegateData Define(Moniker id, Delegate src, MemoryRange location, byte[] content)
            => new NativeDelegateData(id, src, location, content);

        [MethodImpl(Inline)]
        NativeDelegateData(Moniker id, Delegate src, MemoryRange location, byte[] content)
            : base(id, src, src.Method, location, content)
        {

        }
    }
}