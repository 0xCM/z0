//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static IDI;

    public interface TIdentityParser : IInfallibleParser<OpIdentity>
    {
        [MethodImpl(Inline)]
        OpIdentity IInfallibleParser<OpIdentity>.Parse(string text)
            => OpIdentityParser.parse(text);
        
        OpIdentity INullary<OpIdentity>.Zero 
            => OpIdentity.Empty;
    }
}