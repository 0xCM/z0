//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
            
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface IBitStringCheck : ICheckNumeric
    {
        bool eq(BitString lhs, BitString rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => BitStringCheck.eq(lhs,rhs,caller,file,line);

        bool neq(BitString lhs, BitString rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => BitStringCheck.neq(lhs,rhs,caller,file,line);

        static new IBitStringCheck<BitStringCheck> Checker => BitStringCheck.Checker;
    }

    public interface IBitStringCheck<C> : IBitStringCheck, ICheckNumeric<C>
        where C : IBitStringCheck<C>, new()
    {

    }
}