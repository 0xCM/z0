//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Grammars
    {
        public static string format(IProduction src)
        {
            // var dst = text.buffer();
            // dst.AppendFormat("<{0}> := {1}", src.Name, Rules.format(src.Expansion));
            // return dst.Emit();
            return EmptyString;
        }

        public static string format<T>(in Atom<T> src)
            where T : unmanaged
                => src.Value.ToString();
    }
}