//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static DnCilModel;

    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public readonly struct CilFunction
    {
        public readonly ClrArtifactKey Id;

        public readonly MethodImplAttributes Attributes;

        public readonly string FullName;

        public readonly Instruction[] Instructions;

        [MethodImpl(Inline)]
        public CilFunction(ClrArtifactKey id, string name, MethodImplAttributes attribs, Instruction[] instructions)
        {
            Id = id;
            FullName = name;
            Attributes = attribs;
            Instructions = instructions;
        }
    }
}