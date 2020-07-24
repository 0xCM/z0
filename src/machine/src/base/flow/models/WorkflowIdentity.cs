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

    public readonly struct WorkflowIdentity
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
        public static WorkflowIdentity<T> define<T>(PartId part)
            where T : struct
                => new WorkflowIdentity<T>(part);

        [MethodImpl(Inline)]
        public static WorkflowIdentity define(PartId part, Type host)
            => new WorkflowIdentity(part, host);

        [MethodImpl(Inline)]
        public static WorkflowIdentity define(Type host)
            => new WorkflowIdentity(host);

        [MethodImpl(Inline)]
        public WorkflowIdentity(PartId part, Type host)
        {
            PartId = (byte)part;
            Host = host;
        }        

        [MethodImpl(Inline)]
        public WorkflowIdentity(Type host)
        {
            PartId = (byte)host.Assembly.Id();
            Host = host;
        }
    }
}