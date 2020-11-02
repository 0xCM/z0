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
    using static DnCilModel;

    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public struct CilFunction
    {
        public ClrArtifactKey Key;

        public OpIdentity Identifier;

        public string FullName;

        public MemoryAddress BaseAddress;

        public MethodImplAttributes Attributes;

        /// <summary>
        /// The encoded cil
        /// </summary>
        public BinaryCode Encoded;

        public Instruction[] Instructions;

        public string Formatted;

        [MethodImpl(Inline)]
        public CilFunction(ClrArtifactKey id, string name, MethodImplAttributes attribs, Instruction[] instructions)
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
            get => Key == 0 || Identifier.IsEmpty || Instructions == null || text.blank(Formatted) || Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            get => !IsEmpty;
        }

    }
}