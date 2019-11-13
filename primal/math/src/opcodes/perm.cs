//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class pmoc
    {
        public static Perm4 perm4_assemble_id()
            => Perm4Spec.assemble(Perm4.A, Perm4.B, Perm4.C, Perm4.D);

        public static Perm4 perm4_assemble_rid()
            => Perm4Spec.assemble(Perm4.D, Perm4.C, Perm4.B, Perm4.A);

    }

}