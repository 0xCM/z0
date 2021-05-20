//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct Markdown
    {
        [MethodImpl(Inline), Op]
        public static RelativeLink relative(string label, string target)
            => new RelativeLink(label,target);

        public readonly struct RelativeLink : ITextual
        {
            public string Label {get;}

            public string Target {get;}

            [MethodImpl(Inline)]
            public RelativeLink(string label, string target)
            {
                Label = label;
                Target = target;
            }

            public string Format()
                => string.Format("[{0}](./{1})", Label, Target);

            public override string ToString()
                => Format();

        }
    }
}