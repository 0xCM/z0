//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckGeneric : TCheckGeneric
    {
        public static TCheckGeneric Checker => default(CheckGeneric);

        [MethodImpl(Inline)]
        public static void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(Bit32))
                gmath.eq((uint)Bit32.specific(lhs), (uint)Bit32.specific(rhs)).OnNone(() => throw ClaimException.Define(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));
            else if(typeof(T).IsPrimalNumeric())
                gmath.eq(lhs,rhs).OnNone(() => throw ClaimException.Define(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));
            else
                CheckEqual.Checker.Eq(lhs,rhs);
        }
    }
}