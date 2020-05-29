//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Encodes a language over a an alphabet A, where a language is understood
    /// to be a set of words over A
    /// </summary>
    /// <typeparam name="A">The alphabet over which the language is defined</typeparam>
    /// <remarks>A language is typically infinite, which we encode by an enumerable generator</remarks>
    public abstract class LegacyLanguage<L,A>
        where A : struct, ILegacyAlphabet<A>
        where L : LegacyLanguage<L,A>, new()
    {        
        public abstract IEnumerable<LegacyWord<A>> Words {get;}
    }

    public abstract class LegacyLanguage<L,A,W>
        where L : LegacyLanguage<L,A,W>, new()
        where A : struct, ILegacyAlphabet<A>
        where W : struct, ILegacyWord<W,A>
    {
        public abstract IEnumerable<W> Words(int len);
    }
}