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
    using static zfunc;

    public readonly struct UserType : ITypeKind
    {

    }        

    public readonly struct UserType<T> : ITypeKind<T> 
        where T : unmanaged
    {

        [MethodImpl(Inline)]
        public static implicit operator UserType(UserType<T> src)
            =>  default;
        
    }                
}