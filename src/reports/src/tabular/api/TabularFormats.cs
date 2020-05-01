//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Seed;

    using F = TabularField;
    using A = TabularFieldAttribute;

    public class TabularFormats
    {    
        /// <summary>
        /// Derives format configuration data from a type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        public static TabularFormat derive<T>()
            => derive(typeof(T));        

        public static string[] headers<T>()
            => derive<T>().Headers;

        /// <summary>
        /// Derives field information from a reflected member
        /// </summary>
        /// <param name="src">The source member</param>
        public static TabularField field(MemberInfo src)
            => src.Tag<TabularFieldAttribute>()
                  .MapRequired(attrib => new TabularField(attrib.Name, attrib.Index, attrib.Width));

        public static TabularFormat derive(Type src)
        {
            var props = from p in src.DeclaredProperties().Instance()
                        where p.Tagged<A>()
                        select field(p);

            var fields = from f in src.DeclaredFields().Instance()
                        where f.Tagged<A>()
                        select field(f);
            
            var members = props.Union(fields).OrderBy(x => x.Index).ToArray();
            return new TabularFormat(members, headers(members));
        }

        public static string[] headers(F[] fields)
        {
            var count = fields.Length;
            var headers = new string[count];

            for(var i=0; i<count; i++)
            {
                var field = fields[i];
                if(i == 0)
                    headers[i] = field.Name.PadRight(field.Width);
                else if(i == count - 1)
                    headers[i] = string.Concat(Chars.Space, field.Name);
                else
                    headers[i] = string.Concat(Chars.Space, field.Name.PadRight(field.Width));        
            }
            return headers;
        }
    }
}