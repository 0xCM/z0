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

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ZFuncAttribute : Attribute
    {
        public ZFuncAttribute(string name, PrimalKind primal)
        {
            this.Name = name;
            this.Primal = primal;
        }

        public ZFuncAttribute(PrimalKind primal)
        {
            this.Name = string.Empty;
            this.Primal = primal;
        }

        public string Name {get;}

        public PrimalKind Primal {get;}

        public override string ToString()
            =>  string.IsNullOrEmpty(Name) ? Moniker.suffix(Primal) : Moniker.define(Name,Primal);
    }

}