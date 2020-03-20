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


    public interface IUnaryArithmeticKind : IArithmeticKind, IOpKind<UnaryArithmeticKind>
    {
        UnaryArithmeticKind IKind<UnaryArithmeticKind>.Class 
            => Enums.parse<UnaryArithmeticKind>(KindId.ToString()).ValueOrDefault();
    }    

    partial class OpKinds
    {


    }
}