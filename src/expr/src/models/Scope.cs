//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Identifies a context-relative scope
    /// </summary>
    public readonly struct Scope : IScope
    {
        public Label Parent {get;}

        public Label Name {get;}

        [MethodImpl(Inline)]
        public Scope(Label parent, Label name)
        {
            Parent = parent;
            Name = name;
        }

        public bool IsRoot
        {
            [MethodImpl(Inline)]
            get => Parent.Length == 0;
        }

        [MethodImpl(Inline)]

        public bool Equals(Scope src)
            => Name.Equals(src.Name) && Parent.Equals(src.Parent);

        public string Format()
            => expr.format(this);

        public override string ToString()
            => Format();
    }
}