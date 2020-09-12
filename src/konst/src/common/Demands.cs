//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost]
    public readonly struct Demands
    {
        [MethodImpl(Inline), Op]
        public static void insist(bool invariant, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => z.insist(invariant, EmptyString, caller, file, line);

        [MethodImpl(Inline), Op]
        public static void reason(bool invariant, string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => z.insist(invariant, msg, caller, file, line);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T insist<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : IEquatable<T>
                => z.insist(lhs, rhs, true, caller, file, line);
    }
}