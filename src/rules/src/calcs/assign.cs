//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleCalcs
    {
        [MethodImpl(Inline), Op]
        public static ScriptVar assign(ScriptVar src, string value)
            => RuleModels.scriptvar(src.Symbol, value);

        /// <summary>
        /// Defines an idiom to promote brevity of expression
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool assign<T>(in T src, out T dst)
        {
            dst = src;
            return true;
        }
    }
}