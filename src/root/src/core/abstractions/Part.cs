//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    public readonly struct PartResolution
    {
        public static bool resolve(Type type, out IPart part)
        {
            try
            {
                part = (IPart)Activator.CreateInstance(type);
                return true;
            }
            catch(Exception)
            {
                part = default;
                return false;
            }
        }

        public const string ResolutionProperty = "Resolved";
    }

    public readonly struct PartResolution<P>
        where P : Part<P>, IPart<P>, new()
    {
        public P Resolved => new P();
    }

    public abstract class Part<P> : IPart<P>
        where P : Part<P>, IPart<P>, new()
    {
        public PartId Id {get;}

        public static Assembly Assembly
            => typeof(P).Assembly;

        public Assembly Owner {get;}

        /// <summary>
        /// The resolved part
        /// </summary>
        public static P Resolved
            => new P();

        protected Part()
        {
            Owner = typeof(P).Assembly;
            Id =  id(Owner);
        }

        [MethodImpl(Inline)]
        public static bool operator ==(Part<P> p1, Part<P> p2)
            => p1.Id == p2.Id;

        [MethodImpl(Inline)]
        public static bool operator !=(Part<P> p1, Part<P> p2)
            => p1.Id != p2.Id;

        [MethodImpl(Inline)]
        public bool Equals(P src)
            => Id == src.Id;

        public override bool Equals(object src)
            => src is P x && Equals(x);
        public uint Hash
        {
            [MethodImpl(Inline)]
            get => hash(Id);
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public string Format()
            => format(Id);

        public override string ToString()
            => Format();
    }
}