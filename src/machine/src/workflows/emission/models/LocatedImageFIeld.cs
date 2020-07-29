//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public enum LocatedImageField : ushort
    {
        ImagePath = 20,

        PartId = 12,

        EntryAddress = 16,

        BaseAddress = 16,

        EndAddress = 16,

        Size = 10,

        Gap = 10
    }
}