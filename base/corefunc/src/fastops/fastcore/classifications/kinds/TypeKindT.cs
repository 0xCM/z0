//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    public readonly struct TypeKind<T> : ITypeKind
        where T : unmanaged, Enum
    {
        public static TypeKind<T> None => default;

        TypeKind ITypeKind.General 
            => General;

        uint ITypeKind.Specific 
            => evalue<T,uint>(Specific);

        public TypeKind(TypeKind general, T specific)
        {
            this.General = general;
            this.Specific = specific;
        }

        public readonly TypeKind General;

        public readonly T Specific;    

        public TypeKind<S> As<S>()
            where S : unmanaged, Enum
                => Unsafe.As<TypeKind<T>,TypeKind<S>>(ref Unsafe.AsRef(in this));
        
        public string Format()
            => concat(General.ToString(), AsciSym.Colon, AsciSym.Space, Specific.ToString());
        
        public override string ToString()
            => Format();

    }
}