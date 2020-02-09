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
        const string AsmScheme = "asm";

        public readonly string Scheme;
        
        public readonly AssemblyId Catalog;

        public readonly string Subject;

        public readonly string GroupName;

        public readonly OpIdentity OpId;

        public string Identifier {get;}

        [MethodImpl(Inline)]
        public static string PathText(string scheme, AssemblyId catalog, string subject)
            => $"{scheme}://{catalog.Format()}/{subject}";

        [MethodImpl(Inline)]
        public static string QueryText(string scheme, AssemblyId catalog, string subject, string group)
            => $"{scheme}://{catalog.Format()}/{subject}?{group}";

        [MethodImpl(Inline)]
        public static string UriText(string scheme, AssemblyId catalog, string subject, string group, OpIdentity opid)
            => $"{scheme}://{catalog.Format()}/{subject}?{group}#{opid.Identifier}";

        [MethodImpl(Inline)]
        public static string AsmPathText(AssemblyId catalog, string subject)
            => PathText(AsmScheme, catalog, subject);

        [MethodImpl(Inline)]
        public static string AsmQueryText(AssemblyId catalog, string subject, string group)
            => QueryText(AsmScheme, catalog,subject,group);

        [MethodImpl(Inline)]
        public static string AsmUriText(AssemblyId catalog, string subject, string group, OpIdentity opid)
            => UriText(AsmScheme,catalog,subject,group,opid);

        [MethodImpl(Inline)]
        public static bool operator==(OpUri a, OpUri b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(OpUri a, OpUri b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static OpUri AsmOp(AssemblyId catalog, string subject, string group, OpIdentity opid)        
            => new OpUri("asm", catalog, subject, group, opid);

        [MethodImpl(Inline)]
        public static OpUri AsmGroup(AssemblyId catalog, string subject, string group)        
            => new OpUri("asm", catalog, subject, group, OpIdentity.Empty);

        [MethodImpl(Inline)]
        OpUri(string scheme, AssemblyId catalog, string subject, string group, OpIdentity opid)
        {
            this.Scheme = scheme;
            this.Catalog = catalog;
            this.Subject = subject;
            this.OpId = opid;
            this.GroupName = group;
            this.Identifier = opid.IsEmpty ? QueryText(scheme, catalog,subject,group) : UriText(scheme, catalog, subject, GroupName, opid);
        }
        
        public OpUri GroupUri
            => new OpUri(Scheme, Catalog, Subject, GroupName, OpIdentity.Empty);

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

        public int CompareTo(IIdentity other)
            => IdentityCompare(this, other);
    }
}