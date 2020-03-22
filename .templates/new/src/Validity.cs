//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.Validity)]

namespace Z0.Resolutions
{
    public sealed class Validity : ApiResolution<Validity, Validity.C>
    {
        public Validity() : base(AssemblyId.Validity) {}
        
        public class C : ApiCatalog<C> { public C() : base(AssemblyId.Validity) {} }            
    }
}

namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Root;
    using static AppMessages;

    public static class Validity
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;


        internal static class Claim
        {
            public static ClaimException failed(ClaimOpKind op, AppMsg msg)
                => ClaimException.Define(op, msg);

            /// <summary>
            /// Asserts the equality of two bit values
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            public static void eq(bit lhs, bit rhs)
                => (lhs == rhs).IfNone(() => AppErrors.ThrowNotEqualNoCaller(lhs,rhs));

            /// <summary>
            /// Asserts the equality of two values via whatever equals operator is implemented
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            /// <param name="caller">The caller member name</param>
            /// <param name="file">The source file of the calling function</param>
            /// <param name="line">The source file line number where invocation ocurred</param>        
            public static bool eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => lhs.Equals(rhs) ? true : throw failed(ClaimOpKind.Eq, NotEqual(lhs,rhs, caller, file, line));

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
                if(typeof(T) == typeof(bit))
                    eq(As.ubit(lhs), As.ubit(rhs));
                else
                    Numeric.eq(lhs,rhs).IfNone(() => AppErrors.ThrowNotEqualNoCaller(lhs,rhs));
            }
        }      
    }
}