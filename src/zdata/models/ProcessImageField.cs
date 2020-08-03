//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum ProessImageField : ushort
    {
        ImageId = 20,

        PartId = 20,

        EntryAddress = 16,

        BaseAddress = 16,

        EndAddress = 16,

        Size = 10,

        Gap = 10
    }
}