//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface TCheckInvariant : TValidator
    {         
        void Nongeneric(MethodInfo src)
        {
            if(src.IsGenericMethod || src.IsConstructedGenericMethod || src.IsGenericMethodDefinition)
                throw AppErrors.GenericMethod(src);
        }

        void Constructed(MethodInfo src)
        {
            if(!src.IsConstructedGenericMethod)
                throw AppErrors.NonGenericMethod(src);
        }

        bool Require(bool invariant, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => invariant ? true : throw Failed(ClaimKind.Invariant, InvariantFailure(caller, file, line));

        /// <summary>
        /// Asserts the operand is true
        /// </summary>
        /// <param name="src">The value claimed to be false</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        void yea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => src.OnNone(() => throw ClaimException.Define(NotTrue(msg, caller, file,line)));

        /// <summary>
        /// Asserts the operand is false
        /// </summary>
        /// <param name="src">The value claimed to be false</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        void nea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => src.OnSome(() => throw ClaimException.Define(NotFalse(msg, caller, file,line)));

        void yea<T>(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => src.OnNone(() => throw ClaimException.Define(NotTrue($"{typeof(T).NumericKind().Format()}" + (msg ?? string.Empty) , caller, file, line)));
    }
}