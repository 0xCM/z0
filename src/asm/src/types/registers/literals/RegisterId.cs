//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using K = RegisterKind;
    using W = RegisterWidth;
    using I = RegisterIndex;

    enum RegisterId : ulong
    {        
        AL_Width = K.AL & W.All,

        AL_Id = (((K.AL & I.All) >> 10) - 1) | (K.AL & W.All),

        CL_Id = (((K.CL & I.All) >> 10) - 1) | (K.CL & W.All),

        DL_Id = (((K.DL & I.All) >> 10) - 1) | (K.DL & W.All),

        BL_Id = (((K.BL & I.All) >> 10) - 1) | (K.BL & W.All),

        SIL_Id = (((K.SIL & I.All) >> 10) - 1) | (K.SIL & W.All),

        DIL_Id = (((K.DIL & I.All) >> 10) - 1) | (K.DIL & W.All),

        R8B_Id = (((K.R8B & I.All) >> 10) - 1) | (K.R8B & W.All),
        
        AX_Id = (((K.AX & I.All) >> 10) - 1) | (K.AX & W.All),

        AL_Pos = ((K.AL & I.All) >> 10) - 1,

        CL_Pos = ((K.CL & I.All) >> 10) - 1,

        DL_Pos = ((K.DL & I.All) >> 10) - 1,

        BL_Pos = ((K.BL & I.All) >> 10) - 1,
        

        AX_Pos = ((K.AX & I.All) >> 10) - 1,

        R15W_Pos = ((K.R15W & I.All) >> 10) - 1,

        R15D_Pos = ((K.R15D & I.All) >> 10) - 1,

        //max int!
        ZMM_31_Pos = ((K.Max & I.All) >> 10) - 1,

        ZMM_31_Width = K.ZMM31 & W.All,

    }
}