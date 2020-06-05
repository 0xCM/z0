//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed; 

    /// <summary>
    /// Describes the reason for a thing to be
    /// </summary>
    public class PurposeAttribute : Attribute
    {
        public PurposeAttribute(string description)
        {
            Description = text.denullify(description);
        }
        
        public string Description {get;}
    }

    public readonly struct Purpose
    {
        public string Description {get;}

        public static Purpose Get(MemberInfo src)
            => src.Tag<PurposeAttribute>().MapValueOrDefault(a => Some(a.Description), Without);
        
        static Purpose Without => new Purpose(string.Empty);

        [MethodImpl(Inline)]
        public static Purpose Some(string description)
            => new Purpose(description);
        
        [MethodImpl(Inline)]
        public Purpose(string description)
        {
            Description = text.denullify(description);
        }
        
        public bool None
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Description);
        }

        public bool Has
        {
            [MethodImpl(Inline)]
            get => !string.IsNullOrWhiteSpace(Description);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.denullify(Description);
    }
}