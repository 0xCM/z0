//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static ApiSigs;

    /// <summary>
    /// Describes an operand defined by an api operation
    /// </summary>
    public readonly struct ApiOperand : IDataType<ApiOperand>
    {
        public byte Position {get;}

        public ApiType Type {get;}

        public OperandName Name {get;}

        public ModifierKind Modifier {get;}

        [MethodImpl(Inline)]
        public ApiOperand(byte pos, ApiType type, OperandName name, ModifierKind modifier)
        {
            Position = pos;
            Type = type;
            Name = name;
            Modifier = modifier;
        }
        public string Format()
            => string.Format("{0} {1} {2}", Modifier, Type, Name);

        public override string ToString()
            => Format();
    }
}