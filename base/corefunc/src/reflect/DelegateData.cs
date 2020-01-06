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
    public readonly struct DelegateData : INativeMemberData
    {        
        public static DelegateData Empty => default;

        [MethodImpl(Inline)]
        public DelegateData(Delegate Delegate, ulong StartAddress, ulong EndAddress, byte[] body)
        {
            this.Delegate = Delegate;
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Body = body.ToArray();
        }

        /// <summary>
        /// The deconstructed delegate
        /// </summary>
        public readonly Delegate Delegate;

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        public readonly ulong StartAddress {get;}

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        public readonly ulong EndAddress {get;}

        /// <summary>
        /// The memory content
        /// </summary>
        public readonly byte[] Body {get;}
        
        public ref readonly byte this[int ix]
        {
            [MethodImpl(Inline)]
            get => ref Body[ix];
        }

        public ulong Length 
            => EndAddress -StartAddress;

        /// <summary>
        /// The method for the deconstructed delegate
        /// </summary>
        public MethodInfo Method    
            => Delegate.Method;

       public bool IsEmpty
            => Method == null || Body == null;
    }
}