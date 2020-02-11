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

    using static RootShare;

    [Flags]
    public enum HostedOpKind
    {
        None = 0,

        Direct = 1,

        Generic = 2,

        Service = 4,

        DirectAndGeneric = Direct | Generic
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ApiHostAttribute : Attribute
    {
        public ApiHostAttribute(string Name, HostedOpKind opkind)
        {
            this.Name = Name;
            this.OpKind = opkind;
        }

        public ApiHostAttribute(HostedOpKind opkind)
        {
            this.Name = string.Empty;
            this.OpKind = opkind;
        }

        public ApiHostAttribute(string Name)
            : this(Name, HostedOpKind.DirectAndGeneric)
        {
        }

        public ApiHostAttribute()
            : this(string.Empty, HostedOpKind.DirectAndGeneric)
        {
        }

        public string Name {get;}


        public HostedOpKind OpKind {get;}

    }

    public readonly struct ApiHost
    {
        public static ApiHost Empty = new ApiHost(AssemblyId.None, typeof(void));
        
        [MethodImpl(Inline)]
        public static ApiHost Define(Type src)
            => new ApiHost(src.Assembly.AssemblyId(), src);

        [MethodImpl(Inline)]
        public static ApiHost Define(AssemblyId owner, Type src)
            => new ApiHost(owner, src);

        [MethodImpl(Inline)]
        public static IEnumerable<ApiHost> Define(AssemblyId owner, params Type[] src)
            => src.Select(t => Define(owner, t));

        [MethodImpl(Inline)]
        ApiHost(AssemblyId id, Type t)
        {
            this.Owner = id;
            this.HostingType = t;
            var name =  t.GetCustomAttribute<ApiHostAttribute>()?.Name;
            Name = string.IsNullOrEmpty(name) ? t.Name : name;
        }
        
        public readonly AssemblyId Owner;
        
        public readonly Type HostingType;

        public IEnumerable<MethodInfo> DeclaredMethods
            =>  HostingType.DeclaredMethods();

        public string Name {get;}
            // => $"{Owner.Format()}/{HostingType.Name.ToLower()}";

        public override string ToString() 
            => Name;

        public bool IsEmtpy => Owner == AssemblyId.None && HostingType == typeof(void);
        
    }
}