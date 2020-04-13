//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using Id = OpKindId;

    /// <summary>
    /// Identifies bitwise operations in an arity-neutral way
    /// </summary>
    public enum BitFunctionKind : ulong
    {
        None = 0,

        TestC = Id.TestC,

        TestZ = Id.TestZ
    }
}