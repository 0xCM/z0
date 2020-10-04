//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct ApiIdentify
    {
        /// <summary>
        /// Defines an identity, bypassing validation
        /// </summary>
        /// <param name="src">The identity text</param>
        [MethodImpl(Inline), Op]
        public static OpIdentity define(string src)
            => OpIdentity.define(src);

        /// <summary>
        /// Defines an operation identifier with all aspects explicitly specified
        /// </summary>
        /// <param name="text">The identity text</param>
        /// <param name="name">The operation name</param>
        /// <param name="suffix">The operaion suffix</param>
        /// <param name="generic">The operation's generic status</param>
        /// <param name="imm">Specifies whether the operation requires one or more immediate values</param>
        /// <param name="components">The identity components</param>
        [MethodImpl(Inline), Op]
        public static OpIdentity define(string text, string name, string suffix, bool generic, bool imm, string[] components)
            => new OpIdentity(text, name, suffix, generic, imm, components);
   }
}
