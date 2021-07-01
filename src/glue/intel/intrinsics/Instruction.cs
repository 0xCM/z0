//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static XedModels;

    partial class IntrinsicsModels
    {
        public struct Instruction
        {
            public const string ElementName = "instruction";

            public string name;

            public string form;

            public IFormType xed;
        }
    }
}