//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Glues a generic method definition to a set of kinds that represent types over which the
    /// generic method can close
    /// </summary>
    public class GenericOp 
    {            
        /// <summary>
        /// The operation host to which generic definition and any concrete closures belowng
        /// </summary>
        public ApiHost Host {get;}
    
        /// <summary>
        /// The operation identity
        /// </summary>
        public GenericOpIdentity Id {get;}            

        public NumericKind[] Kinds {get;}

        public MethodInfo Definition {get;}

        [MethodImpl(Inline)]
        public static GenericOp Define(ApiHost host, GenericOpIdentity id, MethodInfo method, NumericKind[] kinds)            
            => new GenericOp(host, id,method, kinds);

        [MethodImpl(Inline)]
        GenericOp(ApiHost host, GenericOpIdentity id, MethodInfo method, NumericKind[] kinds)
        {
            this.Kinds = kinds;
            this.Host = host;
            this.Id = id;
            this.Definition = method;
        }
    }
}