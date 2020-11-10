//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        public struct Vars : IScriptVars<Vars>
        {
            readonly Indexed<Dir> Directories;

            [MethodImpl(Inline)]
            internal Vars(Dir[] src)
            {
                Directories = src;
            }

            public Indexed<IScriptVar> Members()
                => Directories.Cast<IScriptVar>();

            public string Format()
                => format(this);

            public override string ToString()
                => Format();
        }
    }

}