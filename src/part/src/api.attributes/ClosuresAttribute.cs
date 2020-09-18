//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public class ClosuresAttribute : Attribute
    {
        public TypeClosureKind Kind {get;}

        public ulong Spec {get;}

        public ulong[] Values {get;}

        public (ulong m, ulong n)[] Pairs {get;}

        ClosuresAttribute()
        {
            Spec = 0;
            Kind = 0;
            Values = new ulong[]{};
            Pairs = new (ulong,ulong)[]{};

        }

        public ClosuresAttribute(ulong spec)
            : this()
        {
            Spec = spec;
        }

        public ClosuresAttribute(NumericKind spec)
            : this()
        {
            Spec = (ulong)spec;
            Kind = TypeClosureKind.Numeric;
        }


        public ClosuresAttribute(CellWidth spec)
            : this()
        {
            Spec = (ulong)spec;
            Kind = TypeClosureKind.Fixed;
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
            Spec = (ulong)spec;
            Kind = TypeClosureKind.Natural;
            Pairs = pairs;
        }

        public ClosuresAttribute(WidthClosureKind spec, params TypeWidth[] values)
            : this()
        {
            Spec = (ulong)spec;
            Kind = TypeClosureKind.Width;
            Values = values.Select(v => (ulong)v).ToArray();
        }

        public ClosuresAttribute(ImmClosureKind spec, params byte[] values)
            : this()
        {
            Spec = (ulong)spec;
            Kind = TypeClosureKind.Imm8;
            Values = values.Select(v => (ulong)v).ToArray();
        }
    }
}