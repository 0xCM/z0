//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Specifies a md token
    /// </summary>
    public struct token
    {
        public uint Value {get;}

        [MethodImpl(Inline)]
        public token(uint value)
            => Value = value;

        [MethodImpl(Inline)]
        public static implicit operator token(uint src)
            => new token(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(token src)
            => src.Value;
    }

    /// <summary>
    /// Specifies a sequence of bytes, otherwise known as a BLOB
    /// </summary>
    public struct bytes : IHeapRef<bytes>
    {
        public token Id {get;}

        [MethodImpl(Inline)]
        public bytes(token location)
            => Id = location;

        [MethodImpl(Inline)]
        public static implicit operator FK<bytes>(bytes src)
            => new FK<bytes>(src.Id);
    }

    /// <summary>
    /// Specifies a sequence of 128 bits, otherwise known as a <see cref='Guid'/>
    /// </summary>
    public struct guid : IHeapRef<guid>
    {
        public token Id {get;}

        public guid(token location)
            => Id = location;

        public static implicit operator FK<guid>(guid src)
            => new FK<guid>(src.Id);
    }

    /// <summary>
    /// Specifies a <see cref='char'/> sequence
    /// </summary>
    public struct chars : IHeapRef<chars>
    {
        public token Id {get;}

        public chars(token location)
            => Id = location;

        public static implicit operator FK<chars>(chars src)
            => new FK<chars>(src.Id);
    }

    public struct name
    {
        public token Id {get;}

        public name(token location)
            => Id = location;

        public static implicit operator FK<name>(name src)
            => new FK<name>(src.Id);

        public static implicit operator chars(name src)
            => new chars(src.Id);
    }

    public struct sig
    {
        public token Id {get;}

        public sig(token location)
            => Id = location;

        public static implicit operator FK<sig>(sig src)
            => new FK<sig>(src.Id);

        public static implicit operator bytes(sig src)
            => new bytes(src.Id);
    }
}