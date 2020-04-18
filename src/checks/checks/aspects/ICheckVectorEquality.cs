//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
        
    using static Seed;
    using static AppErrorMsg;    
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface ICheckVectorEquality : IValidator
    {
        /// <summary>
        /// Asserts the equality of two vectors
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        void veq<T>(Vector128<T> lhs, Vector128<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(!lhs.Equals(rhs)) 
                throw failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }

        /// <summary>
        /// Asserts the equality of two vectors
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        void veq<T>(Vector256<T> lhs, Vector256<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(!lhs.Equals(rhs)) 
                throw failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }
    }
}