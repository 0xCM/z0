//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Threading;
    using System.Linq;

    using static zfunc;

    public interface IRecord
    {
        /// <summary>
        /// Returns a line of text represents the record value
        /// </summary>
        string DelimitedText(char delimiter);

        IReadOnlyList<string> GetHeaders();

        
    }

    public class ColInfoAttribute : Attribute
    {
        public ColInfoAttribute(string Name, string desc = "", int Width = 0)
        {
            this.Name = Name;
            this.Desc = desc;
            this.Width = Width == 0 ? (int?)null : Width;
        }
        
        public string Name {get;}

        public string Desc {get;}
        
        public int? Width {get;}
    }
    

    public interface IRecord<T> : IRecord
    {
        IReadOnlyList<string> Headers
        {
            get 
            {
                var headers = new List<string>();
                headers.AddRange(type<T>().DeclaredFields().Instance(). Select(f => f.Name));
                headers.AddRange(type<T>().DeclaredProperties().Instance().Select(f => f.Name));
                return headers;                                
            }
        }
    }


}