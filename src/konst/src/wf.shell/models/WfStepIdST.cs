//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    /// <summary>
    /// Identifies a workflow step
    /// </summary>
    public readonly struct WfStepId<S,T>
        where S : struct
        where T : struct
    {
        public const string RenderPattern = "{0} -> {1}";

        public string HostName
        {
            [MethodImpl(Inline)]
            get => text.format(RenderPattern, typeof(S).AssemblyQualifiedName, typeof(T).AssemblyQualifiedName);
        }

        [MethodImpl(Inline)]
        public static implicit operator LinkType<S,T>(WfStepId<S,T> src)
            => src.Type;

        [MethodImpl(Inline)]
        public static implicit operator WfToken(WfStepId<S,T> src)
            => src.Token;

        /// <summary>
        /// The step controller
        /// </summary>
        public Type Source
            => typeof(T);

        /// <summary>
        /// The step effector
        /// </summary>
        public Type Target
            => typeof(S);

        public LinkType<S,T> Type
            => default;

        /// <summary>
        /// The step token
        /// </summary>
        public WfToken Token
        {
            [MethodImpl(Inline)]
            get => new WfToken(hash<S,T>());
        }

        [MethodImpl(Inline)]
        public bool Equals(WfStepId<S,T> src)
            => true;

        [MethodImpl(Inline)]
        public int CompareTo(WfStepId<S,T> src)
            => 0;

        [MethodImpl(Inline)]
        public string Format()
            => HostName;

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => default(LinkType<S,T>).Hashed;
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => hash<S,T>();
        }

        public override int GetHashCode()
            => (int)Hashed;


        public override bool Equals(object src)
            => src is WfStepId x && Equals(x);

        public override string ToString()
            => Format();
    }
}