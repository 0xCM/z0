//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static VBitSvcHosts;

    public partial class VBitSvcHosts
    {

    }

    [FunctionalService]
    public class VBitSvc : ISFxRoot<VBitSvc,VBitSvcHosts>
    {
        [MethodImpl(Inline)]
        public static BitClear128<T> vbitclear<T>(N128 w, T t = default)
            where T : unmanaged
                => default(BitClear128<T>);

        [MethodImpl(Inline)]
        public static BitClear256<T> vbitclear<T>(N256 w, T t = default)
            where T : unmanaged
                => default(BitClear256<T>);
    }
}