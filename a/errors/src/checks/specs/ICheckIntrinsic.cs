//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Core;

    public interface ICheckIntrinsic : IValidator
    {
        [MethodImpl(Inline)]
        bool veq<T>(Vector128<T> lhs, Vector128<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => Claim.veq(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]
        bool veq<T>(Vector256<T> lhs, Vector256<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => Claim.veq(lhs, rhs, caller, file, line);
    }
}