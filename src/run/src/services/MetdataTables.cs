//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct MetadataTables
    {
        public struct MethodDefinitionTable
        {
            public MethodAttributes Attributes;

            public MethodImplAttributes ImplAttributes;

            public StringRef Name;

            public Address32 RelativeVirtualAddress;

            public EntitySig Signature;

            public CilCode Cil;            

        }
        
        public struct FieldDefinitionTable
        {
            public FieldAttributes Attributes;

            public StringRef Name;
            
            public EntitySig Signature;
        }           
    }

    public readonly struct EntitySig
    {
        public readonly BinaryCode Data;

        [MethodImpl(Inline)]
        public static implicit operator EntitySig(byte[] src)
            => new EntitySig(src);

        [MethodImpl(Inline)]
        public EntitySig(byte[] src)
        {
            Data = src;
        }
    }
}