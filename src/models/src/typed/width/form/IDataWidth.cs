//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public interface IDataWidth<W> : IDataWidth, ITypedLiteral<W,DataWidth,uint>, IEquatable<W>
        where W : struct, IDataWidth<W>
    {

    }
}