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
            this.Kind = 0;
            this.Values = new ulong[]{};
        }

        public ClosuresAttribute(NumericKind spec)
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Numeric;
            this.Values = new ulong[]{};
        }

        public ClosuresAttribute(FixedWidth spec)
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Fixed;
            this.Values = new ulong[]{};
        }

        public ClosuresAttribute(NatClosureKind spec, params ulong[] values)
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Natural;
            this.Values = values;
        }

        public ClosuresAttribute(WidthClosureKind spec, params TypeWidth[] values)
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Width;
            this.Values = values.Map(v => (ulong)v);
        }

        public ClosuresAttribute(ImmClosureKind spec, params Imm8Kind[] values)
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Imm8;
            this.Values = values.Map(v => (ulong)v);
        }

        public ulong Spec {get;}

        public TypeClosureKind Kind {get;}

        public ulong[] Values {get;}
    }

    /// <summary>
    /// Applies to a generic type/method to advertise the types over which type parameter(s) may be closed
    /// </summary>
    public class NumericClosuresAttribute : ClosuresAttribute
    {
        public NumericClosuresAttribute(NumericKind nk)
            : base(nk)
        {
            
        }

        public NumericKind NumericPrimitive => (NumericKind)Spec;
    }    

    public class NaturalsAttribute : ClosuresAttribute
    {
        public NaturalsAttribute(params ulong[] values)
            : base(NatClosureKind.Individuals, values)
        {

        }
    }
}