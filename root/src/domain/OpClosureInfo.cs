//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Captures identifying/descriptive information about a closure
    /// </summary>
    public class OpClosureInfo 
    {
        /// <summary>
        /// Creates a closure description
        /// </summary>
        /// <param name="id">The assigned identity</param>
        /// <param name="kind">The primal kind over which the subject was closed</param>
        /// <param name="closed">The closed method</param>
        public static OpClosureInfo Define(Moniker id, NumericKind kind, MethodInfo closed)
            => new OpClosureInfo(id,kind,closed);

        OpClosureInfo(Moniker id, NumericKind kind, MethodInfo method)
        {
            this.Id = id;
            this.Kind = kind;
            this.ClosedMethod = method;
        }
    
        /// <summary>
        /// The closure identity
        /// </summary>
        public Moniker Id {get;}

        /// <summary>
        /// The primal kind over which the subject operation was closed
        /// </summary>
        public NumericKind Kind {get;}

        /// <summary>
        /// The closed method
        /// </summary>
        public MethodInfo ClosedMethod {get;}

        public void Deconstruct(out Moniker id, out NumericKind k, out MethodInfo closed)
        {
            id = Id;
            k = Kind;
            closed = ClosedMethod;
        }
    }
}