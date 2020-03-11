
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public interface IBufferToken 
    {
        IntPtr Handle {get;} 

        int Size {get;}  
    }

    public interface IFixedBufferToken : IBufferToken
    {

    }

    public interface IBufferToken<F> : IFixedBufferToken
        where F : unmanaged, IFixed
    {

    }


}