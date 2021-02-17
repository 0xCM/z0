//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Expr
    {
        public readonly struct UnaryBitLogic
        {
            public UnaryBitLogicKind Kind {get;}
        }

        public readonly struct BinaryBitLogic
        {
            public BinaryBitLogicKind Kind {get;}
        }

        public readonly struct TernaryBitLogic
        {
            public TernaryBitLogicKind Kind {get;}
        }
    }
}