//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public interface IIdentifier<H> : IName<Name>, IDataTypeComparable<H>
        where H : struct, IIdentifier<H>
    {

    }

    public interface IIdentifier<H,T> : IIdentifier<H>
        where H : struct, IIdentifier<H,T>
        where T : IComparable<T>
    {
        Name IContented<Name>.Content
            => Format();

        T Value {get;}
    }
}