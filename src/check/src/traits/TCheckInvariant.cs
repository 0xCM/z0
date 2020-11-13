//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using api = CheckInvariant;

    public interface TCheckInvariant : TValidator
    {
        bool Require(bool invariant, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.require(invariant, caller, file, line);

        void yea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.yea(src, msg, caller, file, line);

        void nea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.nea(src, msg, caller, file, line);

        void yea<T>(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : unmanaged
                => api.yea<T>(src, msg, caller, file, line);
    }
}