//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;


    partial class RngX
    {
        /// <summary>
        /// Produces a stream of values sampled from an enum
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static IEnumerable<E> EnumValues<E>(this IPolyrand random, Func<E,bool> filter)
            where E : unmanaged, Enum
        {
            IEnumerable<E> produce()
            {
                var names = Enum.GetNames(typeof(E)).Mapi((index, name) => (index, name)).ToDictionary();
                var domain = zfunc.domain(0, names.Count);
                var stream = random.Stream(domain);

                while(true)
                {   
                    var name = names[stream.First()];
                    var value = Enum.Parse<E>(name);
                    if(filter != null)
                    {
                        if(filter(value))
                            yield return value;
                    }
                    else
                        yield return value;
                }            
            }

            return stream(produce(), random.RngKind);
        }

        /// <summary>
        /// Produces a stream of enum values enum
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="exclusions">Enum literals to exclude</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static IEnumerable<E> EnumValues<E>(this IPolyrand random, params E[] exclusions)
            where E : unmanaged, Enum
        {
            IEnumerable<E> produce()
            {
                var excluded = exclusions.Select(x => x.ToString()).ToHashSet();
                var available = Enum.GetNames(typeof(E)).Where(n => !excluded.Contains(n)).ToArray();
                var names = available.Mapi((index, name) => (index, name)).ToDictionary();
                var stream = random.Stream(domain(0, names.Count));

                while(true)
                    yield return Enum.Parse<E>(names[stream.Next()]);
            }

            return stream(produce(), random.RngKind);
        }
    }
}

