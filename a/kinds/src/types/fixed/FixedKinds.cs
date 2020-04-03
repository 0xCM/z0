//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class FixedKinds
    {

    }

    public readonly struct FixedTypeKind : ILiteralKind<FixedKind>
    {        
        [MethodImpl(Inline)]
        public static implicit operator FixedTypeKind(FixedKind kind)
            => new FixedTypeKind(kind);

        [MethodImpl(Inline)]
        public static implicit operator FixedKind(FixedTypeKind kind)
            => kind.Class;

        [MethodImpl(Inline)]
        public FixedTypeKind(FixedKind kind)
        {
            this.Class = kind;
        }
        
        public FixedKind Class {get;}
    }

    public readonly struct FixedTypeKind<W> : IFixedType<FixedTypeKind<W>, W>
        where W : unmanaged, ITypeWidth
    {        
        [MethodImpl(Inline)]
        public static implicit operator FixedTypeKind<W>(FixedKind kind)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator FixedTypeKind<W>(FixedTypeKind kind)
            => default;            
    }
}