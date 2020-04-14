//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using Id = OpKindId;

    public interface IBitFunctionKind : IOpKind, IOpKind<BitFunctionKind>
    {
        BitFunctionKind Kind {get;}

        OpKindId IOpKind.KindId => (OpKindId)Kind;
    }    

    public interface IBitFunctionKind<K> : IBitFunctionKind, IOpKind<K,BitFunctionKind>
        where K : unmanaged, IBitFunctionKind
    {
        OpKindId IOpKind.KindId => default(K).KindId;                
    }
    
    public interface IBitFunctionKind<K,T> : IBitFunctionKind<K>
        where K : unmanaged, IBitFunctionKind
        where T : unmanaged
    {
        BitFunctionKind IBitFunctionKind.Kind => default(K).Kind;
    }

    /// <summary>
    /// Identifies bitwise operations in an arity-neutral way
    /// </summary>
    public enum BitFunctionKind : ulong
    {
        None = 0,

        TestC = Id.TestC,

        TestZ = Id.TestZ
    }
}