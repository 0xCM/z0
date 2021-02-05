//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    public struct ClrMethodMetadata : ITextual
    {
        public ClrToken Token;

        public Name MethodName;

        public ClrAssemblyName DefiningAssembly;

        public Name DefiningModule;

        public ClrTypeSigInfo DeclaringType;

        public ClrTypeSigInfo ReturnType;

        public Index<ClrParamInfo> ValueParams;

        public Index<TypeParameter> TypeParams;

        public ClrDisplaySig DisplaySig
            => ClrDisplaySig.from(this);
        public string Format()
            => DisplaySig.Format();

        public override string ToString()
            => Format();
    }
}