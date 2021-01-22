//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Datatype]
    public readonly struct ApiOperand : IDataType<ApiOperand>
    {
        public byte Position {get;}

        public TypeName Type {get;}

        public OperandName Name {get;}

        public ApiOperandModifier Modifiers {get;}

        [MethodImpl(Inline)]
        public ApiOperand(byte pos, TypeName type, OperandName name, ApiOperandModifier modifier)
        {
            Position = pos;
            Type = type;
            Name = name;
            Modifiers = modifier;
        }

        public string Format()
            => string.Format("{0} {1} {2}", Modifiers, Type, Name);

        public override string ToString()
            => Format();
    }
}