//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;

    /// <summary>
    /// Specifies a md token
    /// </summary>
    public struct token
    {
        public uint Value {get;}

        public uint Kind {get;}
    }

    /// <summary>
    /// Specifies a sequence of bytes, otherwise known as a BLOB
    /// </summary>
    public struct bytes
    {
        public ulong Location{get;}

        public bytes(ulong location)
            => Location = location;

        public static implicit operator FK<bytes>(bytes src)
            => new FK<bytes>(src.Location);
    }

    /// <summary>
    /// Specifies a sequence of 128 bits, otherwise known as a <see cref='Guid'/>
    /// </summary>
    public struct guid
    {
        public ulong Location {get;}

        public guid(ulong location)
            => Location = location;

        public static implicit operator FK<guid>(guid src)
            => new FK<guid>(src.Location);
    }

    /// <summary>
    /// Specifies a <see cref='char'/> sequence
    /// </summary>
    public struct chars
    {
        public ulong Location {get;}

        public chars(ulong location)
            => Location = location;

        public static implicit operator FK<chars>(chars src)
            => new FK<chars>(src.Location);
    }

    public struct name
    {
        public ulong Location {get;}

        public name(ulong location)
            => Location = location;

        public static implicit operator FK<name>(name src)
            => new FK<name>(src.Location);

        public static implicit operator chars(name src)
            => new chars(src.Location);
    }

    public struct sig
    {
        public ulong Location {get;}

        public sig(ulong location)
            => Location = location;

        public static implicit operator FK<sig>(sig src)
            => new FK<sig>(src.Location);

        public static implicit operator bytes(sig src)
            => new bytes(src.Location);
    }
}