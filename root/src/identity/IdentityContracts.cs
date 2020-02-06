//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static RootShare;

    public interface IIdentity : IComparable<IIdentity>
    {
        string Identifier {get;}

        bool IsEmpty 
            => string.IsNullOrWhiteSpace(Identifier);
    }

    public interface IIdentity<T> :  IIdentity, IEquatable<T>
        where T : struct, IIdentity<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool IEquatable<T>.Equals(T src)
            => IdentityEquals(Identifier,src.Identifier);        
    }

    public interface ITypeIdentity : IIdentity
    {

    }
    
    public interface ITypeIdentity<T> : ITypeIdentity, IIdentity<T>
        where T : struct, ITypeIdentity<T>    
    {

    }
    
    public interface IOpIdentity : IIdentity
    {

    }
    
    public interface IOpIdentity<T> : IOpIdentity, IIdentity<T>
        where T : struct, IOpIdentity<T>    
    {

    }    

    public interface IIdentityProvider
    {
        IdentityKind ProviderKind {get;}   
    }
    
    public interface IIdentityProvider<S,T> : IIdentityProvider
        where T : IIdentity
    {

    }

    public interface ITypeIdentityProvider : IIdentityProvider<Type,TypeIdentity>
    {
        TypeIdentity DefineIdentity(Type src);        

        IdentityKind IIdentityProvider.ProviderKind => IdentityKind.Type;
    }
    
    public interface IOpIdentityProvider : IIdentityProvider<MethodInfo,OpIdentity>
    {
        IdentityKind IIdentityProvider.ProviderKind => IdentityKind.Operation;

        OpIdentity DefineIdentity(MethodInfo method);

        OpIdentity GroupIdentity(MethodInfo method);                    

        OpIdentity GenericIdentity(MethodInfo method);                    

        OpIdentity DefineIdentity(MethodInfo method, NumericKind k);
    }

}        
