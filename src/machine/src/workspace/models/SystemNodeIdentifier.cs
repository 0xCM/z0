//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Identifies a <see cref="SystemNode"/>
    /// </summary>
    public sealed class SystemNodeIdentifier  : IIdentified<string>
    {
        public string Id {get;}                         
    
        public static implicit operator SystemNodeIdentifier(string x)
            => new SystemNodeIdentifier(x);

        [MethodImpl(Inline)]
        public static implicit operator string(SystemNodeIdentifier src)
            => src.Id;

        public SystemNodeIdentifier New(string IdentifierText)
            => new SystemNodeIdentifier(IdentifierText ?? string.Empty);

        [MethodImpl(Inline)]
        public SystemNodeIdentifier(string id)
        {
            Id = id;
        }                    
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.blank(Id);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public static bool IsLocal(string id)
            => string.Equals(id, "Node00", StringComparison.InvariantCultureIgnoreCase)
            || string.Equals(id, "n00", StringComparison.InvariantCultureIgnoreCase);

        public static SystemNodeIdentifier Local
            => SystemNode.Local.NodeIdentifier;
    }
}