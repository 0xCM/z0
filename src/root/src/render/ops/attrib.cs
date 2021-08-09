//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RP
    {
        /// <summary>
        /// Renders an attribute '{name}:{value};
        /// </summary>
        /// <param name="name">The attribute name</param>
        /// <param name="value">The attribute value</param>
        [Op]
        public static string attrib(string name, object value)
            => string.Format(Attrib, name, denullify(value));

        /// <summary>
        /// Renders an attribute '{name,{pad}}:{value}
        /// </summary>
        /// <param name="name">The attribute name</param>
        /// <param name="value">The attribute value</param>
        [Op]
        public static string attrib(int pad, string name, object value)
            => string.Format(Attrib, string.Format(RP.pad(pad), name), denullify(value));
    }
}