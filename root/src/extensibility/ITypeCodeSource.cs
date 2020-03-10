//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    public interface ITypeCodeSource
    {
        AssemblyId Owner {get;}
        
        ulong[] AssignedCodes {get;}
    }
    
    public interface ITypeCodeSource<S> : ITypeCodeSource
        where S : struct, ITypeCodeSource<S>
    {
        AssemblyId ITypeCodeSource.Owner
            => typeof(S).Assembly.Id();     

        ulong[] ITypeCodeSource.AssignedCodes 
            => typeof(S).LiteralFields().Map(f => (ulong)f.GetRawConstantValue());
    }

}