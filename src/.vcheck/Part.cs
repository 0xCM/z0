//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VCheck)]

namespace Z0.Parts
{
    public sealed class VCheck : Part<VCheck>
    {

    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static partial class XTend
    {

    }

    public static class VCheck
    {

        internal static class Claim
        {
            public static ClaimException failed(ClaimKind op, IAppMsg msg)
                => ClaimException.Define(op, msg);

            /// <summary>
            /// Asserts the equality of two bit values
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            public static void eq(Bit32 lhs, Bit32 rhs)
                => (lhs == rhs).OnNone(() => AppErrors.ThrowNotEqualNoCaller(lhs,rhs));

            /// <summary>
            /// Asserts the equality of two values via whatever equals operator is implemented
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            /// <param name="caller">The caller member name</param>
            /// <param name="file">The source file of the calling function</param>
            /// <param name="line">The source file line number where invocation ocurred</param>
            public static bool eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => lhs.Equals(rhs) ? true : throw failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));

            /// <summary>
            /// Asserts the equality of two primal values
            /// </summary>
            /// <param name="lhs">The first value</param>
            /// <param name="rhs">The second value</param>
            /// <typeparam name="T">The primal value type</typeparam>
            [MethodImpl(Inline)]
            public static void numeq<T>(T lhs, T rhs)
                where T : unmanaged
            {
                if(typeof(T) == typeof(Bit32))
                    eq(Bit32.specific(lhs), Bit32.specific(rhs));
                else
                    gmath.eq(lhs,rhs).OnNone(() => AppErrors.ThrowNotEqualNoCaller(lhs,rhs));
            }
        }
    }
}