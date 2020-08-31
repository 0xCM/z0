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

    public interface IWfStepId<H> : IComparable<H>, IEquatable<H>, INamed<H>, ITextual
        where H : struct, IWfStepId<H>
    {
        /// <summary>
        /// The Step controller
        /// </summary>
        Type Control {get;}

        /// <summary>
        /// The Step implementation
        /// </summary>
        Type Effect {get;}

        /// <summary>
        /// The step token
        /// </summary>
        WfToken Token
        {
            [MethodImpl(Inline)]
            get => AB.token(WfPartKind.Step, Effect);
        }

        bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Effect == null || Effect.IsEmpty();
        }

        bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Effect != null && !Effect.IsEmpty();
        }

        string ITextual.Format()
            => Effect.Name;


        [MethodImpl(Inline)]
        bool Equals(WfStepId src)
            => Effect == src.Effect;

        [MethodImpl(Inline)]
        int CompareTo(WfStepId src)
            => (src.IsEmpty || IsEmpty)? 0 : Effect.FullName.CompareTo(src.Effect.FullName);


        [MethodImpl(Inline)]
        string Format(bool full)
            => full ? Effect.FullName : Effect.Name;
        uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)Effect.GetHashCode();
        }
    }
}