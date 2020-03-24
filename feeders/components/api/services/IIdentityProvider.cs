//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    /// <summary>
    /// Specifies what it means to be an identifier
    /// </summary>
    public interface IIdentified
    {        
        string Identifier {get;}

        bool IsEmpty 
        {
            get => string.IsNullOrWhiteSpace(Identifier);
        }               
    }

    public interface IIdentityProvider
    {
        IdentityTargetKind ProviderKind {get;}   

        IIdentified Identify(object src);
    }

    /// <summary>
    /// Characterizes a serviice capable of assigning identity to T-values
    /// </summary>
    /// <typeparam name="T">The subject of</typeparam>
    public interface IIdentifier<T> : IIdentityProvider
    {
        IIdentified Identify(T src);

        IIdentified IIdentityProvider.Identify(object src)
            => Identify((T)src);
    }

    public interface ITypeIdentifier : IIdentifier<Type>
    {
        IdentityTargetKind IIdentityProvider.ProviderKind 
            => IdentityTargetKind.Type;
    }

    public interface IMethodIdentifier : IIdentifier<MethodInfo>
    {
        IdentityTargetKind IIdentityProvider.ProviderKind 
            => IdentityTargetKind.Method;        
    }

    public interface IIdentityProvider<S,T> : IIdentifier<S>
        where T : IIdentified
    {

    }
}