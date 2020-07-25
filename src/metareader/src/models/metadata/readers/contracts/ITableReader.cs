//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITableReader<F,S,T>
        where S : struct, IReaderState
        where F : struct, ITableReader<F,S,T>
    {
        F Init(S state);
    }    
}