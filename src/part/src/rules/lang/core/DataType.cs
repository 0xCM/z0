//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface IDataType : IType
    {

    }

    public readonly struct DataType : IDataType
    {
        public Identifier Name {get;}

        [MethodImpl(Inline)]
        public DataType(Identifier name)
        {
            Name = name;
        }
    }
}