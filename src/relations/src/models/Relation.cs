//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Relation
    {
        public Label Source {get;}

        public Label Target {get;}

        [MethodImpl(Inline)]
        public Relation(Label src, Label dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public Relation(Label src)
        {
            Source = src;
            Target = Label.Empty;
        }

        public bool IsRoot
        {
            [MethodImpl(Inline)]
            get => Target.IsEmpty;
        }
    }
}