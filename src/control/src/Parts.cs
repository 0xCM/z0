//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    using static Memories;

    using P = Z0.Parts;

    public readonly struct PartSelection : IIndexContainer<IPart>
    {
        public static PartSelection Selected => default(PartSelection);
        
        IPart[] IContainer<IPart[]>.Content
            => new IPart[]{
                P.GMath.Resolved,  
               };
    }
}