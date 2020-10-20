//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a directed association between two data members
    /// </summary>
    public class DataMemberArrow : IArrow<DataMember>
    {
        /// <summary>
        /// The supplier member
        /// </summary>
        public readonly DataMember Source;

        /// <summary>
        /// The client member
        /// </summary>
        public readonly DataMember Target;

        public string Identifier
            => text.concat(Source.Name, Colon, Source.DataType.Name, " -> ", Target.Name, Colon, Target.DataType.Name);

        [MethodImpl(Inline)]
        public DataMemberArrow(DataMember s, DataMember t)
        {
            Source = s;
            Target = t;
        }

        const char Colon = ':';

         DataMember IArrow<DataMember,DataMember>.Source
            => Source;

        DataMember IArrow<DataMember,DataMember>.Target
            => Target;

        public string Format()
            => Identifier;


        public override string ToString()
            => Format();
    }

    /// <summary>
    /// Defines a directed association between two value members defined by two respective types
    /// </summary>
    /// <typeparam name="X">The source type</typeparam>
    /// <typeparam name="Y">The target type</typeparam>
    public readonly struct DataMemberArrow<X,Y>
    {
        readonly DataMemberArrow  Arrow;

        [MethodImpl(Inline)]
        public static implicit operator DataMemberArrow(DataMemberArrow<X,Y> src)
            => src.Arrow;

        [MethodImpl(Inline)]
        public DataMemberArrow(DataMember s, DataMember t)
        {
            Arrow = new DataMemberArrow(s,t);
        }

        /// <summary>
        /// The supplier member
        /// </summary>
        public DataMember Source
        {
            [MethodImpl(Inline)]
            get => Arrow.Source;
        }

        /// <summary>
        /// The client member
        /// </summary>
        public DataMember Target
        {
            [MethodImpl(Inline)]
            get => Arrow.Target;
        }

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => Arrow.Identifier;
        }

        public string Format()
            => Arrow.Format();


        public override string ToString()
            => Format();
    }
}