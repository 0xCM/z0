//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Rules;

    [ApiHost("text.rules")]
    public readonly partial struct TextRules
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static Fence<char> fence(char left, char right)
            => Rules.fence(left,right);

        [MethodImpl(Inline), Op]
        public static Fence<string> fence(string left, string right)
            => Rules.fence(left,right);

        public const StringComparison InvariantCulture = StringComparison.InvariantCulture;

        public static bool eval(string src, Adjacent<char, OneOf<char>> rule, out Adjacent<char> dst)
        {
            var match = rule.A;
            var candidates = rule.B.Elements.View;
            var count = candidates.Length;
            var ix = TextTools.index(candidates, rule.A);
            if(ix != NotFound)
            {
                dst = adjacent<char>(match, skip(candidates,ix));
                return true;
            }
            dst = default;
            return false;
        }

        [ApiHost("text.rules.format")]
        public readonly partial struct Format
        {

        }

        [ApiHost("text.rules.factory")]
        public readonly partial struct Factory
        {

        }

        [ApiComplete("text.rules.data")]
        public readonly partial struct Data
        {

        }
    }
}