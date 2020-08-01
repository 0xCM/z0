//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;

    public readonly struct EnumDescription
    {                
        [MethodImpl(Inline)]
        public static EnumDescription create(in EnumLiteral src)
            => new EnumDescription(src.Id, src.TypeHandle, src.TypeName, src.Position, src.Name, Variant.extract<ulong>(src.Value));
        
        public readonly ArtifactIdentity Id;
        
        public readonly MemoryAddress TypeAddress;

        public readonly StringRef TypeName;

        public readonly uint LiteralIndex;

        public readonly StringRef LiteralName;

        public readonly ulong LiteralValue;

        [MethodImpl(Inline)]
        public EnumDescription(ArtifactIdentity id, MemoryAddress address, string type, uint index, string name, ulong value)
        {
            Id = id;
            TypeAddress = address;
            TypeName = type;
            LiteralIndex = index;
            LiteralName = name;
            LiteralValue = value;
        }
    }
}