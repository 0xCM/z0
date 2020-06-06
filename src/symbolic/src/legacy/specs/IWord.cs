//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ILegacyWord<W,A> : ILegacySymbol
        where A : struct, ILegacyAlphabet<A>
        where W : struct, ILegacyWord<W,A> 
    {

    }
}
