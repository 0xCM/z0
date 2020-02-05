//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    

    public class IdentityProviderAttribute : Attribute
    {
        public IdentityProviderAttribute(Type host)
        {
            this.Host = host;
        }

        public Type Host;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class OpHostAttribute : Attribute
    {
        public OpHostAttribute(string Name, bool generic)
        {
            this.Name = Name;
            this.Generic = generic;
        }

        public OpHostAttribute(string Name)
            : this(Name, false)
        {
        }

        public OpHostAttribute()
            : this(string.Empty, false)
        {
        }

        public string Name {get;}


        public bool Generic {get;}

    }

    /// <summary>
    /// Identifies a formal operation for inclusing in the identity assignment and catalog system
    /// </summary>
    public class OpAttribute : Attribute
    {
        public string Name {get;}

        public bool ByRef {get;}

        public bool CombineCustomName {get;}
         
        public OpAttribute()
        {
            this.Name = string.Empty;
            this.ByRef = false;
            this.CombineCustomName = true;
        }

        public OpAttribute(string name, bool combine = true)
        {
            this.Name = name;
            this.ByRef = false;
            this.CombineCustomName = combine;
        }

        public override string ToString()
            => Name;
    }
}

