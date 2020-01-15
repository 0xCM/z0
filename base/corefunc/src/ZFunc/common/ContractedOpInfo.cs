//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;

    public class ContractedOpInfo
    {
        public static ContractedOpInfo Define(string name, Type host, IEnumerable<Moniker> reifications)
            => new ContractedOpInfo(name, host,reifications);

        public ContractedOpInfo(string name, Type host, IEnumerable<Moniker> reifications)
        {
            this.Name = name;
            this.Host = host;
            this.Reifications = reifications;
        }

        public string Name {get;}

        public Type Host {get;}

        public IEnumerable<Moniker> Reifications {get;}
    }
}