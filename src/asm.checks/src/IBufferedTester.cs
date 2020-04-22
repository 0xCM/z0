//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;
    using static BufferSeqId;

    public interface IBufferedTester : ITester, IServiceAllocation
    {
        IBufferToken this[BufferSeqId id] {get;}       
    }
}