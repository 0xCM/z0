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
    /// Represents a type parameter in a generic artifact definition
    /// </summary>
    public readonly struct TypeParamInfo : ITextual
    {
        public string Name {get;}

        public ushort Position {get;}

        [MethodImpl(Inline)]
        public TypeParamInfo(string name, int position)
        {
            Name = name;
            Position = (ushort)position;
        }

        public string Format(bool fence)
            => fence ? Name.Angled() : Name;

        public string Format()
            => Format(false);

        public override string ToString()
            => Format();
    }
}