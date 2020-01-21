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

    public class TernaryBitLogicOpAttribute : OpKindAttribute
    {
        static readonly string kindName = typeof(TernaryBitLogicKind).DisplayName();
        
        public TernaryBitLogicOpAttribute(TernaryBitLogicKind kind)
            : base( (uint)kind,kind.Format())
        {
            this.Kind = kind;
        }

        public TernaryBitLogicKind Kind {get;}

        public override string KindName 
            => GetType().DisplayName();        
    }

    public class TernaryBitwiseOpAttribute : TernaryBitLogicOpAttribute
    {
        
        public TernaryBitwiseOpAttribute(TernaryBitLogicKind kind)
            : base(kind)
        {
            
        }
    }

    public class TernaryLogicOpAttribute : TernaryBitLogicOpAttribute
    {
        
        public TernaryLogicOpAttribute(TernaryBitLogicKind kind)
            : base(kind)
        {
        }
    }
}