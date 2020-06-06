//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    

    public interface ILegacyAlphabet<A> : ILegacySymbol
        where A : struct, ILegacyAlphabet<A>
    {
        /// <summary>
        /// Enumerates the symbols defined by an alphabet
        /// </summary>
        IEnumerable<LegacySymbol<A>> Symbols {get;}    
    }
}