//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;

    using static Root;

    public interface IIdentityProvider
    {
        IdentityTargetKind ProviderKind {get;}   
    }
    
    public interface IIdentityProvider<S,T> : IIdentityProvider
        where T : IIdentity
    {

    }

    public interface ITypeIdentityProvider : IIdentityProvider<Type,TypeIdentity>
    {
        TypeIdentity DefineIdentity(Type src);        

        IdentityTargetKind IIdentityProvider.ProviderKind => IdentityTargetKind.Type;

        IEnumerable<Type> Identifiable 
            => array<Type>();
    }

    /// <summary>
    /// Characterizes a type identity provider than can define an identity predicated on a parametric type
    /// </summary>
    /// <typeparam name="T">The type for which identity will be defined</typeparam>
    public interface ITypeIdentityProvider<T> : ITypeIdentityProvider
    {
        TypeIdentity DefineIdentity();
        
        IEnumerable<Type> ITypeIdentityProvider.Identifiable
            => array(typeof(T));

        TypeIdentity ITypeIdentityProvider.DefineIdentity(Type src)
            => DefineIdentity();
    }    

    public interface ITypeIdentityProviders : IAppService
    {
        ITypeIdentityProvider Find(Type src, Func<Type,ITypeIdentityProvider> fallback);
    }
    public interface IOpIdentity : IIdentity
    {

    }
    
    public interface IOpIdentity<T> : IOpIdentity, IIdentity<T>
        where T : IOpIdentity<T>, new()    
    {
        Func<string,T> Factory {get;}
    }

    public interface IOpIdentityProvider : IIdentityProvider<MethodInfo,OpIdentity>
    {
        IdentityTargetKind IIdentityProvider.ProviderKind => IdentityTargetKind.Method;

        OpIdentity DefineIdentity(MethodInfo method);

        OpIdentity GroupIdentity(MethodInfo method);                    

        OpIdentity GenericIdentity(MethodInfo method);                    

        OpIdentity DefineIdentity(MethodInfo method, NumericKind k);
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
}