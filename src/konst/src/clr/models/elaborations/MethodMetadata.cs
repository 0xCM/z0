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

        public ClrAssemblyName DefiningAssembly;

        public Name DefiningModule;

        public ClrTypeSigInfo DeclaringType;

        public ClrTypeSigInfo ReturnType;

        public Index<ClrParamInfo> ValueParams;

        public Index<ClrTypeParamInfo> TypeParams;
        public string Format()
            => Clr.format(this);

        public override string ToString()
            => Format();
    }
}