
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBufferToken 
    {
        IntPtr Handle {get;} 

        int Size {get;}  
    }

    public interface IFixedBufferToken : IBufferToken
    {

    }

}