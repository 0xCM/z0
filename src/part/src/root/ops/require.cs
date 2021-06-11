//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct root
    {
        /// <summary>
        /// Insists upon invariant satisfaction
        /// </summary>
        /// <param name="invariant">It must be so, or the operation will not go</param>
        /// <param name="f">A function that emits a message to throw upon invariant failure</param>
        [MethodImpl(Inline), Op]
        public static void invariant(bool invariant, in Func<string> f)
            => Require.invariant(invariant, f);

        [MethodImpl(Inline), Op]
        public static T require<T>(T src, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Require.notnull(src, caller, file, line);
    }
}