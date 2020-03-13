//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public interface IOpKind<T>
        where T : unmanaged, IOpKind<T>
    {   
        OpKindId Id {get;}    
    }

    public static partial class OpKinds
    {

    }
}