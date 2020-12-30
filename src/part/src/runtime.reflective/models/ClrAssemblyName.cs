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

    [Datatype]
    public readonly struct ClrAssemblyName : IDataTypeEquatable<ClrAssemblyName>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public ClrAssemblyName(string content)
            => Content = content;

        [MethodImpl(Inline)]
        public ClrAssemblyName(AssemblyName src)
            => Content = src.FullName;

        [MethodImpl(Inline)]
        public ClrAssemblyName(Assembly src)
            => Content = src.FullName;

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ClrAssemblyName(AssemblyName src)
            => new ClrAssemblyName(src);

        [MethodImpl(Inline)]
        public static implicit operator ClrAssemblyName(Assembly src)
            => new ClrAssemblyName(src);

        public override int GetHashCode()
            => Content?.GetHashCode() ?? 0;

        public bool Equals(ClrAssemblyName src)
            => string.Equals(Content, src.Content);

        public override bool Equals(object src)
            => src is ClrAssemblyName n && Equals(n);
    }
}