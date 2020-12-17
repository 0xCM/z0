//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using api = CheckNumeric;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface TCheckGeneric : IValidator
    {
        [MethodImpl(Inline)]
        void eq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.eq(lhs,rhs,caller,file,line);

        [MethodImpl(Inline)]
        void NumEq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.eq(lhs,rhs,caller,file,line);

        [MethodImpl(Inline)]
        void neq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.neq(lhs,rhs, caller, file, line);

        [MethodImpl(Inline)]
        bool nonzero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.nonzero(x,caller,file,line);

        [MethodImpl(Inline)]
        bool zero<T>(T x, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.zero(x, caller, file, line);

        [MethodImpl(Inline)]
        bool gt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.gt(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]
        bool gteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.gteq(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]
        bool lt<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.lt(lhs, rhs, caller, file, line);

        [MethodImpl(Inline)]
        bool lteq<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.lteq(lhs, rhs, caller, file, line);
    }
}