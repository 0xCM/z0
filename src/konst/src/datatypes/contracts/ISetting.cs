//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Characterizes a nonparametric application setting
    /// </summary>
    public interface ISetting : ITextual
    {
        /// <summary>
        /// The setting name
        /// </summary>
        string Name {get;}

        /// <summary>
        /// The setting value
        /// </summary>
        string Value {get;}
    }

    public interface ISetting<K,V> : ISetting
    {
        new K Name {get;}

        new V Value {get;}

        string ISetting.Name
            => Name.ToString();

        string ISetting.Value
            => Value.ToString();
        string ITextual.Format()
            => Render.setting(Name,Value);
    }

    public interface ISetting<H,K,V> : ISetting<K,V>
        where H : struct, ISetting<H,K,V>
    {

    }
}