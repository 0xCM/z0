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

    public readonly struct OpUri : IEquatable<OpUri>, IComparable<OpUri>
    {
        public readonly string Catalog;

        public readonly string Subject;

        public readonly OpIdentity OpId;

        public readonly string UriText;

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
            this.UriText = BuildUriText(scheme, catalog, subject,groupPart,opid);
            //concat(scheme, colon(), fslash(), fslash(), Catalog, fslash(), Subject, fslash(), groupPart, OpId.Identifier);
        }
        
        [MethodImpl(Inline)]
        static string BuildUriText(string scheme, string catalog, string subject, string group, OpIdentity opid)
            => $"{scheme}://{catalog}/{subject}?{group}{opid.Identifier}";

        public string Format()
            => UriText;
        
        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(OpUri src)
            => string.Compare(Format(), src.Format()) == 0;
        
        public override bool Equals(object obj)
            => obj is OpUri x && Equals(x);
         
        public override int GetHashCode()
            => HashCode.Combine(Catalog,Subject,OpId);

        [MethodImpl(Inline)]
        public int CompareTo(OpUri other)
            => this.UriText.CompareTo(other.UriText);
    }
}