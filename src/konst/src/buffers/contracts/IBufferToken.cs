
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBufferTokenSource
    {
        /// <summary>
        /// Returns the token of an index-identified buffer
        /// </summary>
        ref readonly BufferToken this[BufferSeqId id] {get;}
    }

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
