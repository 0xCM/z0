//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISizedOperand : ISized, IOperand
    {

    }

    [Free]
    public interface ISizedOperand<T> : ISizedOperand, IOperand<T>
    {
        BitSize ISized.StorageWidth
            => memory.bitwidth<T>();
    }
}