//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm.records
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct EntityRelation
    {
        public Label Source {get;}

        public Label Target {get;}

        [MethodImpl(Inline)]
        public EntityRelation(Label src, Label dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public EntityRelation(Label src)
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