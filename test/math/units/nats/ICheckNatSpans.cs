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

    public interface ICheckNatSpans : TCheckSpans
    {
        /// <summary>
        /// Asserts content equality for two natural spans of coincident length
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        void eq<N,T>(NatSpan<N,T> lhs, NatSpan<N,T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Eq(lhs.Edit,rhs.Edit);

        /// <summary>
        /// Asserts content equality for two tabular spans of coincident dimension
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        void eq<M,N,T>(TableSpan<M,N,T> lhs, TableSpan<M,N,T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => Eq(lhs.Data, rhs.Data);
    }
}