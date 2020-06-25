
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBufferTokenSource
    {
        /// <summary>
        /// Returns the token of an index-identified buffer
        /// </summary>
        IBufferToken this[BufferSeqId id] {get;}
    }
}