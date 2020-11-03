//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.IO;

    using static Konst;
    using static z;

    public struct ApiRuntimeMember
    {
        public MemoryAddress Address;

        public ApiMetadataUri Uri;

        public GenericState Genericity;

        public MethodMetadata Metadata;

        public ApiSig Sig;

        public MethodInfo Definition;

        public MachineFunction x86Fx;

        public CilFunction CilFx;
    }
}