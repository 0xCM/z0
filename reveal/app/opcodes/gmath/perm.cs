//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmathops
    {
        public static Perm4 perm4_assemble_id()
            => Perm.assemble(Perm4.A, Perm4.B, Perm4.C, Perm4.D);

        public static Perm4 perm4_assemble_rid()
            => Perm.assemble(Perm4.D, Perm4.C, Perm4.B, Perm4.A);

    }

}