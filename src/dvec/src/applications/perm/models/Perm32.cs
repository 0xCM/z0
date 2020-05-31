//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;    
    using static Memories;
        
    /// <summary>
    /// Defines a 32-symbol permutation
    /// </summary>
    public readonly struct Perm32
    {            
        internal readonly Vector256<byte> data;
         
        [MethodImpl(Inline)]
        public Perm32(Vector256<byte> data)
            => this.data = data;        
    }
}