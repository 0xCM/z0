//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static Memories;

    using P = Z0.Parts;

    public readonly struct PartSelection : IIndexedElements<IPart>
    {
        public static PartSelection Selected => default(PartSelection);
        
        IPart[] IContented<IPart[]>.Content
            => new IPart[]{
                P.GMath.Resolved,  
               };
    }
}