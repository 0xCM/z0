//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    using static BinaryArithmeticKind;
    
    using Id = OpKindId;
    using A = OpKindAttribute;


    public interface IBinaryArithmeticKind : IArithmeticKind, IOpKind<BinaryArithmeticKind>
    {
        BinaryArithmeticKind IKind<BinaryArithmeticKind>.Class 
            => Enums.parse<BinaryArithmeticKind>(KindId.ToString()).ValueOrDefault();
    }    

    partial class OpKinds
    {


    }
}