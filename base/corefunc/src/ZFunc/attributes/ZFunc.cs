//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    [AttributeUsage(AttributeTargets.Parameter)]
    public class ImmAttribute : Attribute
    {


    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ZFuncAttribute : Attribute
    {
        public ZFuncAttribute()
        {
            this.Name = string.Empty;
            this.Closures = PrimalKind.None;
        }

        public ZFuncAttribute(string name)
        {
            this.Name = name;
            this.Closures = PrimalKind.None;
        }
        
        public ZFuncAttribute(string name, PrimalKind closures)
        {
            this.Name = name;
            this.Closures = closures;
        }

        public ZFuncAttribute(PrimalKind closures)
        {
            this.Name = string.Empty;
            this.Closures = closures;
        }

        /// <summary>
        /// The root operation name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// Specifies the primal types over which the associated method can be closed, if generic;
        /// otherwise, ignored
        /// </summary>
        public PrimalKind Closures {get;}

        public override string ToString()
            =>  string.IsNullOrEmpty(Name) ? Moniker.primalsig(Closures) : Moniker.define(Name,Closures);
    }

}