//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IParseResult
    {
        Type TargetType {get;}

        bool Succeeded {get;}

        object Value {get;}
    }

    public interface IParseResult<T> : IParseResult
    {

        Type IParseResult.TargetType
            => typeof(T);

        object IParseResult.Value
            => Value;

        new T Value {get;}
    }

}