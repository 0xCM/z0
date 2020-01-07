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

        [MethodImpl(Inline)]
        public NativeDelegateData(Delegate Delegate, ulong StartAddress, ulong EndAddress, byte[] body)
            : base(Delegate, Delegate.Method, (StartAddress,EndAddress), body)
        {

        }
    }
}