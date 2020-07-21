//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static Konst;
    
    partial class Identity
    {
        /// <summary>
        /// Assigns identity to each value parameter (not to be confused with type parametricity) declared by a metod
        /// </summary>
        /// <param name="src">The source method</param>
        static IEnumerable<string> VaueParamIdentities(MethodInfo src)
        {
            var args = src.GetParameters();
            var argtypes = src.ParameterTypes(true);
            for(var i=0; i<argtypes.Length; i++)
            {                                
                var argtext = Identity.ParameterTypeIdentity(args[i]);
                if(argtext.IsNotBlank())
                    yield return argtext;
            }
        }

        /// <summary>
        /// Assigns identitity to each type argument supplied to close a generic method
        /// </summary>
        /// <param name="src">The constructed generic method</param>
        static IEnumerable<string> TypeArgIdentities(MethodInfo src)
            => src.GenericArguments().Select(targ => Identity.identify(targ).Identifier);

        /// <summary>
        /// Assigns aggregate identity to the type argument segquence that closes a generic method
        /// </summary>
        /// <param name="src">The constructed generic method</param>
        static string TypeArgIdentity(MethodInfo src)
            => SequenceIdentity(IDI.TypeArgsOpen, IDI.TypeArgsClose, IDI.ArgSep, TypeArgIdentities(src));

        /// <summary>
        /// Assigns aggregate identity to a method's value parameter sequence
        /// </summary>
        /// <param name="src">The source method</param>
        static string ValueParamIdentity(MethodInfo src)
            => SequenceIdentity(IDI.ArgsOpen, IDI.ArgsClose, IDI.ArgSep, VaueParamIdentities(src));

        /// <summary>
        /// Assigns aggregate identity to an identity sequence
        /// </summary>
        /// <param name="open">The left fence</param>
        /// <param name="close">The right fence</param>
        /// <param name="sep">The sequence element delimiter</param>
        /// <param name="src">The source sequence</param>
        static string SequenceIdentity(char open, char close, char sep, IEnumerable<string> src)
            => text.concat(open, string.Join(sep,src), close);
    }
}