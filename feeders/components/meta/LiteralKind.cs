//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// Characterizes type classifiers predicated on enumerations
    /// </summary>
    /// <typeparam name="E">The enum type that defines the classifier superset</typeparam>
    public interface ITypedLiteral<E> : IClassifier
        where E : unmanaged, Enum
    {
        E Class {get;}

        string Name => Class.ToString().ToLower();
    }

    /// <summary>
    /// Characterizes numerically-parametric typed literals
    /// </summary>
    /// <typeparam name="E">The enum type that defines the classifier superset</typeparam>
    /// <typeparam name="V">The numeric type refined by the enum</typeparam>
    public interface ITypedLiteral<E,V> : ITypedLiteral<E>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        V Value {get;}
    }

    /// <summary>
    /// Characterizes typed literals that support kind partitioning
    /// </summary>
    /// <typeparam name="E">The classifying enum type</typeparam>
    public interface ILiteralKind<E> : IKind, ITypedLiteral<E>
        where E : unmanaged, Enum
    {

    }


    /// <summary>
    /// Characterizes numerically-parametric typed literals that support kind partitioning
    /// </summary>
    /// <typeparam name="E">The classifying enum type</typeparam>
    public interface ILiteralKind<E,T> : ILiteralKind<E>, INumericKind<T>
        where T : unmanaged
        where E : unmanaged, Enum

    {

    }    

    /// <summary>
    /// Characterizes a F-bound polymorphic literal reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="E">T literal type</typeparam>
    public interface ILiteral<F,E> : ILiteralKind<E>
        where F : ILiteral<F,E>, new()
        where E : unmanaged, Enum
    {}

    public readonly struct Literal<F,E> : ILiteral<Literal<F, E>, E>
        where E : unmanaged, Enum
    {
        [MethodImpl(Inline)]
        public Literal(E @class)
        {
            this.Class = @class;
        }

        public E Class {get;}
    }

    /// <summary>
    /// Characterizes a T-parametric F-bound polymorphic literal reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="E">T literal type</typeparam>
    public interface ILiteral<F,E,T> : ILiteral<F,E>, ILiteralKind<E,T>
        where F : ILiteral<F,E,T>, new()
        where E : unmanaged, Enum
        where T : unmanaged
    {


    }

    public static class TypedLiteral
    {
        /// <summary>
        /// Produces an enum literal given its value
        /// </summary>
        /// <param name="v">The value to reinterpret</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        [MethodImpl(Inline)]
        internal static unsafe E literal<E,V>(V v)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<E>((E*)&v);

        /// <summary>
        /// Reads a numeric value from an enum. 
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        internal static unsafe V numeric<E,V>(E e)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<V>((V*)(&e));

        /// <summary>
        /// Creates a typed literal from an enumeration literal
        /// </summary>
        /// <typeparam name="E">The enumeration type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E> From<E>(E @class)
            where E : unmanaged, Enum
                => @class;
        
        /// <summary>
        /// Creates a numeric-parametric typed literal from a numeric value
        /// </summary>
        /// <param name="value">The numeric value</param>
        /// <param name="e">An enum representative to aid type inference</param>
        /// <typeparam name="E">An enumeration type that refines the parametric numeric type</typeparam>
        /// <typeparam name="V">The numeric type refined by the enum</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,V> From<E,V>(V value, E e = default)
            where E : unmanaged, Enum
            where V : unmanaged
                => new TypedLiteral<E,V>(literal<E,V>(value));

        /// <summary>
        /// Creates a numeric-parametric typed literal from an enumeration literal
        /// </summary>
        /// <param name="@class">The enum litera value</param>
        /// <param name="v">An numeric representative to aid type inference</param>
        /// <typeparam name="E">An enumeration type that refines the parametric numeric type</typeparam>
        /// <typeparam name="V">The numeric type refined by the enum</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteral<E,V> From<E,V>(E @class, V v = default)
            where E : unmanaged, Enum
            where V : unmanaged
                => new TypedLiteral<E,V>(@class);
    }

    /// <summary>
    /// Lifts an enumeration literal to a type
    /// </summary>
    public readonly struct TypedLiteral<E> : ITypedLiteral<E>
        where E : unmanaged, Enum
    {
        [MethodImpl(Inline)]
        public static implicit operator E(TypedLiteral<E> t)
            => t.Class;

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E>(E @class)
            => new TypedLiteral<E>(@class);
        
        [MethodImpl(Inline)]
        public TypedLiteral(E @class)
        {
            this.Class = @class;
        }

        public E Class {get;}
    }

    /// <summary>
    /// A numeric-parametric typed literal
    /// </summary>
    /// <typeparam name="E">An enumeration type that refines the parametric numeric type</typeparam>
    /// <typeparam name="V">The numeric type refined by the enum</typeparam>
    public readonly struct TypedLiteral<E,V> : ITypedLiteral<E,V>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator E(TypedLiteral<E,V> t)
            => t.Class;

        [MethodImpl(Inline)]
        public static implicit operator V(TypedLiteral<E,V> t)
            => t.Value;

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E,V>(E @class)
            => new TypedLiteral<E,V>(@class);

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E,V>(V value)
            => TypedLiteral.From<E,V>(value);

        [MethodImpl(Inline)]
        public static implicit operator TypedLiteral<E>(TypedLiteral<E,V> src)
            => TypedLiteral.From<E>(src.Class);

        [MethodImpl(Inline)]
        public TypedLiteral(E @class)
        {
            this.Class = @class;
            this.Value = TypedLiteral.numeric<E,V>(@class);
        }

        [MethodImpl(Inline)]
        public TypedLiteral(V value)
        {
            this.Class = TypedLiteral.literal<E,V>(value);
            this.Value = value;
        }

        /// <summary>
        /// The classifying literal
        /// </summary>
        public E Class {get;}

        /// <summary>
        /// The numeric value of the classifier
        /// </summary>
        public V Value {get;}
    }
}