//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Root;

    [AttributeUsage(AttributeTargets.Field)]
    class IdentityIndicatorAttribute : Attribute
    {
        public IdentityIndicatorAttribute(IdentityIndicatorKind kind)        
            => this.IndicatorKind = kind;
        
        public IdentityIndicatorKind IndicatorKind {get;}
    }
    
    /// <summary>
    /// Specifies what it means to be an identifier
    /// </summary>
    public interface IIdentity : ICustomFormattable, IComparable
    {
        string Identifier {get;}

        bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => text.empty(Identifier);
        }
        
        [MethodImpl(Inline)]
        string ICustomFormattable.Format()
            => text.denullify(Identifier);

        [MethodImpl(Inline)]
        int IComparable.CompareTo(object src)
            => text.denullify(Identifier).CompareTo((src as IIdentity)?.Identifier);
    }

    /// <summary>
    /// Specifies what it means to be a reified identifier
    /// </summary>
    public interface IIdentity<T> :  IIdentity, IEquatable<T>, IFormattable<T>, IComparable<T>
        where T : IIdentity<T>, new()
    {
        [MethodImpl(Inline)]
        bool IEquatable<T>.Equals(T src)
            => text.equals(Identifier, src?.Identifier);

        [MethodImpl(Inline)]
        int IComparable<T>.CompareTo(T src)
            => text.denullify(Identifier).CompareTo(src?.Identifier); 
    }    

    public interface IIdentityProvider
    {
        IdentityKind ProviderKind {get;}   
    }
    
    public interface IIdentityProvider<S,T> : IIdentityProvider
        where T : IIdentity
    {

    }

    public class IdentityProviderAttribute : Attribute
    {
        /// <summary>
        /// Use of this constructor implies that the attribution target is the provider
        /// </summary>
        public IdentityProviderAttribute()
        {
            Host = Option.none<Type>();
        }
        
        public IdentityProviderAttribute(Type host)
        {
            this.Host = host;
        }

        public Option<Type> Host;
    }    
    
    public static class IdentityProviders
    {
        public static ITypeIdentityProvider find(Type src, Func<Type,ITypeIdentityProvider> fallback)
            => TypeIdentityProviders.GetOrAdd(src.EffectiveType(), fallback);

        public static IOpIdentityProvider find(Type src, Func<IOpIdentityProvider> fallback)
            => OpIdentityProviders.GetOrAdd(src.EffectiveType(),t => fallback());

        static ConcurrentDictionary<Type, IOpIdentityProvider> OpIdentityProviders 
            = new ConcurrentDictionary<Type, IOpIdentityProvider>();

        static ConcurrentDictionary<Type, ITypeIdentityProvider> TypeIdentityProviders 
            = new ConcurrentDictionary<Type, ITypeIdentityProvider>();
    }    
}