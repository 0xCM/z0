//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;

    using static Seed;    

    using K = Kinds;

    public partial class VSvcHosts
    {
        static Type ApiG => typeof(gvec);

        static MethodInfo gApiMethod(Vec128Kind hk, string name)
            => ApiG.DeclaredMethods().WithName(name).OfKind(hk).Single();

        static MethodInfo gApiMethod(Vec256Kind hk, string name)
            => ApiG.DeclaredMethods().WithName(name).OfKind(hk).Single();

    }
    
    [ApiServiceFactory]
    public partial class VSvc : IApiService<VSvc,VSvcHosts>
    {

    }

    [ApiHost]
    public class VSvcChecks : IApiHost<VSvcChecks>
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit match<T>(Vector128<T> x, Vector128<T> y, K.And f, W128 w)
            where T : unmanaged
                => TestBitLogicMatch.Checker.match(x,y,f,w);
    }
}