//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial class AppErrors
    {
        public static void ThrowNotEqual<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw new Exception(NotEqual(lhs,rhs,caller,file,line));

        public static T ThrowNotEqualNoCaller<T>(T lhs, T rhs)
            => throw new Exception(NotEqual(lhs,rhs));
    }
}