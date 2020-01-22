//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct AsmDescriptor
    {
        public static AsmDescriptor Define(AsmUri uri, MemoryRange origin)        
            => new AsmDescriptor(uri, origin);

        public static AsmDescriptor Define(string catalog, string subject, Moniker id, MemoryRange origin)        
            => new AsmDescriptor(AsmUri.Define(catalog,subject, id), origin);

        AsmDescriptor(AsmUri uri, MemoryRange origin)
        {
            this.Uri = uri;
            this.Origin = origin;
        }

        public readonly AsmUri Uri;

        public readonly MemoryRange Origin;

        public string Format()
            => concat(Uri.ToString(), Origin.Format());

        public override string ToString()
            => Format();
    }

}