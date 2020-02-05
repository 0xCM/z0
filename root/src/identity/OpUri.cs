//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public readonly struct OpUri : IEquatable<OpUri>, IComparable<OpUri>, IIdentity<OpUri>
    {
        public readonly string Catalog;

        public readonly string Subject;

        public readonly OpIdentity OpId;

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static string DefineUriText(string scheme, string catalog, string subject, string group, OpIdentity opid)
            => $"{scheme}://{catalog}/{subject}?{group}{opid.Identifier}";

        [MethodImpl(Inline)]
        public static bool operator==(OpUri a, OpUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpUri a, OpUri b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static OpUri Asm(string catalog, string subject, OpIdentity opid)        
            => new OpUri("asm", catalog, subject, string.Empty, opid);

        [MethodImpl(Inline)]
        public static OpUri Asm(string catalog, string subject, string group, OpIdentity opid)        
            => new OpUri("asm", catalog, subject, group, opid);

        [MethodImpl(Inline)]
        OpUri(string scheme, string catalog, string subject, string group, OpIdentity opid)
        {
            this.Catalog = catalog;
            this.Subject = subject;
            this.OpId = opid;
            var groupPart = string.IsNullOrWhiteSpace(group) ? string.Empty : $"{group}#";
            this.Identifier = DefineUriText(scheme, catalog, subject,groupPart,opid);
        }
        
        public string Format()
            => Identifier;
        
        [MethodImpl(Inline)]
        public bool Equals(OpUri src)
            => IdentityEquals(this, src);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityEquals(this, obj);

        [MethodImpl(Inline)]
        public int CompareTo(OpUri other)
            => IdentityCompare(this, other);
    }
}