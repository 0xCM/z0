//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ClosuresAttribute : Attribute
    {
        public TypeClosureKind Kind {get;}
        
        public ulong Spec {get;}

        public ulong[] Values {get;}

        public (ulong m, ulong n)[] Pairs {get;}

        ClosuresAttribute()
        {
            this.Spec = 0;
            this.Kind = 0;
            this.Values = new ulong[]{};
            this.Pairs = new (ulong,ulong)[]{};

        }

        public ClosuresAttribute(ulong spec)
            : this()
        {
            this.Spec = spec;
        }

        public ClosuresAttribute(NumericKind spec)
            : this()
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Numeric;
        }

        
        public ClosuresAttribute(FixedWidth spec)
            : this()
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Fixed;
        }

        public ClosuresAttribute(NatClosureKind spec, params ulong[] values)
            : this()
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Natural;
            this.Values = values;
        }

        public ClosuresAttribute(NatClosureKind spec, params (ulong m, ulong n)[] pairs)
            : this()
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Natural;
            this.Pairs = pairs;
        }

        public ClosuresAttribute(WidthClosureKind spec, params TypeWidth[] values)
            : this()
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Width;
            this.Values = values.Select(v => (ulong)v).ToArray();
        }

        public ClosuresAttribute(ImmClosureKind spec, params Imm8Kind[] values)
            : this()
        {
            this.Spec = (ulong)spec;
            this.Kind = TypeClosureKind.Imm8;
            this.Values = values.Select(v => (ulong)v).ToArray();
        }
    }
}