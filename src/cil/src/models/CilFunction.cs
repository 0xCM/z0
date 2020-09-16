//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.CilSpecs;

    using static Konst;

    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public readonly struct CilFunction
    {
        public readonly int MethodId;

        public readonly MethodImplAttributes ImplSpec;

        public readonly string FullName;

        public readonly Instruction[] Instructions;

        [MethodImpl(Inline)]
        public CilFunction(int id, string name, MethodImplAttributes attribs, Instruction[] instructions)
        {
            MethodId = id;
            FullName = name;
            ImplSpec = attribs;
            Instructions = instructions;
        }
    }
}