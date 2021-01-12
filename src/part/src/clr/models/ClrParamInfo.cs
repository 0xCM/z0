//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a method (value, not type) parameter
    /// </summary>
    public readonly struct ClrParamInfo : ITextual
    {
        public string Name {get;}

        public ushort Position {get;}

        public ClrTypeSigInfo Type {get;}

        public ClrArgRefKind RefKind {get;}

        [MethodImpl(Inline)]
        public ClrParamInfo(ClrTypeSigInfo type, ClrArgRefKind refkind, string name, ushort pos)
        {
            Type = type;
            Name = name;
            Position = pos;
            RefKind = refkind;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} {1}", Type.Format(), Name);

        public override string ToString()
            => Format();
    }
}