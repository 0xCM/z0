//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IApiMember : IApiMethod
    {
    }        

    public interface IApiMember<T> : IApiMember, IEquatable<T>, ITextual<T>, INullary<T>
        where T : struct, IApiMember<T>
    {

    }
}