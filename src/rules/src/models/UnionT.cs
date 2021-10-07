//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        public struct Union<T>
        {
            readonly CharBlock32 _Name;

            readonly Index<T> _Members;

            [MethodImpl(Inline)]
            public Union(string name, T[] members)
            {
                _Name = name;
                _Members = members;
            }

            public Span<T> Members
            {
                [MethodImpl(Inline)]
                get => _Members.Edit;
            }

            public ReadOnlySpan<char> Name
            {
                [MethodImpl(Inline)]
                get => _Name.String;
            }

            public string Format()
                => format(this);

            public override string ToString()
                => Format();
        }
    }
}