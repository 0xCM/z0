//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a survey predicated on primal type evaluation
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public readonly ref struct Survey<T>
        where T : unmanaged
    {
        public readonly uint Id;

        public readonly string Name;

        public readonly Span<Question<T>> Questions;

        [MethodImpl(Inline)]
        public Survey(uint Id, string Name, params Question<T>[] Questions)
        {
            this.Id = Id;
            this.Name = Name;
            this.Questions = Questions;
        }

        public override string ToString()
            => Name;   
    }
}