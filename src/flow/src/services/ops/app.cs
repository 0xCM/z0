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
        /// The parts that happen to be known here
        /// </summary>
        public static IPart[] Known
            => KnownParts.Service.Known.Where(r => r.Id != 0);

        /// <summary>
        /// Creates a stock application context
        /// </summary>
        [MethodImpl(Inline), Op]
        public static IAppContext app()
            => AppContext.Create(AppPaths.Default, 
                ApiComposition.Assemble(Known), 
                Polyrand.Pcg64(PolySeed64.Seed05));                   
    }
}