//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public readonly struct MethodMetadata : IMethodMetadata
    {
        public static implicit operator MethodInfo(MethodMetadata src)
            => src.Element;

        [MethodImpl(Inline)]
        public static MethodMetadata<N,T> From<N,T>(MethodInfo method)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new MethodMetadata<N, T>(method);

        [MethodImpl(Inline)]
        public static MethodMetadata From(MethodInfo method, FixedWidth width, NumericKind segkind)            
            => new MethodMetadata(method,width,segkind);

        [MethodImpl(Inline)]
        public MethodMetadata(MethodInfo method, FixedWidth width, NumericKind segkind)
        {
            this.Element = method;                
            this.Width = width;
            this.SegKind = segkind;
        }

        public MethodInfo Element {get;}

        public readonly FixedWidth Width;

        public readonly NumericKind SegKind;
    }
    
    /// <summary>
    /// A type information carrier
    /// </summary>
    public readonly struct MethodMetadata<W,T>: IMethodMetadata<W,T>
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {            
        public static implicit operator MethodInfo(MethodMetadata<W,T> src)
            => src.Element;

        public static implicit operator MethodMetadata(MethodMetadata<W,T> src)
            => MethodMetadata.From(src.Element, src.Width, src.SegKind);
                        
        static W n => default;


        [MethodImpl(Inline)]
        public MethodMetadata(MethodInfo method)
        {
            this.Element = method;                
        }
    
        public MethodInfo Element {get;}

        public FixedWidth Width
            => (FixedWidth)n.NatValue;

        public NumericKind SegKind
            => typeof(T).NumericKind();
    }

}