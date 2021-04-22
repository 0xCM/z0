//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;


    partial struct Pipes
    {
        [MethodImpl(Inline)]
        public static VPipe128<P,S,T> vpipe<P,S,T>(W128 w, P vmap, S s = default, T t = default)
            where S : unmanaged
            where P : IVMap128<P,S,T>
            where T : unmanaged
                => new VPipe128<P,S,T>(vmap);

        [MethodImpl(Inline)]
        public static VPipe256<P,S,T> vpipe<S,P,T>(W256 w, P vmap, S s = default, T t = default)
            where S : unmanaged
            where P : IVMap256<P,S,T>
            where T : unmanaged
                => new VPipe256<P,S,T>(vmap);
    }
}