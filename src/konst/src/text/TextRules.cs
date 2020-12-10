//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    public readonly partial struct TextRules
    {
        const NumericKind Closure = UnsignedInts;

        [ApiHost("text.rules.text")]
        public readonly partial struct Test
        {

        }

        [ApiHost("text.rules.format")]
        public readonly partial struct Format
        {

        }

        [ApiHost("text.rules.transform")]
        public readonly partial struct Transform
        {

        }

        [ApiHost("text.rules.parse")]
        public readonly partial struct Parse
        {

        }
    }
}