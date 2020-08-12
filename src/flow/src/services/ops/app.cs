//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {
        /// <summary>
        /// Creates a stock application context
        /// </summary>
        [Op]
        public static IAppContext app()
            => AppContext.Create(AppPaths.Default, 
                ApiComposition.Assemble(KnownParts.Service.Known.Where(r => r.Id != 0)), 
                Polyrand.Pcg64(PolySeed64.Seed05));                   
    }
}