//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct AsmDescriptor : IEquatable<AsmDescriptor>, IComparable<AsmDescriptor>
    {
        public readonly AsmUri Uri;

        public readonly MemoryRange Origin;

        [MethodImpl(Inline)]
        public static bool operator==(AsmDescriptor a, AsmDescriptor b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(AsmDescriptor a, AsmDescriptor b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static AsmDescriptor Define(AsmUri uri, MemoryRange origin)        
            => new AsmDescriptor(uri, origin);

        [MethodImpl(Inline)]
        public static AsmDescriptor Define(string catalog, string subject, Moniker id, MemoryRange origin)        
            => new AsmDescriptor(AsmUri.Define(catalog,subject, id), origin);

        [MethodImpl(Inline)]
        AsmDescriptor(AsmUri uri, MemoryRange origin)
        {
            this.Uri = uri;
            this.Origin = origin;
        }

        public string Format()
            => concat(Uri.ToString(), Origin.Format());

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => HashCode.Combine(Uri,Origin);

        [MethodImpl(Inline)]
        public bool Equals(AsmDescriptor src)
            => Uri == src.Uri && Origin == src.Origin;
        
        public override bool Equals(object src)
            => src is AsmDescriptor d && Equals(d);

        [MethodImpl(Inline)]
        public int CompareTo(AsmDescriptor rhs)
            => Origin.CompareTo(rhs.Origin);
    }

}