//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;
    using static VBitSvcHosts;
    using static CalcHosts;

    [ApiHost]
    public readonly partial struct Calcs
    {
        const NumericKind Closure = Integers;

    }


    public static partial class XTend
    {


    }

    public partial class VSvcHosts
    {

    }

    public partial class VSvc : ISFxRoot<VSvc,VSvcHosts>
    {
        const NumericKind Closure = UInt64k;
    }


    public partial class BSvcHosts
    {

    }

    public partial class BSvc : ISFxRoot<BSvc,BSvcHosts>
    {

    }

    public partial class VBitSvcHosts
    {

    }

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

    public partial class BC : ISFxHost<BC>
    {

        [MethodImpl(Inline)]
        public static Between<T> between<T>(T t = default)
            where T : unmanaged
                => sfunc<Between<T>>();


    }

}