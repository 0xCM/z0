//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public class ShiftOpAttribute : OpAttribute
    {
        static readonly string kindName = typeof(ShiftOpKind).DisplayName();

        public ShiftOpAttribute(ShiftOpKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public ShiftOpKind Kind {get;}

        public override string KindName => kindName;

    }
}