//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public interface ILanguage
    {
        Type Metatype {get;}
    }

    public interface ILanguage<L> : ILanguage
    {
        Name Id {get;}

        Type ILanguage.Metatype
            => typeof(L);
    }
}