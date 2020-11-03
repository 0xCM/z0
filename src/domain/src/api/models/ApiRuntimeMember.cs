//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ApiDataModel
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RuntimeMember
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
}