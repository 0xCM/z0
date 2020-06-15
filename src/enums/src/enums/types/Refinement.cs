//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Refinement
    {
        [MethodImpl(Inline)]
        public static Refinement<V,T> init<V,T>(V src, T rep = default)
            where V : unmanaged, Enum
            where T : unmanaged
                => new Refinement<V,T>(src);            
    }

    public interface IRefinement<V> : ITextual
        where V : unmanaged, Enum
    {
        EnumScalarKind Kind => Enums.kind<V>();
    }
    
    public interface IRefinement<V,T> : IRefinement<V>
        where V : unmanaged, Enum
        where T : unmanaged
    {

    }

    public interface IRefinement<F,E,T> : IRefinement<E,T>, INullary<F>, IEquatable<F>
        where F : unmanaged, IRefinement<F,E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        F INullary<F>.Zero => default(F);
    }

    /// <summary>
    /// Let's pretend we can make refinement types in .Net
    /// </summary>
    public readonly struct Refinement<V,T> : IRefinement<Refinement<V,T>,V,T>
        where V : unmanaged, Enum
        where T : unmanaged
    {
        public static Refinement<V,T> Zero => default;
        
        public readonly V Value;

        [MethodImpl(Inline)]
        public static bool operator ==(Refinement<V,T> x, Refinement<V,T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(Refinement<V,T> x, Refinement<V,T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator Refinement<V,T>(V src)
            => new Refinement<V,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Refinement<V,T> src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator V(Refinement<V,T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public Refinement(V value)
        {
            Value = value;
        }        
        public EnumScalarKind Kind 
        {
            [MethodImpl(Inline)]
            get => Enums.kind<V>();
        }

        public T Data 
        {
            [MethodImpl(Inline)]
            get => Enums.scalar<V,T>(Value);
        }
        
        public bool Equals(Refinement<V,T> src)
            => src.Value.Equals(Value);

        public override bool Equals(object src)
            => src is Refinement<V,T> r && Equals(r);
        public string Format()
            => Value.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Value.GetHashCode();
    }
}