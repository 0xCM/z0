//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static Cil;

    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public struct CilFunctionInfo
    {
        public CliArtifactKey Key;

        public OpIdentity Identifier;

        public string FullName;

        public MemoryAddress BaseAddress;

        public MethodImplAttributes Attributes;

        /// <summary>
        /// The encoded cil
        /// </summary>
        public BinaryCode Encoded;

        public Index<Instruction> Instructions;

        public string Formatted;

        [MethodImpl(Inline)]
        public CilFunctionInfo(CliArtifactKey id, string name, MethodImplAttributes attribs, params Instruction[] instructions)
        {
            Key = id;
            Identifier = default;
            FullName = name;
            BaseAddress = default;
            Attributes = attribs;
            Instructions = instructions;
            Encoded = default;
            Formatted = EmptyString;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Key == 0 || Identifier.IsEmpty || Instructions.IsEmpty || text.blank(Formatted) || Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public static CilFunctionInfo Empty
        {
            [MethodImpl(Inline)]
            get => new CilFunctionInfo(CliArtifactKey.Empty, EmptyString, 0);
        }
    }
}