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

    public abstract class BinaryBitLogicOpAttribute : OpKindAttribute
    {
        public BinaryBitLogicOpAttribute(BinaryBitLogicKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public BinaryBitLogicKind Kind {get;}

        public override string KindName 
            => nameof(BinaryBitLogicKind);
    }

    public sealed class BinaryBitwiseOpAttribute : BinaryBitLogicOpAttribute
    {
        public BinaryBitwiseOpAttribute(BinaryBitLogicKind kind)
            : base(kind)
        {

        }
    }

    public sealed class BinaryLogicOpAttribute : BinaryBitLogicOpAttribute
    {
        public BinaryLogicOpAttribute(BinaryBitLogicKind kind)
            : base(kind)
        {

        }
    }
}