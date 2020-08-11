//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    using P = Z0.Parts;

    readonly struct SelectedParts : IContentIndex<IPart>
    {        
        public static IPart[] Known
            => KnownParts.Service.Known.Where(r => r.Id != 0).ToArray();
        
        IPart[] IContented<IPart[]>.Content
            => new IPart[]{P.GMath.Resolved};
    }
}