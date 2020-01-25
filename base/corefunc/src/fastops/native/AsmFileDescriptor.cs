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

    public readonly struct AsmFileDescriptor : IEquatable<AsmFileDescriptor>, IComparable<AsmFileDescriptor>
    {
        public readonly AsmUri Uri;

        public readonly MemoryRange Origin;

        [MethodImpl(Inline)]
        public static bool operator==(AsmFileDescriptor a, AsmFileDescriptor b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(AsmFileDescriptor a, AsmFileDescriptor b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static AsmFileDescriptor Define(AsmUri uri, MemoryRange origin)        
            => new AsmFileDescriptor(uri, origin);

        [MethodImpl(Inline)]
        public static AsmFileDescriptor Define(string catalog, string subject, Moniker id, MemoryRange origin)        
            => new AsmFileDescriptor(AsmUri.Define(catalog,subject, id), origin);

        [MethodImpl(Inline)]
        AsmFileDescriptor(AsmUri uri, MemoryRange origin)
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
        public bool Equals(AsmFileDescriptor src)
            => Uri == src.Uri && Origin == src.Origin;
        
        public override bool Equals(object src)
            => src is AsmFileDescriptor d && Equals(d);

        [MethodImpl(Inline)]
        public int CompareTo(AsmFileDescriptor rhs)
            => Origin.CompareTo(rhs.Origin);
    }

}