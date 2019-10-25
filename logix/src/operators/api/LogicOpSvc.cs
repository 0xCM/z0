//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct LogicOpSvc : ILogicOpSvc
    {
        public static ILogicOpSvc Factory
        {
            [MethodImpl(Inline)]
            get => default(LogicOpSvc);
        }

        public IEnumerable<UnaryLogicOpKind> UnaryOpKinds 
            => LogicOpApi.UnaryOpKinds;

        public IEnumerable<BinaryLogicOpKind> BinaryOpKinds 
            => LogicOpApi.BinaryOpKinds;

        public IEnumerable<TernaryBitOpKind> TernaryOpKinds 
            => LogicOpApi.TernaryOpKinds;

        public bit Eval(UnaryLogicOpKind kind, bit a)
            => LogicOpApi.eval(kind,a);

        public bit eval(BinaryLogicOpKind kind, bit a, bit b)
            => LogicOpApi.eval(kind,a,b);

        public bit eval(TernaryBitOpKind kind, bit a, bit b, bit c)
            => LogicOpApi.eval(kind,a,b,c);

        public UnaryOp<bit> Lookup(UnaryLogicOpKind kind)
            => LogicOpApi.lookup(kind);

        public BinaryOp<bit> Lookup(BinaryLogicOpKind kind)
            => LogicOpApi.lookup(kind);

        public TernaryOp<bit> Lookup(TernaryBitOpKind kind)
            => LogicOpApi.lookup(kind);
    }

}