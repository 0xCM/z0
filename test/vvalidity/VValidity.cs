//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.ValidityVectors)]

namespace Z0.Parts
{
    public sealed class ValidityVectors : Part<ValidityVectors>
    {        
        
    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static partial class XTend
    {

    }
    
    public static class ValidityVectors
    {
        const char Sep = UriDelimiters.PathSep;

        /// <summary>
        /// Produces the name of the test case for the specified function
        /// </summary>
        /// <param name="f">The function</param>
        public static string testcase(Type host, ISFuncApi f)
            => $"{Identify.owner(host)}{Sep}{host.Name}{Sep}{f.Id}";

        internal static class Claim
        {
            public static ValidityException failed(ValidityClaim op, IAppMsg msg)
                => ValidityException.Define(op, msg);

            /// <summary>
            /// Asserts the equality of two bit values
            /// </summary>
            /// <param name="lhs">The left operand</param>
            /// <param name="rhs">The right operand</param>
            public static void eq(bit lhs, bit rhs)
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
                => lhs.Equals(rhs) ? true : throw failed(ValidityClaim.Eq, NotEqual(lhs,rhs, caller, file, line));

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
                    eq(bit.specific(lhs), bit.specific(rhs));
                else
                    Numeric.eq(lhs,rhs).OnNone(() => AppErrors.ThrowNotEqualNoCaller(lhs,rhs));
            }
        }      
    }
}