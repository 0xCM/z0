//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Returns the replacement text if the source text is blank := {null | empty}
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string ifblank(string test, string replace)
            => sys.blank(test) ? replace ?? EmptyString : test;
    }
}