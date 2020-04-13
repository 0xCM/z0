//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static AppErrorMsg;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;


    public interface IVectorEqualityCheck : IValidator
    {
        void eq<T>(Vector128<T> a, Vector128<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(!a.Equals(b))
                throw failed(ValidityClaim.Eq, NotEqual(a, b, caller, file, line));
        }

        void neq<T>(Vector128<T> a, Vector128<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(a.Equals(b))
                throw failed(ValidityClaim.NEq, Equal(a,b, caller, file, line));
        }

        void eq<T>(Vector256<T> a, Vector256<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(!a.Equals(b))
                throw failed(ValidityClaim.Eq, NotEqual(a,b, caller, file, line));
        }

        void neq<T>(Vector256<T> a, Vector256<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(a.Equals(b))
                throw failed(ValidityClaim.NEq, Equal(a,b, caller, file, line));
        }

        void eq<T>(Vector512<T> a, Vector512<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(!a.Equals(b))
                throw failed(ValidityClaim.Eq, NotEqual(a,b, caller, file, line));

        }

        void neq<T>(Vector512<T> a, Vector512<T> b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
        {
            if(a.Equals(b))
                throw failed(ValidityClaim.NEq, Equal(a,b, caller, file, line));
        }
    }

    public interface IVectorCheck : IVectorEqualityCheck, ICheckNumeric
    {
        static new IVectorCheck<VectorCheck> Checker => VectorCheck.Check;        
        
    }

    public interface IVectorCheck<C> : IVectorCheck, ICheck<C>
        where C : IVectorCheck<C>, new()
    {
    }

    public readonly struct VectorCheck : IVectorCheck<VectorCheck>
    {
        public static IVectorCheck<VectorCheck> Check => default(VectorCheck);
    }
}