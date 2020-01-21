//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public abstract class UnaryBitLogicOpAttribute : OpKindAttribute
    {
        public UnaryBitLogicOpAttribute(UnaryBitLogicKind kind)
            : base((uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public UnaryBitLogicKind Kind {get;}

        public override string KindName 
            => GetType().DisplayName();
    }

    public sealed class UnaryBitwiseOpAttribute : UnaryBitLogicOpAttribute
    {
        public UnaryBitwiseOpAttribute(UnaryBitLogicKind kind)
            : base(kind)
        {

        }
    }

    public sealed class UnaryLogicOpAttribute : UnaryBitLogicOpAttribute
    {
        public UnaryLogicOpAttribute(UnaryBitLogicKind kind)
            : base(kind)
        {

        }
    }
}