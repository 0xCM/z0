//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum ApiPartKindId : ushort
    {
        None = 0,

        Assembly,

        OperationHost,

        OperationService,

        Operation,

        DataType,
    }
}