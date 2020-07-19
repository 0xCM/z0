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
        [MethodImpl(Inline)]
        public static WorkflowIdentity define<T>()
            where T : struct
        {
            var t = type<T>();
            var id = t.Assembly.Id();
            return new WorkflowIdentity(id, t.Name);
        }
        
        [MethodImpl(Inline)]
        public static WorkflowIdentity define(PartId part, string host)
            => new WorkflowIdentity(part,host);

        /// <summary>
        /// Specifies the lower 8 bits of the part identifier
        /// </summary>
        public readonly byte Part;

        /// <summary>
        /// Specifies the name of the reifying type
        /// </summary>
        public readonly StringRef Host;

        [MethodImpl(Inline)]
        public WorkflowIdentity(PartId part, string host)
        {
            Part = (byte)part;
            Host = host;
        }        
    }
}