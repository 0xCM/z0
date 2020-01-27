//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Collections.Generic;
    
    using static zfunc;    

    class Catalog : OpCatalog<Catalog>
    {
        public Catalog(AssemblyId id)
             : base(id)
        {

        }
        
        public override IEnumerable<Type> DirectApiHosts
            => items(typeof(LogicOpApi), typeof(LogicOps));

        public override IEnumerable<Type> GenericApiHosts
            => items(
                typeof(BitMatrixOpApi), typeof(BitMatrixOps), 
                typeof(BitVectorOpApi), typeof(BitVectorOps),
                typeof(ScalarOpApi), typeof(ScalarOps), 
                typeof(VectorizedOpApi), typeof(VectorizedOps),
                typeof(PredicateApi), typeof(LogicEngine),
                typeof(OpHelpers), typeof(CompareEval)
                );               
    }
}