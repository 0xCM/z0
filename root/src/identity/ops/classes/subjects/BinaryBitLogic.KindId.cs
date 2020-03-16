//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using Id = OpKindId;

    public enum BinaryBitLogicKindId : ulong
    {
        /// <summary>
        /// The empty identity
        /// </summary>
        None = 0,
        
        False = Id.False,

        And = Id.And,

        CNonImpl = Id.CNonImpl,               

        LProject = Id.LProject, 

        NonImpl = Id.NonImpl,        

        RProject = Id.RProject,

        Xor = Id.Xor,

        Or = Id.Xor,

        Nor = Id.Nor, 

        Xnor = Id.Xnor, 

        RNot = Id.RNot, 

        Impl = Id.Impl,

        LNot = Id.LNot, 

        CImpl = Id.CImpl,

        Nand = Id.Nand, 
        
        True = Id.True,
    }
}