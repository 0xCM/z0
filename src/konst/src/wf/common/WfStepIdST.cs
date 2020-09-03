//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Identifies a workflow step
    /// </summary>
    public readonly struct WfStepId<S,T> : IWfStepId
        where S : struct
        where T : struct
    {
        public const string RenderPattern = "{0} -> {1}";

        [MethodImpl(Inline)]
        public static implicit operator WfType<S,T>(WfStepId<S,T> src)
            => src.Type;

        [MethodImpl(Inline)]
        public static implicit operator WfToken(WfStepId<S,T> src)
            => src.Token;

        [MethodImpl(Inline)]
        public static implicit operator Type(WfStepId<S,T> src)
            => WfType<S,T>.Type;

        /// <summary>
        /// The step name
        /// </summary>
        public string Name
            => text.format(RenderPattern, typeof(S).Name, typeof(T).Name);

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

        public WfType<S,T> Type
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
            => Name;

        [MethodImpl(Inline)]
        public string Format(bool full)
            => text.format(RenderPattern, typeof(S).AssemblyQualifiedName, typeof(T).AssemblyQualifiedName);

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => default(WfType<S,T>).Hashed;
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