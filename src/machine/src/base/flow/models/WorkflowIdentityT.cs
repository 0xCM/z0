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

    public readonly struct WorkflowIdentity<T>
    {
        public readonly byte PartId;

        public string HostName
        {
            [MethodImpl(Inline)]
            get => typeof(T).Name;
        }

        public ArtifactIdentity HostId
        {
            [MethodImpl(Inline)]
            get => typeof(T).MetadataToken;
        }
 
        [MethodImpl(Inline)]
        public static implicit operator WorkflowIdentity(WorkflowIdentity<T> src)
            => new WorkflowIdentity((PartId)src.PartId, typeof(T));
        
        [MethodImpl(Inline)]
        public WorkflowIdentity(PartId part)
        {
            PartId = (byte)part;
        }
    }
}