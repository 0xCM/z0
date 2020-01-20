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
    /// Represents a contiguous block of memory that represents native data that defines a method
    /// </summary>
    sealed class NativeMethodData : NativeMemberData<MethodInfo>
    {        
        public static NativeMethodData Empty => default;

        public static NativeMethodData Define(MethodInfo method, AddressSegment location, byte[] content)
            => new NativeMethodData(method, location, content);

        [MethodImpl(Inline)]
        public NativeMethodData(MethodInfo method, AddressSegment location, byte[] content)
            : base(method, method, location, content)
        {

        }

    }
}