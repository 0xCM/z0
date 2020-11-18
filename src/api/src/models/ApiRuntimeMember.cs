//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ApiRuntimeMember
    {
        public MemoryAddress Address;

        public ApiMetadataUri Uri;

        public GenericState Genericity;

        public MethodMetadata Metadata;

        public ApiSig Sig;

        public CilMethod Cil;

        public MachineFunction x86Fx;
    }
}