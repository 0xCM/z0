//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ClrStructName : ITextual
    {
        readonly string FullName;

        [MethodImpl(Inline)]
        public ClrStructName(string name)
            => FullName = name;

        public ClrTypeName Name
        {
            [MethodImpl(Inline)]
            get => ClrTypeName.define(FullName);
        }

        public string Format()
            => FullName;

        public override string ToString()
            => Format();


        [MethodImpl(Inline)]
        public static implicit operator ClrTypeName(ClrStructName src)
            => src.Name;
    }
}