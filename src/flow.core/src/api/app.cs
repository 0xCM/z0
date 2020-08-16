//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    partial struct Flow    
    {

        [MethodImpl(Inline), Op]
        public static IAppContext app()
            => AppContext.create(AppPaths.Default, 
                ApiComposition.Assemble(SelectedParts.Known), 
                Polyrand.Pcg64(PolySeed64.Seed05));           

        readonly struct SelectedParts : IContentIndex<IPart>
        {        
            public static IPart[] Known
                => KnownParts.Service.Known.Where(r => r.Id != 0).ToArray();
            
            IPart[] IContented<IPart[]>.Content
                => new IPart[]{Parts.GMath.Resolved};
        }
    }
}