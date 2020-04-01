//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class ClosuresAttribute : Attribute
    {
        public ClosuresAttribute(ulong spec)
        {
            this.Spec = spec;
        }

        public ClosuresAttribute(NumericKind spec)
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Numeric;
        }

        public ulong Spec {get;}

        public TypeClosureKind Kind {get;}
    }

    public enum TypeClosureKind : byte
    {
        None = 0,

        Numeric = 1, 
    }
}