//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    static class RootShare
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        public static bool IdentityEquals(string lhs, string rhs)
            => string.Equals(lhs, rhs, StringComparison.InvariantCultureIgnoreCase);        

        [MethodImpl(Inline)]
        public static bool IdentityEquals(IIdentity lhs, object rhs)
            => rhs is IIdentity i && IdentityEquals(lhs.Identifier, i.Identifier);        

        [MethodImpl(Inline)]
        public static bool IdentityEquals<T>(in T lhs, in T rhs)
            where T : struct, IIdentity<T>
                => IdentityEquals(lhs.Identifier, rhs.Identifier);   

        [MethodImpl(Inline)]
        public static int IdentityHashCode<T>(in T src)     
            where T : struct, IIdentity<T>
                => src.Identifier.GetHashCode();

        [MethodImpl(Inline)]
        public static NotSupportedException unsupported(object value)
            => new NotSupportedException($"{value}");
    }


    public static partial class RootKindExtensions
    {


    }
}