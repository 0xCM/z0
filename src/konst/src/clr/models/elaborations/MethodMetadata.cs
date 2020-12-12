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
        public CliArtifactKey MethodId;

        public Name MethodName;

        public Name DefiningAssembly;

        public Name DefiningModule;

        public TypeSig DeclaringType;

        public TypeSig ReturnType;

        public MethodParameters ValueParams;

        public TypeParameters TypeParams;

        public MethodMetadata(int id, string assembly, string module, TypeSig type, string name, TypeSig tReturn, MethodParameters args, TypeParameters tParams)
        {
            MethodId = id;
            DefiningAssembly = assembly;
            DefiningModule = module;
            DeclaringType = type;
            MethodName = name;
            ReturnType = tReturn;
            ValueParams = args;
            TypeParams = tParams;
        }

        public string Format()
            => ClrQuery.format(this);

        public override string ToString()
            => Format();
    }
}