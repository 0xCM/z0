//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct ClrMethodArtifact : IClrArtifact
    {
        public CliToken Id;

        public Name MethodName;

        public ClrAssemblyName DefiningAssembly;

        public Name DefiningModule;

        public ClrTypeSigInfo DeclaringType;

        public ClrTypeSigInfo ReturnType;

        public Index<ClrParamInfo> Args;

        public Index<string> TypeParameters;

        public ClrDisplaySig DisplaySig
            => ClrDisplaySig.from(this);

        CliToken IClrArtifact.Token
            => Id;

        string IClrArtifact.Name
            => MethodName;

        public ClrArtifactKind Kind
            => ClrArtifactKind.Method;

        public string Format()
            => DisplaySig.Format();

        public override string ToString()
            => Format();
    }
}