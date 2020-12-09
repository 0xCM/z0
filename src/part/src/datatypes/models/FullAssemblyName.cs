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
    public readonly struct FullAssemblyName : IDataTypeEquatable<FullAssemblyName>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public FullAssemblyName(string content)
            => Content = content;

        [MethodImpl(Inline)]
        public FullAssemblyName(AssemblyName src)
            => Content = src.FullName;

        [MethodImpl(Inline)]
        public FullAssemblyName(Assembly src)
            => Content = src.FullName;

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator FullAssemblyName(AssemblyName src)
            => new FullAssemblyName(src);

        [MethodImpl(Inline)]
        public static implicit operator FullAssemblyName(Assembly src)
            => new FullAssemblyName(src);

        public override int GetHashCode()
            => Content?.GetHashCode() ?? 0;

        public bool Equals(FullAssemblyName src)
            => string.Equals(Content, src.Content);

        public override bool Equals(object src)
            => src is FullAssemblyName n && Equals(n);
    }
}