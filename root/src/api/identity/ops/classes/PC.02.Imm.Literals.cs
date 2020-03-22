//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using PC = ParameterClass;


    /// <summary>
    /// Classfies parameters according to whether the require/expect an immediate value
    /// </summary>
    public enum ParamImmAspect : uint
    {
        None = 0,

        Imm8 = PC.Imm8,

        Imm16 = PC.Imm16,

        Imm32 = PC.Imm32,

        Imm64 = PC.Imm64,
    }

}