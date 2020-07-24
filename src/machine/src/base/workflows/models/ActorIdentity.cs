//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ActorIdentity
    {
        /// <summary>
        /// Specifies the lower 8 bits of the part identifier
        /// </summary>
        public readonly byte PartId;

        /// <summary>
        /// Specifies the name of the reifying type
        /// </summary>
        readonly Type Host;

        public string HostName
        {
            [MethodImpl(Inline)]
            get => Host.Name;
        }        

        public ArtifactIdentity HostId
        {
            [MethodImpl(Inline)]
            get => Host.MetadataToken;
        }        
        
        [MethodImpl(Inline)]
        public static ActorIdentity<T> define<T>(PartId part)
            where T : struct
                => new ActorIdentity<T>(part);

        [MethodImpl(Inline)]
        public static ActorIdentity define(PartId part, Type host)
            => new ActorIdentity(part, host);

        [MethodImpl(Inline)]
        public static ActorIdentity define(Type host)
            => new ActorIdentity(host);

        [MethodImpl(Inline)]
        public ActorIdentity(PartId part, Type host)
        {
            PartId = (byte)part;
            Host = host;
        }        

        [MethodImpl(Inline)]
        public ActorIdentity(Type host)
        {
            PartId = (byte)host.Assembly.Id();
            Host = host;
        }
    }
}