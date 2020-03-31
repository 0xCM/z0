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

    using static Core;

    public interface ICheckInvariant : IValidator
    {
        [MethodImpl(Inline)]   
        void nongeneric(MethodInfo src)
            => Claim.RequireNonGeneric(src);

        [MethodImpl(Inline)]   
        void constructed(MethodInfo src)
            => Claim.RequireConstructed(src);

        [MethodImpl(Inline)]   
        bool require(bool invariant, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.require(invariant, caller,file,line);

        [MethodImpl(Inline)]   
        void yea<T>(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
              => Claim.yea<T>(src, msg, caller,file, line);

        [MethodImpl(Inline)]   
        void nea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.nea(src,msg, caller,file,line);
    }
}