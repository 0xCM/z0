//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Defines a survey predicated on primal type evaluation
    /// </summary>
    /// <typeparam name="T">The primal survey representation type</typeparam>
    public class Survey<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public Survey(uint Id, string Name, params Question<T>[] Questions)
        {
            this.Id = Id;
            this.Name = Name;
            this.Questions = Questions;
        }

        public uint Id {get;}

        public string Name {get;}


        public IReadOnlyList<Question<T>> Questions {get;}

        public string Format()
        {
            var format = buildstring();
            format.AppendLine(Name);
            format.AppendLine(new string(AsciSym.Dash,80));
            Questions.Iterate(q => format.AppendLine(q.Format()));
            return format.ToString();
        }

        public override string ToString()
            => Name;   
    }
}