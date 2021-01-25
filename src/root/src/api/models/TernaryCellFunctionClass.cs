//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TernaryCellFunctionClass : ICellFunctionClass<TernaryCellFunctionClass,OperatorArity>
    {
        public TypeWidth Width {get;}

        public OperatorArity Kind
            => OperatorArity.TernaryOp;

        public OperatorClass Classifier
        {
            [MethodImpl(Inline)]
            get => new OperatorClass(Kind);
        }

        [MethodImpl(Inline)]
        public TernaryCellFunctionClass(TypeWidth width)
            => Width = width;

        [MethodImpl(Inline)]
        public static implicit operator OperatorClass(TernaryCellFunctionClass src)
            => new OperatorClass(src.Kind);
    }

}