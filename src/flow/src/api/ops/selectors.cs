//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct OldFlow    
    {
        /// <summary>
        /// Creates a stock application context
        /// </summary>
        [Op]
        public static IAppContext app()
            => AppContext.create(AppPaths.Default, 
                ApiComposition.Assemble(KnownParts.Service.Known.Where(r => r.Id != 0)), 
                Polyrand.Pcg64(PolySeed64.Seed05));                   

        [MethodImpl(Inline)]
        public static TableSectors<D,S> selectors<D,S>(TableSelector<D,S>[] src, S min, S max)
            where D : unmanaged, Enum        
            where S : unmanaged
                => new TableSectors<D,S>(src,min,max);
    }
}