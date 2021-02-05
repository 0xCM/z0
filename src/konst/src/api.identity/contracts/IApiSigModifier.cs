//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static ApiSigs;

    public interface IApiSigModifier<T> : ITextual
        where T : struct, IApiSigModifier<T>
    {
        Name Name {get;}

        SigModifier Kind {get;}
    }
}