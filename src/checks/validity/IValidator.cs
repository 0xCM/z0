//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface IValidator
    {
        ValidityException failed(ValidityClaim op, AppMsg msg)
            => Claim.failed(op,msg);

        void failwith(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.failwith(msg, caller, file, line);

        void fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.fail(caller, file, line);        
    }

    public interface IValidator<V> : IValidator
        where V : IValidator<V>, new()
    {


    }

    public interface IEqualCheck<T> : IValidator
    {
        void eq(T a, T b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null);
    }

    public interface INotEqualCheck<T> : IValidator
    {
        void neq(T a, T b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null);
    }
}