//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    
    using Id = OpKindId;
    using A = OpKindAttribute;


    public interface IUnaryArithmeticKind : IArithmeticKind, IOpKind<UnaryArithmeticKind>
    {

    }    

    partial class OpKinds
    {


    }
}