//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public struct MethodMetadata : ITextual
    {
        public ClrToken Token;

        public Name MethodName;

        public Name DefiningAssembly;

        public Name DefiningModule;

        public TypeSigInfo DeclaringType;

        public TypeSigInfo ReturnType;

        public MethodParameters ValueParams;

        public TypeParameters TypeParams;

        public string Format()
            => ClrQuery.format(this);

        public override string ToString()
            => Format();
    }
}