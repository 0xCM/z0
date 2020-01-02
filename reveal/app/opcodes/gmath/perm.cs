//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class gmathops
    {
        public static Perm4L perm4_assemble_id()
            => Perms.assemble(Perm4L.A, Perm4L.B, Perm4L.C, Perm4L.D);

        public static Perm4L perm4_assemble_rid()
            => Perms.assemble(Perm4L.D, Perm4L.C, Perm4L.B, Perm4L.A);

    }

}