//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Relations;

    /// <summary>
    /// Specifies a sequence of bytes, otherwise known as a BLOB
    /// </summary>
    public struct bytes : IHeapRef<bytes>
    {
        public Token Id {get;}

        [MethodImpl(Inline)]
        public bytes(Token location)
            => Id = location;

        [MethodImpl(Inline)]
        public static implicit operator FK<BlobIndex>(bytes src)
            => new FK<BlobIndex>(src.Id);
    }

    /// <summary>
    /// Specifies a sequence of 128 bits, otherwise known as a <see cref='Guid'/>
    /// </summary>
    public struct guid : IHeapRef<guid>
    {
        public Token Id {get;}

        public guid(Token location)
            => Id = location;

        public static implicit operator FK<guid>(guid src)
            => new FK<guid>(src.Id);
    }

    /// <summary>
    /// Specifies a <see cref='char'/> sequence
    /// </summary>
    public struct chars : IHeapRef<chars>
    {
        public Token Id {get;}

        public chars(Token location)
            => Id = location;

        public static implicit operator FK<chars>(chars src)
            => new FK<chars>(src.Id);
    }

    public struct name
    {
        public Token Id {get;}

        public name(Token location)
            => Id = location;

        public static implicit operator FK<name>(name src)
            => new FK<name>(src.Id);

        public static implicit operator chars(name src)
            => new chars(src.Id);
    }

    public struct sig
    {
        public Token Id {get;}

        public sig(Token location)
            => Id = location;

        public static implicit operator FK<sig>(sig src)
            => new FK<sig>(src.Id);

        public static implicit operator bytes(sig src)
            => new bytes(src.Id);
    }
}