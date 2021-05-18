//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a catalog over <see cref='ApiMember'/> values for a specified <see cref='IApiHost'/>
    /// </summary>
    public readonly struct ApiHostCatalog
    {
        public IApiHost Host {get;}

        public ApiMembers Members {get;}

        [MethodImpl(Inline)]
        internal ApiHostCatalog(IApiHost host, ApiMembers src)
        {
            Host = host;
            Members = src;
        }

        public MemoryAddress MinAddress
        {
            [MethodImpl(Inline)]
            get => IsNonEmpty ? Members[0].BaseAddress : 0;
        }

        public MemoryAddress MaxAddress
        {
            [MethodImpl(Inline)]
            get =>  IsNonEmpty ? Members[MemberCount - 1].BaseAddress : 0;
        }

        /// <summary>
        /// The defining part
        /// </summary>
        public PartId Part
        {
            [MethodImpl(Inline)]
            get => Host.PartId;
        }

        public Count MemberCount
        {
            [MethodImpl(Inline)]
            get => Members.Count;
        }

        /// <summary>
        /// The defining part
        /// </summary>
        public Type HostType
        {
            [MethodImpl(Inline)]
            get => Host.HostType;
        }

        public ReadOnlySpan<ApiMember> MemberView
        {
            [MethodImpl(Inline)]
            get => Members.View;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Members.Count == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Members.Count != 0;
        }

        // public Index<ApiMemberInfo> Describe()
        //     => root.map(Members, m => m.Describe());

        public static ApiHostCatalog Empty
        {
            [MethodImpl(Inline)]
            get => new ApiHostCatalog(ApiHost.Empty, ApiMembers.Empty);
        }
    }
}