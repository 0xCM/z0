//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Seed;
    using static AppErrorMsg;    
    
    public readonly struct Claim : ICheck
    {
        public static ICheck Checker => default(Claim);
        
        [MethodImpl(Inline)]   
        public static int length<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        [MethodImpl(Inline)]   
        public static int length<T>(T[] lhs, T[] rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        [MethodImpl(Inline)]   
        public static int length<T>(Span<T> lhs, Span<T> rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        /// <summary>
        /// Raises an error if the source method is any flavor of generic
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireNonGeneric(MethodInfo src)
        {
            if(src.IsGenericMethod || src.IsConstructedGenericMethod || src.IsGenericMethodDefinition)
                throw AppErrors.GenericMethod(src);
        }

        /// <summary>
        /// Raises an error if the source method is not a constructed generic method
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static void RequireConstructed(MethodInfo src)
        {
            if(!src.IsConstructedGenericMethod)
                throw AppErrors.NonGenericMethod(src);
        }

        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="op">The kind of claim that failed</param>
        /// <param name="msg">The failure description</param>
        public static ClaimException failed(ClaimKind op, IAppMsg msg)
        {
            require(msg != null, $"Defining validity exceptions with invalid messages is bad");
            return ClaimException.Define(op, msg);
        }

        /// <summary>
        /// Fails unconditionally with a message
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void failwith(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimKind.Fail, AppMsg.Error(msg, caller, file,line));

        /// <summary>
        /// Fails unconditionally
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimKind.Fail, AppMsg.Error("failed", caller, file,line));

        [MethodImpl(Inline)]   
        public static bool eq(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(uint lhs, uint rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        public static bool eq(ulong lhs, ulong rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));        

        [MethodImpl(Inline)]   
        public static bool require(bool invariant, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => invariant ? true : throw failed(ClaimKind.Invariant, InvariantFailure(caller, file, line));
            
        public static void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!object.Equals(lhs,rhs))
                throw failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }            
    }
}